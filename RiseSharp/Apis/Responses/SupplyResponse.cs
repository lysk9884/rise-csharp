using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class SupplyResponse : BaseApiResponse
	{
		[DataMember(Name = "supply")]
		public long Supply { get; set; }
	}
}
