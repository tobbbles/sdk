# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.15.0
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_client.models.update_registration_flow_with_profile_method import UpdateRegistrationFlowWithProfileMethod

class TestUpdateRegistrationFlowWithProfileMethod(unittest.TestCase):
    """UpdateRegistrationFlowWithProfileMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateRegistrationFlowWithProfileMethod:
        """Test UpdateRegistrationFlowWithProfileMethod
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateRegistrationFlowWithProfileMethod`
        """
        model = UpdateRegistrationFlowWithProfileMethod()
        if include_optional:
            return UpdateRegistrationFlowWithProfileMethod(
                csrf_token = '',
                method = '',
                screen = '',
                traits = ory_client.models.traits.traits(),
                transient_payload = ory_client.models.transient_payload.transient_payload()
            )
        else:
            return UpdateRegistrationFlowWithProfileMethod(
                method = '',
                traits = ory_client.models.traits.traits(),
        )
        """

    def testUpdateRegistrationFlowWithProfileMethod(self):
        """Test UpdateRegistrationFlowWithProfileMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
