Imports System.IO
Imports System.Threading
Imports System.Net.Sockets


Public Class CClient
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>

#Region "public variables"
    Dim MyTcpClient As TcpClient
    Dim MyStreamReader As StreamReader
    Dim MyStreamWriter As StreamWriter
#End Region

#Region "private variables"
    Private isConnected As Boolean = False
    Private IpAdresse As String
    Private Port As Integer
#End Region

#Region "public events"
    Public Event Connected()
    Public Event Reconnected()
    Public Event newTextarrived(ByVal sText As String)
#End Region



#Region "public methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="IpAdresse">IP-adress as string</param>
    ''' <param name="Port">Port as integer</param>
    ''' <remarks></remarks>
    Public Sub ClientStart(ByVal IpAdresse As String, ByVal Port As Integer)
        Me.IpAdresse = IpAdresse
        Me.Port = Port
        Connect()
    End Sub

    ''' <summary>
    ''' Send Text to ControlSoftware
    ''' </summary>
    ''' <param name="sText">text to send</param>
    ''' <remarks></remarks>
    ''' <exception cref="Exception"></exception>
    Public Sub SendText(ByVal sText As String)
        Try
            Me.MyStreamWriter.WriteLine(sText)
            Me.MyStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "private Methods"
    ''' <summary>
    ''' Receive text from the ControlSoftware 
    ''' </summary>
    ''' <remarks></remarks>
    ''' <exception cref=" Exception"></exception>
    Private Sub ReceiveText()
        Try
            While Me.isConnected
                Dim sText As String
                sText = Me.MyStreamReader.ReadLine
                RaiseEvent newTextarrived(sText)
            End While
        Catch ex As Exception
            Me.isConnected = False
            Reconnect()
        End Try
    End Sub

    ''' <summary>
    ''' Wait for 5 seconds and try again
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Reconnect()
        RaiseEvent Reconnected()
        Me.MyTcpClient.Close()
        Thread.Sleep(5000)
        'call Error Event 
    End Sub

    ''' <summary>
    ''' Connect the client as tcpClient, 
    ''' </summary>
    ''' <remarks></remarks>
    ''' <exception cref="Exception">If there is an exception, call reconnect sub</exception>
    Private Sub Connect()
        Try
            Me.MyTcpClient = New TcpClient
            Me.MyTcpClient.Connect(Me.IpAdresse, Me.Port)
            If Me.MyTcpClient.Connected = True Then
                Me.isConnected = True
                Me.MyStreamReader = New StreamReader(Me.MyTcpClient.GetStream)
                Me.MyStreamWriter = New StreamWriter(Me.MyTcpClient.GetStream)
                Dim t As New Thread(AddressOf ReceiveText)
                t.IsBackground = True
                t.Start()
            Else
                Me.isConnected = False
                Reconnect()
            End If
        Catch ex As Exception
            Me.isConnected = False
            Reconnect()
        End Try

    End Sub

#End Region

End Class
