using System;
using System.Collections.Generic;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Headers;
using RiseSharp.Models;

namespace RiseSharp.Apis.Requests
{
	public class PostSignaturesRequest : TransportHeaders
	{
		[QueryParam(Name = "signature")]
		public IList<Signature> Signatures { get; set; }
	}
}
