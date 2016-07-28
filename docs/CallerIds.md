# IO.DialMyCalls.Api.CallerIds

All URIs are relative to *https://api.dialmycalls.com/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCallerId**](CallerIds.md#createcallerid) | **POST** /callerid | Add Caller ID
[**CreateUnverifiedCallerId**](CallerIds.md#createunverifiedcallerid) | **POST** /verify/callerid | Add Caller ID (Unverified)
[**DeleteCallerIdById**](CallerIds.md#deletecalleridbyid) | **DELETE** /callerid/{CalleridId} | Delete Caller ID
[**GetCallerIdById**](CallerIds.md#getcalleridbyid) | **GET** /callerid/{CalleridId} | Get Caller ID
[**GetCallerIds**](CallerIds.md#getcallerids) | **GET** /callerids | List Caller IDs
[**UpdateCallerIdById**](CallerIds.md#updatecalleridbyid) | **PUT** /callerid/{CalleridId} | Update Caller ID
[**VerifyCallerIdById**](CallerIds.md#verifycalleridbyid) | **PUT** /verify/callerid/{CalleridId} | Verify Caller ID


<a name="createcallerid"></a>
# **CreateCallerId**
> Object CreateCallerId (CreateCallerIdParameters createCallerIdParameters)

Add Caller ID

Add a caller ID. <br><br> Returns a caller ID object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"phone\": \"5555555555\", \"name\": \"New Number\"}" https://$API_KEY@api.dialmycalls.com/2.0/callerid ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateCallerIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CallerIds();
            var createCallerIdParameters = new CreateCallerIdParameters(); // CreateCallerIdParameters | Request body

            try
            {
                // Add Caller ID
                Object result = apiInstance.CreateCallerId(createCallerIdParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallerIds.CreateCallerId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCallerIdParameters** | [**CreateCallerIdParameters**](CreateCallerIdParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createunverifiedcallerid"></a>
# **CreateUnverifiedCallerId**
> Object CreateUnverifiedCallerId (CreateUnverifiedCallerIdParameters createUnverifiedCallerIdParameters)

Add Caller ID (Unverified)

Initiate adding a new caller ID when you need to go through the verification process. You will receive a phone call at the phone number provided and will need to make a subsequent API call with the PIN code that you are provided. <br><br> Returns a caller ID object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"phone\": \"5555555555\", \"name\": \"New Number\"}" https://$API_KEY@api.dialmycalls.com/2.0/verify/callerid ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateUnverifiedCallerIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CallerIds();
            var createUnverifiedCallerIdParameters = new CreateUnverifiedCallerIdParameters(); // CreateUnverifiedCallerIdParameters | Request body

            try
            {
                // Add Caller ID (Unverified)
                Object result = apiInstance.CreateUnverifiedCallerId(createUnverifiedCallerIdParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallerIds.CreateUnverifiedCallerId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createUnverifiedCallerIdParameters** | [**CreateUnverifiedCallerIdParameters**](CreateUnverifiedCallerIdParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecalleridbyid"></a>
# **DeleteCallerIdById**
> Object DeleteCallerIdById (string calleridId)

Delete Caller ID

Delete a caller ID. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/callerid/$CALLERID_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class DeleteCallerIdByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CallerIds();
            var calleridId = calleridId_example;  // string | CalleridId

            try
            {
                // Delete Caller ID
                Object result = apiInstance.DeleteCallerIdById(calleridId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallerIds.DeleteCallerIdById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calleridId** | **string**| CalleridId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcalleridbyid"></a>
# **GetCallerIdById**
> Object GetCallerIdById (string calleridId)

Get Caller ID

Retrieve a caller ID. <br><br> Returns a caller ID object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/callerid/$CALLERID_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetCallerIdByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CallerIds();
            var calleridId = calleridId_example;  // string | CalleridId

            try
            {
                // Get Caller ID
                Object result = apiInstance.GetCallerIdById(calleridId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallerIds.GetCallerIdById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calleridId** | **string**| CalleridId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcallerids"></a>
# **GetCallerIds**
> Object GetCallerIds (string range = null)

List Caller IDs

Retrieve a list of caller IDs. <br><br> Returns a list of caller ID objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/callerids ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetCallerIdsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CallerIds();
            var range = range_example;  // string | Range (ie \"records=201-300\") of callerids requested (optional) 

            try
            {
                // List Caller IDs
                Object result = apiInstance.GetCallerIds(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallerIds.GetCallerIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of callerids requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecalleridbyid"></a>
# **UpdateCallerIdById**
> Object UpdateCallerIdById (UpdateCallerIdByIdParameters updateCallerIdByIdParameters, string calleridId)

Update Caller ID

Update an existing caller ID. <br><br> Returns a caller ID object if a valid identifier was provided and input validation passed, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X PUT -d "{\"name\": \"New Number Updated\"}" https://$API_KEY@api.dialmycalls.com/2.0/callerid/$CALLERID_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class UpdateCallerIdByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CallerIds();
            var updateCallerIdByIdParameters = new UpdateCallerIdByIdParameters(); // UpdateCallerIdByIdParameters | Request body
            var calleridId = calleridId_example;  // string | CalleridId

            try
            {
                // Update Caller ID
                Object result = apiInstance.UpdateCallerIdById(updateCallerIdByIdParameters, calleridId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallerIds.UpdateCallerIdById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateCallerIdByIdParameters** | [**UpdateCallerIdByIdParameters**](UpdateCallerIdByIdParameters.md)| Request body | 
 **calleridId** | **string**| CalleridId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifycalleridbyid"></a>
# **VerifyCallerIdById**
> Object VerifyCallerIdById (VerifyCallerIdByIdParameters verifyCallerIdByIdParameters, string calleridId)

Verify Caller ID

Verify a new caller ID. <br><br> Returns a caller ID object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"phone\": \"5555555555\", \"name\": \"New Number\"}" https://$API_KEY@api.dialmycalls.com/2.0/verify/callerid/$CALLERID_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class VerifyCallerIdByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new CallerIds();
            var verifyCallerIdByIdParameters = new VerifyCallerIdByIdParameters(); // VerifyCallerIdByIdParameters | Request body
            var calleridId = calleridId_example;  // string | CalleridId

            try
            {
                // Verify Caller ID
                Object result = apiInstance.VerifyCallerIdById(verifyCallerIdByIdParameters, calleridId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallerIds.VerifyCallerIdById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **verifyCallerIdByIdParameters** | [**VerifyCallerIdByIdParameters**](VerifyCallerIdByIdParameters.md)| Request body | 
 **calleridId** | **string**| CalleridId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

