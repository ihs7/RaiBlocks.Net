using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Actions
{
    public class RetrieveBlock : IAction<RetrieveBlockResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "block";

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
