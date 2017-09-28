using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
	public class GetForgingStatusResponse : BaseApiResponse
	{
		[QueryParam(Name = "enabled")]
        public bool Enabled { get; set; }
	}
}
