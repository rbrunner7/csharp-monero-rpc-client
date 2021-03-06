﻿using Monero.Client.Network;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Monero.Client.Daemon.POD.Responses
{
    internal class AlternateChainResponse : RpcResponse
    {
        [JsonPropertyName("result")]
        public AlternateChainResult Result { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class AlternateChainResult
    {
        [JsonPropertyName("chains")]
        public List<Chain> Chains { get; set; } = new List<Chain>();
    }
}