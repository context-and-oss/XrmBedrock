using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using SharedContext.Dao;

namespace DataverseLogic;

#pragma warning disable CA1062 // Validate arguments of public methods
#pragma warning disable CA2254 // Template should be a static expression
public class UserDataverseAccessObjectService(IOrganizationServiceFactory organizationServiceFactory, IPluginExecutionContext context, ILogger logger)
    : DataverseAccessObject(organizationServiceFactory?.CreateOrganizationService(context.UserId), logger), IUserDataverseAccessObjectService
#pragma warning restore CA2254 // Template should be a static expression
#pragma warning restore CA1062 // Validate arguments of public methods
{
}
