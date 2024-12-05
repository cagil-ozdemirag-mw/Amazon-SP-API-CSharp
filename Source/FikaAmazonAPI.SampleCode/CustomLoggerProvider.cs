using FikaAmazonAPI.Utils;
using Microsoft.Extensions.Logging;

namespace FikaAmazonAPI.SampleCode;

public class CustomLoggerProvider : IFikaAmazonLoggerProvider
{
    private readonly ILoggerFactory _loggerFactory;
    
    public CustomLoggerProvider(ILoggerFactory loggerFactory)
    {
        _loggerFactory = loggerFactory;
    }
    
    public IFikaAmazonLogger CreateLogger(string categoryName)
    {
        return new CustomLogger(_loggerFactory.CreateLogger(categoryName));
    }
}