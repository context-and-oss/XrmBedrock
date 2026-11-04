using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using System.Runtime.CompilerServices;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Generic Async method that executes an OrganisationRequest in XRM
    /// </summary>
    /// <param name="request"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<OrganizationResponse> ExecuteAsync(OrganizationRequest request, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
    {
        return DataverseWrapAccessAsync.GenericExecuteInXrmAsync(logger, nameof(ExecuteAsync), callerMethodName, () => orgServiceAsync.ExecuteAsync(request, ct == default ? cancellationToken : ct));
    }
}
