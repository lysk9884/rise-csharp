using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class TransactionsResponse<T> : BaseApiResponse
	{
		[DataMember(Name = "transactions")]
		public IList<Transaction<T>> Transactions { get; set; }

		[DataMember(Name = "count")]
		public string Count { get; set; }
	}
}
