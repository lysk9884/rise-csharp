using System;
using System.Runtime.Serialization;

namespace RiseSharp.Models
{
    [DataContract]
    public class Signature
    {
		[DataMember(Name = "transaction")]
		public string TransactionId { get; set; }

		[DataMember(Name = "signature")]
		public string SignatureId { get; set; }
    }
}
