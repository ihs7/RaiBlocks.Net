using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;
using System;

namespace RaiBlocks.Actions
{
    public class GetAccountHistory : IAction<AccountHistoryResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "account_history";

        [JsonProperty("account")]
        public string AccountNumber { get; private set; }

        [JsonProperty("count")]
        public int Count { get; private set; }


        public GetAccountHistory(RaiAddress address, int count = 1)
        {
            if (count < 1) throw new ArgumentException("Count must be larger than 0");

            AccountNumber = address ?? throw new ArgumentNullException(nameof(address));
            Count = count;
        }
    }
}
