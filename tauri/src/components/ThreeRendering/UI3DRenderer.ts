import { SceneGraphTreeViewManager } from "@/components/ThreeRendering/SceneGraphTreeViewManager";
import { EventListenerModel } from "@/components/DataPresentation/EventListenerModel";
import * as KotOR from "@/components/ThreeRendering/KotOR";
import * as THREE from 'three';
import { ModelViewerControls } from "@/components/DataPresentation/ModelViewerControls";
import { SceneGraphNode } from "@/components/DataPresentation/SceneGraphNode";
import { FlyControls } from 'three/examples/jsm/controls/FlyControls.js';
import { FirstPersonControls } from 'three/examples/jsm/controls/FirstPersonControls.js';
import { TransformControls } from 'three/examples/jsm/controls/TransformControls';
import { ViewHelper } from 'three/examples/jsm/helpers/ViewHelper.js';

export class UI3DRenderer extends EventListenerModel {

  private uuid: string;

  public sceneGraphManager: SceneGraphTreeViewManager;

  private time: number;
  private deltaTime: number;
  private deltaTimeFixed: number = 0;

  private canvas?: HTMLCanvasElement;
  private width: number = 640;
  private height: number = 480;

  private guiMode: boolean = false;
  private clock: THREE.Clock;
  private renderer?: THREE.WebGLRenderer;
  private clearColor: THREE.Color = new THREE.Color(0x333333);
  public scene: THREE.Scene = new THREE.Scene();
  private camera: THREE.PerspectiveCamera;
  private guiCamera: THREE.OrthographicCamera;
  private currentCamera: THREE.PerspectiveCamera;
  private cameras: THREE.PerspectiveCamera[] = [];
  private light: THREE.AmbientLight;
  private lights: THREE.Group = new THREE.Group();
  private globalLight: THREE.Light;
  private depthTarget: THREE.WebGLRenderTarget;
  private raycaster: THREE.Raycaster = new THREE.Raycaster();

  private lightManager: KotOR.LightManager = new KotOR.LightManager();

  public referenceNode: THREE.Object3D = new THREE.Object3D();

  private selectable: THREE.Group = new THREE.Group();
  private unselectable: THREE.Group = new THREE.Group();

  private resizeObserver: ResizeObserver;
  private loadingTextures: boolean;
  private enabled: boolean = false;

  private controls: ModelViewerControls;
  public controlsEnabled: boolean = false;

  private queuedAnimationFrame: number;

  private odysseyModels: KotOR.OdysseyModel3D[] = [];
  private selectionBox = new THREE.BoxHelper(new THREE.Object3D(), 0xffffff);

  private flyControls: FirstPersonControls;
  private transformControls: TransformControls;
  private viewHelper: ViewHelper;

  private group: {
    lights: THREE.Group;
    light_helpers: THREE.Group;
    shadow_lights: THREE.Group;
  };
  private frustumMat4: THREE.Matrix4;
  private viewportFrustum: THREE.Frustum;


  
  constructor(canvas?: HTMLCanvasElement, width: number = 640, height: number = 480) {
    super();
    this.uuid = crypto.randomUUID();
    this.sceneGraphManager = new SceneGraphTreeViewManager();
    this.sceneGraphManager.attachUI3DRenderer(this);
    this.canvas = canvas;
    this.width = width;
    this.height = height;

    this.frustumMat4 = new THREE.Matrix4();
    this.viewportFrustum = new THREE.Frustum();

    this.time = 0;
    this.deltaTime = 0;

    this.clock = new THREE.Clock();
    this.selectionBox.visible = false;

    this.group = {
      lights: new THREE.Group(),
      light_helpers: new THREE.Group(),
      shadow_lights: new THREE.Group(),
    }

    this.resizeObserver = new ResizeObserver((elements: ResizeObserverEntry[]) => {
      for (let i = 0; i < elements.length; i++) {
        const entry = elements[i];
        this.setSize(entry.contentRect.width, entry.contentRect.height);
      }
    });

    this.buildCamera();
    if (this.canvas) {
      this.buildWebGLRenderer();
      this.buildDepthTarget();
      this.buildAmbientLight();
      this.buildScene();
    }

    this.controls = new ModelViewerControls(this);
    this.controls.attachEventListener('onSelect', (intersect: THREE.Intersection) => {
      this.selectObject(intersect?.object);
    })
    this.selectionBox.visible = false;
    this.buildTransformControls();
    this.buildViewHelper();
    this.buildFlyControls();

    this.lightManager.init(this);
  }

