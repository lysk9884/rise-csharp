using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class BalanceResponse : BaseApiResponse
    {
		[DataMember(Name = "balance")]
		public string Balance { get; set; }

        [DataMember(Name = "unconfirmedBalance")]
        public string UnconfirmedBalance { get; set; }
    }
}
