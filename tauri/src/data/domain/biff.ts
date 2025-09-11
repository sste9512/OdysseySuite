export class BiffHeader {
    file_type: string;
    file_version: string;
    variable_resource_count: number;
    fixed_resource_count: number;
    variable_table_offset: number;

    constructor() {
        this.file_type = '';
        this.file_version = '';
        this.variable_resource_count = 0;
        this.fixed_resource_count = 0;
        this.variable_table_offset = 0;
    }
}

export class VResourceEntry {
    id: number;
    offset: number;
    file_size: number;
    resource_type: number;

    constructor() {
        this.id = 0;
        this.offset = 0;
        this.file_size = 0;
        this.resource_type = 0;
    }
}

export class FResourceEntry {
    id: number;
    offset: number;
    part_count: number;
    file_size: number;
    resource_type: number;

    constructor() {
        this.id = 0;
        this.offset = 0;
        this.part_count = 0;
        this.file_size = 0;
        this.resource_type = 0;
    }
}

export class VariableResourceData {
    data: Uint8Array;

    constructor() {
        this.data = new Uint8Array();
    }
}

export class FixedResourceData {
    data: Uint8Array;

    constructor() {
        this.data = new Uint8Array();
    }
}

export class Biff {
    header: BiffHeader;
    variable_resources: VResourceEntry[];
    fixed_resources: FResourceEntry[];
    variable_resource_data: VariableResourceData[];
    fixed_resource_data: FixedResourceData[];

    constructor() {
        this.header = new BiffHeader();
        this.variable_resources = [];
        this.fixed_resources = [];
        this.variable_resource_data = [];
        this.fixed_resource_data = [];
    }
}