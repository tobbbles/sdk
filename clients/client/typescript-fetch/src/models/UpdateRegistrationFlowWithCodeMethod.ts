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
 * Update Registration Flow with Code Method
 * @export
 * @interface UpdateRegistrationFlowWithCodeMethod
 */
export interface UpdateRegistrationFlowWithCodeMethod {
    /**
     * The OTP Code sent to the user
     * @type {string}
     * @memberof UpdateRegistrationFlowWithCodeMethod
     */
    code?: string;
    /**
     * The CSRF Token
     * @type {string}
     * @memberof UpdateRegistrationFlowWithCodeMethod
     */
    csrf_token?: string;
    /**
     * Method to use
     * 
     * This field must be set to `code` when using the code method.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithCodeMethod
     */
    method: string;
    /**
     * Resend restarts the flow with a new code
     * @type {string}
     * @memberof UpdateRegistrationFlowWithCodeMethod
     */
    resend?: string;
    /**
     * The identity's traits
     * @type {object}
     * @memberof UpdateRegistrationFlowWithCodeMethod
     */
    traits: object;
    /**
     * Transient data to pass along to any webhooks
     * @type {object}
     * @memberof UpdateRegistrationFlowWithCodeMethod
     */
    transient_payload?: object;
}

/**
 * Check if a given object implements the UpdateRegistrationFlowWithCodeMethod interface.
 */
export function instanceOfUpdateRegistrationFlowWithCodeMethod(value: object): value is UpdateRegistrationFlowWithCodeMethod {
    if (!('method' in value) || value['method'] === undefined) return false;
    if (!('traits' in value) || value['traits'] === undefined) return false;
    return true;
}

export function UpdateRegistrationFlowWithCodeMethodFromJSON(json: any): UpdateRegistrationFlowWithCodeMethod {
    return UpdateRegistrationFlowWithCodeMethodFromJSONTyped(json, false);
}

export function UpdateRegistrationFlowWithCodeMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateRegistrationFlowWithCodeMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'code': json['code'] == null ? undefined : json['code'],
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'method': json['method'],
        'resend': json['resend'] == null ? undefined : json['resend'],
        'traits': json['traits'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
    };
}

export function UpdateRegistrationFlowWithCodeMethodToJSON(value?: UpdateRegistrationFlowWithCodeMethod | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'code': value['code'],
        'csrf_token': value['csrf_token'],
        'method': value['method'],
        'resend': value['resend'],
        'traits': value['traits'],
        'transient_payload': value['transient_payload'],
    };
}

