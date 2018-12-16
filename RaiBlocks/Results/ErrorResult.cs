using Newtonsoft.Json;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class ErrorResult : IActionResultWithError
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
