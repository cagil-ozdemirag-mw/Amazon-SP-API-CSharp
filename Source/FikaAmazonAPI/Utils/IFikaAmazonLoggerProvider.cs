namespace FikaAmazonAPI.Utils
{
    public interface IFikaAmazonLoggerProvider
    {
        IFikaAmazonLogger CreateLogger(string categoryName);
    }
    
    public sealed class DefaultFikaAmazonLoggerProvider : IFikaAmazonLoggerProvider
    {
        public IFikaAmazonLogger CreateLogger(string categoryName)
        {
            return new DefaultFikaAmazonLogger();
        }
    }
}