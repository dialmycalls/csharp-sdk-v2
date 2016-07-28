# IO.DialMyCalls.Api.Keywords

All URIs are relative to *https://api.dialmycalls.com/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteKeywordByID**](Keywords.md#deletekeywordbyid) | **DELETE** /keyword/{KeywordId} | Delete Keyword
[**GetKeywordByID**](Keywords.md#getkeywordbyid) | **GET** /keyword/{KeywordId} | Get Keyword
[**GetKeywords**](Keywords.md#getkeywords) | **GET** /keywords | List Keywords


<a name="deletekeywordbyid"></a>
# **DeleteKeywordByID**
> Object DeleteKeywordByID (string keywordId)

Delete Keyword

Delete a keyword. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/keyword/$KEYWORD_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class DeleteKeywordByIDExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Keywords();
            var keywordId = keywordId_example;  // string | KeywordId

            try
            {
                // Delete Keyword
                Object result = apiInstance.DeleteKeywordByID(keywordId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Keywords.DeleteKeywordByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keywordId** | **string**| KeywordId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeywordbyid"></a>
# **GetKeywordByID**
> Object GetKeywordByID (string keywordId)

Get Keyword

Retrieve a keyword. <br><br> Returns a keyword object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/keyword/$KEYWORD_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetKeywordByIDExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Keywords();
            var keywordId = keywordId_example;  // string | KeywordId

            try
            {
                // Get Keyword
                Object result = apiInstance.GetKeywordByID(keywordId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Keywords.GetKeywordByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keywordId** | **string**| KeywordId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeywords"></a>
# **GetKeywords**
> Object GetKeywords (string range = null)

List Keywords

Retrieve a list of keywords. <br><br> Returns a list of keyword objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/keywords ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetKeywordsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Keywords();
            var range = range_example;  // string | Range (ie \"records=201-300\") of keywords requested (optional) 

            try
            {
                // List Keywords
                Object result = apiInstance.GetKeywords(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Keywords.GetKeywords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of keywords requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

