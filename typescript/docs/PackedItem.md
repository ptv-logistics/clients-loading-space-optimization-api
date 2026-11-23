
# PackedItem

Describes how an item is packed into the bin. If Item.numberOfInstances is greater than one, several of this item are packed into the bin. 

## Properties

Name | Type
------------ | -------------
`itemId` | string
`position` | [ItemPosition](ItemPosition.md)
`dimensions` | [BoxDimensions](BoxDimensions.md)
`orientation` | [ItemOrientation](ItemOrientation.md)

## Example

```typescript
import type { PackedItem } from ''

// TODO: Update the object below with actual values
const example = {
  "itemId": null,
  "position": null,
  "dimensions": null,
  "orientation": null,
} satisfies PackedItem

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as PackedItem
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


