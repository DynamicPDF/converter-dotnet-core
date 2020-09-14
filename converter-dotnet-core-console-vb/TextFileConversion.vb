Imports System.IO
Imports ceTe.DynamicPDF.Conversion

Public Class TextFileConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As TextConversionOptions = New TextConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Dim textConverter As TextConverter = New TextConverter(File.ReadAllText(Program.GetResourcePath("DocumentA.txt")), options)
        textConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("TxtFileConversion Example Executed.")

    End Sub
End Class
