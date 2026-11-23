
# BinPackingFocus

Algorithmic focus for the bin packing operation: * `BUILD_LAYERS` - Focus on building horizontal layers of similar items. This will freely use available floor space with no special regard to loading meters. * `REDUCE_LOADING_METERS` - Focus on reducing loading meters. This might result in less efficient use of overall volume.

## Properties

Name | Type
------------ | -------------

## Example

```typescript
import type { BinPackingFocus } from ''

// TODO: Update the object below with actual values
const example = {
} satisfies BinPackingFocus

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as BinPackingFocus
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


