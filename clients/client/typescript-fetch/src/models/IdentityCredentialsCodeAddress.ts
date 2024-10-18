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
 * 
 * @export
 * @interface IdentityCredentialsCodeAddress
 */
export interface IdentityCredentialsCodeAddress {
    /**
     * The address for this code
     * @type {string}
     * @memberof IdentityCredentialsCodeAddress
     */
    address?: string;
    /**
     * 
     * @type {string}
     * @memberof IdentityCredentialsCodeAddress
     */
    channel?: string;
}

/**
 * Check if a given object implements the IdentityCredentialsCodeAddress interface.
 */
export function instanceOfIdentityCredentialsCodeAddress(value: object): value is IdentityCredentialsCodeAddress {
    return true;
}

export function IdentityCredentialsCodeAddressFromJSON(json: any): IdentityCredentialsCodeAddress {
    return IdentityCredentialsCodeAddressFromJSONTyped(json, false);
}

export function IdentityCredentialsCodeAddressFromJSONTyped(json: any, ignoreDiscriminator: boolean): IdentityCredentialsCodeAddress {
    if (json == null) {
        return json;
    }
    return {
        
        'address': json['address'] == null ? undefined : json['address'],
        'channel': json['channel'] == null ? undefined : json['channel'],
    };
}

export function IdentityCredentialsCodeAddressToJSON(value?: IdentityCredentialsCodeAddress | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'address': value['address'],
        'channel': value['channel'],
    };
}

