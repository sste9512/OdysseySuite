import { PixelFormat } from "@/components/Aurora-Rendering/types/TPC";

export interface TpcData {
  width: number;
  height: number;
  encoding: number;
  data_size: number;
  pixels: number[];
  mipmap_count: number;
  has_alpha: boolean;
  average_color: number[];
}


export interface MipMap {
  // Add mipmap fields as needed
  width?: number;
  height?: number;
  data?: Uint8Array;
}

export interface TPC_Xoreos {
  mip_maps: MipMap[];
  format: PixelFormat;
  txi_data: Uint8Array | null;
  txi_data_size: number;
  is_animated: boolean;
  layer_count: number;
  is_cube_map: boolean;
}
