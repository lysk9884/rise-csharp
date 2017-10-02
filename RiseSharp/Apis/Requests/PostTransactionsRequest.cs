using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Headers;
using RiseSharp.Models;

namespace RiseSharp.Apis.Requests
{
	public class PostTransactionsRequest<T> : TransportHeaders
	{
		[QueryParam(Name = "transactions")]
		public Transaction<T>[] Transaction { get; set; }
	}
}
