using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class NethashResponse : BaseApiResponse
	{
		[DataMember(Name = "nethash")]
		public string Nethash { get; set; }
	}
}
