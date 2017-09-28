using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class DelegateResponse : BaseApiResponse
    {
		[DataMember(Name = "delegate")]
		public Models.Delegate Delegate { get; set; }
    }
}
