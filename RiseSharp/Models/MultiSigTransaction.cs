using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Models.Base;

namespace RiseSharp.Models
{
    [DataContract]
    public class MultiSigTransaction<T> : BaseTransaction<T>
    {
		[DataMember(Name = "signatures")]
		public IList<string> Signatures { get; set; }
    }
}
