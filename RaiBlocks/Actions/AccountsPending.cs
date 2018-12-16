using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using System;
using System.Collections.Generic;

namespace RaiBlocks.Actions
{
    public class AccountsPending : IAction<AccountsPendingResult>
    {
        public AccountsPending(List<string> accounts, long count, bool source)
        {
            Accounts = accounts ?? throw new ArgumentNullException(nameof(accounts));
            Count = count;
            Source = source;
        }

        [JsonProperty("action")]
        public string Action { get; } = "accounts_pending";

        [JsonProperty("accounts")]
        public List<string> Accounts { get; private set; }

        [JsonProperty("count")]
        public long Count { get; private set; }

        [JsonProperty("source")]
        public bool Source { get; private set; }
    }
}
