<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayReportAI
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnConfirm = New DevExpress.XtraEditors.SimpleButton
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.txtReport = New AutoCompleteTextBox.AutoCompleteTextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Report Name"
        '
        'btnConfirm
        '
        Me.btnConfirm.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnConfirm.Appearance.Options.UseFont = True
        Me.btnConfirm.Appearance.Options.UseForeColor = True
        Me.btnConfirm.Location = New System.Drawing.Point(406, 22)
        Me.btnConfirm.LookAndFeel.SkinName = "Money Twins"
        Me.btnConfirm.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(66, 23)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Display"
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.txtReport)
        Me.grpMain.Controls.Add(Me.btnConfirm)
        Me.grpMain.Location = New System.Drawing.Point(9, 4)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(485, 167)
        Me.grpMain.TabIndex = 3
        Me.grpMain.TabStop = False
        '
        'txtReport
        '
        Me.txtReport.CreateNewCustomer = False
        Me.txtReport.DefaultCustomer = Nothing
        Me.txtReport.Location = New System.Drawing.Point(92, 23)
        Me.txtReport.Name = "txtReport"
        Me.txtReport.NewMobileNumber = False
        Me.txtReport.SearchWhere = AutoCompleteTextBox.AutoCompleteTextBox.SearchOptions.Start
        Me.txtReport.Size = New System.Drawing.Size(299, 22)
        Me.txtReport.SourceData = Nothing
        Me.txtReport.TabIndex = 1
        Me.txtReport.Tag = "Party"
        Me.txtReport.TextDescription = Nothing
        Me.txtReport.TextKey = Nothing
        Me.txtReport.TextValue = Nothing
        Me.txtReport.ValidateOnLeave = False
        Me.txtReport.Values = Nothing
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmDisplayReportAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 180)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDisplayReportAI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display Report AI"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtReport As AutoCompleteTextBox.AutoCompleteTextBox
End Class
