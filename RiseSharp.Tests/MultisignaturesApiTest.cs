using System;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using Xunit;

namespace RiseSharp.Tests
{
    public class MultisignaturesApiTest
    {
        MultiSignaturesApi api = new MultiSignaturesApi(new Config(ApiParams.DefaultHost, true, null));

        [Fact]
        public void CreateMultiSigAccountTest()
		{
            var response = api.CreateMultiSigAccount(new Apis.Requests.CreateMultiSigAccountRequest 
            {
                Secret = AccountApiTests._liveSecret,
                LifeTime = 1,
                Min = 1,
                PublicKeys = new string[]{AccountApiTests._livePubKey}
            });

            Assert.NotNull(response);
        }

        [Fact]
        public void GetAccountsTest()
        {
            var response = api.GetAccounts(new Apis.Requests.GetAccountByPublicKeyRequest
            { 
                PublicKey = AccountApiTests._livePubKey  
            });

            Assert.True(response.Success);
        }

        [Fact]
        public void GetPendingTest()
        {
            var response = api.GetPending<object>(new Apis.Requests.GetPendingRequest 
            {
                PublicKey = AccountApiTests._livePubKey
			});

            Assert.True(response.Success);
        }

        [Fact]
        public void SignTest()
        {
            var response = api.Sign(new Apis.Requests.MultiSigSignRequest {
                PublicKey = AccountApiTests._livePubKey
            });
        }
    }
}
