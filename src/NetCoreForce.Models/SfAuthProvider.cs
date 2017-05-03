// SF API version v39.0
// Custom fields included: False
// Relationship objects included: True

using System;
using NetCoreForce.Client.Models;
using NetCoreForce.Client.Attributes;
using Newtonsoft.Json;

namespace NetCoreForce.Models
{
	///<summary>
	/// Auth. Provider
	///<para>SObject Name: AuthProvider</para>
	///<para>Custom Object: False</para>
	///</summary>
	public class SfAuthProvider : SObject
	{
		[JsonIgnore]
		public static string SObjectTypeName
		{
			get { return "AuthProvider"; }
		}

		///<summary>
		/// Auth. Provider ID
		/// <para>Name: Id</para>
		/// <para>SF Type: id</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "id")]
		[Updateable(false), Createable(false)]
		public string Id { get; set; }

		///<summary>
		/// Created Date
		/// <para>Name: CreatedDate</para>
		/// <para>SF Type: datetime</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "createdDate")]
		[Updateable(false), Createable(false)]
		public DateTimeOffset? CreatedDate { get; set; }

		///<summary>
		/// Provider Type
		/// <para>Name: ProviderType</para>
		/// <para>SF Type: picklist</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "providerType")]
		public string ProviderType { get; set; }

		///<summary>
		/// Name
		/// <para>Name: FriendlyName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "friendlyName")]
		public string FriendlyName { get; set; }

		///<summary>
		/// URL Suffix
		/// <para>Name: DeveloperName</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "developerName")]
		public string DeveloperName { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: RegistrationHandlerId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "registrationHandlerId")]
		public string RegistrationHandlerId { get; set; }

		///<summary>
		/// User ID
		/// <para>Name: ExecutionUserId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "executionUserId")]
		public string ExecutionUserId { get; set; }

		///<summary>
		/// Consumer Key
		/// <para>Name: ConsumerKey</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "consumerKey")]
		public string ConsumerKey { get; set; }

		///<summary>
		/// Consumer Secret
		/// <para>Name: ConsumerSecret</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "consumerSecret")]
		[Updateable(false), Createable(true)]
		public string ConsumerSecret { get; set; }

		///<summary>
		/// Custom Error URL
		/// <para>Name: ErrorUrl</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "errorUrl")]
		public string ErrorUrl { get; set; }

		///<summary>
		/// Authorize Endpoint URL
		/// <para>Name: AuthorizeUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "authorizeUrl")]
		public string AuthorizeUrl { get; set; }

		///<summary>
		/// Token Endpoint URL
		/// <para>Name: TokenUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "tokenUrl")]
		public string TokenUrl { get; set; }

		///<summary>
		/// User Info Endpoint URL
		/// <para>Name: UserInfoUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "userInfoUrl")]
		public string UserInfoUrl { get; set; }

		///<summary>
		/// Default Scopes
		/// <para>Name: DefaultScopes</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "defaultScopes")]
		public string DefaultScopes { get; set; }

		///<summary>
		/// Token Issuer
		/// <para>Name: IdTokenIssuer</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "idTokenIssuer")]
		public string IdTokenIssuer { get; set; }

		///<summary>
		/// Send access token in header
		/// <para>Name: OptionsSendAccessTokenInHeader</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsSendAccessTokenInHeader")]
		public bool? OptionsSendAccessTokenInHeader { get; set; }

		///<summary>
		/// Send client credentials in header
		/// <para>Name: OptionsSendClientCredentialsInHeader</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsSendClientCredentialsInHeader")]
		public bool? OptionsSendClientCredentialsInHeader { get; set; }

		///<summary>
		/// Include identity organization's organization ID for third-party account linkage
		/// <para>Name: OptionsIncludeOrgIdInId</para>
		/// <para>SF Type: boolean</para>
		/// <para>Nillable: False</para>
		///</summary>
		[JsonProperty(PropertyName = "optionsIncludeOrgIdInId")]
		public bool? OptionsIncludeOrgIdInId { get; set; }

		///<summary>
		/// Icon URL
		/// <para>Name: IconUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "iconUrl")]
		public string IconUrl { get; set; }

		///<summary>
		/// Custom Logout URL
		/// <para>Name: LogoutUrl</para>
		/// <para>SF Type: url</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "logoutUrl")]
		public string LogoutUrl { get; set; }

		///<summary>
		/// Class ID
		/// <para>Name: PluginId</para>
		/// <para>SF Type: reference</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "pluginId")]
		public string PluginId { get; set; }

		///<summary>
		/// Custom Metadata Type Record
		/// <para>Name: CustomMetadataTypeRecord</para>
		/// <para>SF Type: string</para>
		/// <para>Nillable: True</para>
		///</summary>
		[JsonProperty(PropertyName = "customMetadataTypeRecord")]
		public string CustomMetadataTypeRecord { get; set; }

	}
}