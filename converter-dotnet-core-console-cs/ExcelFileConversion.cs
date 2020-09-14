using ceTe.DynamicPDF.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace converter_dotnet_core_console_cs
{
    public class ExcelFileConversion
    {
        public static void Run(string outputPdf)
        {
            ExcelConversionOptions options = new ExcelConversionOptions(false);

            ExcelConverter excelConverter = new ExcelConverter(Program.GetResourcePath(@"DocumentA.xlsx"), options);

            excelConverter.Convert(Program.GetOutputDocPath(outputPdf));

            Console.WriteLine("OfficeExcelFileConversion Example Executed.");
        }
    }
}
