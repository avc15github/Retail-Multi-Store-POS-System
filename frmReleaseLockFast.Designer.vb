<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReleaseLockFast
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.chkLstRecordId = New System.Windows.Forms.CheckedListBox
        Me.lstTables = New System.Windows.Forms.ListBox
        Me.btnView = New DevExpress.XtraEditors.SimpleButton
        Me.cmbMenu = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.txtSearch)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.lstTables)
        Me.grpMain.Location = New System.Drawing.Point(16, 39)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(500, 373)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "GroupControl1"
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(195, 335)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 26)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.chkLstRecordId)
        Me.Panel1.Location = New System.Drawing.Point(271, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 278)
        Me.Panel1.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Appearance.Options.UseFont = True
        Me.btnUpdate.Location = New System.Drawing.Point(26, 245)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(131, 26)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        '
        'chkLstRecordId
        '
        Me.chkLstRecordId.FormattingEnabled = True
        Me.chkLstRecordId.Location = New System.Drawing.Point(4, 4)
        Me.chkLstRecordId.Name = "chkLstRecordId"
        Me.chkLstRecordId.Size = New System.Drawing.Size(187, 220)
        Me.chkLstRecordId.TabIndex = 1
        '
        'lstTables
        '
        Me.lstTables.FormattingEnabled = True
        Me.lstTables.ItemHeight = 15
        Me.lstTables.Location = New System.Drawing.Point(33, 42)
        Me.lstTables.Name = "lstTables"
        Me.lstTables.Size = New System.Drawing.Size(201, 274)
        Me.lstTables.TabIndex = 0
        '
        'btnView
        '
        Me.btnView.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.Location = New System.Drawing.Point(334, 9)
        Me.btnView.LookAndFeel.SkinName = "Money Twins"
        Me.btnView.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(90, 22)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View Modules"
        '
        'cmbMenu
        '
        Appearance4.FontData.Name = "Verdana"
        Appearance4.FontData.SizeInPoints = 8.0!
        Me.cmbMenu.Appearance = Appearance4
        Me.cmbMenu.AutoComplete = True
        Me.cmbMenu.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbMenu.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMenu.FlatMode = True
        Me.cmbMenu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMenu.Location = New System.Drawing.Point(168, 10)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(156, 20)
        Me.cmbMenu.TabIndex = 4
        Me.cmbMenu.Tag = "Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(152, 8)
        Me.txtSearch.MaxLength = 40
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(156, 22)
        Me.txtSearch.TabIndex = 223
        Me.txtSearch.Tag = "Alias"
        '
        'frmReleaseLockFast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 425)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.cmbMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReleaseLockFast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Release Locks"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cmbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lstTables As System.Windows.Forms.ListBox
    Friend WithEvents chkLstRecordId As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbMenu As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
