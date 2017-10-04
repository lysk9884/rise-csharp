using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis
{
    public class SignaturesApi : BaseApi, ISignaturesApi
    {
        public SignaturesApi():base(){ }

        public SignaturesApi(Config NetworkConfig):base(NetworkConfig){ }

        public GetTransactionResponse<T> Add<T>(AddSignaturesRequest Request)
            => AddAsync<T>(Request).GetAwaiter().GetResult();

        public Task<GetTransactionResponse<T>> AddAsync<T>(AddSignaturesRequest Request)
            => PutSimpleJsonAsync<GetTransactionResponse<T>, AddSignaturesRequest>(Request, Api.PutSignatureAdd);
    }
}
