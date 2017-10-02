using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class MultiSigSignRequest : BaseApiRequest
    {
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }

		[QueryParam(Name = "publicKey")]
		public string PublicKey { get; set; }

		[QueryParam(Name = "transactionId")]
		public string TransactionId { get; set; }
    }
}
