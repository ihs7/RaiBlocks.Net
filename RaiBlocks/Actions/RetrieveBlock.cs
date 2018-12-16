using System;
using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;

namespace RaiBlocks.Actions
{
    public class RetrieveBlock : IAction<RetrieveBlockResult>
    {
        public RetrieveBlock(string hash)
        {
            Hash = hash ?? throw new ArgumentNullException(nameof(hash));
        }

        [JsonProperty("action")]
        public string Action { get; } = "block";

        [JsonProperty("hash")]
        public string Hash { get; private set; }
    }
}
