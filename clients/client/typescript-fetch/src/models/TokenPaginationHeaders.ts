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
 * 
 * @export
 * @interface TokenPaginationHeaders
 */
export interface TokenPaginationHeaders {
    /**
     * The link header contains pagination links.
     * 
     * For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
     * 
     * in: header
     * @type {string}
     * @memberof TokenPaginationHeaders
     */
    link?: string;
    /**
     * The total number of clients.
     * 
     * in: header
     * @type {string}
     * @memberof TokenPaginationHeaders
     */
    x_total_count?: string;
}

/**
 * Check if a given object implements the TokenPaginationHeaders interface.
 */
export function instanceOfTokenPaginationHeaders(value: object): boolean {
    return true;
}

export function TokenPaginationHeadersFromJSON(json: any): TokenPaginationHeaders {
    return TokenPaginationHeadersFromJSONTyped(json, false);
}

export function TokenPaginationHeadersFromJSONTyped(json: any, ignoreDiscriminator: boolean): TokenPaginationHeaders {
    if (json == null) {
        return json;
    }
    return {
        
        'link': json['link'] == null ? undefined : json['link'],
        'x_total_count': json['x-total-count'] == null ? undefined : json['x-total-count'],
    };
}

export function TokenPaginationHeadersToJSON(value?: TokenPaginationHeaders | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'link': value['link'],
        'x-total-count': value['x_total_count'],
    };
}

