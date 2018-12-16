using System;
using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;

namespace RaiBlocks.Actions
{
    public class AccountKey: IAction<AccountKeyResult>
    {
        public AccountKey(string accountNumber)
        {
            AccountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
        }

        [JsonProperty("action")]
        public string Action { get; } = "account_key";
        
        [JsonProperty("account")]
        public string AccountNumber { get; private set; }
    }
}
