Imports ceTe.DynamicPDF.Conversion

Public Class PptFileConversion
    Public Shared Sub Run()
        SimplePowerpoint("ppt_conversion_output.pdf")
        AdvancedPowerpoint("ppt_conversion_adv_output.pdf")
    End Sub

    Public Shared Sub SimplePowerpoint(outputPdf As String)
        Dim options As New PowerPointConversionOptions(False)

        Dim pptConverter As New PowerPointConverter(Program.GetResourcePath("DocumentA.pptx"), options)

        pptConverter.Convert(Program.GetOutputDocPath(outputPdf))

        Console.WriteLine("OfficePptFileConversion Example Executed.")
    End Sub

    Public Shared Sub AdvancedPowerpoint(outputPdf As String)
        Dim powerPointConversionOptions As New PowerPointConversionOptions(PageSize.A4, PageOrientation.Portrait, 36)

        Dim handout As HandoutOutputType = PowerPointOutputType.Handout
        handout.HandoutPrintOrder = HandoutPrintOrder.Horizontal
        handout.SlidesPerPage = SlidesPerPage.Six
        handout.FrameSlides = True

        powerPointConversionOptions.OutputType = handout
        powerPointConversionOptions.OutputType.PrintHiddenSlide = True

        Dim powerPointConverter1 As New PowerPointConverter(Program.GetResourcePath("DocumentA.pptx"), powerPointConversionOptions)
        powerPointConverter1.Convert(outputPdf)
    End Sub
End Class

