using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class RewardResponse : BaseApiResponse
    {
		[DataMember(Name = "reward")]
        public decimal Reward { get; set; }
    }
}
