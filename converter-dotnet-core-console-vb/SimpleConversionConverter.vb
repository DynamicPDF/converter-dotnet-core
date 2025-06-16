Imports ceTe.DynamicPDF.Conversion

Class SimpleConversionConverter

    Public Shared Sub Run()
        TextConvert()
        RTFConvert()
        WordConvert()
        PowerPointConvert()
        ExcelConvert()
        ImageConvert()
        HtmlConvert()
    End Sub

    Private Shared Sub TextConvert()
        Converter.Convert(Program.GetResourcePath("DocumentA.txt"), Program.GetOutputDocPath("simple-txt-output.pdf"))
    End Sub

    Private Shared Sub RTFConvert()
        Converter.Convert(Program.GetResourcePath("DocumentA.rtf"), Program.GetOutputDocPath("simple-rtf-output.pdf"))
    End Sub

    Private Shared Sub WordConvert()
        Converter.Convert(Program.GetResourcePath("DocumentA.doc"), Program.GetOutputDocPath("simple-doc-output.pdf"))
    End Sub

    Private Shared Sub PowerPointConvert()
        Converter.Convert(Program.GetResourcePath("DocumentA.pptx"), Program.GetOutputDocPath("simple-pptx-output.pdf"))
    End Sub

    Private Shared Sub ExcelConvert()
        Converter.Convert(Program.GetResourcePath("DocumentA.xlsx"), Program.GetOutputDocPath("simple-xlsx-output.pdf"))
    End Sub

    Private Shared Sub ImageConvert()
        Converter.Convert(Program.GetResourcePath("DocumentA.gif"), Program.GetOutputDocPath("simple-gif-output.pdf"))
    End Sub

    Private Shared Sub HtmlConvert()
        Converter.Convert(Program.GetResourcePath("moby-dick.html"), Program.GetOutputDocPath("simple-html-output.pdf"))
    End Sub

End Class

