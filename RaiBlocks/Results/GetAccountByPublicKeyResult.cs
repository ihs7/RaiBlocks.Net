using Newtonsoft.Json;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class GetAccountByPublicKeyResult
    {
        [JsonProperty("account")]
        public RaiAddress AddressNumber { get; set; }
    }
}
