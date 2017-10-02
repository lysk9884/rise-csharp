using System;
using System.Threading.Tasks;
using RiseSharp.Apis.Requests;
using RiseSharp.Apis.Responses;

namespace RiseSharp.Apis.Interfaces
{
    public interface IPeersApi
    {
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="Request">Request.</param>
        PeersGetListResponse GetList(PeersGetListRequest Request);

        /// <summary>
        /// Gets the list async.
        /// </summary>
        /// <returns>The list async.</returns>
        /// <param name="Request">Request.</param>
        Task<PeersGetListResponse> GetListAsync(PeersGetListRequest Request);

        /// <summary>
        /// Gets the peer by port ip.
        /// </summary>
        /// <returns>The peer by port ip.</returns>
        /// <param name="Request">Request.</param>
        GetPeerByPortIpResponse GetPeerByPortIp(GetPeerByPortIpRequest Request);

        /// <summary>
        /// Gets the peer by port ip async.
        /// </summary>
        /// <returns>The peer by port ip async.</returns>
        /// <param name="Request">Request.</param>
        Task<GetPeerByPortIpResponse> GetPeerByPortIpAsync(GetPeerByPortIpRequest Request);

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <returns>The version.</returns>
        GetPeerVersionResponse GetVersion();

        /// <summary>
        /// Gets the version async.
        /// </summary>
        /// <returns>The version async.</returns>
        Task<GetPeerVersionResponse> GetVersionAsync();
    }
}
