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
import type { PackedItem } from './PackedItem';
import {
    PackedItemFromJSON,
    PackedItemFromJSONTyped,
    PackedItemToJSON,
} from './PackedItem';

/**
 * Describes a bin packed with items. If Bin.numberOfInstances is greater than one, multiple packed bins with the same PackedBin.binId might be part of a response.
 * 
 * @export
 * @interface PackedBin
 */
export interface PackedBin {
    /**
     * ID of the bin.
     * @type {string}
     * @memberof PackedBin
     */
    binId: string;
    /**
     * List of items that were packed into this bin.
     * @type {Array<PackedItem>}
     * @memberof PackedBin
     */
    packedItems: Array<PackedItem>;
    /**
     * Accumulated volume of the items packed into the bin in [cm³]. This is the raw sum and does not try to capture wasted volume (e.g. gaps).
     * @type {number}
     * @memberof PackedBin
     */
    totalItemsVolume: number;
    /**
     * Accumulated weight of items packed into this bin in [g].
     * @type {number}
     * @memberof PackedBin
     */
    totalItemsWeight: number;
    /**
     * Percent of maximumWeightCapacity and the accumulated weight of the items packed into this bin (totalItemsWeight). Not returned if maximumWeightCapacity was not specified.
     * 
     * @type {number}
     * @memberof PackedBin
     */
    usedWeightCapacity?: number;
    /**
     * Percent of maximumVolumeCapacity and the accumulated volume of the items packed into this bin (totalItemsVolume).
     * 
     * @type {number}
     * @memberof PackedBin
     */
    usedVolumeCapacity: number;
    /**
     * Item extent along the z-axis (length) from the back wall of the bin in [m].
     * 
     * @type {number}
     * @memberof PackedBin
     */
    loadingMeters: number;
}

/**
 * Check if a given object implements the PackedBin interface.
 */
export function instanceOfPackedBin(value: object): value is PackedBin {
    if (!('binId' in value) || value['binId'] === undefined) return false;
    if (!('packedItems' in value) || value['packedItems'] === undefined) return false;
    if (!('totalItemsVolume' in value) || value['totalItemsVolume'] === undefined) return false;
    if (!('totalItemsWeight' in value) || value['totalItemsWeight'] === undefined) return false;
    if (!('usedVolumeCapacity' in value) || value['usedVolumeCapacity'] === undefined) return false;
    if (!('loadingMeters' in value) || value['loadingMeters'] === undefined) return false;
    return true;
}

export function PackedBinFromJSON(json: any): PackedBin {
    return PackedBinFromJSONTyped(json, false);
}

export function PackedBinFromJSONTyped(json: any, ignoreDiscriminator: boolean): PackedBin {
    if (json == null) {
        return json;
    }
    return {
        
        'binId': json['binId'],
        'packedItems': ((json['packedItems'] as Array<any>).map(PackedItemFromJSON)),
        'totalItemsVolume': json['totalItemsVolume'],
        'totalItemsWeight': json['totalItemsWeight'],
        'usedWeightCapacity': json['usedWeightCapacity'] == null ? undefined : json['usedWeightCapacity'],
        'usedVolumeCapacity': json['usedVolumeCapacity'],
        'loadingMeters': json['loadingMeters'],
    };
}

export function PackedBinToJSON(value?: PackedBin | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'binId': value['binId'],
        'packedItems': ((value['packedItems'] as Array<any>).map(PackedItemToJSON)),
        'totalItemsVolume': value['totalItemsVolume'],
        'totalItemsWeight': value['totalItemsWeight'],
        'usedWeightCapacity': value['usedWeightCapacity'],
        'usedVolumeCapacity': value['usedVolumeCapacity'],
        'loadingMeters': value['loadingMeters'],
    };
}

