using System;
using System.Collections.Generic;

namespace CyberSource
{
public static class DictionaryUtil
    {
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) =>
            ToDictionary(source, keySelector, elementSelector, null);
        
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            if (source == null)
            {
                throw new ArgumentException(nameof(source));
            }

            if (keySelector == null)
            {
                throw new ArgumentException(nameof(keySelector));
            }

            if (elementSelector == null)
            {
                throw new ArgumentException(nameof(elementSelector));
            }

            int capacity = 0;
            if (source is ICollection<TSource> collection)
            {
                capacity = collection.Count;
                if (capacity == 0)
                {
                    return new Dictionary<TKey, TElement>(comparer);
                }

                if (collection is TSource[] array)
                {
                    return ToDictionary(array, keySelector, elementSelector, comparer);
                }

                if (collection is List<TSource> list)
                {
                    return ToDictionary(list, keySelector, elementSelector, comparer);
                }
            }

            Dictionary<TKey, TElement> d = new Dictionary<TKey, TElement>(capacity, comparer);
            foreach (TSource element in source)
            {
                d.Add(keySelector(element), elementSelector(element));
            }

            return d;
        }
        private static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(TSource[] source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            Dictionary<TKey, TElement> d = new Dictionary<TKey, TElement>(source.Length, comparer);
            for (int i = 0; i < source.Length; i++)
            {
                var key = keySelector(source[i]);
                if (!d.ContainsKey(key))
                    d.Add(key, elementSelector(source[i]));
            }

            return d;
        }
        
        private static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(List<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            Dictionary<TKey, TElement> d = new Dictionary<TKey, TElement>(source.Count, comparer);
            foreach (TSource element in source)
            {
                var key = keySelector(element);
                if (!d.ContainsKey(key))
                 d.Add(key, elementSelector(element));
            }

            return d;
        }
        
    }
}