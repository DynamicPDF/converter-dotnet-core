Imports ceTe.DynamicPDF.Conversion

Public Class PptFileConversion
    Public Shared Sub Run(outputPdf As String)

        Dim options As PowerPointConversionOptions = New PowerPointConversionOptions(False)
        Dim powerPointConverter As PowerPointConverter = New PowerPointConverter(Program.GetResourcePath("DocumentA.pptx"), options)
        powerPointConverter.Convert(Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("OfficePptFileConversion Example Executed.")

    End Sub
End Class
