<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration1
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
        Me.pnlCompany = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.cmbUsers = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtStation = New System.Windows.Forms.TextBox
        Me.txtPin = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRegistration = New VRSRetail.RegistrationText
        Me.btnContinue = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblMachineKey = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        Me.pnlCompany.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.pnlCompany)
        Me.grpMain.Controls.Add(Me.txtRegistration)
        Me.grpMain.Controls.Add(Me.btnContinue)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.btnCancel)
        Me.grpMain.Controls.Add(Me.lblMachineKey)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Location = New System.Drawing.Point(8, 4)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(458, 356)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'pnlCompany
        '
        Me.pnlCompany.Controls.Add(Me.Label10)
        Me.pnlCompany.Controls.Add(Me.txtCompany)
        Me.pnlCompany.Controls.Add(Me.cmbUsers)
        Me.pnlCompany.Controls.Add(Me.Label1)
        Me.pnlCompany.Controls.Add(Me.Label9)
        Me.pnlCompany.Controls.Add(Me.txtContact)
        Me.pnlCompany.Controls.Add(Me.txtEmail)
        Me.pnlCompany.Controls.Add(Me.Label3)
        Me.pnlCompany.Controls.Add(Me.Label8)
        Me.pnlCompany.Controls.Add(Me.txtAddress)
        Me.pnlCompany.Controls.Add(Me.txtPhone)
        Me.pnlCompany.Controls.Add(Me.Label5)
        Me.pnlCompany.Controls.Add(Me.Label7)
        Me.pnlCompany.Controls.Add(Me.txtStation)
        Me.pnlCompany.Controls.Add(Me.txtPin)
        Me.pnlCompany.Controls.Add(Me.Label6)
        Me.pnlCompany.Location = New System.Drawing.Point(4, 72)
        Me.pnlCompany.Name = "pnlCompany"
        Me.pnlCompany.Size = New System.Drawing.Size(448, 240)
        Me.pnlCompany.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(7, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "No of Users"
        Me.Label10.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(114, 3)
        Me.txtCompany.MaxLength = 100
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(329, 22)
        Me.txtCompany.TabIndex = 1
        Me.txtCompany.Tag = "Company Name"
        '
        'cmbUsers
        '
        Me.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.Location = New System.Drawing.Point(114, 212)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(90, 22)
        Me.cmbUsers.TabIndex = 15
        Me.cmbUsers.Tag = "Users"
        Me.cmbUsers.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* Company"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(7, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Email"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(114, 31)
        Me.txtContact.MaxLength = 100
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(329, 22)
        Me.txtContact.TabIndex = 3
        Me.txtContact.Tag = "Contact Person"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(114, 183)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(329, 22)
        Me.txtEmail.TabIndex = 13
        Me.txtEmail.Tag = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(7, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "* Contact Person"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(7, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Phone"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(114, 59)
        Me.txtAddress.MaxLength = 500
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(329, 62)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.Tag = "Address"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(114, 155)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(329, 22)
        Me.txtPhone.TabIndex = 11
        Me.txtPhone.Tag = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(7, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(329, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 21)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pin"
        '
        'txtStation
        '
        Me.txtStation.Location = New System.Drawing.Point(114, 127)
        Me.txtStation.MaxLength = 20
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(193, 22)
        Me.txtStation.TabIndex = 7
        Me.txtStation.Tag = "Station"
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(355, 127)
        Me.txtPin.MaxLength = 10
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(88, 22)
        Me.txtPin.TabIndex = 9
        Me.txtPin.Tag = "Pincode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(7, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Station"
        '
        'txtRegistration
        '
        Me.txtRegistration.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistration.Location = New System.Drawing.Point(116, 44)
        Me.txtRegistration.Name = "txtRegistration"
        Me.txtRegistration.Size = New System.Drawing.Size(224, 25)
        Me.txtRegistration.TabIndex = 1
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(117, 319)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(90, 29)
        Me.btnContinue.TabIndex = 3
        Me.btnContinue.Text = "&Register Me"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Registration Key"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(251, 319)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 29)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "C&ancel"
        '
        'lblMachineKey
        '
        Me.lblMachineKey.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachineKey.ForeColor = System.Drawing.Color.Navy
        Me.lblMachineKey.Location = New System.Drawing.Point(117, 16)
        Me.lblMachineKey.Name = "lblMachineKey"
        Me.lblMachineKey.Size = New System.Drawing.Size(332, 20)
        Me.lblMachineKey.TabIndex = 1
        Me.lblMachineKey.Text = "Company"
        Me.lblMachineKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMachineKey.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(12, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Machine Key"
        Me.Label4.Visible = False
        '
        'frmRegistration1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 364)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistration1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Information"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.pnlCompany.ResumeLayout(False)
        Me.pnlCompany.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblMachineKey As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRegistration As VRSRetail.RegistrationText
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStation As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbUsers As System.Windows.Forms.ComboBox
    Friend WithEvents pnlCompany As System.Windows.Forms.Panel
End Class
