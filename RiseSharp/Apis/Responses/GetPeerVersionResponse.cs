using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetPeerVersionResponse : BaseApiResponse
    {
        [DataMember(Name = "build")]
        public string Build { get; set; }

		[DataMember(Name = "commit")]
		public string Commit { get; set; }

		[DataMember(Name = "version")]
		public string Version { get; set; }

		[DataMember(Name = "minVersion")]
		public string MinVersion { get; set; }
    }
}
