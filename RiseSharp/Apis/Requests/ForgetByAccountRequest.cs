using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class ForgetByAccountRequest : BaseApiRequest
    {
		[QueryParam(Name = "publicKey")]
		public string Publickey { get; set; }
    }
}
