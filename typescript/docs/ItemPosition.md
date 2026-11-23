
# ItemPosition

Describes the position of an item in a bin.  The coordinate system is right-handed with x extending to the right, y pointing up and z pointing towards you. In terms of a truck (0,0,0) would be at the lower-left-corner of the opposing wall when looking through the back doors.  An item, for example a palette, placed there would be on the ground. It would also touch the left wall as well as the wall towards the drivers cabin. 

## Properties

Name | Type
------------ | -------------
`x` | number
`y` | number
`z` | number

## Example

```typescript
import type { ItemPosition } from ''

// TODO: Update the object below with actual values
const example = {
  "x": null,
  "y": null,
  "z": null,
} satisfies ItemPosition

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as ItemPosition
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


