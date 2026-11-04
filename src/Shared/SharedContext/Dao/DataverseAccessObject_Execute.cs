using System.Runtime.CompilerServices;
using Microsoft.Xrm.Sdk;

namespace SharedContext.Dao;

public partial class DataverseAccessObject : IDataverseAccessObject
{
    /// <summary>
    /// Generic method that executes an OrganisationRequest in XRM
    /// </summary>
    /// <param name="request"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public OrganizationResponse Execute(OrganizationRequest request, [CallerMemberName] string callerMethodName = "")
    {
        return DataverseWrapAccess.WrapFunction(logger, "Execute", request.RequestName, () => orgService.Execute(request), callerMethodName);
    }
}