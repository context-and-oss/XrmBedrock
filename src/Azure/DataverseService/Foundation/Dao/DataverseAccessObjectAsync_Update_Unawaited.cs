using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using System.Runtime.CompilerServices;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Generic UnawaitedAsync method that updates an entity of type T0 in XRM
    /// NOTE! This is an UnawaitedAsync method so caller is responsible for all exception handling. Please keep it uniform!
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <param name="entity"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    public Task UpdateUnawaitedAsync<T0>(T0 entity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T0 : Entity
    {
        return DataverseWrapAccessAsync.GenericUpdateInXrmUnawaitedAsync(logger, nameof(UpdateUnawaitedAsync), callerMethodName, entity, () => orgServiceAsync.UpdateAsync(entity, ct == default ? cancellationToken : ct));
    }
}
