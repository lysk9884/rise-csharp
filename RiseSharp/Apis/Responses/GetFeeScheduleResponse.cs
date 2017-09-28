using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class GetFeeScheduleResponse : BaseApiResponse
	{
		[DataMember(Name = "fees")]
		public Fees Fees { get; set; }
	}

}
