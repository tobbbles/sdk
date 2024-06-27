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
 * Create Custom Hostname Request Body
 * @export
 * @interface CreateCustomDomainBody
 */
export interface CreateCustomDomainBody {
    /**
     * The domain where cookies will be set. Has to be a parent domain of the custom hostname to work.
     * @type {string}
     * @memberof CreateCustomDomainBody
     */
    cookie_domain?: string;
    /**
     * CORS Allowed origins for the custom hostname.
     * @type {Array<string>}
     * @memberof CreateCustomDomainBody
     */
    cors_allowed_origins?: Array<string>;
    /**
     * CORS Enabled for the custom hostname.
     * @type {boolean}
     * @memberof CreateCustomDomainBody
     */
    cors_enabled?: boolean;
    /**
     * The base URL where the custom user interface will be exposed.
     * @type {string}
     * @memberof CreateCustomDomainBody
     */
    custom_ui_base_url?: string;
    /**
     * The custom hostname where the API will be exposed.
     * @type {string}
     * @memberof CreateCustomDomainBody
     */
    hostname?: string;
}

/**
 * Check if a given object implements the CreateCustomDomainBody interface.
 */
export function instanceOfCreateCustomDomainBody(value: object): boolean {
    return true;
}

export function CreateCustomDomainBodyFromJSON(json: any): CreateCustomDomainBody {
    return CreateCustomDomainBodyFromJSONTyped(json, false);
}

export function CreateCustomDomainBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateCustomDomainBody {
    if (json == null) {
        return json;
    }
    return {
        
        'cookie_domain': json['cookie_domain'] == null ? undefined : json['cookie_domain'],
        'cors_allowed_origins': json['cors_allowed_origins'] == null ? undefined : json['cors_allowed_origins'],
        'cors_enabled': json['cors_enabled'] == null ? undefined : json['cors_enabled'],
        'custom_ui_base_url': json['custom_ui_base_url'] == null ? undefined : json['custom_ui_base_url'],
        'hostname': json['hostname'] == null ? undefined : json['hostname'],
    };
}

export function CreateCustomDomainBodyToJSON(value?: CreateCustomDomainBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'cookie_domain': value['cookie_domain'],
        'cors_allowed_origins': value['cors_allowed_origins'],
        'cors_enabled': value['cors_enabled'],
        'custom_ui_base_url': value['custom_ui_base_url'],
        'hostname': value['hostname'],
    };
}

