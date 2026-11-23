
# Bin


## Properties

Name | Type
------------ | -------------
`id` | string
`numberOfInstances` | number
`dimensions` | [BoxDimensions](BoxDimensions.md)
`maximumVolumeCapacity` | number
`maximumWeightCapacity` | number

## Example

```typescript
import type { Bin } from ''

// TODO: Update the object below with actual values
const example = {
  "id": null,
  "numberOfInstances": null,
  "dimensions": null,
  "maximumVolumeCapacity": null,
  "maximumWeightCapacity": null,
} satisfies Bin

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as Bin
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


