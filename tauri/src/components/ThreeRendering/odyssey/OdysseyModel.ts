import { Result } from "@/models/Result";
import { BinaryReader } from "../BinaryReader";
import { OdysseyModelEngine } from "../enums/odyssey/OdysseyModelEngine";
import { OdysseyModelNodeType } from "../enums/odyssey/OdysseyModelNodeType";
import { IOdysseyArrayDefinition } from "../interface/odyssey/IOdysseyArrayDefinition";
import { IOdysseyFileHeader } from "../interface/odyssey/IOdysseyFileHeader";
import { IOdysseyGeometryHeader } from "../interface/odyssey/IOdysseyGeometryHeader";
import { IOdysseyModelHeader } from "../interface/odyssey/IOdysseyModelHeader";
import { OdysseyModelAnimation } from "./OdysseyModelAnimation";
import { OdysseyModelFactory } from "./OdysseyModelFactory";
import { OdysseyModelNode } from "./OdysseyModelNode";
import { OdysseyModelUtility } from "./OdysseyModelUtility";



export interface IProgress {
  type: string;
  current: number;
  total: number;
  message?: string;
}

export class Progress implements IProgress {
  type: string;
  current: number = 0;
  total: number = 0;
  message?: string;
  private observers: ((progress: IProgress) => void)[] = [];

  constructor(type: string, total: number = 0) {
    this.type = type;
    this.total = total;
  }

  update(current: number, message?: string) {
    this.current = current;
    if (message) {
      this.message = message;
    }
    this.notifyObservers();
  }

  setTotal(total: number) {
    this.total = total;
    this.notifyObservers();
  }

  getPercentage(): number {
    if (this.total === 0) return 0;
    return (this.current / this.total) * 100;
  }

  addObserver(observer: (progress: IProgress) => void) {
    this.observers.push(observer);
  }

  removeObserver(observer: (progress: IProgress) => void) {
    this.observers = this.observers.filter(obs => obs !== observer);
  }

  private notifyObservers() {
    this.observers.forEach(observer => {
      observer(this);
    });
  }
}



