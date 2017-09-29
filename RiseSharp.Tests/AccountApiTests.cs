using System;
using RiseSharp.Apis;
using RiseSharp.Models;
using RiseSharp.Utils;
using Xunit;

namespace RiseSharp.Tests
{
    public class AccountApiTests
    {

        string _secretForExample = "cabbage chief join task universe hello grab slush page exit update brisk";

        AccountsApi api = new AccountsApi();

        [Fact]
		public void TestGenerateSecret()
		{
			var code = CryptoUtils.GenerateSecret();
			Assert.True(!string.IsNullOrWhiteSpace(code), "Invalid Mneumonic code");
			Assert.True(code.Split(" ".ToCharArray()).Length == 12, "BIP39 Mneumonic code must contain 12 words.");
		}

        [Fact]
        public void GeneratePublicKey()
        {
            var response = api.GeneratePublicKey(new Apis.Requests.GeneratePublicKeyRequest
            {
                Secret = _secretForExample      
            });
            Assert.NotNull(response.PublicKey);
            Assert.True(response.Success);
        }

        [Fact]
        public void OpenAccount(){
            var response = api.Open(new Apis.Requests.OpenAccountRequest
            {
                Secret = _secretForExample  
			});
            Assert.NotNull(response.Account.PublicKey);
            Assert.NotNull(response.Account.Address);
            Assert.True(response.Success);
        }

        [Fact]
        public void GetAccount(){
            string _Address = GetAccountModel().Address;
            var response = api.GetAccount(new Apis.Requests.GetAccountRequest
            {
                Address = _Address
            });
			Assert.NotNull(response.Account.PublicKey);
			Assert.NotNull(response.Account.Address);
			Assert.True(response.Success);
        }

        private Account GetAccountModel(){
			return api.Open(new Apis.Requests.OpenAccountRequest
			{
				Secret = _secretForExample  
			}).Account;
        }

        [Fact]
        public void GetAccountByPublicKey(){
            string _PublicKey = GetAccountModel().PublicKey;
            var response = api.GetAccountByPublicKey(new Apis.Requests.GetAccountByPublicKeyRequest
            {
                PublicKey = _PublicKey
			});
			Assert.NotNull(response.Account.PublicKey);
			Assert.NotNull(response.Account.Address);
			Assert.True(response.Success);
        }

        [Fact]
        public void GetBalance(){
            string _Address = GetAccountModel().Address;
            var response = api.GetBalance(new Apis.Requests.GetBalanceRequest 
            {
                Address = _Address
            });
            Assert.NotNull(response.Balance);
            Assert.NotNull(response.UnconfirmedBalance);
            Assert.True(response.Success);
        }

        [Fact]
        public void GetDelegates(){
            string _Address = GetAccountModel().Address;
            var response = api.GetDelegates(new Apis.Requests.GetDelegatesRequest
            {
                Address = _Address
            });
            Assert.NotNull(response.Delegates);
            Assert.True(response.Success);
        }

        [Fact]
        public void GetPublicKey(){
			string _Address = GetAccountModel().Address;
            var response = api.GetPublicKey(new Apis.Requests.GetPublicKeyRequest
			{
				Address = _Address
			});
            Assert.NotNull(response.PublicKey);
			Assert.True(response.Success);
        }

        //[Fact]
        //public void PutDelegates(){
        //    var response = api.PutDelegates(new Apis.Requests.PutDelegatesRequest {
        //        Secret = _secretForExample,

        //    });
        //}
    }
}
