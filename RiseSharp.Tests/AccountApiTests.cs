using System;
using RiseSharp.Apis;
using Xunit;

namespace RiseSharp.Tests
{
    public class AccountApiTests
    {

		string _secret = "cabbage chief join task universe hello grab slush page exit update brisk";
        //string _secondSecret = "process sheriff sea august atom parrot immune finger ticket clean crater celery";

        [Fact]
        public void GeneratePublicKey()
        {
            var api = new AccountsApi();
            var balance = api.GeneratePublicKey(new Apis.Requests.GeneratePublicKeyRequest
            {
                Secret = _secret
            });
            Assert.Null(balance);
        }
    }
}
