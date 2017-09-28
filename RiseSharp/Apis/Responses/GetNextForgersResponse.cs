using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetNextForgersResponse : BaseApiResponse
    {
		[DataMember(Name = "currentBlock")]
        public decimal CurrentBlock { get; set; }

		[DataMember(Name = "currentBlockSlot")]
		public decimal CurrentBlockSlot { get; set; }

		[DataMember(Name = "currentSlot")]
		public decimal CurrentSlot { get; set; }

		[DataMember(Name = "delegates")]
		public IList<string> Delegates { get; set; }
    }
}
