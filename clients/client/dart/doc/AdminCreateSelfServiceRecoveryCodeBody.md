# ory_client.model.AdminCreateSelfServiceRecoveryCodeBody

## Load the model package
```dart
import 'package:ory_client/api.dart';
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**expiresIn** | **String** | Code Expires In  The recovery code will expire at that point in time. Defaults to the configuration value of `selfservice.flows.recovery.request_lifespan`. | [optional] 
**identityId** | **String** | Identity to Recover  The identity's ID you wish to recover. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

