using ceTe.DynamicPDF.Conversion;
using System;

namespace converter_dotnet_core_console_cs
{
    public class ExcelFileConversion
    {
        public static void Run()
        {
            ExcelFileConversion.SimpleConvert(@"excel-simple-convert-output.pdf");
            ConvertExcel(@"excel-convert-output.pdf");
            ConvertExcelOptions(@"excel-convert-options-output.pdf");
        }

        public static void SimpleConvert(string outputPdf)
        {
            Converter.Convert(Program.GetResourcePath(@"DocumentA.xlsx"), Program.GetOutputDocPath(outputPdf));
        }

        public static void ConvertExcel(string outputPdf)
        {

            ExcelConversionOptions options = new ExcelConversionOptions(false);
            ExcelConverter excelConverter = new ExcelConverter(Program.GetResourcePath(@"DocumentA.xlsx"), options);
            excelConverter.Convert(Program.GetOutputDocPath(outputPdf));
            Console.WriteLine("OfficeExcelFileConversion Example Executed.");
        }

        public static void ConvertExcelOptions(string outputPdf)
        {
            ExcelConversionOptions options = new ExcelConversionOptions(false);
            options.PageSize = ExcelPageSize.Executive;
            options.Orientation = PageOrientation.Landscape;
            options.Author = "John Doe";

            ExcelConverter excelConverter = new ExcelConverter(Program.GetResourcePath(@"sample-data.xlsx"), options);
            excelConverter.Convert(Program.GetOutputDocPath(outputPdf));
        }

    }
}
