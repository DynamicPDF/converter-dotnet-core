using ceTe.DynamicPDF.Conversion;
using System;

namespace converter_dotnet_core_console_cs
{
    public class HtmlConversion
    {
        public static void Run()
        {
            ConvertUri(@"HtmlURIConversion-output.pdf");
            ConvertString(@"HtmlStringConversion-output.pdf");
            ConvertOptions(@"HtmlStringConversionOptions-output.pdf");
            ConvertAppend(@"HtmlStringConversionAppend-output.pdf");

        }

        public static void ConvertUri(string outputPdf)
        {
            HtmlConverter htmlConverter = new HtmlConverter(new Uri("http://www.google.com"));
            htmlConverter.Convert(Program.GetOutputDocPath(outputPdf));

        }

        public static void ConvertString(string outputPdf)
        {
            string html = "<html><body><p>This is a very simple HTML" 
                + "string including a table.</p>"
                + "<h4>Two rows and three columns:</h4>"
                + "<table border=\"1\"><tr><td>100</td>"
                + "<td>200</td><td>300</td></tr><tr><td>"
                + "400</td><td>500</td><td>600</td></tr>"
                + "</table></body></html>";
            
            HtmlConverter htmlConverter = new(html);
            htmlConverter.Convert(Program.GetOutputDocPath(outputPdf));
        }

        public static void ConvertOptions(string outputPdf)
        {
            string html = "<html><body><p>Very simple HTML"
                + "</p></body></html>";

            HtmlConversionOptions conversionOptions = new HtmlConversionOptions(PageSize.A4, PageOrientation.Landscape, 36);

            HtmlConverter htmlConverter = new(html, conversionOptions);
            htmlConverter.Convert(Program.GetOutputDocPath(outputPdf));
        }

        public static void ConvertAppend(string outputPdf)
        {
            string html = "<html><body><p>Very simple HTML."
                + "</p></body></html>";
            
            HtmlConverter converter = new(new Uri("http://www.google.com"));
            converter.Convert(Program.GetOutputDocPath(outputPdf));

            HtmlConversionOptions options = new(PageSize.A4, PageOrientation.Landscape, 36);
            options.AppendToPdf = true;
            HtmlConverter converterB = new(html, options);
            converterB.Convert(Program.GetOutputDocPath(outputPdf));
        }

    }
}



