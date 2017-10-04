using System;
using System.Collections.Generic;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using RiseSharp.Models;
using Xunit;

namespace RiseSharp.Tests
{
    public class TransportApiTest
    {
        TransportApi api = new TransportApi(new Config(ApiParams.DefaultHost, true, null));

        string _liveNetHash = "cd8171332c012514864edd8eb6f68fc3ea6cb2afbaf21c56e12751022684cea5";

        string _liveVersion = "0.1.2";


        [Fact]
        public void GetPeerHeightTest()
        {
            var response = api.GetPeerHeight(new Apis.Headers.TransportHeaders
            {
                NetHash = _liveNetHash,
                Version = _liveVersion
            });
            Assert.True(response.Success);
        }

        [Fact]
        public void GetPeerListTest()
        {
            var response = api.GetPeersList(new Apis.Headers.TransportHeaders 
            {
				NetHash = _liveNetHash,
				Version = _liveVersion
            });

            Assert.True(response.Success);
        }

        [Fact]
        public void PingTest()
        {
            var response = api.Ping(new Apis.Headers.TransportHeaders 
            {
				NetHash = _liveNetHash,
				Version = _liveVersion
            });

            Assert.True(response.Success);
        }

        [Fact]
        public void PostSignatureTest()
        {
            var response = api.PostSignature(new Apis.Requests.PostSignatureRequest 
            {
                Signature = new Signature{
                    TransactionId = "tr id",
                    SignatureId = "sig id"
                }
            });

            Assert.True(response.Success);
        }

		[Fact]
		public void PostSignaturesTest()
		{
			var response = api.PostSignatures(new Apis.Requests.PostSignaturesRequest
			{
                Signatures = new List<Signature>{ new Signature
                {
                    TransactionId = "tr id",
                    SignatureId = "sig id"
                }
                }
			});

            Assert.True(response.Success);
		}

        [Fact]
        public void PostTransactionTest()
        {
            var response = api.PostTransaction(new Apis.Requests.PostTransactionRequest<object> 
            {
                Transaction = new Transaction<object>{
                    //params TODO
                }
            });

            Assert.True(response.Success);
        }

		[Fact]
		public void PostTransactionsTest()
		{
			var response = api.PostTransactions(new Apis.Requests.PostTransactionsRequest<object>
			{
                Transactions = new List<Transaction<object>>
                {
					new Transaction<object>
		                {
                            //params TODO
                        }
                } .ToArray()
			});

            Assert.True(response.Success);
		}
    }
}
