using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using SharedContext.Dao;

namespace DataverseLogic;

#pragma warning disable CA1848 // Use the LoggerMessage delegates
#pragma warning disable CA2254 // Template should be a static expression
public class AdminDataverseAccessObjectService(IOrganizationServiceFactory organizationServiceFactory, ILogger logger)
    : DataverseAccessObject(organizationServiceFactory?.CreateOrganizationService(null), logger), IAdminDataverseAccessObjectService
#pragma warning restore CA2254 // Template should be a static expression
#pragma warning restore CA1848 // Use the LoggerMessage delegates
{
}
