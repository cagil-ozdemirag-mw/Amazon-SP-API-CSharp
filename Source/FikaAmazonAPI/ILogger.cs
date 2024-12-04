using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FikaAmazonAPI
{
    public interface IAmazonApiLogger
    {
        void LogDebug(string message);
        void LogInfo(string message);
    }
    
    public sealed class DefaultAmazonAPILogger : IAmazonApiLogger
    {
        public void LogDebug(string message)
        {
            Debug.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}