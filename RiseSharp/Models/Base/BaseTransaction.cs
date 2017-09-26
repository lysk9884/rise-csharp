using System;
using System.Runtime.Serialization;
using RiseSharp.Models.Enums;

namespace RiseSharp.Models.Base
{
    [DataContract]
    public class BaseTransaction<T>
    {
        [DataMember(Name = "type")]
        public TransactionType Type { get; set; }

		[DataMember(Name = "amount")]
        public decimal Amount { get; set; }

		[DataMember(Name = "senderPublicKey")]
        public string SenderPublicKey { get; set; }

		[DataMember(Name = "requesterPublicKey")]
		public string RequesterPublicKey { get; set; }

		[DataMember(Name = "timestamp")]
        public long Timestamp { get; set; }

		[DataMember(Name = "asset")]
		public T Asset { get; set; }

		[DataMember(Name = "recipientId")]
        public string RecipientId { get; set; }

		[DataMember(Name = "signature")]
        public string Signature { get; set; }

		[DataMember(Name = "id")]
        public string Id { get; set; }

		[DataMember(Name = "fee")]
        public decimal Fee { get; set; }
    }
}