  buildTransformControls() {
    if (this.transformControls) {
      this.transformControls.dispose();
      (this.transformControls as unknown as THREE.Object3D).removeFromParent();
    }
    if (this.canvas) {
      this.transformControls = new TransformControls(this.currentCamera, this.canvas);
      (this.transformControls as unknown as THREE.Object3D).visible = false;
      this.unselectable.add(this.transformControls as unknown as THREE.Object3D);
      (this.transformControls as unknown as THREE.Object3D).userData.uuids = [];
      (this.transformControls as unknown as THREE.Object3D).traverse((obj) => {
        (this.transformControls as unknown as THREE.Object3D).userData.uuids.push(obj.uuid);
      });
    }
  }

  buildFlyControls() {
    // if(this.flyControls) this.flyControls.dispose();
    // if(this.canvas){
    //   this.flyControls = new FirstPersonControls(this.currentCamera as any, this.canvas);
    // }
  }

  buildViewHelper() {
    if (this.viewHelper) this.viewHelper.dispose();
    if (this.canvas) {
      this.viewHelper = new ViewHelper(this.currentCamera as any, this.canvas);
    }
  }

  attachObject(object: THREE.Object3D, selectable: boolean = true) {
    if (object) {
      if (selectable) this.selectable.add(object);
      else this.unselectable.add(object);

      object.traverse((node) => {
        if (node instanceof KotOR.OdysseyModel3D) {
          if (this.odysseyModels.indexOf(node) == -1) {
            this.odysseyModels.push(node);
          }
        }
      });

      this.sceneGraphManager.rebuild();
    }
  }

  detachObject(object: THREE.Object3D) {
    object.removeFromParent();

    object.traverse((node) => {
      if (node instanceof KotOR.OdysseyModel3D) {
        const index = this.odysseyModels.indexOf(node);
        if (index >= 0) {
          this.odysseyModels.splice(index, 1);
        }
      }
    });

    this.sceneGraphManager.rebuild();
  }

  attachCamera(camera: THREE.PerspectiveCamera) {
    camera.userData.heler = new THREE.CameraHelper(camera);
    this.scene.add(camera.userData.heler);
    this.cameras.push(camera);
  }

  selectObject(object: THREE.Object3D) {
    if (object) {
      this.selectionBox.setFromObject(object);
      this.selectionBox.visible = true;
    } else {
      this.selectionBox.visible = false;
    }
  }

  setCanvas(canvas: HTMLCanvasElement) {
    const oCanvas = this.canvas;
    if (oCanvas?.parentElement) this.resizeObserver.unobserve(oCanvas.parentElement);
    this.canvas = canvas;
    if (this.canvas && oCanvas != this.canvas) {
      this.buildWebGLRenderer();
      this.buildDepthTarget();

      // this.buildCamera();
      this.buildAmbientLight();
      this.buildScene();
    }
    if (this.canvas) {
      this.buildTransformControls();
      this.buildViewHelper();
      this.buildFlyControls();
      if (this.canvas?.parentElement) this.resizeObserver.observe(this.canvas.parentElement);
      this.setSize(this.canvas.width, this.canvas.height);
      this.controls.attachCanvasElement(this.canvas);
      this.processEventListener('onCanvasAttached', [this.canvas]);
    }
  }

  buildCamera() {
    // if(this.camera) this.camera.dispose();
    this.camera = new THREE.PerspectiveCamera(50, this.width / this.height, 0.1, 1500);
    this.camera.up = new THREE.Vector3(0, 0, 1);
    this.camera.position.set(.1, 5, 1); // offset the camera a bit
    this.camera.lookAt(new THREE.Vector3(0, 0, 0));
    this.camera.aspect = this.width / this.height;
    this.camera.updateProjectionMatrix();

    this.currentCamera = this.camera;

    this.guiCamera = new THREE.OrthographicCamera(
      this.width / -2, this.width / 2,
      this.height / 2, this.height / -2,
      1, 1000
    );
    this.guiCamera.up = new THREE.Vector3(0, 0, 1);
    this.guiCamera.position.z = 500;
    this.guiCamera.updateProjectionMatrix();
  }

  buildAmbientLight() {
    if (this.globalLight) {
      this.globalLight.removeFromParent();
      this.globalLight.dispose();
    }
    this.globalLight = new THREE.AmbientLight(0x7F7F7F); //0x60534A
    this.globalLight.name = 'Ambient Light';
    this.globalLight.position.x = 0;
    this.globalLight.position.y = 0;
    this.globalLight.position.z = 0;
    this.globalLight.intensity = 1;
    this.lights.add(this.globalLight);
  }

