using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetVotersResponse
    {
        [DataMember(Name = "accounts")]
        public IList<Account> Accounts{ get; set; }
    }
}
