using System;
using System.Runtime.Serialization;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    [DataContract]
    public class SendTransactionRequest : BaseApiRequest
    {
        [DataMember(Name = "secret")]
        public string Secret { get; set; }

        [DataMember(Name = "amount")]
        public long? Amount { get; set; }

        [DataMember(Name = "recipientId")]
        public string RecipientId { get; set; }

        [DataMember(Name = "publicKey")]
        public string PublicKey { get; set; }

        [DataMember(Name = "secondSecret")]
        public string SecondSecret { get; set; }

        //[DataMember(Name = "multisigAccountPublicKey")] //not sure for this
        //public string MultiSigAccountPublicKey { get; set; }

    }
}
