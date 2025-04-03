Imports ceTe.DynamicPDF.Conversion

Class ConverterConversions
    Public Shared Sub Convert()
        SimpleImage("simple-image-output.pdf")
        SimpleHtml("simple-html-output.pdf")
        SimpleText("simple-text-output.pdf")
        SimpleWord("simple-word-output.pdf")
    End Sub

    Public Shared Sub SimpleImage(ByVal outputPdf As String)
        Dim options As New ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        options.ExpandToFit = True
        Converter.Convert(Program.GetResourcePath("large-logo.png"), Program.GetOutputDocPath(outputPdf), options)
    End Sub

    Public Shared Sub SimpleHtml(ByVal outputPdf As String)
        Dim html As String = "<html><body><p>Very simple HTML." & "</p></body></html>"
        Converter.ConvertHtmlString(html, Program.GetOutputDocPath(outputPdf))
    End Sub

    Public Shared Sub SimpleWord(ByVal outputPdf As String)
        Dim options As New ConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Converter.Convert(Program.GetResourcePath("DocumentA.doc"), Program.GetOutputDocPath(outputPdf), options)
    End Sub

    Public Shared Sub SimpleText(ByVal outputPdf As String)
        Dim options As New ConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Converter.Convert(Program.GetResourcePath("DocumentA.txt"), Program.GetOutputDocPath(outputPdf), options)
    End Sub
End Class
