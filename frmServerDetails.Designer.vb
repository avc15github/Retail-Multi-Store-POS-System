<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerDetails
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
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.chkDemo = New System.Windows.Forms.CheckBox
        Me.pnlServer = New System.Windows.Forms.Panel
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.btnDBFile = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDatabase = New System.Windows.Forms.TextBox
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.grpMain.SuspendLayout()
        Me.pnlServer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.chkDemo)
        Me.grpMain.Controls.Add(Me.pnlServer)
        Me.grpMain.Controls.Add(Me.btnCancel)
        Me.grpMain.Controls.Add(Me.btnOK)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.txtDatabase)
        Me.grpMain.Controls.Add(Me.txtServer)
        Me.grpMain.Location = New System.Drawing.Point(8, 4)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(466, 169)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'chkDemo
        '
        Me.chkDemo.AutoSize = True
        Me.chkDemo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDemo.Location = New System.Drawing.Point(127, 12)
        Me.chkDemo.Name = "chkDemo"
        Me.chkDemo.Size = New System.Drawing.Size(83, 18)
        Me.chkDemo.TabIndex = 0
        Me.chkDemo.Text = "Demo Data"
        Me.chkDemo.UseVisualStyleBackColor = True
        Me.chkDemo.Visible = False
        '
        'pnlServer
        '
        Me.pnlServer.Controls.Add(Me.txtFile)
        Me.pnlServer.Controls.Add(Me.btnDBFile)
        Me.pnlServer.Controls.Add(Me.Label3)
        Me.pnlServer.Location = New System.Drawing.Point(1, 89)
        Me.pnlServer.Name = "pnlServer"
        Me.pnlServer.Size = New System.Drawing.Size(461, 28)
        Me.pnlServer.TabIndex = 5
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(126, 3)
        Me.txtFile.MaxLength = 100
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(297, 22)
        Me.txtFile.TabIndex = 1
        Me.txtFile.TabStop = False
        Me.txtFile.Tag = "Restore From"
        '
        'btnDBFile
        '
        Me.btnDBFile.Location = New System.Drawing.Point(426, 3)
        Me.btnDBFile.Name = "btnDBFile"
        Me.btnDBFile.Size = New System.Drawing.Size(33, 22)
        Me.btnDBFile.TabIndex = 2
        Me.btnDBFile.Text = "..."
        Me.btnDBFile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(12, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Database Location"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(252, 128)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 28)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(139, 128)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(68, 28)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Database Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Database Server"
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDatabase.Location = New System.Drawing.Point(127, 63)
        Me.txtDatabase.MaxLength = 100
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.ReadOnly = True
        Me.txtDatabase.Size = New System.Drawing.Size(296, 22)
        Me.txtDatabase.TabIndex = 4
        Me.txtDatabase.Tag = "Database"
        '
        'txtServer
        '
        Me.txtServer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtServer.Location = New System.Drawing.Point(127, 35)
        Me.txtServer.MaxLength = 100
        Me.txtServer.Name = "txtServer"
        Me.txtServer.ReadOnly = True
        Me.txtServer.Size = New System.Drawing.Size(296, 22)
        Me.txtServer.TabIndex = 2
        Me.txtServer.Tag = "Server"
        '
        'frmServerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 179)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Manager"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlServer.ResumeLayout(False)
        Me.pnlServer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnDBFile As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents pnlServer As System.Windows.Forms.Panel
    Friend WithEvents chkDemo As System.Windows.Forms.CheckBox
End Class
