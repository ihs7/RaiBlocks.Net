using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Actions
{
    public class BlockCreate : IAction<BlockCreateResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "block_create";

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public BlockType Type { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("account")]
        public string AccountNumber { get; set; }

        [JsonProperty("representative")]
        public string RepresentativeNumber { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("wallet")]
        public string Wallet { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("balance")]
        public RaiUnits.RaiRaw Balance { get; set; }

        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("amount")]
        public RaiUnits.RaiRaw Amount { get; set; }
    }
}
