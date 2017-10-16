using System;
using System.Collections.Generic;
using RiseSharp.Apis;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Responses;
using RiseSharp.Models;
using Xunit;

namespace RiseSharp.Tests
{
    public class BlocksApiTests
    {
  //      BlocksApi api = new BlocksApi(new Config(ApiParams.DefaultHost, true, null));
  //      IList<Block> TestBlocks;

  //      [Fact]
  //      public void GetBlocksTest(){
  //          var response = api.GetBlocks(new Apis.Requests.GetBlocksRequest());
  //          Assert.True(response.Success);
  //      }

  //      public IList<Block> GetBlocks()
  //      {
  //          if(TestBlocks == null){
  //              TestBlocks = api.GetBlocks(new Apis.Requests.GetBlocksRequest()).Blocks;
  //          }
  //          return TestBlocks;
  //      }

  //      [Fact]
  //      public void GetBlockTest(){
  //          var response = api.GetBlock(new Apis.Requests.GetBlockRequest
  //          {
  //              Id = GetBlocks()[0].Id
  //          });
  //          Assert.True(response.Success);
  //      }

  //      [Fact]
  //      public void GetFeeTest(){
  //          var response = api.GetFee();
  //          Assert.True(response.Success);
  //      }

		//[Fact]
		//public void GetFeeScheduleTest()
		//{
		//	var response = api.GetFeeSchedule();
		//	Assert.True(response.Success);
		//}

		//[Fact]
		//public void GetHeightTest()
		//{
		//	var response = api.GetHeight();
		//	Assert.True(response.Success);
		//}

		//[Fact]
		//public void GetMilestone()
		//{
  //          var response = api.GetMilestone();
		//	Assert.True(response.Success);
		//}

		//[Fact]
		//public void GetNetHashTest()
		//{
  //          var response = api.GetNetHash();
		//	Assert.True(response.Success);
  //          Assert.NotNull(response.Nethash);
		//}

		//[Fact]
		//public void GetRewardTest()
		//{
  //          var response = api.GetReward();
		//	Assert.True(response.Success);
		//}

		//[Fact]
		//public void GetStatusTest()
		//{
  //          var response = api.GetStatus();
		//	Assert.True(response.Success);
		//}

		//[Fact]
		//public void GetSupplyTest()
		//{
  //          var response = api.GetSupply();
		//	Assert.True(response.Success);
		//}
    }
}
