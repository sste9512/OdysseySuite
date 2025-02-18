import * as THREE from 'three';

import { TXI, TXIBlending, TXIPROCEDURETYPE } from './TXI';
// @ts-ignore
import * as dxtJs from "dxt-js";

import { OdysseyTexture } from "@/components/Aurora-Rendering/types/OdysseyTexture";
import { DDS_HEADER, DDS_MIPMAP } from './DDS';
import { Result } from '@/models/Result';

const TPCHeaderLength = 128;



// TODO : Figure out why mip maps are not being generated correctly

export interface ITPCObjectOptions {
    file?: Uint8Array,
    filename?: string,
    pack?: number;
}
export interface ITPCHeader {
    data_size: number;
    alpha_test: number;
    width: number;
    height: number;
    encoding: number;

    bytes_per_pixel: number;
    bits_per_pixel: number;
    min_data_size: number;
    compressed: boolean;
    has_alpha: boolean;
    format: PixelFormat;
    is_cube_map: boolean;
    faces: number;
    mip_map_count: number;
}

export enum ENCODING {
    GRAY = 1,
    RGB = 2,
    RGBA = 4,
    BGRA = 12
}



export class OdysseyCompressedTexture extends OdysseyTexture {
    material: THREE.Material;
    isCompressedTexture: boolean = true;

    constructor(mipmaps: ImageData[], width: number, height: number, format?: THREE.CompressedPixelFormat, type?: THREE.TextureDataType, mapping?: THREE.Mapping, wrapS?: THREE.Wrapping, wrapT?: THREE.Wrapping, magFilter?: THREE.TextureFilter, minFilter?: THREE.TextureFilter, anisotropy?: number, encoding?: THREE.TextureEncoding) {
        super(null, mapping, wrapS, wrapT, magFilter, minFilter, format, type, anisotropy, encoding);

        this.image = { width: width, height: height };
        this.mipmaps = mipmaps;

        // no flipping for cube textures
        // (also flipping doesn't work for compressed textures )

        this.flipY = false;

        // can't generate mipmaps for compressed textures
        // mips must be embedded in DDS files

        this.generateMipmaps = false;
    }

    static fromDDS(mipmaps: DDS_MIPMAP[], width: number, height: number, format?: THREE.CompressedPixelFormat, type?: THREE.TextureDataType, mapping?: THREE.Mapping, wrapS?: THREE.Wrapping, wrapT?: THREE.Wrapping, magFilter?: THREE.TextureFilter, minFilter?: THREE.TextureFilter, anisotropy?: number, encoding?: THREE.TextureEncoding): Result<OdysseyCompressedTexture, Error> {
        try {
            const mipmapsIntermediate = mipmaps.map(mipmap => {
                const imageData = new ImageData(new Uint8ClampedArray(mipmap.data), mipmap.width, mipmap.height);
                return imageData;
            });

            const texture = new OdysseyCompressedTexture(mipmapsIntermediate, width, height, format, type, mapping, wrapS, wrapT, magFilter, minFilter, anisotropy, encoding);
            return { ok: true, value: texture };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }

}

export enum PixelFormat {
    R8G8B8 = 1,
    B8G8R8 = 2,
    R8G8B8A8 = 3,
    B8G8R8A8 = 4,
    A1R5G5B5 = 5,
    R5G6B5 = 6,
    Depth16 = 7,
    DXT1 = 8,
    DXT3 = 9,
    DXT5 = 10
};

/**
 * Class TPC represents a texture processing system for handling texture data.
 * This includes reading texture headers, handling mipmaps, DDS data extraction,
 * and animated textures.
 */
export class TPC {

    header: ITPCHeader;
    txi: TXI = new TXI('');
    file: Uint8Array;
    filename: string;
    pack: number;

    canvas: OffscreenCanvas[] = [];


    // Example usage
    // const result = await this.findTPC(resRef);
    //       const tpc = new TPCObject({
    //         filename: resRef, // the name of the texture file
    //         file: result.buffer, // actual binary data
    //         pack: result.pack, // this is the texture pack reference, meaning the different packages of erf files that contain the textures
    //       });

