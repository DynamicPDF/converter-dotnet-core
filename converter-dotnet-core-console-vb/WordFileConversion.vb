Imports ceTe.DynamicPDF.Conversion

Public Class WordFileConversion
    Public Shared Sub Run()
        SimpleWordConversion("word-simple-conversion-output.pdf")
        ConversionOptionsExample("word-conversion-options-output.pdf")
        ConvertBookmarks("word-bookmarks-output.pdf")
    End Sub

    Public Shared Sub SimpleWordConversion(outputPdf As String)
        Dim wordDocConverter As New WordConverter(Program.GetResourcePath("sample.doc"))
        wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub

    Public Shared Sub ConversionOptionsExample(outputPdf As String)
        Dim options As New WordConversionOptions(False)
        options.Author = "John Doe"
        options.TopMargin = 144
        options.BottomMargin = 72
        options.LeftMargin = 72
        options.RightMargin = 72

        Dim wordDocConverter As New WordConverter(Program.GetResourcePath("sample.doc"), options)
        wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub

    Public Shared Sub ConvertBookmarks(outputPdf As String)
        Dim conversionOptions As New WordConversionOptions(False)
        conversionOptions.BookmarksType = WordBookmarksType.Headings

        Dim converter As New WordConverter(Program.GetResourcePath("sample.doc"), conversionOptions)
        converter.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub
End Class


