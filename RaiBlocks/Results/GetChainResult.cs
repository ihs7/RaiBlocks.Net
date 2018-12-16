using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;
using System.Collections.Generic;

namespace RaiBlocks.Results
{
    public class GetChainResult : IActionResult
    {
        [JsonProperty("blocks")]
        public IEnumerable<RaiBlock> Blocks { get; set; }
    }
}
