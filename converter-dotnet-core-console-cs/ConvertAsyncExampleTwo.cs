using ceTe.DynamicPDF.Conversion;
using System.IO;
using System.Threading.Tasks;

namespace converter_dotnet_core_console_cs
{
    class ConvertAsyncExampleTwo
    {
        public static async Task Process()
        {
            byte[] result = await Converter.ConvertAsync(Program.GetResourcePath(@"DocumentA.txt"));
            if (result != null)
            {
                File.WriteAllBytes(Program.GetOutputDocPath(@"test-output.pdf"), result);

            }
        }
        public static void Run()
        {
            Process().Wait();
        }
    }
}