  buildScene() {
    // this.scene = new THREE.Scene();

    this.scene.add(this.selectionBox);
    this.scene.add(this.lights);
    this.scene.add(this.selectable);
    this.scene.add(this.unselectable);
    this.scene.add(this.referenceNode);
    this.scene.add(this.group.lights);
    this.scene.add(this.group.light_helpers);
    this.scene.add(this.group.shadow_lights);
    this.sceneGraphManager.rebuild();
  }

  buildWebGLRenderer() {
    if (this.renderer) this.renderer.dispose();
    this.renderer = new THREE.WebGLRenderer({
      canvas: this.canvas,
      antialias: false,
      // autoClear: false,
      depth: true,
      alpha: true,
      logarithmicDepthBuffer: false,
      preserveDrawingBuffer: false,
    });

    if (this.renderer) {
      this.renderer.setClearColor(this.clearColor)
      this.renderer.autoClear = false;
      this.renderer.setSize(this.width, this.height);
    }
  }

  buildDepthTarget() {
    if (this.depthTarget) this.depthTarget.dispose();
    const pars = { minFilter: THREE.LinearFilter, magFilter: THREE.LinearFilter, format: THREE.RGBAFormat };
    this.depthTarget = new THREE.WebGLRenderTarget(window.innerWidth, window.innerHeight, pars);
    this.depthTarget.texture.generateMipmaps = false;
    this.depthTarget.stencilBuffer = false;
    this.depthTarget.depthBuffer = true;
    this.depthTarget.depthTexture = new THREE.DepthTexture(window.innerWidth, window.innerHeight);
    this.depthTarget.depthTexture.type = THREE.UnsignedShortType;
  }

  setSize(width = 100, height = 100) {
    this.width = width;
    this.height = height;
    if (this.renderer) this.renderer.setSize(this.width, this.height);

    this.camera.up = new THREE.Vector3(0, 0, 1);
    this.camera.aspect = this.width / this.height;
    this.camera.updateProjectionMatrix();
    this.depthTarget.setSize(this.width, this.height);

    this.guiCamera.left = this.width / -2;
    this.guiCamera.right = this.width / 2;
    this.guiCamera.top = this.height / 2;
    this.guiCamera.bottom = this.height / -2;

    this.guiCamera.updateProjectionMatrix();
  }

  triggerResize() {
    if (this.canvas) {
      this.setSize(this.canvas.width, this.canvas.height);
    }
  }

  resetScene() {
    this.scene = new THREE.Scene();
    this.scene.add(this.light);

    return this.scene;
  }

  getScene() {
    return this.scene;
  }

  getCamera() {
    return this.camera;
  }

  getRenderedImage(): string {
    if (this.canvas) {
      return this.canvas.toDataURL();
    }
    return '';
  }

  render() {
    if (!this.enabled) return;
    this.queuedAnimationFrame = requestAnimationFrame(() => {
      this.render();
    });
    if (this.renderer) {
      this.renderer.clear();
      this.selectionBox.update();

      const delta = this.clock.getDelta();
      this.time += delta;
      this.deltaTime += delta;
      this.deltaTimeFixed += (1 / 60);

      // if(this.controlsEnabled && this.flyControls){
      //   this.flyControls.update(delta);
      // }

      if (this.viewHelper && this.viewHelper.animating === true) {
        this.viewHelper.update(delta);
      }

      if (this.controlsEnabled) {
        this.controls.update(delta);
      }

      //Custom render logic can run here
      this.processEventListener('onBeforeRender', [delta]);

      if (!this.loadingTextures && KotOR.TextureLoader.queue.length) {
        this.loadingTextures = true;
        KotOR.TextureLoader.LoadQueue(() => {
          this.loadingTextures = false;
        });
      }

      if (this.currentCamera) {
        this.frustumMat4.multiplyMatrices(this.currentCamera.projectionMatrix, this.currentCamera.matrixWorldInverse)
        this.viewportFrustum.setFromProjectionMatrix(this.frustumMat4);
        this.lightManager.update(delta, this.currentCamera);
      }

      this.renderer.render(this.scene, this.guiMode ? this.guiCamera : this.currentCamera);

      if (this.viewHelper) {
        this.viewHelper.render(this.renderer);
      }

      //Custom render logic can run here
      this.processEventListener('onAfterRender', [delta]);
    }
  }

  destroy() {
    this.enabled = false;
    cancelAnimationFrame(this.queuedAnimationFrame);
    if (this.renderer) this.renderer.dispose();
    this.renderer = undefined;

    this.controls.dispose();

    if (this.camera) {
      this.camera.removeFromParent();
    }
    if (this.guiCamera) {
      this.guiCamera.removeFromParent();
    }
    while (this.scene.children.length) {
      this.scene.children[0].removeFromParent();
    }
    this.canvas = undefined;
  }

}

