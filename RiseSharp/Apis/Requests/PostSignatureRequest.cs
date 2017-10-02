using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Headers;
using RiseSharp.Models;

namespace RiseSharp.Apis.Requests
{
    public class PostSignatureRequest : TransportHeaders
    {
        [QueryParam(Name = "signature")]
        public Signature Signature { get; set; }
    }
}
