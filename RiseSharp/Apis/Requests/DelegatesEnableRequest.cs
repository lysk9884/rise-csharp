using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class DelegatesEnableRequest : BaseApiRequest
    {
		[QueryParam(Name = "secret")]
		public string Secret { get; set; }

		[QueryParam(Name = "secondSecret")]
		public string SecondSecret { get; set; }

		[QueryParam(Name = "username")]
		public string UserName { get; set; }
    }
}
