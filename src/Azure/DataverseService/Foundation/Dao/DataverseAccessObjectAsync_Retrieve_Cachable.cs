using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using XrmBedrock.SharedContext;
using Task = System.Threading.Tasks.Task;

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
        where T : Entity => cacheHandler.GetOrCreateAsync<T>(cacheKey, () => RetrieveAsync<T>(guidOfElement, columnExpressions));

    /// <summary>
    /// Same as RetrieveListAsync<typeparamref name="T"/> but allows the use of caching of the retrieved list of objects by the specified cacheKey
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cacheKey"></param>
    /// <param name="query"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveListCachableAsync<T>(string cacheKey, QueryExpression query, [CallerMemberName] string callerMethodName = "")
        where T : Entity => cacheHandler.GetOrCreateAsync<List<T>>(cacheKey, () => RetrieveListAsync<T>(query, callerMethodName));

    /// <summary>
    /// Same as RetrieveMultipleAsync but allows the use of caching of the retrieved list of objects by the specified cacheKey
    /// </summary>
    /// <param name="cacheKey"></param>
    /// <param name="query"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<Entity>> RetrieveMultipleCachableAsync(string cacheKey, QueryExpression query, [CallerMemberName] string callerMethodName = "")
        => cacheHandler.GetOrCreateAsync<List<Entity>>(cacheKey, () => RetrieveMultipleAsync(query, callerMethodName));

    
}