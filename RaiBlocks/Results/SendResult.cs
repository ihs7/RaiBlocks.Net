using Newtonsoft.Json;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class SendResult : IActionResult
    {
        [JsonProperty("block")]
        public string Block { get; set; }
    }
}
