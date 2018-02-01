using Newtonsoft.Json;
using RaiBlocks.Converters;
using System.Collections.Generic;

namespace RaiBlocks.Results
{
    public class BalancesResult
    {
        [JsonProperty("balances")]
        public Dictionary<string, BalanceResult> Balances { get; set; }
    }
}
