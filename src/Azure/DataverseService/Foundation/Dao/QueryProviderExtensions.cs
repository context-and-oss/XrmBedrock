using Microsoft.Xrm.Sdk.Query;
using System.Linq.Expressions;
using System.Reflection;

namespace DataverseService.Foundation.Dao;

/// <summary>
/// Code tribute https://stackoverflow.com/questions/6740179/convert-linq-expression-to-queryexpression-or-fetchxml/26563446#26563446
/// </summary>
public static class QueryProviderExtensions
{
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
        return (QueryExpression?)getQueryExpressionMethod.Invoke(queryProvider, arguments);
    }

    private static Type GetSubTypeOfQueryProvider(Type queryProviderType, string subTypeString) =>
            queryProviderType.Assembly.GetType(subTypeString) ?? throw new TypeAccessException($"Unable to access {subTypeString}");
}
