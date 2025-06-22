<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftwareExtend
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lnkExtend = New System.Windows.Forms.LinkLabel
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.grpMain.AppearanceCaption.Options.UseFont = True
        Me.grpMain.AppearanceCaption.Options.UseForeColor = True
        Me.grpMain.Controls.Add(Me.btnOK)
        Me.grpMain.Controls.Add(Me.Label1)
        Me.grpMain.Controls.Add(Me.lnkExtend)
        Me.grpMain.Location = New System.Drawing.Point(0, 0)
        Me.grpMain.LookAndFeel.SkinName = "Money Twins"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(327, 136)
        Me.grpMain.TabIndex = 0
        Me.grpMain.Text = "Extend Demo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(28, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Software Expired, Contact Administrator !"
        '
        'lnkExtend
        '
        Me.lnkExtend.AutoSize = True
        Me.lnkExtend.Location = New System.Drawing.Point(97, 68)
        Me.lnkExtend.Name = "lnkExtend"
        Me.lnkExtend.Size = New System.Drawing.Size(132, 14)
        Me.lnkExtend.TabIndex = 0
        Me.lnkExtend.TabStop = True
        Me.lnkExtend.Text = "Extend another 15 days"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(124, 96)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(78, 27)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'frmSoftwareExtend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 138)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSoftwareExtend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extend Demo"
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lnkExtend As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
End Class
