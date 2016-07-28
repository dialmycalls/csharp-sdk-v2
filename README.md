# IO.DialMyCalls - the C# library for the DialMyCalls API

The DialMyCalls API

For more information, please visit [https://www.dialmycalls.com](https://www.dialmycalls.com)

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.DialMyCalls.Api;
using IO.DialMyCalls.Client;
using Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.dialmycalls.com/2.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*Accounts* | [**CreateAccessAccount**](docs/Accounts.md#createaccessaccount) | **POST** /accessaccount | Add Access Account
*Accounts* | [**DeleteAccessAccountById**](docs/Accounts.md#deleteaccessaccountbyid) | **DELETE** /accessaccount/{AccessAccountId} | Delete Access Account
*Accounts* | [**GetAccessAccountById**](docs/Accounts.md#getaccessaccountbyid) | **GET** /accessaccount/{AccessAccountId} | Get Access Account
*Accounts* | [**GetAccessAccounts**](docs/Accounts.md#getaccessaccounts) | **GET** /accessaccounts | List Access Accounts
*Accounts* | [**GetAccount**](docs/Accounts.md#getaccount) | **GET** /account | Get Account
*Accounts* | [**UpdateAccessAccountById**](docs/Accounts.md#updateaccessaccountbyid) | **PUT** /accessaccount/{AccessAccountId} | Update Access Account
*CallerIds* | [**CreateCallerId**](docs/CallerIds.md#createcallerid) | **POST** /callerid | Add Caller ID
*CallerIds* | [**CreateUnverifiedCallerId**](docs/CallerIds.md#createunverifiedcallerid) | **POST** /verify/callerid | Add Caller ID (Unverified)
*CallerIds* | [**DeleteCallerIdById**](docs/CallerIds.md#deletecalleridbyid) | **DELETE** /callerid/{CalleridId} | Delete Caller ID
*CallerIds* | [**GetCallerIdById**](docs/CallerIds.md#getcalleridbyid) | **GET** /callerid/{CalleridId} | Get Caller ID
*CallerIds* | [**GetCallerIds**](docs/CallerIds.md#getcallerids) | **GET** /callerids | List Caller IDs
*CallerIds* | [**UpdateCallerIdById**](docs/CallerIds.md#updatecalleridbyid) | **PUT** /callerid/{CalleridId} | Update Caller ID
*CallerIds* | [**VerifyCallerIdById**](docs/CallerIds.md#verifycalleridbyid) | **PUT** /verify/callerid/{CalleridId} | Verify Caller ID
*Calls* | [**CancelCallById**](docs/Calls.md#cancelcallbyid) | **DELETE** /service/call/{CallId} | Cancel Call
*Calls* | [**CreateCall**](docs/Calls.md#createcall) | **POST** /service/call | Create Call
*Calls* | [**GetCallById**](docs/Calls.md#getcallbyid) | **GET** /service/call/{CallId} | Get Call
*Calls* | [**GetCallRecipientsByCallId**](docs/Calls.md#getcallrecipientsbycallid) | **GET** /service/call/{CallId}/recipients | Get Call Recipients
*Calls* | [**GetCalls**](docs/Calls.md#getcalls) | **GET** /service/calls | List Calls
*Contacts* | [**CreateContact**](docs/Contacts.md#createcontact) | **POST** /contact | Add Contact
*Contacts* | [**DeleteContactById**](docs/Contacts.md#deletecontactbyid) | **DELETE** /contact/{ContactId} | Delete Contact
*Contacts* | [**GetContactById**](docs/Contacts.md#getcontactbyid) | **GET** /contact/{ContactId} | Get Contact
*Contacts* | [**GetContacts**](docs/Contacts.md#getcontacts) | **GET** /contacts | List Contacts
*Contacts* | [**GetContactsByGroupId**](docs/Contacts.md#getcontactsbygroupid) | **GET** /contacts/{GroupId} | List Contacts in Group
*Contacts* | [**UpdateContactById**](docs/Contacts.md#updatecontactbyid) | **PUT** /contact/{ContactId} | Update Contact
*DoNotContacts* | [**GetDoNotContacts**](docs/DoNotContacts.md#getdonotcontacts) | **GET** /donotcontacts | List DoNotContacts
*Groups* | [**CreateGroup**](docs/Groups.md#creategroup) | **POST** /group | Add Group
*Groups* | [**DeleteGroupById**](docs/Groups.md#deletegroupbyid) | **DELETE** /group/{GroupId} | Delete Group
*Groups* | [**GetGroupById**](docs/Groups.md#getgroupbyid) | **GET** /group/{GroupId} | Get Group
*Groups* | [**GetGroups**](docs/Groups.md#getgroups) | **GET** /groups | List Groups
*Groups* | [**UpdateGroupById**](docs/Groups.md#updategroupbyid) | **PUT** /group/{GroupId} | Update Group
*Keywords* | [**DeleteKeywordByID**](docs/Keywords.md#deletekeywordbyid) | **DELETE** /keyword/{KeywordId} | Delete Keyword
*Keywords* | [**GetKeywordByID**](docs/Keywords.md#getkeywordbyid) | **GET** /keyword/{KeywordId} | Get Keyword
*Keywords* | [**GetKeywords**](docs/Keywords.md#getkeywords) | **GET** /keywords | List Keywords
*Recordings* | [**CreateRecording**](docs/Recordings.md#createrecording) | **POST** /recording/tts | Create Recording (Text-to-Speech)
*Recordings* | [**CreateRecordingByPhone**](docs/Recordings.md#createrecordingbyphone) | **POST** /recording/phone | Create Recording (Phone)
*Recordings* | [**CreateRecordingByUrl**](docs/Recordings.md#createrecordingbyurl) | **POST** /recording/url | Create Recording (URL)
*Recordings* | [**DeleteRecordingById**](docs/Recordings.md#deleterecordingbyid) | **DELETE** /recording/{RecordingId} | Delete Recording
*Recordings* | [**GetRecordingById**](docs/Recordings.md#getrecordingbyid) | **GET** /recording/{RecordingId} | Get Recording
*Recordings* | [**GetRecordings**](docs/Recordings.md#getrecordings) | **GET** /recordings | List Recordings
*Recordings* | [**UpdateRecordingById**](docs/Recordings.md#updaterecordingbyid) | **PUT** /recording/{RecordingId} | Update Recording
*Texts* | [**CancelTextById**](docs/Texts.md#canceltextbyid) | **DELETE** /service/text/{TextId} | Cancel Text
*Texts* | [**CreateText**](docs/Texts.md#createtext) | **POST** /service/text | Create Text
*Texts* | [**DeleteIncomingTextById**](docs/Texts.md#deleteincomingtextbyid) | **DELETE** /incoming/text/{TextId} | Delete Incoming Text
*Texts* | [**GetIncomingTextById**](docs/Texts.md#getincomingtextbyid) | **GET** /incoming/text/{TextId} | Get Incoming Text
*Texts* | [**GetIncomingTexts**](docs/Texts.md#getincomingtexts) | **GET** /incoming/texts | List Incoming Texts
*Texts* | [**GetShortCodes**](docs/Texts.md#getshortcodes) | **GET** /shortcodes | List Shortcodes
*Texts* | [**GetTextById**](docs/Texts.md#gettextbyid) | **GET** /service/text/{TextId} | Get Text
*Texts* | [**GetTextRecipientsByTextId**](docs/Texts.md#gettextrecipientsbytextid) | **GET** /service/text/{TextId}/recipients | Get Text Recipients
*Texts* | [**GetTexts**](docs/Texts.md#gettexts) | **GET** /service/texts | List Texts
*VanityNumbers* | [**DeleteVanityNumberById**](docs/VanityNumbers.md#deletevanitynumberbyid) | **DELETE** /vanitynumber/{VanityNumberId} | Delete Vanity Number
*VanityNumbers* | [**GetVanityNumberById**](docs/VanityNumbers.md#getvanitynumberbyid) | **GET** /vanitynumber/{VanityNumberId} | Get Vanity Number
*VanityNumbers* | [**GetVanityNumbers**](docs/VanityNumbers.md#getvanitynumbers) | **GET** /vanitynumbers | List Vanity Numbers
*VanityNumbers* | [**UpdateVanityNumberById**](docs/VanityNumbers.md#updatevanitynumberbyid) | **PUT** /vanitynumber/{VanityNumberId} | Update Vanity Number


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Accessaccount](docs/Accessaccount.md)
 - [Model.Account](docs/Account.md)
 - [Model.CallRecipient](docs/CallRecipient.md)
 - [Model.Callerid](docs/Callerid.md)
 - [Model.Callservice](docs/Callservice.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactAttributes](docs/ContactAttributes.md)
 - [Model.CreateAccessAccountParameters](docs/CreateAccessAccountParameters.md)
 - [Model.CreateCallParameters](docs/CreateCallParameters.md)
 - [Model.CreateCallerIdParameters](docs/CreateCallerIdParameters.md)
 - [Model.CreateContactParameters](docs/CreateContactParameters.md)
 - [Model.CreateGroupParameters](docs/CreateGroupParameters.md)
 - [Model.CreateRecordingByPhoneParameters](docs/CreateRecordingByPhoneParameters.md)
 - [Model.CreateRecordingByUrlParameters](docs/CreateRecordingByUrlParameters.md)
 - [Model.CreateRecordingParameters](docs/CreateRecordingParameters.md)
 - [Model.CreateTextParameters](docs/CreateTextParameters.md)
 - [Model.CreateUnverifiedCallerIdParameters](docs/CreateUnverifiedCallerIdParameters.md)
 - [Model.Donotcontact](docs/Donotcontact.md)
 - [Model.Group](docs/Group.md)
 - [Model.Identifier](docs/Identifier.md)
 - [Model.Incomingtext](docs/Incomingtext.md)
 - [Model.Keyword](docs/Keyword.md)
 - [Model.Polling](docs/Polling.md)
 - [Model.PushToListenAgain](docs/PushToListenAgain.md)
 - [Model.PushToOptOut](docs/PushToOptOut.md)
 - [Model.PushToRecord](docs/PushToRecord.md)
 - [Model.PushToTalk](docs/PushToTalk.md)
 - [Model.Recording](docs/Recording.md)
 - [Model.Service](docs/Service.md)
 - [Model.Shortcode](docs/Shortcode.md)
 - [Model.TextRecipient](docs/TextRecipient.md)
 - [Model.UpdateAccessAccountByIdParameters](docs/UpdateAccessAccountByIdParameters.md)
 - [Model.UpdateCallerIdByIdParameters](docs/UpdateCallerIdByIdParameters.md)
 - [Model.UpdateContactByIdParameters](docs/UpdateContactByIdParameters.md)
 - [Model.UpdateGroupByIdParameters](docs/UpdateGroupByIdParameters.md)
 - [Model.UpdateRecordingByIdParameters](docs/UpdateRecordingByIdParameters.md)
 - [Model.UpdateVanityNumberByIdParameters](docs/UpdateVanityNumberByIdParameters.md)
 - [Model.Vanitynumber](docs/Vanitynumber.md)
 - [Model.VerifyCallerIdByIdParameters](docs/VerifyCallerIdByIdParameters.md)


## Documentation for Authorization

### api_key

- **Type**: API key
- **API key parameter name**: X-Auth-ApiKey
- **Location**: HTTP header

