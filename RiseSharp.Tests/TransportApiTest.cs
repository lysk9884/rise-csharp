﻿using System;
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

        string _liveNetHash = "e90d39ac200c495b97deb6d9700745177c7fc4aa80a404108ec820cbeced054c";

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
