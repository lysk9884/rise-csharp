using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class ForgetByAccountResponse : BaseApiResponse
	{
		[DataMember(Name = "fees")]
		public string Fees { get; set; }

		[DataMember(Name = "rewards")]
		public string Rewards { get; set; }

		[DataMember(Name = "forged")]
		public string Forged { get; set; }
	}
}
