using FikaAmazonAPI.Utils;
using Microsoft.Extensions.Logging;

namespace FikaAmazonAPI.SampleCode;

public class CustomLogger : IFikaAmazonLogger
{
    private readonly ILogger _logger;

    public CustomLogger(ILogger logger)
    {
        _logger = logger;
    }
    
    public void LogDebug(string message)
    {
        _logger.LogDebug(message);
    }

    public void LogInfo(string message)
    {
        _logger.LogInformation(message);
    }
}