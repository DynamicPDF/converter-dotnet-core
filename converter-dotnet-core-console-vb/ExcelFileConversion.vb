Imports ceTe.DynamicPDF.Conversion

Public Class ExcelFileConversion

    Public Shared Sub Run()
        SimpleConvert("excel-simple-convert-output.pdf")
        ConvertExcel("excel-convert-output.pdf")
        ConvertExcelOptions("excel-convert-options-output.pdf")
    End Sub

    Public Shared Sub SimpleConvert(outputPdf As String)
        Converter.Convert(Program.GetResourcePath(@"DocumentA.xlsx"), Program.GetOutputDocPath(outputPdf))
    End Sub

    Public Shared Sub ConvertExcel(outputPdf As String)
        Dim options As New ExcelConversionOptions(False)
        Dim excelConverter As New ExcelConverter(Program.GetResourcePath("DocumentA.xlsx"), options)
        excelConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("OfficeExcelFileConversion Example Executed.")
    End Sub

    Public Shared Sub ConvertExcelOptions(outputPdf As String)
        Dim options As New ExcelConversionOptions(False)
        options.PageSize = ExcelPageSize.Executive
        options.Orientation = PageOrientation.Landscape
        options.Author = "John Doe"

        Dim excelConverter As New ExcelConverter(Program.GetResourcePath("sample-data.xlsx"), options)
        excelConverter.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub

End Class

