<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMC
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
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.grpPayment = New System.Windows.Forms.GroupBox
        Me.txtPLockMsg = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPLockDays = New NumericTextBox.NumericTextBox
        Me.txtPMsgDays = New NumericTextBox.NumericTextBox
        Me.txtPaymentMsg = New System.Windows.Forms.TextBox
        Me.chkPLock = New System.Windows.Forms.CheckBox
        Me.chkPMsg = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpPDate = New DateTimePick.DateTimePick
        Me.Label14 = New System.Windows.Forms.Label
        Me.grpAMC = New System.Windows.Forms.GroupBox
        Me.txtALockMsg = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRenewDays = New NumericTextBox.NumericTextBox
        Me.txtADays = New NumericTextBox.NumericTextBox
        Me.txtAMCMsg = New System.Windows.Forms.TextBox
        Me.chkALock = New System.Windows.Forms.CheckBox
        Me.chkAMsg = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpRenewDate = New DateTimePick.DateTimePick
        Me.dtpRegDate = New DateTimePick.DateTimePick
        Me.lblFrom = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpAMC.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpMain.Appearance.Options.UseBackColor = True
        Me.grpMain.Controls.Add(Me.grpPayment)
        Me.grpMain.Controls.Add(Me.grpAMC)
        Me.grpMain.Controls.Add(Me.btnCancel)
        Me.grpMain.Controls.Add(Me.btnSave)
        Me.grpMain.Location = New System.Drawing.Point(8, 4)
        Me.grpMain.LookAndFeel.SkinName = "Caramel"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(595, 523)
        Me.grpMain.TabIndex = 0
        '
        'grpPayment
        '
        Me.grpPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpPayment.Controls.Add(Me.txtPLockMsg)
        Me.grpPayment.Controls.Add(Me.Label2)
        Me.grpPayment.Controls.Add(Me.txtPLockDays)
        Me.grpPayment.Controls.Add(Me.txtPMsgDays)
        Me.grpPayment.Controls.Add(Me.txtPaymentMsg)
        Me.grpPayment.Controls.Add(Me.chkPLock)
        Me.grpPayment.Controls.Add(Me.chkPMsg)
        Me.grpPayment.Controls.Add(Me.Label3)
        Me.grpPayment.Controls.Add(Me.Label11)
        Me.grpPayment.Controls.Add(Me.Label12)
        Me.grpPayment.Controls.Add(Me.dtpPDate)
        Me.grpPayment.Controls.Add(Me.Label14)
        Me.grpPayment.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPayment.ForeColor = System.Drawing.Color.Black
        Me.grpPayment.Location = New System.Drawing.Point(7, 242)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(583, 244)
        Me.grpPayment.TabIndex = 14
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Information"
        '
        'txtPLockMsg
        '
        Me.txtPLockMsg.Enabled = False
        Me.txtPLockMsg.Location = New System.Drawing.Point(171, 184)
        Me.txtPLockMsg.Multiline = True
        Me.txtPLockMsg.Name = "txtPLockMsg"
        Me.txtPLockMsg.Size = New System.Drawing.Size(387, 50)
        Me.txtPLockMsg.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Payment Lock Message"
        '
        'txtPLockDays
        '
        Me.txtPLockDays.AllowAlphabets = False
        Me.txtPLockDays.AllowMoveToNextControl = False
        Me.txtPLockDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPLockDays.EditValue = 0
        Me.txtPLockDays.Enabled = False
        Me.txtPLockDays.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPLockDays.Location = New System.Drawing.Point(288, 150)
        Me.txtPLockDays.Name = "txtPLockDays"
        Me.txtPLockDays.Size = New System.Drawing.Size(40, 22)
        Me.txtPLockDays.TabIndex = 24
        Me.txtPLockDays.Tag = "Quantity"
        Me.txtPLockDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPMsgDays
        '
        Me.txtPMsgDays.AllowAlphabets = False
        Me.txtPMsgDays.AllowMoveToNextControl = False
        Me.txtPMsgDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPMsgDays.EditValue = 0
        Me.txtPMsgDays.Enabled = False
        Me.txtPMsgDays.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPMsgDays.Location = New System.Drawing.Point(361, 55)
        Me.txtPMsgDays.Name = "txtPMsgDays"
        Me.txtPMsgDays.Size = New System.Drawing.Size(40, 22)
        Me.txtPMsgDays.TabIndex = 19
        Me.txtPMsgDays.Tag = "Quantity"
        Me.txtPMsgDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaymentMsg
        '
        Me.txtPaymentMsg.Enabled = False
        Me.txtPaymentMsg.Location = New System.Drawing.Point(171, 91)
        Me.txtPaymentMsg.Multiline = True
        Me.txtPaymentMsg.Name = "txtPaymentMsg"
        Me.txtPaymentMsg.Size = New System.Drawing.Size(387, 50)
        Me.txtPaymentMsg.TabIndex = 21
        '
        'chkPLock
        '
        Me.chkPLock.AutoSize = True
        Me.chkPLock.Location = New System.Drawing.Point(24, 152)
        Me.chkPLock.Name = "chkPLock"
        Me.chkPLock.Size = New System.Drawing.Size(99, 18)
        Me.chkPLock.TabIndex = 22
        Me.chkPLock.Text = "Lock Software"
        Me.chkPLock.UseVisualStyleBackColor = True
        '
        'chkPMsg
        '
        Me.chkPMsg.AutoSize = True
        Me.chkPMsg.Location = New System.Drawing.Point(24, 57)
        Me.chkPMsg.Name = "chkPMsg"
        Me.chkPMsg.Size = New System.Drawing.Size(224, 18)
        Me.chkPMsg.TabIndex = 17
        Me.chkPMsg.Text = "Display Payment Reminder Message"
        Me.chkPMsg.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "After Payment Days:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 14)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Payment Message"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(282, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 14)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Before Days:"
        '
        'dtpPDate
        '
        Me.dtpPDate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtpPDate.Location = New System.Drawing.Point(171, 23)
        Me.dtpPDate.Name = "dtpPDate"
        Me.dtpPDate.Size = New System.Drawing.Size(89, 22)
        Me.dtpPDate.TabIndex = 15
        Me.dtpPDate.Value = New Date(2016, 10, 12, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 14)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "Payment Due Date:"
        '
        'grpAMC
        '
        Me.grpAMC.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpAMC.Controls.Add(Me.txtALockMsg)
        Me.grpAMC.Controls.Add(Me.Label4)
        Me.grpAMC.Controls.Add(Me.txtRenewDays)
        Me.grpAMC.Controls.Add(Me.txtADays)
        Me.grpAMC.Controls.Add(Me.txtAMCMsg)
        Me.grpAMC.Controls.Add(Me.chkALock)
        Me.grpAMC.Controls.Add(Me.chkAMsg)
        Me.grpAMC.Controls.Add(Me.Label8)
        Me.grpAMC.Controls.Add(Me.Label6)
        Me.grpAMC.Controls.Add(Me.Label5)
        Me.grpAMC.Controls.Add(Me.dtpRenewDate)
        Me.grpAMC.Controls.Add(Me.dtpRegDate)
        Me.grpAMC.Controls.Add(Me.lblFrom)
        Me.grpAMC.Controls.Add(Me.Label1)
        Me.grpAMC.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAMC.ForeColor = System.Drawing.Color.Black
        Me.grpAMC.Location = New System.Drawing.Point(4, 5)
        Me.grpAMC.Name = "grpAMC"
        Me.grpAMC.Size = New System.Drawing.Size(583, 233)
        Me.grpAMC.TabIndex = 0
        Me.grpAMC.TabStop = False
        Me.grpAMC.Text = "AMC Information"
        '
        'txtALockMsg
        '
        Me.txtALockMsg.Enabled = False
        Me.txtALockMsg.Location = New System.Drawing.Point(171, 177)
        Me.txtALockMsg.Multiline = True
        Me.txtALockMsg.Name = "txtALockMsg"
        Me.txtALockMsg.Size = New System.Drawing.Size(387, 50)
        Me.txtALockMsg.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 14)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "AMC Lock Message"
        '
        'txtRenewDays
        '
        Me.txtRenewDays.AllowAlphabets = False
        Me.txtRenewDays.AllowMoveToNextControl = False
        Me.txtRenewDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRenewDays.EditValue = 0
        Me.txtRenewDays.Enabled = False
        Me.txtRenewDays.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRenewDays.Location = New System.Drawing.Point(290, 147)
        Me.txtRenewDays.Name = "txtRenewDays"
        Me.txtRenewDays.Size = New System.Drawing.Size(40, 22)
        Me.txtRenewDays.TabIndex = 12
        Me.txtRenewDays.Tag = "Quantity"
        Me.txtRenewDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtADays
        '
        Me.txtADays.AllowAlphabets = False
        Me.txtADays.AllowMoveToNextControl = False
        Me.txtADays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtADays.EditValue = 0
        Me.txtADays.Enabled = False
        Me.txtADays.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtADays.Location = New System.Drawing.Point(283, 56)
        Me.txtADays.Name = "txtADays"
        Me.txtADays.Size = New System.Drawing.Size(40, 22)
        Me.txtADays.TabIndex = 7
        Me.txtADays.Tag = "Quantity"
        Me.txtADays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAMCMsg
        '
        Me.txtAMCMsg.Enabled = False
        Me.txtAMCMsg.Location = New System.Drawing.Point(171, 91)
        Me.txtAMCMsg.Multiline = True
        Me.txtAMCMsg.Name = "txtAMCMsg"
        Me.txtAMCMsg.Size = New System.Drawing.Size(387, 50)
        Me.txtAMCMsg.TabIndex = 9
        '
        'chkALock
        '
        Me.chkALock.AutoSize = True
        Me.chkALock.Location = New System.Drawing.Point(24, 149)
        Me.chkALock.Name = "chkALock"
        Me.chkALock.Size = New System.Drawing.Size(99, 18)
        Me.chkALock.TabIndex = 10
        Me.chkALock.Text = "Lock Software"
        Me.chkALock.UseVisualStyleBackColor = True
        '
        'chkAMsg
        '
        Me.chkAMsg.AutoSize = True
        Me.chkAMsg.Location = New System.Drawing.Point(24, 58)
        Me.chkAMsg.Name = "chkAMsg"
        Me.chkAMsg.Size = New System.Drawing.Size(145, 18)
        Me.chkAMsg.TabIndex = 5
        Me.chkAMsg.Text = "Display AMC Message"
        Me.chkAMsg.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(172, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "After Renewal Days:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 14)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "AMC Message"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Before Days:"
        '
        'dtpRenewDate
        '
        Me.dtpRenewDate.Location = New System.Drawing.Point(457, 25)
        Me.dtpRenewDate.Name = "dtpRenewDate"
        Me.dtpRenewDate.Size = New System.Drawing.Size(89, 22)
        Me.dtpRenewDate.TabIndex = 3
        Me.dtpRenewDate.Value = New Date(2016, 10, 12, 0, 0, 0, 0)
        '
        'dtpRegDate
        '
        Me.dtpRegDate.Location = New System.Drawing.Point(171, 25)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.Size = New System.Drawing.Size(89, 22)
        Me.dtpRegDate.TabIndex = 1
        Me.dtpRegDate.Value = New Date(2016, 10, 12, 0, 0, 0, 0)
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(24, 29)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(105, 14)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "Registration Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Renewal Date"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(307, 491)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 29)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 491)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 29)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 533)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAMC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMC & Payment Information"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.grpAMC.ResumeLayout(False)
        Me.grpAMC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpRenewDate As DateTimePick.DateTimePick
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpRegDate As DateTimePick.DateTimePick
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents grpAMC As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkALock As System.Windows.Forms.CheckBox
    Friend WithEvents chkAMsg As System.Windows.Forms.CheckBox
    Friend WithEvents chkPLock As System.Windows.Forms.CheckBox
    Friend WithEvents chkPMsg As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpPDate As DateTimePick.DateTimePick
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentMsg As System.Windows.Forms.TextBox
    Friend WithEvents txtAMCMsg As System.Windows.Forms.TextBox
    Friend WithEvents txtADays As NumericTextBox.NumericTextBox
    Friend WithEvents txtPLockDays As NumericTextBox.NumericTextBox
    Friend WithEvents txtPMsgDays As NumericTextBox.NumericTextBox
    Friend WithEvents txtRenewDays As NumericTextBox.NumericTextBox
    Friend WithEvents txtPLockMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtALockMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
