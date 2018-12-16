using Newtonsoft.Json;

namespace RaiBlocks.Results
{
    public class ProcessBlockResult: ErrorResult
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
