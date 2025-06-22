<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportTypeAI
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
        Me.btnFile = New DevExpress.XtraEditors.SimpleButton
        Me.chkShowFilter = New DevExpress.XtraEditors.CheckEdit
        Me.chkShowDate = New DevExpress.XtraEditors.CheckEdit
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtReportName = New System.Windows.Forms.TextBox
        Me.txtSearchName = New System.Windows.Forms.TextBox
        Me.chkAllBranch = New DevExpress.XtraEditors.CheckEdit
        Me.Search = New SearchWindow.SearchWindow
        Me.FuncButtons = New FunctionButtons.FunctionButtons
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.chkShowFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.Appearance.Options.UseFont = True
        Me.grpMain.Controls.Add(Me.btnFile)
        Me.grpMain.Controls.Add(Me.chkShowFilter)
        Me.grpMain.Controls.Add(Me.chkShowDate)
        Me.grpMain.Controls.Add(Me.chkStatus)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.txtReportName)
        Me.grpMain.Controls.Add(Me.txtSearchName)
        Me.grpMain.Controls.Add(Me.chkAllBranch)
        Me.grpMain.Location = New System.Drawing.Point(-1, 1)
        Me.grpMain.LookAndFeel.SkinName = "Blue"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(599, 140)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "GroupControl1"
        '
        'btnFile
        '
        Me.btnFile.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Appearance.Options.UseFont = True
        Me.btnFile.Location = New System.Drawing.Point(534, 38)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(32, 22)
        Me.btnFile.TabIndex = 10
        Me.btnFile.Text = "..."
        '
        'chkShowFilter
        '
        Me.chkShowFilter.Location = New System.Drawing.Point(488, 12)
        Me.chkShowFilter.Name = "chkShowFilter"
        Me.chkShowFilter.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowFilter.Properties.Appearance.Options.UseFont = True
        Me.chkShowFilter.Properties.Caption = "Show Filter"
        Me.chkShowFilter.Size = New System.Drawing.Size(88, 19)
        Me.chkShowFilter.TabIndex = 3
        '
        'chkShowDate
        '
        Me.chkShowDate.Location = New System.Drawing.Point(394, 11)
        Me.chkShowDate.Name = "chkShowDate"
        Me.chkShowDate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDate.Properties.Appearance.Options.UseFont = True
        Me.chkShowDate.Properties.Caption = "Show Date"
        Me.chkShowDate.Size = New System.Drawing.Size(88, 19)
        Me.chkShowDate.TabIndex = 2
        '
        'chkStatus
        '
        Me.chkStatus.Location = New System.Drawing.Point(90, 66)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStatus.Properties.Appearance.Options.UseFont = True
        Me.chkStatus.Properties.Caption = "Active"
        Me.chkStatus.Size = New System.Drawing.Size(59, 19)
        Me.chkStatus.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Report Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Name"
        '
        'txtReportName
        '
        Me.txtReportName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportName.Location = New System.Drawing.Point(92, 38)
        Me.txtReportName.MaxLength = 40
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.ReadOnly = True
        Me.txtReportName.Size = New System.Drawing.Size(436, 22)
        Me.txtReportName.TabIndex = 4
        Me.txtReportName.Tag = "Print Name"
        '
        'txtSearchName
        '
        Me.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchName.Location = New System.Drawing.Point(92, 10)
        Me.txtSearchName.MaxLength = 40
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(288, 22)
        Me.txtSearchName.TabIndex = 1
        Me.txtSearchName.Tag = "Product Type"
        '
        'chkAllBranch
        '
        Me.chkAllBranch.Location = New System.Drawing.Point(267, 135)
        Me.chkAllBranch.Name = "chkAllBranch"
        Me.chkAllBranch.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllBranch.Properties.Appearance.Options.UseFont = True
        Me.chkAllBranch.Properties.Caption = "Create In All Branch"
        Me.chkAllBranch.Size = New System.Drawing.Size(135, 19)
        Me.chkAllBranch.TabIndex = 7
        Me.chkAllBranch.Visible = False
        '
        'Search
        '
        Me.Search.DisplaySearchRecords = True
        Me.Search.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(0, 141)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(598, 355)
        Me.Search.TabIndex = 2
        '
        'FuncButtons
        '
        Me.FuncButtons.ContinueToChangeImage = False
        Me.FuncButtons.DisplaySearchButton = False
        Me.FuncButtons.ExitButton = Nothing
        Me.FuncButtons.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncButtons.IsTransaction = False
        Me.FuncButtons.Location = New System.Drawing.Point(89, 99)
        Me.FuncButtons.Name = "FuncButtons"
        Me.FuncButtons.Size = New System.Drawing.Size(331, 31)
        Me.FuncButtons.TabIndex = 1
        '
        'frmReportTypeAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 497)
        Me.Controls.Add(Me.FuncButtons)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.Search)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReportTypeAI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Type AI"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.chkShowFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Search As SearchWindow.SearchWindow
    Friend WithEvents FuncButtons As FunctionButtons.FunctionButtons
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReportName As System.Windows.Forms.TextBox
    Friend WithEvents chkAllBranch As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkShowFilter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkShowDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnFile As DevExpress.XtraEditors.SimpleButton

End Class
