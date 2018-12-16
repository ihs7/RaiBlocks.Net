using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Actions
{
    public class ValidateAccount : IAction<ValidateAccountResult>
    {
        public ValidateAccount(RaiAddress address)
        {
            AccountNumber = address ?? throw new ArgumentNullException(nameof(address));
        }

        [JsonProperty("action")]
        public string Action { get; } = "validate_account_number";

        [JsonProperty("account")]
        public string AccountNumber { get; private set; }
    }
}
