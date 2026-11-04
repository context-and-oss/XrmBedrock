using Microsoft.Extensions.Logging;
using System.Runtime.Caching;

namespace SharedContext.Dao;

public class CacheHandler(MemoryCache cache, ILogger logger)
{
    public const int CacheExpirationTimeInMinutes = 60;
    private readonly MemoryCache cache = cache;
    private readonly ILogger logger = logger;

    public T? GetOrCreate<T>(string key, Func<T> factory)
    {
        T? value = GetCachedValue<T>(key);
        if (value == null)
        {
            // Stop logging as soon as confidence in the caching mekanism is established among the team
            logger.LogTrace($"cache miss on '{key}'");
            value = factory.Invoke();
            if (value != null)
            {
                cache.Add(key, value, DateTimeOffset.Now.AddMinutes(CacheExpirationTimeInMinutes));
            }
        }
        else
        {
            // Stop logging as soon as confidence in the caching mekanism is established among the team
            logger.LogTrace($"cache hit on '{key}'");
        }

        return value;
    }

    public async Task<T?> GetOrCreateAsync<T>(string key, Func<Task<T>> factory)
    {
        T? value = GetCachedValue<T>(key);
        if (value == null)
        {
            // Stop logging as soon as confidence in the caching mekanism is established among the team
            logger.LogTrace($"cache miss on '{key}'");
            value = await factory.Invoke();
            if (value != null)
            {
                cache.Add(key, value, DateTimeOffset.Now.AddMinutes(CacheExpirationTimeInMinutes));
            }
        }
        else
        {
            // Stop logging as soon as confidence in the caching mekanism is established among the team
            logger.LogTrace($"cache hit on '{key}'");
        }

        return value;
    }

    private T? GetCachedValue<T>(string key)
    {
        T? value;
        try
        {
            value = (T)cache.Get(key);
        }
        catch (InvalidCastException ice)
        {
            logger?.LogWarning($"InvalidCastException thrown on getting value for key '{key}' from the cache. Details: {ice.Message}");

            // InvalidCastException may occur if the plugin assembly is loaded multiple times on the same XRM node.
            // Types from different copies of the same plugin are considered different even though they are basically the same.
            // See https://stackoverflow.com/questions/2500280/invalidcastexception-for-two-objects-of-the-same-type
            // By setting value = default (which is typically null), we force an update of the cached value
            value = default;
        }

        return value;
    }

    /// <summary>
    /// The use of this method is solely for testing purposes
    /// </summary>
    /// <param name="key"></param>
    public void ClearItemFromCache(string key)
    {
        cache.Remove(key);
    }

    /// <summary>
    /// The use of this method is solely for testing purposes
    /// </summary>
    /// <returns></returns>
    public string GetGeneralCacheInfo()
    {
        return $"Number of items in the cache: {cache.GetCount()}. CacheMemoryLimit (MB): {cache.CacheMemoryLimit / 1024 / 1024}";
    }

    /// <summary>
    /// The use of this method is solely for testing purposes
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public string PeekAnItemInTheCache(string key)
    {
        var value = cache.Get(key);
        if (value == null) return $"No value for key '{key}' found in cache";
        string? valueStr = null;
        if (value is string)
        {
            valueStr = value.ToString();
        }

        if (string.IsNullOrEmpty(valueStr)) return $"Key '{key}' found in cache with type '{value.GetType()}'";
        return $"Key '{key}' found in cache with type '{value.GetType()}' and value '{valueStr}'";
    }
}
