export type UI3DRendererEventListenerTypes =
  'onBeforeRender'|'onAfterRender'|'onCreate'|'onDispose'|'onResize'|'onCanvasAttached';

export interface UI3DRendererEventListeners {
  onBeforeRender: Function[],
  onAfterRender:  Function[],
  onCreate:       Function[],
  onDispose:      Function[],
  onResize:       Function[],
  onCanvasAttached: Function[],
}