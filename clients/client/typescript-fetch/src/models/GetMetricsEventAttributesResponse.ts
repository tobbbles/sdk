/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.7
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * Response of the getMetricsEventAttributes endpoint
 * @export
 * @interface GetMetricsEventAttributesResponse
 */
export interface GetMetricsEventAttributesResponse {
    /**
     * The list of data points.
     * @type {Array<string>}
     * @memberof GetMetricsEventAttributesResponse
     */
    readonly events: Array<string>;
}

/**
 * Check if a given object implements the GetMetricsEventAttributesResponse interface.
 */
export function instanceOfGetMetricsEventAttributesResponse(value: object): value is GetMetricsEventAttributesResponse {
    if (!('events' in value) || value['events'] === undefined) return false;
    return true;
}

export function GetMetricsEventAttributesResponseFromJSON(json: any): GetMetricsEventAttributesResponse {
    return GetMetricsEventAttributesResponseFromJSONTyped(json, false);
}

export function GetMetricsEventAttributesResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): GetMetricsEventAttributesResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'events': json['events'],
    };
}

export function GetMetricsEventAttributesResponseToJSON(value?: Omit<GetMetricsEventAttributesResponse, 'events'> | null): any {
    if (value == null) {
        return value;
    }
    return {
        
    };
}

