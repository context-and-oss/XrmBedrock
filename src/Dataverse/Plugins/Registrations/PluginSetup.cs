using DataverseLogic;
using DataverseLogic.Azure;
using DataverseLogic.Utility;
using Microsoft.Extensions.DependencyInjection;
using SharedContext.Dao;

namespace DataverseRegistration;

internal static class PluginSetup
{
    internal static void SetupCustomDependencies(this IServiceCollection services)
    {
        services.AddAzureConfig();

        // Utility
        services.AddScoped<DuplicateRuleService>();

        // Dao objects
        services.AddScoped<IAdminDataverseAccessObjectService, AdminDataverseAccessObjectService>();
        services.AddScoped<IUserDataverseAccessObjectService, UserDataverseAccessObjectService>();

        // Integration logic (lexicografical order please)
        services.AddScoped<AzureService>();

        // Dataverse Logic (lexicografical order please)
        // Add your custom service registrations here
    }
}
