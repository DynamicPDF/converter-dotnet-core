using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class MhtmlFileConversion
    {
        public static void Run(string outputPdf)
        {
            Converter.Convert(Program.GetResourcePath(@"DocumentA.mht"), Program.GetOutputDocPath(outputPdf));
            Console.WriteLine("MhtmlFileConversion Example Executed.");
        }
    }
}
