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
import type { SubjectSet } from './SubjectSet';
import {
    SubjectSetFromJSON,
    SubjectSetFromJSONTyped,
    SubjectSetToJSON,
} from './SubjectSet';

/**
 * Check Permission using Post Request Body
 * @export
 * @interface PostCheckPermissionBody
 */
export interface PostCheckPermissionBody {
    /**
     * Namespace to query
     * @type {string}
     * @memberof PostCheckPermissionBody
     */
    namespace?: string;
    /**
     * Object to query
     * @type {string}
     * @memberof PostCheckPermissionBody
     */
    object?: string;
    /**
     * Relation to query
     * @type {string}
     * @memberof PostCheckPermissionBody
     */
    relation?: string;
    /**
     * SubjectID to query
     * 
     * Either SubjectSet or SubjectID can be provided.
     * @type {string}
     * @memberof PostCheckPermissionBody
     */
    subject_id?: string;
    /**
     * 
     * @type {SubjectSet}
     * @memberof PostCheckPermissionBody
     */
    subject_set?: SubjectSet;
}

/**
 * Check if a given object implements the PostCheckPermissionBody interface.
 */
export function instanceOfPostCheckPermissionBody(value: object): boolean {
    return true;
}

export function PostCheckPermissionBodyFromJSON(json: any): PostCheckPermissionBody {
    return PostCheckPermissionBodyFromJSONTyped(json, false);
}

export function PostCheckPermissionBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): PostCheckPermissionBody {
    if (json == null) {
        return json;
    }
    return {
        
        'namespace': json['namespace'] == null ? undefined : json['namespace'],
        'object': json['object'] == null ? undefined : json['object'],
        'relation': json['relation'] == null ? undefined : json['relation'],
        'subject_id': json['subject_id'] == null ? undefined : json['subject_id'],
        'subject_set': json['subject_set'] == null ? undefined : SubjectSetFromJSON(json['subject_set']),
    };
}

export function PostCheckPermissionBodyToJSON(value?: PostCheckPermissionBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'namespace': value['namespace'],
        'object': value['object'],
        'relation': value['relation'],
        'subject_id': value['subject_id'],
        'subject_set': SubjectSetToJSON(value['subject_set']),
    };
}

