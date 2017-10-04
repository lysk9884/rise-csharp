using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class MultiSignaturesSignResponse : BaseApiResponse
    {
        [DataMember(Name = "transactionId")]
        public string TransactionId { get; set; }
    }
}
