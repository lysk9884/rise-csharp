using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class GetPeerByPortIpRequest : BaseApiRequest
    {
        [QueryParam(Name = "ip")]
        public string Ip { get; set; }

		[QueryParam(Name = "port")]
        public int Port { get; set; }
    }
}
