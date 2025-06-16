using ceTe.DynamicPDF.Conversion;

namespace converter_dotnet_core_console_cs
{
    class SimpleConversionConverter
    {
        public static void Run()
        {
            TextConvert();
            RTFConvert();
            WordConvert();
            PowerPointConvert();
            ExcelConvert();
            ImageConvert();
            HtmlConvert();
        }

        private static void TextConvert()
        {
            Converter.Convert(Program.GetResourcePath("DocumentA.txt"), Program.GetOutputDocPath("simple-txt-output.pdf"));
        }

        private static void RTFConvert()
        {
            Converter.Convert(Program.GetResourcePath("DocumentA.rtf"), Program.GetOutputDocPath("simple-rtf-output.pdf"));
        }

        private static void WordConvert()
        {
            Converter.Convert(Program.GetResourcePath("DocumentA.doc"), Program.GetOutputDocPath("simple-doc-output.pdf"));
        }

        private static void PowerPointConvert()
        {
            Converter.Convert(Program.GetResourcePath("DocumentA.pptx"), Program.GetOutputDocPath("simple-pptx-output.pdf"));
        }
        private static void ExcelConvert()
        {
            Converter.Convert(Program.GetResourcePath("DocumentA.xlsx"), Program.GetOutputDocPath("simple-xlsx-output.pdf"));
        }

        private static void ImageConvert()
        {
            Converter.Convert(Program.GetResourcePath("DocumentA.gif"), Program.GetOutputDocPath("simple-gif-output.pdf"));
        }

        private static void HtmlConvert()
        {
            Converter.Convert(Program.GetResourcePath("moby-dick.html"), Program.GetOutputDocPath("simple-html-output.pdf"));
        }


    }
}
