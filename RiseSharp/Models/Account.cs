using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiseSharp.Models
{
	[DataContract]
	public class Account
	{
        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "isDelegate")]
        public bool IsDelegate { get; set; }

        [DataMember(Name = "secondSignature")]
        public bool SecondSignature { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "publicKey")]
        public string PublicKey { get; set; }

        [DataMember(Name = "secondPublicKey")]
        public string SecondPublicKey { get; set; }

        [DataMember(Name = "balance")]
        public int Balance { get; set; }

        [DataMember(Name = "vote")]
        public int Vote { get; set; }

        [DataMember(Name = "rate")]
        public int Rate { get; set; }

    }
}
