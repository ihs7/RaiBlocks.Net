using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;
using System;

namespace RaiBlocks.Actions
{
    public class GetAccountBlockCount : IAction<AccountBlockCountResult> 
    {
        [JsonProperty("action")]
        public string Action { get; } = "account_block_count";

        [JsonProperty("account")]
        public string AccountNumber { get; private set; }

        public GetAccountBlockCount(RaiAddress address)
        {
            AccountNumber = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
