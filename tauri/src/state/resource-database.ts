import Dexie, { Table } from 'dexie';
import { ChitinKey, KeyEntry } from '@/data/chitin-key';
import { ErfFile, ErfKeyEntry } from '@/data/erf';
import { Rim, RimKeyEntry } from '@/data/rim';
import { Biff, BiffHeader, VResourceEntry, FResourceEntry } from '@/data/biff';
import { Result } from '@/models/Result';

export interface RelevantFile {
    id?: number;
    file_path: string;
}

export interface ResourceInfoReference<T>{
     id?: string;
     resource_type: number;
     resource_name: string;
     resource_id: number;
     file_path: string;
     resource_data: T;
}

export class ResourceDatabase extends Dexie {
    // Define tables
    chitinKeyResources!: Table<ResourceInfoReference<ChitinKey>, string>;
    keyEntryResources!: Table<ResourceInfoReference<KeyEntry>, string>;

    erfFileResources!: Table<ResourceInfoReference<ErfFile>, string>;
    erfKeyEntryResources!: Table<ResourceInfoReference<ErfKeyEntry>, string>;

    rimFileResources!: Table<ResourceInfoReference<Rim>, string>;
    rimKeyEntryResources!: Table<ResourceInfoReference<RimKeyEntry>, string>;

    biffFileResources!: Table<ResourceInfoReference<Biff>, string>;
    biffHeaderResources!: Table<ResourceInfoReference<BiffHeader>, string>;
    vResourceEntryResources!: Table<ResourceInfoReference<VResourceEntry>, string>;
    fResourceEntryResources!: Table<ResourceInfoReference<FResourceEntry>, string>;

    allFoundRelevantFiles!: Table<RelevantFile, number>;

    constructor() {
        super('GameDatabase');

        this.version(1).stores({
            // Store indexes for commonly queried fields
            chitinKeys: '++id, file_type, file_version',
            keyEntries: '++id, resref, resource_type, res_id',

            erfFiles: '++id, file_path',
            erfKeyEntries: '++id, filename, resource_id, resource_type',

            rimFiles: '++id',
            rimKeyEntries: '++id, resource_name, resource_type, resource_id',

            biffFiles: '++id',
            biffHeaders: '++id, file_type, file_version',
            vResourceEntries: '++id, resource_type',
            fResourceEntries: '++id, resource_type',

            allFoundRelevantFiles: '++id, file_path'
        });
    }

 

    // Helper methods for common operations
    async storeChitinKey(filePath: string, key: ChitinKey): Promise<Result<string, Error>> {
        try {
            const id = await this.chitinKeyResources.add({
                resource_type: 0,
                resource_name: filePath.split('/').pop() || '',
                resource_id: 0,
                file_path: filePath,
                resource_data: key
            });
            // Store associated key entries
            if (key.key_entries) {
                await this.keyEntryResources.bulkAdd(key.key_entries.map(entry => ({
                    resource_type: 1,
                    resource_name: entry.resref.toString(),
                    resource_id: entry.res_id,
                    file_path: filePath,
                    resource_data: entry
                })));
            }
            return { ok: true, value: id };
        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error(String(error)) };
        }
    }

    async storeAllFoundRelevantFiles(filePaths: string[]): Promise<Result<number, Error>> {
        try {
            // Convert string paths to RelevantFile objects
            const fileObjects = filePaths.map(path => ({
                file_path: path
            }));

            const ids = await this.allFoundRelevantFiles.bulkAdd(fileObjects);
            return { ok: true, value: ids };
        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error(String(error)) };
        }
    }

    async storeErfFile(filePath: string, erf: ErfFile): Promise<Result<string, Error>> {
        try {
            const id = await this.erfFileResources.add({
                resource_type: 2,
                resource_name: filePath.split('/').pop() || '',
                resource_id: 0,
                file_path: filePath,
                resource_data: erf
            });
            // Store associated key entries
            if (erf.key_list?.entries) {
                await this.erfKeyEntryResources.bulkAdd(erf.key_list.entries.map(entry => ({
                    resource_type: 2,
                    resource_name: entry.filename.toString(),
                    resource_id: entry.resource_id,
                    file_path: filePath,
                    resource_data: entry
                })));
            }
            return { ok: true, value: id };
        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error(String(error)) };
        }
    }

    async storeRimFile(filePath: string, rim: Rim): Promise<Result<string, Error>> {
        try {
            const id = await this.rimFileResources.add({
                resource_type: 3,
                resource_name: filePath.split('/').pop() || '',
                resource_id: 0,
                file_path: filePath,
                resource_data: rim
            });
            // Store key entries if they exist
            if (rim.key_entry_list) {
                await this.rimKeyEntryResources.bulkAdd(rim.key_entry_list.map(entry => ({
                    resource_type: 3,
                    resource_name: filePath.split('/').pop() || '',
                    resource_id: entry.resource_id,
                    file_path: filePath,
                    resource_data: entry
                })));
            }
            return { ok: true, value: id };
        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error(String(error)) };
        }
    }

    async storeBiffFile(filePath: string, biff: Biff): Promise<Result<string, Error>> {
        try {
            const id = await this.biffFileResources.add({
                resource_type: 4,
                resource_name: filePath.split('/').pop() || '',
                resource_id: 0,
                file_path: filePath,
                resource_data: biff
            });
            // Store header and resource entries
            await this.biffHeaderResources.add({
                resource_type: 4,
                resource_name: filePath.split('/').pop() || '',
                resource_id: 0,
                file_path: filePath,
                resource_data: biff.header
            });
            if (biff.variable_resources) {
                await this.vResourceEntryResources.bulkAdd(biff.variable_resources.map(entry => ({
                    resource_type: 4,
                    resource_name: filePath.split('/').pop() || '',
                    resource_id: entry.id,
                    file_path: filePath,
                    resource_data: entry
                })));
            }
            if (biff.fixed_resources) {
                await this.fResourceEntryResources.bulkAdd(biff.fixed_resources.map(entry => ({
                    resource_type: 4,
                    resource_name: filePath.split('/').pop() || '',
                    resource_id: entry.id,
                    file_path: filePath,
                    resource_data: entry
                })));
            }
            return { ok: true, value: id };
        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error(String(error)) };
        }
    }

    // Query helpers
    async findResourceByName(name: string): Promise<Result<KeyEntry[], Error>> {
        try {
            const results = await this.keyEntryResources
                .where('resource_name')
                .equals(name)
                .toArray();
            return { ok: true, value: results.map(result => result.resource_data) };
        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error(String(error)) };
        }
    }

    async findResourceByType(type: number): Promise<Result<KeyEntry[], Error>> {
        try {
            const results = await this.keyEntryResources
                .where('resource_type')
                .equals(type)
                .toArray();
            return { ok: true, value: results.map(result => result.resource_data) };
        } catch (error) {
            return { ok: false, error: error instanceof Error ? error : new Error(String(error)) };
        }
    }
}

// Create and export a singleton instance
export const resourceDB = new ResourceDatabase();
