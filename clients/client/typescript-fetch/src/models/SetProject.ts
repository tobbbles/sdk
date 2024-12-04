/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.15.14
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { ProjectServices } from './ProjectServices';
import {
    ProjectServicesFromJSON,
    ProjectServicesFromJSONTyped,
    ProjectServicesToJSON,
} from './ProjectServices';
import type { ProjectCors } from './ProjectCors';
import {
    ProjectCorsFromJSON,
    ProjectCorsFromJSONTyped,
    ProjectCorsToJSON,
} from './ProjectCors';

/**
 * 
 * @export
 * @interface SetProject
 */
export interface SetProject {
    /**
     * 
     * @type {ProjectCors}
     * @memberof SetProject
     */
    cors_admin: ProjectCors;
    /**
     * 
     * @type {ProjectCors}
     * @memberof SetProject
     */
    cors_public: ProjectCors;
    /**
     * The name of the project.
     * @type {string}
     * @memberof SetProject
     */
    name: string;
    /**
     * 
     * @type {ProjectServices}
     * @memberof SetProject
     */
    services: ProjectServices;
}

/**
 * Check if a given object implements the SetProject interface.
 */
export function instanceOfSetProject(value: object): value is SetProject {
    if (!('cors_admin' in value) || value['cors_admin'] === undefined) return false;
    if (!('cors_public' in value) || value['cors_public'] === undefined) return false;
    if (!('name' in value) || value['name'] === undefined) return false;
    if (!('services' in value) || value['services'] === undefined) return false;
    return true;
}

export function SetProjectFromJSON(json: any): SetProject {
    return SetProjectFromJSONTyped(json, false);
}

export function SetProjectFromJSONTyped(json: any, ignoreDiscriminator: boolean): SetProject {
    if (json == null) {
        return json;
    }
    return {
        
        'cors_admin': ProjectCorsFromJSON(json['cors_admin']),
        'cors_public': ProjectCorsFromJSON(json['cors_public']),
        'name': json['name'],
        'services': ProjectServicesFromJSON(json['services']),
    };
}

export function SetProjectToJSON(value?: SetProject | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'cors_admin': ProjectCorsToJSON(value['cors_admin']),
        'cors_public': ProjectCorsToJSON(value['cors_public']),
        'name': value['name'],
        'services': ProjectServicesToJSON(value['services']),
    };
}

