/**
 * TXITexType is an enumeration representing different types of texture mappings
 * used in rendering or graphical computations.
 *
 * Enumeration values:
 * - DIFFUSE: Represents the diffuse texture type, used for basic surface coloring.
 * - BUMPMAP: Represents the bump map texture type, used to simulate surface details.
 * - NORMALMAP: Represents the normal map texture type, used to provide more detailed surface normal vectors for lighting calculations.
 * - ENVMAP: Represents the environment map texture type, used for reflection or refraction effects.
 * - LIGHTMAP: Represents the light map texture type, used for baked lighting effects.
 */
export enum TXITexType {
    'DIFFUSE' = 0,
    'BUMPMAP' = 1,
    'NORMALMAP' = 2,
    'ENVMAP' = 3,
    'LIGHTMAP' = 4
};

/**
 * Enumeration TXIPROCEDURETYPE represents various types of procedural processes.
 *
 * The enum defines a set of constants representing different procedure types,
 * where each type is associated with a numerical value.
 *
 * Available Types:
 * - NONE: Represents no procedural process.
 * - CYCLE: Represents a cyclic procedural process.
 * - WATER: Represents a water-like procedural process.
 * - RANDOM: Represents a random procedural process.
 * - RINGTEXDISTORT: Represents a ring texture distortion procedural process.
 */
export enum TXIPROCEDURETYPE {
    'NONE' = 0,
    'CYCLE' = 1,
    'WATER' = 2,
    'RANDOM' = 3,
    'RINGTEXDISTORT' = 4
};

/**
 * Represents blending modes for a texture or material. The enumeration provides
 * different blending options to define how a texture is blended with the background.
 *
 * Enum values:
 * - `NONE`: No blending is applied (value: 0).
 * - `ADDITIVE`: Uses additive blending, where the colors of the texture are added to the background (value: 1).
 * - `PUNCHTHROUGH`: Renders the texture with transparency by discarding transparent pixels, creating a punch-through effect (value: 2).
 */
export enum TXIBlending {
    'NONE' = 0,
    'ADDITIVE' = 1,
    'PUNCHTHROUGH' = 2
}

