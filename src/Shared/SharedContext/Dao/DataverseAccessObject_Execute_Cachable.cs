using System.Runtime.CompilerServices;
using Microsoft.Xrm.Sdk;

namespace SharedContext.Dao;

public partial class DataverseAccessObject : IDataverseAccessObject
{
    /// <summary>
    /// Same as Execute, but allows caching of the response. Notice, this method does mostly suitable for getting results. 
    /// </summary>
    /// <param name="cacheKey"></param>
    /// <param name="request"></param>
    /// <param name="callerMethodName"></param>
    /// <returns></returns>
    public OrganizationResponse ExecuteCachable(string cacheKey, OrganizationRequest request, [CallerMemberName] string callerMethodName = "")
    {
        return cacheHandler.GetOrCreate<OrganizationResponse>(cacheKey, () => Execute(request, callerMethodName));
    }
}