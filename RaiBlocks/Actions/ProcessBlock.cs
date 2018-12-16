using System;
using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;

namespace RaiBlocks.Actions
{
    public class ProcessBlock: IAction<ProcessBlockResult>
    {
        public ProcessBlock(string block)
        {
            Block = block ?? throw new ArgumentNullException(nameof(block));
        }

        [JsonProperty("action")]
        public string Action { get; } = "process";

        [JsonProperty("block")]
        public string Block { get; private set; }
    }
}
