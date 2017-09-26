using System;
using System.Numerics;
using System.Runtime.Serialization;

namespace RiseSharp.Models.Base
{
    [DataContract]
    public class BaseBlock
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "height")]
        public decimal Height { get; set; }

        [DataMember(Name = "blockSignature")]
        public string BlockSignature { get; set; }

        [DataMember(Name = "generatorPublickKey")]
        public string GeneratorPublicKey { get; set; }

        [DataMember(Name = "numberOfTransactions")]
        public int NumberOfTransactions { get; set; }

        [DataMember(Name = "payloadHash")]
        public string PayloadHash { get; set; }

        [DataMember(Name = "payloadLength")]
        public decimal PayloadLength { get; set; }

        [DataMember(Name = "previousBlock")]
        public BigInteger PreviousBlock { get; set; }

        [DataMember(Name = "timestamp")]
        public long Timestamp { get; set; }

        [DataMember(Name = "totalAmount")]
        public long TotalAmount { get; set; }

        [DataMember(Name = "totalFee")]
        public decimal TotalFee { get; set; }

        [DataMember(Name = "reward")]
        public decimal Reward { get; set; }

        [DataMember(Name = "version")]
        public decimal Version { get; set; }
    }
}
