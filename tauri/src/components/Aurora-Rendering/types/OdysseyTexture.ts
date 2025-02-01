import * as THREE from "three";
import { TXI } from "./TXI";


// Adapter class to transfer TGA data to HTML renderer
// TPC File -> Convert to TGA -> Insert into this component
/**
 * A texture class that extends THREE.Texture and provides additional functionality
 * specific to handling Odyssey textures. This includes custom properties and
 * configurations for packing, bump mapping, and metadata.
 *
 * OdysseyTexture includes support for managing texture wrapping, filtering,
 * and custom TXI metadata handling.
 */
export class OdysseyTexture extends THREE.Texture {


    /**
     * Represents an instance of the TXI class.
     *
     * This variable stores an initialized instance of the TXI object with
     * the specified default parameters. The TXI class might be responsible
     * for managing transactions, processing input, or other operations
     * based on its implementation details.
     *
     * @type {TXI}
     */
    txi: TXI = new TXI('');
    /**
     * Represents a variable that can hold any type of value.
     * This is a generic variable intended for use cases where the type of data is not known or can vary.
     * Use with caution, as type-safety is not enforced.
     */
    header: any;
    /**
     * Represents the number of packs.
     *
     * This variable is initialized with a default value of 0.
     * It typically holds a numeric value indicating the count
     * of packs being managed or used in a specific context.
     *
     * @type {number}
     */
    pack: number = 0;
    /**
     * Represents the type of bump mapping applied to a material in a 3D rendering pipeline.
     * The value specifies the method or algorithm used for bump mapping, which enhances the visual
     * details and textures on a surface by simulating bumps and wrinkles.
     *
     * @type {string}
     */
    bumpMapType: string;

    constructor(
        image?: HTMLImageElement | HTMLCanvasElement | HTMLVideoElement,
        mapping?: THREE.Mapping,
        wrapS?: THREE.Wrapping,
        wrapT?: THREE.Wrapping,
        magFilter?: THREE.TextureFilter,
        minFilter?: THREE.TextureFilter,
        format?: THREE.PixelFormat|THREE.CompressedPixelFormat,
        type?: THREE.TextureDataType,
        anisotropy?: number,
        encoding?: THREE.TextureEncoding,
    ){
        super(image, mapping, wrapS, wrapT, magFilter, minFilter, format as THREE.PixelFormat, type, anisotropy, encoding);
        this.txi = new TXI();
    }
}