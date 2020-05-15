using UnityEngine;

namespace DemoToolbox
{
    public static class ArrayExtensions
    {
        public static T RandomElement<T>(this T[] source)
        {
            if (source.Length > 0)
            {
                return source[Random.Range(0, source.Length)];
            }
            else
            {
                return default(T);
            }
        }
    }
}