export function fromBytes(mdl: Uint8Array, mdx: Uint8Array): Result<IOdysseyModel, string> {
  try {
    // Create DataView readers for the MDL and MDX buffers
    const mdlReader = new DataView(mdl.buffer);
    const mdxReader = new DataView(mdx.buffer);

    // Create new model instance
    const model = {} as IOdysseyModel;

    // Track current buffer offset
    let offset = 0;

    // Read file header
    model.fileHeader.flagBinary = mdlReader.getUint32(offset);
    offset += 4;

    // Validate binary flag
    if (model.fileHeader.flagBinary != 0) {
      return { ok: false, error: "KotOR binary model not presented" };
    }

    // Read data sizes
    model.fileHeader.mdlDataSize = mdlReader.getUint32(offset);
    offset += 4;
    model.fileHeader.mdxDataSize = mdlReader.getUint32(offset);
    offset += 4;

    // Calculate data offsets
    model.fileHeader.modelDataOffset = 12;
    model.fileHeader.rawDataOffset = model.fileHeader.modelDataOffset + model.fileHeader.mdlDataSize;

    /*
     * Geometry Header
     */

    // Read function pointers
    model.geometryHeader.functionPointer0 = mdlReader.getUint32(offset);
    offset += 4;
    model.geometryHeader.functionPointer1 = mdlReader.getUint32(offset);
    offset += 4;

    // Determine engine version based on functionPointer0
    switch (model.geometryHeader.functionPointer0) {
      case 4273776:
        model.engine = OdysseyModelEngine.K1;
        break;
      case 4285200:
        model.engine = OdysseyModelEngine.K2;
        break;
      case 4254992:
        model.engine = OdysseyModelEngine.K1_XBOX;
        break;
      case 4285872:
        model.engine = OdysseyModelEngine.K2_XBOX;
        break;
    }

    // Read model name (32 chars)
    const modelNameBytes = new Uint8Array(mdl.buffer, offset, 32);
    model.geometryHeader.modelName = new TextDecoder().decode(modelNameBytes).replace(/\0[\s\S]*$/g, '');
    offset += 32;

    // Read node info
    model.geometryHeader.rootNodeOffset = mdlReader.getUint32(offset);
    offset += 4;
    model.geometryHeader.nodeCount = mdlReader.getUint32(offset);
    offset += 4;

    // Read array definitions
    model.geometryHeader.unknown1ArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
    offset += 8;
    model.geometryHeader.unknown2ArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
    offset += 8;

    // Read reference count and geometry type
    model.geometryHeader.refCount = mdlReader.getUint32(offset);
    offset += 4;
    model.geometryHeader.geometryType = mdlReader.getUint8(offset);
    offset += 1;
    model.geometryHeader.unknown4 = new Uint8Array(mdl.buffer, offset, 3);
    offset += 3;

    /*
     * Model Header
     */

    // Read model classifications
    model.modelHeader.classification = mdlReader.getUint8(offset);
    offset += 1;
    model.modelHeader.subClassification = mdlReader.getUint8(offset);
    offset += 1;
    model.modelHeader.smoothing = !!mdlReader.getUint8(offset);
    offset += 1;
    model.modelHeader.fogged = !!mdlReader.getUint8(offset);
    offset += 1;
    model.modelHeader.childModelCount = mdlReader.getUint32(offset);
    offset += 4;

    // Read animation array definition
    model.modelHeader.animationArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
    offset += 8;

    // Read parent model pointer
    model.modelHeader.parentModelPointer = mdlReader.getUint32(offset);
    offset += 4;

    // Read bounding box coordinates
    model.modelHeader.boundingMinX = mdlReader.getFloat32(offset);
    offset += 4;
    model.modelHeader.boundingMinY = mdlReader.getFloat32(offset);
    offset += 4;
    model.modelHeader.boundingMinZ = mdlReader.getFloat32(offset);
    offset += 4;
    model.modelHeader.boundingMaxX = mdlReader.getFloat32(offset);
    offset += 4;
    model.modelHeader.boundingMaxY = mdlReader.getFloat32(offset);
    offset += 4;
    model.modelHeader.boundingMaxZ = mdlReader.getFloat32(offset);
    offset += 4;
    model.modelHeader.radius = mdlReader.getFloat32(offset);
    offset += 4;
    model.modelHeader.scale = mdlReader.getFloat32(offset);
    offset += 4;

    // Seek to super model name
    offset = 148;

    // Read super model name (32 chars)
    const superModelNameBytes = new Uint8Array(mdl.buffer, offset, 32);
    model.modelHeader.superModelName = new TextDecoder().decode(superModelNameBytes).replace(/\0[\s\S]*$/g, '');
    offset += 32;

    /*
     * Names Array Header
     */

    // Read additional node offsets and padding
    model.geometryHeader.rootNodeOffset2 = mdlReader.getUint32(offset);
    offset += 4;
    model.geometryHeader.padding = mdlReader.getUint32(offset);
    offset += 4;
    model.geometryHeader.mdxLength = mdlReader.getUint32(offset);
    offset += 4;
    model.geometryHeader.mdxOffset = mdlReader.getUint32(offset);
    offset += 4;

    // Read names array definition
    model.namesArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
    offset += 8;

    // Read name offsets array
    model.nameOffsetsArray = OdysseyModelUtility.ReadArrayDV(
      mdlReader,
      model.fileHeader.modelDataOffset + model.namesArrayDefinition.offset,
      model.namesArrayDefinition.count
    );

    // Read and process names
    model.names = OdysseyModelUtility.ReadStringsDV(
      mdlReader,
      model.nameOffsetsArray,
      model.fileHeader.modelDataOffset
    );

    // Clean up and lowercase names
    for (let i = 0, namesLen = model.names.length; i < namesLen; i++) {
      model.names[i] = model.names[i].replace(/\0[\s\S]*$/g, '').toLowerCase();
    }

    /*
     * Nodes
     */

    // Read root node
    model.rootNode = model.readNode(model.geometryHeader.rootNodeOffset);

    /*
     * Animations
     */

    // Read animation offsets
    const animOffsets = OdysseyModelUtility.ReadArrayDV(
      mdlReader,
      model.fileHeader.modelDataOffset + model.modelHeader.animationArrayDefinition.offset,
      model.modelHeader.animationArrayDefinition.count
    );

    // Read each animation
    for (let i = 0; i < model.modelHeader.animationArrayDefinition.count; i++) {
      model.readAnimation(model.fileHeader.modelDataOffset + animOffsets[i]);
    }

    return { ok: true, value: model };
  } catch (error) {
    return { ok: false, error: error.toString() };
  }
}


export interface IOdysseyModel {
  mdlReader: BinaryReader;
  mdxReader: BinaryReader;

  fileHeader: IOdysseyFileHeader;
  geometryHeader: IOdysseyGeometryHeader;
  modelHeader: IOdysseyModelHeader;

