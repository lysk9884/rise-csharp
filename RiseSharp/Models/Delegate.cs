using System;
using System.Runtime.Serialization;

namespace RiseSharp.Models
{
	[DataContract]
	public class Delegate
	{
		[DataMember(Name = "username")]
		public string Username { get; set; }

		[DataMember(Name = "address")]
		public string Address { get; set; }

		[DataMember(Name = "publicKey")]
		public string PublicKey { get; set; }

		[DataMember(Name = "vote")]
		public string Vote { get; set; }

		[DataMember(Name = "producedblocks")]
		public int Producedblocks { get; set; }

		[DataMember(Name = "missedblocks")]
		public int Missedblocks { get; set; }

		[DataMember(Name = "rate")]
        public decimal Rate { get; set; }

		[DataMember(Name = "rank")]
        public decimal Rank { get; set; }

		[DataMember(Name = "approval")]
        public decimal Approval { get; set; }

		[DataMember(Name = "productivity")]
        public decimal Productivity { get; set; }
	}
}