    constructor(args = {} as ITPCObjectOptions) {

        const _default: ITPCObjectOptions = {} as ITPCObjectOptions;

        const options = { ..._default, ...args };

        this.file = options.file;
        this.filename = options.filename;
        this.pack = options.pack;
        this.header = this.readHeader();
        this.txi = new TXI(this.getTXIData());

    }

    static loadFromBytes(bytes: Uint8Array, args: ITPCObjectOptions): Result<TPC, Error> {
        try {
            let tpc = new TPC();
            tpc.file = bytes;
            const headerResult = tpc.readHeaderFromBytes(bytes);   
            if (!headerResult.ok) {
                return { ok: false, error: headerResult.error };
            }
            tpc.header = headerResult.value;
            tpc.txi = new TXI(tpc.getTXIData());
            return { ok: true, value: tpc };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }


    /**
     * Extracts and returns the TXI data from a binary file. The method calculates the offset and length
     * of the TXI section within the file and reads its content character by character until a null
     * character is encountered or the data ends.
     *
     * @return {string} The TXI data as a string. Returns an empty string if the TXI data length is zero
     *                  or an error occurs during processing.
     */
    getTXIData(): string {

        try {
            let _txiOffset = this.getDataLength() + TPCHeaderLength;
            let _txiDataLength = this.file.length - _txiOffset;

            if (_txiDataLength > 0) {
                let txiReader = new BinaryReader(this.file.slice(_txiOffset, _txiOffset + _txiDataLength));
                let txiData = '';
                let ch;

                while ((ch = txiReader.readChar() || '\0').charCodeAt(0) != 0)
                    txiData = txiData + ch;

                return txiData;
            } else {
                return '';
            }
        } catch (e) {
            console.error('getTXIData', e);
            return '';
        }

    }

    getMIPMaps() {

    }

    /**
     * Parses and retrieves the DDS (DirectDraw Surface) texture from the file data.
     * The method processes header information and handles both compressed and uncompressed formats,
     * including mipmap and cubemap textures. Additionally, it supports the reconstruction of animated textures
     * if the input file describes a procedure-based texture cycle.
     *
     * @param {boolean} compressMipMaps If true, compresses the mipmaps using DXT compression formats. Defaults to true.
     * @return {Object} An object representing the DDS texture, with the following properties:
     *     - mipmaps: An array of mipmap levels, each containing texture data, width, and height.
     *     - width: The width of the texture.
     *     - height: The height of the texture.
     *     - format: The texture format (e.g., RGBAFormat, RGB_S3TC_DXT1_Format, etc.).
     *     - mipmapCount: The total number of mipmap levels.
     *     - isCubemap: A boolean indicating if the texture is a cubemap.
     */



    static tryGetDDS(tpc: TPC, compressMipMaps: boolean = true): Result<DDS_HEADER, string> {
        try {
            const header: DDS_HEADER = {
                dwSize: 124,
                dwFlags: 0x1 | 0x2 | 0x4 | 0x1000, // DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT
                dwHeight: tpc.header?.height || 0,
                dwWidth: tpc.header?.width || 0,
                dwPitchOrLinearSize: 0,
                dwDepth: 0,
                dwMipMapCount: tpc.header?.mip_map_count || 0,
                dwReserved1: Array(11).fill(0),
                ddspf: {
                    dwSize: 32,
                    dwFlags: 0,
                    dwFourCC: 0,
                    dwRGBBitCount: 0,
                    dwRBitMask: 0,
                    dwGBitMask: 0,
                    dwBBitMask: 0,
                    dwABitMask: 0
                },
                dwCaps: 0x1000, // DDSCAPS_TEXTURE
                dwCaps2: tpc.header?.is_cube_map ? 0xFE00 : 0, // Set cubemap flags if needed
                dwCaps3: 0,
                dwCaps4: 0,
                dwReserved2: 0,
                isCubemap: tpc.header?.is_cube_map,
                mipmaps: []
            };

            if (!tpc.header.compressed) {
                // Uncompressed
                switch (tpc.header.encoding) {
                    case ENCODING.GRAY:
                        // 8bpp grayscale
                        break;
                    case ENCODING.RGB:
                        header.ddspf.dwFourCC = 0x31545844; // DXT1
                        break;
                    case ENCODING.RGBA:
                        header.ddspf.dwFourCC = 0x35545844; // DXT5
                        break;
                    case ENCODING.BGRA:
                        header.ddspf.dwFourCC = 0x31545844; // DXT1
                        break;
                }
            } else {
                switch (tpc.header.encoding) {
                    case ENCODING.RGB:
                        // S3TC DXT1
                        header.ddspf.dwFourCC = 0x31545844; // DXT1
                        break;
                    case ENCODING.RGBA:
                        // S3TC DXT5
                        header.ddspf.dwFourCC = 0x35545844; // DXT5
                        break;
                }
            }

            header.dwMipMapCount = tpc.header.mip_map_count;
            header.isCubemap = tpc.header.is_cube_map;
            header.dwWidth = tpc.header.width;
            header.dwHeight = tpc.header.height;

            let dataOffset = TPCHeaderLength;

            //Detect Animated Textures
            if (tpc.txi.procedureType == 1) {
                tpc.header.faces = tpc.txi.numx * tpc.txi.numy;
                header.dwWidth = tpc.header.width / tpc.txi.numx;
                header.dwHeight = tpc.header.height / tpc.txi.numy;
                header.dwMipMapCount = TPC.generateMipMapCount(tpc, header.dwWidth, header.dwHeight);
            }

            for (let face = 0; face < tpc.header.faces; face++) {
                let width = header.dwWidth;
                let height = header.dwHeight;
                let dataSize = tpc.header.data_size;
                let dataLength = 0;
                let byteArray = new Uint8Array(0);

                for (let i = 0; i < header.dwMipMapCount; i++) {
                    if (!tpc.header.compressed) {
                        dataLength = width * height * tpc.header.min_data_size;
                        const rawBuffer = tpc.file.slice(dataOffset, dataOffset + dataLength);
                        if (tpc.header.encoding == ENCODING.RGB) {
                            byteArray = new Uint8Array((rawBuffer.length / 3) * 4);
                            let n = 4 * width * height;
                            let s = 0, d = 0;
                            while (d < n) {
                                byteArray[d++] = rawBuffer[s++];
                                byteArray[d++] = rawBuffer[s++];
                                byteArray[d++] = rawBuffer[s++];
                                byteArray[d++] = 255;
                            }
                        } else {
                            byteArray = rawBuffer;
                        }
                    } else {
                        if (tpc.header.encoding == ENCODING.RGB) {
                            dataLength = Math.max(tpc.header.min_data_size, width * height * 0.5);
                            dataLength = Math.max(tpc.header.min_data_size, Math.floor((width + 3) / 4) * Math.floor((height + 3) / 4) * tpc.header.min_data_size);
                        } else if (tpc.header.encoding == ENCODING.RGBA) {
                            dataLength = Math.max(tpc.header.min_data_size, Math.floor((width + 3) / 4) * Math.floor((height + 3) / 4) * tpc.header.min_data_size);
                        }
                        byteArray = tpc.file.slice(dataOffset, dataOffset + dataLength);
                        if (!compressMipMaps) {
                            byteArray = dxtJs.decompress(byteArray, width, height, tpc.header.encoding == ENCODING.RGB ? dxtJs.flags.DXT1 : dxtJs.flags.DXT5);
                        }
                    }

                    header.mipmaps.push({
                        data: byteArray,
                        width: width,
                        height: height,
                        pitchOrLinearSize: 0,
                        depth: 0
                    });

                    dataOffset += dataLength;

                    width = Math.max(width >> 1, 1);
                    height = Math.max(height >> 1, 1);
                    dataSize = Math.max(dataSize >> 2, tpc.header.min_data_size);
                }
            }

            console.log(header.mipmaps);

            return { ok: true, value: header };
        } catch (err) {
            return { ok: false, error: `Failed to get DDS: ${err}` };
        }
    }


    static getDDS(tpc: TPC, compressMipMaps: boolean = true): DDS_HEADER {
        const header: DDS_HEADER = {
            dwSize: 124,
            dwFlags: 0x1 | 0x2 | 0x4 | 0x1000, // DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT
            dwHeight: tpc.header?.height || 0,
            dwWidth: tpc.header?.width || 0,
            dwPitchOrLinearSize: 0,
            dwDepth: 0,
            dwMipMapCount: tpc.header?.mip_map_count || 0,
            dwReserved1: Array(11).fill(0),
            ddspf: {
                dwSize: 32,
                dwFlags: 0,
                dwFourCC: 0,
                dwRGBBitCount: 0,
                dwRBitMask: 0,
                dwGBitMask: 0,
                dwBBitMask: 0,
                dwABitMask: 0
            },
            dwCaps: 0x1000, // DDSCAPS_TEXTURE
            dwCaps2: tpc.header?.is_cube_map ? 0xFE00 : 0, // Set cubemap flags if needed
            dwCaps3: 0,
            dwCaps4: 0,
            dwReserved2: 0,
            isCubemap: tpc.header?.is_cube_map,
            mipmaps: []
        };



        // Set format flags based on compression and encoding
        // if (tpc.header?.compressed) {
        //     header.dwFlags |= 0x80000; // DDSD_LINEARSIZE
        //     header.ddspf.dwFlags = 0x4; // DDPF_FOURCC


        //     switch (tpc.header.encoding) {
        //         case ENCODING.RGB:
        //             header.ddspf.dwFourCC = 0x31545844; // DXT1
        //             break;


        //         case ENCODING.RGBA:
        //             header.ddspf.dwFourCC = 0x35545844; // DXT5
        //             break;
        //     }
        // } else {
        //     header.dwFlags |= 0x8; // DDSD_PITCH
        //     header.ddspf.dwFlags = 0x40; // DDPF_RGB

        //     switch (tpc.header.encoding) {
        //         case ENCODING.RGB:
        //             header.ddspf.dwRGBBitCount = 24;

        //             header.ddspf.dwRBitMask = 0xff0000;
        //             header.ddspf.dwGBitMask = 0x00ff00;
        //             header.ddspf.dwBBitMask = 0x0000ff;
        //             break;

        //         case ENCODING.RGBA:
        //         case ENCODING.BGRA:
        //             header.ddspf.dwFlags |= 0x1; // DDPF_ALPHAPIXELS
        //             header.ddspf.dwRGBBitCount = 32;
        //             header.ddspf.dwRBitMask = 0xff0000;
        //             header.ddspf.dwGBitMask = 0x00ff00;
        //             header.ddspf.dwBBitMask = 0x0000ff;
        //             header.ddspf.dwABitMask = 0xff000000;
        //             break;
        //     }
        // }

        // // Set mipmap flags if present
        // if (tpc.header?.mipMapCount > 1) {
        //     header.dwFlags |= 0x20000; // DDSD_MIPMAPCOUNT
        //     header.dwCaps |= 0x400000 | 0x8; // DDSCAPS_COMPLEX | DDSCAPS_MIPMAP
        // }
        header.dwMipMapCount = tpc.header.mip_map_count;
        header.isCubemap = tpc.header.is_cube_map;
        header.dwWidth = tpc.header.width;
        header.dwHeight = tpc.header.height;

        let dataOffset = TPCHeaderLength;

        //Detect Animated Textures
        if (tpc.txi.procedureType == 1) {
            tpc.header.faces = tpc.txi.numx * tpc.txi.numy;
            header.dwWidth = tpc.header.width / tpc.txi.numx;
            header.dwHeight = tpc.header.height / tpc.txi.numy;
            header.dwMipMapCount = TPC.generateMipMapCount(tpc, header.dwWidth, header.dwHeight);
        }

        for (let face = 0; face < tpc.header.faces; face++) {

            let width = header.dwWidth;
            let height = header.dwHeight;
            let dataSize = tpc.header.data_size;
            let dataLength = 0;
            let byteArray = new Uint8Array(0);

            for (let i = 0; i < header.dwMipMapCount; i++) {

                if (!tpc.header.compressed) {
                    dataLength = width * height * tpc.header.min_data_size;
                    const rawBuffer = tpc.file.slice(dataOffset, dataOffset + dataLength);
                    if (tpc.header.encoding == ENCODING.RGB) {
                        byteArray = new Uint8Array((rawBuffer.length / 3) * 4);
                        let n = 4 * width * height;
                        let s = 0, d = 0;
                        while (d < n) {
                            byteArray[d++] = rawBuffer[s++];
                            byteArray[d++] = rawBuffer[s++];
                            byteArray[d++] = rawBuffer[s++];
                            byteArray[d++] = 255;
                        }
                    } else {
                        byteArray = rawBuffer;
                    }
                } else {
                    if (tpc.header.encoding == ENCODING.RGB) {
                        dataLength = Math.max(tpc.header.min_data_size, width * height * 0.5);
                        dataLength = Math.max(tpc.header.min_data_size, Math.floor((width + 3) / 4) * Math.floor((height + 3) / 4) * tpc.header.min_data_size);
                    } else if (tpc.header.encoding == ENCODING.RGBA) {
                        dataLength = Math.max(tpc.header.min_data_size, Math.floor((width + 3) / 4) * Math.floor((height + 3) / 4) * tpc.header.min_data_size);
                    }
                    byteArray = tpc.file.slice(dataOffset, dataOffset + dataLength);
                    if (!compressMipMaps) {
                        byteArray = dxtJs.decompress(byteArray, width, height, tpc.header.encoding == ENCODING.RGB ? dxtJs.flags.DXT1 : dxtJs.flags.DXT5);
                    }
                }

                header.mipmaps.push({
                    data: byteArray,
                    width: width,
                    height: height,
                    pitchOrLinearSize: 0,
                    depth: 0
                });

                dataOffset += dataLength;

                width = Math.max(width >> 1, 1);
                height = Math.max(height >> 1, 1);
                dataSize = Math.max(dataSize >> 2, tpc.header.min_data_size);

            }
        }

        console.log(header.mipmaps);

        return header;
    }

    /**
     * Calculates the total number of mipmap levels required for a texture based on its width and height.

     *
     * @param {number} [width=0] - The initial width of the texture. Defaults to 0.
     * @param {number} [height=0] - The initial height of the texture. Defaults to 0.
     * @return {number} The total count of mipmap levels for the given texture dimensions.
     */
    static generateMipMapCount(tpc: TPC, width = 0, height = 0) {
        let nWidth = width;
        let nHeight = height;
        let dataSize = 0;
        let running = true;
        let mips = 0;

        let multiplier = (tpc.header.encoding == ENCODING.RGB) ? 0.5 : 1;

        while (running) {
            let mipMapSize = Math.max((nWidth * nHeight) * multiplier, tpc.header.min_data_size);
            //console.log(nWidth, nHeight, mipMapSize);
            dataSize += mipMapSize;//Math.max( dataSize >> 2, this.header.minDataSize );
            if (nWidth == 1 && nHeight == 1) {
                running = false;
            }
            nWidth = Math.max(nWidth >> 1, 1);
            nHeight = Math.max(nHeight >> 1, 1);
            mips += 1;
        }
        return mips;
    }

    /**
     * Reads and parses the header data of a TPC file, extracting image properties, encoding information, and related metadata.
     *
     * @return {ITPCHeader} An object containing metadata about the image, such as dimensions, encoding, format, compression status, and other attributes.
     */
    readHeader(): ITPCHeader {

        // Parse header
        let Header: ITPCHeader = {} as ITPCHeader;
        let Reader = new BinaryReader(this.file.slice(0, TPCHeaderLength));
        Reader.seek(0);
        Header.data_size = Reader.readUInt32();
        Header.alpha_test = Reader.readSingle();

        // Image dimensions
        Header.width = Reader.readUInt16();
        Header.height = Reader.readUInt16();

        // How's the pixel data encoded?
        Header.encoding = Reader.readByte();

        // Number of mip maps in the image
        Header.mip_map_count = Math.max(1, Reader.readByte());

        Header.bytes_per_pixel = 4;
        Header.bits_per_pixel = (Header.bytes_per_pixel * 8);

        Header.min_data_size = 0;
        Header.compressed = false;
        Header.has_alpha = false;

        if (Header.data_size == 0) {
            // Uncompressed
            Header.compressed = false;
            switch (Header.encoding) {
                case ENCODING.GRAY:
                    Header.has_alpha = false;
                    Header.format = PixelFormat.R8G8B8;
                    Header.min_data_size = 1;
                    Header.data_size = Header.width * Header.height;
                    break;
                case ENCODING.RGB:
                    Header.has_alpha = false;
                    Header.format = PixelFormat.R8G8B8;
                    Header.min_data_size = 3;
                    Header.data_size = Header.width * Header.height * 3;
                    break;
                case ENCODING.RGBA:
                    Header.has_alpha = true;
                    Header.format = PixelFormat.R8G8B8A8;
                    Header.min_data_size = 4;
                    Header.data_size = Header.width * Header.height * 4;
                    break;
                case ENCODING.BGRA:
                    Header.has_alpha = true;
                    Header.format = PixelFormat.B8G8R8A8;
                    Header.min_data_size = 4;
                    Header.data_size = Header.width * Header.height * 4;
                    break;
                default:
                    console.error('TPCObject', Header);
                    throw 'Unknown';
            }
        } else {
            switch (Header.encoding) {
                case ENCODING.RGB:
                    // S3TC DXT1
                    Header.compressed = true;
                    Header.has_alpha = false;
                    Header.format = PixelFormat.DXT1;
                    Header.min_data_size = 8;
                    break;
                case ENCODING.RGBA:
                    // S3TC DXT5
                    Header.compressed = true;
                    Header.has_alpha = true;
                    Header.format = PixelFormat.DXT5;
                    Header.min_data_size = 16;
                    break;
                default:
                    console.error('TPCObject', Header);
            }
        }

        // Extract mipmaps buffers
        Header.is_cube_map = false;
        if ((Header.height / Header.width) == 6) {
            Header.is_cube_map = true;
            Header.height = Header.width;
        }

        Header.faces = Header.is_cube_map ? 6 : 1;

        return Header;

    }


    readHeaderFromBytes(bytes: Uint8Array): Result<ITPCHeader> {
        try {
            // Parse header
            const Header: ITPCHeader = {} as ITPCHeader;
            const reader = new DataView(bytes.buffer);
            let offset = 0;
            Header.data_size = reader.getUint32(offset, true);
            offset += 4;
            Header.alpha_test = reader.getFloat32(offset, true);

            // Image dimensions
            Header.width = reader.getUint16(offset, true);
            offset += 2;
            Header.height = reader.getUint16(offset, true);
            offset += 2;

            // How's the pixel data encoded?
            Header.encoding = reader.getUint8(offset);
            offset += 1;

            // Number of mip maps in the image
            Header.mip_map_count = Math.max(1, reader.getUint8(offset));
            offset += 1;

            Header.bytes_per_pixel = 4;
            Header.bits_per_pixel = (Header.bytes_per_pixel * 8);

            Header.min_data_size = 0;
            Header.compressed = false;
            Header.has_alpha = false;

            if (Header.data_size == 0) {
                // Uncompressed
                Header.compressed = false;
                switch (Header.encoding) {
                    case ENCODING.GRAY:
                        Header.has_alpha = false;
                        Header.format = PixelFormat.R8G8B8;
                        Header.min_data_size = 1;
                        Header.data_size = Header.width * Header.height;
                        break;
                    case ENCODING.RGB:
                        Header.has_alpha = false;
                        Header.format = PixelFormat.R8G8B8;
                        Header.min_data_size = 3;
                        Header.data_size = Header.width * Header.height * 3;
                        break;
                    case ENCODING.RGBA:
                        Header.has_alpha = true;
                        Header.format = PixelFormat.R8G8B8A8;
                        Header.min_data_size = 4;
                        Header.data_size = Header.width * Header.height * 4;
                        break;
                    case ENCODING.BGRA:
                        Header.has_alpha = true;
                        Header.format = PixelFormat.B8G8R8A8;
                        Header.min_data_size = 4;
                        Header.data_size = Header.width * Header.height * 4;
                        break;
                    default:
                        console.error('TPCObject', Header);
                        return { ok: false, error: new Error('Unknown encoding format') };
                }
            } else {
                switch (Header.encoding) {
                    case ENCODING.RGB:
                        // S3TC DXT1
                        Header.compressed = true;
                        Header.has_alpha = false;
                        Header.format = PixelFormat.DXT1;
                        Header.min_data_size = 8;
                        break;
                    case ENCODING.RGBA:
                        // S3TC DXT5
                        Header.compressed = true;
                        Header.has_alpha = true;
                        Header.format = PixelFormat.DXT5;
                        Header.min_data_size = 16;
                        break;
                    default:
                        console.error('TPCObject', Header);
                        return { ok: false, error: new Error('Unknown compressed encoding format') };
                }
            }

            // Extract mipmaps buffers
            Header.is_cube_map = false;
            if ((Header.height / Header.width) == 6) {
                Header.is_cube_map = true;
                Header.height = Header.width;
            }

            Header.faces = Header.is_cube_map ? 6 : 1;

            return { ok: true, value: Header };

        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error('Failed to read header from bytes') };
        }
    }

