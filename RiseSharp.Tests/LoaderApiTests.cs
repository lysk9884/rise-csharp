using System;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using Xunit;

namespace RiseSharp.Tests
{
    public class LoaderApiTests
    {
        LoaderApi api = new LoaderApi(new Config(ApiParams.DefaultHost, true, null));

        [Fact]
        public void GetStatusTest()
        {
            var response = api.GetStatus();
            Assert.True(response.Success);
        }

        [Fact]
        public void SyncStatusTest()
        {
            var response = api.SyncStatus();
            Assert.True(response.Success);
        }
    }
}
