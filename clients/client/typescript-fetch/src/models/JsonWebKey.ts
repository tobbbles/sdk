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
 * @interface JsonWebKey
 */
export interface JsonWebKey {
    /**
     * The "alg" (algorithm) parameter identifies the algorithm intended for
     * use with the key.  The values used should either be registered in the
     * IANA "JSON Web Signature and Encryption Algorithms" registry
     * established by [JWA] or be a value that contains a Collision-
     * Resistant Name.
     * @type {string}
     * @memberof JsonWebKey
     */
    alg: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    crv?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    d?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    dp?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    dq?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    e?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    k?: string;
    /**
     * The "kid" (key ID) parameter is used to match a specific key.  This
     * is used, for instance, to choose among a set of keys within a JWK Set
     * during key rollover.  The structure of the "kid" value is
     * unspecified.  When "kid" values are used within a JWK Set, different
     * keys within the JWK Set SHOULD use distinct "kid" values.  (One
     * example in which different keys might use the same "kid" value is if
     * they have different "kty" (key type) values but are considered to be
     * equivalent alternatives by the application using them.)  The "kid"
     * value is a case-sensitive string.
     * @type {string}
     * @memberof JsonWebKey
     */
    kid: string;
    /**
     * The "kty" (key type) parameter identifies the cryptographic algorithm
     * family used with the key, such as "RSA" or "EC". "kty" values should
     * either be registered in the IANA "JSON Web Key Types" registry
     * established by [JWA] or be a value that contains a Collision-
     * Resistant Name.  The "kty" value is a case-sensitive string.
     * @type {string}
     * @memberof JsonWebKey
     */
    kty: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    n?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    p?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    q?: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    qi?: string;
    /**
     * Use ("public key use") identifies the intended use of
     * the public key. The "use" parameter is employed to indicate whether
     * a public key is used for encrypting data or verifying the signature
     * on data. Values are commonly "sig" (signature) or "enc" (encryption).
     * @type {string}
     * @memberof JsonWebKey
     */
    use: string;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    x?: string;
    /**
     * The "x5c" (X.509 certificate chain) parameter contains a chain of one
     * or more PKIX certificates [RFC5280].  The certificate chain is
     * represented as a JSON array of certificate value strings.  Each
     * string in the array is a base64-encoded (Section 4 of [RFC4648] --
     * not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
     * The PKIX certificate containing the key value MUST be the first
     * certificate.
     * @type {Array<string>}
     * @memberof JsonWebKey
     */
    x5c?: Array<string>;
    /**
     * 
     * @type {string}
     * @memberof JsonWebKey
     */
    y?: string;
}

/**
 * Check if a given object implements the JsonWebKey interface.
 */
export function instanceOfJsonWebKey(value: object): value is JsonWebKey {
    if (!('alg' in value) || value['alg'] === undefined) return false;
    if (!('kid' in value) || value['kid'] === undefined) return false;
    if (!('kty' in value) || value['kty'] === undefined) return false;
    if (!('use' in value) || value['use'] === undefined) return false;
    return true;
}

export function JsonWebKeyFromJSON(json: any): JsonWebKey {
    return JsonWebKeyFromJSONTyped(json, false);
}

export function JsonWebKeyFromJSONTyped(json: any, ignoreDiscriminator: boolean): JsonWebKey {
    if (json == null) {
        return json;
    }
    return {
        
        'alg': json['alg'],
        'crv': json['crv'] == null ? undefined : json['crv'],
        'd': json['d'] == null ? undefined : json['d'],
        'dp': json['dp'] == null ? undefined : json['dp'],
        'dq': json['dq'] == null ? undefined : json['dq'],
        'e': json['e'] == null ? undefined : json['e'],
        'k': json['k'] == null ? undefined : json['k'],
        'kid': json['kid'],
        'kty': json['kty'],
        'n': json['n'] == null ? undefined : json['n'],
        'p': json['p'] == null ? undefined : json['p'],
        'q': json['q'] == null ? undefined : json['q'],
        'qi': json['qi'] == null ? undefined : json['qi'],
        'use': json['use'],
        'x': json['x'] == null ? undefined : json['x'],
        'x5c': json['x5c'] == null ? undefined : json['x5c'],
        'y': json['y'] == null ? undefined : json['y'],
    };
}

export function JsonWebKeyToJSON(value?: JsonWebKey | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'alg': value['alg'],
        'crv': value['crv'],
        'd': value['d'],
        'dp': value['dp'],
        'dq': value['dq'],
        'e': value['e'],
        'k': value['k'],
        'kid': value['kid'],
        'kty': value['kty'],
        'n': value['n'],
        'p': value['p'],
        'q': value['q'],
        'qi': value['qi'],
        'use': value['use'],
        'x': value['x'],
        'x5c': value['x5c'],
        'y': value['y'],
    };
}

