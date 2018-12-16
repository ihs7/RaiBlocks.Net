using System.Collections.Generic;
using Newtonsoft.Json;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Results
{
    public class RetrieveBlocksInfoResult : IActionResult
    {
        [JsonProperty("blocks")]
        public Dictionary<string, BlocksInfo> Blocks { get; set; }   
    }

    public class BlocksInfo
    {
        [JsonProperty("block_account")]
        public RaiBlock BlockAccount { get; set; }
        
        [JsonProperty("amount")]
        public string Amount { get; set; }
        
        [JsonProperty("pending")]
        public string Pending { get; set; }
        
        [JsonProperty("source_account")]
        public string SourceAccount { get; set; }
        
        [JsonProperty("balance")]
        public string Balance { get; set; }
        
        [JsonConverter(typeof(JsonParseConverter<RetrieveBlockContent>))]
        [JsonProperty("contents")]
        public RetrieveBlockContent Contents { get; set; }
    }
}
