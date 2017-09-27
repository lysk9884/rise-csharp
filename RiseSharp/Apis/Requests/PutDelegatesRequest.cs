using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
	[DataContract]
	public class PutDelegatesRequest : BaseApiRequest
	{
		[DataMember(Name = "secret")]
		public string Secret { get; set; }

		[DataMember(Name = "publicKey")]
		public string PublicKey { get; set; }

		[DataMember(Name = "delegates")]
		public string[] Delegates { get; set; }

		[DataMember(Name = "secondSecret")]
		public string SecondSecret { get; set; }
	}
}
