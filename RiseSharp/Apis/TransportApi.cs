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

        public BaseApiResponse PostSignature(PostSignatureRequest Request)
            => PostSignatureAsync(Request).GetAwaiter().GetResult();

        public Task<BaseApiResponse> PostSignatureAsync(PostSignatureRequest Request)
            => PostSimpleJsonAsync<BaseApiResponse, PostSignatureRequest>(Request, Api.PeerGetSignatures);

        public BaseApiResponse PostSignatures(PostSignaturesRequest Request)
            => PostSignaturesAsync(Request).GetAwaiter().GetResult();

        public Task<BaseApiResponse> PostSignaturesAsync(PostSignaturesRequest Request)
            => PostSimpleJsonAsync<BaseApiResponse, PostSignaturesRequest>(Request, Api.PeerGetSignatures);

        public BaseApiResponse PostTransaction<T>(PostTransactionRequest<T> Request)
            => PostTransactionAsync(Request).GetAwaiter().GetResult();

        public Task<BaseApiResponse> PostTransactionAsync<T>(PostTransactionRequest<T> Request)
            => PostSimpleJsonAsync<BaseApiResponse, PostTransactionRequest<T>>(Request, Api.PeerPostTransactions);

        public BaseApiResponse PostTransactions<T>(PostTransactionsRequest<T> Request)
			=> PostTransactionsAsync(Request).GetAwaiter().GetResult();

        public Task<BaseApiResponse> PostTransactionsAsync<T>(PostTransactionsRequest<T> Request)
			=> PostSimpleJsonAsync<BaseApiResponse, PostTransactionsRequest<T>>(Request, Api.PeerPostTransactions);
    }
}
