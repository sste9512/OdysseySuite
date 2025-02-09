import * as THREE from 'three';
import { DDSLoader } from 'three/examples/jsm/loaders/DDSLoader';

export class DDSTexture extends THREE.CompressedTexture {
    constructor(
        mipmaps: THREE.CompressedTextureMipmap[],
        width: number,
        height: number,
        format: THREE.CompressedPixelFormat,
        type?: THREE.TextureDataType,
        mapping?: THREE.Mapping,
        wrapS?: THREE.Wrapping,
        wrapT?: THREE.Wrapping,
        magFilter?: THREE.MagnificationTextureFilter,
        minFilter?: THREE.MinificationTextureFilter,
        anisotropy?: number,
        colorSpace?: THREE.ColorSpace
    ) {
        super(mipmaps, width, height, format, type, mapping, wrapS, wrapT, magFilter, minFilter, anisotropy);
        this.flipY = false;
        this.generateMipmaps = false;
        if (colorSpace) this.colorSpace = colorSpace;
    }

    static fromDDSData(buffer: ArrayBuffer): DDSTexture {
        console.log('Loading texture from buffer:', buffer);
        const loader = new DDSLoader();
        const texture = loader.parse(buffer, true) as unknown as THREE.CompressedTexture;

        return new DDSTexture(
            texture.mipmaps,
            texture.image.width,
            texture.image.height,
            texture.format,
            texture.type,
            texture.mapping as THREE.Mapping,
            texture.wrapS,
            texture.wrapT,
            texture.magFilter as THREE.MagnificationTextureFilter,
            texture.minFilter as THREE.MinificationTextureFilter,
            texture.anisotropy,
            texture.colorSpace as THREE.ColorSpace
        );
    }

    static async load(url: string): Promise<DDSTexture> {
        const loader = new DDSLoader();
        return new Promise((resolve, reject) => {
            loader.load(
                url,
                (texture: THREE.CompressedTexture) => {
                    resolve(new DDSTexture(
                        texture.mipmaps,
                        texture.image.width,
                        texture.image.height,
                        texture.format,
                        texture.type,
                        texture.mapping as THREE.Mapping,
                        texture.wrapS,
                        texture.wrapT,
                        texture.magFilter as THREE.MagnificationTextureFilter,
                        texture.minFilter as THREE.MinificationTextureFilter,
                        texture.anisotropy,
                        texture.colorSpace as THREE.ColorSpace
                    ));
                },
                undefined,
                reject
            );
        });
    }
}