using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using XrmBedrock.SharedContext;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Same as RetrieveAsync<typeparamref name="T"/> but allows the use of caching of the retrieved object by the specified cacheKey
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cacheKey"></param>
    /// <param name="guidOfElement"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<T> RetrieveCachableAsync<T>(string cacheKey, Guid guidOfElement, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity
        => cacheHandler.GetOrCreateAsync<T>(cacheKey, () => RetrieveAsync<T>(guidOfElement, columnExpressions));

    /// <summary>
    /// Same as RetrieveWithCtAsync<typeparamref name="T"/> but allows the use of caching of the retrieved object by the specified cacheKey
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cacheKey"></param>
    /// <param name="guidOfElement"></param>
    /// <param name="ct"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<T> RetrieveCachableWithCtAsync<T>(string cacheKey, Guid guidOfElement, CancellationToken ct, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity
        => cacheHandler.GetOrCreateAsync<T>(cacheKey, () => RetrieveWithCtAsync<T>(guidOfElement, ct, columnExpressions));

    /// <summary>
    /// Same as RetrieveListAsync<typeparamref name="T"/> but allows the use of caching of the retrieved list of objects by the specified cacheKey
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cacheKey"></param>
    /// <param name="query"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T : Entity
        => cacheHandler.GetOrCreateAsync<List<T>>(cacheKey, () => RetrieveListAsync<T>(query, ct, callerMethodName));

    /// <summary>
    /// Same as RetrieveListAsync but allows the use of caching of the retrieved list of objects by the specified cacheKey
    /// </summary>
    /// <param name="cacheKey"></param>
    /// <param name="query"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<Entity>> RetrieveListCachableAsync(string cacheKey, QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        => cacheHandler.GetOrCreateAsync<List<Entity>>(cacheKey, () => RetrieveListAsync(query, ct, callerMethodName));

    /// <summary>
    /// Same as RetrieveListAsync<typeparamref name="T"/> but allows the use of caching of the retrieved list of objects by the specified cacheKey
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cacheKey"></param>
    /// <param name="delegateQueryFunction"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, Func<Xrm, IQueryable<T>> delegateQueryFunction, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T : Entity
        => cacheHandler.GetOrCreateAsync<List<T>>(cacheKey, () => RetrieveListAsync<T>(delegateQueryFunction, ct, callerMethodName));

    /// <summary>
    /// Same as RetrieveListAsync<typeparamref name="T"/> but allows the use of caching of the retrieved list of objects by the specified cacheKey
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cacheKey"></param>
    /// <param name="delegateQueryFunction"></param>
    /// <param name="mapper"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, Func<Xrm, IQueryable<T>> delegateQueryFunction, Func<Entity, T> mapper, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        => cacheHandler.GetOrCreateAsync<List<T>>(cacheKey, () => RetrieveListAsync<T>(delegateQueryFunction, mapper, ct, callerMethodName));
}
