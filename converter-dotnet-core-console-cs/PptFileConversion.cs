using ceTe.DynamicPDF.Conversion;
using System;

namespace converter_dotnet_core_console_cs
{
    public class PptFileConversion
    {
        public static void Run()
        {
            SimplePowerpoint(@"ppt_conversion_output.pdf");
            AdvancedPowerpoint(@"ppt_conversion_adv_output.pdf");
        }

        public static void SimplePowerpoint(string outputPdf)
        {
            PowerPointConversionOptions options = new PowerPointConversionOptions(false);

            PowerPointConverter pptConverter = new PowerPointConverter(Program.GetResourcePath(@"DocumentA.pptx"), options);

            pptConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("OfficePptFileConversion Example Executed.");
        }

        public static void AdvancedPowerpoint(string outputPdf)
        {
            PowerPointConversionOptions powerPointConversionOptions = new PowerPointConversionOptions(PageSize.A4, PageOrientation.Portrait, 36);
            HandoutOutputType handout = PowerPointOutputType.Handout;
            handout.HandoutPrintOrder = HandoutPrintOrder.Horizontal;
            handout.SlidesPerPage = SlidesPerPage.Six;
            handout.FrameSlides = true;
            powerPointConversionOptions.OutputType = handout;
            powerPointConversionOptions.OutputType.PrintHiddenSlide = true;
            PowerPointConverter powerPointConverter1 = new PowerPointConverter(Program.GetResourcePath(@"DocumentA.pptx"), powerPointConversionOptions);
            powerPointConverter1.Convert(outputPdf);
        }
    }
}
