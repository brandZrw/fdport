using FDPort.Communication;
using FDPort.FieldModuleClass;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace FDPort.Class
{
    public class JsonFieldModule : JsonConverter
    {
        /// <summary>
        ///     写入Json数据
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        /// <summary>
        ///     读Json数据
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                                        JsonSerializer serializer)
        {
            if(objectType == typeof(FieldModule))
            {
                var jobj = serializer.Deserialize<JObject>(reader);
                var type = jobj.Value<int>("type");
                switch (type)
                {
                    case 0:
                        return jobj.ToObject<FieldStatic>();
                    case 1:
                        return jobj.ToObject<FieldByte>();
                    case 2:
                        return jobj.ToObject<FieldBit>();
                    case 3:
                        return jobj.ToObject<FieldFunc>();
                    case 4:
                        return jobj.ToObject<FieldData>();
                }
            }
            else if(objectType == typeof(PortBase))
            {
                var jobj = serializer.Deserialize<JObject>(reader);
                if(jobj == null)
                {
                    return null;
                }
                var type = jobj.Value<int>("type");
                switch (type)
                {
                    case 1:
                        return jobj.ToObject<PortSerial>();
                    case 2:
                        return jobj.ToObject<PortTCPClient>();
                    case 3:
                        return jobj.ToObject<PortTCPService>();
                }
            }
            
            return null;
        }

        /// <summary>
        ///     是否可以转换
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(FieldModule) || objectType == typeof(PortBase);
        }
    }

}
