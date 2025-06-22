<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemCaption
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
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.dgvCaption = New System.Windows.Forms.DataGridView
        CType(Me.dgvCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Location = New System.Drawing.Point(179, 417)
        Me.btnCancel.LookAndFeel.SkinName = "Money Twins"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 25)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Close"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Location = New System.Drawing.Point(88, 417)
        Me.btnSave.LookAndFeel.SkinName = "Money Twins"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 25)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        '
        'dgvCaption
        '
        Me.dgvCaption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaption.Location = New System.Drawing.Point(9, 9)
        Me.dgvCaption.Name = "dgvCaption"
        Me.dgvCaption.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCaption.Size = New System.Drawing.Size(319, 399)
        Me.dgvCaption.TabIndex = 0
        '
        'frmSystemCaption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 454)
        Me.Controls.Add(Me.dgvCaption)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSystemCaption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Default Captions"
        CType(Me.dgvCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvCaption As System.Windows.Forms.DataGridView
End Class
