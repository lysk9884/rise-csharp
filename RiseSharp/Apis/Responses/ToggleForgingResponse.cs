using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class ToggleForgingResponse : BaseApiResponse
    {
		[DataMember(Name = "address")]
        public string Address { get; set; }
    }
}
