using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace DataverseRegistration;

public abstract class Plugin : XrmPluginCore.Plugin
{
    protected override IServiceCollection OnBeforeBuildServiceProvider(IServiceCollection services)
    {
        services.AddScoped<ILogger, DataverseLogger>();
        services.TryAdd(ServiceDescriptor.Scoped(typeof(ILogger<>), typeof(DataverseLogger<>)));
        services.SetupCustomDependencies();
        return services;
    }
}
