# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.13.10
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from datetime import datetime
from pydantic import BaseModel, ConfigDict, Field, StrictStr, field_validator
from typing import Any, ClassVar, Dict, List, Optional
from typing_extensions import Annotated
from typing import Optional, Set
from typing_extensions import Self

class NormalizedProjectRevisionTokenizerTemplate(BaseModel):
    """
    NormalizedProjectRevisionTokenizerTemplate
    """ # noqa: E501
    claims_mapper_url: Optional[StrictStr] = Field(default=None, description="Claims mapper URL")
    created_at: Optional[datetime] = Field(default=None, description="The Project's Revision Creation Date")
    id: Optional[StrictStr] = Field(default=None, description="The revision ID.")
    jwks_url: Optional[StrictStr] = Field(default=None, description="JSON Web Key URL")
    key: Optional[StrictStr] = Field(default=None, description="The unique key of the template")
    project_revision_id: Optional[StrictStr] = Field(default=None, description="The Revision's ID this schema belongs to")
    ttl: Optional[Annotated[str, Field(strict=True)]] = Field(default='1m', description="Token time to live")
    updated_at: Optional[datetime] = Field(default=None, description="Last Time Project's Revision was Updated")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["claims_mapper_url", "created_at", "id", "jwks_url", "key", "project_revision_id", "ttl", "updated_at"]

    @field_validator('ttl')
    def ttl_validate_regular_expression(cls, value):
        """Validates the regular expression"""
        if value is None:
            return value

        if not re.match(r"^[0-9]+(ns|us|ms|s|m|h)$", value):
            raise ValueError(r"must validate the regular expression /^[0-9]+(ns|us|ms|s|m|h)$/")
        return value

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
        """Create an instance of NormalizedProjectRevisionTokenizerTemplate from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "created_at",
            "id",
            "updated_at",
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of NormalizedProjectRevisionTokenizerTemplate from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "claims_mapper_url": obj.get("claims_mapper_url"),
            "created_at": obj.get("created_at"),
            "id": obj.get("id"),
            "jwks_url": obj.get("jwks_url"),
            "key": obj.get("key"),
            "project_revision_id": obj.get("project_revision_id"),
            "ttl": obj.get("ttl") if obj.get("ttl") is not None else '1m',
            "updated_at": obj.get("updated_at")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


