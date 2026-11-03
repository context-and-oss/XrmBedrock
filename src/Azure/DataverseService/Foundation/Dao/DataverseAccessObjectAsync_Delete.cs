using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Generic method that deleted an entity of type T in XRM
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entityGuid"></param>
    /// <param name="callerMethodName"></param>
    public Task DeleteAsync<T>(Guid entityGuid, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
        where T : Entity
    {
        var entityName = typeof(T).Name.ToLowerInvariant();
        var deleteOperation = () => orgServiceAsync.DeleteAsync(entityName, entityGuid, ct == default ? cancellationToken : ct);
        return DataverseWrapAccessAsync.GenericDeleteInXrmAsync(logger, nameof(DeleteAsync), callerMethodName, entityGuid, typeof(T).Name, deleteOperation);
    }
}