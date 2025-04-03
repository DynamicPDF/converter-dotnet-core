using ceTe.DynamicPDF.Conversion;
using System.IO;

namespace converter_dotnet_core_console_cs
{
    public class TextRtfConversion
    {
        public static void Run()
        {
            ConvertText(@"TextConversion-output.pdf");
            ConvertTextAppendByte(@"TextConversion-append-output.pdf");
            ConvertRtf(@"RtfConversion-output.pdf");
        }

        public static void ConvertText(string outputPdf)
        {
            TextConversionOptions options = new TextConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);
            TextConverter converter = new TextConverter(File.ReadAllText(Program.GetResourcePath(@"DocumentA.txt")), options);
            converter.Convert(Program.GetOutputDocPath(outputPdf));
        }

        public static void ConvertTextAppendByte(string outputPdf)
        {
            byte[] bytes = File.ReadAllBytes(Program.GetResourcePath(@"DocumentA.pdf"));
            TextConverter converter = new TextConverter(File.ReadAllText(Program.GetResourcePath(@"DocumentA.txt")));
            byte[] output = converter.Convert(bytes);
            File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), output);
        }

        public static void ConvertRtf(string outputPdf)
        {
           RtfConversionOptions options = new(PageSize.Legal, PageOrientation.Portrait, 50);
           RtfConverter converter = new(Program.GetResourcePath(@"DocumentA.rtf"), options);
           converter.Convert(Program.GetOutputDocPath(outputPdf));
        }
    }
}
