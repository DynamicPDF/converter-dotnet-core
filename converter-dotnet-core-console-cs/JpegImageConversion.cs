using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class JpegImageConversion
    {
        public static void Run(string outputPdf)
        {
            ImageConversionOptions options = new ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);

            ImageConverter imageConverter = new ImageConverter(Program.GetResourcePath(@"DocumentA.jpeg"), options);

            imageConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("JpegImageConversion Example Executed.");
        }
    }
}
