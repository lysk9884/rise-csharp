using System;
using System.Runtime.Serialization;

namespace RiseSharp.Apis.Responses.Base
{
    [DataContract]
    public class BaseApiResponse
    {
        [DataMember(Name = "success", Order = 1)]
        public bool Success;
    }
}
