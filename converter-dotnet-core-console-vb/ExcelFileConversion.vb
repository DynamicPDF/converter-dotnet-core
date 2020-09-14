Imports ceTe.DynamicPDF.Conversion

Public Class ExcelFileConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As WordConversionOptions = New WordConversionOptions(False)
        Dim wordDocConverter As WordConverter = New WordConverter(Program.GetResourcePath("DocumentA.xlsx"), options)
        wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("OfficeExcelFileConversion Example Executed.")

    End Sub
End Class
