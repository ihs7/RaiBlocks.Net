using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Actions
{
    public class WorkGenerate: IAction<WorkGenerateResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "work_generate";

        [JsonProperty("hash")]
        public string Hash { get; set; }
        public WorkGenerate(string hash)
        {
            Hash = hash;
        }

    }
}
