using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class PptFileConversion
    {
        public static void Run(string outputPdf)
        {
            PowerPointConversionOptions options = new PowerPointConversionOptions(false);

            PowerPointConverter pptConverter = new PowerPointConverter(Program.GetResourcePath(@"DocumentA.pptx"), options);

            pptConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("OfficePptFileConversion Example Executed.");
        }
    }
}
