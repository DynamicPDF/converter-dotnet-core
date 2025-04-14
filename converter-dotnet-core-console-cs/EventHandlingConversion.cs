
using ceTe.DynamicPDF.Conversion;
using System;

namespace converter_dotnet_core_console_cs
{
    class EventHandlingConversion
    {
        public static void Run()
        {
            EventExcelExample(@"event-excel-output.pdf");
        }


        public static void EventWordExample(string outputPdf)
        {
            WordConverter word = new WordConverter(Program.GetResourcePath(@"DocumentA.doc"));
            word.ProgressChanged += new ProgressChanged(converter_progresschanged);
            word.Completed += new ConversionCompleted(converter_completed);
            word.Convert(Program.GetOutputDocPath(outputPdf));
        }

        public static void EventExcelExample(string outputPdf)
        {
            ExcelConverter excel = new ExcelConverter(Program.GetResourcePath(@"DocumentA.xlsx"));
            excel.DocumentParsing += new ExcelDocumentParsing(converter_documentparsing);
            excel.ProgressChanged += new ProgressChanged(converter_progresschanged);
            excel.Completed += new ConversionCompleted(converter_completed);
            excel.Convert(Program.GetOutputDocPath(outputPdf));
        }


        public static void converter_progresschanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.Status);
        }

        static void converter_documentparsing(object sender, ExcelDocumentParsingEventArgs e)
        {
            Console.WriteLine("parsing spreadsheet");

            foreach (ExcelWorksheet excelWorksheet in e.Worksheets)
            {
                Console.WriteLine("Parsing a worksheet");
            }
        }

        public static void converter_completed(object sender, ConversionCompletedEventArgs e)
        {
            if (e.FailException != null)
                Console.WriteLine("Conversion failed with:" + e.FailException.Message);
            else Console.WriteLine("Conversion completed");
        }

    }
}
