using System;
using System.Threading.Tasks;

namespace FikaAmazonAPI
{
    public interface ILogger
    {
        void LogDebug(string message);
        void LogInfo(string message);
    }
    
    public class DefaultLogger : ILogger
    {
        public void LogDebug(string message)
        {
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}