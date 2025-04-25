using System.IO;
using System.Text.RegularExpressions;


namespace converter_dotnet_core_console_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterConversions.Convert();
            ConvertAsyncExample.Run();
            EventHandlingConversion.Run();
            ExcelFileConversion.Run();
            GifImageConversion.Run(@"GifImageConversion.pdf");
            HtmlConversion.Run();
            JpgImageConversion.Run(@"JpgImageConversion.pdf");
            LoggingExample.LogConfiguration();
            MhtmlFileConversion.Run(@"MhtmlFileConversion.pdf");
            OtherConversions.Run();
            PngImageConversion.Run(@"PngImageConversion.pdf");
            PptFileConversion.Run();
            TextRtfConversion.Run();
            TiffImageConversion.Run();
            WordFileConversion.Run();
            XmlFileConversion.Run(@"XmlConversion.pdf");
        }


        public static string GetResourcePath(string inputFileName)
        {
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return System.IO.Path.Combine(appRoot, "Resources", inputFileName);
        }

        public static string GetOutputDocPath(string outputfileName)
        {
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            if (!Directory.Exists(Path.Combine(appRoot, "OutputFiles")))
            {
                Directory.CreateDirectory(System.IO.Path.Combine(appRoot, "OutputFiles"));
            }

            return System.IO.Path.Combine(appRoot, "OutputFiles", outputfileName);
        }
    }
}
