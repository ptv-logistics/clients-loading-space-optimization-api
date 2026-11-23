
# StackingOptions

Defines all stacking options to be considered during the packing algorithm.

## Properties

Name | Type
------------ | -------------
`stackingRestrictions` | [Array&lt;StackingRestrictions&gt;](StackingRestrictions.md)
`stackOnTopOfNextStops` | boolean
`stackOnTopOfMultipleStacks` | boolean

## Example

```typescript
import type { StackingOptions } from ''

// TODO: Update the object below with actual values
const example = {
  "stackingRestrictions": null,
  "stackOnTopOfNextStops": false,
  "stackOnTopOfMultipleStacks": false,
} satisfies StackingOptions

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as StackingOptions
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


