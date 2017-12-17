using Newtonsoft.Json;
using RaiBlocks.Converters;

namespace RaiBlocks.Results
{
    public class BalanceResult
    {
        [JsonConverter(typeof(RawToXrbConverter))]
        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonConverter(typeof(RawToXrbConverter))]
        [JsonProperty("pending")]
        public decimal Pending { get; set; }
    }
}
