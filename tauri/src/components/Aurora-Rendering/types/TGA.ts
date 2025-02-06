import {TXI} from "@/components/Aurora-Rendering/types/TXI";


/**
 * Represents the structure of a TGA (Targa) file header, typically used to describe
 * properties of an image in a TGA file format.
 */
export interface ITGAHeader {
    /**
     * Unique identifier of the image, often used to store comments or metadata.
     */
    ID: number;

    /**
     * Indicates if a color map (palette) is included: 0 for no color map and 1 for included color map.
     */
    ColorMapType: number;

    /**
     * The type of the TGA file, such as 2 for uncompressed RGB images.
     */
    FileType: number;

    /**
     * Indicates whether the TGA file contains a color map (calculated based on `ColorMapType`).
     */
    hasColorMap: boolean;

    /**
     * The starting index of the color map in the palette, used only if a color map is present.
     */
    ColorMapIndex: number;

    /**
     * The horizontal offset (in pixels) of the image from the origin.
     */
    offsetX: number;

    /**
     * The vertical offset (in pixels) of the image from the origin.
     */
    offsetY: number;

    /**
     * The width of the image in pixels.
     */
    width: number;

    /**
     * The height of the image in pixels.
     */
    height: number;

    /**
     * The number of bits per pixel used to store the image. Common values are 8, 24, or 32.
     */
    bitsPerPixel: number;

    /**
     * Describes the image's attributes and orientation, such as alpha channel depth and flipping.
     */
    imageDescriptor: number;

    /**
     * The byte offset in the file where the pixel data begins.
     */
    pixelDataOffset: number;
};

/**
 * Represents the options for configuring a TGA object.
 * This interface defines the properties required to manage and use TGA file data.
 *
 * @interface ITGAObjectOptions
 *
 * @property {string | Uint8Array} file - The file data, either as a path to the file (string) or as a binary Uint8Array.
 * @property {string} filename - The name of the file including its extension.
 */
export interface ITGAObjectOptions {
    file: string | Uint8Array;
    filename: string;
}

export class TGA {

    /**
     * A variable representing binary file data.
     *
     * This variable is an instance of Uint8Array, which is a typed array that contains
     * a sequence of 8-bit unsigned integer values. It is typically used to store and
     * manipulate raw binary data from files or other sources.
     */
    fileData: Uint8Array;
    /**
     * Represents the header data of a TGA (Targa) image file.
     *
     * The `imageHeader` variable is an object conforming to the `ITGAHeader` interface,
     * which contains metadata about the TGA image, such as width, height, pixel depth,
     * and other attributes necessary for decoding and rendering the image.
     *
     * It provides essential information required to interpret the image data stored
     * in a TGA file.
     *
     * @type {ITGAHeader}
     */
    imageHeader: ITGAHeader;
    /**
     * Represents the raw pixel data of an image or graphical element.
     *
     * The pixelData variable is a typed array specifically using the `Uint8Array` type,
     * which is designed to store unsigned 8-bit integer values. Each value in the array
     * corresponds to a single channel of a pixel, commonly representing channels such as
     * red, green, blue, and alpha (transparency) in sequence if the encoding format follows
     * standard RGBA structure.
     *
     * The structure of the data, including how many bytes correspond to each pixel and
     * their arrangement, is dependent on the particular use case or image format.
     *
     * Usage of this array can be applied in scenarios involving low-level image processing,
     * custom rendering pipelines, and direct manipulation of image or texture data.
     */
    pixelData: Uint8Array;
    /**
     * Represents an instance of the `TXI` object, which is initialized with an empty string.
     * The `txi` variable is used to manage or interact with the TXI framework or functionality.
     *
     * @type {TXI}
     */
    txi: TXI = new TXI('');
    /**
     * Represents the name of a file.
     *
     * This variable is used to store the name of a file,
     * which typically includes the base name and an optional file extension.
     * The value should be a string that follows standard file naming conventions.
     */
    fileName: string;

    constructor(options: ITGAObjectOptions = {} as ITGAObjectOptions) {

        const defaultOptions: ITGAObjectOptions = {
            file: new Uint8Array(0),
            filename: '',
        } as ITGAObjectOptions;

        const mergedOptions = {...defaultOptions, ...options};

        console.log('TGAObject', options);

        if (typeof mergedOptions.file === 'string') {
            this.fileData = new Uint8Array(0);
        } else {
            this.fileData = mergedOptions.file;
        }

        this.fileName = mergedOptions.filename;

        this.imageHeader = this.readHeader();
        this.pixelData = new Uint8Array(0);

    }

    readHeader(): ITGAHeader {
        const header: ITGAHeader = {
            ID: 0,
            ColorMapType: 0,
            FileType: 2,
            ColorMapIndex: 0,
            offsetX: 0,
            offsetY: 0,
            width: 1,
            height: 1,
            bitsPerPixel: 32,
            imageDescriptor: 0
        } as ITGAHeader;

        if (this.fileData.length > 0) {
            const binaryReader = new BinaryReader(this.fileData);

            header.ID = binaryReader.readByte();
            header.ColorMapType = binaryReader.readByte();
            header.FileType = binaryReader.readByte();

            // Simple color map detection (May not be adequate)
            header.hasColorMap = header.ColorMapType !== 0;
            header.ColorMapIndex = binaryReader.readByte();

            if (header.hasColorMap) {

            }

            header.offsetX = binaryReader.readUInt32();
            header.offsetY = binaryReader.readUInt32();
            header.width = binaryReader.readUInt16();
            header.height = binaryReader.readUInt16();

            header.bitsPerPixel = binaryReader.readByte();
            header.imageDescriptor = binaryReader.readByte();

            header.pixelDataOffset = binaryReader.position;
        }

        return header;
    }

