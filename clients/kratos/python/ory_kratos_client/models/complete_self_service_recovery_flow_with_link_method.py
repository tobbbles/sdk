# coding: utf-8

"""
    Ory Kratos

    Welcome to the ORY Kratos HTTP API documentation!  # noqa: E501

    The version of the OpenAPI document: v0.5.1-alpha.1
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from ory_kratos_client.configuration import Configuration


class CompleteSelfServiceRecoveryFlowWithLinkMethod(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'csrf_token': 'str',
        'email': 'str'
    }

    attribute_map = {
        'csrf_token': 'csrf_token',
        'email': 'email'
    }

    def __init__(self, csrf_token=None, email=None, local_vars_configuration=None):  # noqa: E501
        """CompleteSelfServiceRecoveryFlowWithLinkMethod - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._csrf_token = None
        self._email = None
        self.discriminator = None

        if csrf_token is not None:
            self.csrf_token = csrf_token
        if email is not None:
            self.email = email

    @property
    def csrf_token(self):
        """Gets the csrf_token of this CompleteSelfServiceRecoveryFlowWithLinkMethod.  # noqa: E501

        Sending the anti-csrf token is only required for browser login flows.  # noqa: E501

        :return: The csrf_token of this CompleteSelfServiceRecoveryFlowWithLinkMethod.  # noqa: E501
        :rtype: str
        """
        return self._csrf_token

    @csrf_token.setter
    def csrf_token(self, csrf_token):
        """Sets the csrf_token of this CompleteSelfServiceRecoveryFlowWithLinkMethod.

        Sending the anti-csrf token is only required for browser login flows.  # noqa: E501

        :param csrf_token: The csrf_token of this CompleteSelfServiceRecoveryFlowWithLinkMethod.  # noqa: E501
        :type: str
        """

        self._csrf_token = csrf_token

    @property
    def email(self):
        """Gets the email of this CompleteSelfServiceRecoveryFlowWithLinkMethod.  # noqa: E501

        Email to Recover  Needs to be set when initiating the flow. If the email is a registered recovery email, a recovery link will be sent. If the email is not known, a email with details on what happened will be sent instead.  format: email in: body  # noqa: E501

        :return: The email of this CompleteSelfServiceRecoveryFlowWithLinkMethod.  # noqa: E501
        :rtype: str
        """
        return self._email

    @email.setter
    def email(self, email):
        """Sets the email of this CompleteSelfServiceRecoveryFlowWithLinkMethod.

        Email to Recover  Needs to be set when initiating the flow. If the email is a registered recovery email, a recovery link will be sent. If the email is not known, a email with details on what happened will be sent instead.  format: email in: body  # noqa: E501

        :param email: The email of this CompleteSelfServiceRecoveryFlowWithLinkMethod.  # noqa: E501
        :type: str
        """

        self._email = email

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, CompleteSelfServiceRecoveryFlowWithLinkMethod):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, CompleteSelfServiceRecoveryFlowWithLinkMethod):
            return True

        return self.to_dict() != other.to_dict()
