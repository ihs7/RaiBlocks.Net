using Newtonsoft.Json;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class BalanceResult : IActionResult
    {
        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("balance")]
        public RaiUnits.RaiRaw Balance { get; set; }

        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("pending")]
        public RaiUnits.RaiRaw Pending { get; set; }
    }
}
