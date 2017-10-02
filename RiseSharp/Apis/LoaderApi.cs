using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis
{
    public class LoaderApi : BaseApi, ILoaderApi
    {
        public LoaderApi():base(){ }

        public LoaderApi(Config NetworkConfig):base(NetworkConfig){ }

        public GetLoaderStatusResponse GetStatus()
            => GetStatusAsync().GetAwaiter().GetResult();

        public Task<GetLoaderStatusResponse> GetStatusAsync()
            => GetSimpleJsonAsync<GetLoaderStatusResponse>(Api.GetLoaderStatus);

        public LoaderSyncStatusResponse SyncStatus()
            => SyncStatusAsync().GetAwaiter().GetResult();

        public Task<LoaderSyncStatusResponse> SyncStatusAsync()
            => GetSimpleJsonAsync<LoaderSyncStatusResponse>(Api.GetLoaderSyncStatus);
    }
}
