import {container} from "tsyringe";
import type {AxiosInstance} from "axios";
import axios from "axios";
import {useAuthStore} from "@/state/auth-state";
import {
    FileExplorationClient,
    type IFileExplorationClient,
    type IProjectManagementClient, 
    type IResourceEndpointsClient,
    ProjectManagementClient, ResourceEndpointsClient
} from "@/clients/web-api-client";


// TODO: Add bearer token here
export class InjectionContext {
    constructor() {
        
        const serverUrl = "http://localhost:5090";
        container.register<AxiosInstance>('axios-instance', {
            useFactory: () => {
                const authState = useAuthStore();
                return axios.create({
                    baseURL: serverUrl,
                    timeout: 1000,
                    headers: {Authorization: `Bearer ${authState}`}
                })
            }
        })

        container.register<IProjectManagementClient>('project-client', {
            useFactory: (c) => {
                return new ProjectManagementClient(serverUrl, c.resolve<AxiosInstance>("axios-instance"))
            }
        })
        
        container.register<IFileExplorationClient>('file-exploration-client', {
            useFactory: (c) => {
                return new FileExplorationClient(serverUrl, c.resolve<AxiosInstance>("axios-instance"))
            }
        })
        
        container.register<IResourceEndpointsClient>('resources-client', {
            useFactory:(c) => {
                 return new ResourceEndpointsClient(serverUrl, c.resolve<AxiosInstance>("axios-instance"))
            }
        })
        
    }
}

export function resolve<T>(key: string) {
    return container.resolve<T>(key);
}