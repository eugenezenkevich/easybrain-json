#if JSONDOTNET
namespace Easybrain.Json
{
    public class DotNetJsonProvider : IJsonProvider
    {
        public string ToJson(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None);
        }

        public T FromJson<T>(string json)
        {
            T result = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            return result;
        }
    }
}
#endif