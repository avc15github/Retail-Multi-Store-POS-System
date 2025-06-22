<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemUserField
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


    Public Sub New(ByVal ItemType As Char)

        InitializeComponent()
        Field_Type = ItemType
        If Field_Type = "I" Then
            Me.Text = "Item Fields"
        ElseIf Field_Type = "C" Then
            Me.Text = "Customer Fields"
        ElseIf Field_Type = "S" Then
            Me.Text = "Supplier Fields"
        ElseIf Field_Type = "E" Then
            Me.Text = "Employee Fields"
        ElseIf Field_Type = "B" Then 'Rajashri-14-03-2022
            Me.Text = "Style Fields"
        End If
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit
        Me.cmbFieldType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDisplaySeq = New NumericTextBox.NumericTextBox
        Me.txtAltCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAlias = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.chkAllBranch = New DevExpress.XtraEditors.CheckEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCountry = New DevExpress.XtraEditors.SimpleButton
        Me.FuncButtons = New FunctionButtons.FunctionButtons
        Me.Search = New SearchWindow.SearchWindow
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.grpMain.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.Appearance.Options.UseBackColor = True
        Me.grpMain.Appearance.Options.UseFont = True
        Me.grpMain.Controls.Add(Me.chkStatus)
        Me.grpMain.Controls.Add(Me.cmbFieldType)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.txtDisplaySeq)
        Me.grpMain.Controls.Add(Me.txtAltCode)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.txtAlias)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.txtName)
        Me.grpMain.Location = New System.Drawing.Point(5, 4)
        Me.grpMain.LookAndFeel.SkinName = "Money Twins"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(560, 141)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "GroupControl1"
        '
        'chkStatus
        '
        Me.chkStatus.EditValue = True
        Me.chkStatus.Location = New System.Drawing.Point(76, 74)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStatus.Properties.Appearance.Options.UseFont = True
        Me.chkStatus.Properties.Caption = "Active"
        Me.chkStatus.Size = New System.Drawing.Size(59, 19)
        Me.chkStatus.TabIndex = 7
        Me.chkStatus.TabStop = False
        Me.chkStatus.Visible = False
        '
        'cmbFieldType
        '
        Me.cmbFieldType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFieldType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFieldType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFieldType.FormattingEnabled = True
        Me.cmbFieldType.Location = New System.Drawing.Point(78, 43)
        Me.cmbFieldType.MaxLength = 50
        Me.cmbFieldType.Name = "cmbFieldType"
        Me.cmbFieldType.Size = New System.Drawing.Size(191, 21)
        Me.cmbFieldType.TabIndex = 5
        Me.cmbFieldType.Tag = "Field Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(275, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 14)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Display Seq"
        '
        'txtDisplaySeq
        '
        Me.txtDisplaySeq.AllowAlphabets = False
        Me.txtDisplaySeq.AllowMoveToNextControl = False
        Me.txtDisplaySeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisplaySeq.EditValue = 0
        Me.txtDisplaySeq.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplaySeq.Location = New System.Drawing.Point(362, 42)
        Me.txtDisplaySeq.Name = "txtDisplaySeq"
        Me.txtDisplaySeq.Size = New System.Drawing.Size(71, 22)
        Me.txtDisplaySeq.TabIndex = 6
        Me.txtDisplaySeq.Tag = "Quantity"
        Me.txtDisplaySeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAltCode
        '
        Me.txtAltCode.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltCode.Location = New System.Drawing.Point(319, -25)
        Me.txtAltCode.MaxLength = 40
        Me.txtAltCode.Name = "txtAltCode"
        Me.txtAltCode.Size = New System.Drawing.Size(10, 22)
        Me.txtAltCode.TabIndex = 4
        Me.txtAltCode.TabStop = False
        Me.txtAltCode.Tag = "Print Name"
        Me.txtAltCode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Field Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Display Name"
        '
        'txtAlias
        '
        Me.txtAlias.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(362, 12)
        Me.txtAlias.MaxLength = 50
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(190, 22)
        Me.txtAlias.TabIndex = 3
        Me.txtAlias.Tag = "Print Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Field Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(79, 11)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(190, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.Tag = "State"
        '
        'chkAllBranch
        '
        Me.chkAllBranch.Location = New System.Drawing.Point(277, -17)
        Me.chkAllBranch.Name = "chkAllBranch"
        Me.chkAllBranch.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllBranch.Properties.Appearance.Options.UseFont = True
        Me.chkAllBranch.Properties.Caption = "Create In All Branch"
        Me.chkAllBranch.Size = New System.Drawing.Size(41, 19)
        Me.chkAllBranch.TabIndex = 8
        Me.chkAllBranch.TabStop = False
        Me.chkAllBranch.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, -13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Alt_Code"
        Me.Label4.Visible = False
        '
        'btnCountry
        '
        Me.btnCountry.Appearance.BackColor = System.Drawing.Color.White
        Me.btnCountry.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountry.Appearance.Options.UseBackColor = True
        Me.btnCountry.Appearance.Options.UseFont = True
        Me.btnCountry.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCountry.Location = New System.Drawing.Point(254, -22)
        Me.btnCountry.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCountry.Name = "btnCountry"
        Me.btnCountry.Size = New System.Drawing.Size(20, 20)
        Me.btnCountry.TabIndex = 7
        Me.btnCountry.TabStop = False
        Me.btnCountry.Visible = False
        '
        'FuncButtons
        '
        Me.FuncButtons.ContinueToChangeImage = False
        Me.FuncButtons.DisplaySearchButton = False
        Me.FuncButtons.ExitButton = Nothing
        Me.FuncButtons.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncButtons.IsTransaction = False
        Me.FuncButtons.Location = New System.Drawing.Point(100, 105)
        Me.FuncButtons.Name = "FuncButtons"
        Me.FuncButtons.Size = New System.Drawing.Size(331, 31)
        Me.FuncButtons.TabIndex = 1
        '
        'Search
        '
        Me.Search.DisplaySearchRecords = True
        Me.Search.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(5, 150)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(560, 342)
        Me.Search.TabIndex = 2
        '
        'frmItemUserField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 497)
        Me.Controls.Add(Me.FuncButtons)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.btnCountry)
        Me.Controls.Add(Me.chkAllBranch)
        Me.Controls.Add(Me.Search)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmItemUserField"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item User Fields"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Search As SearchWindow.SearchWindow
    Friend WithEvents FuncButtons As FunctionButtons.FunctionButtons
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents btnCountry As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkAllBranch As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtAltCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDisplaySeq As NumericTextBox.NumericTextBox
    Friend WithEvents cmbFieldType As System.Windows.Forms.ComboBox
End Class
