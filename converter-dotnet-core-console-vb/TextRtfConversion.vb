Imports System.IO
Imports ceTe.DynamicPDF.Conversion

Public Class TextRtfConversion
    Public Shared Sub Run()
        ConvertText("TextConversion-output.pdf")
        ConvertTextAppendByte("TextConversion-append-output.pdf")
        ConvertRtf("RtfConversion-output.pdf")
    End Sub

    Public Shared Sub ConvertText(outputPdf As String)
        Dim options As New TextConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Dim converter As New TextConverter(File.ReadAllText(Program.GetResourcePath("DocumentA.txt")), options)
        converter.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub

    Public Shared Sub ConvertTextAppendByte(outputPdf As String)
        Dim bytes As Byte() = File.ReadAllBytes(Program.GetResourcePath("DocumentA.pdf"))
        Dim converter As New TextConverter(File.ReadAllText(Program.GetResourcePath("DocumentA.txt")))
        Dim output As Byte() = converter.Convert(bytes)
        File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), output)
    End Sub

    Public Shared Sub ConvertRtf(outputPdf As String)
        Dim options As New RtfConversionOptions(PageSize.Legal, PageOrientation.Portrait, 50)
        Dim converter As New RtfConverter(Program.GetResourcePath("DocumentA.rtf"), options)
        converter.Convert(Program.GetOutputDocPath(outputPdf))
    End Sub
End Class

