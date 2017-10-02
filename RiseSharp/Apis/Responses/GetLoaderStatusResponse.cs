using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetLoaderStatusResponse : BaseApiResponse
    {
        [DataMember(Name = "loaded")]
        public bool Loaded { get; set; }

		[DataMember(Name = "now")]
        public decimal Now { get; set; }

		[DataMember(Name = "blocksCount")]
        public long BlocksCount { get; set; }
    }
}
