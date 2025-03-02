<template>
  <div class="model-viewer-container">
    <aside v-if="model" class="model-info">
      <div class="tool-window-header">
        <h3>Model Structure</h3>
      </div>
      
      <div class="tool-window-content">
        <div class="info-section">
          <div class="section-header">File Details</div>
          <div class="info-row">
            <span class="label">Engine:</span>
            <span>{{ model.id }}</span>
          </div>
          <div class="info-row">
            <span class="label">Model Name:</span>
            <span>{{ model.name }}</span>
          </div>
          <div class="info-row">
            <span class="label">Node Count:</span>
            <span>{{ model.nodes.size }}</span>
          </div>
        </div>

        <div class="info-section">
          <div class="section-header">Model Properties</div>
          <div class="info-row">
            <span class="label">Classification:</span>
            <span>{{ model.modelHeader.classification }}</span>
          </div>
          <div class="info-row">
            <span class="label">Animations:</span>
            <span>{{ model.animations.length }}</span>
          </div>
          <div class="info-row">
            <span class="label">Smoothing:</span>
            <span>{{ model.modelHeader.smoothing ? 'Yes' : 'No' }}</span>
          </div>
          <div class="info-row">
            <span class="label">Fogged:</span>
            <span>{{ model.modelHeader.fogged ? 'Yes' : 'No' }}</span>
          </div>
        </div>

        <div class="info-section">
          <div class="section-header">Bounding Box</div>
          <div class="info-row">
            <span class="label">Min:</span>
            <span>({{ model.modelHeader.boundingMinX }}, 
                   {{ model.modelHeader.boundingMinY }}, 
                   {{ model.modelHeader.boundingMinZ }})</span>
          </div>
          <div class="info-row">
            <span class="label">Max:</span>
            <span>({{ model.modelHeader.boundingMaxX }}, 
                   {{ model.modelHeader.boundingMaxY }}, 
                   {{ model.modelHeader.boundingMaxZ }})</span>
          </div>
          <div class="info-row">
            <span class="label">Radius:</span>
            <span>{{ model.modelHeader.radius }}</span>
          </div>
        </div>
      </div>
    </aside>

    <div class="model-viewer">
      <ui3d-renderer-view :context="modelViewerService.getRenderer">
        <ui3d-overlay-component :context="modelViewerService.getRenderer"></ui3d-overlay-component>
      </ui3d-renderer-view>
    </div>
  </div>


</template>

<script lang="ts">
import { defineComponent, PropType, ref } from 'vue';

// import { KeyFrameTimelineComponent } from "@/components/DataPresentation/KeyFrameTimelineComponent";
// import { ModelViewerSidebarComponent } from "@/components/DataPresentation/ModelViewerSidebarComponent";
// import { UI3DOverlayComponent } from "@/components/DataPresentation/UI3DOverlayComponent";
import UI3DRendererView from "@/components/DataPresentation/3d-Renderer-View.vue";
import { ModelViewerService } from '@/components/ThreeRendering/ModelViewerState';
import { OdysseyModel3D } from '@/components/ThreeRendering/KotOR';

export default defineComponent({
  name: 'MdlRenderer',
  components: {
    // KeyFrameTimelineComponent,
    // ModelViewerSidebarComponent,
    // UI3DOverlayComponent,
    UI3DRendererView
  },
  props: {

    modelPath: {
      type: String,
      required: true
    },
    mdlId: {
      type: Number,
      required: true
    },
    mdxId: {
      type: Number,
      required: true
    }
  },
  async setup(props) {
    const modelViewerService = ref<ModelViewerService>(new ModelViewerService());
    const model = ref<OdysseyModel3D | null>(null);
    console.log(props.modelPath, props.mdlId, props.mdxId);
    model.value = await modelViewerService.value.loadModelAsync(props.modelPath, props.mdlId, props.mdxId);
    console.log(model.value);
    return {
      modelViewerService,
      model
    }
  },
  async onMounted() {
    
    
    console.log(this.$props.modelPath, this.$props.mdlId, this.$props.mdxId);
    this.model = await this.modelViewerService.loadModelAsync(this.$props.modelPath, this.$props.mdlId, this.$props.  mdxId);


  },
  // computed: {
  //   southPanel() {
  //     return <KeyFrameTimelineComponent tab={this.tab} />;
  //   },
  //   eastPanel() {
  //     return <ModelViewerSidebarComponent tab={this.tab} />;
  //   }
  // }
});
</script>

<style scoped>
  .model-viewer-container {
    display: flex;
    flex-direction: row;
    gap: 1rem;
  }
  .model-info {
    padding: 1rem;
    background: rgba(0, 0, 0, 0.8);
    color: white;
    position: absolute;
    top: 1rem;
    left: 1rem;
    border-radius: 4px;
    max-width: 300px;
    z-index: 100;
  }
  .span {
    font-size: 12px;
    color: #90CAF9;
  }

  .info-section {
    margin-bottom: 1rem;
  }

  .section-header {
    font-size: 14px;
    font-weight: bold;
    color: #90CAF9;
  }

  .info-section h4 {
    margin-bottom: 0.5rem;
    color: #4CAF50;
  }

  .info-row {
    display: flex;
    justify-content: space-between;
    margin-bottom: 0.25rem;
  }

  .label {
    font-weight: bold;
    color: #90CAF9;
  }
  </style>