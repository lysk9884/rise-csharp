using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class AddSignaturesRequest : BaseApiRequest
    {
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }

		[QueryParam(Name = "secondSecret")]
		public string SecondSecret { get; set; }

		[QueryParam(Name = "publicKey")]
		public string PublicKey { get; set; }
    }
}
