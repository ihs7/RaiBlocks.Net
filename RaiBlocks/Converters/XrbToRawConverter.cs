using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RaiBlocks.Converters
{
    public class XrbToRawConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(System.String).Equals(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jt = JToken.ReadFrom(reader);

            return BigInteger.Multiply(BigInteger.Parse(jt.Value<string>()), BigInteger.Parse("1000000000000000000000000000000")).ToString();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToString());
        }
    }
}
