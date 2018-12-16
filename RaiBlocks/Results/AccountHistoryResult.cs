using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class AccountHistoryResult : IActionResult
    {
        [JsonProperty("history")]
        public SingleAccountHistory[] Entries { get; set; }
    }

    public class SingleAccountHistory
    {
        [JsonProperty("hash")]
        public string Frontier { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public BlockType Type { get; set; }

        [JsonProperty("account")]
        public RaiBlock RepresentativeBlock { get; set; }

        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("amount")]
        public RaiUnits.RaiRaw Amount { get; set; }
    }
}
