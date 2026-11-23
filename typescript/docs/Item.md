
# Item


## Properties

Name | Type
------------ | -------------
`id` | string
`dimensions` | [BoxDimensions](BoxDimensions.md)
`weight` | number
`maximumSurfaceLoads` | [ItemSurfaceLoads](ItemSurfaceLoads.md)
`allowedOrientations` | [Array&lt;AllowedOrientation&gt;](AllowedOrientation.md)
`numberOfInstances` | number

## Example

```typescript
import type { Item } from ''

// TODO: Update the object below with actual values
const example = {
  "id": null,
  "dimensions": null,
  "weight": null,
  "maximumSurfaceLoads": null,
  "allowedOrientations": ["ORIGINAL","XZ"],
  "numberOfInstances": null,
} satisfies Item

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as Item
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