    getDataLength() {

        let dataLength = 0;

        for (let face = 0; face < this.header.faces; face++) {

            let width = this.header.width;
            let height = this.header.height;
            let data_size = this.header.data_size;

            for (let i = 0; i < this.header.mip_map_count; i++) {
                if (!this.header.compressed) {
                    dataLength += width * height * this.header.min_data_size;
                } else {
                    dataLength += data_size;
                }

                width = Math.max(width >> 1, 1);
                height = Math.max(height >> 1, 1);
                data_size = Math.max(data_size >> 2, this.header.min_data_size);
            }

        }

        return dataLength;

    }

    FlipY(pixelData: any) {
        let offset = 0;
        let stride = this.header.width * 4;

        if (pixelData == null)
            throw 'Missing pixelData'

        let unFlipped = Uint8Array.from(pixelData);

        for (let pos = unFlipped.length - stride; pos >= 0; pos -= stride) {
            pixelData.set(unFlipped.slice(pos, pos + stride), offset);
            offset += stride;
        }

        return pixelData;

    }


    /**
     * Prints a formatted table of DDS header information for debugging and inspection purposes.
     * @param tpc The TPC object to display DDS header information about
     */
    static printDDSProperties(ddsHeader: DDS_HEADER): void {
        console.group('DDS Header Information');
        console.table({


            flags: ddsHeader?.dwFlags,
            height: ddsHeader?.dwHeight,
            width: ddsHeader?.dwWidth,
            pitchOrLinearSize: ddsHeader?.dwPitchOrLinearSize,
            depth: ddsHeader?.dwDepth,
            mipMapCount: ddsHeader?.dwMipMapCount,
            pixelFormat: {
                size: ddsHeader?.ddspf.dwSize,
                flags: ddsHeader?.ddspf.dwFlags,
                fourCC: ddsHeader?.ddspf.dwFourCC,
                rgbBitCount: ddsHeader?.ddspf.dwRGBBitCount,
                rBitMask: ddsHeader?.ddspf.dwRBitMask,
                gBitMask: ddsHeader?.ddspf.dwGBitMask,
                bBitMask: ddsHeader?.ddspf.dwBBitMask,
                aBitMask: ddsHeader?.ddspf.dwABitMask
            },
            caps: ddsHeader?.dwCaps,
            caps2: ddsHeader?.dwCaps2,
            caps3: ddsHeader?.dwCaps3,
            caps4: ddsHeader?.dwCaps4,
            reserved2: ddsHeader?.dwReserved2
        });
        console.groupEnd();
    }

