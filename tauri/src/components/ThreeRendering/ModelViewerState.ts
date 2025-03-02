import { defineComponent, ref, onMounted, onUnmounted } from 'vue';
//   import BaseTabStateOptions from "@/interfaces/BaseTabStateOptions";
// import { TabState, TabStateEventListenerTypes, TabStateEventListeners } from "@/components/ThreeRendering/TabState";
import * as KotOR from "./KotOR";
import * as THREE from 'three';
import {UI3DRenderer} from "./UI3DRenderer";  
// import { EditorFile } from "@/components/ThreeRendering/EditorFile";
import { BinaryReader } from "./BinaryReader";
import { SceneGraphNode } from "../DataPresentation/SceneGraphNode";
import { AuroraService } from '@/data/aurora-service';
import { UI3DRendererEventListenerTypes } from './UI3DRendererTypes';

// export interface ModelViewerStateOptions extends BaseTabStateOptions {
//   file?: EditorFile;
// }
export class ModelViewerService {
  private ui3DRenderer: UI3DRenderer;
  private model: KotOR.OdysseyModel3D | null = null;
  private odysseyModel: KotOR.OdysseyModel | null = null;
  private mdl: Uint8Array | null = null;
  private mdx: Uint8Array | null = null;
  private animations: KotOR.OdysseyModelAnimation[] = [];
  private currentAnimation: KotOR.OdysseyModelAnimation | null = null;
  private currentAnimationState = {
    elapsed: 0
  };
  private paused = true;
  private looping = false;
  private selectedAnimationIndex = -1;
  private layout: KotOR.LYTObject | null = null;
  private layoutGroup = new THREE.Group();
  private layoutSceneGraphNode: SceneGraphNode;
  private groundMesh: THREE.LineSegments;

  constructor() {
    console.log('Initializing renderer...');
    this.ui3DRenderer = new UI3DRenderer();
    this.ui3DRenderer.controlsEnabled = true;

    console.log('Setting up ground mesh...');
    const groundColor = new THREE.Color(0.5, 0.5, 0.5);
    const groundGeometry = new THREE.WireframeGeometry(new THREE.PlaneGeometry(2500, 2500, 100, 100));
    const groundMaterial = new THREE.LineBasicMaterial({ color: groundColor, linewidth: 2 });
    this.groundMesh = new THREE.LineSegments(groundGeometry, groundMaterial);

    console.log('Adding meshes to scene...');
    this.ui3DRenderer.scene.add(this.groundMesh);
    this.ui3DRenderer.scene.add(this.layoutGroup);

    console.log('Setting up layout scene graph...');
    this.layoutSceneGraphNode = new SceneGraphNode({
      name: 'Layout'
    });
    this.ui3DRenderer.sceneGraphManager.sceneNode.addChildNode(this.layoutSceneGraphNode);

    console.log('Binding animation update...');
    this.ui3DRenderer.addEventListener<UI3DRendererEventListenerTypes>('onBeforeRender', this.animate.bind(this));
  }




  public async loadModelAsync(fileName : string, mdlId: number, mdxId: number): Promise<KotOR.OdysseyModel3D> {
    const auroraService = new AuroraService();
    // TODO: create command that reads byte data for mdl and mdx files
    const response = await auroraService.readModelFiles(fileName, mdlId, mdxId);
    if (response.ok) {
      try {
        console.log('Response received:', response.value);
        this.mdl = response.value[0];
        console.log("MDL:", this.mdl.length);
        this.mdx = response.value[1];
        console.log("MDX:", this.mdx.length);
        
         const result = new KotOR.OdysseyModel(new BinaryReader(this.mdl), new BinaryReader(this.mdx));
         this.odysseyModel = result;
         console.log('Odyssey model created:', this.odysseyModel.toFormattedString());

        // if (result.ok) {
        //   this.odysseyModel = result.value;
        //   console.log('Odyssey model created:', this.odysseyModel.toFormattedString());
        // } else {
        //   console.error('Error creating Odyssey model:', result.error);
        // }
      
      } catch (error) {
        console.error('Error creating Odyssey model:', error);
      }
    }
    // this.odysseyModel = new KotOR.OdysseyModel(
    //   new BinaryReader(response.buffer), 
    //   new BinaryReader(response.buffer2 as Buffer)
    // );

    return new Promise((resolve) => {
      KotOR.OdysseyModel3D.FromMDL(this.odysseyModel, {
        context: this.ui3DRenderer,
        editorMode: true,
        onComplete: (model: KotOR.OdysseyModel3D) => {
          console.log('Loading model...');
          this.model = model;
          
          console.log('Attaching model to renderer...');
          this.ui3DRenderer.attachObject(model, true);

          console.log('Setting up animations...');
          this.animations = model.odysseyAnimations.slice(0).sort((a, b) => {
            return a.name.localeCompare(b.name);
          });

          this.selectedAnimationIndex = 0;
          this.currentAnimation = this.animations[this.selectedAnimationIndex];
          console.log(`Found ${this.animations.length} animations`);

          console.log('Setting up emitters...');
          model.emitters.forEach(emitter => {
            emitter.referenceNode = this.ui3DRenderer.referenceNode as any;
          });
          console.log(`Setup ${model.emitters.length} emitters`);

          console.log('Setting up camera...');
          if (model.camerahook) {
            const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
            camera.name = model.name;
            model.camerahook.add(camera);
            this.ui3DRenderer.attachCamera(camera);
            console.log('Camera setup complete');
          } else {
            console.log('No camera hook found');
          }

          console.log('Rebuilding scene graph...');
          this.ui3DRenderer.sceneGraphManager.rebuild();
          
          console.log('Model loading complete');
          resolve(model);
        }
      });
    });
  }

