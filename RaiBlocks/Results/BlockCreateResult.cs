using Newtonsoft.Json;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class BlockCreateResult : IActionResult
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }
    }
}
