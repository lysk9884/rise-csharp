using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class DelegatesResponse : BaseApiResponse
    {
		[DataMember(Name = "delegates")]
		public IList<Models.Delegate> Delegates { get; set; }
    }
}
