/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.0
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * Get Permissions on Project Request Parameters
 * @export
 * @interface PermissionsOnWorkspace
 */
export interface PermissionsOnWorkspace {
    /**
     * 
     * @type {{ [key: string]: boolean; }}
     * @memberof PermissionsOnWorkspace
     */
    permissions?: { [key: string]: boolean; };
}

/**
 * Check if a given object implements the PermissionsOnWorkspace interface.
 */
export function instanceOfPermissionsOnWorkspace(value: object): boolean {
    return true;
}

export function PermissionsOnWorkspaceFromJSON(json: any): PermissionsOnWorkspace {
    return PermissionsOnWorkspaceFromJSONTyped(json, false);
}

export function PermissionsOnWorkspaceFromJSONTyped(json: any, ignoreDiscriminator: boolean): PermissionsOnWorkspace {
    if (json == null) {
        return json;
    }
    return {
        
        'permissions': json['permissions'] == null ? undefined : json['permissions'],
    };
}

export function PermissionsOnWorkspaceToJSON(value?: PermissionsOnWorkspace | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'permissions': value['permissions'],
    };
}

