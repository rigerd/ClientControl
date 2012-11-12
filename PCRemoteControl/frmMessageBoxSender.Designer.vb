<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBoxSender
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btSend = New System.Windows.Forms.Button()
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btSend
        '
        Me.btSend.Location = New System.Drawing.Point(3, 232)
        Me.btSend.Name = "btSend"
        Me.btSend.Size = New System.Drawing.Size(317, 23)
        Me.btSend.TabIndex = 0
        Me.btSend.Text = "send"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(3, 12)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(317, 20)
        Me.txtHeader.TabIndex = 1
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(3, 38)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(317, 188)
        Me.txtMessage.TabIndex = 2
        '
        'frmMessageBoxSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 264)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtHeader)
        Me.Controls.Add(Me.btSend)
        Me.Name = "frmMessageBoxSender"
        Me.Text = "message box sender"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSend As System.Windows.Forms.Button
    Friend WithEvents txtHeader As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
End Class
