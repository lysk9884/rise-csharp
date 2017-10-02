using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis.Interfaces
{
    public interface IDappsApi
    {
        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <returns>The categories.</returns>
        GetDappCategoriesResponse GetCategories();

        /// <summary>
        /// Gets the categories async.
        /// </summary>
        /// <returns>The categories async.</returns>
        Task<GetDappCategoriesResponse> GetCategoriesAsync();
    }
}
