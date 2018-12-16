using System;
using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;

namespace RaiBlocks.Actions
{
    /// <summary>
    /// Creates account. Returns wallet address.
    /// enable_control is required.
    /// </summary>
    public class CreateAccount : IAction<CreateAccountResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "account_create";

        [JsonProperty("wallet")]
        public string Wallet { get; private set; }

        public CreateAccount(string wallet)
        {
            Wallet = wallet ?? throw new ArgumentNullException(nameof(wallet));
        }
    }
}
