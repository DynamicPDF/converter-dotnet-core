using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class GifImageConversion
    {
        public static void Run(string outputPdf)
        {
            ImageConversionOptions options = new ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);

            ImageConverter imageConverter = new ImageConverter(Program.GetResourcePath(@"DocumentA.gif"), options);

            imageConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("GifImageConversion Example Executed.");
        }
    }
}
