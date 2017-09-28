using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
	public class UserNameRequest : BaseApiRequest
	{
		[QueryParam(Name = "username")]
		public string UserName { get; set; }
	}
}
