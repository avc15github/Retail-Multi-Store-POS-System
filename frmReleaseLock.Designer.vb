<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReleaseLock
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
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.chkLstRecordId = New System.Windows.Forms.CheckedListBox
        Me.lstTables = New System.Windows.Forms.ListBox
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.lstTables)
        Me.grpMain.Location = New System.Drawing.Point(12, 12)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(400, 280)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "GroupControl1"
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(156, 242)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 26)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.chkLstRecordId)
        Me.Panel1.Location = New System.Drawing.Point(246, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(137, 216)
        Me.Panel1.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Appearance.Options.UseFont = True
        Me.btnUpdate.Location = New System.Drawing.Point(3, 188)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(131, 26)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        '
        'chkLstRecordId
        '
        Me.chkLstRecordId.FormattingEnabled = True
        Me.chkLstRecordId.Location = New System.Drawing.Point(3, 3)
        Me.chkLstRecordId.Name = "chkLstRecordId"
        Me.chkLstRecordId.Size = New System.Drawing.Size(131, 184)
        Me.chkLstRecordId.TabIndex = 1
        '
        'lstTables
        '
        Me.lstTables.FormattingEnabled = True
        Me.lstTables.ItemHeight = 15
        Me.lstTables.Location = New System.Drawing.Point(18, 15)
        Me.lstTables.Name = "lstTables"
        Me.lstTables.Size = New System.Drawing.Size(189, 214)
        Me.lstTables.TabIndex = 0
        '
        'frmReleaseLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 303)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReleaseLock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Release Locks"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lstTables As System.Windows.Forms.ListBox
    Friend WithEvents chkLstRecordId As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
