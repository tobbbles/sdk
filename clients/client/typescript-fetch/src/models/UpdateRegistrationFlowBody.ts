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

import type { UpdateRegistrationFlowWithCodeMethod } from './UpdateRegistrationFlowWithCodeMethod';
import {
    instanceOfUpdateRegistrationFlowWithCodeMethod,
    UpdateRegistrationFlowWithCodeMethodFromJSON,
    UpdateRegistrationFlowWithCodeMethodFromJSONTyped,
    UpdateRegistrationFlowWithCodeMethodToJSON,
} from './UpdateRegistrationFlowWithCodeMethod';
import type { UpdateRegistrationFlowWithOidcMethod } from './UpdateRegistrationFlowWithOidcMethod';
import {
    instanceOfUpdateRegistrationFlowWithOidcMethod,
    UpdateRegistrationFlowWithOidcMethodFromJSON,
    UpdateRegistrationFlowWithOidcMethodFromJSONTyped,
    UpdateRegistrationFlowWithOidcMethodToJSON,
} from './UpdateRegistrationFlowWithOidcMethod';
import type { UpdateRegistrationFlowWithPasskeyMethod } from './UpdateRegistrationFlowWithPasskeyMethod';
import {
    instanceOfUpdateRegistrationFlowWithPasskeyMethod,
    UpdateRegistrationFlowWithPasskeyMethodFromJSON,
    UpdateRegistrationFlowWithPasskeyMethodFromJSONTyped,
    UpdateRegistrationFlowWithPasskeyMethodToJSON,
} from './UpdateRegistrationFlowWithPasskeyMethod';
import type { UpdateRegistrationFlowWithPasswordMethod } from './UpdateRegistrationFlowWithPasswordMethod';
import {
    instanceOfUpdateRegistrationFlowWithPasswordMethod,
    UpdateRegistrationFlowWithPasswordMethodFromJSON,
    UpdateRegistrationFlowWithPasswordMethodFromJSONTyped,
    UpdateRegistrationFlowWithPasswordMethodToJSON,
} from './UpdateRegistrationFlowWithPasswordMethod';
import type { UpdateRegistrationFlowWithWebAuthnMethod } from './UpdateRegistrationFlowWithWebAuthnMethod';
import {
    instanceOfUpdateRegistrationFlowWithWebAuthnMethod,
    UpdateRegistrationFlowWithWebAuthnMethodFromJSON,
    UpdateRegistrationFlowWithWebAuthnMethodFromJSONTyped,
    UpdateRegistrationFlowWithWebAuthnMethodToJSON,
} from './UpdateRegistrationFlowWithWebAuthnMethod';

/**
 * @type UpdateRegistrationFlowBody
 * Update Registration Request Body
 * @export
 */
export type UpdateRegistrationFlowBody = { method: 'code' } & UpdateRegistrationFlowWithCodeMethod | { method: 'oidc' } & UpdateRegistrationFlowWithOidcMethod | { method: 'passKey' } & UpdateRegistrationFlowWithPasskeyMethod | { method: 'password' } & UpdateRegistrationFlowWithPasswordMethod | { method: 'webauthn' } & UpdateRegistrationFlowWithWebAuthnMethod;

export function UpdateRegistrationFlowBodyFromJSON(json: any): UpdateRegistrationFlowBody {
    return UpdateRegistrationFlowBodyFromJSONTyped(json, false);
}

export function UpdateRegistrationFlowBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateRegistrationFlowBody {
    if (json == null) {
        return json;
    }
    switch (json['method']) {
        case 'code':
            return {...UpdateRegistrationFlowWithCodeMethodFromJSONTyped(json, true), method: 'code'};
        case 'oidc':
            return {...UpdateRegistrationFlowWithOidcMethodFromJSONTyped(json, true), method: 'oidc'};
        case 'passKey':
            return {...UpdateRegistrationFlowWithPasskeyMethodFromJSONTyped(json, true), method: 'passKey'};
        case 'password':
            return {...UpdateRegistrationFlowWithPasswordMethodFromJSONTyped(json, true), method: 'password'};
        case 'webauthn':
            return {...UpdateRegistrationFlowWithWebAuthnMethodFromJSONTyped(json, true), method: 'webauthn'};
        default:
            throw new Error(`No variant of UpdateRegistrationFlowBody exists with 'method=${json['method']}'`);
    }
}

export function UpdateRegistrationFlowBodyToJSON(value?: UpdateRegistrationFlowBody | null): any {
    if (value == null) {
        return value;
    }
    switch (value['method']) {
        case 'code':
            return UpdateRegistrationFlowWithCodeMethodToJSON(value);
        case 'oidc':
            return UpdateRegistrationFlowWithOidcMethodToJSON(value);
        case 'passKey':
            return UpdateRegistrationFlowWithPasskeyMethodToJSON(value);
        case 'password':
            return UpdateRegistrationFlowWithPasswordMethodToJSON(value);
        case 'webauthn':
            return UpdateRegistrationFlowWithWebAuthnMethodToJSON(value);
        default:
            throw new Error(`No variant of UpdateRegistrationFlowBody exists with 'method=${value['method']}'`);
    }

}

