using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;
using System;

namespace RaiBlocks.Actions
{
    public class GetAccountInformation : IAction<AccountInformationResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "account_info";

        [JsonProperty("account")]
        public string AccountNumber { get; private set; }

        public GetAccountInformation(RaiAddress address)
        {
            AccountNumber = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
