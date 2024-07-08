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
 * 
 * @export
 * @interface ContinueWithRecoveryUiFlow
 */
export interface ContinueWithRecoveryUiFlow {
    /**
     * The ID of the recovery flow
     * @type {string}
     * @memberof ContinueWithRecoveryUiFlow
     */
    id: string;
    /**
     * The URL of the recovery flow
     * @type {string}
     * @memberof ContinueWithRecoveryUiFlow
     */
    url?: string;
}

/**
 * Check if a given object implements the ContinueWithRecoveryUiFlow interface.
 */
export function instanceOfContinueWithRecoveryUiFlow(value: object): value is ContinueWithRecoveryUiFlow {
    if (!('id' in value) || value['id'] === undefined) return false;
    return true;
}

export function ContinueWithRecoveryUiFlowFromJSON(json: any): ContinueWithRecoveryUiFlow {
    return ContinueWithRecoveryUiFlowFromJSONTyped(json, false);
}

export function ContinueWithRecoveryUiFlowFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContinueWithRecoveryUiFlow {
    if (json == null) {
        return json;
    }
    return {
        
        'id': json['id'],
        'url': json['url'] == null ? undefined : json['url'],
    };
}

export function ContinueWithRecoveryUiFlowToJSON(value?: ContinueWithRecoveryUiFlow | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'id': value['id'],
        'url': value['url'],
    };
}

