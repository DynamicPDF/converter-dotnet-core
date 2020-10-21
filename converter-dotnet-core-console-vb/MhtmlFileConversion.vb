Imports ceTe.DynamicPDF.Conversion

Public Class MhtmlFileConversion
    Public Shared Sub Run(outputPdf As String)

        Converter.Convert(Program.GetResourcePath("DocumentA.mht"), Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("MhtmlFileConversion Example Executed.")

    End Sub
End Class
