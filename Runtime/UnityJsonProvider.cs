using UnityEngine;

namespace Easybrain.Json
{
    public class UnityJsonProvider : IJsonProvider
    {
        public string ToJson(object obj)
        {
            return JsonUtility.ToJson(obj);
        }

        public T FromJson<T>(string json)
        {
            return JsonUtility.FromJson<T>(json);
        }
    }
}