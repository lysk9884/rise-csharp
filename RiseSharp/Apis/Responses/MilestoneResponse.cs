using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class MilestoneResponse : BaseApiResponse
	{
		[DataMember(Name = "milestone")]
        public decimal Milestone { get; set; }
	}
}
