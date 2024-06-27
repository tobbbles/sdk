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

from ory_client.models.error_o_auth2 import ErrorOAuth2

class TestErrorOAuth2(unittest.TestCase):
    """ErrorOAuth2 unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> ErrorOAuth2:
        """Test ErrorOAuth2
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `ErrorOAuth2`
        """
        model = ErrorOAuth2()
        if include_optional:
            return ErrorOAuth2(
                error = '',
                error_debug = '',
                error_description = '',
                error_hint = 'The redirect URL is not allowed.',
                status_code = 401
            )
        else:
            return ErrorOAuth2(
        )
        """

    def testErrorOAuth2(self):
        """Test ErrorOAuth2"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
