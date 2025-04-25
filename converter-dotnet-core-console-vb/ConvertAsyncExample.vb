Imports ceTe.DynamicPDF.Conversion
Imports System
Imports System.IO

Public Class ConvertAsyncExample
    Public Shared Sub Run()
        Dim tsk1 As Task = RunTextSaveFile("async-text-file-output.pdf")
        Dim tsk2 As Task = RunTextInputFileName("async-text-input-file-name-output.pdf")
        Dim tsk3 As Task = RunTextBytesConvOpt("async-text-bytes-options-output.pdf")
        Dim tsk4 As Task = RunTextBytesConvAppnd("async-text-bytes-append-output.pdf")

        Task.WaitAll({tsk2, tsk1, tsk3, tsk4})
        Console.WriteLine("Conversion Completed successfully")
    End Sub

    Public Shared Async Function RunTextInputFileName(outputPdf As String) As Task
        Dim input As Byte() = File.ReadAllBytes(Program.GetResourcePath("DocumentA.txt"))
        Dim result As Byte() = Await Converter.ConvertAsync(input, Program.GetResourcePath("DocumentA.txt"))

        If result IsNot Nothing Then
            File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result)
        End If
    End Function

    Public Shared Async Function RunTextBytesConvOpt(outputPdf As String) As Task
        Dim options As New ConversionOptions(False)
        Dim result As Byte() = Await Converter.ConvertAsync(Program.GetResourcePath("DocumentA.txt"), options)

        If result IsNot Nothing Then
            File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result)
        End If
    End Function

    Public Shared Async Function RunTextBytesConvAppnd(outputPdf As String) As Task
        Dim options As New ConversionOptions(False)
        Dim appendToPdf As Byte() = File.ReadAllBytes(Program.GetResourcePath("DocumentA.pdf"))

        Dim result As Byte() = Await Converter.ConvertAsync(Program.GetResourcePath("DocumentA.txt"), options, appendToPdf)

        If result IsNot Nothing Then
            File.WriteAllBytes(Program.GetOutputDocPath(outputPdf), result)
        End If
    End Function

    Public Shared Async Function RunTextSaveFile(outputPdf As String) As Task
        Dim result As Boolean = Await Converter.ConvertAsync(Program.GetResourcePath("DocumentA.rtf"), Program.GetOutputDocPath(outputPdf))

        If result Then
            Console.WriteLine("Conversion Completed successfully")
        End If
    End Function
End Class