  // public async loadModel(file: EditorFile): Promise<KotOR.OdysseyModel3D> {
  //   const response = await file.readFile();
    
  //   this.mdl = response.buffer;
  //   this.mdx = response.buffer2 as Buffer;
  //   this.odysseyModel = KotOR.OdysseyModel.fromBytes(this.mdl, this.mdx);
  //   // this.odysseyModel = new KotOR.OdysseyModel(
  //   //   new BinaryReader(response.buffer), 
  //   //   new BinaryReader(response.buffer2 as Buffer)
  //   // );

  //   return new Promise((resolve) => {
  //     KotOR.OdysseyModel3D.FromMDL(this.odysseyModel, {
  //       context: this.ui3DRenderer,
  //       editorMode: true,
  //       onComplete: (model: KotOR.OdysseyModel3D) => {
  //         console.log('Loading model...');
  //         this.model = model;
          
  //         console.log('Attaching model to renderer...');
  //         this.ui3DRenderer.attachObject(model, true);

  //         console.log('Setting up animations...');
  //         this.animations = model.odysseyAnimations.slice(0).sort((a, b) => {
  //           return a.name.localeCompare(b.name);
  //         });

  //         this.selectedAnimationIndex = 0;
  //         this.currentAnimation = this.animations[this.selectedAnimationIndex];
  //         console.log(`Found ${this.animations.length} animations`);

  //         console.log('Setting up emitters...');
  //         model.emitters.forEach(emitter => {
  //           emitter.referenceNode = this.ui3DRenderer.referenceNode as any;
  //         });
  //         console.log(`Setup ${model.emitters.length} emitters`);

  //         console.log('Setting up camera...');
  //         if (model.camerahook) {
  //           const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
  //           camera.name = model.name;
  //           model.camerahook.add(camera);
  //           this.ui3DRenderer.attachCamera(camera);
  //           console.log('Camera setup complete');
  //         } else {
  //           console.log('No camera hook found');
  //         }

  //         console.log('Rebuilding scene graph...');
  //         this.ui3DRenderer.sceneGraphManager.rebuild();
          
  //         console.log('Model loading complete');
  //         resolve(model);
  //       }
  //     });
  //   });
  // }

  public animate(delta: number = 0): void {
    if (!this.model || !this.currentAnimation) return;

    if (this.currentAnimation !== this.model.animationManager.currentAnimation) {
      this.model.animationManager.currentAnimation = this.currentAnimation;
      this.model.animationManager.currentAnimationState = this.currentAnimationState;
    }

    const cachedAnimationState = this.model.animationManager.currentAnimationState;

    if (!this.paused) {
      const elapsed = this.currentAnimationState.elapsed;
      this.model.update(delta);
      let currentElapsed = this.model.animationManager.currentAnimationState.elapsed;
      
      if (isNaN(currentElapsed)) {
        currentElapsed = elapsed;
      }
      
      if (currentElapsed < elapsed && !this.looping) {
        currentElapsed = elapsed;
      }
    } else {
      const elapsed = this.model.animationManager.currentAnimationState.elapsed;
      this.model.update(delta);
      
      if (!isNaN(elapsed)) {
        this.model.animationManager.currentAnimationState.elapsed = elapsed;
      }
    }

    if (!this.model.animationManager.currentAnimationState) {
      this.model.animationManager.currentAnimationState = cachedAnimationState;
    }

    this.currentAnimationState = this.model.animationManager.currentAnimationState;
  }

  public setAnimationByIndex(index: number): void {
    if (!this.model) return;

    this.selectedAnimationIndex = index;
    const animation = this.animations[index];

    if (animation) {
      this.model.playAnimation(animation, this.looping);
      this.currentAnimation = animation;
    } else {
      this.selectedAnimationIndex = 0;
      this.currentAnimation = this.animations[0];
    }
  }

  public play(): void {
    if (!this.currentAnimation || !this.model) return;

    this.paused = false;
    if (this.currentAnimation !== this.model.animationManager.currentAnimation) {
      this.model.playAnimation(this.currentAnimation, this.looping);
    }
  }

  public pause(): void {
    this.paused = true;
  }

  public stop(): void {
    if (!this.model) return;
    this.paused = true;
    this.model.stopAnimation();
  }

  public seek(time: number = 0): void {
    if (!this.currentAnimation || !this.currentAnimationState) return;

    time = Math.max(0, Math.min(time, this.currentAnimation.length));
    this.currentAnimationState.elapsed = time;
  }

  public setLooping(loop: boolean): void {
    this.looping = loop;
    if (this.currentAnimation && this.model) {
      this.model.playAnimation(this.currentAnimation, loop);
    }
  }

  public destroy(): void {
    this.ui3DRenderer.destroy();
    this.disposeLayout();
  }

  private disposeLayout(): void {
    this.layoutSceneGraphNode.setNodes([]);
    this.ui3DRenderer.sceneGraphManager.rebuild();

    this.layoutGroup.children.forEach(child => {
      if (child instanceof KotOR.OdysseyModel3D) {
        child.dispose();
        this.layoutGroup.remove(child);
      }
    });
  }

  public getRenderer(): UI3DRenderer {
    return this.ui3DRenderer;
  }

  public getCurrentAnimation(): KotOR.OdysseyModelAnimation | null {
    return this.currentAnimation;
  }

  public getCurrentAnimationState() {
    return this.currentAnimationState;
  }
}