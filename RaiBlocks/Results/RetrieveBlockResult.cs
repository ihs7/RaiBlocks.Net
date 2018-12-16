using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class RetrieveBlockResult : IActionResult
    {
        [JsonConverter(typeof(JsonParseConverter<RetrieveBlockContent>))]
        [JsonProperty("contents")]
        public RetrieveBlockContent Contents { get; set; }
    }

    public class RetrieveBlockContent
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
