using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Models.Base;

namespace RiseSharp.Models
{
    [DataContract]
    public class ForgedBlock : BaseBlock
    {
        [DataMember(Name = "transactions")]
        public IList<BaseTransaction<object>> Transactions { get; set; }
    }
}
