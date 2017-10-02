using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis.Interfaces
{
    public interface ILoaderApi
    {
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <returns>The status.</returns>
        GetLoaderStatusResponse GetStatus();

        /// <summary>
        /// Gets the status async.
        /// </summary>
        /// <returns>The status async.</returns>
        Task<GetLoaderStatusResponse> GetStatusAsync();

        /// <summary>
        /// Syncs the status.
        /// </summary>
        /// <returns>The status.</returns>
        LoaderSyncStatusResponse SyncStatus();

        /// <summary>
        /// Syncs the status async.
        /// </summary>
        /// <returns>The status async.</returns>
        Task<LoaderSyncStatusResponse> SyncStatusAsync();
    }
}