    /**
     * Prints a formatted table of all TPC properties for debugging and inspection purposes.
     * @param tpc The TPC object to display information about
     */
    static printProperties(tpc: TPC): void {
        console.group('TPC Properties');

        // File info
        console.group('File Information');
        console.table({
            filename: tpc.filename,
            pack: tpc.pack,
            fileSize: tpc.file.length
        });
        console.groupEnd();

        // Header info
        console.group('Header Information');
        console.table({
            width: tpc.header.width,
            height: tpc.header.height,
            data_size: tpc.header.data_size,
            encoding: ENCODING[tpc.header.encoding],
            mip_map_count: tpc.header.mip_map_count,
            bytes_per_pixel: tpc.header.bytes_per_pixel,
            bits_per_pixel: tpc.header.bits_per_pixel,
            compressed: tpc.header.compressed,
            has_alpha: tpc.header.has_alpha,
            alpha_test: tpc.header.alpha_test,
            format: PixelFormat[tpc.header.format],
            is_cube_map: tpc.header.is_cube_map,
            faces: tpc.header.faces
        });
        console.groupEnd();

        // TXI info if present
        if (tpc.txi.procedureType !== TXIPROCEDURETYPE.NONE || tpc.txi.blending !== TXIBlending.NONE) {
            console.group('TXI Information');
            console.table({
                procedureType: TXIPROCEDURETYPE[tpc.txi.procedureType],
                blending: TXIBlending[tpc.txi.blending],
                numX: tpc.txi.numx,
                numY: tpc.txi.numy,
                fps: tpc.txi.fps,
                filter: tpc.txi.filter
            });
            console.groupEnd();
        }

        console.groupEnd();
    }

