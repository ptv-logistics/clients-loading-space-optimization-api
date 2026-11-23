
# StackingRestrictionType

Defines the stacking restrictions: * `ALL_ALLOWED` - All items can be stacked on top of this item. * `ALL_PROHIBITED` - No further item may be stacked on top of this item. * `ALLOWED` - Every listed items can be stacked on top of this item. * `PROHIBITED` - None of the listed items may be stacked on top of this item.

## Properties

Name | Type
------------ | -------------

## Example

```typescript
import type { StackingRestrictionType } from ''

// TODO: Update the object below with actual values
const example = {
} satisfies StackingRestrictionType

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as StackingRestrictionType
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


