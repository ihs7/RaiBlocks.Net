using Newtonsoft.Json;

namespace RaiBlocks.Results
{
    public class AccountHistoryResult
    {
        [JsonProperty("history")]
        public SingleAccountHistory[] Entries { get; set; }
    }

    public class SingleAccountHistory
    {
        [JsonProperty("hash")]
        public string Frontier { get; set; }

        [JsonProperty("type")]
        public string OpenBlock { get; set; }

        [JsonProperty("account")]
        public string RepresentativeBlock { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }
}
