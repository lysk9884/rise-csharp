﻿using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class GetAccountByPublicKeyRequest : BaseApiRequest
    {
		[QueryParam(Name = "publicKey")]
		public string PublicKey { get; set; }
    }
}
