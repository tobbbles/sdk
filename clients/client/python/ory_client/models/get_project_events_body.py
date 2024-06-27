# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.12.0
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from datetime import datetime
from pydantic import BaseModel, ConfigDict, Field, StrictInt, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from ory_client.models.attribute_filter import AttributeFilter
from typing import Optional, Set
from typing_extensions import Self

class GetProjectEventsBody(BaseModel):
    """
    Body of the getProjectEvents endpoint
    """ # noqa: E501
    event_name: Optional[StrictStr] = Field(default=None, description="The event name to query for")
    filters: Optional[List[AttributeFilter]] = Field(default=None, description="Event attribute filters")
    var_from: datetime = Field(description="The start RFC3339 date of the time window", alias="from")
    page_size: Optional[StrictInt] = Field(default=25, description="Maximum number of events to return")
    page_token: Optional[StrictStr] = Field(default=None, description="Pagination token to fetch next page, empty if first page")
    to: datetime = Field(description="The end RFC3339 date of the time window")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["event_name", "filters", "from", "page_size", "page_token", "to"]

    model_config = ConfigDict(
        populate_by_name=True,
        validate_assignment=True,
        protected_namespaces=(),
    )


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of GetProjectEventsBody from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # override the default output from pydantic by calling `to_dict()` of each item in filters (list)
        _items = []
        if self.filters:
            for _item in self.filters:
                if _item:
                    _items.append(_item.to_dict())
            _dict['filters'] = _items
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of GetProjectEventsBody from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "event_name": obj.get("event_name"),
            "filters": [AttributeFilter.from_dict(_item) for _item in obj["filters"]] if obj.get("filters") is not None else None,
            "from": obj.get("from"),
            "page_size": obj.get("page_size") if obj.get("page_size") is not None else 25,
            "page_token": obj.get("page_token"),
            "to": obj.get("to")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


