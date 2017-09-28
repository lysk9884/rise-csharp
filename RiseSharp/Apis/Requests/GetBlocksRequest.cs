using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
	public class GetBlocksRequest : BaseApiRequest
	{
		[QueryParam(Name = "generatorPublicKey")]
		public string GeneratorPublickey { get; set; }

		[QueryParam(Name = "totalAmount")]
		public long? TotalAmount { get; set; }

		[QueryParam(Name = "totalFee")]
		public int? TotalFee { get; set; }

		[QueryParam(Name = "reward")]
		public int? Reward { get; set; }

		[QueryParam(Name = "previousBlock")]
		public string PreviousBlock { get; set; }

		[QueryParam(Name = "height")]
		public int? Height { get; set; }
	}
}
