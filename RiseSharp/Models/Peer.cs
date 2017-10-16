using System;
using System.Runtime.Serialization;
using RiseSharp.Models.Enums;

namespace RiseSharp.Models
{
	[DataContract]
	public class Peer
	{
		[DataMember(Name = "ip")]
		public string IpAddress { get; set; }

		[DataMember(Name = "port")]
		public int? Port { get; set; }

		[DataMember(Name = "state")]
		public PeerState? State { get; set; }

		[DataMember(Name = "os")]
		public string Os { get; set; }

		[DataMember(Name = "version")]
		public string Version { get; set; }

		[DataMember(Name = "dappid")]
		public string Dappid { get; set; }

		[DataMember(Name = "broadhash")]
		public string Broadhash { get; set; }

		[DataMember(Name = "height")]
        public decimal? Height { get; set; }

		[DataMember(Name = "clock")]
		public string Clock { get; set; }

		[DataMember(Name = "updated")]
        public decimal? Updated { get; set; }

		[DataMember(Name = "nonce")]
        public string Nonce { get; set; }
	}
}
