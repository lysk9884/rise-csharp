using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class MultiSigSignRequest : BaseApiRequest
    {
        [DataMember(Name = "secret")]
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }

        [DataMember(Name = "publicKey")]
        [QueryParam(Name = "publicKey")]
		public string PublicKey { get; set; }

        [DataMember(Name = "transactionId")]
        [QueryParam(Name = "transactionId")]
		public string TransactionId { get; set; }
    }
}
