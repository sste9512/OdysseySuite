import { TPC } from "@/components/Aurora-Rendering/types/TPC";

import { OdysseyCompressedTexture } from "@/components/Aurora-Rendering/types/TPC";
import { Result } from "@/models/Result";


export class TPCLoader {



  // Here we have an altered version of the fetch function that allows us to load a TPC texture from a file name and a Uint8Array
  // We load the data from the rust api instead of the js route in kotor js
  async fetch(fileName: string, input: Uint8Array = new Uint8Array()): Promise<OdysseyCompressedTexture> {
    try {

      const tpc = new TPC({
        filename: fileName,
        file: input,
      });

      const textureResult = TPC.toCompressedTexture(tpc);
      if (!textureResult.ok) {
        throw new Error('Failed to map TPC to texture');
      }
      
      const texture = textureResult.value;
      texture.header = tpc.header;
      return texture;

    } catch (error) {
      console.error('Error loading TPC texture:', error);
      if (error instanceof Error) {
        console.error('Error message:', error.message);
      }
      throw new Error('Failed to load TPC texture');
    }
  }

  mapToTexture(tpc: TPC): Result<OdysseyCompressedTexture, Error> {
    try {
      const textureResult = TPC.toCompressedTexture(tpc);
      if (!textureResult.ok) {
        return textureResult;
      }
      const texture = textureResult.value;
      texture.header = tpc.header;
      return { ok: true, value: texture };
    } catch (error) {
      console.error('Error mapping TPC to texture:', error);
      return { ok: false, error: error as Error };
    }
  }

  // async fetchOverride(resRef: string = ''): Promise<OdysseyCompressedTexture> {
  //   const dir = path.join('Override');

  //   try{
  //     const buffer = await GameFileSystem.readFile(path.join(dir, resRef)+'.tpc');
  //     if(!buffer){
  //       throw new Error(`Failed to load ${resRef}.tpc from the override folder`);
  //     }

  //     const tpc = new TPCObject({
  //       filename: resRef,
  //       file: buffer
  //     });

  //     const texture = tpc.toCompressedTexture();

  //     return texture;
  //   }catch(e){

  //   }
  // };

  /*fetchLocal( resRef = '', onLoad?: Function, onProgress?: Function, onError?: Function ) {
  
    let file_info = path.parse(resRef);
    if(file_info.ext == '.tpc'){
      GameFileSystem.readFile(resRef).then( (buffer) => {
        let tpc = new TPCObject({
          filename: file_info.name,
          file: buffer
        });
  
        let texture = tpc.toCompressedTexture();
        //console.log("loaded texture", texName);
  
        if ( typeof onLoad === 'function' ) onLoad( texture );
  
      }).catch( (err) => {
        throw err; // Fail if the file can't be read.
      })
    }else{
      onError('Unsupported File Format');
    }
  
  };

  loadFromArchive( archive: string, tex: string, onComplete?: Function, onError?: Function ){
    let resKey = ERFManager.ERFs.get(archive).getResource(tex, ResourceTypes['tpc']);
    if(resKey instanceof Object){
  
      if (typeof onComplete === 'function') {
        ERFManager.ERFs.get(archive).getResourceBufferByResRef(tex, ResourceTypes['tpc']).then((buffer: Uint8Array) => {
          onComplete(
            new TPCObject({
              filename: tex,
              file: buffer
            })
          );
        });
      }
  
      return;
    }
  
    if (typeof onError === 'function') {
      onError('TPC not found in game archive '+archive+'.erf!');
    }
  }
  
  async load( resRef: string, isLocal = false ): Promise<TPCObject> {
    if(!isLocal){
      try{
        const result = await this.findTPC(resRef);
        const tpc = new TPCObject({
          filename: resRef,
          file: result.buffer,
          pack: result.pack,
        });
  
        return tpc;
      }catch(e){
        console.error(e);
        return undefined;
      }
  
    }else{
      console.warn('Local files not implemented yet');
    }
    return undefined;
  };*/

}
