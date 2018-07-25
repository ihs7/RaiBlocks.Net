using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;

namespace RaiBlocks.Actions
{
    public class AccountKey: IAction<AccountKeyResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "account_key";
        
        [JsonProperty("account")]
        public string AccountNumber { get; set; }
    }
}
