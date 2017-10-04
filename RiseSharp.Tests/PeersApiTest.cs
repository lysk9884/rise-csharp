using System;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using Xunit;

namespace RiseSharp.Tests
{
    public class PeersApiTest
    {
        PeersApi api = new PeersApi(new Config(ApiParams.DefaultHost, true, null));

        [Fact]
        public void GetListTest()
        {
            var response = api.GetList(new Apis.Requests.PeersGetListRequest {
                //optional
            });

            Assert.True(response.Success);
            Assert.NotNull(response.Peers);
        }

        [Fact]
        public void GetPeerByPortIp()
        {
            var response = api.GetPeerByPortIp(new Apis.Requests.GetPeerByPortIpRequest 
            {
                Port = ApiParams.DefaultPort,
                Ip = ApiParams.DefaultHostIp
            });

            Assert.True(response.Success);
        }

        [Fact]
        public void GetVersionTest()
        {
            var response = api.GetVersion();
            Assert.True(response.Success);
        }
    }
}
