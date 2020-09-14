Imports ceTe.DynamicPDF.Conversion

Public Class XmlFileConversion
    Public Shared Sub Run(outputPdf As String)

        Converter.Convert(Program.GetResourcePath("DocumentA.xml"), Program.GetOutputDocPath(outputPdf))
        Console.WriteLine("XmlFileConversion Example Executed.")

    End Sub
End Class
