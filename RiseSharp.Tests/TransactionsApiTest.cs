using System;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using Xunit;

namespace RiseSharp.Tests
{
    public class TransactionsApiTest
    {
        TransactionsApi api = new TransactionsApi(new Config(ApiParams.DefaultHost, true, null));

        [Fact]
        public void GetAccountTest()
        {
            var response = api.GetCount();
            Assert.True(response.Success);
        }

        [Fact]
        public void GetListTest()
        {
            var response = api.GetList<object>(new Apis.Requests.TransactionsRequest 
            {
                SenderPublickey = AccountApiTests._livePubKey
            });

            Assert.True(response.Success);
            Assert.NotNull(response.Transactions);
        }

        [Fact]
        public void GetTransactionTest() //TODO
        {
            var response = api.GetTransaction<object>(new Apis.Requests.GetTransactionRequest {
                Id = "transaction id"
            });

            Assert.True(response.Success);
        }

        [Fact]
        public void GetUnconfirmedTransactionTest() //TODO
		{
            var response = api.GetUnconfirmedTransaction<object>(new Apis.Requests.GetTransactionRequest
			{
				Id = "transaction id"
			});

			Assert.True(response.Success);
		}

		[Fact]
		public void GetUnconfirmedTransactionsTest()
		{
            var response = api.GetUnconfirmedTransactions<object>();
            Assert.NotNull(response.Transactions);
			Assert.True(response.Success);
		}

        [Fact]
        public void SendTest() //TODO
        {
            var response = api.Send(new Apis.Requests.SendTransactionRequest {
                Secret = AccountApiTests._liveSecret,
                Amount = 1,
                PublicKey = AccountApiTests._livePubKey
            });

            Assert.True(response.Success);
        }


    }
}
