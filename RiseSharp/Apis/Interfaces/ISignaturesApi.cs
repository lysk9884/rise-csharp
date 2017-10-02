using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;

namespace RiseSharp.Apis.Interfaces
{
    public interface ISignaturesApi
    {
        /// <summary>
        /// Add the specified Request.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="Request">Request.</param>
        object Add(AddSignaturesRequest Request);

        /// <summary>
        /// Adds the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="Request">Request.</param>
        Task<object> AddAsync(AddSignaturesRequest Request);
    }
}
