Imports ceTe.DynamicPDF.Conversion

Class EventHandlingConversion

    Public Shared Sub Run()
        EventExcelExample("event-excel-output.pdf")
    End Sub

    Public Shared Sub EventWordExample(outputPdf As String)
        Dim word As New WordConverter(Program.GetResourcePath("DocumentA.doc"))
        AddHandler word.ProgressChanged, AddressOf converter_progresschanged
        AddHandler word.Completed, AddressOf converter_completed
        word.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub

    Public Shared Sub EventExcelExample(outputPdf As String)
        Dim excel As New ExcelConverter(Program.GetResourcePath("DocumentA.xlsx"))
        AddHandler excel.DocumentParsing, AddressOf converter_documentparsing
        AddHandler excel.ProgressChanged, AddressOf converter_progresschanged
        AddHandler excel.Completed, AddressOf converter_completed
        excel.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub

    Public Shared Sub converter_progresschanged(sender As Object, e As ProgressChangedEventArgs)
        Console.WriteLine(e.Status)
    End Sub

    Private Shared Sub converter_documentparsing(sender As Object, e As ExcelDocumentParsingEventArgs)
        Console.WriteLine("parsing spreadsheet")

        For Each excelWorksheet As ExcelWorksheet In e.Worksheets
            Console.WriteLine("Parsing a worksheet")
        Next
    End Sub

    Public Shared Sub converter_completed(sender As Object, e As ConversionCompletedEventArgs)
        If e.FailException IsNot Nothing Then
            Console.WriteLine("Conversion failed with:" & e.FailException.Message)
        Else
            Console.WriteLine("Conversion completed")
        End If
    End Sub

End Class
