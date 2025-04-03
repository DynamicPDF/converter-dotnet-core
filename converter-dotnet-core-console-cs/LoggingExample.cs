using ceTe.DynamicPDF.Conversion;
using System;

namespace converter_dotnet_core_console_cs
{
    class LoggingExample
    {
        public static void LogConfiguration()
        {
            ConversionOptions.Logging.Level = LogLevel.Debug;
            ConversionOptions.Logging.LogFilePath = @"C:\temp\LogFile.txt";
            //ConversionOptions.Logging.LogAction = DelegateMethod;
        }

        public static void DelegateMethod(LogIdentifier identifier, LogLevel logLevel, string message)
        {
            Console.WriteLine(logLevel + "|" + identifier + "|" + message);
        }
    }
}
