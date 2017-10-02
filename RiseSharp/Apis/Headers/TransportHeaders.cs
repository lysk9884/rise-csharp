using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Headers
{
    public class TransportHeaders : BaseApiRequest
    {
        [HeaderValue(Name = "nethash")]
        public string NetHash { get; set; }

		[HeaderValue(Name = "port")]
		public int Port { get; set; }

		[HeaderValue(Name = "version")]
		public string Version { get; set; }

		[HeaderValue(Name = "broadhash")]
		public string BroadHash { get; set; }

		[HeaderValue(Name = "Height")]
        public decimal Height { get; set; }

		[HeaderValue(Name = "nonce")]
        public decimal Nonce { get; set; }

		[HeaderValue(Name = "os")]
		public string OS { get; set; }
    }
}
