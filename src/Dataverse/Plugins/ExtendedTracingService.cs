using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.PluginTelemetry;
using SharedDataverseLogic;

namespace DataverseLogic;

public class ExtendedTracingService(ITracingService tracingService, ILogger pluginTelemetryLogger) : IExtendedTracingService
{
    private readonly ITracingService tracingService = tracingService;
    private readonly ILogger pluginTelemetryLogger = pluginTelemetryLogger;

    public void Trace(string format, params object[] args)
    {
        tracingService?.Trace(format, args);
        pluginTelemetryLogger?.LogInformation(format, args);
    }
}
