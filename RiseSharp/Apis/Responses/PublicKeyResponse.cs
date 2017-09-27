using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class PublicKeyResponse : BaseApiResponse
    {
		[DataMember(Name = "publicKey")]
		public string PublicKey { get; set; }
    }
}
