using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using System.Runtime.CompilerServices;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Generic method that deleted an entity of type T0 in XRM
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <param name="entityGuid"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    public Task DeleteUnawaitedAsync<T0>(Guid entityGuid, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T0 : Entity
    {
        var entityName = typeof(T0).Name.ToLowerInvariant();
        var deleteOperation = () => orgServiceAsync.DeleteAsync(entityName, entityGuid, ct == default ? cancellationToken : ct);
        return DataverseWrapAccessAsync.GenericDeleteInXrmUnawaitedAsync(logger, nameof(DeleteUnawaitedAsync), callerMethodName, entityGuid, typeof(T0).Name, deleteOperation);
    }
}
