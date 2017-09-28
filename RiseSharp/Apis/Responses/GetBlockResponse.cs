using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class GetBlockResponse : BaseApiResponse
	{
		[DataMember(Name = "block")]
		public Block Block { get; set; }
	}
}
