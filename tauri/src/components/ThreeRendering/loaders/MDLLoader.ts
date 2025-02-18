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
    return new Promise<OdysseyModel>((resolve, reject) => {
      try {
        if (ModelCache.models.has(resourceReference)) { // Check if the model is already in the cache
          const cachedModelReference = ModelCache.models.get(resourceReference); // Retrieve the cached model reference
          resolve(cachedModelReference.model); // Resolve the cached model
        } else {
          // Attempt to load the .mdl resource from the ResourceLoader
          ResourceLoader.loadResource(ResourceTypes['mdl'], resourceReference).then((mdlBuffer: Uint8Array) => {
            // If .mdl loads successfully, attempt to load the .mdx resource
            ResourceLoader.loadResource(ResourceTypes['mdx'], resourceReference).then((mdxBuffer: Uint8Array) => {
              // Create a new OdysseyModel instance from the loaded buffers
              const odysseyModel = MDLLoader.MDLFromBuffer(mdlBuffer, mdxBuffer);

              // Cache the newly created model
              ModelCache.models.set(resourceReference, {
                model: odysseyModel
              });

              resolve(odysseyModel); // Resolve the newly created model
            }).catch((error) => {
              console.error(error); // Log any error that occurs while loading .mdx
              console.error('MDX 404', resourceReference); // Log .mdx specific 404 error
              reject(error); // Reject the promise to propagate the error
            });
          }).catch((error) => {
            console.error(error); // Log any error that occurs while loading .mdl
            console.error('MDL 404', resourceReference); // Log .mdl specific 404 error
            reject(error); // Reject the promise to propagate the error
          });
        }
      } catch (error: any) {
        console.error('MDLLoader.load', resourceReference, error); // Log general errors
        reject(error); // Reject the promise with the error
      }
    });
  }

  static MDLFromBuffer(mdl_buffer: Uint8Array, mdx_buffer: Uint8Array): OdysseyModel {
    let mdlReader = new BinaryReader(mdl_buffer);
    let mdxReader = new BinaryReader(mdx_buffer);
    return new OdysseyModel(mdlReader, mdxReader);
  }

}
