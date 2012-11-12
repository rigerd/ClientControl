Imports System.IO
Imports System.Threading
Imports System.Net.Sockets

Public Class CServer

#Region "public variables"
    Dim MyTcpListener As TcpListener
    Dim Port As Integer
    Dim shouldConnected As Boolean
    Dim vClientList As New List(Of CVclient)
#End Region

#Region "public events"
    Public Event NewVClientConnected(ByVal v As CVclient)
    Public Event VClientDisconnected(ByVal v As CVclient)
#End Region


#Region "public methods"
    ''' <summary>
    ''' method start server
    ''' </summary>
    ''' <param name="Port"></param>
    ''' <remarks></remarks>
    Public Sub Start(ByVal Port As Integer)
        Me.Port = Port
        Dim t As New Thread(AddressOf AcceptConnection)
        Me.shouldConnected = True
        t.IsBackground = True
        t.Start()
    End Sub
#End Region


#Region "private methods"
    ''' <summary>
    ''' accept connection, read first line
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AcceptConnection()
        Me.MyTcpListener = New TcpListener(Me.Port)
        Me.MyTcpListener.Start()

        While Me.shouldConnected
            Dim c As TcpClient = Me.MyTcpListener.AcceptTcpClient()
            'which Connection?
            Dim str As New StreamReader(c.GetStream)
            Dim FirstLine As String = str.ReadLine
            If FirstLine = "vClient" Then
                Dim v As New CVclient
                vClientList.Add(v)
                v.Start(c)
                AddHandler v.Diconnected, AddressOf VClientDisonnected
                RaiseEvent NewVClientConnected(v)

            ElseIf FirstLine = "Test" Then
                '
            ElseIf FirstLine = "Remote Desktop" Then
                '
            Else
                'Connection unknown 
            End If


        End While
    End Sub

    ''' <summary>
    ''' if VClient is disconnected
    ''' </summary>
    ''' <param name="v"></param>
    ''' <remarks></remarks>
    Private Sub VClientDisonnected(ByVal v As CVclient)
        RaiseEvent VClientDisconnected(v)
    End Sub
#End Region

    
End Class
