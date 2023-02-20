namespace AzurePipelines.Toolkit.Extensions;

internal static class DictionaryExtensions
{
    internal static IDictionary<TKey, TValue> AddPair<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key,
        TValue value)
    {
        dictionary.Add(key, value);
        return dictionary;
    }

    internal static IDictionary<TKey, TValue> AddPairWhenValueNotNull<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key,
        TValue? value)
        where TValue : class
    {
        return value != null
            ? dictionary.AddPair(key, value)
            : dictionary;
    }
}