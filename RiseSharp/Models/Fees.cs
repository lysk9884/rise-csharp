using System;
using System.Runtime.Serialization;

namespace RiseSharp.Models
{
    [DataContract]
    public class Fees
    {
		[DataMember(Name = "send")]
        public decimal Send { get; set; }

		[DataMember(Name = "vote")]
		public decimal Vote { get; set; }

		[DataMember(Name = "secondsignature")]
		public decimal SecondSignature { get; set; }

		[DataMember(Name = "delegate")]
		public decimal Delegate { get; set; }

		[DataMember(Name = "multisignature")]
		public decimal MultiSignature { get; set; }

		[DataMember(Name = "dapp")]
		public decimal Dapp { get; set; }
    }
}
