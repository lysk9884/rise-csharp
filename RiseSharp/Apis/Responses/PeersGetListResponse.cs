using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class PeersGetListResponse : BaseApiResponse
    {
        [DataMember(Name = "peers")]
        public IList<Peer> Peers { get; set; }
    }
}
