using System;
using NUnit.Framework;
using RiseSharp;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using RiseSharp.Models;
using RiseSharp.Utils;

namespace NunitPcl.Test
{
    [TestFixture]
    public class AccountApiTests
    {

        public static string _liveSecret = "cabbage chief join task universe hello grab slush page exit update brisk";
        public static string _liveAddress = "10861956178781184496R";
        public static string _livePubKey = "328dc8563b84d8429e2d69dacbb72692b95a1c427961c425f347fce342c1e152";

        AccountsApi api = new AccountsApi(new Config(ApiParams.DefaultHost, true, null));

        [Test]
        public void TestGenerateSecret()
        {
            var code = CryptoUtils.GenerateSecret();
            Assert.True(!string.IsNullOrWhiteSpace(code), "Invalid Mneumonic code");
            Assert.True(code.Split(" ".ToCharArray()).Length == 12, "BIP39 Mneumonic code must contain 12 words.");
        }

        [Test]
        public void GeneratePublicKey()
        {
            var response = api.GeneratePublicKey(new RiseSharp.Apis.Requests.GeneratePublicKeyRequest
            {
                Secret = _liveSecret
            });
            Assert.NotNull(response.PublicKey);
            Assert.True(response.Success);
        }

        [Test]
        public void OpenAccount()
        {
            var response = api.Open(new RiseSharp.Apis.Requests.OpenAccountRequest
            {
                Secret = _liveSecret
            });
            Assert.NotNull(response.Account.PublicKey);
            Assert.NotNull(response.Account.Address);
            Assert.True(response.Success);
        }

        [Test]
        public void GetAccount()
        {
            string _Address = _liveAddress;
            var response = api.GetAccount(new RiseSharp.Apis.Requests.GetAccountRequest
            {
                Address = _Address
            });
            Assert.NotNull(response.Account.PublicKey);
            Assert.NotNull(response.Account.Address);
            Assert.True(response.Success);
        }

        [Test]
        public void GetAccountByPublicKey()
        {
            string _PublicKey = _livePubKey;
            var response = api.GetAccountByPublicKey(new RiseSharp.Apis.Requests.GetAccountByPublicKeyRequest
            {
                PublicKey = _PublicKey
            });
            Assert.NotNull(response.Account.PublicKey);
            Assert.NotNull(response.Account.Address);
            Assert.True(response.Success);
        }

        [Test]
        public void GetBalance()
        {
            string _Address = _liveAddress;
            var response = api.GetBalance(new RiseSharp.Apis.Requests.GetBalanceRequest
            {
                Address = _Address
            });
            Assert.NotNull(response.Balance);
            Assert.NotNull(response.UnconfirmedBalance);
            Assert.True(response.Success);
        }

        [Test]
        public void GetDelegates()
        {
            string _Address = _liveAddress;
            var response = api.GetDelegates(new RiseSharp.Apis.Requests.GetDelegatesRequest
            {
                Address = _Address
            });
            Assert.NotNull(response.Delegates);
            Assert.True(response.Success);
        }

        [Test]
        public void GetPublicKey()
        {
            string _Address = _liveAddress;
            var response = api.GetPublicKey(new RiseSharp.Apis.Requests.GetPublicKeyRequest
            {
                Address = _Address
            });
            Assert.NotNull(response.PublicKey);
            Assert.True(response.Success);
        }

        //[Test]
        //public void PutDelegates()
        //{ // NOT TESTED
        //    var response = api.PutDelegates(new RiseSharp.Apis.Requests.PutDelegatesRequest
        //    {
        //        Secret = _liveSecret,
        //        PublicKey = _livePubKey,
        //        Delegates = new string[] { }

        //    });

        //    Assert.NotNull(response);
        //}
    }
}
