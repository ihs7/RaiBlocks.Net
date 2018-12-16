using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using System;

namespace RaiBlocks.Results
{
    public class ValidateAccountResult : IActionResult
    {
        [JsonProperty("valid")]
        public Int16 Valid { get; set; }

        public bool IsValid()
        {
            return Valid.Equals(1);
        }
    }
}
