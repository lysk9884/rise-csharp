using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis
{
    public class DappsApi : BaseApi, IDappsApi
    {
        public DappsApi():base(){ }

        public DappsApi(Config NetworkConfig):base(NetworkConfig){ }

        public GetDappCategoriesResponse GetCategories()
            => GetCategoriesAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<GetDappCategoriesResponse> GetCategoriesAsync()
            => GetSimpleJsonAsync<GetDappCategoriesResponse>(Api.GetDappsCategories);
    }
}
