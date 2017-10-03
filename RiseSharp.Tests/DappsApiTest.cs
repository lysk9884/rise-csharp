using System;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using Xunit;

namespace RiseSharp.Tests
{
    public class DappsApiTest
    {
        DappsApi api = new DappsApi(new Config(ApiParams.DefaultHost, true, null));

        [Fact]
        public void GetCategoriesTest()
        {
            var response = api.GetCategories();
            Assert.True(response.Success);
            Assert.NotNull(response.Categories);
        }
    }
}
