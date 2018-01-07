using Newtonsoft.Json;
using RaiBlocks.Converters;

namespace RaiBlocks.Results
{
    public class BalanceResult
    {
        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("balance")]
        public RaiUnits.RaiRaw Balance { get; set; }

        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("pending")]
        public RaiUnits.RaiRaw Pending { get; set; }
    }
}
