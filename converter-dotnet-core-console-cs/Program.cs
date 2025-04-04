using System.IO;
using System.Text.RegularExpressions;

namespace converter_dotnet_core_console_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            PptFileConversion.Run();
            /*
             *             ExcelFileConversion.Run();

            LoggingExample.LogConfiguration();
            ConverterConversions.Convert();
            PptFileConversion.Run();
            HtmlConversion.Run();
            TextRtfConversion.Run();
            WordFileConversion.Run();
            OtherConversions.Run();
            TiffImageConversion.Run();
            WordFileConversion.Run();

            ConvertAsyncExample.RunText("ConvertAsyncText.pdf").Wait();
            ConvertAsyncExample.RunHtml("ConvertAsyncHtml.pdf").Wait();

            MhtmlFileConversion.Run(@"MhtmlFileConversion.pdf");
            XmlFileConversion.Run(@"XmlConversion.pdf");

            GifImageConversion.Run(@"GifImageConversion.pdf");
            JpegImageConversion.Run(@"JpegImageConversion.pdf");
            JpgImageConversion.Run(@"JpgImageConversion.pdf");
            PngImageConversion.Run(@"PngImageConversion.pdf");
            TiffImageConversion.Run();

            ExcelFileConversion.Run(@"ExcelFileConversion.pdf");
            PptFileConversion.Run(@"PptFileConversion.pdf");
            */

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
