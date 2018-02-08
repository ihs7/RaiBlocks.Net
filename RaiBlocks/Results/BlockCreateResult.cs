using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Results
{
    public class BlockCreateResult
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }
    }
}