    //Convert the TPC into a THREE.CompressedTexture for use in the engine
    static toCompressedTexture(tpc: TPC): Result<OdysseyCompressedTexture, Error> {
        let images = [];
        let result = TPC.tryGetDDS(tpc, true);
        let texDatas: DDS_HEADER;
        let _texture: OdysseyCompressedTexture | THREE.CanvasTexture;

        try {
            if (result.ok) {
                texDatas = result.value;
                let textureResult = OdysseyCompressedTexture.fromDDS(texDatas.mipmaps, texDatas.dwWidth, texDatas.dwHeight);
                if (textureResult.ok) {
                    _texture = textureResult.value;
                }
                else {
                    console.error(textureResult.error);
                    _texture = new THREE.CanvasTexture(tpc.canvas[0] as any);
                }
            }
            else {
                console.error(result.error);
                _texture = new THREE.CanvasTexture(tpc.canvas[0] as any);
            }


            // if(this.canvas.length){
            //   _texture = new THREE.CanvasTexture(this.canvas[0] as any);
            // }else{
            if (texDatas.isCubemap) {
                let faces = texDatas.mipmaps.length / texDatas.dwMipMapCount;
                for (let f = 0; f < faces; f++) {
                    images[f] = { mipmaps: [] } as any;

                    for (let i = 0; i < texDatas.dwMipMapCount; i++) {
                        images[f].mipmaps.push(texDatas.mipmaps[f * texDatas.dwMipMapCount + i]);
                        images[f].format = THREE.CubeReflectionMapping;//texDatas.format;
                        images[f].width = texDatas.dwWidth;
                        images[f].height = texDatas.dwHeight;


                        _texture.mipmaps = images[f].mipmaps;
                    }
                }
                (_texture as any).image = images;
                _texture.image.width = texDatas.dwWidth;
                _texture.image.height = texDatas.dwHeight;

            } else {
                _texture.image.width = texDatas.dwWidth;
                _texture.image.height = texDatas.dwHeight;
                _texture.mipmaps = texDatas.mipmaps;
            }

            // }

            _texture.name = tpc.filename;

            if (texDatas.dwMipMapCount === 1) {
                _texture.minFilter = THREE.LinearFilter;
            }


            _texture.format = texDatas.ddspf.dwFourCC as any;
            _texture.needsUpdate = true;
            (_texture as any).bumpMapType = 'NORMAL';


            (_texture as any).header = tpc.header;
            (_texture as any).pack = tpc.pack;
            (_texture as any).txi = null;

            (_texture as any).txi = tpc.txi;

            (_texture as any).clone = function () {
                let cloned = new this.constructor().copy(this);
                cloned.format = this.format;
                cloned.needsUpdate = true;
                cloned.bumpMapType = this.bumpMapType;
                cloned.header = this.header;
                cloned.txi = tpc.txi;
                return this;
            };
        }
        catch (error) {
            return { ok: false, error: error as Error };
        }

        return { ok: true, value: _texture as OdysseyCompressedTexture };
    }

}

