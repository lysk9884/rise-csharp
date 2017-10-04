using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis
{
    public class MultiSignaturesApi : BaseApi, IMultisignaturesApi
    {
        public MultiSignaturesApi():base(){ }

        public MultiSignaturesApi(Config NetworkConfig):base(NetworkConfig){ }

        public object CreateMultiSigAccount(CreateMultiSigAccountRequest Request)
            => CreateMultiSigAccountAsync(Request).GetAwaiter().GetResult();

        public Task<object> CreateMultiSigAccountAsync(CreateMultiSigAccountRequest Request)
            => PutSimpleJsonAsync<object, CreateMultiSigAccountRequest>(Request, Api.PutMultiSignaturesAdd);

        public GetAccountsResponse GetAccounts(GetAccountByPublicKeyRequest Request)
            => GetAccountsAsync(Request).GetAwaiter().GetResult();

        public Task<GetAccountsResponse> GetAccountsAsync(GetAccountByPublicKeyRequest Request)
            =>GetSimpleJsonAsync<GetAccountsResponse, GetAccountByPublicKeyRequest>(Request, Api.GetMultiSignaturesAccounts);

        public TransactionsResponse<T> GetPending<T>(GetPendingRequest Request)
            => GetPendingAsync<T>(Request).GetAwaiter().GetResult();

        public Task<TransactionsResponse<T>> GetPendingAsync<T>(GetPendingRequest Request)
            => GetSimpleJsonAsync<TransactionsResponse<T>, GetPendingRequest>(Request, Api.GetMultiSignaturesPending);

        public MultiSignaturesSignResponse Sign(MultiSigSignRequest Request)
            => SignAsync(Request).GetAwaiter().GetResult();

        public Task<MultiSignaturesSignResponse> SignAsync(MultiSigSignRequest Request)
            => PostSimpleJsonAsync<MultiSignaturesSignResponse, MultiSigSignRequest>(Request, Api.PostMultiSignaturesSign);
	}
}
