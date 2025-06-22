<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrans1
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
        Me.grpOpen = New System.Windows.Forms.GroupBox
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.dtpTo = New DateTimePick.DateTimePick
        Me.lblFrom = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.dtpFrom = New DateTimePick.DateTimePick
        Me.btnOpenCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.lblLabel = New System.Windows.Forms.Label
        Me.grpOpen.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOpen
        '
        Me.grpOpen.Controls.Add(Me.pnlDate)
        Me.grpOpen.Controls.Add(Me.btnOpenCancel)
        Me.grpOpen.Controls.Add(Me.btnSave)
        Me.grpOpen.Location = New System.Drawing.Point(5, 36)
        Me.grpOpen.Name = "grpOpen"
        Me.grpOpen.Size = New System.Drawing.Size(320, 97)
        Me.grpOpen.TabIndex = 0
        Me.grpOpen.TabStop = False
        '
        'pnlDate
        '
        Me.pnlDate.Controls.Add(Me.dtpTo)
        Me.pnlDate.Controls.Add(Me.lblFrom)
        Me.pnlDate.Controls.Add(Me.lblTo)
        Me.pnlDate.Controls.Add(Me.dtpFrom)
        Me.pnlDate.Location = New System.Drawing.Point(17, 16)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(286, 31)
        Me.pnlDate.TabIndex = 4
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(189, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(89, 23)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.Value = New Date(2017, 12, 28, 0, 0, 0, 0)
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(5, 8)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(31, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(149, 8)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTo.Size = New System.Drawing.Size(19, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(50, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(89, 23)
        Me.dtpFrom.TabIndex = 0
        Me.dtpFrom.Value = New Date(2017, 12, 28, 0, 0, 0, 0)
        '
        'btnOpenCancel
        '
        Me.btnOpenCancel.Location = New System.Drawing.Point(158, 62)
        Me.btnOpenCancel.Name = "btnOpenCancel"
        Me.btnOpenCancel.Size = New System.Drawing.Size(58, 26)
        Me.btnOpenCancel.TabIndex = 3
        Me.btnOpenCancel.Text = "Close"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(93, 62)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 26)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Show"
        '
        'lblLabel
        '
        Me.lblLabel.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.Location = New System.Drawing.Point(23, 9)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(283, 25)
        Me.lblLabel.TabIndex = 0
        Me.lblLabel.Text = "Trans 1"
        Me.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTrans1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 138)
        Me.Controls.Add(Me.grpOpen)
        Me.Controls.Add(Me.lblLabel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmTrans1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trans 1"
        Me.grpOpen.ResumeLayout(False)
        Me.pnlDate.ResumeLayout(False)
        Me.pnlDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpOpen As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpenCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents dtpTo As DateTimePick.DateTimePick
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As DateTimePick.DateTimePick
End Class
