using System;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using Xunit;

namespace RiseSharp.Tests
{
    public class DelegatesApiTest
    {
        DelegatesApi api = new DelegatesApi(new Config(ApiParams.DefaultHost, true, null));

        [Fact]
        public void EnableTest()
        {
            var response = api.Enable(new Apis.Requests.DelegatesEnableRequest
            {
                Secret = AccountApiTests._liveSecret
            });
            Assert.NotNull(response);
        }

        [Fact]
        public void GetByPublicKeyTest()
        {
            var response = api.GetByPublicKey(new Apis.Requests.PublicKeyRequest
            {
                PublicKey = AccountApiTests._livePubKey
            });

            Assert.True(response.Success);
            Assert.NotNull(response.Delegate);
        }

        [Fact]
        public void GetByUserNameTest()
        {
            var response = api.GetByUserName(new Apis.Requests.UserNameRequest 
            {
                UserName = "Some User Name"
            });

            Assert.True(response.Success);
            Assert.NotNull(response.Delegate);
        }

        [Fact]
        public void GetForgetByAccountTest()
        {
            var response = api.GetForgetByAccount(new Apis.Requests.ForgetByAccountRequest
            {
                Publickey = AccountApiTests._livePubKey
            });

			Assert.True(response.Success);
        }

        [Fact]
        public void GetForgingStatusTest()
        {
            var response = api.GetForgingStatus(new Apis.Requests.GetForgingStatusRequest 
            {
                PublicKey = AccountApiTests._livePubKey
            });

            Assert.True(response.Success);
        }

        [Fact]
        public void GetListTest()
        {
            var response = api.GetList();
            Assert.True(response.Success);
            Assert.NotNull(response.Delegates);
        }

        [Fact]
        public void GetNextForgersTest()
        {
            var response = api.GetNextForgers(new Apis.Requests.GetNextForgersRequest 
            {
                Limit = 2
            });

            Assert.True(response.Success);
        }

        [Fact]
        public void GetVoters()
        {
            var response = api.GetVoters(new Apis.Requests.GetVotersRequest 
            {
                PublicKey = AccountApiTests._livePubKey
            });    

            Assert.True(response.Success);
            Assert.NotNull(response.Accounts);
        }

        [Fact]
        public void ToggleForgingTest()
        {
            var response = api.ToggleForging(new Apis.Requests.ToggleForgingRequest {
                Secret = AccountApiTests._liveSecret
            }, true);

            Assert.True(response.Success);
            Assert.NotNull(response.Address);
        }
    }
}
