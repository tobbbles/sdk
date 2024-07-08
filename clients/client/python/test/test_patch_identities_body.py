# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.13.10
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_client.models.patch_identities_body import PatchIdentitiesBody

class TestPatchIdentitiesBody(unittest.TestCase):
    """PatchIdentitiesBody unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> PatchIdentitiesBody:
        """Test PatchIdentitiesBody
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `PatchIdentitiesBody`
        """
        model = PatchIdentitiesBody()
        if include_optional:
            return PatchIdentitiesBody(
                identities = [
                    ory_client.models.identity_patch.identityPatch(
                        create = ory_client.models.create_identity_body.createIdentityBody(
                            credentials = ory_client.models.identity_with_credentials.identityWithCredentials(
                                oidc = ory_client.models.identity_with_credentials_oidc.identityWithCredentialsOidc(
                                    config = ory_client.models.identity_with_credentials_oidc_config.identityWithCredentialsOidcConfig(
                                        providers = [
                                            ory_client.models.identity_with_credentials_oidc_config_provider.identityWithCredentialsOidcConfigProvider(
                                                provider = '', 
                                                subject = '', )
                                            ], ), ), 
                                password = ory_client.models.identity_with_credentials_password.identityWithCredentialsPassword(), ), 
                            metadata_admin = null, 
                            metadata_public = null, 
                            recovery_addresses = [
                                ory_client.models.recovery_identity_address.recoveryIdentityAddress(
                                    created_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                    id = '', 
                                    updated_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                    value = '', 
                                    via = '', )
                                ], 
                            schema_id = '', 
                            state = 'active', 
                            traits = ory_client.models.traits.traits(), 
                            verifiable_addresses = [
                                ory_client.models.verifiable_identity_address.verifiableIdentityAddress(
                                    created_at = '2014-01-01T23:28:56.782Z', 
                                    id = '', 
                                    status = '', 
                                    updated_at = '2014-01-01T23:28:56.782Z', 
                                    value = '', 
                                    verified = True, 
                                    verified_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                    via = 'email', )
                                ], ), 
                        patch_id = '', )
                    ]
            )
        else:
            return PatchIdentitiesBody(
        )
        """

    def testPatchIdentitiesBody(self):
        """Test PatchIdentitiesBody"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
