using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using RiseSharp.Tests.Attrs;
using RiseSharp.Utils;
using System.Diagnostics;
using Xunit;

namespace RiseSharp.Tests
{
    [TestCaseOrderer("RiseSharp.Tests.Attrs.PriorityOrderer", "RiseSharp.Tests")]
    public class AccountApiTests
    {
        public static string _liveSecret = "sniff case husband impulse nerve aunt vacant air shallow hope fold hole";
        public static string _liveAddress = "5536192064797317240R";
        public static string _livePubKey = "99551e800e58525ff90cefd00760c0a40283abab6cdec8a8b8a633c172b81d60";

        private AccountsApi api = new AccountsApi(new Config(ApiParams.DefaultHost, ApiParams.UseHttps, ApiParams.DefaultPort));

        [Fact, TestPriority(32)]
        public void TestGenerateSecret()
        {
            var code = CryptoUtils.GenerateSecret();
            Assert.True(!string.IsNullOrWhiteSpace(code), "Invalid Mneumonic code");
            Assert.True(code.Split(" ".ToCharArray()).Length == 12, "BIP39 Mneumonic code must contain 12 words.");
        }

        [Fact, TestPriority(0)]
        public void GeneratePublicKey()
        {
            var response = api.GeneratePublicKey(new Apis.Requests.GeneratePublicKeyRequest
            {
                Secret = _liveSecret
            });
            Assert.NotNull(response.PublicKey);
            Assert.True(response.Success);
        }

        [Fact, TestPriority(2)]
        public void GetAccount()
        {
            string _Address = _liveAddress;
            var response = api.GetAccount(new Apis.Requests.GetAccountRequest
            {
                Address = _Address
            });

            Assert.NotNull(response.Account.PublicKey);
            Assert.NotNull(response.Account.Address);
            Assert.True(response.Success);
        }

        [Fact, TestPriority(3)]
        public void GetAccountByPublicKey()
        {
            string _PublicKey = _livePubKey;
            var response = api.GetAccountByPublicKey(new Apis.Requests.GetAccountByPublicKeyRequest
            {
                PublicKey = _PublicKey
            });
            Assert.NotNull(response.Account.PublicKey);
            Assert.NotNull(response.Account.Address);
            Assert.True(response.Success);
        }

        [Fact, TestPriority(4)]
        public void GetBalance()
        {
            string _Address = _liveAddress;
            var response = api.GetBalance(new Apis.Requests.GetBalanceRequest
            {
                Address = _Address
            });
            Assert.NotNull(response.Balance);
            Assert.NotNull(response.UnconfirmedBalance);
            Assert.True(response.Success);
        }

        [Fact, TestPriority(5)]
        public void GetDelegates()
        {
            string _Address = _liveAddress;
            var response = api.GetDelegates(new Apis.Requests.GetDelegatesRequest
            {
                Address = _Address
            });

            Debug.WriteLine(response.ToString());
            Assert.True(response.Success);
        }

        [Fact, TestPriority(6)]
        public void GetPublicKey()
        {
            string _Address = _liveAddress;
            var response = api.GetPublicKey(new Apis.Requests.GetPublicKeyRequest
            {
                Address = _Address
            });
            Assert.NotNull(response.PublicKey);
            Assert.True(response.Success);
        }

        [Fact, TestPriority(7)]
        public void PutDelegates()
        { // NOT TESTED
            var response = api.PutDelegates(new Apis.Requests.PutDelegatesRequest
            {
                Secret = _liveSecret,
                PublicKey = _livePubKey,
                Delegates = new string[] { }
            });

            Assert.NotNull(response);
        }
    }
}