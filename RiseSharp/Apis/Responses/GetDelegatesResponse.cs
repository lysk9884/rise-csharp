using RiseSharp.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
	[DataContract]
	public class GetDelegatesResponse : BaseApiResponse
	{
        [DataMember(Name = "delegates", Order = 2)]
        public List<int> Delegates { get; set; }
    }
}
