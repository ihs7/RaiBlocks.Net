using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaiBlocks.Converters
{
    public class TimeStampToDateConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(System.String).Equals(objectType);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var timestamp = JToken.ReadFrom(reader).Value<int>();
            return (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(timestamp);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = (DateTime)value - origin;
            serializer.Serialize(writer, Math.Floor(diff.TotalSeconds));
        }
    }
}
