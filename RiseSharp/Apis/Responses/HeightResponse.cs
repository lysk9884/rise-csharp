using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class HeightResponse : BaseApiResponse
    {
		[DataMember(Name = "height")]
        public decimal Height { get; set; }
    }
}
