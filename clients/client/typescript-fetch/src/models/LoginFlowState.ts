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


/**
 * The state represents the state of the login flow.
 * 
 * choose_method: ask the user to choose a method (e.g. login account via email)
 * sent_email: the email has been sent to the user
 * passed_challenge: the request was successful and the login challenge was passed.
 * @export
 */
export const LoginFlowState = {
    ChooseMethod: 'choose_method',
    SentEmail: 'sent_email',
    PassedChallenge: 'passed_challenge'
} as const;
export type LoginFlowState = typeof LoginFlowState[keyof typeof LoginFlowState];


export function LoginFlowStateFromJSON(json: any): LoginFlowState {
    return LoginFlowStateFromJSONTyped(json, false);
}

export function LoginFlowStateFromJSONTyped(json: any, ignoreDiscriminator: boolean): LoginFlowState {
    return json as LoginFlowState;
}

export function LoginFlowStateToJSON(value?: LoginFlowState | null): any {
    return value as any;
}

