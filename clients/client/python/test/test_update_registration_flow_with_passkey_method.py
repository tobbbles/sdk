# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.12.0
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_client.models.update_registration_flow_with_passkey_method import UpdateRegistrationFlowWithPasskeyMethod

class TestUpdateRegistrationFlowWithPasskeyMethod(unittest.TestCase):
    """UpdateRegistrationFlowWithPasskeyMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateRegistrationFlowWithPasskeyMethod:
        """Test UpdateRegistrationFlowWithPasskeyMethod
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateRegistrationFlowWithPasskeyMethod`
        """
        model = UpdateRegistrationFlowWithPasskeyMethod()
        if include_optional:
            return UpdateRegistrationFlowWithPasskeyMethod(
                csrf_token = '',
                method = '',
                passkey_register = '',
                traits = ory_client.models.traits.traits(),
                transient_payload = ory_client.models.transient_payload.transient_payload()
            )
        else:
            return UpdateRegistrationFlowWithPasskeyMethod(
                method = '',
                traits = ory_client.models.traits.traits(),
        )
        """

    def testUpdateRegistrationFlowWithPasskeyMethod(self):
        """Test UpdateRegistrationFlowWithPasskeyMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
