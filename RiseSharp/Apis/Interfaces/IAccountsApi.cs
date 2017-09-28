using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Models;

namespace RiseSharp.Apis.Interfaces
{
    public interface IAccountsApi
    {
		/// <summary>
		/// Opens a new account using the specified secrect string
		/// </summary>
		/// <returns>AccountResponse</returns>
		/// <param name="Secret">secret the string to use to generate the new account</param>
        AccountResponse Open(OpenAccountRequest Secret);

		/// <summary>
		/// Opens a new account using the specified secrect string asynchronously
		/// </summary>
		/// <returns>Task<AccountResponse></returns>
		/// <param name="Secret">secret the string to use to generate the new account</param>
        Task<AccountResponse> OpenAsync(OpenAccountRequest Secret);

		/// <summary>
		/// Returns balance and unconfirmed balance for the specified address
		/// </summary>
		/// <returns>BalanceResponse</returns>
		/// <param name="Address">address to check</param>
        BalanceResponse GetBalance(GetBalanceRequest Address);

		/// <summary>
		/// Returns balance and unconfirmed balance for the specified address asynchronously
		/// </summary>
		/// <returns>Task<BalanceResponse></returns>
		/// <param name="Address">address to check</param>
		Task<BalanceResponse> GetBalanceAsync(GetBalanceRequest Address);

		/// <summary>
		/// Returns the address public key
		/// </summary>
		/// <returns>PublicKeyResponse</returns>
		/// <param name="Address">address to check</param>
		PublicKeyResponse GetPublicKey(GetPublicKeyRequest Address);

		/// <summary>
		/// Returns the address public key asynchronously
		/// </summary>
		/// <returns>Task<PublicKeyResponse></returns>
		/// <param name="Address">address to check</param>
		Task<PublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest Address);

		/// <summary>
		/// Generates the public key.
		/// </summary>
		/// <returns>PublicKeyResponse</returns>
		/// <param name="Secret">secret the secret to use</param>
        PublicKeyResponse GeneratePublicKey(GeneratePublicKeyRequest Secret);

		/// <summary>
		/// Generates the public key asynchronously
		/// </summary>
		/// <returns>Task<PublicKeyResponse></returns>
		/// <param name="Secret">secret the secret to use</param>
        Task<PublicKeyResponse> GeneratePublicKeyAsync(GeneratePublicKeyRequest Secret);

		/// <summary>
		/// Get Account information by its address
		/// </summary>
		/// <returns>AccountResponse</returns>
		/// <param name="Address">Address</param>
        AccountResponse GetAccount(GetAccountRequest Address);

		/// <summary>
		/// Get Account information by its address asynchronously
		/// </summary>
		/// <returns>Task<AccountResponse></returns>
		/// <param name="Address">Address</param>
        Task<AccountResponse> GetAccountAsync(GetAccountRequest Address);

		/// <summary>
		/// Get Account information by its publicKey
		/// </summary>
		/// <returns>AccountResponse</returns>
		/// <param name="PublicKey">Public key</param>
        AccountResponse GetAccountByPublicKey(GetAccountByPublicKeyRequest PublicKey);

		/// <summary>
		/// Get Account information by its publicKey asynchronously
		/// </summary>
		/// <returns>AccountResponse</returns>
		/// <param name="PublicKey">Public key</param>
        Task<AccountResponse> GetAccountByPublicKeyAsync(GetAccountByPublicKeyRequest PublicKey);

		/// <summary>
		/// Return accounts delegates by using the given address
		/// </summary>
		/// <returns>DelegatesResponse</returns>
		/// <param name="Address">Address</param>
        DelegatesResponse GetDelegates(GetDelegatesRequest Address);

		/// <summary>
		/// Return accounts delegates by using the given address asynchronously
		/// </summary>
		/// <returns>Task<DelegatesResponse></returns>
		/// <param name="Address">Address</param>
        Task<DelegatesResponse> GetDelegatesAsync(GetDelegatesRequest Address);

		/// <summary>
		/// Cast votes. The delegates array must use delegate Public Key prepended witha "+" or "-" sign wether you want to up/downvote the delegate
		/// </summary>
		/// <returns>object</returns>
		/// <param name="Request">PutDelegatesRequest</param>
		object PutDelegates(PutDelegatesRequest Request);

		/// <summary>
		/// Cast votes asynchronously. The delegates array must use delegate Public Key prepended witha "+" or "-" sign wether you want to up/downvote the delegate
		/// </summary>
		/// <returns>Task<object></returns>
		/// <param name="Request">PutDelegatesRequest</param>
		Task<object> PutDelegatesAsync(PutDelegatesRequest Request);
    }
}
