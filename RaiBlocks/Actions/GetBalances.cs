using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RaiBlocks.Actions
{
    public class GetBalances : IAction<BalancesResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "accounts_balances";

        [JsonProperty("accounts")]
        public IEnumerable<string> AccountsNumbers { get; private set; }

        public GetBalances(IEnumerable<RaiAddress> addresses)
        {
            AccountsNumbers = addresses?.Select(x=> x.ToString()) ?? throw new ArgumentNullException(nameof(addresses));
        }
    }
}
