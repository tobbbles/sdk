"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v0.0.1-alpha.110
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.project import Project
from ory_client.model.warning import Warning
globals()['Project'] = Project
globals()['Warning'] = Warning
from ory_client.model.successful_project_config_update import SuccessfulProjectConfigUpdate


class TestSuccessfulProjectConfigUpdate(unittest.TestCase):
    """SuccessfulProjectConfigUpdate unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testSuccessfulProjectConfigUpdate(self):
        """Test SuccessfulProjectConfigUpdate"""
        # FIXME: construct object with mandatory attributes with example values
        # model = SuccessfulProjectConfigUpdate()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
