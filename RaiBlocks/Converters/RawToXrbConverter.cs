using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Numerics;

namespace RaiBlocks.Converters
{
    public class RawToXrbConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(System.String).Equals(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jt = JToken.ReadFrom(reader);

            var raw = BigInteger.Parse(jt.Value<string>());

            return (decimal) Math.Exp(BigInteger.Log(raw) - BigInteger.Log(BigInteger.Parse("1000000000000000000000000000000")));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToString());
        }
    }
}
