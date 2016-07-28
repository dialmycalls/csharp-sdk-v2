# IO.DialMyCalls.Api.Texts

All URIs are relative to *https://api.dialmycalls.com/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelTextById**](Texts.md#canceltextbyid) | **DELETE** /service/text/{TextId} | Cancel Text
[**CreateText**](Texts.md#createtext) | **POST** /service/text | Create Text
[**DeleteIncomingTextById**](Texts.md#deleteincomingtextbyid) | **DELETE** /incoming/text/{TextId} | Delete Incoming Text
[**GetIncomingTextById**](Texts.md#getincomingtextbyid) | **GET** /incoming/text/{TextId} | Get Incoming Text
[**GetIncomingTexts**](Texts.md#getincomingtexts) | **GET** /incoming/texts | List Incoming Texts
[**GetShortCodes**](Texts.md#getshortcodes) | **GET** /shortcodes | List Shortcodes
[**GetTextById**](Texts.md#gettextbyid) | **GET** /service/text/{TextId} | Get Text
[**GetTextRecipientsByTextId**](Texts.md#gettextrecipientsbytextid) | **GET** /service/text/{TextId}/recipients | Get Text Recipients
[**GetTexts**](Texts.md#gettexts) | **GET** /service/texts | List Texts


<a name="canceltextbyid"></a>
# **CancelTextById**
> Object CancelTextById (string textId)

Cancel Text

Cancel an outgoing text. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/service/text/$TEXT_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CancelTextByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var textId = textId_example;  // string | TextId

            try
            {
                // Cancel Text
                Object result = apiInstance.CancelTextById(textId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.CancelTextById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **textId** | **string**| TextId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtext"></a>
# **CreateText**
> Object CreateText (CreateTextParameters createTextParameters)

Create Text

Create an outgoing text broadcast. <br><br> Returns a service object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"keyword_id\": \"dfe49537-a0a8-4f4a-98a1-e03df388af11\", \"send_immediately\": true,\"messages\": [\"Testing testing\"], \"contacts\": [{\"phone\":\"1116551235\"},{\"phone\":\"1116551234\"}]}" https://$API_KEY@api.dialmycalls.com/2.0/service/text ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateTextExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var createTextParameters = new CreateTextParameters(); // CreateTextParameters | Request body

            try
            {
                // Create Text
                Object result = apiInstance.CreateText(createTextParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.CreateText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createTextParameters** | [**CreateTextParameters**](CreateTextParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteincomingtextbyid"></a>
# **DeleteIncomingTextById**
> Object DeleteIncomingTextById (string textId)

Delete Incoming Text

Delete a incoming text. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/incoming/text/$TEXT_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class DeleteIncomingTextByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var textId = textId_example;  // string | TextId

            try
            {
                // Delete Incoming Text
                Object result = apiInstance.DeleteIncomingTextById(textId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.DeleteIncomingTextById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **textId** | **string**| TextId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getincomingtextbyid"></a>
# **GetIncomingTextById**
> Object GetIncomingTextById (string textId)

Get Incoming Text

Retrieve a text. <br><br> Returns a Incoming Text object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/incoming/text/$TEXT_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetIncomingTextByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var textId = textId_example;  // string | TextId

            try
            {
                // Get Incoming Text
                Object result = apiInstance.GetIncomingTextById(textId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.GetIncomingTextById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **textId** | **string**| TextId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getincomingtexts"></a>
# **GetIncomingTexts**
> Object GetIncomingTexts (string range = null)

List Incoming Texts

Retrieve a list of texts. <br><br> Returns a list of Incoming Text objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/incoming/texts ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetIncomingTextsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var range = range_example;  // string | Range (ie \"records=201-300\") of texts requested (optional) 

            try
            {
                // List Incoming Texts
                Object result = apiInstance.GetIncomingTexts(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.GetIncomingTexts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of texts requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshortcodes"></a>
# **GetShortCodes**
> Object GetShortCodes (string range = null)

List Shortcodes

Retrieve a list of shortcodes. <br><br> Returns a list of shortcode objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/shortcodes ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetShortCodesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var range = range_example;  // string | Range (ie \"records=201-300\") of shortcodes requested (optional) 

            try
            {
                // List Shortcodes
                Object result = apiInstance.GetShortCodes(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.GetShortCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of shortcodes requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettextbyid"></a>
# **GetTextById**
> Object GetTextById (string textId)

Get Text

Retrieve a text. <br><br> Returns a service object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/service/text/$TEXT_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetTextByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var textId = textId_example;  // string | TextId

            try
            {
                // Get Text
                Object result = apiInstance.GetTextById(textId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.GetTextById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **textId** | **string**| TextId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettextrecipientsbytextid"></a>
# **GetTextRecipientsByTextId**
> Object GetTextRecipientsByTextId (string textId, string range = null)

Get Text Recipients

Retrieve a list of a text's recipients. <br><br> Returns a list of text recipient objects if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/service/text/$TEXT_ID/recipients ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetTextRecipientsByTextIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var textId = textId_example;  // string | TextId
            var range = range_example;  // string | Range (ie \"records=201-300\") of recipients requested (optional) 

            try
            {
                // Get Text Recipients
                Object result = apiInstance.GetTextRecipientsByTextId(textId, range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.GetTextRecipientsByTextId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **textId** | **string**| TextId | 
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of recipients requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettexts"></a>
# **GetTexts**
> Object GetTexts (string range = null)

List Texts

Retrieve a list of texts. <br><br> Returns a list of service objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/service/texts ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetTextsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Texts();
            var range = range_example;  // string | Range (ie \"records=201-300\") of texts requested (optional) 

            try
            {
                // List Texts
                Object result = apiInstance.GetTexts(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Texts.GetTexts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of texts requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

