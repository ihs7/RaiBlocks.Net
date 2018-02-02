using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Results
{
    public class ProcessBlockResult: ErrorResult
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
