 


import * as THREE from "three";
import { OdysseyTexture } from "@/components/Aurora-Rendering/types/OdysseyTexture";


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

export class TPCTexture extends OdysseyCompressedTexture {
    constructor(buffer: ArrayBuffer) {
        // Parse TPC header
        const view = new DataView(buffer);
        let offset = 0;

        // TPC header structure
        const signature = view.getUint32(offset, true); // Should be 'TPC '
        offset += 4;
        const version = view.getUint32(offset, true);
        offset += 4;
        const width = view.getUint16(offset, true);
        offset += 2;
        const height = view.getUint16(offset, true);
        offset += 2;
        const textureFormat = view.getUint32(offset, true);
        offset += 4;
        const mipMapCount = view.getUint32(offset, true);
        offset += 4;

        // Create mipmaps array
        const mipmaps = [];
        
        // For each mipmap level
        for (let i = 0; i < mipMapCount; i++) {
            const mipWidth = Math.max(1, width >> i);
            const mipHeight = Math.max(1, height >> i);
            
            // Get mipmap size based on format
            const dataSize = calculateMipMapSize(mipWidth, mipHeight, textureFormat);
            
            // Extract mipmap data
            const data = new Uint8Array(buffer, offset, dataSize);
            offset += dataSize;
            
            mipmaps.push({
                data: data,
                width: mipWidth,
                height: mipHeight
            });
        }

        // Initialize base texture
        super(mipmaps, width, height);

        // Set format based on TPC format
        this.format = convertTPCFormatToThree(textureFormat);
    }
}

function calculateMipMapSize(width: number, height: number, format: number): number {
    // Format constants (example values, actual values depend on your TPC spec)
    const FORMAT_DXT1 = 0x31545844; // 'DXT1'
    const FORMAT_DXT3 = 0x33545844; // 'DXT3'
    const FORMAT_DXT5 = 0x35545844; // 'DXT5'

    switch (format) {
        case FORMAT_DXT1:
            return Math.max(8, Math.floor((width + 3) / 4) * Math.floor((height + 3) / 4) * 8);
        case FORMAT_DXT3:
        case FORMAT_DXT5:
            return Math.max(16, Math.floor((width + 3) / 4) * Math.floor((height + 3) / 4) * 16);
        default:
            throw new Error(`Unsupported TPC format: ${format}`);
    }
}

function convertTPCFormatToThree(format: number): number {
    // Convert TPC format to THREE.js format constants
    const FORMAT_DXT1 = 0x31545844;
    const FORMAT_DXT3 = 0x33545844;
    const FORMAT_DXT5 = 0x35545844;

    switch (format) {
        case FORMAT_DXT1:
            return 33776; // THREE.RGBA_S3TC_DXT1_Format
        case FORMAT_DXT3:
            return 33778; // THREE.RGBA_S3TC_DXT3_Format
        case FORMAT_DXT5:
            return 33779; // THREE.RGBA_S3TC_DXT5_Format
        default:
            throw new Error(`Unsupported TPC format: ${format}`);
    }
}