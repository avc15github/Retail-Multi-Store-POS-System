<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModNoGenerate
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodeLength = New NumericTextBox.NumericTextBox
        Me.cmbType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSeqNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPrefix = New System.Windows.Forms.TextBox
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit
        Me.FuncButtons = New FunctionButtons.FunctionButtons
        Me.Search = New SearchWindow.SearchWindow
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.Appearance.Options.UseFont = True
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.txtCodeLength)
        Me.grpMain.Controls.Add(Me.cmbType)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.txtSeqNo)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.txtPrefix)
        Me.grpMain.Controls.Add(Me.chkStatus)
        Me.grpMain.Location = New System.Drawing.Point(5, 4)
        Me.grpMain.LookAndFeel.SkinName = "Blue"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(398, 149)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "GroupControl1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 307
        Me.Label2.Text = "Code Length"
        '
        'txtCodeLength
        '
        Me.txtCodeLength.AllowAlphabets = False
        Me.txtCodeLength.AllowMoveToNextControl = True
        Me.txtCodeLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodeLength.EditValue = 0
        Me.txtCodeLength.Location = New System.Drawing.Point(95, 65)
        Me.txtCodeLength.MaxLength = 2
        Me.txtCodeLength.Name = "txtCodeLength"
        Me.txtCodeLength.Size = New System.Drawing.Size(88, 21)
        Me.txtCodeLength.TabIndex = 4
        Me.txtCodeLength.Tag = "QtyVarinFabPO"
        Me.txtCodeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbType
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbType.Appearance = Appearance1
        Me.cmbType.AutoComplete = True
        Me.cmbType.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmbType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbType.FlatMode = True
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Location = New System.Drawing.Point(95, 8)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(269, 20)
        Me.cmbType.TabIndex = 1
        Me.cmbType.Tag = "SubGroup"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 305
        Me.Label5.Text = "Type"
        '
        'txtSeqNo
        '
        Me.txtSeqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeqNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeqNo.Location = New System.Drawing.Point(267, 35)
        Me.txtSeqNo.MaxLength = 8
        Me.txtSeqNo.Name = "txtSeqNo"
        Me.txtSeqNo.Size = New System.Drawing.Size(97, 22)
        Me.txtSeqNo.TabIndex = 3
        Me.txtSeqNo.Tag = "Alias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(218, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 303
        Me.Label4.Text = "Seq No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 14)
        Me.Label3.TabIndex = 222
        Me.Label3.Text = "Prefix"
        '
        'txtPrefix
        '
        Me.txtPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrefix.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(95, 34)
        Me.txtPrefix.MaxLength = 5
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(88, 22)
        Me.txtPrefix.TabIndex = 2
        Me.txtPrefix.Tag = "Alias"
        '
        'chkStatus
        '
        Me.chkStatus.Location = New System.Drawing.Point(219, 69)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStatus.Properties.Appearance.Options.UseFont = True
        Me.chkStatus.Properties.Caption = "Active"
        Me.chkStatus.Size = New System.Drawing.Size(59, 19)
        Me.chkStatus.TabIndex = 5
        '
        'FuncButtons
        '
        Me.FuncButtons.ContinueToChangeImage = False
        Me.FuncButtons.DisplaySearchButton = False
        Me.FuncButtons.ExitButton = Nothing
        Me.FuncButtons.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncButtons.IsTransaction = False
        Me.FuncButtons.Location = New System.Drawing.Point(38, 112)
        Me.FuncButtons.Name = "FuncButtons"
        Me.FuncButtons.Size = New System.Drawing.Size(331, 31)
        Me.FuncButtons.TabIndex = 1
        '
        'Search
        '
        Me.Search.DisplaySearchRecords = True
        Me.Search.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(5, 152)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(398, 271)
        Me.Search.TabIndex = 2
        '
        'frmModNoGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 425)
        Me.Controls.Add(Me.FuncButtons)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.Search)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmModNoGenerate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Module Number Generate"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Search As SearchWindow.SearchWindow
    Friend WithEvents FuncButtons As FunctionButtons.FunctionButtons
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSeqNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodeLength As NumericTextBox.NumericTextBox

End Class
