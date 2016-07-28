# IO.DialMyCalls.Model.CreateTextParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | (Required)  Name the broadcast. | [optional] 
**KeywordId** | **Guid?** | (Required)  The keyword id that should be associated with this broadcast. | [optional] 
**Messages** | **List&lt;string&gt;** | (Required)  List of messages to send (up to 10). | [optional] 
**SendAt** | **string** | When the broadcast should be sent. (Ex: 2016-07-25T12:00:00+0000) | [optional] 
**SendImmediately** | **bool?** | Should the broadcast go out immediately? | [optional] 
**SendEmail** | **bool?** | Also send an email to the contacts? | [optional] 
**AccessaccountId** | **Guid?** | Schedule this broadcast as an access account. | [optional] 
**ShortcodeId** | **Guid?** | The shortcode id that the broadcast will be sent from. | [optional] 
**ConcatenateSms** | **bool?** | Combine all SMS messages into 1 message on the end users device. | [optional] 
**Contacts** | [**List&lt;ContactAttributes&gt;**](ContactAttributes.md) | (Required)  List of contact information that should be sent the broadcast. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

