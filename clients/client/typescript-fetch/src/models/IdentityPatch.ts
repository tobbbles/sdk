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
import type { CreateIdentityBody } from './CreateIdentityBody';
import {
    CreateIdentityBodyFromJSON,
    CreateIdentityBodyFromJSONTyped,
    CreateIdentityBodyToJSON,
} from './CreateIdentityBody';

/**
 * Payload for patching an identity
 * @export
 * @interface IdentityPatch
 */
export interface IdentityPatch {
    /**
     * 
     * @type {CreateIdentityBody}
     * @memberof IdentityPatch
     */
    create?: CreateIdentityBody;
    /**
     * The ID of this patch.
     * 
     * The patch ID is optional. If specified, the ID will be returned in the
     * response, so consumers of this API can correlate the response with the
     * patch.
     * @type {string}
     * @memberof IdentityPatch
     */
    patch_id?: string;
}

/**
 * Check if a given object implements the IdentityPatch interface.
 */
export function instanceOfIdentityPatch(value: object): boolean {
    return true;
}

export function IdentityPatchFromJSON(json: any): IdentityPatch {
    return IdentityPatchFromJSONTyped(json, false);
}

export function IdentityPatchFromJSONTyped(json: any, ignoreDiscriminator: boolean): IdentityPatch {
    if (json == null) {
        return json;
    }
    return {
        
        'create': json['create'] == null ? undefined : CreateIdentityBodyFromJSON(json['create']),
        'patch_id': json['patch_id'] == null ? undefined : json['patch_id'],
    };
}

export function IdentityPatchToJSON(value?: IdentityPatch | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'create': CreateIdentityBodyToJSON(value['create']),
        'patch_id': value['patch_id'],
    };
}

