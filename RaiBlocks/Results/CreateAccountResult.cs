using Newtonsoft.Json;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class CreateAccountResult
    {
        [JsonProperty("account")]
        public RaiAddress AddressNumber { get; set; }
    }
}
