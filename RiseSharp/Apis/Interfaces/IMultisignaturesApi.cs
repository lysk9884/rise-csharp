using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;

namespace RiseSharp.Apis.Interfaces
{
    public interface IMultisignaturesApi
    {
        /// <summary>
        /// Gets the pending.
        /// </summary>
        /// <returns>The pending.</returns>
        /// <param name="Request">Request.</param>
        object GetPending(GetPendingRequest Request);

        /// <summary>
        /// Gets the pending async.
        /// </summary>
        /// <returns>The pending async.</returns>
        /// <param name="Request">Request.</param>
        Task<object> GetPendingAsync(GetPendingRequest Request);

        /// <summary>
        /// Creates the multi sig account.
        /// </summary>
        /// <returns>The multi sig account.</returns>
        /// <param name="Request">Request.</param>
        object CreateMultiSigAccount(CreateMultiSigAccountRequest Request);

        /// <summary>
        /// Creates the multi sig account async.
        /// </summary>
        /// <returns>The multi sig account async.</returns>
        /// <param name="Request">Request.</param>
        Task<object> CreateMultiSigAccountAsync(CreateMultiSigAccountRequest Request);

        /// <summary>
        /// Sign the specified Request.
        /// </summary>
        /// <returns>The sign.</returns>
        /// <param name="Request">Request.</param>
        object Sign(MultiSigSignRequest Request);

        /// <summary>
        /// Signs the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="Request">Request.</param>
        Task<object> SignAsync(MultiSigSignRequest Request);

        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns>The accounts.</returns>
        /// <param name="Request">Request.</param>
        object GetAccounts(GetAccountByPublicKeyRequest Request);

        /// <summary>
        /// Gets the accounts async.
        /// </summary>
        /// <returns>The accounts async.</returns>
        /// <param name="Request">Request.</param>
        Task<object> GetAccountsAsync(GetAccountByPublicKeyRequest Request);

        //object GetMultisignatures(GetMultiSignaturesRequest Request);
        //Task<object> GetMultisignaturesAsync(GetMultiSignaturesRequest Request);
    }
}
