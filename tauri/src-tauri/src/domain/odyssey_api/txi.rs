use serde::{Serialize, Deserialize};


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
#[derive(Debug,Copy, Clone, PartialEq, Serialize, Deserialize)]
pub enum TXITextureType {
    DIFFUSE = 0,
    BUMPMAP = 1,
    NORMALMAP = 2,
    ENVMAP = 3,
    LIGHTMAP = 4,
}

#[derive(Debug,Clone, PartialEq, Serialize, Deserialize)]
pub enum TXIInput {
    String(String),
    Bytes(Vec<u8>),
}

// Implement conversions from different types to TXIInput
impl From<Vec<u8>> for TXIInput {
    fn from(bytes: Vec<u8>) -> Self {
        TXIInput::Bytes(bytes)
    }
}

impl From<&[u8]> for TXIInput {
    fn from(bytes: &[u8]) -> Self {
        TXIInput::Bytes(bytes.to_vec())
    }
}

impl From<String> for TXIInput {
    fn from(text: String) -> Self {
        TXIInput::String(text)
    }
}

impl From<&str> for TXIInput {
    fn from(text: &str) -> Self {
        TXIInput::String(text.to_string())
    }
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
#[derive(Debug,Copy, Clone, PartialEq, Serialize, Deserialize)]
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
#[derive(Debug,Clone, PartialEq, Serialize, Deserialize)]
pub enum TXIBlending {
    NONE = 0,
    ADDITIVE = 1,
    PUNCHTHROUGH = 2,
}

#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct TXI {
    pub blending: TXIBlending,
    pub texture_type: TXITextureType,
    pub procedure_type: TXIProcedureType,
    pub is_compressed: bool,
    pub bump_map_scaling: f32,
    pub is_bumpmap: bool,
    pub bump_map_texture: Option<String>,
    pub env_map_texture: Option<String>,
    pub water_alpha: Option<f32>,
    pub default_width: Option<i32>,
    pub default_height: Option<i32>,
    pub down_sample_min: i32,
    pub down_sample_max: i32,
    pub mip_map: i32,
    pub decal: i32,
    pub num_chars: i32,
    pub filter: i32,
    pub font_height: f32,
    pub baseline_height: f32,
    pub texture_width: f32,
    pub spacing_r: f32,
    pub spacing_b: f32,
    pub caret_indent: f32,
    pub upper_left_coords: Vec<Coord>,
    pub lower_right_coords: Vec<Coord>,
    pub is_animated: bool,
    pub num_x: i32,
    pub num_y: i32,
    pub fps: i32,
    pub info: String,
}

#[derive(Debug, Clone, Serialize, Deserialize)]
struct Coord {
    x: f32,
    y: f32,
    z: f32,
}

impl TXI {
    pub fn create_from_options(info: TXIInput) -> Self {
        let mut txi = TXI {
            blending: TXIBlending::NONE,
            texture_type: TXITextureType::DIFFUSE,
            procedure_type: TXIProcedureType::NONE,
            is_compressed: true,
            bump_map_scaling: 1.0,
            is_bumpmap: false,
            bump_map_texture: None,
            env_map_texture: None,
            water_alpha: None,
            default_width: None,
            default_height: None,
            down_sample_min: 0,
            down_sample_max: 0,
            mip_map: 0,
            decal: 0,
            num_chars: 0,
            filter: 0,
            font_height: 0.0,
            baseline_height: 0.0,
            texture_width: 0.0,
            spacing_r: 0.0,
            spacing_b: 0.0,
            caret_indent: 0.0,
            upper_left_coords: Vec::new(),
            lower_right_coords: Vec::new(),
            is_animated: false,
            num_x: 0,
            num_y: 0,
            fps: 0,
            info: String::new(),
        };

        if let TXIInput::Bytes(info) = info {
            txi.info = String::from_utf8_lossy(&info).to_lowercase();
            txi.parse_info();
        }

        txi
    }

