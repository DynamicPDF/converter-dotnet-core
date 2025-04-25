using ceTe.DynamicPDF.Conversion;
using System;
using System.IO;
using System.Threading.Tasks;

namespace converter_dotnet_core_console_cs
{
    public class ConvertAsyncExample
    {
        public static void Run()
        {
          
           var tsk1 = RunTextSaveFile(@"async-text-file-output.pdf");
           var tsk2 = RunTextInputFileName(@"async-text-input-file-name-output.pdf");
           var tsk3 = RunTextBytesConvOpt(@"async-text-bytes-options-output.pdf");
           var tsk4 = RunTextBytesConvAppnd(@"async-text-bytes-append-output.pdf");
           Task.WaitAll(new Task[] {tsk2, tsk1, tsk3, tsk4});
           Console.WriteLine("Conversion Completed successfully");
        }

        public static async Task RunTextInputFileName(string outputPdf)
        {
            byte[] input = File.ReadAllBytes(Program.GetResourcePath(@"DocumentA.txt"));
            byte[] result = await Converter.ConvertAsync(input,Program.GetResourcePath(@"DocumentA.txt"));

            if (result != null)
            {
               File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result);
            }

        }

        public static async Task RunTextBytesConvOpt(string outputPdf)
        {
            ConversionOptions options = new(false);
            byte[] result = await Converter.ConvertAsync(Program.GetResourcePath(@"DocumentA.txt"), options);

            if (result != null)
            {
                File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result);

            }
        }


        public static async Task RunTextBytesConvAppnd(string outputPdf)
        {
            ConversionOptions options = new(false);
            byte[] appendToPdf = File.ReadAllBytes(Program.GetResourcePath(@"DocumentA.pdf"));

            byte[] result = await Converter.ConvertAsync(Program.GetResourcePath(@"DocumentA.txt"), options, appendToPdf);

            if (result != null)
            {
                File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result);

            }
        }


        public static async Task RunTextSaveFile(string outputPdf)
        {

            bool result = await Converter.ConvertAsync(Program.GetResourcePath(@"DocumentA.rtf"), Program.GetOutputDocPath(outputPdf));

            if (result)
            {
                Console.WriteLine("Conversion Completed successfully");
            }
        }

    }
}
