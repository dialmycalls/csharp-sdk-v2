# IO.DialMyCalls.Api.Accounts

All URIs are relative to *https://api.dialmycalls.com/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccessAccount**](Accounts.md#createaccessaccount) | **POST** /accessaccount | Add Access Account
[**DeleteAccessAccountById**](Accounts.md#deleteaccessaccountbyid) | **DELETE** /accessaccount/{AccessAccountId} | Delete Access Account
[**GetAccessAccountById**](Accounts.md#getaccessaccountbyid) | **GET** /accessaccount/{AccessAccountId} | Get Access Account
[**GetAccessAccounts**](Accounts.md#getaccessaccounts) | **GET** /accessaccounts | List Access Accounts
[**GetAccount**](Accounts.md#getaccount) | **GET** /account | Get Account
[**UpdateAccessAccountById**](Accounts.md#updateaccessaccountbyid) | **PUT** /accessaccount/{AccessAccountId} | Update Access Account


<a name="createaccessaccount"></a>
# **CreateAccessAccount**
> Object CreateAccessAccount (CreateAccessAccountParameters createAccessAccountParameters)

Add Access Account

Add a access account. <br><br> Returns a access account object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"email\": \"test@test.com\", \"password\": \"1234A5678\", \"name\": \"John Doe\"}" https://$API_KEY@api.dialmycalls.com/2.0/accessaccount ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateAccessAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Accounts();
            var createAccessAccountParameters = new CreateAccessAccountParameters(); // CreateAccessAccountParameters | Request body

            try
            {
                // Add Access Account
                Object result = apiInstance.CreateAccessAccount(createAccessAccountParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Accounts.CreateAccessAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createAccessAccountParameters** | [**CreateAccessAccountParameters**](CreateAccessAccountParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccessaccountbyid"></a>
# **DeleteAccessAccountById**
> Object DeleteAccessAccountById (string accessAccountId)

Delete Access Account

Delete a access account. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/accessaccount/$ACCESSACCOUNT_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class DeleteAccessAccountByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Accounts();
            var accessAccountId = accessAccountId_example;  // string | AccessAccountId

            try
            {
                // Delete Access Account
                Object result = apiInstance.DeleteAccessAccountById(accessAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Accounts.DeleteAccessAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessAccountId** | **string**| AccessAccountId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccessaccountbyid"></a>
# **GetAccessAccountById**
> Object GetAccessAccountById (string accessAccountId)

Get Access Account

Retrieve an access account. <br><br> Returns a access account object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/accessaccount/$ACCESSACCOUNT_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetAccessAccountByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Accounts();
            var accessAccountId = accessAccountId_example;  // string | AccessAccountId

            try
            {
                // Get Access Account
                Object result = apiInstance.GetAccessAccountById(accessAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Accounts.GetAccessAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessAccountId** | **string**| AccessAccountId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccessaccounts"></a>
# **GetAccessAccounts**
> Object GetAccessAccounts (string range = null)

List Access Accounts

Retrieve a list of access accounts. <br><br> Returns a list of access account objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/accessaccounts ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetAccessAccountsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Accounts();
            var range = range_example;  // string | Range (ie \"records=201-300\") of accessaccounts requested (optional) 

            try
            {
                // List Access Accounts
                Object result = apiInstance.GetAccessAccounts(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Accounts.GetAccessAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of accessaccounts requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
> Object GetAccount ()

Get Account

Retrieve account details. <br><br> Returns a account object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/account ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Accounts();

            try
            {
                // Get Account
                Object result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Accounts.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccessaccountbyid"></a>
# **UpdateAccessAccountById**
> Object UpdateAccessAccountById (UpdateAccessAccountByIdParameters updateAccessAccountByIdParameters, string accessAccountId)

Update Access Account

Update an existing access account. <br><br> Returns a access account object if a valid identifier was provided and input validation passed, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X PUT -d "{\"name\": \"New Name\"}" https://$API_KEY@api.dialmycalls.com/2.0/accessaccount/$ACCESSACCOUNT_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class UpdateAccessAccountByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Accounts();
            var updateAccessAccountByIdParameters = new UpdateAccessAccountByIdParameters(); // UpdateAccessAccountByIdParameters | Request body
            var accessAccountId = accessAccountId_example;  // string | AccessAccountId

            try
            {
                // Update Access Account
                Object result = apiInstance.UpdateAccessAccountById(updateAccessAccountByIdParameters, accessAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Accounts.UpdateAccessAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateAccessAccountByIdParameters** | [**UpdateAccessAccountByIdParameters**](UpdateAccessAccountByIdParameters.md)| Request body | 
 **accessAccountId** | **string**| AccessAccountId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

