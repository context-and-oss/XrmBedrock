using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace DataverseService.Foundation.Dao;

/// <summary>
/// Code tribute https://stackoverflow.com/questions/6740179/convert-linq-expression-to-queryexpression-or-fetchxml/26563446#26563446
/// </summary>
public static class QueryProviderExtensions
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S3011:Reflection should not be used to increase accessibility of classes, methods, or fields", Justification = "Accepting this here")]
    public static QueryExpression ToQueryExpression<T>(this IQueryable<T> items)
    {
        var queryProvider = items.Provider;

        var queryProviderType = queryProvider.GetType();
        var listType = typeof(List<>);

        var projectionType = queryProviderType.Assembly.GetType("Microsoft.Xrm.Sdk.Linq.QueryProvider+Projection");
        var navigationSourceType = queryProviderType.Assembly.GetType("Microsoft.Xrm.Sdk.Linq.QueryProvider+NavigationSource");
        var linkLookupType = queryProviderType.Assembly.GetType("Microsoft.Xrm.Sdk.Linq.QueryProvider+LinkLookup");
        var linkLookupListType = listType.MakeGenericType(linkLookupType);

        object projection = null;
        var args = new object[] { null, null };
        object source = Activator.CreateInstance(navigationSourceType, args);
        object linkLookups = Activator.CreateInstance(linkLookupListType);
        bool throwIfSequenceIsEmpty = false;
        bool throwIfSequenceNotSingle = false;

        object[] arguments = new object[6];
        arguments[0] = items.Expression;
        arguments[1] = throwIfSequenceIsEmpty;
        arguments[2] = throwIfSequenceNotSingle;
        arguments[3] = projection;
        arguments[4] = source;
        arguments[5] = linkLookups;

        var getQueryExpressionMethod = queryProviderType.GetMethod("GetQueryExpression", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public, null, new[] {
                typeof(Expression),
                typeof(bool).MakeByRefType(),
                typeof(bool).MakeByRefType(),
                projectionType.MakeByRefType(),
                navigationSourceType.MakeByRefType(),
                linkLookupListType.MakeByRefType(),
            }, null);

        var queryExpression = (QueryExpression)getQueryExpressionMethod.Invoke(queryProvider, arguments);
        return queryExpression;
    }

    public static string ToXml(this QueryExpression queryExpression, IOrganizationService service)
    {
        var request = new QueryExpressionToFetchXmlRequest { Query = queryExpression };
        var response = (QueryExpressionToFetchXmlResponse)service.Execute(request);
        return response.FetchXml;
    }
}
