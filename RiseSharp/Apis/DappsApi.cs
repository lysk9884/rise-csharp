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
        public GetDappCategoriesResponse GetCategories()
            => GetCategoriesAsync().GetAwaiter().GetResult();

        public Task<GetDappCategoriesResponse> GetCategoriesAsync()
            => GetSimpleJsonAsync<GetDappCategoriesResponse>(Api.GetDappsCategories);
    }
}
