using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class CreateMultiSigAccountRequest : BaseApiRequest
    {
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }

        [QueryParam(Name = "lifetime")]
        public decimal LifeTime { get; set; }

		[QueryParam(Name = "min")]
        public decimal Min { get; set; }

		[QueryParam(Name = "keysgroup")]
		public string[] PublicKeys { get; set; }
    }
}
