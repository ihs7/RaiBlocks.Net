using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using System;

namespace RaiBlocks.Actions
{
    public class WorkGenerate: IAction<WorkGenerateResult>
    {
        public WorkGenerate(string hash)
        {
            Hash = hash ?? throw new ArgumentNullException(nameof(hash));
        }

        [JsonProperty("action")]
        public string Action { get; } = "work_generate";

        [JsonProperty("hash")]
        public string Hash { get; private set; }
    }
}
