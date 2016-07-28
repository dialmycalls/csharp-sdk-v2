# IO.DialMyCalls.Model.CreateCallParameters
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | (Required)  Name the broadcast. | [optional] 
**CalleridId** | **Guid?** | (Required)  The caller id that the message should be sent from. | [optional] 
**RecordingId** | **Guid?** | (Required)  The recording id of the message that should be played. | [optional] 
**MachineRecordingId** | **Guid?** | The recording id of the message that should be played on answering machines.  If not supplied the recording_id will be used.  use_amd must be true in order for this feature to work. | [optional] 
**SendAt** | **string** | When the broadcast should be sent. (Ex: 2016-07-25T12:00:00+0000) | [optional] 
**SendImmediately** | **bool?** | Should the broadcast go out immediately? | [optional] 
**UseAmd** | **bool?** | Using answering machine detection? | [optional] 
**SendEmail** | **bool?** | Also send an email to the contacts? | [optional] 
**AccessaccountId** | **Guid?** | Schedule this broadcast as an access account. | [optional] 
**Contacts** | [**List&lt;ContactAttributes&gt;**](ContactAttributes.md) | (Required)  List of contact information that should be sent the broadcast. | [optional] 
**AddOns** | [**List&lt;PushToListenAgain&gt;**](PushToListenAgain.md) | A list of feature add-ons for the calls. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

