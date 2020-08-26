namespace Easybrain.Json
{
    public interface IJsonProvider
    {
        string ToJson(object obj);
        T FromJson<T>(string json);
    }
}