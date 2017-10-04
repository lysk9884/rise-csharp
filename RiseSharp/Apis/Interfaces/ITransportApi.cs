using System.Threading.Tasks;
using RiseSharp.Apis.Headers;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Interfaces
{
    public interface ITransportApi
    {
        /// <summary>
        /// Gets the height of the peer.
        /// </summary>
        /// <returns>The peer height.</returns>
        /// <param name="Request">Request.</param>
        GetPeerHeightResponse GetPeerHeight(TransportHeaders Request);

        /// <summary>
        /// Gets the peer height async.
        /// </summary>
        /// <returns>The peer height async.</returns>
        /// <param name="Request">Request.</param>
        Task<GetPeerHeightResponse> GetPeerHeightAsync(TransportHeaders Request);

        /// <summary>
        /// Gets the peers list.
        /// </summary>
        /// <returns>The peers list.</returns>
        /// <param name="Request">Request.</param>
        PeersGetListResponse GetPeersList(TransportHeaders Request);

        /// <summary>
        /// Gets the peers list async.
        /// </summary>
        /// <returns>The peers list async.</returns>
        /// <param name="Request">Request.</param>
        Task<PeersGetListResponse> GetPeersListAsync(TransportHeaders Request);

        /// <summary>
        /// Ping the specified Request.
        /// </summary>
        /// <returns>The ping.</returns>
        /// <param name="Request">Request.</param>
        BaseApiResponse Ping(TransportHeaders Request);

        /// <summary>
        /// Pings the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="Request">Request.</param>
        Task<BaseApiResponse> PingAsync(TransportHeaders Request);

        /// <summary>
        /// Posts the transaction.
        /// </summary>
        /// <returns>The transaction.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        BaseApiResponse PostTransaction<T>(PostTransactionRequest<T> Request);

        /// <summary>
        /// Posts the transaction async.
        /// </summary>
        /// <returns>The transaction async.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task<BaseApiResponse> PostTransactionAsync<T>(PostTransactionRequest<T> Request);

        /// <summary>
        /// Posts the transactions.
        /// </summary>
        /// <returns>The transactions.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
		BaseApiResponse PostTransactions<T>(PostTransactionsRequest<T> Request);

        /// <summary>
        /// Posts the transactions async.
        /// </summary>
        /// <returns>The transactions async.</returns>
        /// <param name="Request">Request.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
		Task<BaseApiResponse> PostTransactionsAsync<T>(PostTransactionsRequest<T> Request);

        /// <summary>
        /// Posts the signature.
        /// </summary>
        /// <returns>The signature.</returns>
        /// <param name="Request">Request.</param>
        BaseApiResponse PostSignature(PostSignatureRequest Request);

        /// <summary>
        /// Posts the signature async.
        /// </summary>
        /// <returns>The signature async.</returns>
        /// <param name="Request">Request.</param>
        Task<BaseApiResponse> PostSignatureAsync(PostSignatureRequest Request);

        /// <summary>
        /// Posts the signatures.
        /// </summary>
        /// <returns>The signatures.</returns>
        /// <param name="Request">Request.</param>
		BaseApiResponse PostSignatures(PostSignaturesRequest Request);

        /// <summary>
        /// Posts the signatures async.
        /// </summary>
        /// <returns>The signatures async.</returns>
        /// <param name="Request">Request.</param>
		Task<BaseApiResponse> PostSignaturesAsync(PostSignaturesRequest Request);
    }
}
