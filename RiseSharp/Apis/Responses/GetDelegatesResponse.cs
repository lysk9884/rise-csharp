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
        public List<Delegate> Delegates { get; set; }

        [DataMember(Name = "totalcount", Order = 3)]
        public int TotalCount { get; set; }
    }
}
