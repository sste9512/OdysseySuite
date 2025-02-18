

//DDS (DirectDraw Surface) is a proprietary image file format developed by Microsoft specifically for storing compressed texture data used in video games 
// and 3D applications. Here are the key aspects:

//
//1. **Structure**:
//```cpp
        // Basic DDS file structure
        // "DDS " (Magic number)
        // DDS_HEADER (124 bytes)
        // [DDS_HEADER_DXT10] (Optional, for newer formats)
        // Image Data (Including mipmaps)
//```

/*

2. **Key Features**:
        Key Features:
        Supports multiple compression formats:
        DXT1/BC1 (RGB compression, 4:1 ratio)
        DXT3/BC2 (RGBA with sharp alpha)
        DXT5/BC3 (RGBA with smooth alpha)
        BC4-BC7 (Various specialized formats)
        Hardware-accelerated decompression
        Stores pre-generated mipmaps
        Supports cubemaps and volume textures
        Direct GPU upload capability
        Common Uses:
        Video game textures
        Real-time 3D applications
        Normal maps
        Cubemaps for environment mapping
        Texture arrays
        Volume textures

Advantages:

*/


export interface DDS_PIXELFORMAT {
    dwSize: number;
    dwFlags: number;
    dwFourCC: number;
    dwRGBBitCount: number;
    dwRBitMask: number;
    dwGBitMask: number;
    dwBBitMask: number;
    dwABitMask: number;
}


export interface DDS_HEADER {
    isCubemap: any;
    mipmaps: DDS_MIPMAP[];
    dwSize: number;           // Size of header (124 bytes)
    dwFlags: number;          // Format flags
    dwHeight: number;         // Image height
    dwWidth: number;          // Image width
    dwPitchOrLinearSize: number;
    dwDepth: number;          // Depth for volume textures

    dwMipMapCount: number;    // Number of mipmaps
    dwReserved1: number[];   // Reserved
    ddspf: DDS_PIXELFORMAT;  // Pixel format info
    dwCaps: number;          // Capabilities
    dwCaps2: number;         // Additional capabilities
    dwCaps3: number;         // Not used
    dwCaps4: number;         // Not used
    dwReserved2: number;     // Reserved
}

export interface DDS_MIPMAP {
    width: number;
    height: number;
    pitchOrLinearSize: number;
    depth: number;
    data: Uint8Array;
}

