<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoiceSearch
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

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'NewUserId = LedKey
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.btnView = New DevExpress.XtraEditors.SimpleButton
        Me.cmbMenu = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbUser = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblLogin = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpGrid = New System.Windows.Forms.GroupBox
        Me.dtgDetails = New System.Windows.Forms.DataGrid
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.mnuOption = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAllowDisallow = New System.Windows.Forms.ToolStripMenuItem
        Me.grpMain.SuspendLayout()
        CType(Me.cmbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrid.SuspendLayout()
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMain.Controls.Add(Me.btnView)
        Me.grpMain.Controls.Add(Me.cmbMenu)
        Me.grpMain.Controls.Add(Me.cmbUser)
        Me.grpMain.Controls.Add(Me.lblLogin)
        Me.grpMain.Controls.Add(Me.Label2)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Location = New System.Drawing.Point(4, 0)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(697, 45)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'btnView
        '
        Me.btnView.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.Location = New System.Drawing.Point(311, 13)
        Me.btnView.LookAndFeel.SkinName = "Money Twins"
        Me.btnView.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(90, 22)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "Display "
        '
        'cmbMenu
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbMenu.Appearance = Appearance1
        Me.cmbMenu.AutoComplete = True
        Me.cmbMenu.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbMenu.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbMenu.FlatMode = True
        Me.cmbMenu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMenu.Location = New System.Drawing.Point(108, 15)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(193, 20)
        Me.cmbMenu.TabIndex = 3
        Me.cmbMenu.Tag = "Menu"
        '
        'cmbUser
        '
        Appearance2.FontData.Name = "Verdana"
        Appearance2.FontData.SizeInPoints = 8.0!
        Me.cmbUser.Appearance = Appearance2
        Me.cmbUser.AutoComplete = True
        Me.cmbUser.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbUser.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbUser.FlatMode = True
        Me.cmbUser.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUser.Location = New System.Drawing.Point(76, -22)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(145, 20)
        Me.cmbUser.TabIndex = 1
        Me.cmbUser.Tag = "Station"
        Me.cmbUser.Visible = False
        '
        'lblLogin
        '
        Me.lblLogin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Maroon
        Me.lblLogin.Location = New System.Drawing.Point(2, 15)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(103, 19)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Module Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, -19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Login Name"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, -20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        Me.Label1.Visible = False
        '
        'grpGrid
        '
        Me.grpGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGrid.Controls.Add(Me.dtgDetails)
        Me.grpGrid.Controls.Add(Me.btnClose)
        Me.grpGrid.Controls.Add(Me.btnUpdate)
        Me.grpGrid.Location = New System.Drawing.Point(4, 39)
        Me.grpGrid.Name = "grpGrid"
        Me.grpGrid.Size = New System.Drawing.Size(697, 449)
        Me.grpGrid.TabIndex = 0
        Me.grpGrid.TabStop = False
        '
        'dtgDetails
        '
        Me.dtgDetails.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetails.CaptionVisible = False
        Me.dtgDetails.DataMember = ""
        Me.dtgDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetails.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgDetails.Location = New System.Drawing.Point(5, 12)
        Me.dtgDetails.Name = "dtgDetails"
        Me.dtgDetails.Size = New System.Drawing.Size(685, 392)
        Me.dtgDetails.TabIndex = 44
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(359, 410)
        Me.btnClose.LookAndFeel.SkinName = "Money Twins"
        Me.btnClose.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 25)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        '
        'btnUpdate
        '
        Me.btnUpdate.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Appearance.Options.UseFont = True
        Me.btnUpdate.Appearance.Options.UseTextOptions = True
        Me.btnUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnUpdate.Location = New System.Drawing.Point(222, 410)
        Me.btnUpdate.LookAndFeel.SkinName = "Money Twins"
        Me.btnUpdate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 25)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        '
        'mnuOption
        '
        Me.mnuOption.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAllowDisallow})
        Me.mnuOption.Name = "mnuOption"
        Me.mnuOption.Size = New System.Drawing.Size(154, 26)
        '
        'mnuAllowDisallow
        '
        Me.mnuAllowDisallow.Name = "mnuAllowDisallow"
        Me.mnuAllowDisallow.Size = New System.Drawing.Size(153, 22)
        Me.mnuAllowDisallow.Text = "Allow/Disallow"
        '
        'frmVoiceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 494)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.grpGrid)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmVoiceSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Voice Search"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.cmbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrid.ResumeLayout(False)
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOption.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents grpGrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtgDetails As System.Windows.Forms.DataGrid
    Friend WithEvents cmbUser As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents mnuOption As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAllowDisallow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents cmbMenu As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
