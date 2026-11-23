
# ItemsToUnload

Defines the number of instances of an item to unload.

## Properties

Name | Type
------------ | -------------
`itemId` | string
`numberOfInstances` | number

## Example

```typescript
import type { ItemsToUnload } from ''

// TODO: Update the object below with actual values
const example = {
  "itemId": null,
  "numberOfInstances": null,
} satisfies ItemsToUnload

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as ItemsToUnload
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


