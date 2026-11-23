
# BinPackingOptions

Allows customization of the bin packing operation.

## Properties

Name | Type
------------ | -------------
`unloadingSequence` | [Array&lt;Stop&gt;](Stop.md)
`stackingOptions` | [StackingOptions](StackingOptions.md)

## Example

```typescript
import type { BinPackingOptions } from ''

// TODO: Update the object below with actual values
const example = {
  "unloadingSequence": null,
  "stackingOptions": null,
} satisfies BinPackingOptions

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as BinPackingOptions
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


