Imports ceTe.DynamicPDF.Conversion

Public Class TiffImageConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As ImageConversionOptions = New ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Dim imageConverter As ImageConverter = New ImageConverter(Program.GetResourcePath("DocumentA.tiff"), options)
        imageConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("TiffImageConversion Example Executed.")

    End Sub
End Class
