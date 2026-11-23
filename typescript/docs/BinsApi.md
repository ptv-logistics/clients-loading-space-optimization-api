# BinsApi

All URIs are relative to *https://api.myptv.com/binpacking/v1*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**cancelBinPacking**](BinsApi.md#cancelbinpacking) | **DELETE** /bins/{id} |  |
| [**getPackedBins**](BinsApi.md#getpackedbins) | **GET** /bins/{id} |  |
| [**getStatus**](BinsApi.md#getstatus) | **GET** /bins/status/{id} |  |
| [**packBins**](BinsApi.md#packbinsoperation) | **POST** /bins |  |
| [**startBinPacking**](BinsApi.md#startbinpacking) | **POST** /bins/async |  |



## cancelBinPacking

> cancelBinPacking(id)



Cancels a bin packing operation and deletes the results specified by its ID. Results already calculated cannot be requested by its ID, anymore.

### Example

```ts
import {
  Configuration,
  BinsApi,
} from '';
import type { CancelBinPackingRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new BinsApi(config);

  const body = {
    // string | The ID of a bin packing operation.
    id: 38400000-8cf0-11bd-b23e-10b96e4ef00d,
  } satisfies CancelBinPackingRequest;

  try {
    const data = await api.cancelBinPacking(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | `string` | The ID of a bin packing operation. | [Defaults to `undefined`] |

### Return type

`void` (Empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## getPackedBins

> PackBinsResponse getPackedBins(id)



Gets the results of a bin packing operation specified by its ID.

### Example

```ts
import {
  Configuration,
  BinsApi,
} from '';
import type { GetPackedBinsRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new BinsApi(config);

  const body = {
    // string | The ID of a bin packing operation.
    id: 38400000-8cf0-11bd-b23e-10b96e4ef00d,
  } satisfies GetPackedBinsRequest;

  try {
    const data = await api.getPackedBins(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | `string` | The ID of a bin packing operation. | [Defaults to `undefined`] |

### Return type

[**PackBinsResponse**](PackBinsResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## getStatus

> StatusResponse getStatus(id, maximumPollingPeriod)



Returns the status of a bin packing operation.

### Example

```ts
import {
  Configuration,
  BinsApi,
} from '';
import type { GetStatusRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new BinsApi(config);

  const body = {
    // string | The ID of a bin packing operation.
    id: 38400000-8cf0-11bd-b23e-10b96e4ef00d,
    // number | If the calculation is still running, this operation will be blocked and will not return before this period [ms] expires. If the calculation is completed, it will return immediately.  The default of 0 ms will cause the operation to return immediately in any case. Use a value > 0 to implement long polling to reduce the number of requests. See the [tutorial](https://developer.myptv.com/en/resources/tutorials/general/how-use-asynchronous-requests-ptv-developer-apis) on asynchronous requests for details.  (optional)
    maximumPollingPeriod: 56,
  } satisfies GetStatusRequest;

  try {
    const data = await api.getStatus(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **id** | `string` | The ID of a bin packing operation. | [Defaults to `undefined`] |
| **maximumPollingPeriod** | `number` | If the calculation is still running, this operation will be blocked and will not return before this period [ms] expires. If the calculation is completed, it will return immediately.  The default of 0 ms will cause the operation to return immediately in any case. Use a value &gt; 0 to implement long polling to reduce the number of requests. See the [tutorial](https://developer.myptv.com/en/resources/tutorials/general/how-use-asynchronous-requests-ptv-developer-apis) on asynchronous requests for details.  | [Optional] [Defaults to `0`] |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## packBins

> PackBinsResponse packBins(packBinsRequest, focus)



Performs a bin packing operation as described by the request and directly returns the packing result in the response. Therefore the request is restricted as described at the request body to limit the calculation time to a maximum of 10 seconds. In case the operation lasts longer, it will be aborted. The state up to then will be returned. So the result may differ to the asynchronous call.

### Example

```ts
import {
  Configuration,
  BinsApi,
} from '';
import type { PackBinsOperationRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new BinsApi(config);

  const body = {
    // PackBinsRequest | Specifies a packing problem consisting of a number of up to 100 items of various types that get packed into up to 2 bins of various types. Items as well as bins are always of cuboid shape. 
    packBinsRequest: ...,
    // BinPackingFocus (optional)
    focus: ...,
  } satisfies PackBinsOperationRequest;

  try {
    const data = await api.packBins(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **packBinsRequest** | [PackBinsRequest](PackBinsRequest.md) | Specifies a packing problem consisting of a number of up to 100 items of various types that get packed into up to 2 bins of various types. Items as well as bins are always of cuboid shape.  | |
| **focus** | `BinPackingFocus` |  | [Optional] [Defaults to `undefined`] [Enum: BUILD_LAYERS, REDUCE_LOADING_METERS] |

### Return type

[**PackBinsResponse**](PackBinsResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## startBinPacking

> PackedBinsIdentifier startBinPacking(packBinsRequest, focus)



Starts a bin packing operation as described by the request. The result informs if operation is accepted and in this case returns an operation ID. Further information and result should be requested by getStatus() and getPackedBins() via ID.

### Example

```ts
import {
  Configuration,
  BinsApi,
} from '';
import type { StartBinPackingRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new BinsApi(config);

  const body = {
    // PackBinsRequest | Specifies a packing problem consisting of a number of items of various types that get packed into a number of bins of various types. Items as well as bins are always of cuboid shape. 
    packBinsRequest: ...,
    // BinPackingFocus (optional)
    focus: ...,
  } satisfies StartBinPackingRequest;

  try {
    const data = await api.startBinPacking(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **packBinsRequest** | [PackBinsRequest](PackBinsRequest.md) | Specifies a packing problem consisting of a number of items of various types that get packed into a number of bins of various types. Items as well as bins are always of cuboid shape.  | |
| **focus** | `BinPackingFocus` |  | [Optional] [Defaults to `undefined`] [Enum: BUILD_LAYERS, REDUCE_LOADING_METERS] |

### Return type

[**PackedBinsIdentifier**](PackedBinsIdentifier.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)

