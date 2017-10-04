using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetAccountsResponse : BaseApiResponse
    {
        [DataMember(Name = "accounts")]
        public IList<Account> Accounts { get; set; }
    }
}
