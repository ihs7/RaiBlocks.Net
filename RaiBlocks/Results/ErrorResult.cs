using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Results
{
    public class ErrorResult
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
