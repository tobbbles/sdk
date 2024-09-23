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
 * @interface AcceptOAuth2ConsentRequestSession
 */
export interface AcceptOAuth2ConsentRequestSession {
    /**
     * AccessToken sets session data for the access and refresh token, as well as any future tokens issued by the
     * refresh grant. Keep in mind that this data will be available to anyone performing OAuth 2.0 Challenge Introspection.
     * If only your services can perform OAuth 2.0 Challenge Introspection, this is usually fine. But if third parties
     * can access that endpoint as well, sensitive data from the session might be exposed to them. Use with care!
     * @type {any}
     * @memberof AcceptOAuth2ConsentRequestSession
     */
    access_token?: any | null;
    /**
     * IDToken sets session data for the OpenID Connect ID token. Keep in mind that the session'id payloads are readable
     * by anyone that has access to the ID Challenge. Use with care!
     * @type {any}
     * @memberof AcceptOAuth2ConsentRequestSession
     */
    id_token?: any | null;
}

/**
 * Check if a given object implements the AcceptOAuth2ConsentRequestSession interface.
 */
export function instanceOfAcceptOAuth2ConsentRequestSession(value: object): value is AcceptOAuth2ConsentRequestSession {
    return true;
}

export function AcceptOAuth2ConsentRequestSessionFromJSON(json: any): AcceptOAuth2ConsentRequestSession {
    return AcceptOAuth2ConsentRequestSessionFromJSONTyped(json, false);
}

export function AcceptOAuth2ConsentRequestSessionFromJSONTyped(json: any, ignoreDiscriminator: boolean): AcceptOAuth2ConsentRequestSession {
    if (json == null) {
        return json;
    }
    return {
        
        'access_token': json['access_token'] == null ? undefined : json['access_token'],
        'id_token': json['id_token'] == null ? undefined : json['id_token'],
    };
}

export function AcceptOAuth2ConsentRequestSessionToJSON(value?: AcceptOAuth2ConsentRequestSession | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'access_token': value['access_token'],
        'id_token': value['id_token'],
    };
}

