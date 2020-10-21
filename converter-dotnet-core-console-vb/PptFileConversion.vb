Imports ceTe.DynamicPDF.Conversion

Public Class PptFileConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As PowerPointConversionOptions = New PowerPointConversionOptions(False)
        Dim wordDocConverter As PowerPointConverter = New PowerPointConverter(Program.GetResourcePath("DocumentA.pptx"), options)
        wordDocConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("OfficePptFileConversion Example Executed.")

    End Sub
End Class