    fn parse_info(&mut self) {
        let lines: Vec<&str> = self.info.split('\n').collect();
        let mut i = 0;
        while i < lines.len() {
            let line = lines[i];
            let mut args: Vec<&str> = line.split(' ').collect();

            if args.len() > 1 {
                args[1] = args[1].trim();
            }

            match args[0] {
                "isbumpmap" => {
                    self.is_bumpmap = args[1].parse::<i32>().map(|n| n != 0).unwrap_or(false);
                }
                "islightmap" => {
                    self.texture_type = TXITextureType::LIGHTMAP;
                }
                "cube" => {
                    self.texture_type = TXITextureType::ENVMAP;
                }
                "compresstexture" => {
                    self.is_compressed = args[1].parse::<i32>().map(|n| n == 1).unwrap_or(false);
                }
                "mipmap" => {
                    self.mip_map = args[1].parse().unwrap_or(0);
                }
                "downsamplemin" => {
                    self.down_sample_min = args[1].parse().unwrap_or(0);
                }
                "downsamplemax" => {
                    self.down_sample_max = args[1].parse().unwrap_or(0);
                }
                "decal" => {
                    self.decal = args[1].parse().unwrap_or(0);
                }
                "defaultwidth" => {
                    self.default_width = args[1].parse().ok();
                }
                "defaultheight" => {
                    self.default_height = args[1].parse().ok();
                }
                "filter" => {
                    self.filter = args[1].parse().unwrap_or(0);
                }
                "blending" => {
                    self.blending = match args[1] {
                        "punchthrough" => TXIBlending::PUNCHTHROUGH,
                        "additive" => TXIBlending::ADDITIVE,
                        _ => TXIBlending::NONE
                    };
                }
                "bumpmapscaling" => {
                    self.bump_map_scaling = args[1].parse().unwrap_or(1.0);
                }
                "bumpmaptexture" => {
                    self.bump_map_texture = Some(args[1].trim().to_string());
                }
                "bumpyshinytexture" | "envmaptexture" => {
                    self.env_map_texture = Some(args[1].trim().to_string());
                }
                "wateralpha" => {
                    self.water_alpha = args[1].parse().ok();
                }
                "proceduretype" => {
                    self.is_animated = true;
                    self.procedure_type = match args[1] {
                        "cycle" => TXIProcedureType::CYCLE,
                        "water" => {
                            self.is_animated = false;
                            TXIProcedureType::WATER
                        }
                        "random" => TXIProcedureType::RANDOM,
                        "ringtexdistort" => TXIProcedureType::RINGTEXDISTORT,
                        _ => TXIProcedureType::NONE
                    };
                }
                "numx" => {
                    self.num_x = args[1].parse().unwrap_or(0);
                }
                "numy" => {
                    self.num_y = args[1].parse().unwrap_or(0);
                }
                "fps" => {
                    self.fps = args[1].parse().unwrap_or(0);
                }
                "numchars" => {
                    self.num_chars = args[1].parse().unwrap_or(0);
                }
                "fontheight" => {
                    self.font_height = args[1].parse().unwrap_or(0.0);
                }
                "baselineheight" => {
                    self.baseline_height = args[1].parse().unwrap_or(0.0);
                }
                "texturewidth" => {
                    self.texture_width = args[1].parse().unwrap_or(0.0);
                }
                "spacingr" => {
                    self.spacing_r = args[1].parse().unwrap_or(0.0);
                }
                "spacingb" => {
                    self.spacing_b = args[1].parse().unwrap_or(0.0);
                }
                "caretindent" => {
                    self.caret_indent = args[1].parse().unwrap_or(0.0);
                }
                "upperleftcoords" => {
                    if let Ok(num) = args[1].parse::<usize>() {
                        let max = i + 1 + num;
                        for j in (i + 1)..max {
                            if let Some(line) = lines.get(j) {
                                let coords: Vec<f32> = line.split(' ')
                                    .filter_map(|s| s.parse().ok())
                                    .collect();
                                if coords.len() >= 3 {
                                    self.upper_left_coords.push(Coord {
                                        x: coords[0],
                                        y: coords[1],
                                        z: coords[2]
                                    });
                                }
                            }
                        }
                        i += num - 1;
                    }
                }
                "lowerrightcoords" => {
                    if let Ok(num) = args[1].parse::<usize>() {
                        let max = i + 1 + num;
                        for j in (i + 1)..max {
                            if let Some(line) = lines.get(j) {
                                let coords: Vec<f32> = line.split(' ')
                                    .filter_map(|s| s.parse().ok())
                                    .collect();
                                if coords.len() >= 3 {
                                    self.lower_right_coords.push(Coord {
                                        x: coords[0],
                                        y: coords[1],
                                        z: coords[2]
                                    });
                                }
                            }
                        }
                        i += num - 1;
                    }
                }
                _ => {}
            }
            i += 1;
        }
    }
}
