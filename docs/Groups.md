# IO.DialMyCalls.Api.Groups

All URIs are relative to *https://api.dialmycalls.com/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroup**](Groups.md#creategroup) | **POST** /group | Add Group
[**DeleteGroupById**](Groups.md#deletegroupbyid) | **DELETE** /group/{GroupId} | Delete Group
[**GetGroupById**](Groups.md#getgroupbyid) | **GET** /group/{GroupId} | Get Group
[**GetGroups**](Groups.md#getgroups) | **GET** /groups | List Groups
[**UpdateGroupById**](Groups.md#updategroupbyid) | **PUT** /group/{GroupId} | Update Group


<a name="creategroup"></a>
# **CreateGroup**
> Object CreateGroup (CreateGroupParameters createGroupParameters)

Add Group

Add a contact group. <br><br> Returns a group object on success, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X POST -d "{\"name\": \"Test Group\"}" https://$API_KEY@api.dialmycalls.com/2.0/group ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Groups();
            var createGroupParameters = new CreateGroupParameters(); // CreateGroupParameters | Request body

            try
            {
                // Add Group
                Object result = apiInstance.CreateGroup(createGroupParameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Groups.CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createGroupParameters** | [**CreateGroupParameters**](CreateGroupParameters.md)| Request body | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupbyid"></a>
# **DeleteGroupById**
> Object DeleteGroupById (string groupId)

Delete Group

Delete a contact group. <br><br> Returns the following if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X DELETE https://$API_KEY@api.dialmycalls.com/2.0/group/$GROUP_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class DeleteGroupByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Groups();
            var groupId = groupId_example;  // string | GroupId

            try
            {
                // Delete Group
                Object result = apiInstance.DeleteGroupById(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Groups.DeleteGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| GroupId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupbyid"></a>
# **GetGroupById**
> Object GetGroupById (string groupId)

Get Group

Retrieve a contact group. <br><br> Returns a group object if a valid identifier was provided, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/group/$GROUP_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetGroupByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Groups();
            var groupId = groupId_example;  // string | GroupId

            try
            {
                // Get Group
                Object result = apiInstance.GetGroupById(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Groups.GetGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| GroupId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroups"></a>
# **GetGroups**
> Object GetGroups (string range = null)

List Groups

Retrieve a list of contact groups. <br><br> Returns a list of group objects. <br><br> ``` curl -i -H "Content-Type: application/json" -X GET https://$API_KEY@api.dialmycalls.com/2.0/groups ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Groups();
            var range = range_example;  // string | Range (ie \"records=201-300\") of groups requested (optional) 

            try
            {
                // List Groups
                Object result = apiInstance.GetGroups(range);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Groups.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **range** | **string**| Range (ie \&quot;records&#x3D;201-300\&quot;) of groups requested | [optional] 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupbyid"></a>
# **UpdateGroupById**
> Object UpdateGroupById (UpdateGroupByIdParameters updateGroupByIdParameters, string groupId)

Update Group

Update an existing contact group. <br><br> Returns a group object if a valid identifier was provided and input validation passed, and returns an error otherwise. <br><br> ``` curl -i -H "Content-Type: application/json" -X PUT -d "{\"name\": \"Test Group Updated\"}" https://$API_KEY@api.dialmycalls.com/2.0/group/$GROUP_ID ```

### Example
```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using IO.DialMyCalls.Model;

namespace Example
{
    public class UpdateGroupByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-Auth-ApiKey", "YOUR_API_KEY");

            var apiInstance = new Groups();
            var updateGroupByIdParameters = new UpdateGroupByIdParameters(); // UpdateGroupByIdParameters | Request body
            var groupId = groupId_example;  // string | GroupId

            try
            {
                // Update Group
                Object result = apiInstance.UpdateGroupById(updateGroupByIdParameters, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Groups.UpdateGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateGroupByIdParameters** | [**UpdateGroupByIdParameters**](UpdateGroupByIdParameters.md)| Request body | 
 **groupId** | **string**| GroupId | 

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

