using System.Collections.Generic;
using Newtonsoft.Json;
using RaiBlocks.Converters;

namespace RaiBlocks.Results
{
    public class RetrieveBlocksInfoResult
    {
        [JsonProperty("blocks")]
        public Dictionary<string, BlocksInfo> Blocks { get; set; }   
    }

    public class BlocksInfo
    {
        [JsonProperty("block_account")]
        public string BlockAccount { get; set; }
        
        [JsonProperty("amount")]
        public string Amount { get; set; }
        
        [JsonProperty("pending")]
        public string Pending { get; set; }
        
        [JsonProperty("source_account")]
        public string SourceAccount { get; set; }
        
        [JsonProperty("balance")]
        public string Balance { get; set; }
        
        [JsonConverter(typeof(JsonParseConverter<RetrieveBlock>))]
        [JsonProperty("contents")]
        public RetrieveBlock Contents { get; set; }
    }
}
