using ceTe.DynamicPDF.Conversion;

namespace converter_dotnet_core_console_cs
{
    class WordFileConversion
    {
        public static void Run(string outputPath)
        {
            WordConversionOptions options = new WordConversionOptions(false);
            options.Author = "John Doe";
            options.TopMargin = 144;
            options.BottomMargin = 72;
            options.LeftMargin = 72;
            options.RightMargin = 72;
            WordConverter wordDocConverter = new WordConverter(Program.GetResourcePath(@"sample.doc"), options);
            wordDocConverter.Convert(Program.GetOutputDocPath("sample.pdf"));
        }
    }
}