  animations: OdysseyModelAnimation[];
  rootNode: OdysseyModelNode;
  engine: OdysseyModelEngine;

  names: string[];
  nodes: Map<string, OdysseyModelNode>;

  namesArrayDefinition: IOdysseyArrayDefinition;
  nameOffsetsArray: number[];

  toFormattedString(): string;


}

export class OdysseyModel implements IOdysseyModel {

  mdlReader: BinaryReader;
  mdxReader: BinaryReader;

  fileHeader: IOdysseyFileHeader = {} as IOdysseyFileHeader;
  geometryHeader: IOdysseyGeometryHeader = {} as IOdysseyGeometryHeader;
  modelHeader: IOdysseyModelHeader = {} as IOdysseyModelHeader;

  animations: OdysseyModelAnimation[] = [];
  rootNode: OdysseyModelNode;
  engine: OdysseyModelEngine;

  names: string[];
  nodes: Map<string, OdysseyModelNode> = new Map();

  namesArrayDefinition: IOdysseyArrayDefinition;
  nameOffsetsArray: number[] = [];


  constructor( mdlReader: BinaryReader, mdxReader: BinaryReader ){

    this.mdlReader = mdlReader;
    this.mdxReader = mdxReader;

    this.fileHeader.flagBinary = this.mdlReader.readUInt32();

    if (this.fileHeader.flagBinary != 0){
      throw ("KotOR binary model not presented");
    }

    this.fileHeader.mdlDataSize = this.mdlReader.readUInt32();
    this.fileHeader.mdxDataSize = this.mdlReader.readUInt32();

    this.fileHeader.modelDataOffset = 12;
    this.fileHeader.rawDataOffset = this.fileHeader.modelDataOffset + this.fileHeader.mdlDataSize;

    /*
     * Geometry Header
     */

    this.geometryHeader.functionPointer0 = this.mdlReader.readUInt32(); //4Byte Function pointer
    this.geometryHeader.functionPointer1 = this.mdlReader.readUInt32(); //4Byte Function pointer

    //Thanks bead-v :)
    //Use FunctionPointer0 in the geometry header to determine the engine version the model was prepared for.
    switch(this.geometryHeader.functionPointer0){
      case 4273776: //K1
        this.engine = OdysseyModelEngine.K1;
      break;
      case 4285200: //K2
        this.engine = OdysseyModelEngine.K2;
      break;
      case 4254992: //K1_XBOX
        this.engine = OdysseyModelEngine.K1_XBOX;
      break;
      case 4285872: //K2_XBOX
        this.engine = OdysseyModelEngine.K2_XBOX;
      break;
    }

    this.geometryHeader.modelName = this.mdlReader.readChars(32).replace(/\0[\s\S]*$/g,'');
    this.geometryHeader.rootNodeOffset = this.mdlReader.readUInt32();
    this.geometryHeader.nodeCount = this.mdlReader.readUInt32();

    this.geometryHeader.unknown1ArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);
    this.geometryHeader.unknown2ArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);

    this.geometryHeader.refCount = this.mdlReader.readUInt32();
    this.geometryHeader.geometryType = this.mdlReader.readByte(); //Model Type
    this.geometryHeader.unknown4 = this.mdlReader.readBytes(3); //Padding

    /*
     * Model Header
     */
    
    this.modelHeader.classification = this.mdlReader.readByte();
    this.modelHeader.subClassification = this.mdlReader.readByte();
    this.modelHeader.smoothing = !!this.mdlReader.readByte(); //Unknown
    this.modelHeader.fogged = !!this.mdlReader.readByte();
    this.modelHeader.childModelCount = this.mdlReader.readUInt32(); //Unkown

    this.modelHeader.animationArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);

    this.modelHeader.parentModelPointer = this.mdlReader.readUInt32(); // Parent model pointer

    this.modelHeader.boundingMinX = this.mdlReader.readSingle();
    this.modelHeader.boundingMinY = this.mdlReader.readSingle();
    this.modelHeader.boundingMinZ = this.mdlReader.readSingle();
    this.modelHeader.boundingMaxX = this.mdlReader.readSingle();
    this.modelHeader.boundingMaxY = this.mdlReader.readSingle();
    this.modelHeader.boundingMaxZ = this.mdlReader.readSingle();
    this.modelHeader.radius = this.mdlReader.readSingle();
    this.modelHeader.scale = this.mdlReader.readSingle();
    this.mdlReader.seek(148);
    this.modelHeader.superModelName = this.mdlReader.readChars(32).replace(/\0[\s\S]*$/g,'');
    
    /*
     * Names Array Header
     */

    this.geometryHeader.rootNodeOffset2 = this.mdlReader.readUInt32();
    this.geometryHeader.padding = this.mdlReader.readUInt32();
    this.geometryHeader.mdxLength = this.mdlReader.readUInt32();
    this.geometryHeader.mdxOffset = this.mdlReader.readUInt32();

    this.namesArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(this.mdlReader);
    this.nameOffsetsArray = OdysseyModelUtility.ReadArray(this.mdlReader, this.fileHeader.modelDataOffset + this.namesArrayDefinition.offset, this.namesArrayDefinition.count);

    this.names = OdysseyModelUtility.ReadStrings(this.mdlReader, this.nameOffsetsArray, this.fileHeader.modelDataOffset);
    for(let i = 0, namesLen = this.names.length; i < namesLen; i++){
      this.names[i] = this.names[i].replace(/\0[\s\S]*$/g,'').toLowerCase();
    }

    /*
     * Nodes
     */

    this.rootNode = this.readNode( this.geometryHeader.rootNodeOffset );

    /*
     * Animations
     */

    let animOffsets = OdysseyModelUtility.ReadArray(mdlReader, this.fileHeader.modelDataOffset + this.modelHeader.animationArrayDefinition.offset, this.modelHeader.animationArrayDefinition.count);
    for (let i = 0; i < this.modelHeader.animationArrayDefinition.count; i++){
      this.readAnimation( this.fileHeader.modelDataOffset + animOffsets[i] );
    }

    this.mdlReader.dispose();
    this.mdxReader.dispose();

  }
  

  // NOTE:
  // this is to replace the original constructor which limited the ability to pass data and construct the model from differenct sources
  static fromFile(mdl: Uint8Array, mdx: Uint8Array) {

    const mdlReader = new BinaryReader(mdl);
    const mdxReader = new BinaryReader(mdx);

    const model = new OdysseyModel();

    model.fileHeader.flagBinary = mdlReader.readUInt32();

    if (model.fileHeader.flagBinary != 0) {
      throw ("KotOR binary model not presented");
    }

    model.fileHeader.mdlDataSize = mdlReader.readUInt32();
    model.fileHeader.mdxDataSize = mdlReader.readUInt32();

    model.fileHeader.modelDataOffset = 12;
    model.fileHeader.rawDataOffset = model.fileHeader.modelDataOffset + model.fileHeader.mdlDataSize;

    /*
     * Geometry Header
     */

    model.geometryHeader.functionPointer0 = mdlReader.readUInt32(); //4Byte Function pointer
    model.geometryHeader.functionPointer1 = mdlReader.readUInt32(); //4Byte Function pointer

    //Thanks bead-v :)
    //Use FunctionPointer0 in the geometry header to determine the engine version the model was prepared for.
    switch (model.geometryHeader.functionPointer0) {
      case 4273776: //K1
        model.engine = OdysseyModelEngine.K1;
        break;
      case 4285200: //K2
        model.engine = OdysseyModelEngine.K2;
        break;
      case 4254992: //K1_XBOX
        model.engine = OdysseyModelEngine.K1_XBOX;
        break;
      case 4285872: //K2_XBOX
        model.engine = OdysseyModelEngine.K2_XBOX;
        break;
    }

    model.geometryHeader.modelName = mdlReader.readChars(32).replace(/\0[\s\S]*$/g, '');
    model.geometryHeader.rootNodeOffset = mdlReader.readUInt32();
    model.geometryHeader.nodeCount = mdlReader.readUInt32();

    model.geometryHeader.unknown1ArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);
    model.geometryHeader.unknown2ArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);

    model.geometryHeader.refCount = mdlReader.readUInt32();
    model.geometryHeader.geometryType = mdlReader.readByte(); //Model Type
    model.geometryHeader.unknown4 = mdlReader.readBytes(3); //Padding

    /*
     * Model Header
     */

    model.modelHeader.classification = mdlReader.readByte();
    model.modelHeader.subClassification = mdlReader.readByte();
    model.modelHeader.smoothing = !!mdlReader.readByte(); //Unknown
    model.modelHeader.fogged = !!mdlReader.readByte();
    model.modelHeader.childModelCount = mdlReader.readUInt32(); //Unkown

    model.modelHeader.animationArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);

    model.modelHeader.parentModelPointer = mdlReader.readUInt32(); // Parent model pointer

    model.modelHeader.boundingMinX = mdlReader.readSingle();
    model.modelHeader.boundingMinY = mdlReader.readSingle();
    model.modelHeader.boundingMinZ = mdlReader.readSingle();
    model.modelHeader.boundingMaxX = mdlReader.readSingle();
    model.modelHeader.boundingMaxY = mdlReader.readSingle();
    model.modelHeader.boundingMaxZ = mdlReader.readSingle();
    model.modelHeader.radius = mdlReader.readSingle();
    model.modelHeader.scale = mdlReader.readSingle();
    mdlReader.seek(148);
    model.modelHeader.superModelName = mdlReader.readChars(32).replace(/\0[\s\S]*$/g, '');

    /*
     * Names Array Header
     */

    model.geometryHeader.rootNodeOffset2 = mdlReader.readUInt32();
    model.geometryHeader.padding = mdlReader.readUInt32();
    model.geometryHeader.mdxLength = mdlReader.readUInt32();
    model.geometryHeader.mdxOffset = mdlReader.readUInt32();

    model.namesArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);
    model.nameOffsetsArray = OdysseyModelUtility.ReadArray(mdlReader, model.fileHeader.modelDataOffset + model.namesArrayDefinition.offset, model.namesArrayDefinition.count);

    model.names = OdysseyModelUtility.ReadStrings(mdlReader, model.nameOffsetsArray, model.fileHeader.modelDataOffset);
    for (let i = 0, namesLen = model.names.length; i < namesLen; i++) {
      model.names[i] = model.names[i].replace(/\0[\s\S]*$/g, '').toLowerCase();
    }

    /*
     * Nodes
     */

    model.rootNode = model.readNode(model.geometryHeader.rootNodeOffset);

    /*
     * Animations
     */

    let animOffsets = OdysseyModelUtility.ReadArray(mdlReader, model.fileHeader.modelDataOffset + model.modelHeader.animationArrayDefinition.offset, model.modelHeader.animationArrayDefinition.count);
    for (let i = 0; i < model.modelHeader.animationArrayDefinition.count; i++) {
      model.readAnimation(model.fileHeader.modelDataOffset + animOffsets[i]);
    }

    mdlReader.dispose();
    mdxReader.dispose();

    return model;

  }

  static fromBytes(mdl: Uint8Array, mdx: Uint8Array): Result<OdysseyModel, string> {
    try {
      // Create DataView readers for the MDL and MDX buffers
      const mdlReader = new DataView(mdl.buffer);
      const mdxReader = new DataView(mdx.buffer);

      // Create new model instance
      const model = new OdysseyModel();

      // Track current buffer offset
      let offset = 0;

      // Read file header
      model.fileHeader.flagBinary = mdlReader.getUint32(offset);
      offset += 4;

      // Validate binary flag
      if (model.fileHeader.flagBinary != 0) {
        return { ok: false, error: "KotOR binary model not presented" };
      }

      // Read data sizes
      model.fileHeader.mdlDataSize = mdlReader.getUint32(offset);
      offset += 4;
      model.fileHeader.mdxDataSize = mdlReader.getUint32(offset);
      offset += 4;

      // Calculate data offsets
      model.fileHeader.modelDataOffset = 12;
      model.fileHeader.rawDataOffset = model.fileHeader.modelDataOffset + model.fileHeader.mdlDataSize;

      /*
       * Geometry Header
       */

      // Read function pointers
      model.geometryHeader.functionPointer0 = mdlReader.getUint32(offset);
      offset += 4;
      model.geometryHeader.functionPointer1 = mdlReader.getUint32(offset);
      offset += 4;

      // Determine engine version based on functionPointer0
      switch (model.geometryHeader.functionPointer0) {
        case 4273776:
          model.engine = OdysseyModelEngine.K1;
          break;
        case 4285200:
          model.engine = OdysseyModelEngine.K2;
          break;
        case 4254992:
          model.engine = OdysseyModelEngine.K1_XBOX;
          break;
        case 4285872:
          model.engine = OdysseyModelEngine.K2_XBOX;
          break;
      }

      // Read model name (32 chars)
      const modelNameBytes = new Uint8Array(mdl.buffer, offset, 32);
      model.geometryHeader.modelName = new TextDecoder().decode(modelNameBytes).replace(/\0[\s\S]*$/g, '');
      offset += 32;

      // Read node info
      model.geometryHeader.rootNodeOffset = mdlReader.getUint32(offset);
      offset += 4;
      model.geometryHeader.nodeCount = mdlReader.getUint32(offset);
      offset += 4;

      // Read array definitions
      model.geometryHeader.unknown1ArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
      offset += 8;
      model.geometryHeader.unknown2ArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
      offset += 8;

      // Read reference count and geometry type
      model.geometryHeader.refCount = mdlReader.getUint32(offset);
      offset += 4;
      model.geometryHeader.geometryType = mdlReader.getUint8(offset);
      offset += 1;
      model.geometryHeader.unknown4 = new Uint8Array(mdl.buffer, offset, 3);
      offset += 3;

      /*
       * Model Header
       */

      // Read model classifications
      model.modelHeader.classification = mdlReader.getUint8(offset);
      offset += 1;
      model.modelHeader.subClassification = mdlReader.getUint8(offset);
      offset += 1;
      model.modelHeader.smoothing = !!mdlReader.getUint8(offset);
      offset += 1;
      model.modelHeader.fogged = !!mdlReader.getUint8(offset);
      offset += 1;
      model.modelHeader.childModelCount = mdlReader.getUint32(offset);
      offset += 4;

      // Read animation array definition
      model.modelHeader.animationArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
      offset += 8;

      // Read parent model pointer
      model.modelHeader.parentModelPointer = mdlReader.getUint32(offset);
      offset += 4;

      // Read bounding box coordinates
      model.modelHeader.boundingMinX = mdlReader.getFloat32(offset);
      offset += 4;
      model.modelHeader.boundingMinY = mdlReader.getFloat32(offset);
      offset += 4;
      model.modelHeader.boundingMinZ = mdlReader.getFloat32(offset);
      offset += 4;
      model.modelHeader.boundingMaxX = mdlReader.getFloat32(offset);
      offset += 4;
      model.modelHeader.boundingMaxY = mdlReader.getFloat32(offset);
      offset += 4;
      model.modelHeader.boundingMaxZ = mdlReader.getFloat32(offset);
      offset += 4;
      model.modelHeader.radius = mdlReader.getFloat32(offset);
      offset += 4;
      model.modelHeader.scale = mdlReader.getFloat32(offset);
      offset += 4;

      // Seek to super model name
      offset = 148;

      // Read super model name (32 chars)
      const superModelNameBytes = new Uint8Array(mdl.buffer, offset, 32);
      model.modelHeader.superModelName = new TextDecoder().decode(superModelNameBytes).replace(/\0[\s\S]*$/g, '');
      offset += 32;

      /*
       * Names Array Header
       */

      // Read additional node offsets and padding
      model.geometryHeader.rootNodeOffset2 = mdlReader.getUint32(offset);
      offset += 4;
      model.geometryHeader.padding = mdlReader.getUint32(offset);
      offset += 4;
      model.geometryHeader.mdxLength = mdlReader.getUint32(offset);
      offset += 4;
      model.geometryHeader.mdxOffset = mdlReader.getUint32(offset);
      offset += 4;

      // Read names array definition
      model.namesArrayDefinition = OdysseyModelUtility.ReadArrayDefinitionDV(mdlReader, offset);
      offset += 8;

      // Read name offsets array
      model.nameOffsetsArray = OdysseyModelUtility.ReadArrayDV(
        mdlReader,
        model.fileHeader.modelDataOffset + model.namesArrayDefinition.offset,
        model.namesArrayDefinition.count
      );

      // Read and process names
      model.names = OdysseyModelUtility.ReadStringsDV(
        mdlReader,
        model.nameOffsetsArray,
        model.fileHeader.modelDataOffset
      );

      // Clean up and lowercase names
      for (let i = 0, namesLen = model.names.length; i < namesLen; i++) {
        model.names[i] = model.names[i].replace(/\0[\s\S]*$/g, '').toLowerCase();
      }

      /*
       * Nodes
       */

      // Read root node
      model.rootNode = model.readNode(model.geometryHeader.rootNodeOffset);

      /*
       * Animations
       */

      // Read animation offsets
      const animOffsets = OdysseyModelUtility.ReadArrayDV(
        mdlReader,
        model.fileHeader.modelDataOffset + model.modelHeader.animationArrayDefinition.offset,
        model.modelHeader.animationArrayDefinition.count
      );

      // Read each animation
      for (let i = 0; i < model.modelHeader.animationArrayDefinition.count; i++) {
        model.readAnimation(model.fileHeader.modelDataOffset + animOffsets[i]);
      }

      return { ok: true, value: model };
    } catch (error) {
      return { ok: false, error: error.toString() };
    }
  }


  toFormattedString(): string {
    let output = 'OdysseyModel:\n';

    // File Header
    output += '  FileHeader:\n';
    output += `    FlagBinary: ${this.fileHeader.flagBinary}\n`;
    output += `    MDL Data Size: ${this.fileHeader.mdlDataSize}\n`;
    output += `    MDX Data Size: ${this.fileHeader.mdxDataSize}\n`;
    output += `    Model Data Offset: ${this.fileHeader.modelDataOffset}\n`;
    output += `    Raw Data Offset: ${this.fileHeader.rawDataOffset}\n`;

    // Geometry Header
    output += '  GeometryHeader:\n';
    output += `    Function Pointer 0: ${this.geometryHeader.functionPointer0}\n`;
    output += `    Function Pointer 1: ${this.geometryHeader.functionPointer1}\n`;
    output += `    Model Name: ${this.geometryHeader.modelName}\n`;
    output += `    Root Node Offset: ${this.geometryHeader.rootNodeOffset}\n`;
    output += `    Node Count: ${this.geometryHeader.nodeCount}\n`;
    output += `    Reference Count: ${this.geometryHeader.refCount}\n`;
    output += `    Geometry Type: ${this.geometryHeader.geometryType}\n`;

    // Model Header
    output += '  ModelHeader:\n';
    output += `    Classification: ${this.modelHeader.classification}\n`;
    output += `    SubClassification: ${this.modelHeader.subClassification}\n`;
    output += `    Smoothing: ${this.modelHeader.smoothing}\n`;
    output += `    Fogged: ${this.modelHeader.fogged}\n`;
    output += `    Child Model Count: ${this.modelHeader.childModelCount}\n`;
    output += `    Parent Model Pointer: ${this.modelHeader.parentModelPointer}\n`;
    output += `    Super Model Name: ${this.modelHeader.superModelName}\n`;

    // Bounding Box
    output += '  BoundingBox:\n';
    output += `    Min: (${this.modelHeader.boundingMinX}, ${this.modelHeader.boundingMinY}, ${this.modelHeader.boundingMinZ})\n`;
    output += `    Max: (${this.modelHeader.boundingMaxX}, ${this.modelHeader.boundingMaxY}, ${this.modelHeader.boundingMaxZ})\n`;
    output += `    Radius: ${this.modelHeader.radius}\n`;
    output += `    Scale: ${this.modelHeader.scale}\n`;

    // Engine
    output += `  Engine: ${OdysseyModelEngine[this.engine]}\n`;

    // Names
    output += '  Names:\n';
    this.names.forEach((name, i) => {
      output += `    ${i}: ${name}\n`;
    });

    // Animations
    output += `  Animation Count: ${this.animations.length}\n`;

    return output;
  }

  // constructor(mdlReader: BinaryReader, mdxReader: BinaryReader) {

  //   this.mdlReader = mdlReader;
  //   this.mdxReader = mdxReader;

  //   this.fileHeader.flagBinary = this.mdlReader.readUInt32();

  //   if (this.fileHeader.flagBinary != 0) {
  //     throw ("KotOR binary model not presented");
  //   }

  //   this.fileHeader.mdlDataSize = this.mdlReader.readUInt32();
  //   this.fileHeader.mdxDataSize = this.mdlReader.readUInt32();

  //   this.fileHeader.modelDataOffset = 12;
  //   this.fileHeader.rawDataOffset = this.fileHeader.modelDataOffset + this.fileHeader.mdlDataSize;

  //   /*
  //    * Geometry Header
  //    */

  //   this.geometryHeader.functionPointer0 = this.mdlReader.readUInt32(); //4Byte Function pointer
  //   this.geometryHeader.functionPointer1 = this.mdlReader.readUInt32(); //4Byte Function pointer

  //   //Thanks bead-v :)
  //   //Use FunctionPointer0 in the geometry header to determine the engine version the model was prepared for.
  //   switch (this.geometryHeader.functionPointer0) {
  //     case 4273776: //K1
  //       this.engine = OdysseyModelEngine.K1;
  //       break;
  //     case 4285200: //K2
  //       this.engine = OdysseyModelEngine.K2;
  //       break;
  //     case 4254992: //K1_XBOX
  //       this.engine = OdysseyModelEngine.K1_XBOX;
  //       break;
  //     case 4285872: //K2_XBOX
  //       this.engine = OdysseyModelEngine.K2_XBOX;
  //       break;
  //   }

  //   this.geometryHeader.modelName = this.mdlReader.readChars(32).replace(/\0[\s\S]*$/g, '');
  //   this.geometryHeader.rootNodeOffset = this.mdlReader.readUInt32();
  //   this.geometryHeader.nodeCount = this.mdlReader.readUInt32();

  //   this.geometryHeader.unknown1ArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);
  //   this.geometryHeader.unknown2ArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);

  //   this.geometryHeader.refCount = this.mdlReader.readUInt32();
  //   this.geometryHeader.geometryType = this.mdlReader.readByte(); //Model Type
  //   this.geometryHeader.unknown4 = this.mdlReader.readBytes(3); //Padding

  //   /*
  //    * Model Header
  //    */

  //   this.modelHeader.classification = this.mdlReader.readByte();
  //   this.modelHeader.subClassification = this.mdlReader.readByte();
  //   this.modelHeader.smoothing = !!this.mdlReader.readByte(); //Unknown
  //   this.modelHeader.fogged = !!this.mdlReader.readByte();
  //   this.modelHeader.childModelCount = this.mdlReader.readUInt32(); //Unkown

  //   this.modelHeader.animationArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(mdlReader);

  //   this.modelHeader.parentModelPointer = this.mdlReader.readUInt32(); // Parent model pointer

  //   this.modelHeader.boundingMinX = this.mdlReader.readSingle();
  //   this.modelHeader.boundingMinY = this.mdlReader.readSingle();
  //   this.modelHeader.boundingMinZ = this.mdlReader.readSingle();
  //   this.modelHeader.boundingMaxX = this.mdlReader.readSingle();
  //   this.modelHeader.boundingMaxY = this.mdlReader.readSingle();
  //   this.modelHeader.boundingMaxZ = this.mdlReader.readSingle();
  //   this.modelHeader.radius = this.mdlReader.readSingle();
  //   this.modelHeader.scale = this.mdlReader.readSingle();
  //   this.mdlReader.seek(148);
  //   this.modelHeader.superModelName = this.mdlReader.readChars(32).replace(/\0[\s\S]*$/g, '');

  //   /*
  //    * Names Array Header
  //    */

  //   this.geometryHeader.rootNodeOffset2 = this.mdlReader.readUInt32();
  //   this.geometryHeader.padding = this.mdlReader.readUInt32();
  //   this.geometryHeader.mdxLength = this.mdlReader.readUInt32();
  //   this.geometryHeader.mdxOffset = this.mdlReader.readUInt32();

  //   this.namesArrayDefinition = OdysseyModelUtility.ReadArrayDefinition(this.mdlReader);
  //   this.nameOffsetsArray = OdysseyModelUtility.ReadArray(this.mdlReader, this.fileHeader.modelDataOffset + this.namesArrayDefinition.offset, this.namesArrayDefinition.count);

  //   this.names = OdysseyModelUtility.ReadStrings(this.mdlReader, this.nameOffsetsArray, this.fileHeader.modelDataOffset);
  //   for (let i = 0, namesLen = this.names.length; i < namesLen; i++) {
  //     this.names[i] = this.names[i].replace(/\0[\s\S]*$/g, '').toLowerCase();
  //   }

  //   /*
  //    * Nodes
  //    */

  //   this.rootNode = this.readNode(this.geometryHeader.rootNodeOffset);

  //   /*
  //    * Animations
  //    */

  //   let animOffsets = OdysseyModelUtility.ReadArray(mdlReader, this.fileHeader.modelDataOffset + this.modelHeader.animationArrayDefinition.offset, this.modelHeader.animationArrayDefinition.count);
  //   for (let i = 0; i < this.modelHeader.animationArrayDefinition.count; i++) {
  //     this.readAnimation(this.fileHeader.modelDataOffset + animOffsets[i]);
  //   }

  //   this.mdlReader.dispose();
  //   this.mdxReader.dispose();

  // }

  readNode(offset: number, parent = this.rootNode) {

    this.mdlReader.position = this.fileHeader.modelDataOffset + offset;
    // let node: OdysseyModelNode;

    let node = OdysseyModelFactory.ReadNode(parent, this.mdlReader);

    if (node) {
      node.readBinary(this);
      node.odysseyModel = undefined;

      for (let i = 0, len = node.childOffsets.length; i < len; i++) {
        node.add(this.readNode(node.childOffsets[i], node));
      }

      return node;
    } else {
      console.error('OdysseyModel.ReadNode', 'Unhandled Node', node.nodeType);
    }

    return node;
  }

  readAnimation(offset: number) {
    let pos = this.mdlReader.position;
    this.mdlReader.seek(offset);

    let anim = new OdysseyModelAnimation();
    anim.readBinary(this);

    this.animations.push(anim);
    this.mdlReader.seek(pos);

    return anim;
  }



}
