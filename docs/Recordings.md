# IO.DialMyCalls.Api.Recordings

All URIs are relative to *https://api.dialmycalls.com/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRecording**](Recordings.md#createrecording) | **POST** /recording/tts | Create Recording (Text-to-Speech)
[**CreateRecordingByPhone**](Recordings.md#createrecordingbyphone) | **POST** /recording/phone | Create Recording (Phone)
[**CreateRecordingByUrl**](Recordings.md#createrecordingbyurl) | **POST** /recording/url | Create Recording (URL)
[**DeleteRecordingById**](Recordings.md#deleterecordingbyid) | **DELETE** /recording/{RecordingId} | Delete Recording
[**GetRecordingById**](Recordings.md#getrecordingbyid) | **GET** /recording/{RecordingId} | Get Recording
[**GetRecordings**](Recordings.md#getrecordings) | **GET** /recordings | List Recordings
[**UpdateRecordingById**](Recordings.md#updaterecordingbyid) | **PUT** /recording/{RecordingId} | Update Recording


<a name="createrecording"></a>
# **CreateRecording**
> Object CreateRecording (CreateRecordingParameters createRecordingParameters)

Create Recording (Text-to-Speech)

Create a new recording using text-to-speech. <br><br> Returns a recording object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"name\": \"Test Recording\", \"gender\": \"M\", \"language\": \"en\", \"text\": \"This is just a test.\"}" https://$API_KEY@api.dialmycalls.com/2.0/recording/tts ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateRecordingExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Recordings();
            var createRecordingParameters = new CreateRecordingParameters(); // CreateRecordingParameters | Request body

            try
            {
                // Create Recording (Text-to-Speech)
                Object result = apiInstance.CreateRecording(createRecordingParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Recordings.CreateRecording: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createRecordingParameters** | [**CreateRecordingParameters**](CreateRecordingParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrecordingbyphone"></a>
# **CreateRecordingByPhone**
> Object CreateRecordingByPhone (CreateRecordingByPhoneParameters createRecordingByPhoneParameters)

Create Recording (Phone)

Create a new recording by phone. <br><br> Returns a recording object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"name\": \"Test Recording\", \"phone\": \"5551234567\", \"callerid_id\": \"$CALLERID_ID\"}" https://$API_KEY@api.dialmycalls.com/2.0/recording/phone ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateRecordingByPhoneExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Recordings();
            var createRecordingByPhoneParameters = new CreateRecordingByPhoneParameters(); // CreateRecordingByPhoneParameters | Request body

            try
            {
                // Create Recording (Phone)
                Object result = apiInstance.CreateRecordingByPhone(createRecordingByPhoneParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Recordings.CreateRecordingByPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createRecordingByPhoneParameters** | [**CreateRecordingByPhoneParameters**](CreateRecordingByPhoneParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrecordingbyurl"></a>
# **CreateRecordingByUrl**
> Object CreateRecordingByUrl (CreateRecordingByUrlParameters createRecordingByUrlParameters)

Create Recording (URL)

Create a new recording from a URL. <br><br> Returns a recording object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"name\": \"Test Recording\", \"url\": \"https://ia700200.us.archive.org/1/items/testmp3testfile/mpthreetest.mp3\"}" https://$API_KEY@api.dialmycalls.com/2.0/recording/url ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateRecordingByUrlExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Recordings();
            var createRecordingByUrlParameters = new CreateRecordingByUrlParameters(); // CreateRecordingByUrlParameters | Request body

            try
            {
                // Create Recording (URL)
                Object result = apiInstance.CreateRecordingByUrl(createRecordingByUrlParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Recordings.CreateRecordingByUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createRecordingByUrlParameters** | [**CreateRecordingByUrlParameters**](CreateRecordingByUrlParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterecordingbyid"></a>
# **DeleteRecordingById**
> Object DeleteRecordingById (string recordingId)

Delete Recording

Delete a recording. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/recording/$RECORDING_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class DeleteRecordingByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Recordings();
            var recordingId = recordingId_example;  // string | RecordingId

            try
            {
                // Delete Recording
                Object result = apiInstance.DeleteRecordingById(recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Recordings.DeleteRecordingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingId** | **string**| RecordingId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecordingbyid"></a>
# **GetRecordingById**
> Object GetRecordingById (string recordingId)

Get Recording

Retrieve a recording. <br><br> Returns a recording object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/recording/$RECORDING_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetRecordingByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Recordings();
            var recordingId = recordingId_example;  // string | RecordingId

            try
            {
                // Get Recording
                Object result = apiInstance.GetRecordingById(recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Recordings.GetRecordingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingId** | **string**| RecordingId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecordings"></a>
# **GetRecordings**
> Object GetRecordings (string range = null)

List Recordings

Retrieve a list of recordings. <br><br> Returns a list of recording objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/recordings ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetRecordingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Recordings();
            var range = range_example;  // string | Range (ie \"records=201-300\") of recordings requested (optional) 

            try
            {
                // List Recordings
                Object result = apiInstance.GetRecordings(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Recordings.GetRecordings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of recordings requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecordingbyid"></a>
# **UpdateRecordingById**
> Object UpdateRecordingById (UpdateRecordingByIdParameters updateRecordingByIdParameters, string recordingId)

Update Recording

Update an existing recording. <br><br> Returns a recording object if a valid identifier was provided and input validation passed, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X PUT -d "{\"name\": \"Test Recording Updated\"}" https://$API_KEY@api.dialmycalls.com/2.0/recording/$RECORDING_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class UpdateRecordingByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Recordings();
            var updateRecordingByIdParameters = new UpdateRecordingByIdParameters(); // UpdateRecordingByIdParameters | Request body
            var recordingId = recordingId_example;  // string | RecordingId

            try
            {
                // Update Recording
                Object result = apiInstance.UpdateRecordingById(updateRecordingByIdParameters, recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Recordings.UpdateRecordingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateRecordingByIdParameters** | [**UpdateRecordingByIdParameters**](UpdateRecordingByIdParameters.md)| Request body | 
 **recordingId** | **string**| RecordingId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

