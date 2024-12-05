using System;
using System.Diagnostics;

namespace FikaAmazonAPI.Utils
{
    public interface IFikaAmazonLogger
    {
        void LogDebug(string message);
        void LogInfo(string message);
    }
    
    public sealed class DefaultFikaAmazonLogger : IFikaAmazonLogger
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