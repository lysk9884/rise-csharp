using System;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using Xunit;

namespace RiseSharp.Tests
{
    public class SignaturesApiTest
    {
        SignaturesApi api = new SignaturesApi(new Config(ApiParams.DefaultHost, true, null));

        [Fact]
        public void AddTest() //TODO
        {
            var response = api.Add<object>(new Apis.Requests.AddSignaturesRequest 
            {
                Secret = AccountApiTests._liveSecret,
                PublicKey = AccountApiTests._livePubKey
            });

            Assert.True(response.Success);
        }
    }
}
