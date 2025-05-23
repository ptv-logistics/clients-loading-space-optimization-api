/* tslint:disable */
/* eslint-disable */
/**
 * Loading Optimization
 * With the Bin Packing service you can pack a number of items of various types into a number of bins of various types.
 *
 * The version of the OpenAPI document: 1.2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { ItemsToUnload } from './ItemsToUnload';
import {
    ItemsToUnloadFromJSON,
    ItemsToUnloadFromJSONTyped,
    ItemsToUnloadToJSON,
} from './ItemsToUnload';

/**
 * Defines the list of items to be unloaded at this point.
 * @export
 * @interface Stop
 */
export interface Stop {
    /**
     * Defines the list of items to unload.
     * @type {Array<ItemsToUnload>}
     * @memberof Stop
     */
    itemsToUnload: Array<ItemsToUnload>;
}

/**
 * Check if a given object implements the Stop interface.
 */
export function instanceOfStop(value: object): value is Stop {
    if (!('itemsToUnload' in value) || value['itemsToUnload'] === undefined) return false;
    return true;
}

export function StopFromJSON(json: any): Stop {
    return StopFromJSONTyped(json, false);
}

export function StopFromJSONTyped(json: any, ignoreDiscriminator: boolean): Stop {
    if (json == null) {
        return json;
    }
    return {
        
        'itemsToUnload': ((json['itemsToUnload'] as Array<any>).map(ItemsToUnloadFromJSON)),
    };
}

export function StopToJSON(value?: Stop | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'itemsToUnload': ((value['itemsToUnload'] as Array<any>).map(ItemsToUnloadToJSON)),
    };
}

