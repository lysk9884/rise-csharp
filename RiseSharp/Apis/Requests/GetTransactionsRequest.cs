using System;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Requests
{
    public class TransactionsRequest : BaseApiRequest
    {
        [QueryParam(Name="senderPublicKey")]
        public string SenderPublickey { get; set; }

        [QueryParam(Name="ownerPublicKey")]
        public string OwnerPublicKey { get; set; }

        [QueryParam(Name="ownerAddress")]
        public string OwnerAddress { get; set; }

        [QueryParam(Name="senderId")]
        public string SenderId { get; set; }

        [QueryParam(Name="recipientId")]
        public string RecipientId { get; set; }

        [QueryParam(Name="amount")]
        public long? Amount { get; set; }

        [QueryParam(Name="fee")]
        public int? Fee { get; set; }

        [QueryParam(Name="type")]
        public int? Type { get; set; }

        [QueryParam(Name="blockId")]
        public string BlockId { get; set; }
    }
}
