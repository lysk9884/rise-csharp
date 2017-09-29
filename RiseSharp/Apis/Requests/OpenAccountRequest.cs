using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class OpenAccountRequest : BaseApiRequest
    {
        [QueryParam(Name="secret")]
        public string Secret { get; set; }
    }
}
