
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for IdentityProviders.
.Description
Create an in-memory object for IdentityProviders.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IdentityProviders
#>
function New-AzContainerAppIdentityProviderObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IdentityProviders')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The list of the allowed groups.")]
        [string[]]
        $AllowedPrincipalGroup,
        [Parameter(HelpMessage="The list of the allowed identities.")]
        [string[]]
        $AllowedPrincipalIdentity,
        [Parameter(HelpMessage="<code>false</code> if the Apple provider should not be enabled despite the set registration; otherwise, <code>true</code>.")]
        [bool]
        $AppleEnabled,
        [Parameter(HelpMessage="A list of the scopes that should be requested while authenticating.")]
        [string[]]
        $AppleLoginScope,
        [Parameter(HelpMessage="The Client ID of the app used for login.")]
        [string]
        $AppleRegistrationClientId,
        [Parameter(HelpMessage="The app setting name that contains the client secret.")]
        [string]
        $AppleRegistrationClientSecretSettingName,
        [Parameter(HelpMessage="<code>false</code> if the Azure Active Directory provider should not be enabled despite the set registration; otherwise, <code>true</code>.")]
        [bool]
        $AzureActiveDirectoryEnabled,
        [Parameter(HelpMessage="Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        This is an internal flag primarily intended to support the Azure Management Portal. Users should not
        read or write to this property.")]
        [bool]
        $AzureActiveDirectoryIsAutoProvisioned,
        [Parameter(HelpMessage="The Client ID of this relying party application, known as the client_id.
        This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        other 3rd party OpenID Connect providers.
        More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html.")]
        [string]
        $AzureActiveDirectoryRegistrationClientId,
        [Parameter(HelpMessage="The app setting name that contains the client secret of the relying party application.")]
        [string]
        $AzureActiveDirectoryRegistrationClientSecretSettingName,
        [Parameter(HelpMessage="The list of audiences that can make successful authentication/authorization requests.")]
        [string[]]
        $AzureActiveDirectoryValidationAllowedAudience,
        [Parameter(HelpMessage="<code>false</code> if the Azure Static Web Apps provider should not be enabled despite the set registration; otherwise, <code>true</code>.")]
        [bool]
        $AzureStaticWebAppEnabled,
        [Parameter(HelpMessage="The Client ID of the app used for login.")]
        [string]
        $AzureStaticWebAppsRegistrationClientId,
        [Parameter(HelpMessage="The map of the name of the alias of each custom Open ID Connect provider to the
        configuration settings of the custom Open ID Connect provider.")]
        [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IIdentityProvidersCustomOpenIdConnectProviders]
        $CustomOpenIdConnectProvider,
        [Parameter(HelpMessage="The configuration settings of the Azure Active Directory allowed applications.")]
        [string[]]
        $DefaultAuthorizationPolicyAllowedApplication,
        [Parameter(HelpMessage="<code>false</code> if the Facebook provider should not be enabled despite the set registration; otherwise, <code>true</code>.")]
        [bool]
        $FacebookEnabled,
        [Parameter(HelpMessage="The version of the Facebook api to be used while logging in.")]
        [string]
        $FacebookGraphApiVersion,
        [Parameter(HelpMessage="A list of the scopes that should be requested while authenticating.")]
        [string[]]
        $FacebookLoginScope,
        [Parameter(HelpMessage="<code>false</code> if the GitHub provider should not be enabled despite the set registration; otherwise, <code>true</code>.")]
        [bool]
        $GitHubEnabled,
        [Parameter(HelpMessage="A list of the scopes that should be requested while authenticating.")]
        [string[]]
        $GitHubLoginScope,
        [Parameter(HelpMessage="The Client ID of the app used for login.")]
        [string]
        $GitHubRegistrationClientId,
        [Parameter(HelpMessage="The app setting name that contains the client secret.")]
        [string]
        $GitHubRegistrationClientSecretSettingName,
        [Parameter(HelpMessage="<code>false</code> if the Google provider should not be enabled despite the set registration; otherwise, <code>true</code>.")]
        [bool]
        $GoogleEnabled,
        [Parameter(HelpMessage="A list of the scopes that should be requested while authenticating.")]
        [string[]]
        $GoogleLoginScope,
        [Parameter(HelpMessage="The Client ID of the app used for login.")]
        [string]
        $GoogleRegistrationClientId,
        [Parameter(HelpMessage="The app setting name that contains the client secret.")]
        [string]
        $GoogleRegistrationClientSecretSettingName,
        [Parameter(HelpMessage="The configuration settings of the allowed list of audiences from which to validate the JWT token.")]
        [string[]]
        $GoogleValidationAllowedAudience,
        [Parameter(HelpMessage="The list of the allowed client applications.")]
        [string[]]
        $JwtClaimCheckAllowedClientApplication,
        [Parameter(HelpMessage="The list of the allowed groups.")]
        [string[]]
        $JwtClaimCheckAllowedGroup,
        [Parameter(HelpMessage="<code>true</code> if the www-authenticate provider should be omitted from the request; otherwise, <code>false</code>.")]
        [bool]
        $LoginDisableWwwAuthenticate,
        [Parameter(HelpMessage="Login parameters to send to the OpenID Connect authorization endpoint when
        a user logs in. Each parameter must be in the form `"key=value`".")]
        [string[]]
        $LoginParameter,
        [Parameter(HelpMessage="The App ID of the app used for login.")]
        [string]
        $RegistrationAppId,
        [Parameter(HelpMessage="The app setting name that contains the app secret.")]
        [string]
        $RegistrationAppSecretSettingName,
        [Parameter(HelpMessage="An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret Certificate Thumbprint. It is also optional.")]
        [string]
        $RegistrationClientSecretCertificateIssuer,
        [Parameter(HelpMessage="An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret Certificate Thumbprint. It is also optional.")]
        [string]
        $RegistrationClientSecretCertificateSubjectAlternativeName,
        [Parameter(HelpMessage="An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret. It is also optional.")]
        [string]
        $RegistrationClientSecretCertificateThumbprint,
        [Parameter(HelpMessage="The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        This setting is required for enabling Twitter Sign-In.
        Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in.")]
        [string]
        $RegistrationConsumerKey,
        [Parameter(HelpMessage="The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        application used for sign-in.")]
        [string]
        $RegistrationConsumerSecretSettingName,
        [Parameter(HelpMessage="The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        This URI is a case-sensitive identifier for the token issuer.
        More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html.")]
        [string]
        $RegistrationOpenIdIssuer,
        [Parameter(HelpMessage="<code>false</code> if the Twitter provider should not be enabled despite the set registration; otherwise, <code>true</code>.")]
        [bool]
        $TwitterEnabled
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IdentityProviders]::New()

        if ($PSBoundParameters.ContainsKey('AllowedPrincipalGroup')) {
            $Object.AllowedPrincipalGroup = $AllowedPrincipalGroup
        }
        if ($PSBoundParameters.ContainsKey('AllowedPrincipalIdentity')) {
            $Object.AllowedPrincipalIdentity = $AllowedPrincipalIdentity
        }
        if ($PSBoundParameters.ContainsKey('AppleEnabled')) {
            $Object.AppleEnabled = $AppleEnabled
        }
        if ($PSBoundParameters.ContainsKey('AppleLoginScope')) {
            $Object.AppleLoginScope = $AppleLoginScope
        }
        if ($PSBoundParameters.ContainsKey('AppleRegistrationClientId')) {
            $Object.AppleRegistrationClientId = $AppleRegistrationClientId
        }
        if ($PSBoundParameters.ContainsKey('AppleRegistrationClientSecretSettingName')) {
            $Object.AppleRegistrationClientSecretSettingName = $AppleRegistrationClientSecretSettingName
        }
        if ($PSBoundParameters.ContainsKey('AzureActiveDirectoryEnabled')) {
            $Object.AzureActiveDirectoryEnabled = $AzureActiveDirectoryEnabled
        }
        if ($PSBoundParameters.ContainsKey('AzureActiveDirectoryIsAutoProvisioned')) {
            $Object.AzureActiveDirectoryIsAutoProvisioned = $AzureActiveDirectoryIsAutoProvisioned
        }
        if ($PSBoundParameters.ContainsKey('AzureActiveDirectoryRegistrationClientId')) {
            $Object.AzureActiveDirectoryRegistrationClientId = $AzureActiveDirectoryRegistrationClientId
        }
        if ($PSBoundParameters.ContainsKey('AzureActiveDirectoryRegistrationClientSecretSettingName')) {
            $Object.AzureActiveDirectoryRegistrationClientSecretSettingName = $AzureActiveDirectoryRegistrationClientSecretSettingName
        }
        if ($PSBoundParameters.ContainsKey('AzureActiveDirectoryValidationAllowedAudience')) {
            $Object.AzureActiveDirectoryValidationAllowedAudience = $AzureActiveDirectoryValidationAllowedAudience
        }
        if ($PSBoundParameters.ContainsKey('AzureStaticWebAppEnabled')) {
            $Object.AzureStaticWebAppEnabled = $AzureStaticWebAppEnabled
        }
        if ($PSBoundParameters.ContainsKey('AzureStaticWebAppsRegistrationClientId')) {
            $Object.AzureStaticWebAppsRegistrationClientId = $AzureStaticWebAppsRegistrationClientId
        }
        if ($PSBoundParameters.ContainsKey('CustomOpenIdConnectProvider')) {
            $Object.CustomOpenIdConnectProvider = $CustomOpenIdConnectProvider
        }
        if ($PSBoundParameters.ContainsKey('DefaultAuthorizationPolicyAllowedApplication')) {
            $Object.DefaultAuthorizationPolicyAllowedApplication = $DefaultAuthorizationPolicyAllowedApplication
        }
        if ($PSBoundParameters.ContainsKey('FacebookEnabled')) {
            $Object.FacebookEnabled = $FacebookEnabled
        }
        if ($PSBoundParameters.ContainsKey('FacebookGraphApiVersion')) {
            $Object.FacebookGraphApiVersion = $FacebookGraphApiVersion
        }
        if ($PSBoundParameters.ContainsKey('FacebookLoginScope')) {
            $Object.FacebookLoginScope = $FacebookLoginScope
        }
        if ($PSBoundParameters.ContainsKey('GitHubEnabled')) {
            $Object.GitHubEnabled = $GitHubEnabled
        }
        if ($PSBoundParameters.ContainsKey('GitHubLoginScope')) {
            $Object.GitHubLoginScope = $GitHubLoginScope
        }
        if ($PSBoundParameters.ContainsKey('GitHubRegistrationClientId')) {
            $Object.GitHubRegistrationClientId = $GitHubRegistrationClientId
        }
        if ($PSBoundParameters.ContainsKey('GitHubRegistrationClientSecretSettingName')) {
            $Object.GitHubRegistrationClientSecretSettingName = $GitHubRegistrationClientSecretSettingName
        }
        if ($PSBoundParameters.ContainsKey('GoogleEnabled')) {
            $Object.GoogleEnabled = $GoogleEnabled
        }
        if ($PSBoundParameters.ContainsKey('GoogleLoginScope')) {
            $Object.GoogleLoginScope = $GoogleLoginScope
        }
        if ($PSBoundParameters.ContainsKey('GoogleRegistrationClientId')) {
            $Object.GoogleRegistrationClientId = $GoogleRegistrationClientId
        }
        if ($PSBoundParameters.ContainsKey('GoogleRegistrationClientSecretSettingName')) {
            $Object.GoogleRegistrationClientSecretSettingName = $GoogleRegistrationClientSecretSettingName
        }
        if ($PSBoundParameters.ContainsKey('GoogleValidationAllowedAudience')) {
            $Object.GoogleValidationAllowedAudience = $GoogleValidationAllowedAudience
        }
        if ($PSBoundParameters.ContainsKey('JwtClaimCheckAllowedClientApplication')) {
            $Object.JwtClaimCheckAllowedClientApplication = $JwtClaimCheckAllowedClientApplication
        }
        if ($PSBoundParameters.ContainsKey('JwtClaimCheckAllowedGroup')) {
            $Object.JwtClaimCheckAllowedGroup = $JwtClaimCheckAllowedGroup
        }
        if ($PSBoundParameters.ContainsKey('LoginDisableWwwAuthenticate')) {
            $Object.LoginDisableWwwAuthenticate = $LoginDisableWwwAuthenticate
        }
        if ($PSBoundParameters.ContainsKey('LoginParameter')) {
            $Object.LoginParameter = $LoginParameter
        }
        if ($PSBoundParameters.ContainsKey('RegistrationAppId')) {
            $Object.RegistrationAppId = $RegistrationAppId
        }
        if ($PSBoundParameters.ContainsKey('RegistrationAppSecretSettingName')) {
            $Object.RegistrationAppSecretSettingName = $RegistrationAppSecretSettingName
        }
        if ($PSBoundParameters.ContainsKey('RegistrationClientSecretCertificateIssuer')) {
            $Object.RegistrationClientSecretCertificateIssuer = $RegistrationClientSecretCertificateIssuer
        }
        if ($PSBoundParameters.ContainsKey('RegistrationClientSecretCertificateSubjectAlternativeName')) {
            $Object.RegistrationClientSecretCertificateSubjectAlternativeName = $RegistrationClientSecretCertificateSubjectAlternativeName
        }
        if ($PSBoundParameters.ContainsKey('RegistrationClientSecretCertificateThumbprint')) {
            $Object.RegistrationClientSecretCertificateThumbprint = $RegistrationClientSecretCertificateThumbprint
        }
        if ($PSBoundParameters.ContainsKey('RegistrationConsumerKey')) {
            $Object.RegistrationConsumerKey = $RegistrationConsumerKey
        }
        if ($PSBoundParameters.ContainsKey('RegistrationConsumerSecretSettingName')) {
            $Object.RegistrationConsumerSecretSettingName = $RegistrationConsumerSecretSettingName
        }
        if ($PSBoundParameters.ContainsKey('RegistrationOpenIdIssuer')) {
            $Object.RegistrationOpenIdIssuer = $RegistrationOpenIdIssuer
        }
        if ($PSBoundParameters.ContainsKey('TwitterEnabled')) {
            $Object.TwitterEnabled = $TwitterEnabled
        }
        return $Object
    }
}

