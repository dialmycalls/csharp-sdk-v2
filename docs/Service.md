# IO.DialMyCalls.Model.Service
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | Unique identifier for this service. | [optional] 
**AccessaccountId** | **Guid?** | Unique identifier for the access account which initiated this if available. | [optional] 
**Name** | **string** | The name of the service. | [optional] 
**PendingCancel** | **bool?** | Whether the service has been flagged to be cancelled. | [optional] 
**CreditCost** | **float?** | The amount of credits required to schedule this service. | [optional] 
**TotalRecipients** | **decimal?** | The amount of recipients for this service. | [optional] 
**SendAt** | **string** | When the service will be sent. | [optional] 
**CreatedAt** | **string** | When the service was created. | [optional] 
**UpdatedAt** | **string** | When the service was last updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

