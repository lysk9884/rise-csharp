using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Base;
using RiseSharp.Apis.Interfaces;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Apis.Constants;

namespace RiseSharp.Apis
{
    public class BlocksApi : BaseApi, IBlocksApi
    {
        public GetBlockResponse GetBlock(GetBlockRequest BlockRequest)
            => GetBlockAsync(BlockRequest).GetAwaiter().GetResult();

        public Task<GetBlockResponse> GetBlockAsync(GetBlockRequest BlockRequest)
            => GetSimpleJsonAsync<GetBlockResponse, GetBlockRequest>(BlockRequest, Api.GetBlocksBlock);

        public GetBlocksResponse GetBlocks(GetBlocksRequest Request)
            => GetBlocksAsync(Request).GetAwaiter().GetResult();

        public Task<GetBlocksResponse> GetBlocksAsync(GetBlocksRequest Request)
            => GetSimpleJsonAsync<GetBlocksResponse, GetBlocksRequest>(Request, Api.GetBlocks);

        public FeeResponse GetFee()
            => GetFeeAsync().GetAwaiter().GetResult();

        public Task<FeeResponse> GetFeeAsync()
            => GetSimpleJsonAsync<FeeResponse>(Api.GetBlocksFee);

        public GetFeeScheduleResponse GetFeeSchedule()
            => GetFeeScheduleAsync().GetAwaiter().GetResult();

        public Task<GetFeeScheduleResponse> GetFeeScheduleAsync()
            => GetSimpleJsonAsync<GetFeeScheduleResponse>(Api.GetFeeSchedule);

        public HeightResponse GetHeight()
            => GetHeightAsync().GetAwaiter().GetResult();

        public Task<HeightResponse> GetHeightAsync()
            => GetSimpleJsonAsync<HeightResponse>(Api.GetBlocksHeight);

        public MilestoneResponse GetMilestone()
            => GetMilestoneAsync().GetAwaiter().GetResult();

        public Task<MilestoneResponse> GetMilestoneAsync()
            => GetSimpleJsonAsync<MilestoneResponse>(Api.GetBlocksMilestone);
 
        public NethashResponse GetNetHash()
            => GetNetHashAsync().GetAwaiter().GetResult();

        public Task<NethashResponse> GetNetHashAsync()
            => GetSimpleJsonAsync<NethashResponse>(Api.GetBlocksNethash);
  
        public RewardResponse GetReward()
            => GetRewardAsync().GetAwaiter().GetResult();

        public Task<RewardResponse> GetRewardAsync()
            => GetSimpleJsonAsync<RewardResponse>(Api.GetBlocksReward);
  
        public StatusResponse GetStatus()
            => GetStatusAsync().GetAwaiter().GetResult();

        public Task<StatusResponse> GetStatusAsync()
            => GetSimpleJsonAsync<StatusResponse>(Api.GetBlocksStatus);
        
        public SupplyResponse GetSupply()
            => GetSupplyAsync().GetAwaiter().GetResult();

        public Task<SupplyResponse> GetSupplyAsync()
            => GetSimpleJsonAsync<SupplyResponse>(Api.GetBlocksSupply);
    }
}