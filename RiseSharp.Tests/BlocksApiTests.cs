using System;
using System.Collections.Generic;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Responses;
using RiseSharp.Models;
using RiseSharp.Tests.Attrs;
using Xunit;

namespace RiseSharp.Tests
{
    [TestCaseOrderer("RiseSharp.Tests.Attrs.PriorityOrderer", "RiseSharp.Tests")]
    public class BlocksApiTests
    {
        BlocksApi api = new BlocksApi(new Config(ApiParams.DefaultHost, true, null));
        IList<Block> TestBlocks;

        [Fact, TestPriority(0)]
        public void GetBlocksTest(){
            var response = api.GetBlocks(new Apis.Requests.GetBlocksRequest());
            Assert.True(response.Success);
        }

        public IList<Block> GetBlocks()
        {
            if(TestBlocks == null){
                TestBlocks = api.GetBlocks(new Apis.Requests.GetBlocksRequest()).Blocks;
            }
            return TestBlocks;
        }

        [Fact, TestPriority(1)]
        public void GetBlockTest(){
            var response = api.GetBlock(new Apis.Requests.GetBlockRequest
            {
                Id = GetBlocks()[0].Id
            });
            Assert.True(response.Success);
        }

        [Fact, TestPriority(2)]
        public void GetFeeTest(){
            var response = api.GetFee();
            Assert.True(response.Success);
        }

        [Fact, TestPriority(3)]
		public void GetFeeScheduleTest()
		{
			var response = api.GetFeeSchedule();
			Assert.True(response.Success);
		}

        [Fact, TestPriority(4)]
		public void GetHeightTest()
		{
			var response = api.GetHeight();
			Assert.True(response.Success);
		}

        [Fact, TestPriority(5)]
		public void GetMilestone()
		{
            var response = api.GetMilestone();
			Assert.True(response.Success);
		}

        [Fact, TestPriority(6)]
		public void GetNetHashTest()
		{
            var response = api.GetNetHash();
			Assert.True(response.Success);
            Assert.NotNull(response.Nethash);
		}

        [Fact, TestPriority(7)]
		public void GetRewardTest()
		{
            var response = api.GetReward();
			Assert.True(response.Success);
		}

        [Fact, TestPriority(8)]
		public void GetStatusTest()
		{
            var response = api.GetStatus();
			Assert.True(response.Success);
		}

        [Fact, TestPriority(9)]
		public void GetSupplyTest()
		{
            var response = api.GetSupply();
			Assert.True(response.Success);
		}
    }
}
