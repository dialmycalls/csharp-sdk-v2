# IO.DialMyCalls.Api.VanityNumbers

All URIs are relative to *https://api.dialmycalls.com/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteVanityNumberById**](VanityNumbers.md#deletevanitynumberbyid) | **DELETE** /vanitynumber/{VanityNumberId} | Delete Vanity Number
[**GetVanityNumberById**](VanityNumbers.md#getvanitynumberbyid) | **GET** /vanitynumber/{VanityNumberId} | Get Vanity Number
[**GetVanityNumbers**](VanityNumbers.md#getvanitynumbers) | **GET** /vanitynumbers | List Vanity Numbers
[**UpdateVanityNumberById**](VanityNumbers.md#updatevanitynumberbyid) | **PUT** /vanitynumber/{VanityNumberId} | Update Vanity Number


<a name="deletevanitynumberbyid"></a>
# **DeleteVanityNumberById**
> Object DeleteVanityNumberById (string vanityNumberId)

Delete Vanity Number

Delete a vanity number. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/keyword/$VANITYNUMBER_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class DeleteVanityNumberByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new VanityNumbers();
            var vanityNumberId = vanityNumberId_example;  // string | VanityNumberId

            try
            {
                // Delete Vanity Number
                Object result = apiInstance.DeleteVanityNumberById(vanityNumberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VanityNumbers.DeleteVanityNumberById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vanityNumberId** | **string**| VanityNumberId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvanitynumberbyid"></a>
# **GetVanityNumberById**
> Object GetVanityNumberById (string vanityNumberId)

Get Vanity Number

Retrieve a vanity number. <br><br> Returns a vanitynumber object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/vanitynumber/$VANITYNUMBER_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetVanityNumberByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new VanityNumbers();
            var vanityNumberId = vanityNumberId_example;  // string | VanityNumberId

            try
            {
                // Get Vanity Number
                Object result = apiInstance.GetVanityNumberById(vanityNumberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VanityNumbers.GetVanityNumberById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vanityNumberId** | **string**| VanityNumberId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvanitynumbers"></a>
# **GetVanityNumbers**
> Object GetVanityNumbers (string range = null)

List Vanity Numbers

Retrieve a list of vanity numbers. <br><br> Returns a list of vanitynumber objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/vanitynumbers ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetVanityNumbersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new VanityNumbers();
            var range = range_example;  // string | Range (ie \"records=201-300\") of vanitynumbers requested (optional) 

            try
            {
                // List Vanity Numbers
                Object result = apiInstance.GetVanityNumbers(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VanityNumbers.GetVanityNumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of vanitynumbers requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevanitynumberbyid"></a>
# **UpdateVanityNumberById**
> Object UpdateVanityNumberById (UpdateVanityNumberByIdParameters updateVanityNumberByIdParameters, string vanityNumberId)

Update Vanity Number

Update a vanity number. <br><br> Returns a vanitynumber object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X PUT -d "{\"ptt_number_id\":\"aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeee\",\"call_options\":{\"voicemail\":true}}" https://$API_KEY@api.dialmycalls.com/2.0/vanitynumber/$VANITYNUMBER_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class UpdateVanityNumberByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new VanityNumbers();
            var updateVanityNumberByIdParameters = new UpdateVanityNumberByIdParameters(); // UpdateVanityNumberByIdParameters | Request body
            var vanityNumberId = vanityNumberId_example;  // string | VanityNumberId

            try
            {
                // Update Vanity Number
                Object result = apiInstance.UpdateVanityNumberById(updateVanityNumberByIdParameters, vanityNumberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VanityNumbers.UpdateVanityNumberById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateVanityNumberByIdParameters** | [**UpdateVanityNumberByIdParameters**](UpdateVanityNumberByIdParameters.md)| Request body | 
 **vanityNumberId** | **string**| VanityNumberId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

