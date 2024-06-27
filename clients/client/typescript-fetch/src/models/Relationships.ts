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
import type { Relationship } from './Relationship';
import {
    RelationshipFromJSON,
    RelationshipFromJSONTyped,
    RelationshipToJSON,
} from './Relationship';

/**
 * Paginated Relationship List
 * @export
 * @interface Relationships
 */
export interface Relationships {
    /**
     * The opaque token to provide in a subsequent request
     * to get the next page. It is the empty string iff this is
     * the last page.
     * @type {string}
     * @memberof Relationships
     */
    next_page_token?: string;
    /**
     * 
     * @type {Array<Relationship>}
     * @memberof Relationships
     */
    relation_tuples?: Array<Relationship>;
}

/**
 * Check if a given object implements the Relationships interface.
 */
export function instanceOfRelationships(value: object): boolean {
    return true;
}

export function RelationshipsFromJSON(json: any): Relationships {
    return RelationshipsFromJSONTyped(json, false);
}

export function RelationshipsFromJSONTyped(json: any, ignoreDiscriminator: boolean): Relationships {
    if (json == null) {
        return json;
    }
    return {
        
        'next_page_token': json['next_page_token'] == null ? undefined : json['next_page_token'],
        'relation_tuples': json['relation_tuples'] == null ? undefined : ((json['relation_tuples'] as Array<any>).map(RelationshipFromJSON)),
    };
}

export function RelationshipsToJSON(value?: Relationships | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'next_page_token': value['next_page_token'],
        'relation_tuples': value['relation_tuples'] == null ? undefined : ((value['relation_tuples'] as Array<any>).map(RelationshipToJSON)),
    };
}