export class TXI {
    /**
     * Represents the blending type used in rendering operations.
     * This variable defines how colors are combined when overlapping objects.
     *
     * The `blending` variable typically determines the blending mode, which can
     * influence transparency, lighting effects, or composition of visual elements.
     *
     * It is often utilized in graphics programming or 2D/3D rendering pipelines.
     */
    blending: TXIBlending;
    /**
     * Represents the type of texture used in a graphic or rendering context.
     * This variable specifies the format or classification of the texture,
     * which can dictate how it is processed or rendered in the associated system.
     *
     * The value assigned to `textureType` should correspond to a predefined
     * type within the TXITexType enumeration or type definition. Examples
     * of texture types can include 2D, 3D, CubeMap, or other specialized
     * formats supported by the rendering engine.
     *
     * It is typically used to determine or validate the compatibility of
     * a texture within certain rendering operations or configurations.
     */
    textureType: TXITexType;
    /**
     * Represents the type of a procedure within the system.
     * This variable is utilized to define or categorize a procedure
     * based on the specified enumerations or constants in TXIPROCEDURETYPE.
     * It determines the operational category or nature of the procedure being performed.
     */
    procedureType: TXIPROCEDURETYPE;
    /**
     * A boolean indicating whether the data has been compressed.
     * If true, the data is in a compressed format.
     * If false, the data remains uncompressed.
     */
    isCompressed: boolean;
    /**
     * Represents the scaling factor for the bump map effect.
     * This value determines the intensity or magnitude of the bump mapping applied
     * to a surface in rendering, with higher values resulting in more pronounced
     * surface details and lower values producing subtler effects.
     *
     * It is typically used in 3D graphics to simulate surface irregularities
     * and enhance realism without modifying the actual geometry of the surface.
     *
     * The value should be a non-negative number.
     */
    bumpMapScaling: number;
    /**
     * Indicates whether the texture should be treated as a bump map.
     *
     * A bump map is a texture that simulates surface detail by using the texture's intensity values
     * to alter the surface normals of an object, creating the illusion of depth and detail on a flat surface.
     *
     * @type {boolean}
     */
    isbumpmap: boolean;
    /**
     * Represents the texture used for applying a bump map effect to a 3D model or material.
     * A bump map is a technique in 3D modeling to simulate bumps and wrinkles on the surface
     * of an object without modifying its geometry. This property defines the texture that is
     * interpreted as height information for rendering realistic surface details like grooves
     * and surface irregularities.
     *
     * @type {any}
     */
    bumpMapTexture: any;
    /**
     * A variable representing an environment map texture.
     * This can hold any type of value associated with texture data used for
     * rendering a reflective or refractive appearance in 3D scene environments.
     *
     * It is commonly used in rendering pipelines to simulate effects such as
     * background reflections, skyboxes, or light maps.
     */
    envMapTexture: any;
    /**
     * A variable representing the transparency level or alpha value of water.
     * The value can be of any type and might be used to indicate the opacity,
     * blending, or visual representation of water in a given context.
     */
    waterAlpha: any;
    /**
     * Represents the default width value used for a specific component or layout.
     * This variable typically indicates the standard or initial width when no custom width is provided.
     */
    defaultWidth: number;
    /**
     * Represents the default height value, typically used for setting a standard height
     * in UI components or layout configurations. This value is expressed as a number,
     * and its unit of measurement depends on the context in which it is applied
     * (e.g., pixels, percentage, etc.).
     *
     * @type {number}
     */
    defaultHeight: number;
    /**
     * Represents the minimum value for down-sampling operations.
     * This variable is used to specify the lower limit or threshold
     * for reducing the volume of data or resolution in a dataset
     * during down-sampling processes.
     *
     * @type {number}
     */
    downSampleMin: number;
    /**
     * The maximum number of data points to retain after down-sampling.
     *
     * This variable is used to specify the upper limit of data points
     * allowed in a simplified or reduced dataset, often used for
     * performance optimization or visualization purposes.
     */
    downSampleMax: number;
    /**
     * Represents the mipmap level for a texture in graphical rendering.
     * A mipmap is a series of pre-calculated, optimized versions of a texture image
     * that are used to improve rendering performance and reduce artifacts.
     *
     * The `mipMap` value is a numeric indicator of the level to be used,
     * where 0 typically represents the original texture image,
     * and higher numbers indicate successive levels of detail.
     *
     * @type {number}
     */
    mipMap: number;
    /**
     * Represents a numerical decal value.
     * This variable is typically used to store a number
     * that might be associated with graphical elements,
     * identification, or labeling in a software context.
     */
    decal: number;
    /**
     * Represents the number of characters.
     *
     * This variable is used to store a numerical value indicating the count of characters.
     * It is expected to be a non-negative integer, but specific usage may dictate additional constraints.
     *
     * @type {number}
     */
    numchars: number;
    /**
     * The `filter` variable represents a number used to apply specific filtering criteria
     * within an operation or dataset. Its value is typically utilized to determine
     * matching or exclusion rules based on numerical conditions.
     *
     * @type {number}
     */
    filter: number;
    /**
     * Represents the height of a font measured in pixels.
     * This value is commonly used to calculate text dimensions
     * or for rendering text elements with specific height.
     *
     * @type {number}
     */
    fontheight: number;
    /**
     * Represents the base height measurement used as a reference
     * for layout calculations or scaling within the application.
     *
     * This value is typically used to maintain consistent spacing,
     * alignment, or scaling of UI elements relative to a standard
     * height value set for the design system.
     */
    baselineheight: number;
    /**
     * Represents the width of a texture in pixels.
     *
     * This variable is used to define the horizontal size of a texture,
     * which could be used in rendering contexts, image processing, or
     * graphical manipulations. The value should typically be a non-negative
     * number representing the width in pixels.
     */
    texturewidth: number;
    /**
     * Represents the spacing value to be applied on the right side.
     *
     * This variable is commonly used to define or adjust the horizontal spacing
     * on the right side of an element, layout, or spacing-related calculation.
     *
     * @type {number}
     */
    spacingr: number;
    /**
     * Represents the spacing or margin value, typically used for layout or
     * design-related calculations in user interfaces or graphic elements.
     *
     * @type {number}
     */
    spacingb: number;
    /**
     * Represents the indentation level for a caret within a text editor or input field.
     * This value specifies the number of spaces or units to indent a caret position
     * for proper alignment or formatting purposes.
     *
     * @type {number}
     */
    caretindent: number;
    /**
     * Represents an array of coordinate objects defining the upper-left corner
     * positions in a three-dimensional space.
     *
     * Each coordinate object in the array has three properties:
     * - `x`: A number representing the position on the X-axis.
     * - `y`: A number representing the position on the Y-axis.
     * - `z`: A number representing the position on the Z-axis.
     */
    upperleftcoords: { x: number, y: number, z: number }[];
    /**
     * An array representing the coordinates of points that define the lower-right positions in a 3D space.
     * Each object in the array contains the x, y, and z numerical values corresponding to these positions.
     *
     * @typedef {Object} Coordinate
     * @property {number} x - The x-coordinate of the point.
     * @property {number} y - The y-coordinate of the point.
     * @property {number} z - The z-coordinate of the point.
     *
     * @type {Coordinate[]}
     */
    lowerrightcoords: { x: number, y: number, z: number }[];
    /**
     * A boolean flag indicating whether a certain element or component
     * should have an animation applied to it.
     *
     * When set to `true`, the element or component is animated.
     * When set to `false`, the element or component operates without animation.
     */
    isAnimated: boolean;
    /**
     * Represents a numerical value.
     *
     * This variable is used to store a number and can be utilized
     * in mathematical operations, comparisons, or other contexts
     * where numerical data is required.
     *
     * @type {number}
     */
    numx: number;
    /**
     * Represents a numerical value.
     *
     * This variable is used to store an integer or floating-point number.
     * It can be utilized in various mathematical computations or operations that require a numerical input.
     *
     * @type {number}
     */
    numy: number;
    /**
     * Represents the frames per second (FPS) value.
     *
     * This variable is used to indicate the frequency at which frames
     * are rendered or refreshed in a second. It is commonly used in
     * graphics rendering, animations, or video playback to measure
     * performance and smoothness.
     *
     * @type {number}
     */
    fps: number;
    /**
     * Represents a piece of textual information.
     * Typically used to store descriptions, messages, or other string-based data.
     * Can contain any valid string value.
     */
    info: string;

