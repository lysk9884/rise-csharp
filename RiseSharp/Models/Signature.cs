using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Attributes;

namespace RiseSharp.Models
{
    [DataContract]
    public class Signature
    {
		[DataMember(Name = "transaction")]
        [QueryParam(Name = "transaction")]
		public string TransactionId { get; set; }

		[DataMember(Name = "signature")]
        [QueryParam(Name = "signature")]
		public string SignatureId { get; set; }
    }
}
