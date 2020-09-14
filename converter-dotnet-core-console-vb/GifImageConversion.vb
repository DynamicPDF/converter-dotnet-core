Imports ceTe.DynamicPDF.Conversion

Public Class GifImageConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As ImageConversionOptions = New ImageConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Dim imageConverter As ImageConverter = New ImageConverter(Program.GetResourcePath("DocumentA.gif"), options)
        imageConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("GifImageConversion Example Executed.")

    End Sub
End Class