    constructor(info: Uint8Array | Uint8Array | string = '') {

        this.blending = TXIBlending.NONE;
        this.textureType = TXITexType.DIFFUSE;
        this.procedureType = TXIPROCEDURETYPE.NONE;

        this.isCompressed = true;

        this.bumpMapScaling = 1;
        this.isbumpmap = false;
        this.bumpMapTexture = null;
        this.envMapTexture = null;

        this.waterAlpha = null;

        this.downSampleMin = 0;
        this.downSampleMax = 0;
        this.mipMap = 0;
        this.decal = 0;

        this.numchars = 0;
        this.fontheight = 0;
        this.baselineheight = 0;
        this.texturewidth = 0;
        this.spacingr = 0;
        this.spacingr = 0;
        this.caretindent = 0;
        this.upperleftcoords = [];
        this.lowerrightcoords = [];

        //Animation
        this.isAnimated = false;
        this.numx = 0;
        this.numy = 0;
        this.fps = 0;

        this.info = '';

        if (info instanceof Uint8Array) {
            this.info = (new TextDecoder('utf8')).decode(info).toLowerCase();
            this.ParseInfo();
        } else if (typeof info === 'string') {
            this.info = info.toLowerCase();
            this.ParseInfo();
        }

        //console.log('TXI', this.info, typeof info, info instanceof Uint8Array);

    }

