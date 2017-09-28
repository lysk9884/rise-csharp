using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class GetBlocksResponse : BaseApiResponse
	{
		[DataMember(Name = "blocks")]
		public IList<Block> Blocks { get; set; }

		[DataMember(Name = "count")]
		public int Count { get; set; }
	}
}
