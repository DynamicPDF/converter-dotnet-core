using ceTe.DynamicPDF.Conversion;
using System.IO;
using System.Threading.Tasks;

namespace converter_dotnet_core_console_cs
{
    public class ConvertAsyncExample
    {
        public static async Task RunText(string outputPdf)
        {
            ConversionOptions conversionOptions = new ConversionOptions(PageSize.Letter, PageOrientation.Portrait, 75);
            byte[] result = await Converter.ConvertAsync(Program.GetResourcePath(@"DocumentA.txt"), conversionOptions);
            if (result != null)
            {
                File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result);
            }
        }

        public static async Task RunHtml(string outputPdf)
        {
            string htmlString = "<html><head><title>ceTe software</title></head><body>DynamicPDF Converter</body></html>";

            await Converter.ConvertHtmlStringAsync(htmlString, (Program.GetOutputDocPath(outputPdf)));
        }
    }
}
