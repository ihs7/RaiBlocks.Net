using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Converters
{
    /// <summary>
    /// Converter for case when object send as string.
    /// </summary>
    /// <typeparam name="T">Deserialized object/</typeparam>
    public class JsonParseConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(string).Equals(objectType);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => JObject.Parse(JToken.ReadFrom(reader).Value<string>()).ToObject<T>();

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, value.ToString());
    }
}
