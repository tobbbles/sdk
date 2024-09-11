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

import { mapValues } from '../runtime';
/**
 * OAuth2 JWT Bearer Grant Type Issuer Trusted JSON Web Key
 * @export
 * @interface TrustedOAuth2JwtGrantJsonWebKey
 */
export interface TrustedOAuth2JwtGrantJsonWebKey {
    /**
     * The "key_id" is key unique identifier (same as kid header in jws/jwt).
     * @type {string}
     * @memberof TrustedOAuth2JwtGrantJsonWebKey
     */
    kid?: string;
    /**
     * The "set" is basically a name for a group(set) of keys. Will be the same as "issuer" in grant.
     * @type {string}
     * @memberof TrustedOAuth2JwtGrantJsonWebKey
     */
    set?: string;
}

/**
 * Check if a given object implements the TrustedOAuth2JwtGrantJsonWebKey interface.
 */
export function instanceOfTrustedOAuth2JwtGrantJsonWebKey(value: object): value is TrustedOAuth2JwtGrantJsonWebKey {
    return true;
}

export function TrustedOAuth2JwtGrantJsonWebKeyFromJSON(json: any): TrustedOAuth2JwtGrantJsonWebKey {
    return TrustedOAuth2JwtGrantJsonWebKeyFromJSONTyped(json, false);
}

export function TrustedOAuth2JwtGrantJsonWebKeyFromJSONTyped(json: any, ignoreDiscriminator: boolean): TrustedOAuth2JwtGrantJsonWebKey {
    if (json == null) {
        return json;
    }
    return {
        
        'kid': json['kid'] == null ? undefined : json['kid'],
        'set': json['set'] == null ? undefined : json['set'],
    };
}

export function TrustedOAuth2JwtGrantJsonWebKeyToJSON(value?: TrustedOAuth2JwtGrantJsonWebKey | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'kid': value['kid'],
        'set': value['set'],
    };
}

