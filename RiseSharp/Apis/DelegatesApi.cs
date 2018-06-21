using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Models;

namespace RiseSharp.Apis
{
    public class DelegatesApi : BaseApi, IDelegatesApi
    {
        public DelegatesApi():base(){ }

        public DelegatesApi(Config NetworkConfig):base(NetworkConfig){ }

        public Transaction<Models.Delegate> Enable(DelegatesEnableRequest Request)
            => EnableAsync(Request).GetAwaiter().GetResult();
        
        public Task<Transaction<Models.Delegate>> EnableAsync(DelegatesEnableRequest Request)
            => PutSimpleJsonAsync<Transaction<Models.Delegate>, DelegatesEnableRequest>(Request, Api.GetDelegates);

        public DelegateResponse GetByPublicKey(PublicKeyRequest Request)
            => GetByPublicKeyAsync(Request).GetAwaiter().GetResult();

        public Task<DelegateResponse> GetByPublicKeyAsync(PublicKeyRequest Request)
            => GetSimpleJsonAsync<DelegateResponse, PublicKeyRequest>(Request, Api.GetDelegate);

        public DelegateResponse GetByUserName(UserNameRequest Request)
            => GetByUserNameAsync(Request).GetAwaiter().GetResult();

        public Task<DelegateResponse> GetByUserNameAsync(UserNameRequest Request)
            => GetSimpleJsonAsync<DelegateResponse, UserNameRequest>(Request, Api.GetDelegate);

        public ForgetByAccountResponse GetForgetByAccount (ForgetByAccountRequest Request)
            => GetForgetByAccountAsync(Request).GetAwaiter().GetResult();

        public Task<ForgetByAccountResponse> GetForgetByAccountAsync(ForgetByAccountRequest Request)
            => GetSimpleJsonAsync<ForgetByAccountResponse, ForgetByAccountRequest>(Request, Api.GetDelegateForgeAccount);

        public GetForgingStatusResponse GetForgingStatus(GetForgingStatusRequest Request)
            => GetForgingStatusAsync(Request).GetAwaiter().GetResult();

        public Task<GetForgingStatusResponse> GetForgingStatusAsync(GetForgingStatusRequest Request)
            => GetSimpleJsonAsync<GetForgingStatusResponse, GetForgingStatusRequest>(Request, Api.GetForgingStatus);

        public GetDelegatesResponse GetList()
            => GetListAsync().GetAwaiter().GetResult();

        public Task<GetDelegatesResponse> GetListAsync()
            => GetSimpleJsonAsync<GetDelegatesResponse>(Api.GetDelegates);

        public GetNextForgersResponse GetNextForgers(GetNextForgersRequest Request)
            => GetNextForgersAsync(Request).GetAwaiter().GetResult();

        public Task<GetNextForgersResponse> GetNextForgersAsync(GetNextForgersRequest Request)
            => GetSimpleJsonAsync<GetNextForgersResponse, GetNextForgersRequest>(Request,Api.GetNextForgers);

        public GetVotersResponse GetVoters(GetVotersRequest Request)
            => GetVotersAsync(Request).GetAwaiter().GetResult();

        public Task<GetVotersResponse> GetVotersAsync(GetVotersRequest Request)
            => GetSimpleJsonAsync<GetVotersResponse, GetVotersRequest>(Request, Api.GetDelegateVoters);

        public ToggleForgingResponse ToggleForging(ToggleForgingRequest Request, bool enable)
            => ToggleForgingAsync(Request, enable).GetAwaiter().GetResult();

        public Task<ToggleForgingResponse> ToggleForgingAsync(ToggleForgingRequest Request, bool enable)
            => PostSimpleJsonAsync<ToggleForgingResponse, ToggleForgingRequest>(
            Request,
            string.Format(Api.ToggleForging, enable ? Api.Enable : Api.Disable)
        );
    }
}
