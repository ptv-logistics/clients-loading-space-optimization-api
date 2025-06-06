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
import type { Item } from './Item';
import {
    ItemFromJSON,
    ItemFromJSONTyped,
    ItemToJSON,
} from './Item';
import type { Bin } from './Bin';
import {
    BinFromJSON,
    BinFromJSONTyped,
    BinToJSON,
} from './Bin';
import type { BinPackingOptions } from './BinPackingOptions';
import {
    BinPackingOptionsFromJSON,
    BinPackingOptionsFromJSONTyped,
    BinPackingOptionsToJSON,
} from './BinPackingOptions';

/**
 * 
 * @export
 * @interface PackBinsRequest
 */
export interface PackBinsRequest {
    /**
     * Describes a list of cuboid items that have to be packed into a bin.
     * If there are many identical items that do not have to be differentiated by individual Item.id you should use the Item.numberOfInstances field.
     * This provides better performance and packing than specifying each item on its own when this is not needed.
     * Please note that along each axis the dimension should not exceed 5,000 cm and the sum of each dimension (i.e. x+y+z) should be greater than 50 cm.
     * 
     * @type {Array<Item>}
     * @memberof PackBinsRequest
     */
    items: Array<Item>;
    /**
     * Describes a list of cuboid bins into which items can be packed.
     * Please note that along each axis the dimension should not exceed 5,750 cm and the maximum volume of a bin is 425,385,000 cm³.
     * 
     * @type {Array<Bin>}
     * @memberof PackBinsRequest
     */
    bins: Array<Bin>;
    /**
     * 
     * @type {BinPackingOptions}
     * @memberof PackBinsRequest
     */
    options?: BinPackingOptions;
}

/**
 * Check if a given object implements the PackBinsRequest interface.
 */
export function instanceOfPackBinsRequest(value: object): value is PackBinsRequest {
    if (!('items' in value) || value['items'] === undefined) return false;
    if (!('bins' in value) || value['bins'] === undefined) return false;
    return true;
}

export function PackBinsRequestFromJSON(json: any): PackBinsRequest {
    return PackBinsRequestFromJSONTyped(json, false);
}

export function PackBinsRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): PackBinsRequest {
    if (json == null) {
        return json;
    }
    return {
        
        'items': ((json['items'] as Array<any>).map(ItemFromJSON)),
        'bins': ((json['bins'] as Array<any>).map(BinFromJSON)),
        'options': json['options'] == null ? undefined : BinPackingOptionsFromJSON(json['options']),
    };
}

export function PackBinsRequestToJSON(value?: PackBinsRequest | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'items': ((value['items'] as Array<any>).map(ItemToJSON)),
        'bins': ((value['bins'] as Array<any>).map(BinToJSON)),
        'options': BinPackingOptionsToJSON(value['options']),
    };
}

