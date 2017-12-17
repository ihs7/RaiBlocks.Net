using Newtonsoft.Json;

namespace RaiBlocks.Results
{
    public class SendResult
    {
        [JsonProperty("block")]
        public string Block { get; set; }
    }
}
