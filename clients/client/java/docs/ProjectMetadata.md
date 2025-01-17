

# ProjectMetadata


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**createdAt** | **OffsetDateTime** | The Project&#39;s Creation Date |  |
|**hosts** | **List&lt;String&gt;** |  |  |
|**id** | **String** | The project&#39;s ID. |  [readonly] |
|**name** | **String** | The project&#39;s name if set |  |
|**slug** | **String** | The project&#39;s slug |  [optional] [readonly] |
|**state** | [**StateEnum**](#StateEnum) | The state of the project. running Running halted Halted deleted Deleted |  |
|**subscriptionId** | **String** |  |  [optional] |
|**subscriptionPlan** | **String** |  |  [optional] |
|**updatedAt** | **OffsetDateTime** | Last Time Project was Updated |  |
|**workspaceId** | **String** |  |  [optional] |



## Enum: StateEnum

| Name | Value |
|---- | -----|
| RUNNING | &quot;running&quot; |
| HALTED | &quot;halted&quot; |
| DELETED | &quot;deleted&quot; |



