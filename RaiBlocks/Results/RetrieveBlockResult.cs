using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RaiBlocks.Converters;
using RaiBlocks.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Results
{
    public class RetrieveBlockResult
    {
        [JsonConverter(typeof(JsonParseConverter<RetrieveBlock>))]
        [JsonProperty("contents")]
        public RetrieveBlock Contents { get; set; }
    }

    public class RetrieveBlock
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public BlockType Type { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("work")]
        public string Work { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
    }
}
