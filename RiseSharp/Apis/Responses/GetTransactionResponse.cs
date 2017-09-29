using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;
using RiseSharp.Models;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetTransactionResponse<T> : BaseApiResponse
    {
        [DataMember(Name = "transaction")]
        public Transaction<T> Transaction { get; set;}
    }
}
