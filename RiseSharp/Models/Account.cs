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
        public string Balance { get; set; }

        [DataMember(Name = "vote")]
        public int Vote { get; set; }

        [DataMember(Name = "rate")]
        public int Rate { get; set; }

        [DataMember(Name = "delegates")]
        public string[] Delegates;

        [DataMember(Name = "multisignatures")]
        public string[] MultiSignatures;

        [DataMember(Name = "multimin")]
        public int MultiMin;

        [DataMember(Name = "multilifetime")]
        public int MultiLifetime;

        [DataMember(Name = "blockId")]
        public string BlockID;

        [DataMember(Name = "nameexist")]
        public bool NameExist;

        [DataMember(Name = "producedblocks")]
        public int ProducedBlocks;

        [DataMember(Name = "missedblocks")]
        public int MissedBlocks;

        [DataMember(Name = "fees")]
        public int Fees;

        [DataMember(Name = "rewards")]
        public int Rewards;

        [DataMember(Name = "virgin")]
        public bool Virgin;

        //unconfiremd stuff
        [DataMember(Name = "unconfirmedBalance")]
        public string UnconfirmedBalance { get; set; }

        [DataMember(Name = "unconfirmedSignature")]
        public bool UnconfirmedSingature { get; set; }

        [DataMember(Name = "u_multisignatures")]
        public string[] UnconfirmedMultiSignatures;
    }
}
