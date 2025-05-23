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
import type { StackingOptions } from './StackingOptions';
import {
    StackingOptionsFromJSON,
    StackingOptionsFromJSONTyped,
    StackingOptionsToJSON,
} from './StackingOptions';
import type { Stop } from './Stop';
import {
    StopFromJSON,
    StopFromJSONTyped,
    StopToJSON,
} from './Stop';

/**
 * Allows customization of the bin packing operation.
 * @export
 * @interface BinPackingOptions
 */
export interface BinPackingOptions {
    /**
     * Specifies the sequence of items or group of items to be unloaded. The first element of this sequence will be unloaded first (and loaded last). By default items of a stop will not be stacked on top of items of the subsequent stop. This may be useful when unloading all items of a stop with a hand truck. To change this behavior specify 'stackOnTopOfNextStops'. Please note that this option can only be used the case a single bin is defined.
     * @type {Array<Stop>}
     * @memberof BinPackingOptions
     */
    unloadingSequence?: Array<Stop>;
    /**
     * 
     * @type {StackingOptions}
     * @memberof BinPackingOptions
     */
    stackingOptions?: StackingOptions;
}

/**
 * Check if a given object implements the BinPackingOptions interface.
 */
export function instanceOfBinPackingOptions(value: object): value is BinPackingOptions {
    return true;
}

export function BinPackingOptionsFromJSON(json: any): BinPackingOptions {
    return BinPackingOptionsFromJSONTyped(json, false);
}

export function BinPackingOptionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): BinPackingOptions {
    if (json == null) {
        return json;
    }
    return {
        
        'unloadingSequence': json['unloadingSequence'] == null ? undefined : ((json['unloadingSequence'] as Array<any>).map(StopFromJSON)),
        'stackingOptions': json['stackingOptions'] == null ? undefined : StackingOptionsFromJSON(json['stackingOptions']),
    };
}

export function BinPackingOptionsToJSON(value?: BinPackingOptions | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'unloadingSequence': value['unloadingSequence'] == null ? undefined : ((value['unloadingSequence'] as Array<any>).map(StopToJSON)),
        'stackingOptions': StackingOptionsToJSON(value['stackingOptions']),
    };
}

