using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class CreateAccountResult : IActionResult
    {
        [JsonProperty("account")]
        public RaiAddress AddressNumber { get; set; }
    }
}
