using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;

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

        public object GetAccounts(GetAccountByPublicKeyRequest Request)
            => GetAccountsAsync(Request).GetAwaiter().GetResult();

        public Task<object> GetAccountsAsync(GetAccountByPublicKeyRequest Request)
            =>GetSimpleJsonAsync<object, GetAccountByPublicKeyRequest>(Request, Api.GetMultiSignaturesAccounts);

        public object GetPending(GetPendingRequest Request)
            => GetPendingAsync(Request).GetAwaiter().GetResult();

        public Task<object> GetPendingAsync(GetPendingRequest Request)
            => GetSimpleJsonAsync<object, GetPendingRequest>(Request, Api.GetMultiSignaturesPending);

        public object Sign(MultiSigSignRequest Request)
            => SignAsync(Request).GetAwaiter().GetResult();

        public Task<object> SignAsync(MultiSigSignRequest Request)
            => PostSimpleJsonAsync<object, MultiSigSignRequest>(Request, Api.PostMultiSignaturesSign);

		//public object GetMultisignatures(GetMultiSignaturesRequest Request)
		//{
		//    throw new NotImplementedException();
		//}

		//public Task<object> GetMultisignaturesAsync(GetMultiSignaturesRequest Request)
		//{
		//    throw new NotImplementedException();
		//}
	}
}
