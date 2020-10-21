Imports ceTe.DynamicPDF.Conversion

Public Class ExcelFileConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As ExcelConversionOptions = New ExcelConversionOptions(False)
        Dim wordDocConverter As ExcelConverter = New ExcelConverter(Program.GetResourcePath("DocumentA.xlsx"), options)
        wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("OfficeExcelFileConversion Example Executed.")

    End Sub
End Class
