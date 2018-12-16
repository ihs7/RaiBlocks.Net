using Newtonsoft.Json;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Actions
{
    public class Send : IAction<SendResult>
    {
        public Send(string wallet, RaiAddress source, RaiAddress destination, RaiUnits.RaiRaw amount)
        {
            Wallet = wallet;
            Destination = destination;
            Amount = amount;
        }

        [JsonProperty("action")]
        public string Action { get; } = "send";

        [JsonProperty("wallet")]
        public string Wallet { get; private set; }

        [JsonProperty("source")]
        public RaiAddress Source { get; private set; }

        [JsonProperty("destination")]
        public RaiAddress Destination { get; private set; }

        [JsonConverter(typeof(StringToRawConverter))]
        [JsonProperty("send")]
        public RaiUnits.RaiRaw Amount { get; private set; }
    }
}
