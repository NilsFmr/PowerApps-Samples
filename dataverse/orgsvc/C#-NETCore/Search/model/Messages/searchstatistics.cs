#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerPlatform.Dataverse.CodeSamples
{
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("searchstatistics")]
	public partial class searchstatisticsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public searchstatisticsRequest()
		{
			this.RequestName = "searchstatistics";
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("searchstatistics")]
	public partial class searchstatisticsResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public searchstatisticsResponse()
		{
		}
		
		public string response
		{
			get
			{
				if (this.Results.Contains("response"))
				{
					return ((string)(this.Results["response"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}
#pragma warning restore CS1591
