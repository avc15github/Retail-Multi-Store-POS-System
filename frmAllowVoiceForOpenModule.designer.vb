<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllowVoiceForOpenModule
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
        Me.lblParty = New System.Windows.Forms.Label
        Me.rdClose = New System.Windows.Forms.RadioButton
        Me.rdOpen = New System.Windows.Forms.RadioButton
        Me.chkSize = New System.Windows.Forms.CheckBox
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.lblParty)
        Me.grpMain.Controls.Add(Me.rdClose)
        Me.grpMain.Controls.Add(Me.rdOpen)
        Me.grpMain.Controls.Add(Me.chkSize)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.btnUpdate)
        Me.grpMain.Location = New System.Drawing.Point(10, 3)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(256, 109)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "`"
        '
        'lblParty
        '
        Me.lblParty.AutoSize = True
        Me.lblParty.Location = New System.Drawing.Point(31, 22)
        Me.lblParty.Name = "lblParty"
        Me.lblParty.Size = New System.Drawing.Size(41, 14)
        Me.lblParty.TabIndex = 14
        Me.lblParty.Text = "Status"
        '
        'rdClose
        '
        Me.rdClose.AutoSize = True
        Me.rdClose.Location = New System.Drawing.Point(157, 20)
        Me.rdClose.Name = "rdClose"
        Me.rdClose.Size = New System.Drawing.Size(55, 18)
        Me.rdClose.TabIndex = 4
        Me.rdClose.Text = "Close"
        Me.rdClose.UseVisualStyleBackColor = True
        '
        'rdOpen
        '
        Me.rdOpen.AutoSize = True
        Me.rdOpen.Checked = True
        Me.rdOpen.Location = New System.Drawing.Point(92, 20)
        Me.rdOpen.Name = "rdOpen"
        Me.rdOpen.Size = New System.Drawing.Size(54, 18)
        Me.rdOpen.TabIndex = 3
        Me.rdOpen.TabStop = True
        Me.rdOpen.Text = "Open"
        Me.rdOpen.UseVisualStyleBackColor = True
        '
        'chkSize
        '
        Me.chkSize.AutoSize = True
        Me.chkSize.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSize.Location = New System.Drawing.Point(27, 386)
        Me.chkSize.Name = "chkSize"
        Me.chkSize.Size = New System.Drawing.Size(76, 19)
        Me.chkSize.TabIndex = 13
        Me.chkSize.Text = "View Size"
        Me.chkSize.UseVisualStyleBackColor = True
        Me.chkSize.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(132, 62)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 26)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        '
        'btnUpdate
        '
        Me.btnUpdate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Appearance.Options.UseFont = True
        Me.btnUpdate.Location = New System.Drawing.Point(30, 62)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 26)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        '
        'frmAllowVoiceForOpenModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 123)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAllowVoiceForOpenModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allow Voice For Open Module"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents chkSize As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rdClose As System.Windows.Forms.RadioButton
    Friend WithEvents rdOpen As System.Windows.Forms.RadioButton
    Friend WithEvents lblParty As System.Windows.Forms.Label
End Class
