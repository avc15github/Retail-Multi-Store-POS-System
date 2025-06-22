<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivation))
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.rdBasic = New System.Windows.Forms.RadioButton
        Me.rdEnterprise = New System.Windows.Forms.RadioButton
        Me.rdProfessional = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.pnlInstallOption = New System.Windows.Forms.Panel
        Me.rdServer = New System.Windows.Forms.RadioButton
        Me.rdClient = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlModeOfAct = New System.Windows.Forms.Panel
        Me.rd30Days = New System.Windows.Forms.RadioButton
        Me.rdOnline = New System.Windows.Forms.RadioButton
        Me.rdOffline = New System.Windows.Forms.RadioButton
        Me.pnlInstallType = New System.Windows.Forms.Panel
        Me.rdNew = New System.Windows.Forms.RadioButton
        Me.rdReinStall = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnActivate = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpMain.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlInstallOption.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlModeOfAct.SuspendLayout()
        Me.pnlInstallType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.Panel5)
        Me.grpMain.Controls.Add(Me.Label6)
        Me.grpMain.Controls.Add(Me.Panel4)
        Me.grpMain.Controls.Add(Me.pnlInstallOption)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.Panel3)
        Me.grpMain.Controls.Add(Me.Panel2)
        Me.grpMain.Controls.Add(Me.PictureBox1)
        Me.grpMain.Controls.Add(Me.pnlModeOfAct)
        Me.grpMain.Controls.Add(Me.pnlInstallType)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.btnCancel)
        Me.grpMain.Controls.Add(Me.btnActivate)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Location = New System.Drawing.Point(8, 1)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(480, 394)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(226, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 2)
        Me.Panel1.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rdBasic)
        Me.Panel5.Controls.Add(Me.rdEnterprise)
        Me.Panel5.Controls.Add(Me.rdProfessional)
        Me.Panel5.Location = New System.Drawing.Point(143, 259)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(322, 25)
        Me.Panel5.TabIndex = 19
        '
        'rdBasic
        '
        Me.rdBasic.AutoSize = True
        Me.rdBasic.Checked = True
        Me.rdBasic.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBasic.ForeColor = System.Drawing.Color.Red
        Me.rdBasic.Location = New System.Drawing.Point(10, 3)
        Me.rdBasic.Name = "rdBasic"
        Me.rdBasic.Size = New System.Drawing.Size(55, 19)
        Me.rdBasic.TabIndex = 8
        Me.rdBasic.TabStop = True
        Me.rdBasic.Text = "Basic"
        Me.rdBasic.UseVisualStyleBackColor = True
        '
        'rdEnterprise
        '
        Me.rdEnterprise.AutoSize = True
        Me.rdEnterprise.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEnterprise.ForeColor = System.Drawing.Color.Red
        Me.rdEnterprise.Location = New System.Drawing.Point(224, 3)
        Me.rdEnterprise.Name = "rdEnterprise"
        Me.rdEnterprise.Size = New System.Drawing.Size(81, 19)
        Me.rdEnterprise.TabIndex = 9
        Me.rdEnterprise.Text = "Enterprise"
        Me.rdEnterprise.UseVisualStyleBackColor = True
        '
        'rdProfessional
        '
        Me.rdProfessional.AutoSize = True
        Me.rdProfessional.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdProfessional.ForeColor = System.Drawing.Color.Red
        Me.rdProfessional.Location = New System.Drawing.Point(97, 3)
        Me.rdProfessional.Name = "rdProfessional"
        Me.rdProfessional.Size = New System.Drawing.Size(95, 19)
        Me.rdProfessional.TabIndex = 9
        Me.rdProfessional.Text = "Professional"
        Me.rdProfessional.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(141, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Select Edition"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(251, 189)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(212, 2)
        Me.Panel4.TabIndex = 17
        '
        'pnlInstallOption
        '
        Me.pnlInstallOption.Controls.Add(Me.rdServer)
        Me.pnlInstallOption.Controls.Add(Me.rdClient)
        Me.pnlInstallOption.Location = New System.Drawing.Point(143, 198)
        Me.pnlInstallOption.Name = "pnlInstallOption"
        Me.pnlInstallOption.Size = New System.Drawing.Size(322, 25)
        Me.pnlInstallOption.TabIndex = 16
        '
        'rdServer
        '
        Me.rdServer.AutoSize = True
        Me.rdServer.Checked = True
        Me.rdServer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdServer.ForeColor = System.Drawing.Color.Red
        Me.rdServer.Location = New System.Drawing.Point(10, 3)
        Me.rdServer.Name = "rdServer"
        Me.rdServer.Size = New System.Drawing.Size(100, 19)
        Me.rdServer.TabIndex = 8
        Me.rdServer.TabStop = True
        Me.rdServer.Text = "Server Edition"
        Me.rdServer.UseVisualStyleBackColor = True
        '
        'rdClient
        '
        Me.rdClient.AutoSize = True
        Me.rdClient.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdClient.ForeColor = System.Drawing.Color.Red
        Me.rdClient.Location = New System.Drawing.Point(131, 3)
        Me.rdClient.Name = "rdClient"
        Me.rdClient.Size = New System.Drawing.Size(98, 19)
        Me.rdClient.TabIndex = 9
        Me.rdClient.Text = "Client Edition"
        Me.rdClient.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(141, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Installation Option"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(255, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 2)
        Me.Panel3.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(243, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 2)
        Me.Panel2.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 373)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'pnlModeOfAct
        '
        Me.pnlModeOfAct.Controls.Add(Me.rd30Days)
        Me.pnlModeOfAct.Controls.Add(Me.rdOnline)
        Me.pnlModeOfAct.Controls.Add(Me.rdOffline)
        Me.pnlModeOfAct.Location = New System.Drawing.Point(143, 120)
        Me.pnlModeOfAct.Name = "pnlModeOfAct"
        Me.pnlModeOfAct.Size = New System.Drawing.Size(322, 28)
        Me.pnlModeOfAct.TabIndex = 11
        '
        'rd30Days
        '
        Me.rd30Days.AutoSize = True
        Me.rd30Days.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd30Days.ForeColor = System.Drawing.Color.Red
        Me.rd30Days.Location = New System.Drawing.Point(224, 4)
        Me.rd30Days.Name = "rd30Days"
        Me.rd30Days.Size = New System.Drawing.Size(97, 19)
        Me.rd30Days.TabIndex = 2
        Me.rd30Days.Text = "30 Days &Trial"
        Me.rd30Days.UseVisualStyleBackColor = True
        '
        'rdOnline
        '
        Me.rdOnline.AutoSize = True
        Me.rdOnline.Enabled = False
        Me.rdOnline.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOnline.ForeColor = System.Drawing.Color.Red
        Me.rdOnline.Location = New System.Drawing.Point(10, 4)
        Me.rdOnline.Name = "rdOnline"
        Me.rdOnline.Size = New System.Drawing.Size(62, 19)
        Me.rdOnline.TabIndex = 0
        Me.rdOnline.Text = "&Online"
        Me.rdOnline.UseVisualStyleBackColor = True
        '
        'rdOffline
        '
        Me.rdOffline.AutoSize = True
        Me.rdOffline.Checked = True
        Me.rdOffline.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOffline.ForeColor = System.Drawing.Color.Red
        Me.rdOffline.Location = New System.Drawing.Point(131, 4)
        Me.rdOffline.Name = "rdOffline"
        Me.rdOffline.Size = New System.Drawing.Size(62, 19)
        Me.rdOffline.TabIndex = 1
        Me.rdOffline.TabStop = True
        Me.rdOffline.Text = "O&ffline"
        Me.rdOffline.UseVisualStyleBackColor = True
        '
        'pnlInstallType
        '
        Me.pnlInstallType.Controls.Add(Me.rdNew)
        Me.pnlInstallType.Controls.Add(Me.rdReinStall)
        Me.pnlInstallType.Location = New System.Drawing.Point(143, 65)
        Me.pnlInstallType.Name = "pnlInstallType"
        Me.pnlInstallType.Size = New System.Drawing.Size(322, 25)
        Me.pnlInstallType.TabIndex = 10
        '
        'rdNew
        '
        Me.rdNew.AutoSize = True
        Me.rdNew.Checked = True
        Me.rdNew.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNew.ForeColor = System.Drawing.Color.Red
        Me.rdNew.Location = New System.Drawing.Point(10, 3)
        Me.rdNew.Name = "rdNew"
        Me.rdNew.Size = New System.Drawing.Size(115, 19)
        Me.rdNew.TabIndex = 8
        Me.rdNew.TabStop = True
        Me.rdNew.Text = "&New Installation"
        Me.rdNew.UseVisualStyleBackColor = True
        '
        'rdReinStall
        '
        Me.rdReinStall.AutoSize = True
        Me.rdReinStall.Enabled = False
        Me.rdReinStall.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdReinStall.ForeColor = System.Drawing.Color.Red
        Me.rdReinStall.Location = New System.Drawing.Point(131, 3)
        Me.rdReinStall.Name = "rdReinStall"
        Me.rdReinStall.Size = New System.Drawing.Size(106, 19)
        Me.rdReinStall.TabIndex = 9
        Me.rdReinStall.Text = "&Re-Installation"
        Me.rdReinStall.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(136, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 42)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Note: You need to provide installation details to get the Activation key. Please " & _
            "contact Sales Representative for assistance."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(322, 304)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 28)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(190, 304)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(84, 28)
        Me.btnActivate.TabIndex = 3
        Me.btnActivate.Text = "&Activate"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(141, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mode of Activation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(141, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Installation Type"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(152, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Activate Retail Software"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmActivation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 401)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActivation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retail Software Activation"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlInstallOption.ResumeLayout(False)
        Me.pnlInstallOption.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlModeOfAct.ResumeLayout(False)
        Me.pnlModeOfAct.PerformLayout()
        Me.pnlInstallType.ResumeLayout(False)
        Me.pnlInstallType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rd30Days As System.Windows.Forms.RadioButton
    Friend WithEvents rdOffline As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnline As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdReinStall As System.Windows.Forms.RadioButton
    Friend WithEvents rdNew As System.Windows.Forms.RadioButton
    Friend WithEvents pnlInstallType As System.Windows.Forms.Panel
    Friend WithEvents pnlModeOfAct As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pnlInstallOption As System.Windows.Forms.Panel
    Friend WithEvents rdServer As System.Windows.Forms.RadioButton
    Friend WithEvents rdClient As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rdBasic As System.Windows.Forms.RadioButton
    Friend WithEvents rdProfessional As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdEnterprise As System.Windows.Forms.RadioButton
End Class
