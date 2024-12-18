Imports ceTe.DynamicPDF.Conversion

Public Class WordFileConversion
    Public Shared Sub Run()
        Dim options As New WordConversionOptions(False)
        options.Author = "John Doe"
        options.TopMargin = 144
        options.BottomMargin = 72
        options.LeftMargin = 72
        options.RightMargin = 72

        Dim wordDocConverter As New WordConverter(Program.GetResourcePath("sample.doc"), options)
        wordDocConverter.Convert(Program.GetOutputDocPath("sample.pdf"))
    End Sub
End Class

