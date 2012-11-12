Imports System.IO
Imports System.Threading
Imports System.Net.Sockets

Public Class CVclient
    Dim MyTcpClient As TcpClient
    Dim MyStreamReader As StreamReader
    Dim MyStreamWriter As StreamWriter
    Private isConnected As Boolean = False

    Public Event newTextArrived(ByVal sText As String)
    Public Event Diconnected(ByVal c As CVclient)

    Sub Start(ByVal c As TcpClient)
        Me.MyTcpClient = c
        Me.MyStreamReader = New StreamReader(c.GetStream)
        Me.MyStreamWriter = New StreamWriter(c.GetStream)
        Me.isConnected = True
        'get basic informationen
        Dim t As New Thread(AddressOf ReceiveText)
        t.IsBackground = True
        t.Start()
    End Sub

    Sub ReceiveText()
        Try
            While Me.isConnected
                Dim sText As String = Me.MyStreamReader.ReadLine
                RaiseEvent newTextArrived(sText)
            End While
        Catch ex As Exception
            Disconnect()
        End Try
    End Sub

    Public Sub SendText(ByVal sText As String)
        Try
            Me.MyStreamWriter.WriteLine(sText)
            Me.MyStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Disconnect()
        Me.isConnected = False
        Me.MyStreamReader.Close()
        Me.MyStreamWriter.Close()
        Me.MyTcpClient.Close()
        RaiseEvent Diconnected(Me)
    End Sub

End Class
