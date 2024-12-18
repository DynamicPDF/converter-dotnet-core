using System.IO;
using System.Text.RegularExpressions;

namespace converter_dotnet_core_console_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            WordFileConversion.Run("word-sample.pdf");
            /*
            ConvertAsyncExample.RunText("ConvertAsyncText.pdf").Wait();
            ConvertAsyncExample.RunHtml("ConvertAsyncHtml.pdf").Wait();
           
            HtmlFileConversion.Run(@"HtmlFileConversion.pdf");
            MhtmlFileConversion.Run(@"MhtmlFileConversion.pdf");
            TextFileConversion.Run(@"TextConversion.pdf");
            XmlFileConversion.Run(@"XmlConversion.pdf");

            GifImageConversion.Run(@"GifImageConversion.pdf");
            JpegImageConversion.Run(@"JpegImageConversion.pdf");
            JpgImageConversion.Run(@"JpgImageConversion.pdf");
            PngImageConversion.Run(@"PngImageConversion.pdf");
            TiffImageConversion.Run(@"TiffImageConversion.pdf");

            ExcelFileConversion.Run(@"ExcelFileConversion.pdf");
            DocFileConversion.Run(@"DocFileConversion.pdf");
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
