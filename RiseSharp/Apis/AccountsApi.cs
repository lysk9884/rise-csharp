using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Interfaces.Apis;

namespace RiseSharp.Apis
{
    public class AccountsApi : IAccountsApi
    {

        readonly UriBuilder UriBuilder;
        readonly HttpClient HttpClient;

        public AccountsApi()
        {
            HttpClient = new HttpClient();

            UriBuilder = new UriBuilder
            {
                Host = Constants.ApiParams.DefaultHost,
                Scheme = Constants.ApiParams.Https,
                Port = Constants.ApiParams.DefaultPort
			};
        }

        public PublicKeyResponse GeneratePublicKey(string Secret)
        {
            return GeneratePublicKeyAsync(Secret).GetAwaiter().GetResult();
        }

        public Task<PublicKeyResponse> GeneratePublicKeyAsync(string Secret)
        {
            UriBuilder.Path = Constants.Api.PostGeneratePublicKey;

            return HttpClient.PostJsonAsync<string, PublicKeyResponse>(UriBuilder.ToString(), Secret);
        }

        public AccountResponse GetAccount(string Address)
        {
            throw new NotImplementedException();
        }

        public Task<AccountResponse> GetAccountAsync(string Address)
        {
            throw new NotImplementedException();
        }

        public AccountResponse GetAccountByPublicKey(string PublicKey)
        {
            throw new NotImplementedException();
        }

        public Task<AccountResponse> GetAccountByPublicKeyAsync(string PublicKey)
        {
            throw new NotImplementedException();
        }

        public BalanceResponse GetBalance(string Address)
        {
            return GetBalanceAsync(Address).GetAwaiter().GetResult();
        }

        public Task<BalanceResponse> GetBalanceAsync(string Address)
        {
            UriBuilder.Path = Constants.Api.GetAccountBalance;

            var parameters = new Dictionary<string, string>
            {
                { Constants.QueryKeys.Address, Address }
            };

            return HttpClient.GetJsonAsync<BalanceResponse>(UriBuilder.ToString(), parameters);
        }

        public DelegatesResponse GetDelegates(string Address)
        {
            throw new NotImplementedException();
        }

        public Task<DelegatesResponse> GetDelegatesAsync(string Address)
        {
            throw new NotImplementedException();
        }

        public PublicKeyResponse GetPublicKey(string Address)
        {
            return GetPublicKeyAsync(Address).GetAwaiter().GetResult();
        }

        public Task<PublicKeyResponse> GetPublicKeyAsync(string Address)
        {
			UriBuilder.Path = Constants.Api.GetAccountPublickey;
			return HttpClient.GetJsonAsync<PublicKeyResponse>(UriBuilder.ToString());
        }

        public AccountResponse Open(string Secret)
        {
            return OpenAsync(Secret).GetAwaiter().GetResult();
        }

        public Task<AccountResponse> OpenAsync(string Secret)
        {
			UriBuilder.Path = Constants.Api.PostAccountOpen;
            return HttpClient.PostJsonAsync<string, AccountResponse>(UriBuilder.ToString(), Secret);
        }

        public object PutDelegates(PutDelegatesRequest Request)
        {
            throw new NotImplementedException();
        }

        public Task<object> PutDelegatesAsync(PutDelegatesRequest Request)
        {
            throw new NotImplementedException();
        }
    }
}
