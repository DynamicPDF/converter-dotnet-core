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
           RunTextBytes(@"async-text-bytes-output.pdf").Wait();
           RunTextSaveFile(@"async-text-file-output.pdf").Wait();
           RunTextInputFileName(@"async-text-input-file-name-output.pdf").Wait();
        }


        public static async Task RunTextInputFileName(string outputPdf)
        {
                      
            byte[] input = File.ReadAllBytes(Program.GetResourcePath(@"DocumentA.txt"));

            //public static Task<Byte[]> ConvertAsync(Byte[] inputData, string inputFileName)

            byte[] result = await Converter.ConvertAsync(input,Program.GetResourcePath(@"DocumentA.txt"));

            if (result != null)
            {
                File.WriteAllBytes(outputPdf, result);
            }

        }



        public static async Task RunTextBytes(string outputPdf)
        {

            //public static Task<Byte[]> ConvertAsync(string inputFilePath)
            
            byte[] result = await Converter.ConvertAsync(Program.GetResourcePath(@"DocumentA.txt"));
                       
            if (result != null)
            {
                File.WriteAllBytes(outputPdf, result);
            }

        }

        public static async Task RunTextSaveFile(string outputPdf)
        {
            //works - produces file as expected
            //public static Task<bool> ConvertAsync(string sourceFilePath, string outputFilePath)

            bool result = await Converter.ConvertAsync(Program.GetResourcePath(@"DocumentA.txt"), Program.GetOutputDocPath(outputPdf));

            if (result)
            {
                Console.WriteLine("Conversion Completed successfully");

            }
        }

    }
}
