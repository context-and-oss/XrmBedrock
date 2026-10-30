using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SharedContext.Dao;
using System.Diagnostics;
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
    /// Asynchronously retrieves the object with type <typeparamref name="T"/> with the specified guid from XRM
    /// If you truly want the entire object with all attributes then don't specify any columns and it will default to all
    /// If you only need a couple of values specify these like "x => x.somecol, x => x.anothercol, ... "
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guidOfElement"></param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Task<T> RetrieveAsync<T>(Guid guidOfElement,  params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity
    {
        var callerMethodName = new StackTrace().GetFrame(1).GetMethod().Name;
        var entityName = DataverseStaticExtensions.LogicalName<T>();
        return DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{nameof(RetrieveAsync)}({guidOfElement})", callerMethodName, async () =>
        {
            var cols = columnExpressions.ToList().ConvertAll(x => x.StringOf()).ToArray();
            var columnSet = cols is null || !cols.Any() ? new ColumnSet(true) : new ColumnSet(cols);
            try
            {
                var ret = await orgServiceAsync.RetrieveAsync(entityName, guidOfElement, columnSet, cancellationToken);
                return ret.ToEntity<T>();
            }
            catch (InvalidOperationException ioe)
            {
                throw new Exception($"There is no {entityName} with id {guidOfElement} in Xrm", ioe);
            }
        });
    }

    /// <summary>
    /// Asynchronously retrieves a List of Entities of type <typeparamref name="T"/> from XRM.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="query"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public async Task<List<T>> RetrieveListAsync<T>(QueryExpression query, [CallerMemberName] string callerMethodName = "") where T : Entity
    {
        return await DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{nameof(RetrieveListAsync)}<{typeof(T)}>", callerMethodName, async () =>
        {
            return (await RawRetrieveMultipleAsync(query).ToListAsync()).ConvertAll(x => x.ToEntity<T>());
        });
    }

    /// <summary>
    /// Asynchronously retrieves IAsyncEnumerable of Entities from XRM.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    public async Task<List<Entity>> RetrieveMultipleAsync(QueryExpression query, [CallerMemberName] string callerMethodName = "")
    {
        return await DataverseWrapAccessAsync.GenericRetrieveFromXrmAsync(logger, $"{nameof(RetrieveMultipleAsync)}", callerMethodName, async () =>
        {
            return await RawRetrieveMultipleAsync(query).ToListAsync();
        });
    }
   
    /// <summary>
    /// Asynchronously retrieves IAsyncEnumerable of Entities from XRM with no wrapping
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    public async IAsyncEnumerable<Entity> RawRetrieveMultipleAsync(QueryExpression query)
    {
        var resp = await orgServiceAsync.RetrieveMultipleAsync(query, cancellationToken);

        foreach (var entity in resp.Entities)
        {
            yield return entity;
        }

        if (query.PageInfo.PageNumber == 0)
        {
            query.PageInfo.PageNumber = 1;
        }

        while (resp.MoreRecords)
        {
            cancellationToken.ThrowIfCancellationRequested();
            query.PageInfo.PageNumber++;
            query.PageInfo.PagingCookie = resp.PagingCookie;
            resp = await orgServiceAsync.RetrieveMultipleAsync(query, cancellationToken);

            foreach (var entity in resp.Entities)
            {
                yield return entity;
            }
        }
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
        where T : Entity => RetrieveMultipleByIdsInnerMethodAsync(new StackTrace().GetFrame(1).GetMethod().Name, guids, null, columnExpressions);

    /// <summary>
    /// Asynchronously retrieves a list of objects by their Guids where you specify the name of the Guid column
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guids"></param>
    /// <param name="fieldName">Name of the Guid-field</param>
    /// <param name="columnExpressions"></param>
    /// <returns></returns>
    public Task<List<T>> RetrieveMultipleByIdsAsync<T>(IEnumerable<Guid> guids, string fieldName, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity => RetrieveMultipleByIdsInnerMethodAsync(new StackTrace().GetFrame(1).GetMethod().Name, guids, fieldName, columnExpressions);

    private async Task<List<T>> RetrieveMultipleByIdsInnerMethodAsync<T>(string callerMethodName, IEnumerable<Guid> guids, string fieldName = null, params Expression<Func<T, object>>[] columnExpressions)
        where T : Entity
    {
        var guidArray = guids.ToArray();
        if (guidArray.Length == 0)
        {
            return new List<T>();
        }

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
        return await RetrieveListAsync<T>(query, callerMethodName);
    }
}