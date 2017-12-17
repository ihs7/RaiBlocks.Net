using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using System;

namespace RaiBlocks.Actions
{
    public class GetAccountByPublicKey : IAction<GetAccountByPublicKeyResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "account_get";

        [JsonProperty("key")]
        public string Key { get; private set; }

        public GetAccountByPublicKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException(nameof(key));

            Key = key;
        }
    }
}
