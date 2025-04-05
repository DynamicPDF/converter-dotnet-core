
using ceTe.DynamicPDF.Conversion;

namespace converter_dotnet_core_console_cs
{
    public class WordFileConversion
    {
        public static void Run()
        {
            SimpleWordConversion(@"word-simple-conversion-output.pdf");
            ConversionOptionsExample(@"word-conversion-options-output.pdf");
            ConvertBookmarks(@"word-bookmarks-output.pdf");
        }

        public static void SimpleWordConversion(string outputPdf)
        {
            WordConverter wordDocConverter = new WordConverter(Program.GetResourcePath(@"sample.doc"));
            wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf));
        }

        public static void ConversionOptionsExample(string outputPdf)
        {
            WordConversionOptions options = new WordConversionOptions(false);
            options.Author = "John Doe";
            options.TopMargin = 144;
            options.BottomMargin = 72;
            options.LeftMargin = 72;
            options.RightMargin = 72;
            WordConverter wordDocConverter = new WordConverter(Program.GetResourcePath(@"sample.doc"), options);
            wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf));
        }

        public static void ConvertBookmarks(string outputPdf)
        {
            WordConversionOptions conversionOptions = new(false);
            conversionOptions.BookmarksType = WordBookmarksType.Headings;
            WordConverter converter = new(Program.GetResourcePath(@"sample.doc"), conversionOptions);
            converter.Convert(Program.GetOutputDocPath(outputPdf));
        }

    }
}
