Imports ceTe.DynamicPDF.Conversion

Public Class TiffImageConversion

    Public Shared Sub Run()
        SingleConversion("tiff-output.pdf")
        MultiPage("tiff-multipage-output.pdf")
    End Sub

    Public Shared Sub SingleConversion(outputPdf As String)
        Dim options As New ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Dim imageConverter As New ImageConverter(Program.GetResourcePath("DocumentA.tiff"), options)
        imageConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("TiffImageConversion Example Executed.")
    End Sub

    Public Shared Sub MultiPage(outputPdf As String)
        Dim options As New TiffConversionOptions(False)
        options.PageRange.StartPageNumber = 3
        options.PageRange.EndPageNumber = 5
        Dim converter As New ImageConverter(Program.GetResourcePath("fw9_18.tif"), options)
        converter.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub

End Class
