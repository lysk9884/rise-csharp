using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Headers;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis
{
    public class TransportApi : BaseTransportApi, ITransportApi
    {
        public TransportApi():base(){ }

        public TransportApi(Config NetworkConfig):base(NetworkConfig){ }

        public GetPeerHeightResponse GetPeerHeight(TransportHeaders Request)
            => GetPeerHeightAsync(Request).GetAwaiter().GetResult();

        public Task<GetPeerHeightResponse> GetPeerHeightAsync(TransportHeaders Request)
            => GetSimpleJsonAsync<GetPeerHeightResponse, TransportHeaders>(Request, Api.PeerGetHeight);

        public PeersGetListResponse GetPeersList(TransportHeaders Request)
            => GetPeersListAsync(Request).GetAwaiter().GetResult();

        public Task<PeersGetListResponse> GetPeersListAsync(TransportHeaders Request)
            => GetSimpleJsonAsync<PeersGetListResponse, TransportHeaders>(Request, Api.PeerGetList);

        public BaseApiResponse Ping(TransportHeaders Request)
            => PingAsync(Request).GetAwaiter().GetResult();

        public Task<BaseApiResponse> PingAsync(TransportHeaders Request)
            => GetSimpleJsonAsync<BaseApiResponse, TransportHeaders>(Request, Api.GetPeerPing);

        public object PostSignature(PostSignatureRequest Request)
            => PostSignatureAsync(Request).GetAwaiter().GetResult();

        public Task<object> PostSignatureAsync(PostSignatureRequest Request)
            => PostSimpleJsonAsync<object, PostSignatureRequest>(Request, Api.PeerGetSignatures);

        public object PostSignatures(PostSignaturesRequest Request)
            => PostSignaturesAsync(Request).GetAwaiter().GetResult();

        public Task<object> PostSignaturesAsync(PostSignaturesRequest Request)
            => PostSimpleJsonAsync<object, PostSignaturesRequest>(Request, Api.PeerGetSignatures);

        public object PostTransaction<T>(PostTransactionRequest<T> Request)
            => PostTransactionAsync(Request).GetAwaiter().GetResult();

        public Task<object> PostTransactionAsync<T>(PostTransactionRequest<T> Request)
            => PostSimpleJsonAsync<object, PostTransactionRequest<T>>(Request, Api.PeerPostTransactions);

        public object PostTransactions<T>(PostTransactionsRequest<T> Request)
			=> PostTransactionsAsync(Request).GetAwaiter().GetResult();

        public Task<object> PostTransactionsAsync<T>(PostTransactionsRequest<T> Request)
			=> PostSimpleJsonAsync<object, PostTransactionsRequest<T>>(Request, Api.PeerPostTransactions);
    }
}
