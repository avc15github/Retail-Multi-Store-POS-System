<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeries
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
        Me.dtgSeries = New System.Windows.Forms.DataGrid
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.Label56 = New System.Windows.Forms.Label
        Me.cmbSeriesFor = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dtgSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cmbSeriesFor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgSeries
        '
        Me.dtgSeries.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtgSeries.CaptionBackColor = System.Drawing.Color.Maroon
        Me.dtgSeries.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSeries.CaptionText = "Series Details"
        Me.dtgSeries.CaptionVisible = False
        Me.dtgSeries.DataMember = ""
        Me.dtgSeries.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSeries.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSeries.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgSeries.Location = New System.Drawing.Point(8, 53)
        Me.dtgSeries.Name = "dtgSeries"
        Me.dtgSeries.Size = New System.Drawing.Size(610, 392)
        Me.dtgSeries.TabIndex = 2
        Me.dtgSeries.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label56)
        Me.GroupControl1.Controls.Add(Me.cmbSeriesFor)
        Me.GroupControl1.Controls.Add(Me.btnCancel)
        Me.GroupControl1.Controls.Add(Me.btnSave)
        Me.GroupControl1.Controls.Add(Me.dtgSeries)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 1)
        Me.GroupControl1.LookAndFeel.SkinName = "Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(627, 489)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(185, 29)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(60, 14)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "Series For"
        '
        'cmbSeriesFor
        '
        Me.cmbSeriesFor.AutoComplete = True
        Me.cmbSeriesFor.DisplayMember = "Led_Name"
        Me.cmbSeriesFor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSeriesFor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeriesFor.Location = New System.Drawing.Point(246, 25)
        Me.cmbSeriesFor.Name = "cmbSeriesFor"
        Me.cmbSeriesFor.Size = New System.Drawing.Size(189, 22)
        Me.cmbSeriesFor.TabIndex = 1
        Me.cmbSeriesFor.Tag = "Series For"
        Me.cmbSeriesFor.ValueMember = "Led_Key"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Location = New System.Drawing.Point(553, 453)
        Me.btnCancel.LookAndFeel.SkinName = "Money Twins"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 25)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Close"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Location = New System.Drawing.Point(462, 453)
        Me.btnSave.LookAndFeel.SkinName = "Money Twins"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 25)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        '
        'frmSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 491)
        Me.Controls.Add(Me.GroupControl1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Series Settings"
        CType(Me.dtgSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cmbSeriesFor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgSeries As System.Windows.Forms.DataGrid
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbSeriesFor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label56 As System.Windows.Forms.Label
End Class
