using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class TiffImageConversion
    {
        public static void Run(string outputPdf)
        {
            ImageConversionOptions options = new ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);

            ImageConverter imageConverter = new ImageConverter(Program.GetResourcePath(@"DocumentA.tiff"), options);

            imageConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("TiffImageConversion Example Executed.");
        }
    }
}
