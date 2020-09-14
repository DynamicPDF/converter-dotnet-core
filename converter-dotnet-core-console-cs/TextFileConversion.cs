using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class TextFileConversion
    {
        public static void Run(string outputPdf)
        {
            TextConversionOptions options = new TextConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);

            TextConverter textConverter = new TextConverter(File.ReadAllText(Program.GetResourcePath(@"DocumentA.txt")), options);

            textConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("TxtFileConversion Example Executed.");
        }
    }
}
