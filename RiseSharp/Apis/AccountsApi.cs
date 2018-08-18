using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis
{
    public class AccountsApi : BaseApi, IAccountsApi
    {
        public AccountsApi(){}

        public AccountsApi(Config NetworkConfig):base(NetworkConfig){}

        public PublicKeyResponse GeneratePublicKey(GeneratePublicKeyRequest Secret)
            => GeneratePublicKeyAsync(Secret).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<PublicKeyResponse> GeneratePublicKeyAsync(GeneratePublicKeyRequest Secret)
            => PostSimpleJsonAsync<PublicKeyResponse, GeneratePublicKeyRequest>(Secret, Api.PostGeneratePublicKey);

        public AccountResponse GetAccount(GetAccountRequest Address)
            => GetAccountAsync(Address).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<AccountResponse> GetAccountAsync(GetAccountRequest Address)
            => GetSimpleJsonAsync<AccountResponse, GetAccountRequest>(Address, Api.GetAccount);

        public AccountResponse GetAccountByPublicKey(GetAccountByPublicKeyRequest PublicKey)
            => GetAccountByPublicKeyAsync(PublicKey).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<AccountResponse> GetAccountByPublicKeyAsync(GetAccountByPublicKeyRequest PublicKey)
            => GetSimpleJsonAsync<AccountResponse, GetAccountByPublicKeyRequest>(PublicKey, Api.GetAccount);

        public BalanceResponse GetBalance(GetBalanceRequest Address)
            => GetBalanceAsync(Address).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<BalanceResponse> GetBalanceAsync(GetBalanceRequest Address)
            => GetSimpleJsonAsync<BalanceResponse, GetBalanceRequest>(Address, Api.GetAccountBalance);

        public GetDelegatesResponse GetDelegates(GetDelegatesRequest Address)
            => GetDelegatesAsync(Address).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<GetDelegatesResponse> GetDelegatesAsync(GetDelegatesRequest Address)
            => GetSimpleJsonAsync<GetDelegatesResponse, GetDelegatesRequest>(Address, Api.GetAccountDelegates);

        public PublicKeyResponse GetPublicKey(GetPublicKeyRequest Address)
            => GetPublicKeyAsync(Address).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<PublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest Address)
            => GetSimpleJsonAsync<PublicKeyResponse, GetPublicKeyRequest>(Address, Api.GetAccountPublickey);

        public object PutDelegates(PutDelegatesRequest Request)
            => PutDelegatesAsync(Request).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<object> PutDelegatesAsync(PutDelegatesRequest Request)
            => PutSimpleJsonAsync<object, PutDelegatesRequest>(Request, Api.PutAccountDelegateAdd);
    }
}