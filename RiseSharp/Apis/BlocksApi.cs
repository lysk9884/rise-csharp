﻿using System;
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
        public BlocksApi():base(){ }

        public BlocksApi(Config NetworkConfig):base(NetworkConfig){ }

        public GetBlockResponse GetBlock(GetBlockRequest BlockRequest)
            => GetBlockAsync(BlockRequest).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<GetBlockResponse> GetBlockAsync(GetBlockRequest BlockRequest)
            => GetSimpleJsonAsync<GetBlockResponse, GetBlockRequest>(BlockRequest, Api.GetBlocksBlock);

        public GetBlocksResponse GetBlocks(GetBlocksRequest Request)
            => GetBlocksAsync(Request).ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<GetBlocksResponse> GetBlocksAsync(GetBlocksRequest Request)
            => GetSimpleJsonAsync<GetBlocksResponse, GetBlocksRequest>(Request, Api.GetBlocks);

        public FeeResponse GetFee()
            => GetFeeAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<FeeResponse> GetFeeAsync()
            => GetSimpleJsonAsync<FeeResponse>(Api.GetBlocksFee);

        public GetFeeScheduleResponse GetFeeSchedule()
            => GetFeeScheduleAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<GetFeeScheduleResponse> GetFeeScheduleAsync()
            => GetSimpleJsonAsync<GetFeeScheduleResponse>(Api.GetFeeSchedule);

        public HeightResponse GetHeight()
            => GetHeightAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<HeightResponse> GetHeightAsync()
            => GetSimpleJsonAsync<HeightResponse>(Api.GetBlocksHeight);

        public MilestoneResponse GetMilestone()
            => GetMilestoneAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<MilestoneResponse> GetMilestoneAsync()
            => GetSimpleJsonAsync<MilestoneResponse>(Api.GetBlocksMilestone);
 
        public NethashResponse GetNetHash()
            => GetNetHashAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<NethashResponse> GetNetHashAsync()
            => GetSimpleJsonAsync<NethashResponse>(Api.GetBlocksNethash);
  
        public RewardResponse GetReward()
            => GetRewardAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<RewardResponse> GetRewardAsync()
            => GetSimpleJsonAsync<RewardResponse>(Api.GetBlocksReward);
  
        public StatusResponse GetStatus()
            => GetStatusAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<StatusResponse> GetStatusAsync()
            => GetSimpleJsonAsync<StatusResponse>(Api.GetBlocksStatus);
        
        public SupplyResponse GetSupply()
            => GetSupplyAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        public Task<SupplyResponse> GetSupplyAsync()
            => GetSimpleJsonAsync<SupplyResponse>(Api.GetBlocksSupply);
    }
}