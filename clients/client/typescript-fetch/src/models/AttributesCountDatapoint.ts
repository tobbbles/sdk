/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface AttributesCountDatapoint
 */
export interface AttributesCountDatapoint {
    /**
     * Count of the attribute value for given key
     * @type {number}
     * @memberof AttributesCountDatapoint
     */
    count: number;
    /**
     * Name of the attribute value for given key
     * @type {string}
     * @memberof AttributesCountDatapoint
     */
    name: string;
}

/**
 * Check if a given object implements the AttributesCountDatapoint interface.
 */
export function instanceOfAttributesCountDatapoint(value: object): value is AttributesCountDatapoint {
    if (!('count' in value) || value['count'] === undefined) return false;
    if (!('name' in value) || value['name'] === undefined) return false;
    return true;
}

export function AttributesCountDatapointFromJSON(json: any): AttributesCountDatapoint {
    return AttributesCountDatapointFromJSONTyped(json, false);
}

export function AttributesCountDatapointFromJSONTyped(json: any, ignoreDiscriminator: boolean): AttributesCountDatapoint {
    if (json == null) {
        return json;
    }
    return {
        
        'count': json['count'],
        'name': json['name'],
    };
}

export function AttributesCountDatapointToJSON(value?: AttributesCountDatapoint | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'count': value['count'],
        'name': value['name'],
    };
}

