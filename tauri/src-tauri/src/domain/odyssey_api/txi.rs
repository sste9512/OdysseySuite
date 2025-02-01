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
#[derive(Copy, Clone, PartialEq)]
pub enum TXITextureType {
    DIFFUSE = 0,
    BUMPMAP = 1,
    NORMALMAP = 2,
    ENVMAP = 3,
    LIGHTMAP = 4,
}

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
#[derive(Copy, Clone, PartialEq)]
pub enum TXIProcedureType {
    NONE = 0,
    CYCLE = 1,
    WATER = 2,
    RANDOM = 3,
    RINGTEXDISTORT = 4,
}

/**
 * Represents blending modes for a texture or material. The enumeration provides
 * different blending options to define how a texture is blended with the background.
 *
 * Enum values:
 * - `NONE`: No blending is applied (value: 0).
 * - `ADDITIVE`: Uses additive blending, where the colors of the texture are added to the background (value: 1).
 * - `PUNCHTHROUGH`: Renders the texture with transparency by discarding transparent pixels, creating a punch-through effect (value: 2).
 */
#[derive(Copy, Clone, PartialEq)]
pub enum TXIBlending {
    NONE = 0,
    ADDITIVE = 1,
    PUNCHTHROUGH = 2,
}

pub struct TXI {
    /**
     * Represents the blending type used in rendering operations.
     * This variable defines how colors are combined when overlapping objects.
     *
     * The `blending` variable typically determines the blending mode, which can
     * influence transparency, lighting effects, or composition of visual elements.
     *
     * It is often utilized in graphics programming or 2D/3D rendering pipelines.
     */
    blending: TXIBlending,
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
    texture_type: TXITextureType,
    /**
     * Represents the type of a procedure within the system.
     * This variable is utilized to define or categorize a procedure
     * based on the specified enumerations or constants in TXIPROCEDURETYPE.
     * It determines the operational category or nature of the procedure being performed.
     */
    procedure_type: TXIProcedureType,
    /**
     * A boolean indicating whether the data has been compressed.
     * If true, the data is in a compressed format.
     * If false, the data remains uncompressed.
     */
    is_compressed: bool,
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
    bump_map_scaling: f32,
    /**
     * Indicates whether the texture should be treated as a bump map.
     *
     * A bump map is a texture that simulates surface detail by using the texture's intensity values
     * to alter the surface normals of an object, creating the illusion of depth and detail on a flat surface.
     */
    is_bump_map: bool,
    /**
     * Represents the texture used for applying a bump map effect to a 3D model or material.
     * A bump map is a technique in 3D modeling to simulate bumps and wrinkles on the surface
     * of an object without modifying its geometry. This property defines the texture that is
     * interpreted as height information for rendering realistic surface details like grooves
     * and surface irregularities.
     */
    bump_map_texture: Option<String>,
    /**
     * A variable representing an environment map texture.
     * This can hold any type of value associated with texture data used for
     * rendering a reflective or refractive appearance in 3D scene environments.
     *
     * It is commonly used in rendering pipelines to simulate effects such as
     * background reflections, skyboxes, or light maps.
     */
    env_map_texture: Option<String>,
    /**
     * A variable representing the transparency level or alpha value of water.
     * The value can be of any type and might be used to indicate the opacity,
     * blending, or visual representation of water in a given context.
     */
    water_alpha: Option<f32>,
    /**
     * Represents the default width value used for a specific component or layout.
     * This variable typically indicates the standard or initial width when no custom width is provided.
     */
    default_width: u32,
    /**
     * Represents the default height value, typically used for setting a standard height
     * in UI components or layout configurations. This value is expressed as a number,
     * and its unit of measurement depends on the context in which it is applied
     * (e.g., pixels, percentage, etc.).
     */
    default_height: u32,
    /**
     * Represents the minimum value for down-sampling operations.
     * This variable is used to specify the lower limit or threshold
     * for reducing the volume of data or resolution in a dataset
     * during down-sampling processes.
     */
    down_sample_min: u32,
    /**
     * The maximum number of data points to retain after down-sampling.
     *
     * This variable is used to specify the upper limit of data points
     * allowed in a simplified or reduced dataset, often used for
     * performance optimization or visualization purposes.
     */
    down_sample_max: u32,
}