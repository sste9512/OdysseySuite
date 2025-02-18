import type { PixelFormat } from '@/data/PixelFormat';
 
export interface ITPCHeader {
  dataSize: number;
  alphaTest: number;
  width: number;
  height: number;
  encoding: number;
  mipMapCount: number;
  bytesPerPixel: number;
  bitsPerPixel: number;
  minDataSize: number;
  compressed: boolean
  hasAlpha: boolean
  format: PixelFormat;
  isCubemap: boolean;
  faces: number;
}