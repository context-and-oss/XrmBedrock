using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using System.Runtime.CompilerServices;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Generic method that updates an entity of type T0 in XRM
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <param name="entity"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    public Task UpdateAsync<T0>(T0 entity, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T0 : Entity
    {
        return DataverseWrapAccessAsync.GenericUpdateInXrmAsync(logger, nameof(UpdateAsync), callerMethodName, entity, () => orgServiceAsync.UpdateAsync(entity, ct == default ? cancellationToken : ct));
    }
}
