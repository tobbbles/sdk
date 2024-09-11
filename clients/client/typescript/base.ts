/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.0
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


import type { Configuration } from './configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import type { AxiosPromise, AxiosInstance, RawAxiosRequestConfig } from 'axios';
import globalAxios from 'axios';

export const BASE_PATH = "https://.projects.oryapis.com".replace(/\/+$/, "");

/**
 *
 * @export
 */
export const COLLECTION_FORMATS = {
    csv: ",",
    ssv: " ",
    tsv: "\t",
    pipes: "|",
};

/**
 *
 * @export
 * @interface RequestArgs
 */
export interface RequestArgs {
    url: string;
    options: RawAxiosRequestConfig;
}

/**
 *
 * @export
 * @class BaseAPI
 */
export class BaseAPI {
    protected configuration: Configuration | undefined;

    constructor(configuration?: Configuration, protected basePath: string = BASE_PATH, protected axios: AxiosInstance = globalAxios) {
        if (configuration) {
            this.configuration = configuration;
            this.basePath = configuration.basePath ?? basePath;
        }
    }
};

/**
 *
 * @export
 * @class RequiredError
 * @extends {Error}
 */
export class RequiredError extends Error {
    constructor(public field: string, msg?: string) {
        super(msg);
        this.name = "RequiredError"
    }
}

interface ServerMap {
    [key: string]: {
        url: string,
        description: string,
    }[];
}

/**
 *
 * @export
 */
export const operationServerMap: ServerMap = {
    "EventsApi.createEventStream": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "EventsApi.deleteEventStream": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "EventsApi.listEventStreams": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "EventsApi.setEventStream": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.createOrganization": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.createProject": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.createProjectApiKey": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.deleteOrganization": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.deleteProjectApiKey": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.getOrganization": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.getProject": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.getProjectMembers": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.listOrganizations": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.listProjectApiKeys": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.listProjects": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.patchProject": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.patchProjectWithRevision": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.purgeProject": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.removeProjectMember": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.setProject": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "ProjectApi.updateOrganization": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.createWorkspace": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.createWorkspaceApiKey": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.deleteWorkspaceApiKey": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.getWorkspace": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.listWorkspaceApiKeys": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.listWorkspaceProjects": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.listWorkspaces": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
    "WorkspaceApi.updateWorkspace": [
        {
            url: "https://api.console.ory.sh",
            description: "The Ory Network control plane API which is used to manage your Ory Network projects and workspaces.",
        }
    ],
}
