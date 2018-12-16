using Newtonsoft.Json;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RaiBlocks.Results
{
    public class AccountsPendingResult : IActionResultWithError
    {
        [JsonProperty("blocks")]
        public Dictionary<string, Dictionary<string, AccountPendingBlock>> Blocks { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [OnDeserialized]
        public void OnDeserialized(StreamingContext context)
        {
            if (Blocks == null && Error == null)
            {
                Blocks = new Dictionary<string, Dictionary<string, AccountPendingBlock>>();
            }
        }

        public class AccountPendingBlock
        {
            [JsonConverter(typeof(StringToRawConverter))]
            [JsonProperty("amount")]
            public RaiUnits.RaiRaw Amount { get; set; }

            [JsonProperty("source")]
            public string Source { get; set; }
        }

    }
}
