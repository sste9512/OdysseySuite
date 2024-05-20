import type {IFileExplorationClient} from "@/clients/web-api-client";
import {defineStore} from "pinia";
import {resolve} from "@/injection/injection-context";


export const useDirectoryStore = defineStore('dir-explorer', () => {

    async function viewDirectory(path: string) {
        const client = resolve<IFileExplorationClient>('file-exploration-client');
        return await client.viewDirectory(path);
    }

    async function findLogicalDrives()   {
        const client = resolve<IFileExplorationClient>('file-exploration-client');
        return await client.findLogicalDrives();
    }
  

    return {viewDirectory, findLogicalDrives}
})
