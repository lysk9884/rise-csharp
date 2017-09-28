using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiseSharp.Models
{
	[DataContract]
	public class Account
	{
		[DataMember(Name = "address")]
		public string Address { get; set; }

		[DataMember(Name = "unconfirmedBalance")]
		public string UnconfirmedBalance { get; set; }

		[DataMember(Name = "balance")]
		public string Balance { get; set; }

		[DataMember(Name = "publicKey")]
		public string PublicKey { get; set; }

		[DataMember(Name = "unconfirmedSignature")]
		public int UnconfirmedSignature { get; set; }

		[DataMember(Name = "secondSignature")]
		public int SecondSignature { get; set; }

		[DataMember(Name = "secondPublicKey")]
		public object SecondPublicKey { get; set; }

		[DataMember(Name = "multisignatures")]
		public IList<object> Multisignatures { get; set; }

		[DataMember(Name = "u_multisignatures")]
		public IList<object> UMultisignatures { get; set; }

		[DataMember(Name = "username")]
		public string UserName { get; set; }
	}
}
