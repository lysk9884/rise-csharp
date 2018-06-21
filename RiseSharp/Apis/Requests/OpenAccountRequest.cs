using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;
using System.Runtime.Serialization;

namespace RiseSharp.Apis.Requests
{
    [DataContract]
    public class OpenAccountRequest : BaseApiRequest
    {
        [DataMember(Name = "secret")]
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }
    }
}