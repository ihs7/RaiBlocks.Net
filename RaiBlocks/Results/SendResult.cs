using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class SendResult : IActionResult
    {
        [JsonProperty("block")]
        public RaiBlock Block { get; set; }
    }
}
