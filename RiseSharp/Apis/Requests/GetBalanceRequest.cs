using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class GetBalanceRequest : BaseApiRequest
    {
        public GetBalanceRequest(string Address)
        {
            this.Address = Address;
        }

        [QueryParam(Name = "address")]
		public string Address { get; set; }
    }
}
