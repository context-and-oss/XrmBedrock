using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedContext.Dao;
using SharedContext.Dao.Exceptions;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using XrmBedrock.SharedContext;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    private const int MaxPageSize = 5000;

    /// <summary>
    /// Asynchronously retrieves the object with type <typeparamref name="T"/> with the specified guid from XRM
    /// If you truly want the entire object with all attributes then don't specify any columns and it will default to all
    /// If you only need a couple of values specify these like "x => x.somecol, x => x.anothercol, ... "
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guidOfElement"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Task<T> RetrieveAsync<T>(Guid guidOfElement, params Expression<Func<T, object?>>[] columnExpressions)
        where T : Entity
    {
        var callerMethodName = new StackTrace().GetFrame(1)?.GetMethod()?.Name ?? "CallerUnindentified";
        return RetrieveCoreAsync<T>(guidOfElement, cancellationToken, nameof(RetrieveAsync), callerMethodName);
    }

    /// <summary>
    /// Asynchronously retrieves the object with type <typeparamref name="T"/> with the specified guid from XRM
    /// If you truly want the entire object with all attributes then don't specify any columns and it will default to all
    /// If you only need a couple of values specify these like "x => x.somecol, x => x.anothercol, ... "
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guidOfElement"></param>
    /// <param name="ct"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<T> RetrieveWithCtAsync<T>(Guid guidOfElement, CancellationToken ct, params Expression<Func<T, object?>>[] columnExpressions)
        where T : Entity
    {
        var callerMethodName = new StackTrace().GetFrame(1)?.GetMethod()?.Name ?? "CallerUnindentified";
        return RetrieveCoreAsync<T>(guidOfElement, ct, nameof(RetrieveWithCtAsync), callerMethodName);
    }

    /// <summary>
    /// Asynchronously retrieves a List of Entities of type <typeparamref name="T"/> from XRM.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="query"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveListAsync<T>(QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T : Entity
    {
        return DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{nameof(RetrieveListAsync)}<{typeof(T)}>", callerMethodName, async () =>
        {
            return (await RetrieveMultipleRawAsync(query, ct).ToListAsync()).ConvertAll(x => x.ToEntity<T>());
        });
    }

    /// <summary>
    /// Asynchronously retrieves a List of Entities of type <typeparamref name="T"/> from XRM using linq using a default mapper to map from Entity to <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="delegateQueryFunction"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveListAsync<T>(Func<Xrm, IQueryable<T>> delegateQueryFunction, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T : Entity
    {
        return DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{nameof(RetrieveListAsync)}", callerMethodName, () =>
        {
            return RetrieveListRawAsync(delegateQueryFunction, x => x.ToEntity<T>(), ct);
        });
    }

    /// <summary>
    /// Asynchronously retrieves a List of Entities of type <typeparamref name="T"/> from XRM using linq using a custom mapper to map from Entity to <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="delegateQueryFunction"></param>
    /// <param name="mapper"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveListAsync<T>(Func<Xrm, IQueryable<T>> delegateQueryFunction, Func<Entity, T> mapper, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
    {
        return DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{nameof(RetrieveListAsync)}", callerMethodName, () =>
        {
            return RetrieveListRawAsync(delegateQueryFunction, mapper, ct);
        });
    }

    /// <summary>
    /// Asynchronously retrieves IAsyncEnumerable of Entities from XRM.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<List<Entity>> RetrieveListAsync(QueryExpression query, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
    {
        return DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{nameof(RetrieveListAsync)}", callerMethodName, async () =>
        {
            return await RetrieveMultipleRawAsync(query, ct).ToListAsync();
        });
    }

    /// <summary>
    /// Asynchronously retrieves a list of objects by their Guids
    /// When field name is not specified, the default is entityname+"id", see overload of method for an alternative field name
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guids"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveMultipleByIdsAsync<T>(IEnumerable<Guid> guids, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity => RetrieveMultipleByIdsRawAsync(new StackTrace().GetFrame(1)?.GetMethod()?.Name ?? "CallerUnindentified", guids, fieldName: null, cancellationToken, columnExpressions);

    /// <summary>
    /// Asynchronously retrieves a list of objects by their Guids where you specify the name of the Guid column
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guids"></param>
    /// <param name="fieldName">Name of the Guid-field</param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveMultipleByIdsAsync<T>(IEnumerable<Guid> guids, string fieldName, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity => RetrieveMultipleByIdsRawAsync(new StackTrace().GetFrame(1)?.GetMethod()?.Name ?? "CallerUnindentified", guids, fieldName, cancellationToken, columnExpressions);

    /// <summary>
    /// Asynchronously retrieves a list of objects by their Guids
    /// When field name is not specified, the default is entityname+"id", see overload of method for an alternative field name
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guids"></param>
    /// <param name="ct"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveMultipleByIdsWithCtAsync<T>(IEnumerable<Guid> guids, CancellationToken ct, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity => RetrieveMultipleByIdsRawAsync(new StackTrace().GetFrame(1)?.GetMethod()?.Name ?? "CallerUnindentified", guids, null, ct, columnExpressions);

    /// <summary>
    /// Asynchronously retrieves a list of objects by their Guids where you specify the name of the Guid column
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guids"></param>
    /// <param name="fieldName">Name of the Guid-field</param>
    /// <param name="ct"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveMultipleByIdsWithCtAsync<T>(IEnumerable<Guid> guids, string fieldName, CancellationToken ct, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity => RetrieveMultipleByIdsRawAsync(new StackTrace().GetFrame(1)?.GetMethod()?.Name ?? "CallerUnindentified", guids, fieldName, ct, columnExpressions);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1068:CancellationToken parameters must come last", Justification = "Not possible with the params parameters")]
    private Task<T> RetrieveCoreAsync<T>(Guid guidOfElement, CancellationToken ct, string methodethodName, string callerMethodName, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity
    {
        var entityName = DataverseStaticExtensions.LogicalName<T>();
        return DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{methodethodName}({guidOfElement})", callerMethodName, async () =>
        {
            var cols = columnExpressions.ToList().ConvertAll(x => x.StringOf()).ToArray();
            var columnSet = cols is null || !cols.Any() ? new ColumnSet(true) : new ColumnSet(cols);
            try
            {
                var ret = await orgServiceAsync.RetrieveAsync(entityName, guidOfElement, columnSet, ct);
                return ret.ToEntity<T>();
            }
            catch (InvalidOperationException ioe)
            {
                throw new DataverseInteractionException($"There is no {entityName} with id {guidOfElement} in Xrm", ioe);
            }
        });
    }

    /// <summary>
    /// Asynchronously retrieves IAsyncEnumerable of Entities from XRM with no wrapping
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    private async IAsyncEnumerable<Entity> RetrieveMultipleRawAsync(QueryExpression query, [EnumeratorCancellation] CancellationToken ct = default)
    {
        var currentCancellationToken = ct == default ? cancellationToken : ct;
        var pagedQuery = CopyForPaging(query);
        var resp = await orgServiceAsync.RetrieveMultipleAsync(pagedQuery, currentCancellationToken);

        foreach (var entity in resp.Entities)
        {
            yield return entity;
        }

        if (pagedQuery.PageInfo.PageNumber == 0)
        {
            pagedQuery.PageInfo.PageNumber = 1;
        }

        while (resp.MoreRecords)
        {
            currentCancellationToken.ThrowIfCancellationRequested();
            pagedQuery.PageInfo.PageNumber++;
            pagedQuery.PageInfo.PagingCookie = resp.PagingCookie;
            resp = await orgServiceAsync.RetrieveMultipleAsync(pagedQuery, currentCancellationToken);

            foreach (var entity in resp.Entities)
            {
                yield return entity;
            }
        }
    }

    private async Task<List<T>> RetrieveListRawAsync<T>(Func<Xrm, IQueryable<T>> delegateQueryFunction, Func<Entity, T> mapper, CancellationToken ct = default)
    {
        using (Xrm xrm = new Xrm(orgServiceAsync))
        {
            var lq = delegateQueryFunction(xrm);
            var qe = lq.ToQueryExpression<T>() ?? throw new InvalidOperationException("Unable to get the QueryExpression from the Linq Query");
            var maxRows = ApplyLinqPaging(qe);
            var es = new List<Entity>();
            await foreach (var entity in RetrieveMultipleRawAsync(qe, ct))
            {
                es.Add(entity);
                if (es.Count == maxRows)
                    break;
            }

            var ts = es.ConvertAll(x => mapper(x));
            return ts;
        }
    }

    /// <summary>
    /// The LINQ translation puts Take(n) in PageInfo.Count and Skip(n) in PageInfo.PageNumber as a row offset, which is not a page number.
    /// Take is turned into paging that stops after n rows. Skip is rejected, because sending the offset as a page number returns the wrong rows.
    /// </summary>
    /// <param name="query">Translated query, PageInfo is replaced when Take is present</param>
    /// <returns>The maximum number of rows to return, or null when all rows are wanted</returns>
    private static int? ApplyLinqPaging(QueryExpression query)
    {
        var pageInfo = query.PageInfo;
        if (pageInfo is null)
            return null;

        if (pageInfo.PageNumber > 0)
            throw new NotSupportedException("Skip is not supported in LINQ queries passed to RetrieveListAsync.");

        if (pageInfo.Count <= 0)
            return null;

        var take = pageInfo.Count;
        query.PageInfo = new PagingInfo
        {
            Count = Math.Min(take, MaxPageSize),
            PageNumber = 1,
        };
        return take;
    }

    private async Task<List<T>> RetrieveMultipleByIdsRawAsync<T>(string callerMethodName, IEnumerable<Guid> guids, string? fieldName, CancellationToken ct, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity
    {
        var guidArray = guids.ToArray();
        if (guidArray.Length == 0)
            return new List<T>();

        var entityLogicalName = DataverseStaticExtensions.LogicalName<T>();
        var columnSet = columnExpressions.ToList().ConvertAll(x => x.StringOf()).ToArray();
        var query = new QueryExpression(entityLogicalName)
        {
            ColumnSet = columnSet.Length == 0 ? new ColumnSet(true) : new ColumnSet(columnSet),
            Criteria = new FilterExpression(),
        };
        var condition = new ConditionExpression(fieldName ?? $"{entityLogicalName}id", ConditionOperator.In, guidArray);
        var filter = new FilterExpression();
        filter.Conditions.Add(condition);
        query.Criteria.AddFilter(filter);
        return await RetrieveListAsync<T>(query, ct, callerMethodName);
    }
}
