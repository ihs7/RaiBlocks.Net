using Newtonsoft.Json;
using RaiBlocks.Interfaces;

namespace RaiBlocks.Results
{
    public class ValidateAccountResult : IActionResult
    {
        [JsonProperty("valid")]
        public short Valid { get; set; }

        public bool IsValid() => Valid.Equals(1);
    }
}
