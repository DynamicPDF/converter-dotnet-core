Imports System
Imports System.IO
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        SimpleConversionConverter.Run()
        ConverterConversions.Convert()
        HtmlConversion.Run()
        HtmlFileConversion.Run("HtmlConversion.pdf")
        TextRtfConversion.Run()
        WordFileConversion.Run()
        ConvertAsyncExample.Run()
        ConverterAsyncExample.RunTextAsync("ConverterAsyncText.pdf").Wait()
        ConverterAsyncExample.RunHtmlAsync("ConverterAsyncHtml.pdf").Wait()
        EventHandlingConversion.Run()
        MhtmlFileConversion.Run("MhtmlConversion.pdf")
        TextFileConversion.Run("TextConversion.pdf")
        XmlFileConversion.Run("XmlConversion.pdf")
        GifImageConversion.Run("GifImageConversion.pdf")
        JpegImageConversion.Run("JpegImageConversion.pdf")
        JpgImageConversion.Run("JpgImageConversion.pdf")
        PngImageConversion.Run("PngImageConversion.pdf")
        TiffImageConversion.Run()
        ExcelFileConversion.Run()
        DocFileConversion.Run("DocFileConversion.pdf")
        PptFileConversion.Run()
    End Sub

    Public Function GetResourcePath(inputFileName As String) As String
        Dim exePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim appPathMatcher As Regex = New Regex("(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)")
        Dim appRoot As String = appPathMatcher.Match(exePath).Value
        Return System.IO.Path.Combine(appRoot, "Resources", inputFileName)
    End Function


    Public Function GetOutputDocPath(outputfileName As String) As String
        Dim exePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim appPathMatcher As Regex = New Regex("(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)")
        Dim appRoot As String = appPathMatcher.Match(exePath).Value
        If (Not Directory.Exists(Path.Combine(appRoot, "OutputFiles"))) Then
            Directory.CreateDirectory(System.IO.Path.Combine(appRoot, "OutputFiles"))
        End If

        Return System.IO.Path.Combine(appRoot, "OutputFiles", outputfileName)
    End Function
End Module
