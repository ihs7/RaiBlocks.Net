using Newtonsoft.Json;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class WorkGenerateResult : IActionResult
    {

        [JsonProperty("work")]
        public string Work { get; set; }
    }
}
