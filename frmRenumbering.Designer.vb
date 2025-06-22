<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenumbering
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
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.btnStart = New DevExpress.XtraEditors.SimpleButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTransaction = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.grpMain.SuspendLayout()
        CType(Me.cmbTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnStart)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.cmbTransaction)
        Me.grpMain.Location = New System.Drawing.Point(7, 2)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(273, 138)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(53, 92)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(58, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Reset"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(164, 92)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(58, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction"
        '
        'cmbTransaction
        '
        Me.cmbTransaction.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTransaction.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransaction.Location = New System.Drawing.Point(89, 31)
        Me.cmbTransaction.Name = "cmbTransaction"
        Me.cmbTransaction.Size = New System.Drawing.Size(174, 22)
        Me.cmbTransaction.TabIndex = 1
        Me.cmbTransaction.Tag = "Transaction"
        '
        'frmRenumbering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 146)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmRenumbering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Renumber Transaction Doc"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.cmbTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTransaction As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnStart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
