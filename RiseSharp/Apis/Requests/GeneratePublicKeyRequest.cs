using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class GeneratePublicKeyRequest : BaseApiRequest
    {
		[QueryParam(Name = "secret")]
		public string Secret { get; set; }
    }
}
