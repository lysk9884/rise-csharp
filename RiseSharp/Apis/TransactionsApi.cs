using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis
{
    public class TransactionsApi : BaseApi, ITransactionsApi
    {
        public TransactionsApi():base(){ }

        public TransactionsApi(Config NetworkConfig):base(NetworkConfig){ }

        public TransactionsCountResponse GetCount()
            => GetCountAsync().GetAwaiter().GetResult();

        public Task<TransactionsCountResponse> GetCountAsync()
            => GetSimpleJsonAsync<TransactionsCountResponse>(Api.GetTransactionsCount);

        public TransactionsResponse<T> GetList<T>(TransactionsRequest Request)
            => GetListAsync<T>(Request).GetAwaiter().GetResult();

        public Task<TransactionsResponse<T>> GetListAsync<T>(TransactionsRequest Request)
            => GetSimpleJsonAsync<TransactionsResponse<T>, TransactionsRequest>(Request, Api.GetTransactions);

        public GetTransactionResponse<T> GetTransaction<T>(GetTransactionRequest Request)
            => GetTransactionAsync<T>(Request).GetAwaiter().GetResult();

        public Task<GetTransactionResponse<T>> GetTransactionAsync<T>(GetTransactionRequest Request)
            => GetSimpleJsonAsync<GetTransactionResponse<T>, GetTransactionRequest>(Request, Api.GetTransaction);

        public GetTransactionResponse<T> GetUnconfirmedTransaction<T>(GetTransactionRequest Request)
            => GetUnconfirmedTransactionAsync<T>(Request).GetAwaiter().GetResult();

        public Task<GetTransactionResponse<T>> GetUnconfirmedTransactionAsync<T>(GetTransactionRequest Request)
            => GetSimpleJsonAsync<GetTransactionResponse<T>, GetTransactionRequest>(Request, Api.GetUnconfirmedTransaction);

        public TransactionsResponse<T> GetUnconfirmedTransactions<T>()
            => GetUnconfirmedTransactionsAsync<T>().GetAwaiter().GetResult();

        public Task<TransactionsResponse<T>> GetUnconfirmedTransactionsAsync<T>()
            => GetSimpleJsonAsync<TransactionsResponse<T>>(Api.GetUnconfirmedTransactions);

        public SendTransactionResponse Send(SendTransactionRequest Request)
            => SendAsync(Request).GetAwaiter().GetResult();

        public Task<SendTransactionResponse> SendAsync(SendTransactionRequest Request)
            => PutSimpleJsonAsync<SendTransactionResponse, SendTransactionRequest>(Request, Api.PutAddTransaction);
    }
}
