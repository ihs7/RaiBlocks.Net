using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class BlockCreateResult : IActionResult
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("block")]
        public RaiBlock Block { get; set; }
    }
}
