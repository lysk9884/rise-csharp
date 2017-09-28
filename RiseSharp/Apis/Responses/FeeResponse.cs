using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class FeeResponse : BaseApiResponse
	{
		[DataMember(Name = "fee")]
        public decimal Fee { get; set; }
	}
}
