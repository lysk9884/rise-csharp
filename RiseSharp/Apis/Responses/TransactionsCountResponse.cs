using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class TransactionsCountResponse : BaseApiResponse
    {
        [DataMember(Name = "confirmed")]
        public long Confirmed { get; set; }

		[DataMember(Name = "multisignature")]
		public long Multisignature { get; set; }

		[DataMember(Name = "unconfirmed")]
		public long Unconfirmed { get; set; }

		[DataMember(Name = "queued")]
		public long Queued { get; set; }
    }
}
