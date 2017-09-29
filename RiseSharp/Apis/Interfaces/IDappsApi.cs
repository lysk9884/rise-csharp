using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis.Interfaces
{
    public interface IDappsApi
    {
        GetDappCategoriesResponse GetCategories();

        Task<GetDappCategoriesResponse> GetCategoriesAsync();
    }
}
