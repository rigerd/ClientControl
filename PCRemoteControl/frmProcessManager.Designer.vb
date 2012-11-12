<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessManager
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
        Me.lvProcessManager = New System.Windows.Forms.ListView()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.btCancelProcess = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvProcessManager
        '
        Me.lvProcessManager.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvProcessManager.FullRowSelect = True
        Me.lvProcessManager.GridLines = True
        Me.lvProcessManager.HoverSelection = True
        Me.lvProcessManager.Location = New System.Drawing.Point(2, 12)
        Me.lvProcessManager.Name = "lvProcessManager"
        Me.lvProcessManager.Size = New System.Drawing.Size(408, 298)
        Me.lvProcessManager.TabIndex = 0
        Me.lvProcessManager.UseCompatibleStateImageBehavior = False
        Me.lvProcessManager.View = System.Windows.Forms.View.Details
        '
        'btRefresh
        '
        Me.btRefresh.Location = New System.Drawing.Point(2, 334)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(408, 23)
        Me.btRefresh.TabIndex = 1
        Me.btRefresh.Text = "refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'btCancelProcess
        '
        Me.btCancelProcess.Location = New System.Drawing.Point(2, 364)
        Me.btCancelProcess.Name = "btCancelProcess"
        Me.btCancelProcess.Size = New System.Drawing.Size(408, 23)
        Me.btCancelProcess.TabIndex = 2
        Me.btCancelProcess.Text = "cancel process"
        Me.btCancelProcess.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "name of process"
        Me.ColumnHeader1.Width = 215
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "pid"
        Me.ColumnHeader2.Width = 188
        '
        'frmProcessManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 403)
        Me.Controls.Add(Me.btCancelProcess)
        Me.Controls.Add(Me.btRefresh)
        Me.Controls.Add(Me.lvProcessManager)
        Me.Name = "frmProcessManager"
        Me.Text = "frmProcessManager"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvProcessManager As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btRefresh As System.Windows.Forms.Button
    Friend WithEvents btCancelProcess As System.Windows.Forms.Button
End Class
