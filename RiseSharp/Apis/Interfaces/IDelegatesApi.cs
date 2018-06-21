using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Models;

namespace RiseSharp.Apis.Interfaces
{
    public interface IDelegatesApi
    {
        /// <summary>
        /// Enable this instance.
        /// </summary>
        /// <returns>The enable.</returns>
        Transaction<Models.Delegate> Enable(DelegatesEnableRequest Request);

        /// <summary>
        /// Enables the async.
        /// </summary>
        /// <returns>The async.</returns>
        Task<Transaction<Models.Delegate>> EnableAsync(DelegatesEnableRequest Request);

        /// <summary>
        /// Gets the list async.
        /// </summary>
        /// <returns>The list async.</returns>
        Task<GetDelegatesResponse> GetListAsync();

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>The list.</returns>
        GetDelegatesResponse GetList();

        /// <summary>
        /// Gets the name of the by user.
        /// </summary>
        /// <returns>The by user name.</returns>
        /// <param name="Request">Request.</param>
        DelegateResponse GetByUserName(UserNameRequest Request);

        /// <summary>
        /// Gets the by user name async.
        /// </summary>
        /// <returns>The by user name async.</returns>
        /// <param name="Request">Request.</param>
		Task<DelegateResponse> GetByUserNameAsync(UserNameRequest Request);

        /// <summary>
        /// Gets the by public key.
        /// </summary>
        /// <returns>The by public key.</returns>
        /// <param name="Request">Request.</param>
        DelegateResponse GetByPublicKey(PublicKeyRequest Request);

        /// <summary>
        /// Gets the by public key async.
        /// </summary>
        /// <returns>The by public key async.</returns>
        /// <param name="Request">Request.</param>
        Task<DelegateResponse> GetByPublicKeyAsync(PublicKeyRequest Request);

        /// <summary>
        /// Gets the voters.
        /// </summary>
        /// <returns>The voters.</returns>
        /// <param name="Request">Request.</param>
        GetVotersResponse GetVoters(GetVotersRequest Request);

        /// <summary>
        /// Gets the voters async.
        /// </summary>
        /// <returns>The voters async.</returns>
        /// <param name="Request">Request.</param>
        Task<GetVotersResponse> GetVotersAsync(GetVotersRequest Request);

        /// <summary>
        /// Toggles the forging.
        /// </summary>
        /// <returns>The forging.</returns>
        /// <param name="Request">Request.</param>
        /// <param name="enable">If set to <c>true</c> enable.</param>
        ToggleForgingResponse ToggleForging(ToggleForgingRequest Request, bool enable);

        /// <summary>
        /// Toggles the forging async.
        /// </summary>
        /// <returns>The forging async.</returns>
        /// <param name="Request">Request.</param>
        /// <param name="enable">If set to <c>true</c> enable.</param>
        Task<ToggleForgingResponse> ToggleForgingAsync(ToggleForgingRequest Request, bool enable);

        /// <summary>
        /// Gets the delegate forging account.
        /// </summary>
        /// <returns>The delegate forging account.</returns>
        /// <param name="Request">Request.</param>
        ForgetByAccountResponse GetForgetByAccount(ForgetByAccountRequest Request);

        /// <summary>
        /// Gets the delegate forging account async.
        /// </summary>
        /// <returns>The delegate forging account async.</returns>
        /// <param name="Request">Request.</param>
        Task<ForgetByAccountResponse> GetForgetByAccountAsync(ForgetByAccountRequest Request);

        /// <summary>
        /// Gets the forging status.
        /// </summary>
        /// <returns>The forging status.</returns>
        /// <param name="Request">Request.</param>
        GetForgingStatusResponse GetForgingStatus(GetForgingStatusRequest Request);

        /// <summary>
        /// Gets the forging status async.
        /// </summary>
        /// <returns>The forging status async.</returns>
        /// <param name="Request">Request.</param>
        Task<GetForgingStatusResponse> GetForgingStatusAsync(GetForgingStatusRequest Request);

        /// <summary>
        /// Gets the next forgers.
        /// </summary>
        /// <returns>The next forgers.</returns>
        /// <param name="Request">Request.</param>
        GetNextForgersResponse GetNextForgers(GetNextForgersRequest Request);

        /// <summary>
        /// Gets the next forgers async.
        /// </summary>
        /// <returns>The next forgers async.</returns>
        /// <param name="Request">Request.</param>
        Task<GetNextForgersResponse> GetNextForgersAsync(GetNextForgersRequest Request);

	}
}
