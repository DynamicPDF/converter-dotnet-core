Imports ceTe.DynamicPDF.Conversion
Imports System

Public Class HtmlConversion
        Public Shared Sub Run()
            ConvertUri("HtmlURIConversion-output.pdf")
            ConvertString("HtmlStringConversion-output.pdf")
            ConvertOptions("HtmlStringConversionOptions-output.pdf")
            ConvertAppend("HtmlStringConversionAppend-output.pdf")
        End Sub

        Public Shared Sub ConvertUri(outputPdf As String)
            Dim htmlConverter As New HtmlConverter(New Uri("http://www.google.com"))
            htmlConverter.Convert(Program.GetOutputDocPath(outputPdf))
        End Sub

        Public Shared Sub ConvertString(outputPdf As String)
            Dim html As String = "<html><body><p>This is a very simple HTML" &
                "string including a table.</p>" &
                "<h4>Two rows and three columns:</h4>" &
                "<table border=""1""><tr><td>100</td>" &
                "<td>200</td><td>300</td></tr><tr><td>" &
                "400</td><td>500</td><td>600</td></tr>" &
                "</table></body></html>"

            Dim htmlConverter As New HtmlConverter(html)
            htmlConverter.Convert(Program.GetOutputDocPath(outputPdf))
        End Sub

        Public Shared Sub ConvertOptions(outputPdf As String)
            Dim html As String = "<html><body><p>Very simple HTML" &
                "</p></body></html>"

            Dim conversionOptions As New HtmlConversionOptions(PageSize.A4, PageOrientation.Landscape, 36)

            Dim htmlConverter As New HtmlConverter(html, conversionOptions)
            htmlConverter.Convert(Program.GetOutputDocPath(outputPdf))
        End Sub

        Public Shared Sub ConvertAppend(outputPdf As String)
            Dim html As String = "<html><body><p>Very simple HTML." &
                "</p></body></html>"

            Dim converter As New HtmlConverter(New Uri("http://www.google.com"))
            converter.Convert(Program.GetOutputDocPath(outputPdf))

            Dim options As New HtmlConversionOptions(PageSize.A4, PageOrientation.Landscape, 36)
            options.AppendToPdf = True
            Dim converterB As New HtmlConverter(html, options)
            converterB.Convert(Program.GetOutputDocPath(outputPdf))
        End Sub
    End Class

