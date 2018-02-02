using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Actions
{
    public class ProcessBlock: IAction<ProcessBlockResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "account_block_count";

        [JsonProperty("block")]
        public string Block { get; set; }

        public ProcessBlock(string block)
        {
            Block = block;
        }
    }
}
