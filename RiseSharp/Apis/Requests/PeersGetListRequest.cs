using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;
using RiseSharp.Models.Enums;

namespace RiseSharp.Apis.Requests
{
    public class PeersGetListRequest : BaseApiRequest
    {
        [QueryParam(Name = "state")]
        public PeerState? PeerState { get; set; }

        [QueryParam(Name = "os")]
        public string Os { get; set; }

		[QueryParam(Name = "version")]
		public string Version { get; set; }
    }
}
