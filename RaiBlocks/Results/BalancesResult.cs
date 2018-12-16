using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using System.Collections.Generic;

namespace RaiBlocks.Results
{
    public class BalancesResult : IActionResult
    {
        [JsonProperty("balances")]
        public Dictionary<string, BalanceResult> Balances { get; set; }
    }
}
