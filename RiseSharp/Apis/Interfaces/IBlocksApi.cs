using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;
using RiseSharp.Models;

namespace RiseSharp.Apis.Interfaces
{
    public interface IBlocksApi
    {
        /// <summary>
        /// Gets the block.
        /// </summary>
        /// <returns>The block.</returns>
        /// <param name="BlockRequest">Block request.</param>
        GetBlockResponse GetBlock(GetBlockRequest BlockRequest);

        /// <summary>
        /// Gets the block async.
        /// </summary>
        /// <returns>The block async.</returns>
        /// <param name="BlockRequest">Block request.</param>
        Task<GetBlockResponse> GetBlockAsync(GetBlockRequest BlockRequest);

        /// <summary>
        /// Gets the block milestone.
        /// </summary>
        /// <returns>The block milestone.</returns>
        MilestoneResponse GetMilestone();

        /// <summary>
        /// Gets the block milestone async.
        /// </summary>
        /// <returns>The block milestone async.</returns>
        Task<MilestoneResponse> GetMilestoneAsync();

        /// <summary>
        /// Gets the block net hash.
        /// </summary>
        /// <returns>The block net hash.</returns>
        NethashResponse GetNetHash();

        /// <summary>
        /// Gets the block net hash async.
        /// </summary>
        /// <returns>The block net hash async.</returns>
        Task<NethashResponse> GetNetHashAsync();

        /// <summary>
        /// Gets the height of the block.
        /// </summary>
        /// <returns>The block height.</returns>
        HeightResponse GetHeight();

        /// <summary>
        /// Gets the block height async.
        /// </summary>
        /// <returns>The block height async.</returns>
        Task<HeightResponse> GetHeightAsync();

        /// <summary>
        /// Gets the block status.
        /// </summary>
        /// <returns>The block status.</returns>
        StatusResponse GetStatus();

        /// <summary>
        /// Gets the block status async.
        /// </summary>
        /// <returns>The block status async.</returns>
        Task<StatusResponse> GetStatusAsync();

        /// <summary>
        /// Gets the block supply.
        /// </summary>
        /// <returns>The block supply.</returns>
        SupplyResponse GetSupply();

        /// <summary>
        /// Gets the block supply async.
        /// </summary>
        /// <returns>The block supply async.</returns>
        Task<SupplyResponse> GetSupplyAsync();

        /// <summary>
        /// Gets the block reward.
        /// </summary>
        /// <returns>The block reward.</returns>
        RewardResponse GetReward();

        /// <summary>
        /// Gets the block reward async.
        /// </summary>
        /// <returns>The block reward async.</returns>
        Task<RewardResponse> GetRewardAsync();

        /// <summary>
        /// Gets the fee.
        /// </summary>
        /// <returns>The fee.</returns>
        FeeResponse GetFee();

        /// <summary>
        /// Gets the fee async.
        /// </summary>
        /// <returns>The fee async.</returns>
        Task<FeeResponse> GetFeeAsync();

        /// <summary>
        /// Gets the fee schedule.
        /// </summary>
        /// <returns>The fee schedule.</returns>
        GetFeeScheduleResponse GetFeeSchedule();

        /// <summary>
        /// Gets the fee schedule async.
        /// </summary>
        /// <returns>The fee schedule async.</returns>
        Task<GetFeeScheduleResponse> GetFeeScheduleAsync();

        /// <summary>
        /// Gets the blocks.
        /// </summary>
        /// <returns>The blocks.</returns>
        /// <param name="req">Req.</param>
        GetBlocksResponse GetBlocks(GetBlocksRequest req);

        /// <summary>
        /// Gets the blocks async.
        /// </summary>
        /// <returns>The blocks async.</returns>
        /// <param name="req">Req.</param>
        Task<GetBlocksResponse> GetBlocksAsync(GetBlocksRequest req);
    }
}
