using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis.Interfaces
{
    public interface ISignaturesApi
    {
        /// <summary>
        /// Add the specified Request.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="Request">Request.</param>
        GetTransactionResponse<T> Add<T>(AddSignaturesRequest Request);

        /// <summary>
        /// Adds the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="Request">Request.</param>
        Task<GetTransactionResponse<T>> AddAsync<T>(AddSignaturesRequest Request);
    }
}
