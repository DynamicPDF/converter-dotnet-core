using ceTe.DynamicPDF.Conversion;

namespace converter_dotnet_core_console_cs
{
    class ConverterConversions
    {
        public static void Convert()
        {
            SimpleImage(@"simple-image-output.pdf");
            SimpleHtml(@"simple-html-output.pdf");
            SimpleText(@"simple-text-output.pdf");
            SimpleText(@"simple-word-output.pdf");
            SimpleConversionOptions(@"simple-conversion-options-output.pdf");
            SimpleImageConversion(@"simple-image-conversion-output.pdf");
        }

        public static void SimpleImage(string outputPdf)
        {
            ImageConversionOptions options = new ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);
            options.ExpandToFit = true;
            Converter.Convert(Program.GetResourcePath(@"large-logo.png"), Program.GetOutputDocPath(outputPdf), options);
        }

        public static void SimpleHtml(string outputPdf)
        {
            string html = "<html><body><p>Very simple HTML."
                + "</p></body></html>";
            Converter.ConvertHtmlString(html, Program.GetOutputDocPath(outputPdf));
        }

        public static void SimpleWord(string outputPdf)
        {
            ConversionOptions options = new ConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);
            Converter.Convert(Program.GetResourcePath(@"DocumentA.doc"), Program.GetOutputDocPath(outputPdf), options);
        }

        public static void SimpleText(string outputPdf)
        {
            ConversionOptions options = new ConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);
            Converter.Convert(Program.GetResourcePath(@"DocumentA.txt"), Program.GetOutputDocPath(outputPdf), options);
        }

        public static void SimpleConversionOptions(string outputPdf)
        {
            ConversionOptions options = new ConversionOptions(720, 720, 72, true);
            Converter.Convert(Program.GetResourcePath(@"DocumentA.doc"), outputPdf, options);
        }

        public static void SimpleImageConversion(string outputPdf)
        {
            ImageConversionOptions options = new ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50);
            Converter.Convert(Program.GetResourcePath(@"DocumentA.png"), Program.GetOutputDocPath(outputPdf), options);
        }
    }
}
