using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class TiffImageConversion
    {
        public static void Run()
        {
            Single(@"tiff-output.pdf");
            MultiPage(@"tiff-multipage-output.pdf");
        }

        public static void Single(string outputPdf)
        {
            ImageConversionOptions options = new ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);
            ImageConverter imageConverter = new ImageConverter(Program.GetResourcePath(@"DocumentA.tiff"), options);
            imageConverter.Convert(Program.GetOutputDocPath(outputPdf));
            Console.WriteLine("TiffImageConversion Example Executed.");
        }

        public static void MultiPage(string outputPdf)
        {
            TiffConversionOptions options = new TiffConversionOptions(false);
            options.PageRange.StartPageNumber = 3;
            options.PageRange.EndPageNumber = 5;
            ImageConverter converter = new ImageConverter(Program.GetResourcePath(@"fw9_18.tif"), options);
            converter.Convert(Program.GetOutputDocPath(outputPdf));
        }

    }
}
