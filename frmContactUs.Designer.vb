<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactUs
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
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtWebsite = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPhone2 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtPhone1 = New System.Windows.Forms.TextBox
        Me.txtRegdAddress = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtMobile = New NumericTextBox.NumericTextBox
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Search = New SearchWindow.SearchWindow
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpMain.Appearance.Options.UseBackColor = True
        Me.grpMain.Controls.Add(Me.btnCancel)
        Me.grpMain.Controls.Add(Me.btnSave)
        Me.grpMain.Controls.Add(Me.txtWebsite)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.txtPhone2)
        Me.grpMain.Controls.Add(Me.Label16)
        Me.grpMain.Controls.Add(Me.Label17)
        Me.grpMain.Controls.Add(Me.Label12)
        Me.grpMain.Controls.Add(Me.txtFax)
        Me.grpMain.Controls.Add(Me.txtEmail)
        Me.grpMain.Controls.Add(Me.txtPhone1)
        Me.grpMain.Controls.Add(Me.txtRegdAddress)
        Me.grpMain.Controls.Add(Me.Label9)
        Me.grpMain.Controls.Add(Me.txtMobile)
        Me.grpMain.Controls.Add(Me.txtRemark)
        Me.grpMain.Controls.Add(Me.Label56)
        Me.grpMain.Controls.Add(Me.Label30)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.txtContact)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.txtName)
        Me.grpMain.Location = New System.Drawing.Point(5, 4)
        Me.grpMain.LookAndFeel.SkinName = "Blue"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(451, 369)
        Me.grpMain.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(254, 328)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 29)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(131, 328)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 29)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtWebsite
        '
        Me.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWebsite.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebsite.Location = New System.Drawing.Point(88, 221)
        Me.txtWebsite.MaxLength = 50
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(228, 22)
        Me.txtWebsite.TabIndex = 17
        Me.txtWebsite.Tag = "Website"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Website"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "2"
        '
        'txtPhone2
        '
        Me.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone2.Location = New System.Drawing.Point(270, 137)
        Me.txtPhone2.MaxLength = 40
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(158, 22)
        Me.txtPhone2.TabIndex = 9
        Me.txtPhone2.Tag = "Phone 2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 169)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 14)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Fax"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(23, 197)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 14)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 14)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Phone 1"
        '
        'txtFax
        '
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFax.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(88, 165)
        Me.txtFax.MaxLength = 40
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(157, 22)
        Me.txtFax.TabIndex = 11
        Me.txtFax.Tag = "Fax"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(88, 193)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(340, 22)
        Me.txtEmail.TabIndex = 15
        Me.txtEmail.Tag = "Email"
        '
        'txtPhone1
        '
        Me.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone1.Location = New System.Drawing.Point(88, 137)
        Me.txtPhone1.MaxLength = 40
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(157, 22)
        Me.txtPhone1.TabIndex = 7
        Me.txtPhone1.Tag = "Phone 1"
        '
        'txtRegdAddress
        '
        Me.txtRegdAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegdAddress.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegdAddress.Location = New System.Drawing.Point(88, 66)
        Me.txtRegdAddress.MaxLength = 200
        Me.txtRegdAddress.Multiline = True
        Me.txtRegdAddress.Name = "txtRegdAddress"
        Me.txtRegdAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegdAddress.Size = New System.Drawing.Size(340, 65)
        Me.txtRegdAddress.TabIndex = 5
        Me.txtRegdAddress.Tag = "Regd Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Address"
        '
        'txtMobile
        '
        Me.txtMobile.AllowAlphabets = False
        Me.txtMobile.AllowMoveToNextControl = True
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.EditValue = 0
        Me.txtMobile.Location = New System.Drawing.Point(303, 165)
        Me.txtMobile.MaxLength = 40
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(125, 22)
        Me.txtMobile.TabIndex = 13
        Me.txtMobile.Tag = "Mobile"
        Me.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(88, 249)
        Me.txtRemark.MaxLength = 500
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(340, 69)
        Me.txtRemark.TabIndex = 19
        Me.txtRemark.TabStop = False
        Me.txtRemark.Tag = "Remark"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(23, 258)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(48, 14)
        Me.Label56.TabIndex = 18
        Me.Label56.Text = "Remark"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(251, 169)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 14)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Mobile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contact"
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(88, 38)
        Me.txtContact.MaxLength = 40
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(228, 22)
        Me.txtContact.TabIndex = 3
        Me.txtContact.Tag = "Contact Person"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(88, 10)
        Me.txtName.MaxLength = 80
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(340, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.Tag = "Name"
        '
        'Search
        '
        Me.Search.DisplaySearchRecords = True
        Me.Search.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(5, 4)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(451, 369)
        Me.Search.TabIndex = 9
        '
        'frmContactUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 381)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.Search)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmContactUs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Us"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Search As SearchWindow.SearchWindow
    Friend WithEvents txtMobile As NumericTextBox.NumericTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRegdAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
