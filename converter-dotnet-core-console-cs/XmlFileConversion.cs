using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class XmlFileConversion
    {
        public static void Run(string outputPdf)
        {
            Converter.Convert(Program.GetResourcePath(@"DocumentA.xml"), Program.GetOutputDocPath(outputPdf));
            Console.WriteLine("XmlFileConversion Example Executed.");
        }
    }
}
