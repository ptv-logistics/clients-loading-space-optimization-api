
# PackedBin

Describes a bin packed with items. If Bin.numberOfInstances is greater than one, multiple packed bins with the same PackedBin.binId might be part of a response. 

## Properties

Name | Type
------------ | -------------
`binId` | string
`packedItems` | [Array&lt;PackedItem&gt;](PackedItem.md)
`totalItemsVolume` | number
`totalItemsWeight` | number
`usedWeightCapacity` | number
`usedVolumeCapacity` | number
`loadingMeters` | number

## Example

```typescript
import type { PackedBin } from ''

// TODO: Update the object below with actual values
const example = {
  "binId": null,
  "packedItems": null,
  "totalItemsVolume": null,
  "totalItemsWeight": null,
  "usedWeightCapacity": null,
  "usedVolumeCapacity": null,
  "loadingMeters": null,
} satisfies PackedBin

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as PackedBin
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


