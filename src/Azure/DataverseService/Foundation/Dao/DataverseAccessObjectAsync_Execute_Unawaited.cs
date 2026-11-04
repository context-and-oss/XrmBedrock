using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using System.Runtime.CompilerServices;

namespace Azure.DataverseService.Foundation.Dao;

#pragma warning disable MA0048 // File name must match type name
public partial class DataverseAccessObjectAsync
#pragma warning restore MA0048 // File name must match type name
{
    /// <summary>
    /// Generic UnawaitedAsync method that executes an OrganisationRequest in XRM
    /// NOTE! This is an UnawaitedAsync method so caller is responsible for all exception handling. Please keep it uniform!
    /// </summary>
    /// <param name="request"></param>
    /// <param name="ct"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<OrganizationResponse> ExecuteUnawaitedAsync(OrganizationRequest request, CancellationToken ct = default, [CallerMemberName] string callerMethodName = "")
    {
        return DataverseWrapAccessAsync.GenericExecuteInXrmUnawaitedAsync(logger, nameof(ExecuteUnawaitedAsync), callerMethodName, () => orgServiceAsync.ExecuteAsync(request, ct == default ? cancellationToken : ct));
    }
}
