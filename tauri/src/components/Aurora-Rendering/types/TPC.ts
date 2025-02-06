import * as THREE from 'three';

import { TXI } from './TXI';
// @ts-ignore
import * as dxtJs from "dxt-js";

import {OdysseyTexture} from "@/components/Aurora-Rendering/types/OdysseyTexture";
import { DDS_HEADER } from './DDS';

const TPCHeaderLength = 128;

export interface ITPCObjectOptions {
    file?: Uint8Array,
    filename?: string,
    pack?: number;
}
export interface ITPCHeader {
    dataSize: number;
    alphaTest: number;
    width: number;
    height: number;
    encoding: number;
    mipMapCount: number;
    bytesPerPixel: number;
    bitsPerPixel: number;
    minDataSize: number;
    compressed: boolean
    hasAlpha: boolean
    format: PixelFormat;
    isCubemap: boolean;
    faces: number;
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

    constructor(mipmaps: ImageData[], width: number, height: number, format?: THREE.CompressedPixelFormat, type?: THREE.TextureDataType, mapping?: THREE.Mapping, wrapS?: THREE.Wrapping, wrapT?: THREE.Wrapping, magFilter?: THREE.TextureFilter, minFilter?: THREE.TextureFilter, anisotropy?: number, encoding?: THREE.TextureEncoding){
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

    constructor ( args = {} as ITPCObjectOptions ) {

        const _default: ITPCObjectOptions = {} as ITPCObjectOptions;

        const options = {..._default, ...args};

        this.file = options.file;
        this.filename = options.filename;
        this.pack = options.pack;
        this.header = this.readHeader();
        this.txi = new TXI( this.getTXIData() );

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

        try{
            let _txiOffset = this.getDataLength() + TPCHeaderLength;
            let _txiDataLength = this.file.length - _txiOffset;

            if (_txiDataLength > 0){
                let txiReader = new BinaryReader(this.file.slice(_txiOffset, _txiOffset + _txiDataLength ));
                let txiData = '';
                let ch;

                while ((ch = txiReader.readChar() || '\0').charCodeAt(0) != 0)
                    txiData = txiData + ch;

                return txiData;
            }else{
                return '';
            }
        }catch(e){
            console.error('getTXIData', e);
            return '';
        }

    }

    getMIPMaps(){

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






    getDDS( compressMipMaps: boolean = true ): DDS_HEADER {
        const header: DDS_HEADER = {
            dwSize: 124,
            dwFlags: 0x1 | 0x2 | 0x4 | 0x1000, // DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT
            dwHeight: this.header?.height || 0,
            dwWidth: this.header?.width || 0,
            dwPitchOrLinearSize: 0,
            dwDepth: 0,
            dwMipMapCount: this.header?.mipMapCount || 0,
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
            dwCaps2: this.header?.isCubemap ? 0xFE00 : 0, // Set cubemap flags if needed
            dwCaps3: 0,
            dwCaps4: 0,
            dwReserved2: 0
        };

        

        // Set format flags based on compression and encoding
        if (this.header?.compressed) {
            header.dwFlags |= 0x80000; // DDSD_LINEARSIZE
            header.ddspf.dwFlags = 0x4; // DDPF_FOURCC
            

            switch(this.header.encoding) {
                case ENCODING.RGB:
                    header.ddspf.dwFourCC = 0x31545844; // DXT1
                    break;


                case ENCODING.RGBA:
                    header.ddspf.dwFourCC = 0x35545844; // DXT5
                    break;
            }
        } else {
            header.dwFlags |= 0x8; // DDSD_PITCH
            header.ddspf.dwFlags = 0x40; // DDPF_RGB

            switch(this.header.encoding) {
                case ENCODING.RGB:
                    header.ddspf.dwRGBBitCount = 24;

                    header.ddspf.dwRBitMask = 0xff0000;
                    header.ddspf.dwGBitMask = 0x00ff00;
                    header.ddspf.dwBBitMask = 0x0000ff;
                    break;

                case ENCODING.RGBA:
                case ENCODING.BGRA:
                    header.ddspf.dwFlags |= 0x1; // DDPF_ALPHAPIXELS
                    header.ddspf.dwRGBBitCount = 32;
                    header.ddspf.dwRBitMask = 0xff0000;
                    header.ddspf.dwGBitMask = 0x00ff00;
                    header.ddspf.dwBBitMask = 0x0000ff;
                    header.ddspf.dwABitMask = 0xff000000;
                    break;
            }
        }

        // Set mipmap flags if present
        if (this.header?.mipMapCount > 1) {
            header.dwFlags |= 0x20000; // DDSD_MIPMAPCOUNT
            header.dwCaps |= 0x400000 | 0x8; // DDSCAPS_COMPLEX | DDSCAPS_MIPMAP
        }


        return header;
    }

    /**
     * Calculates the total number of mipmap levels required for a texture based on its width and height.

     *
     * @param {number} [width=0] - The initial width of the texture. Defaults to 0.
     * @param {number} [height=0] - The initial height of the texture. Defaults to 0.
     * @return {number} The total count of mipmap levels for the given texture dimensions.
     */
    generateMipMapCount(width = 0, height = 0){
        let nWidth = width;
        let nHeight = height;
        let dataSize = 0;
        let running = true;
        let mips = 0;

        let multiplier = (this.header.encoding == ENCODING.RGB) ? 0.5 : 1;

        while(running){
            let mipMapSize = Math.max((nWidth * nHeight) * multiplier, this.header.minDataSize);
            //console.log(nWidth, nHeight, mipMapSize);
            dataSize += mipMapSize;//Math.max( dataSize >> 2, this.header.minDataSize );
            if(nWidth == 1 && nHeight == 1){
                running = false;
            }
            nWidth = Math.max( nWidth >> 1, 1 );
            nHeight = Math.max( nHeight >> 1, 1 );
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
        Header.dataSize = Reader.readUInt32();
        Header.alphaTest = Reader.readSingle();

        // Image dimensions
        Header.width = Reader.readUInt16();
        Header.height = Reader.readUInt16();

        // How's the pixel data encoded?
        Header.encoding = Reader.readByte();

        // Number of mip maps in the image
        Header.mipMapCount = Math.max( 1, Reader.readByte() );

        Header.bytesPerPixel = 4;
        Header.bitsPerPixel = (Header.bytesPerPixel * 8);

        Header.minDataSize = 0;
        Header.compressed = false;
        Header.hasAlpha = false;

        if (Header.dataSize == 0) {
            // Uncompressed
            Header.compressed = false;
            switch(Header.encoding){
                case ENCODING.GRAY:
                    Header.hasAlpha = false;
                    Header.format = PixelFormat.R8G8B8;
                    Header.minDataSize = 1;
                    Header.dataSize = Header.width * Header.height;
                    break;
                case ENCODING.RGB:
                    Header.hasAlpha = false;
                    Header.format = PixelFormat.R8G8B8;
                    Header.minDataSize = 3;
                    Header.dataSize = Header.width * Header.height * 3;
                    break;
                case ENCODING.RGBA:
                    Header.hasAlpha = true;
                    Header.format = PixelFormat.R8G8B8A8;
                    Header.minDataSize = 4;
                    Header.dataSize = Header.width * Header.height * 4;
                    break;
                case ENCODING.BGRA:
                    Header.hasAlpha = true;
                    Header.format = PixelFormat.B8G8R8A8;
                    Header.minDataSize = 4;
                    Header.dataSize = Header.width * Header.height * 4;
                    break;
                default:
                    console.error('TPCObject', Header);
                    throw 'Unknown';
            }
        }else{
            switch(Header.encoding){
                case ENCODING.RGB:
                    // S3TC DXT1
                    Header.compressed = true;
                    Header.hasAlpha = false;
                    Header.format = PixelFormat.DXT1;
                    Header.minDataSize = 8;
                    break;
                case ENCODING.RGBA:
                    // S3TC DXT5
                    Header.compressed = true;
                    Header.hasAlpha = true;
                    Header.format = PixelFormat.DXT5;
                    Header.minDataSize = 16;
                    break;
                default:
                    console.error('TPCObject', Header);
            }
        }

        // Extract mipmaps buffers
        Header.isCubemap = false;
        if( ( Header.height / Header.width ) == 6 ){
            Header.isCubemap = true;
            Header.height = Header.width;
        }

        Header.faces = Header.isCubemap ? 6 : 1;

        return Header;

    }

    getDataLength() {

        let dataLength = 0;

        for ( let face = 0; face < this.header.faces; face ++ ) {

            let width = this.header.width;
            let height = this.header.height;
            let dataSize = this.header.dataSize;

            for ( let i = 0; i < this.header.mipMapCount; i ++ ) {
                if ( !this.header.compressed ) {
                    dataLength += width * height * this.header.minDataSize;
                } else {
                    dataLength += dataSize;
                }

                width = Math.max( width >> 1, 1 );
                height = Math.max( height >> 1, 1 );
                dataSize = Math.max( dataSize >> 2, this.header.minDataSize );
            }

        }

        return dataLength;

    }

    FlipY(pixelData: any){
        let offset = 0;
        let stride = this.header.width * 4;

        if(pixelData == null)
            throw 'Missing pixelData'

        let unFlipped = Uint8Array.from(pixelData);

        for (let pos = unFlipped.length - stride; pos >= 0; pos -= stride) {
            pixelData.set(unFlipped.slice(pos, pos + stride), offset);
            offset += stride;
        }

        return pixelData;

    }

    //Convert the TPC into a THREE.CompressedTexture for use in the engine
    toCompressedTexture(){
        let images = [];
        let texDatas = this.getDDS( true );
        let _texture: OdysseyCompressedTexture|THREE.CanvasTexture = new OdysseyCompressedTexture( texDatas.mipmaps, texDatas.dwWidth, texDatas.dwHeight );


        // if(this.canvas.length){
        //   _texture = new THREE.CanvasTexture(this.canvas[0] as any);
        // }else{
        if ( texDatas.isCubemap ) {
            let faces = texDatas.mipmaps.length / texDatas.dwMipMapCount;
            for ( let f = 0; f < faces; f ++ ) {
                images[ f ] = { mipmaps : [] } as any;

                for ( let i = 0; i < texDatas.dwMipMapCount; i++ ) {
                    images[ f ].mipmaps.push( texDatas.mipmaps[ f * texDatas.dwMipMapCount + i ] );
                    images[ f ].format = THREE.CubeReflectionMapping;//texDatas.format;
                    images[ f ].width = texDatas.dwWidth;
                    images[ f ].height = texDatas.dwHeight;


                    _texture.mipmaps = images[ f ].mipmaps;
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

        _texture.name = this.filename;

        if ( texDatas.dwMipMapCount === 1 ) {
            _texture.minFilter = THREE.LinearFilter;
        }


        _texture.format = texDatas.ddspf.dwFourCC;
        _texture.needsUpdate = true;
        (_texture as any).bumpMapType = 'NORMAL';


        (_texture as any).header = this.header;
        (_texture as any).pack = this.pack;
        (_texture as any).txi = null;

        (_texture as any).txi = this.txi;

        (_texture as any).clone = function () {
            let cloned = new this.constructor().copy( this );
            cloned.format = this.format;
            cloned.needsUpdate = true;
            cloned.bumpMapType = this.bumpMapType;
            cloned.header = this.header;
            cloned.txi = this.txi;
            return this;
        };

        return _texture;
    }

}

