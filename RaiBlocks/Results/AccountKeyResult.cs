using Newtonsoft.Json;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class AccountKeyResult : IActionResult
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
