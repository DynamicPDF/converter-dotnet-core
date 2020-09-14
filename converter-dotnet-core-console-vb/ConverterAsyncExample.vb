Imports System.IO
Imports ceTe.DynamicPDF.Conversion

Public Class ConverterAsyncExample

    Public Shared Async Function RunTextAsync(outputPdf As String) As Task
        Dim ConversionOptions As ConversionOptions = New ConversionOptions(PageSize.Letter, PageOrientation.Portrait, 75)
        Dim result As Byte() = Await Converter.ConvertAsync(Program.GetResourcePath("DocumentA.txt"), ConversionOptions)
        If result IsNot Nothing Then
            File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result)
        End If
    End Function

    Public Shared Async Function RunHtmlAsync(outputPdf As String) As Task
        Dim htmlString As String = "<html><head><title>ceTe software</title></head><body>DynamicPDF Converter</body></html>"

        Await Converter.ConvertHtmlStringAsync(htmlString, (Program.GetOutputDocPath(outputPdf)))
    End Function
End Class
