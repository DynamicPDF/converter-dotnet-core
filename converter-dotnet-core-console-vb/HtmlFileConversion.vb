Imports ceTe.DynamicPDF.Conversion

Public Class HtmlFileConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As HtmlConversionOptions = New HtmlConversionOptions(False)
        Dim htmlConverter As HtmlConverter = New HtmlConverter(New Uri("http://www.google.com"), options)
        htmlConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("HtmlFileConversion Example Executed.")

    End Sub
End Class
