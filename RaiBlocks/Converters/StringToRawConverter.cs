using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace RaiBlocks.Converters
{
    public class StringToRawConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(System.String).Equals(objectType);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => new RaiUnits.RaiRaw(JToken.ReadFrom(reader).Value<string>());

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, value.ToString());
    }
}
