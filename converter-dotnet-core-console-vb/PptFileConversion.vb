Imports ceTe.DynamicPDF.Conversion

Public Class PptFileConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As WordConversionOptions = New WordConversionOptions(False)
        Dim wordDocConverter As WordConverter = New WordConverter(Program.GetResourcePath("DocumentA.pptx"), options)
        wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("OfficeDocFileConversion Example Executed.")

    End Sub
End Class
