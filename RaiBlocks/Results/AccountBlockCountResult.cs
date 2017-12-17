using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RaiBlocks.Results
{
    public class AccountBlockCountResult
    {
        [JsonProperty("block_count")]
        public int BlockCount { get; set; }
    }
}
