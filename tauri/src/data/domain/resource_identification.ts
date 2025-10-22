export enum ResourceType {
    NA = 0x000F,
    BMP = 1,
    TGA = 3,
    WAV = 4,
    PLT = 6,
    INI = 7,
    TXT = 10,
    MDL = 2002,
    NSS = 2009,
    NCS = 2010,
    ARE = 2012,
    SET = 2013,
    IFO = 2014,
    BIC = 2015,
    WOK = 2016,
    _2DA = 2017,
    TXI = 2022,
    GIT = 2023,
    UTI = 2025,
    UTC = 2027,
    DLG = 2029,
    ITP = 2030,
    UTT = 2032,
    DDS = 2033,
    UTS = 2035,
    LTR = 2036,
    GFF = 2037,
    FAC = 2038,
    UTE = 2040,
    UTD = 2042,
    UTP = 2045,
    GIC = 2046,
    GUI = 2047,
    UTM = 2051,
    DWK = 2052,
    PWK = 2053,
    JRL = 2056,
    SAV = 2057,
    UTW = 2058,
    SSF = 2060,
    HAK = 2061,
    NWM = 2062,
    BIK = 2063,
    PTM = 2065,
    PTT = 2066,
    LYT = 3000,
    VIS = 3001,
    RIM = 3002,
    PTH = 3003,
    LIP = 3004,
    BWM = 3005,
    TXB = 3006,
    TPC = 3007,
    MDX = 3008,
    RSV = 3009,
    SIG = 3010,
    XBX = 3011,
    ERF = 9997,
    BIF = 9998,
    KEY = 9999,
  }
  
  export const resourceTypeFromNumber = (value: number): ResourceType | undefined => {
    return Object.values(ResourceType).includes(value) ? value as ResourceType : undefined;
  };
  
  export const resourceTypeToNumber = (type: ResourceType): number => {
    return type;
  };
  
  // Common interfaces for resource-related structures
  export interface Vector3 {
    x: number;  // f32 in Rust
    y: number;  // f32 in Rust
    z: number;  // f32 in Rust
  }
  
  export interface ResourceLocation {
    area: number;         // u32 in Rust
    orientation: Vector3;
    position: Vector3;
  }
  
  export type VariableValue = 
    | { type: 'int'; value: number }
    | { type: 'float'; value: number }
    | { type: 'string'; value: string }
    | { type: 'object'; value: object }
    | { type: 'location'; value: ResourceLocation };
  
  export interface Variable {
    name: string;
    varType: number;  // u32 in Rust
    value: VariableValue;
  }