
# ItemSurfaceLoads

Describes the surface loads in [g/cm²] on an item acting on each of its axis. If an axis is not provided it is assumed to be irrelevant and/or non-restrictive. 

## Properties

Name | Type
------------ | -------------
`x` | number
`y` | number
`z` | number

## Example

```typescript
import type { ItemSurfaceLoads } from ''

// TODO: Update the object below with actual values
const example = {
  "x": null,
  "y": null,
  "z": null,
} satisfies ItemSurfaceLoads

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as ItemSurfaceLoads
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


