Module Module1
    Dim WithEvents MyClient As New CClient
'''<Summary>
'''</Summary>
    Sub Main()
        MyClient.ClientStart("127.0.0.1", 89)
        MyClient.SendText("Message from Client")

        While True
            System.Threading.Thread.Sleep(1000)
        End While

    End Sub

    Private Sub MyClient_Connected() Handles MyClient.Connected
        Console.WriteLine("Connection established")
    End Sub

    Private Sub MyClient_newTextarrived(ByVal sText As String) Handles MyClient.newTextarrived
        Console.WriteLine("Text sended", sText)
    End Sub

    Private Sub MyClient_Reconnected() Handles MyClient.Reconnected
        Console.WriteLine("faild to connect, try to reconnect")
    End Sub
End Module
