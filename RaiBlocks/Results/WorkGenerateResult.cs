using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Results
{
    public class WorkGenerateResult
    {

        [JsonProperty("work")]
        public string Work { get; set; }
    }
}
