using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class GetTransactionRequest : BaseApiRequest
    {
        [QueryParam(Name="id")]
        public string Id { get; set; }
    }
}
