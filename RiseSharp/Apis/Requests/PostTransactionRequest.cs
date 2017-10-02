using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Headers;
using RiseSharp.Models;

namespace RiseSharp.Apis.Requests
{
	public class PostTransactionRequest<T> : TransportHeaders
	{
		[QueryParam(Name = "transaction")]
		public Transaction<T> Transaction { get; set; }
	}
}
