using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class DocFileConversion
    {
        public static void Run(string outputPdf)
        {
            WordConversionOptions options = new WordConversionOptions(false);

            WordConverter wordDocConverter = new WordConverter(Program.GetResourcePath(@"DocumentA.doc"), options);
            options.Width = 500;
            options.Height = 600;

            wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("OfficeDocFileConversion Example Executed.");
        }
    }
}