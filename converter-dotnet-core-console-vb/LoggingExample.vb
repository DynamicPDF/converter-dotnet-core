Imports ceTe.DynamicPDF.Conversion
Imports System

Public Class LoggingExample

    Public Shared Sub LogConfiguration()
        ConversionOptions.Logging.Level = LogLevel.Debug
        ConversionOptions.Logging.LogFilePath = "C:\temp\LogFile.txt"
        REM ConversionOptions.Logging.LogAction = AddressOf DelegateMethod
    End Sub

    Public Shared Sub DelegateMethod(identifier As LogIdentifier, logLevel As LogLevel, message As String)
        Console.WriteLine(logLevel.ToString() & "|" & identifier.ToString() & "|" & message)
    End Sub

End Class

