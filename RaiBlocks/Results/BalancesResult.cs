using Newtonsoft.Json;
using RaiBlocks.Converters;
using System.Collections.Generic;

namespace RaiBlocks.Results
{
    public class BalancesResult
    {
        //[JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("balances")]
        public Dictionary<string, BalanceResult> Balances { get; set; }
    }
}
