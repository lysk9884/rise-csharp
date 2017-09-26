using System;
using System.Runtime.Serialization;
using RiseSharp.Models.Base;

namespace RiseSharp.Models
{
    [DataContract]
    public class Transaction<T> : BaseTransaction<T>
    {
		[DataMember(Name = "senderId")]
		public string SenderId { get; set; }

		[DataMember(Name = "relays")]
        public decimal Relays { get; set; }

		[DataMember(Name = "receivedAt")]
		public string ReceivedAt { get; set; }
    }
}
