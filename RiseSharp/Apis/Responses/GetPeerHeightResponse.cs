using System;
using System.Runtime.Serialization;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetPeerHeightResponse
    {
        [DataMember]
        public long Height { get; set; }
    }
}
