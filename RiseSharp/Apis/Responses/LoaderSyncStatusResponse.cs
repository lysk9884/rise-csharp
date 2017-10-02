using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class LoaderSyncStatusResponse : BaseApiResponse
    {
        [DataMember(Name = "syncing")]
        public bool Syncing { get; set; }

		[DataMember(Name = "blocks")]
        public decimal Blocks { get; set; }

		[DataMember(Name = "height")]
        public decimal Height { get; set; }

		[DataMember(Name = "broadhash")]
        public string Broadhash { get; set; }

		[DataMember(Name = "consensus")]
        public decimal Consensus { get; set; }
    }
}
