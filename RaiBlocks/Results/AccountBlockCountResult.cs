using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class AccountBlockCountResult : IActionResult
    {
        [JsonProperty("block_count")]
        public int BlockCount { get; set; }
    }
}
