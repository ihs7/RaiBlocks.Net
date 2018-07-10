using Newtonsoft.Json;

namespace RaiBlocks.Results
{
    public class AccountKeyResult
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
