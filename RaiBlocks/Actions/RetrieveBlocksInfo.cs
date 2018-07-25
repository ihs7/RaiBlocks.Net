using System.Collections.Generic;
using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;

namespace RaiBlocks.Actions
{
    public class RetrieveBlocksInfo : IAction<RetrieveBlocksInfoResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "blocks_info";
        
        [JsonProperty("hashes")]
        public List<string> Hashes { get; set; } = new List<string> ();

        [JsonProperty("pending")]
        public bool Pending { get; set; } = false;
        
        [JsonProperty("source")]
        public bool Source { get; set; } = false;
        
        [JsonProperty("balance")]
        public bool Balance { get; set; } = false;
        
    }
}
