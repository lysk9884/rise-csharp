using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Models;

namespace RiseSharp.Apis.Interfaces
{
    public interface ITransactionsApi
    {
        /// <summary>
        /// Gets the transaction.
        /// </summary>
        /// <returns>The transaction.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        GetTransactionResponse<T> GetTransaction<T>(GetTransactionRequest Request);

        /// <summary>
        /// Gets the transaction async.
        /// </summary>
        /// <returns>The transaction async.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task<GetTransactionResponse<T>> GetTransactionAsync<T>(GetTransactionRequest Request);

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <returns>The count.</returns>
        TransactionsCountResponse GetCount();

        /// <summary>
        /// Gets the count async.
        /// </summary>
        /// <returns>The count async.</returns>
        Task<TransactionsCountResponse> GetCountAsync();

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        TransactionsResponse<T> GetList<T>(TransactionsRequest Request);

        /// <summary>
        /// Gets the list async.
        /// </summary>
        /// <returns>The list async.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task<TransactionsResponse<T>> GetListAsync<T>(TransactionsRequest Request);

        /// <summary>
        /// Send the specified Request.
        /// </summary>
        /// <returns>The send.</returns>
        /// <param name="Request">Request.</param>
        SendTransactionResponse Send(SendTransactionRequest Request);

        /// <summary>
        /// Sends the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="Request">Request.</param>
        Task<SendTransactionResponse> SendAsync(SendTransactionRequest Request);

        /// <summary>
        /// Gets the unconfirmed transactions.
        /// </summary>
        /// <returns>The unconfirmed transactions.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        TransactionsResponse<T> GetUnconfirmedTransactions<T>();

        /// <summary>
        /// Gets the unconfirmed transactions async.
        /// </summary>
        /// <returns>The unconfirmed transactions async.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task<TransactionsResponse<T>> GetUnconfirmedTransactionsAsync<T>();

        /// <summary>
        /// Gets the unconfirmed transaction.
        /// </summary>
        /// <returns>The unconfirmed transaction.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        GetTransactionResponse<T> GetUnconfirmedTransaction<T>(GetTransactionRequest Request);

        /// <summary>
        /// Gets the unconfirmed transaction async.
        /// </summary>
        /// <returns>The unconfirmed transaction async.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task<GetTransactionResponse<T>> GetUnconfirmedTransactionAsync<T>(GetTransactionRequest Request);
    }
}