    ParseInfo() {
        let lines = this.info.split('\n');
        for (let i = 0; i < lines.length; i++) {
            let line = lines[i];
            let args = line.split(' ');

            if (typeof args[1] != 'undefined')
                args[1] = args[1].trim();

            switch (args[0]) {
                /*case 'isbumpmap':
                  if(this.textureType != TXITexType.NORMALMAP)
                    this.textureType = TXITexType.BUMPMAP;
                break;*/
                case 'isbumpmap':
                    this.isbumpmap = parseInt(args[1]) ? true : false;
                    break;
                case 'islightmap':
                    this.textureType = TXITexType.LIGHTMAP;
                    break;
                case 'cube':
                    this.textureType = TXITexType.ENVMAP;
                    break;
                case 'compresstexture':
                    this.isCompressed = parseInt(args[1]) == 1 ? true : false;
                    break;
                case 'mipmap':
                    this.mipMap = parseInt(args[1]);
                    break;
                case 'downsamplemin':
                    this.downSampleMin = parseInt(args[1]);
                    break;
                case 'downsamplemax':
                    this.downSampleMax = parseInt(args[1]);
                    break;
                case 'decal':
                    this.decal = parseInt(args[1]);
                    break;
                case 'defaultwidth':
                    this.defaultWidth = parseInt(args[1]);
                    break;
                case 'defaultheight':
                    this.defaultHeight = parseInt(args[1]);
                    break;
                case 'filter':
                    this.filter = parseInt(args[1]);
                    break;
                case 'blending':
                    switch (args[1]) {
                        case 'punchthrough':
                            this.blending = TXIBlending.PUNCHTHROUGH;
                            break;
                        case 'additive':
                            this.blending = TXIBlending.ADDITIVE;
                            break;
                    }
                    break;
                case 'bumpmapscaling':
                    this.bumpMapScaling = parseFloat(args[1]);
                    break;
                case 'bumpmaptexture':
                    this.bumpMapTexture = args[1].trim().replace(/\0[\s\S]*$/g, '');
                    break;
                case 'bumpyshinytexture':
                case 'envmaptexture':
                    this.envMapTexture = args[1].trim().replace(/\0[\s\S]*$/g, '');
                    break;
                case 'wateralpha':
                    this.waterAlpha = parseFloat(args[1]);
                    break;

                // TXI Animation
                case 'proceduretype':
                    this.isAnimated = true;
                    switch (args[1]) {
                        case 'cycle':
                            this.procedureType = TXIPROCEDURETYPE.CYCLE;
                            break;
                        case 'water':
                            this.isAnimated = false;
                            this.procedureType = TXIPROCEDURETYPE.WATER;
                            break;
                        case 'random':
                            this.procedureType = TXIPROCEDURETYPE.RANDOM;
                            break;
                        case 'ringtexdistort':
                            this.procedureType = TXIPROCEDURETYPE.RINGTEXDISTORT;
                            break;
                    }
                    break;
                case 'numx':
                    this.numx = parseInt(args[1]);
                    break;
                case 'numy':
                    this.numy = parseInt(args[1]);
                    break;
                case 'fps':
                    this.fps = parseInt(args[1]);
                    break;

                //FONTS
                case 'numchars':
                    this.numchars = parseInt(args[1]);
                    break;
                case 'fontheight':
                    this.fontheight = parseFloat(args[1]);
                    break;
                case 'baselineheight':
                    this.baselineheight = parseFloat(args[1]);
                    break;
                case 'texturewidth':
                    this.texturewidth = parseFloat(args[1]);
                    break;
                case 'spacingr':
                    this.spacingr = parseFloat(args[1]);
                    break;
                case 'spacingb':
                    this.spacingb = parseFloat(args[1]);
                    break;
                case 'caretindent':
                    this.caretindent = parseFloat(args[1]);
                    break;
                case 'upperleftcoords':
                    let _num = parseInt(args[1]);

                    let _max = i + 1 + _num;

                    for (let _i = i + 1; _i < _max; _i++) {
                        let line = lines[_i];
                        let args = line.split(' ');
                        this.upperleftcoords.push({
                            x: parseFloat(args[0]),
                            y: parseFloat(args[1]),
                            z: parseFloat(args[2])
                        });
                    }

                    i += _num - 1;

                    break;
                case 'lowerrightcoords':
                    let _num2 = parseInt(args[1]);

                    let _max2 = i + 1 + _num2;

                    for (let _i = i + 1; _i < _max2; _i++) {
                        let line = lines[_i];
                        let args = line.split(' ');
                        this.lowerrightcoords.push({
                            x: parseFloat(args[0]),
                            y: parseFloat(args[1]),
                            z: parseFloat(args[2])
                        });
                    }

                    i += _num2 - 1;

                    break;


            }

        }
    }

}

