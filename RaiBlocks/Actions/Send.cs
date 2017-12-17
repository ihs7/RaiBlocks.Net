using Newtonsoft.Json;
using RaiBlocks.Converters;
using RaiBlocks.Interfaces;
using RaiBlocks.Results;
using RaiBlocks.ValueObjects;
using System;

namespace RaiBlocks.Actions
{
    public class Send : IAction<SendResult>
    {
        [JsonProperty("action")]
        public string Action { get; } = "send";

        [JsonProperty("wallet")]
        public string Wallet { get; private set; }

        [JsonProperty("source")]
        public RaiAddress Source { get; private set; }

        [JsonProperty("destination")]
        public RaiAddress Destination { get; private set; }

        [JsonConverter(typeof(XrbToRawConverter))]
        [JsonProperty("send")]
        public decimal Amount { get; private set; }

        public Send(string wallet, RaiAddress source, RaiAddress destination, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be larger than 0");

            Wallet = wallet;
            Destination = destination;
            Amount = amount;
        }
    }
}
