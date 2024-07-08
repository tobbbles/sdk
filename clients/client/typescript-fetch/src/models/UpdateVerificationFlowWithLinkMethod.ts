/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.13.10
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * Update Verification Flow with Link Method
 * @export
 * @interface UpdateVerificationFlowWithLinkMethod
 */
export interface UpdateVerificationFlowWithLinkMethod {
    /**
     * Sending the anti-csrf token is only required for browser login flows.
     * @type {string}
     * @memberof UpdateVerificationFlowWithLinkMethod
     */
    csrf_token?: string;
    /**
     * Email to Verify
     * 
     * Needs to be set when initiating the flow. If the email is a registered
     * verification email, a verification link will be sent. If the email is not known,
     * a email with details on what happened will be sent instead.
     * 
     * format: email
     * @type {string}
     * @memberof UpdateVerificationFlowWithLinkMethod
     */
    email: string;
    /**
     * Method is the method that should be used for this verification flow
     * 
     * Allowed values are `link` and `code`
     * link VerificationStrategyLink
     * code VerificationStrategyCode
     * @type {string}
     * @memberof UpdateVerificationFlowWithLinkMethod
     */
    method: UpdateVerificationFlowWithLinkMethodMethodEnum;
    /**
     * Transient data to pass along to any webhooks
     * @type {object}
     * @memberof UpdateVerificationFlowWithLinkMethod
     */
    transient_payload?: object;
}


/**
 * @export
 */
export const UpdateVerificationFlowWithLinkMethodMethodEnum = {
    Link: 'link',
    Code: 'code'
} as const;
export type UpdateVerificationFlowWithLinkMethodMethodEnum = typeof UpdateVerificationFlowWithLinkMethodMethodEnum[keyof typeof UpdateVerificationFlowWithLinkMethodMethodEnum];


/**
 * Check if a given object implements the UpdateVerificationFlowWithLinkMethod interface.
 */
export function instanceOfUpdateVerificationFlowWithLinkMethod(value: object): value is UpdateVerificationFlowWithLinkMethod {
    if (!('email' in value) || value['email'] === undefined) return false;
    if (!('method' in value) || value['method'] === undefined) return false;
    return true;
}

export function UpdateVerificationFlowWithLinkMethodFromJSON(json: any): UpdateVerificationFlowWithLinkMethod {
    return UpdateVerificationFlowWithLinkMethodFromJSONTyped(json, false);
}

export function UpdateVerificationFlowWithLinkMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateVerificationFlowWithLinkMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'email': json['email'],
        'method': json['method'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
    };
}

export function UpdateVerificationFlowWithLinkMethodToJSON(value?: UpdateVerificationFlowWithLinkMethod | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'csrf_token': value['csrf_token'],
        'email': value['email'],
        'method': value['method'],
        'transient_payload': value['transient_payload'],
    };
}

