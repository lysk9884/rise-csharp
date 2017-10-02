using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis
{
    public class PeersApi : BaseApi, IPeersApi
    {
        public PeersApi():base(){ }

        public PeersApi(Config NetworkConfig):base(NetworkConfig){ }

        public PeersGetListResponse GetList(PeersGetListRequest Request)
            => GetListAsync(Request).GetAwaiter().GetResult();

        public Task<PeersGetListResponse> GetListAsync(PeersGetListRequest Request)
            => GetSimpleJsonAsync<PeersGetListResponse, PeersGetListRequest>(Request, Api.GetPeers);

        public GetPeerByPortIpResponse GetPeerByPortIp(GetPeerByPortIpRequest Request)
            => GetPeerByPortIpAsync(Request).GetAwaiter().GetResult();

        public Task<GetPeerByPortIpResponse> GetPeerByPortIpAsync(GetPeerByPortIpRequest Request)
            => GetSimpleJsonAsync<GetPeerByPortIpResponse, GetPeerByPortIpRequest>(Request, Api.GetPeer);

        public GetPeerVersionResponse GetVersion()
            => GetVersionAsync().GetAwaiter().GetResult();

        public Task<GetPeerVersionResponse> GetVersionAsync()
            => GetSimpleJsonAsync<GetPeerVersionResponse>(Api.Version);
    }
}
