using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class GetAccountByPublicKeyResult : IActionResult
    {
        [JsonProperty("account")]
        public RaiAddress AddressNumber { get; set; }
    }
}
