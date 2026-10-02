using Microsoft.Extensions.Logging;
using SharedDataverseLogic;

namespace DataverseService.Foundation.Logging;

/// <summary>
/// This class is here to support tracing in services in the SharedDataverseLogic project
/// </summary>
public class ExtendedTracingService(ILogger<ExtendedTracingService> logger) : IExtendedTracingService
{
    private readonly ILogger logger = logger;

    public void Trace(string format, params object[] args)
    {
        logger?.LogTrace(format, args);
    }
}
