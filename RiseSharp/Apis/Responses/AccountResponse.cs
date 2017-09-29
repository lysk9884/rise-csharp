using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class AccountResponse : BaseApiResponse
    {
		[DataMember(Name = "account")]
		public Account Account { get; set; }

    }
}
