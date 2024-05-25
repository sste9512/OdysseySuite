import {defineStore} from "pinia";
import {resolve} from "@/injection/injection-context";
import type {IProjectManagementClient} from "@/clients/web-api-client";
import type {DirectoryInfo} from "@/web-api-client";

export const useProjectStore = defineStore('project', () => {
    
    // Value containers
    // const projects = ref(String[]{""})
    // const name = ref('Eduardo')
    // const bearerToken = ref('');

    const directories: DirectoryInfo[] = [];


    let client: IProjectManagementClient = resolve<IProjectManagementClient>('project-management');




    // function setBearer(bearer: string) {
    //     bearerToken.value = bearer;
    // }

    // async function signin(username: string, password: string): Promise<boolean> {
    //     const authClient = resolve<IUserManagementClient>("");
    //     const result = await authClient.authorize(username, password);
    //     if (result) {
    //         return result
    //     } else {
    //         return result
    //     }
    // }

    return {directories}
})