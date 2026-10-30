using DataverseService.Foundation.Dao;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
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
    /// Generic Async method that executes an OrganisationRequest in XRM
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public Task<OrganizationResponse> ExecuteAsync(OrganizationRequest request, [CallerMemberName] string callerMethodName = "")
    {
        return DataverseWrapAccessAsync.GenericExecuteInXrmAsync(logger, nameof(ExecuteAsync), callerMethodName, () => CancellationTokenIsSet() ? orgServiceAsync.ExecuteAsync(request, cancellationToken) : orgServiceAsync.ExecuteAsync(request));
    }
}