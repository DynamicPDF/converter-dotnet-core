using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class HtmlFileConversion
    {
        public static void Run(string outputPdf)
        {
            HtmlConversionOptions options = new HtmlConversionOptions(false);

            HtmlConverter htmlConverter = new HtmlConverter(new Uri("http://www.google.com"), options);

            htmlConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("HtmlFileConversion Example Executed.");
        }
    }
}
