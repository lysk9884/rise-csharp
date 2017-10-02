using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;

namespace RiseSharp.Apis
{
    public class SignaturesApi : BaseApi, ISignaturesApi
    {
        public SignaturesApi():base(){ }

        public SignaturesApi(Config NetworkConfig):base(NetworkConfig){ }

        public object Add(AddSignaturesRequest Request)
            => AddAsync(Request).GetAwaiter().GetResult();

        public Task<object> AddAsync(AddSignaturesRequest Request)
            => PutSimpleJsonAsync<object, AddSignaturesRequest>(Request, Api.PutSignatureAdd);
    }
}
