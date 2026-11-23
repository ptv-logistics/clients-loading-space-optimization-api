
# ItemOrientation

Describes the orientation that was used to place the item into the bin. * `ORIGINAL` - Item was not re-oriented. Dimensions stay (x,y,z). * `X` - Item was rotated around x-axis (widthwise) by +/-90 degrees compared to the original orientation. Dimensions are (x,z,y). * `Y` - Item was rotated around y-axis (heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,y,x). * `Z` - Item was rotated around z-axis (lengthwise) by +/-90 degrees compared to the original orientation. Dimensions are (y,x,z). * `XZ` - Item was rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y). * `YZ` - Item was rotated around x- then z-axis (width- then heightwise) by +/-90 degrees compared to the original orientation. Dimensions are (z,x,y).

## Properties

Name | Type
------------ | -------------

## Example

```typescript
import type { ItemOrientation } from ''

// TODO: Update the object below with actual values
const example = {
} satisfies ItemOrientation

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as ItemOrientation
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


