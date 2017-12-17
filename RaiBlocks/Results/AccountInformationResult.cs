using Newtonsoft.Json;
using RaiBlocks.Converters;
using RaiBlocks.ValueObjects;
using System;

namespace RaiBlocks.Results
{
    public class AccountInformationResult
    {
        [JsonProperty("frontier")]
        public string Frontier { get; set; }

        [JsonProperty("open_block")]
        public string OpenBlock { get; set; }

        [JsonProperty("representative_block")]
        public string RepresentativeBlock { get; set; }

        [JsonConverter(typeof(RawToXrbConverter))]
        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("modified_timestamp")]
        public DateTime ModifiedTimestamp { get; set; }

        [JsonProperty("block_count")]
        public int BlockCount { get; set; }

        [JsonProperty("representative")]
        public RaiAddress Representative { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonConverter(typeof(RawToXrbConverter))]
        [JsonProperty("pending")]
        public decimal Pending { get; set; }
    }
}
