using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Models
{
    [DataContract]
    public class BlockStatusResponse : BaseApiResponse
    {
        [DataMember(Name = "broadhash")]
        public string BroadHash { get; set; }

		[DataMember(Name = "epoch")]
		public string Epoch { get; set; }

		[DataMember(Name = "height")]
        public decimal Height { get; set; }

		[DataMember(Name = "fee")]
        public decimal Fee { get; set; }

		[DataMember(Name = "milestone")]
        public decimal Milestone { get; set; }

		[DataMember(Name = "nethash")]
		public string NetHash { get; set; }

        [DataMember(Name = "reward")]
        public decimal Reward { get; set; }

		[DataMember(Name = "supply")]
        public int Supply { get; set; }
    }
}
