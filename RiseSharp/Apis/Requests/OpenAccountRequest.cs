using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    [DataContract]
    public class OpenAccountRequest : BaseApiRequest
    {
        public OpenAccountRequest(string Secret)
        {
            this.Secret = Secret;
        }

        [DataMember(Name="secret")]
        [QueryParam(Name="secret")]
        public string Secret { get; set; }
    }
}
