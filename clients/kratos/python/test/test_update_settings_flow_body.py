"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more.   # noqa: E501

    The version of the OpenAPI document: v1.1.0
    Contact: office@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_kratos_client
from ory_kratos_client.model.update_settings_flow_with_lookup_method import UpdateSettingsFlowWithLookupMethod
from ory_kratos_client.model.update_settings_flow_with_oidc_method import UpdateSettingsFlowWithOidcMethod
from ory_kratos_client.model.update_settings_flow_with_password_method import UpdateSettingsFlowWithPasswordMethod
from ory_kratos_client.model.update_settings_flow_with_profile_method import UpdateSettingsFlowWithProfileMethod
from ory_kratos_client.model.update_settings_flow_with_totp_method import UpdateSettingsFlowWithTotpMethod
from ory_kratos_client.model.update_settings_flow_with_web_authn_method import UpdateSettingsFlowWithWebAuthnMethod
globals()['UpdateSettingsFlowWithLookupMethod'] = UpdateSettingsFlowWithLookupMethod
globals()['UpdateSettingsFlowWithOidcMethod'] = UpdateSettingsFlowWithOidcMethod
globals()['UpdateSettingsFlowWithPasswordMethod'] = UpdateSettingsFlowWithPasswordMethod
globals()['UpdateSettingsFlowWithProfileMethod'] = UpdateSettingsFlowWithProfileMethod
globals()['UpdateSettingsFlowWithTotpMethod'] = UpdateSettingsFlowWithTotpMethod
globals()['UpdateSettingsFlowWithWebAuthnMethod'] = UpdateSettingsFlowWithWebAuthnMethod
from ory_kratos_client.model.update_settings_flow_body import UpdateSettingsFlowBody


class TestUpdateSettingsFlowBody(unittest.TestCase):
    """UpdateSettingsFlowBody unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testUpdateSettingsFlowBody(self):
        """Test UpdateSettingsFlowBody"""
        # FIXME: construct object with mandatory attributes with example values
        # model = UpdateSettingsFlowBody()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
