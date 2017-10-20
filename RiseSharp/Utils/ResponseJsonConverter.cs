using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RiseSharp.Utils
{
    public class ResponseJsonConverter<T> : JsonConverter
    {
        const string StatusKey = "success";
        const string ErrorKey = "error";

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            if(jsonObject.GetValue(StatusKey).ToObject<bool>()){
                return JsonConvert.DeserializeObject<T>(jsonObject.ToString());
            }

            throw new Exception(jsonObject.GetValue(ErrorKey).ToObject<string>());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException("This is deserializer");
        }
    }
}
