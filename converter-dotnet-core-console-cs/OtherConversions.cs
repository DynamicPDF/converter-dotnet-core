
using ceTe.DynamicPDF.Conversion;

namespace converter_dotnet_core_console_cs
{
    class OtherConversions
    {

        public static void Run()
        {
            ConvertCsv(@"CsvConversion-output.pdf");
        }

        public static void ConvertCsv(string outputPdf) {

            ExcelConversionOptions options = new (ExcelPageSize.Executive , PageOrientation.Landscape, 25F, 5F);

            ExcelConverter converter = new(Program.GetResourcePath(@"DocumentA.csv"),  options);

            converter.Convert(Program.GetOutputDocPath(outputPdf));
            
        }




    }



}
