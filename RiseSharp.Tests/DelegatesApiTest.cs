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
    }
}