    getPixelData(onLoadCallback?: Function) {

        const binaryReader = new BinaryReader(this.fileData);
        console.log('TGAObject', this.imageHeader);
        binaryReader.seek(this.imageHeader.pixelDataOffset);

        // 32bpp RGBA
        if (this.imageHeader.bitsPerPixel === 32) {
            if (onLoadCallback != null)
                onLoadCallback(binaryReader.readBytes(this.imageHeader.width * this.imageHeader.height * 4));
        }

        // 24bpp RGB
        if (this.imageHeader.bitsPerPixel === 24) {
            if (onLoadCallback != null)
                onLoadCallback(binaryReader.readBytes(this.imageHeader.width * this.imageHeader.height * 3));
        }

        // 8bpp Gray
        if (this.imageHeader.bitsPerPixel === 8) {
            if (onLoadCallback != null)
                onLoadCallback(binaryReader.readBytes(this.imageHeader.width * this.imageHeader.height));
        }

    }

    async toExportBuffer(): Promise<Uint8Array> {
        const binaryWriter = new BinaryWriter();

        binaryWriter.writeByte(this.imageHeader.ID);
        binaryWriter.writeByte(this.imageHeader.ColorMapType);
        binaryWriter.writeByte(this.imageHeader.FileType);
        binaryWriter.writeByte(this.imageHeader.ColorMapIndex);
        binaryWriter.writeUInt32(this.imageHeader.offsetX);
        binaryWriter.writeUInt32(this.imageHeader.offsetY);
        binaryWriter.writeUInt16(this.imageHeader.width);
        binaryWriter.writeUInt16(this.imageHeader.height);
        binaryWriter.writeByte(this.imageHeader.bitsPerPixel);
        binaryWriter.writeByte(this.imageHeader.imageDescriptor);

        binaryWriter.writeBytes(this.pixelData);

        return binaryWriter.buffer;
    }

    async export(resourceReference = '') {
        const buffer = await this.toExportBuffer();
        await GameFileSystem.writeFile(resourceReference, buffer);
        return true;
    }

    /**
     * Flips the given pixel data vertically (along the Y-axis).
     *
     * @param {Uint8Array} pixelData - The pixel data as a flat array of RGBA values.
     * @param {number} [width=1] - The width of the image in pixels.
     * @param {number} [height=1] - The height of the image in pixels.
     * @return {void} - This method modifies the `pixelData` array directly.
     */
    static FlipY(pixelData: Uint8Array, width = 1, height = 1) {
        let offset = 0;
        const rowStride = width * 4;

        const originalData = Uint8Array.from(pixelData);

        for (let position = originalData.length - rowStride; position >= 0; position -= rowStride) {
            pixelData.set(originalData.slice(position, position + rowStride), offset);
            offset += rowStride;
        }
    }

    /**
     * Converts a given canvas element into a TGA image data object.
     *
     * @param {HTMLCanvasElement | OffscreenCanvas} canvas - The canvas element or OffscreenCanvas to be converted into TGA format.
     * @return {TGA} The TGA object containing image header and pixel data derived from the canvas.
     */
    static FromCanvas(canvas: HTMLCanvasElement | OffscreenCanvas) {
        const tga = new TGA();
        if (canvas instanceof HTMLCanvasElement || canvas instanceof OffscreenCanvas) {

            const context: CanvasRenderingContext2D | OffscreenCanvasRenderingContext2D = canvas.getContext('2d') as any;
            if (context) {
                tga.imageHeader.width = canvas.width;
                tga.imageHeader.height = canvas.height;
                tga.imageHeader.bitsPerPixel = 32;
                tga.imageHeader.FileType = 2;
                const imageData = context.getImageData(0, 0, canvas.width, canvas.height).data;

                tga.pixelData = new Uint8Array(imageData.length);

                const rowByteLength = imageData.length / tga.imageHeader.height;
                for (let rowIndex = 0; rowIndex < tga.imageHeader.height; rowIndex++) {
                    const rowOffset = rowByteLength * rowIndex;
                    for (let pixelIndex = 0, reverseIndex = rowByteLength; pixelIndex < rowByteLength; pixelIndex += 4, reverseIndex -= 4) {
                        tga.pixelData[rowOffset + pixelIndex] = imageData[rowOffset + pixelIndex + 2]; // red
                        tga.pixelData[rowOffset + pixelIndex + 1] = imageData[rowOffset + pixelIndex + 1]; // green
                        tga.pixelData[rowOffset + pixelIndex + 2] = imageData[rowOffset + pixelIndex]; // blue
                        tga.pixelData[rowOffset + pixelIndex + 3] = imageData[rowOffset + pixelIndex + 3]; // alpha
                    }
                }

                TGA.FlipY(tga.pixelData, tga.imageHeader.width, tga.imageHeader.height);
            }

        }

        return tga;

    }

}
