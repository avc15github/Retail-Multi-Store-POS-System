<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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

    Public Sub New(ByVal blnCancel As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        blnCancelBtn = blnCancel
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.btnStyleField = New DevExpress.XtraEditors.SimpleButton
        Me.btnEmployeeField = New DevExpress.XtraEditors.SimpleButton
        Me.btnSupplierField = New DevExpress.XtraEditors.SimpleButton
        Me.btnCustomerField = New DevExpress.XtraEditors.SimpleButton
        Me.btnItemField = New DevExpress.XtraEditors.SimpleButton
        Me.txtCopyTo = New System.Windows.Forms.TextBox
        Me.lblCaption = New System.Windows.Forms.Label
        Me.btnCopyTo = New System.Windows.Forms.Button
        Me.lblLastBackup = New System.Windows.Forms.Label
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnStyleField)
        Me.grpMain.Controls.Add(Me.btnEmployeeField)
        Me.grpMain.Controls.Add(Me.btnSupplierField)
        Me.grpMain.Controls.Add(Me.btnCustomerField)
        Me.grpMain.Controls.Add(Me.btnItemField)
        Me.grpMain.Controls.Add(Me.txtCopyTo)
        Me.grpMain.Controls.Add(Me.lblCaption)
        Me.grpMain.Controls.Add(Me.btnCopyTo)
        Me.grpMain.Location = New System.Drawing.Point(4, 6)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(399, 481)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "GroupControl1"
        '
        'btnStyleField
        '
        Me.btnStyleField.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStyleField.Appearance.Options.UseFont = True
        Me.btnStyleField.Location = New System.Drawing.Point(30, 125)
        Me.btnStyleField.LookAndFeel.SkinName = "Money Twins"
        Me.btnStyleField.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnStyleField.Name = "btnStyleField"
        Me.btnStyleField.Size = New System.Drawing.Size(136, 36)
        Me.btnStyleField.TabIndex = 35
        Me.btnStyleField.Text = "Style Fields"
        '
        'btnEmployeeField
        '
        Me.btnEmployeeField.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeField.Appearance.Options.UseFont = True
        Me.btnEmployeeField.Location = New System.Drawing.Point(239, 69)
        Me.btnEmployeeField.LookAndFeel.SkinName = "Money Twins"
        Me.btnEmployeeField.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnEmployeeField.Name = "btnEmployeeField"
        Me.btnEmployeeField.Size = New System.Drawing.Size(120, 36)
        Me.btnEmployeeField.TabIndex = 4
        Me.btnEmployeeField.Text = "Employee Fields"
        '
        'btnSupplierField
        '
        Me.btnSupplierField.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplierField.Appearance.Options.UseFont = True
        Me.btnSupplierField.Location = New System.Drawing.Point(30, 69)
        Me.btnSupplierField.LookAndFeel.SkinName = "Money Twins"
        Me.btnSupplierField.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSupplierField.Name = "btnSupplierField"
        Me.btnSupplierField.Size = New System.Drawing.Size(136, 36)
        Me.btnSupplierField.TabIndex = 3
        Me.btnSupplierField.Text = "Supplier Fields"
        '
        'btnCustomerField
        '
        Me.btnCustomerField.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerField.Appearance.Options.UseFont = True
        Me.btnCustomerField.Location = New System.Drawing.Point(239, 16)
        Me.btnCustomerField.LookAndFeel.SkinName = "Money Twins"
        Me.btnCustomerField.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCustomerField.Name = "btnCustomerField"
        Me.btnCustomerField.Size = New System.Drawing.Size(120, 36)
        Me.btnCustomerField.TabIndex = 2
        Me.btnCustomerField.Text = "Customer Fields"
        '
        'btnItemField
        '
        Me.btnItemField.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemField.Appearance.Options.UseFont = True
        Me.btnItemField.Location = New System.Drawing.Point(32, 16)
        Me.btnItemField.LookAndFeel.SkinName = "Money Twins"
        Me.btnItemField.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnItemField.Name = "btnItemField"
        Me.btnItemField.Size = New System.Drawing.Size(134, 36)
        Me.btnItemField.TabIndex = 1
        Me.btnItemField.Text = "Item Fields"
        '
        'txtCopyTo
        '
        Me.txtCopyTo.BackColor = System.Drawing.Color.White
        Me.txtCopyTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopyTo.Location = New System.Drawing.Point(0, -25)
        Me.txtCopyTo.Name = "txtCopyTo"
        Me.txtCopyTo.ReadOnly = True
        Me.txtCopyTo.Size = New System.Drawing.Size(10, 22)
        Me.txtCopyTo.TabIndex = 3
        Me.txtCopyTo.TabStop = False
        Me.txtCopyTo.Visible = False
        '
        'lblCaption
        '
        Me.lblCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(5, 447)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(585, 34)
        Me.lblCaption.TabIndex = 34
        '
        'btnCopyTo
        '
        Me.btnCopyTo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyTo.Location = New System.Drawing.Point(0, -23)
        Me.btnCopyTo.Name = "btnCopyTo"
        Me.btnCopyTo.Size = New System.Drawing.Size(32, 21)
        Me.btnCopyTo.TabIndex = 4
        Me.btnCopyTo.Text = "..."
        Me.btnCopyTo.Visible = False
        '
        'lblLastBackup
        '
        Me.lblLastBackup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastBackup.Location = New System.Drawing.Point(5, -3)
        Me.lblLastBackup.Name = "lblLastBackup"
        Me.lblLastBackup.Size = New System.Drawing.Size(11, 28)
        Me.lblLastBackup.TabIndex = 31
        Me.lblLastBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLastBackup.Visible = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 497)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.lblLastBackup)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSupplierField As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomerField As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnItemField As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCopyTo As System.Windows.Forms.TextBox
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents lblLastBackup As System.Windows.Forms.Label
    Friend WithEvents btnCopyTo As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeField As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStyleField As DevExpress.XtraEditors.SimpleButton
End Class

