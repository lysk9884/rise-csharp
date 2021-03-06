﻿using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class GetVotersRequest : BaseApiRequest
    {
		[QueryParam(Name = "publicKey")]
		public string PublicKey { get; set; }
    }
}
