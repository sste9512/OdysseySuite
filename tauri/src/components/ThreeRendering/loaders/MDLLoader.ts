import { BinaryReader } from "../BinaryReader";
import { OdysseyModel } from "../odyssey";
import { ResourceLoader } from "./ResourceLoader";
import { ResourceTypes } from "../resource/ResourceTypes";

export interface ModelCacheReference {
  model: OdysseyModel;
  // mdl: Uint8Array;
  // mdx: Uint8Array;
}

export interface ModelCacheInterface {
  models: Map<string, ModelCacheReference>
}

const ModelCache: ModelCacheInterface = {
  models: new Map<string, ModelCacheReference>()
};

/**
 * MDLLoader class.
 * 
 * KotOR JS - A remake of the Odyssey Game Engine that powered KotOR I & II
 * 
 * @file MDLLoader.ts
 * @author KobaltBlu <https://github.com/KobaltBlu>
 * @license {@link https://www.gnu.org/licenses/gpl-3.0.txt|GPLv3}
 */
export class MDLLoader {
  static loader = new MDLLoader();

  load(resourceReference: string = ''): Promise<OdysseyModel> {
    resourceReference = resourceReference.toLocaleLowerCase(); // Ensure the resource reference is lowercase
    console.log('MDLLoader: Loading model:', resourceReference);
    
    return new Promise<OdysseyModel>((resolve, reject) => {
      try {
        console.log('MDLLoader: Checking model cache');
        if (ModelCache.models.has(resourceReference)) {
          console.log('MDLLoader: Found cached model');
          const cachedModelReference = ModelCache.models.get(resourceReference);
          resolve(cachedModelReference.model);
        } else {
          console.log('MDLLoader: Model not in cache, loading from resources');
          console.log('MDLLoader: Loading MDL file');
          ResourceLoader.loadResource(ResourceTypes['mdl'], resourceReference).then((mdlBuffer: Uint8Array) => {
            console.log('MDLLoader: MDL file loaded successfully');
            console.log('MDLLoader: Loading MDX file'); 
            ResourceLoader.loadResource(ResourceTypes['mdx'], resourceReference).then((mdxBuffer: Uint8Array) => {
              console.log('MDLLoader: MDX file loaded successfully');
              console.log('MDLLoader: Creating OdysseyModel from buffers');
              const odysseyModel = MDLLoader.MDLFromBuffer(mdlBuffer, mdxBuffer);

              console.log('MDLLoader: Caching model');
              ModelCache.models.set(resourceReference, {
                model: odysseyModel
              });

              console.log('MDLLoader: Model loaded successfully');
              resolve(odysseyModel);
            }).catch((error) => {
              console.error('MDLLoader: Failed to load MDX file:', error);
              console.error('MDLLoader: MDX 404:', resourceReference);
              reject(error);
            });
          }).catch((error) => {
            console.error('MDLLoader: Failed to load MDL file:', error); 
            console.error('MDLLoader: MDL 404:', resourceReference);
            reject(error);
          });
        }
      } catch (error: any) {
        console.error('MDLLoader: Error loading model:', resourceReference, error);
        reject(error);
      }
    });
  }

  static MDLFromBuffer(mdl_buffer: Uint8Array, mdx_buffer: Uint8Array): OdysseyModel {
    let mdlReader = new BinaryReader(mdl_buffer);
    let mdxReader = new BinaryReader(mdx_buffer);
    return new OdysseyModel(mdlReader, mdxReader);
  }

}
