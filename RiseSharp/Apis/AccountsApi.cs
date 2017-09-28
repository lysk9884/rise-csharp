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
        public PublicKeyResponse GeneratePublicKey(GeneratePublicKeyRequest Secret) 
            => GeneratePublicKeyAsync(Secret).GetAwaiter().GetResult();

        public Task<PublicKeyResponse> GeneratePublicKeyAsync(GeneratePublicKeyRequest Secret) 
            => GetSimpleJsonAsync<PublicKeyResponse, GeneratePublicKeyRequest>(Secret, Api.PostGeneratePublicKey);

        public AccountResponse GetAccount(GetAccountRequest Address) 
            => GetAccountAsync(Address).GetAwaiter().GetResult();

        public Task<AccountResponse> GetAccountAsync(GetAccountRequest Address) 
            => GetSimpleJsonAsync<AccountResponse, GetAccountRequest>(Address, Api.GetAccount);

        public AccountResponse GetAccountByPublicKey(GetAccountByPublicKeyRequest PublicKey) 
            => GetAccountByPublicKeyAsync(PublicKey).GetAwaiter().GetResult();

        public Task<AccountResponse> GetAccountByPublicKeyAsync(GetAccountByPublicKeyRequest PublicKey) 
            => GetSimpleJsonAsync<AccountResponse, GetAccountByPublicKeyRequest>(PublicKey, Api.GetAccount);

        public BalanceResponse GetBalance(GetBalanceRequest Address) 
            => GetBalanceAsync(Address).GetAwaiter().GetResult();

        public Task<BalanceResponse> GetBalanceAsync(GetBalanceRequest Address) 
            => GetSimpleJsonAsync<BalanceResponse, GetBalanceRequest>(Address, Api.GetAccountBalance);

        public DelegatesResponse GetDelegates(GetDelegatesRequest Address) 
            => GetDelegatesAsync(Address).GetAwaiter().GetResult();

        public Task<DelegatesResponse> GetDelegatesAsync(GetDelegatesRequest Address) 
            => GetSimpleJsonAsync<DelegatesResponse, GetDelegatesRequest>(Address, Api.GetAccountDelegates);

        public PublicKeyResponse GetPublicKey(GetPublicKeyRequest Address) 
            => GetPublicKeyAsync(Address).GetAwaiter().GetResult();

        public Task<PublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest Address) 
            => GetSimpleJsonAsync<PublicKeyResponse, GetPublicKeyRequest>(Address, Api.GetAccountPublickey);

        public AccountResponse Open(OpenAccountRequest Secret)
            => OpenAsync(Secret).GetAwaiter().GetResult();

        public Task<AccountResponse> OpenAsync(OpenAccountRequest Secret)
            => PostSimpleJsonAsync<AccountResponse, OpenAccountRequest>(Secret, Api.PostAccountOpen);

        public object PutDelegates(PutDelegatesRequest Request)
            => PutDelegatesAsync(Request).GetAwaiter().GetResult();

        public Task<object> PutDelegatesAsync(PutDelegatesRequest Request)
            => PutSimpleJsonAsync<object, PutDelegatesRequest>(Request, Api.PutAccountDelegateAdd);
    }
}