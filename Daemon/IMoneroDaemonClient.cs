﻿using Monero.Client.Daemon.POD;
using Monero.Client.Daemon.POD.Responses;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Monero.Client.Daemon
{
    public interface IMoneroDaemonClient : IDisposable
    {
        /// <summary>
        /// Look up how many blocks are in the longest chain known to the node.
        /// </summary>
        Task<ulong> GetBlockCountAsync(CancellationToken token = default);
        /// <summary>
        /// Block header information for the most recent block is easily retrieved with this method.
        /// </summary>
        Task<BlockHeader> GetLastBlockHeaderAsync(CancellationToken token = default);
        /// <summary>
        /// Block header information can be retrieved using either a block's hash or height.
        /// This method includes a block's hash as an input parameter to retrieve basic information about the block.
        /// </summary>
        /// <param name="hash">The block's sha256 hash.</param>
        Task<BlockHeader> GetBlockHeaderByHashAsync(string hash, CancellationToken token = default);
        /// <summary>
        /// Similar to get_block_header_by_hash above, this method includes a block's height as an input parameter to retrieve basic information about the block.
        /// </summary>
        /// <param name="height">The block's height.</param>
        Task<BlockHeader> GetBlockHeaderByHeightAsync(uint height, CancellationToken token = default);
        /// <summary>
        /// Similar to get_block_header_by_height above, but for a range of blocks.
        /// This method includes a starting block height and an ending block height as parameters to retrieve basic information about the range of blocks.
        /// </summary>
        /// <param name="startHeight">The starting block's height.</param>
        /// <param name="endHeight">The ending block's height.</param>
        Task<List<BlockHeader>> GetBlockHeaderRangeAsync(uint startHeight, uint endHeight, CancellationToken token = default);
        /// <summary>
        /// Retrieve information about incoming and outgoing connections to your node.
        /// </summary>
        Task<List<Connection>> GetConnectionsAsync(CancellationToken token = default);
        /// <summary>
        /// Retrieve general information about the state of your node and the network.
        /// </summary>
        Task<DaemonInformation> GetDaemonInformationAsync(CancellationToken token = default);
        /// <summary>
        /// Look up information regarding hard fork voting and readiness.
        /// </summary>
        Task<HardforkInformation> GetHardforkInformationAsync(CancellationToken token = default);
        /// <summary>
        /// Get list of banned IPs.
        /// </summary>
        Task<List<Ban>> GetBanInformationAsync(CancellationToken token = default);
        /// <summary>
        /// Flush tx ids from transaction pool
        /// </summary>
        /// <param name="txids">List of transactions IDs to flush from pool (all tx ids flushed if empty).</param>
        Task<string> FlushTransactionPoolAsync(IEnumerable<string> txids, CancellationToken token = default);
        /// <summary>
        /// Get a histogram of output amounts. For all amounts (possibly filtered by parameters), gives the number of outputs on the chain for that amount. RingCT outputs counts as 0 amount.
        /// </summary>
        Task<List<Histogram>> GetOutputHistogramAsync(IEnumerable<ulong> amounts, uint min_count, uint max_count, bool unlocked, uint recent_cutoff, CancellationToken token = default);
        /// <summary>
        /// Get the coinbase amount and the fees amount for n last blocks starting at particular height.
        /// </summary>
        Task<CoinbaseTransactionSumResult> GetCoinbaseTransactionSumAsync(uint height, uint count, CancellationToken token = default);
        /// <summary>
        /// Give the node current version.
        /// </summary>
        Task<uint> GetVersionAsync(CancellationToken token = default);
        /// <summary>
        /// Gives an estimation on fees per byte.
        /// </summary>
        Task<ulong> GetFeeEstimateAsync(uint grace_blocks, CancellationToken token = default);
        /// <summary>
        /// Display alternative chains seen by the node.
        /// </summary>
        Task<List<Chain>> GetAlternateChainsAsync(CancellationToken token = default);
        /// <summary>
        /// Relay a list of transaction IDs.
        /// </summary>
        Task<string> RelayTransactionsAsync(IEnumerable<string> txids, CancellationToken token = default);
        /// <summary>
        /// Get synchronisation informations.
        /// </summary>
        Task<SyncronizationInformation> SyncInformationAsync(CancellationToken token = default);
        /// <summary>
        /// Similar to get_block_header_by_hash above, this method includes a block's height as an input parameter to retrieve basic information about the block.
        /// </summary>
        Task<Block> GetBlockAsync(uint height, CancellationToken token = default);
        /// <summary>
        /// Block header information can be retrieved using either a block's hash or height.
        /// This method includes a block's hash as an input parameter to retrieve basic information about the block.
        /// </summary>
        Task<Block> GetBlockAsync(string hash, CancellationToken token = default);
        /// <summary>
        /// Ban another node by IP.
        /// </summary>
        Task<string> SetBansAsync(IEnumerable<(string host, ulong ip, bool ban, uint seconds)> bans, CancellationToken token = default);
    }
}
