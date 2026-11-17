using Microsoft.Xrm.Sdk.Query;
using System.Linq.Expressions;
using System.Reflection;

namespace DataverseService.Foundation.Dao;

/// <summary>
/// Code tribute https://stackoverflow.com/questions/6740179/convert-linq-expression-to-queryexpression-or-fetchxml/26563446#26563446
/// </summary>
public static class QueryProviderExtensions
{
    private const int MaxTopCount = 5000;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S3011:Reflection should not be used to increase accessibility of classes, methods, or fields", Justification = "Accepting this here")]
    public static QueryExpression? ToQueryExpression<T>(this IQueryable<T> items)
    {
        ArgumentNullException.ThrowIfNull(items);
        var queryProvider = items.Provider ?? throw new InvalidOperationException("Unable to obtain QueryProvider");
        var queryProviderType = queryProvider.GetType();
        var listType = typeof(List<>);
        var projectionType = GetSubTypeOfQueryProvider(queryProviderType, "Microsoft.Xrm.Sdk.Linq.QueryProvider+Projection");
        var navigationSourceType = GetSubTypeOfQueryProvider(queryProviderType, "Microsoft.Xrm.Sdk.Linq.QueryProvider+NavigationSource");
        var linkLookupType = GetSubTypeOfQueryProvider(queryProviderType, "Microsoft.Xrm.Sdk.Linq.QueryProvider+LinkLookup");
        var linkLookupListType = listType.MakeGenericType(linkLookupType);
        object? projection = null;
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var args = new object[] { null, null };
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        object? source = Activator.CreateInstance(navigationSourceType, args);
        object? linkLookups = Activator.CreateInstance(linkLookupListType);
        bool throwIfSequenceIsEmpty = false;
        bool throwIfSequenceNotSingle = false;
        object?[] arguments =
        [
            items.Expression,
            throwIfSequenceIsEmpty,
            throwIfSequenceNotSingle,
            projection,
            source,
            linkLookups,
        ];
        var getQueryExpressionMethod = queryProviderType.GetMethod(
            "GetQueryExpression",
            bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public,
            null,
            new[]
            {
                typeof(Expression),
                typeof(bool).MakeByRefType(),
                typeof(bool).MakeByRefType(),
                projectionType.MakeByRefType(),
                navigationSourceType.MakeByRefType(),
                linkLookupListType.MakeByRefType(),
            },
            null) ?? throw new InvalidOperationException("Unable to obtain QueryExpressionMethod");
        var queryExpression = (QueryExpression?)getQueryExpressionMethod.Invoke(queryProvider, arguments);
        return queryExpression is null ? null : ApplySkipTake(queryExpression);
    }

    /// <summary>
    /// The SDK's internal translation leaves Take(n) in PageInfo.Count and the Skip(n) row offset in PageInfo.PageNumber.
    /// The SDK's own execution rewrites these before sending, which is bypassed here, so they are rewritten into a query Dataverse understands.
    /// Take(n) becomes TopCount. Skip and Take above <see cref="MaxTopCount"/> throw <see cref="NotSupportedException"/>.
    /// </summary>
    /// <param name="queryExpression">Query returned by the SDK translation</param>
    /// <returns>The same query with Take moved to TopCount and an empty PageInfo</returns>
    private static QueryExpression ApplySkipTake(QueryExpression queryExpression)
    {
        var pageInfo = queryExpression.PageInfo;
        if (pageInfo is null)
            return queryExpression;

        if (pageInfo.PageNumber > 0)
            throw new NotSupportedException("Skip() is not supported by ToQueryExpression. Use a QueryExpression and set PageInfo.");

        var take = pageInfo.Count;
        if (take > MaxTopCount)
            throw new NotSupportedException($"Take() above {MaxTopCount} is not supported by ToQueryExpression. Use a QueryExpression and page it.");

        if (take > 0)
        {
            queryExpression.TopCount = take;
            queryExpression.PageInfo = new PagingInfo();
        }

        return queryExpression;
    }

    private static Type GetSubTypeOfQueryProvider(Type queryProviderType, string subTypeString) =>
            queryProviderType.Assembly.GetType(subTypeString) ?? throw new TypeAccessException($"Unable to access {subTypeString}");
}
