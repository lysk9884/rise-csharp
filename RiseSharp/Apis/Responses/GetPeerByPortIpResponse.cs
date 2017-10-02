using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetPeerByPortIpResponse : BaseApiResponse
    {
		[DataMember(Name = "peer")]
		public Peer Peer { get; set; }
    }
}
