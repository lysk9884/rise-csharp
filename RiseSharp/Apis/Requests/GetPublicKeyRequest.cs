using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class GetPublicKeyRequest : BaseApiRequest
    {
		[QueryParam(Name = "address")]
		public string Address { get; set; }
    }
}
