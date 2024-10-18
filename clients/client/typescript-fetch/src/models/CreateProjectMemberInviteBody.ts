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
 * Create Project MemberInvite Request Body
 * @export
 * @interface CreateProjectMemberInviteBody
 */
export interface CreateProjectMemberInviteBody {
    /**
     * A email to invite
     * @type {string}
     * @memberof CreateProjectMemberInviteBody
     */
    invitee_email?: string;
}

/**
 * Check if a given object implements the CreateProjectMemberInviteBody interface.
 */
export function instanceOfCreateProjectMemberInviteBody(value: object): value is CreateProjectMemberInviteBody {
    return true;
}

export function CreateProjectMemberInviteBodyFromJSON(json: any): CreateProjectMemberInviteBody {
    return CreateProjectMemberInviteBodyFromJSONTyped(json, false);
}

export function CreateProjectMemberInviteBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateProjectMemberInviteBody {
    if (json == null) {
        return json;
    }
    return {
        
        'invitee_email': json['invitee_email'] == null ? undefined : json['invitee_email'],
    };
}

export function CreateProjectMemberInviteBodyToJSON(value?: CreateProjectMemberInviteBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'invitee_email': value['invitee_email'],
    };
}

