<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommissionStockLevel
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommissionStockLevel))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dtgDetails = New System.Windows.Forms.DataGrid
        Me.cmbType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblType = New System.Windows.Forms.Label
        Me.dtpChlnDate = New DateTimePick.DateTimePick
        Me.dtpPurDocDt = New DateTimePick.DateTimePick
        Me.txtChlnNo = New System.Windows.Forms.TextBox
        Me.txtPurDocNo = New System.Windows.Forms.TextBox
        Me.btnOccassion = New DevExpress.XtraEditors.SimpleButton
        Me.btnSeason = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuality = New DevExpress.XtraEditors.SimpleButton
        Me.lblSubGroup = New System.Windows.Forms.Label
        Me.lblProduct = New System.Windows.Forms.Label
        Me.grpSize = New DevExpress.XtraEditors.GroupControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotSizeReOrderQty = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotSizeMaxQty = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.lblTotSizeMinQty = New System.Windows.Forms.Label
        Me.btnSizeCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSizeConfirm = New DevExpress.XtraEditors.SimpleButton
        Me.dtgSize = New System.Windows.Forms.DataGrid
        Me.grpMain = New DevExpress.XtraEditors.GroupControl
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.txtCommission = New NumericTextBox.NumericTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbLocation = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkBarcode = New DevExpress.XtraEditors.CheckEdit
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTakaNo = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtQty = New NumericTextBox.NumericTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.cmbSize = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.lblArticleNo = New System.Windows.Forms.Label
        Me.cmbBrand = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblBrand = New System.Windows.Forms.Label
        Me.cmbItmSubGroup = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txtBillPurRate = New NumericTextBox.NumericTextBox
        Me.txtBillSaleRate = New NumericTextBox.NumericTextBox
        Me.Search = New SearchWindow.SearchWindow
        Me.lnkPrintBarcode = New System.Windows.Forms.LinkLabel
        Me.grpPrnBarcode = New DevExpress.XtraEditors.GroupControl
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.txtNoOfColumns = New DevExpress.XtraEditors.TextEdit
        Me.txtBlankLines = New DevExpress.XtraEditors.TextEdit
        Me.btnBarCdClose = New DevExpress.XtraEditors.SimpleButton
        Me.btnBarCdView = New DevExpress.XtraEditors.SimpleButton
        Me.btnBarCdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.txtSrTo = New DevExpress.XtraEditors.TextEdit
        Me.txtSrFrom = New DevExpress.XtraEditors.TextEdit
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.cmbFormat = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label32 = New System.Windows.Forms.Label
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton
        Me.imgButtonList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbProduct = New System.Windows.Forms.ComboBox
        Me.cmbStyle = New System.Windows.Forms.ComboBox
        Me.cmbShade = New System.Windows.Forms.ComboBox
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSize.SuspendLayout()
        CType(Me.dtgSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.cmbLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbItmSubGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPrnBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrnBarcode.SuspendLayout()
        CType(Me.txtNoOfColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBlankLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgDetails
        '
        Me.dtgDetails.CaptionFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetails.CaptionForeColor = System.Drawing.Color.White
        Me.dtgDetails.CaptionText = "Stock  Details"
        Me.dtgDetails.DataMember = ""
        Me.dtgDetails.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetails.HeaderFont = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetails.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgDetails.Location = New System.Drawing.Point(1, 110)
        Me.dtgDetails.Name = "dtgDetails"
        Me.dtgDetails.Size = New System.Drawing.Size(964, 464)
        Me.dtgDetails.TabIndex = 18
        '
        'cmbType
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbType.Appearance = Appearance1
        Me.cmbType.AutoComplete = True
        Me.cmbType.AutoSize = False
        Me.cmbType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbType.FlatMode = True
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Location = New System.Drawing.Point(291, 30)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(160, 21)
        Me.cmbType.TabIndex = 9
        Me.cmbType.Tag = "Type"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(232, 33)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 14)
        Me.lblType.TabIndex = 8
        Me.lblType.Text = "Type"
        '
        'dtpChlnDate
        '
        Me.dtpChlnDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChlnDate.Location = New System.Drawing.Point(173, 586)
        Me.dtpChlnDate.Name = "dtpChlnDate"
        Me.dtpChlnDate.Size = New System.Drawing.Size(24, 22)
        Me.dtpChlnDate.TabIndex = 52
        Me.dtpChlnDate.Tag = "Challan Date"
        Me.dtpChlnDate.Value = New Date(2023, 10, 12, 0, 0, 0, 0)
        Me.dtpChlnDate.Visible = False
        '
        'dtpPurDocDt
        '
        Me.dtpPurDocDt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurDocDt.Location = New System.Drawing.Point(128, 583)
        Me.dtpPurDocDt.Name = "dtpPurDocDt"
        Me.dtpPurDocDt.Size = New System.Drawing.Size(18, 22)
        Me.dtpPurDocDt.TabIndex = 48
        Me.dtpPurDocDt.Tag = "Purchase Doc Dt"
        Me.dtpPurDocDt.Value = New Date(2023, 10, 12, 0, 0, 0, 0)
        Me.dtpPurDocDt.Visible = False
        '
        'txtChlnNo
        '
        Me.txtChlnNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChlnNo.Location = New System.Drawing.Point(149, 584)
        Me.txtChlnNo.MaxLength = 20
        Me.txtChlnNo.Name = "txtChlnNo"
        Me.txtChlnNo.Size = New System.Drawing.Size(18, 22)
        Me.txtChlnNo.TabIndex = 50
        Me.txtChlnNo.Tag = "Challan No"
        Me.txtChlnNo.Visible = False
        '
        'txtPurDocNo
        '
        Me.txtPurDocNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurDocNo.Location = New System.Drawing.Point(99, 584)
        Me.txtPurDocNo.MaxLength = 20
        Me.txtPurDocNo.Name = "txtPurDocNo"
        Me.txtPurDocNo.Size = New System.Drawing.Size(24, 22)
        Me.txtPurDocNo.TabIndex = 46
        Me.txtPurDocNo.Tag = "Purchase Doc No"
        Me.txtPurDocNo.Visible = False
        '
        'btnOccassion
        '
        Me.btnOccassion.Appearance.BackColor = System.Drawing.Color.White
        Me.btnOccassion.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOccassion.Appearance.Options.UseBackColor = True
        Me.btnOccassion.Appearance.Options.UseFont = True
        Me.btnOccassion.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnOccassion.Location = New System.Drawing.Point(840, 584)
        Me.btnOccassion.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnOccassion.Name = "btnOccassion"
        Me.btnOccassion.Size = New System.Drawing.Size(20, 21)
        Me.btnOccassion.TabIndex = 69
        Me.btnOccassion.TabStop = False
        Me.btnOccassion.Visible = False
        '
        'btnSeason
        '
        Me.btnSeason.Appearance.BackColor = System.Drawing.Color.White
        Me.btnSeason.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeason.Appearance.Options.UseBackColor = True
        Me.btnSeason.Appearance.Options.UseFont = True
        Me.btnSeason.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSeason.Location = New System.Drawing.Point(802, 594)
        Me.btnSeason.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSeason.Name = "btnSeason"
        Me.btnSeason.Size = New System.Drawing.Size(20, 21)
        Me.btnSeason.TabIndex = 10
        Me.btnSeason.TabStop = False
        Me.btnSeason.Visible = False
        '
        'btnQuality
        '
        Me.btnQuality.Appearance.BackColor = System.Drawing.Color.White
        Me.btnQuality.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuality.Appearance.Options.UseBackColor = True
        Me.btnQuality.Appearance.Options.UseFont = True
        Me.btnQuality.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuality.Location = New System.Drawing.Point(828, 598)
        Me.btnQuality.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnQuality.Name = "btnQuality"
        Me.btnQuality.Size = New System.Drawing.Size(20, 21)
        Me.btnQuality.TabIndex = 10
        Me.btnQuality.TabStop = False
        Me.btnQuality.Visible = False
        '
        'lblSubGroup
        '
        Me.lblSubGroup.AutoSize = True
        Me.lblSubGroup.BackColor = System.Drawing.Color.Transparent
        Me.lblSubGroup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubGroup.Location = New System.Drawing.Point(232, 9)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(60, 14)
        Me.lblSubGroup.TabIndex = 2
        Me.lblSubGroup.Text = "SubGroup"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.BackColor = System.Drawing.Color.Transparent
        Me.lblProduct.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(462, 9)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(47, 14)
        Me.lblProduct.TabIndex = 3
        Me.lblProduct.Text = "Product"
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.Label2)
        Me.grpSize.Controls.Add(Me.lblTotSizeReOrderQty)
        Me.grpSize.Controls.Add(Me.Label1)
        Me.grpSize.Controls.Add(Me.lblTotSizeMaxQty)
        Me.grpSize.Controls.Add(Me.Label31)
        Me.grpSize.Controls.Add(Me.lblTotSizeMinQty)
        Me.grpSize.Controls.Add(Me.btnSizeCancel)
        Me.grpSize.Controls.Add(Me.btnSizeConfirm)
        Me.grpSize.Controls.Add(Me.dtgSize)
        Me.grpSize.Location = New System.Drawing.Point(4, 163)
        Me.grpSize.LookAndFeel.SkinName = "Caramel"
        Me.grpSize.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(418, 264)
        Me.grpSize.TabIndex = 41
        Me.grpSize.Text = "Size Wise Details"
        Me.grpSize.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 14)
        Me.Label2.TabIndex = 260
        Me.Label2.Text = "Tot ReOrder :"
        '
        'lblTotSizeReOrderQty
        '
        Me.lblTotSizeReOrderQty.BackColor = System.Drawing.Color.Transparent
        Me.lblTotSizeReOrderQty.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSizeReOrderQty.Location = New System.Drawing.Point(364, 215)
        Me.lblTotSizeReOrderQty.Name = "lblTotSizeReOrderQty"
        Me.lblTotSizeReOrderQty.Size = New System.Drawing.Size(46, 19)
        Me.lblTotSizeReOrderQty.TabIndex = 259
        Me.lblTotSizeReOrderQty.Text = "0.00"
        Me.lblTotSizeReOrderQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 258
        Me.Label1.Text = "Tot Max :"
        '
        'lblTotSizeMaxQty
        '
        Me.lblTotSizeMaxQty.BackColor = System.Drawing.Color.Transparent
        Me.lblTotSizeMaxQty.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSizeMaxQty.Location = New System.Drawing.Point(228, 215)
        Me.lblTotSizeMaxQty.Name = "lblTotSizeMaxQty"
        Me.lblTotSizeMaxQty.Size = New System.Drawing.Size(46, 19)
        Me.lblTotSizeMaxQty.TabIndex = 257
        Me.lblTotSizeMaxQty.Text = "0.00"
        Me.lblTotSizeMaxQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(57, 216)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 14)
        Me.Label31.TabIndex = 256
        Me.Label31.Text = "Tot Min :"
        '
        'lblTotSizeMinQty
        '
        Me.lblTotSizeMinQty.BackColor = System.Drawing.Color.Transparent
        Me.lblTotSizeMinQty.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSizeMinQty.Location = New System.Drawing.Point(113, 214)
        Me.lblTotSizeMinQty.Name = "lblTotSizeMinQty"
        Me.lblTotSizeMinQty.Size = New System.Drawing.Size(46, 19)
        Me.lblTotSizeMinQty.TabIndex = 255
        Me.lblTotSizeMinQty.Text = "0.00"
        Me.lblTotSizeMinQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSizeCancel
        '
        Me.btnSizeCancel.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSizeCancel.Appearance.Options.UseFont = True
        Me.btnSizeCancel.Image = CType(resources.GetObject("btnSizeCancel.Image"), System.Drawing.Image)
        Me.btnSizeCancel.Location = New System.Drawing.Point(330, 236)
        Me.btnSizeCancel.Name = "btnSizeCancel"
        Me.btnSizeCancel.Size = New System.Drawing.Size(81, 23)
        Me.btnSizeCancel.TabIndex = 254
        Me.btnSizeCancel.Text = "Cancel"
        '
        'btnSizeConfirm
        '
        Me.btnSizeConfirm.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSizeConfirm.Appearance.Options.UseFont = True
        Me.btnSizeConfirm.Image = CType(resources.GetObject("btnSizeConfirm.Image"), System.Drawing.Image)
        Me.btnSizeConfirm.Location = New System.Drawing.Point(244, 236)
        Me.btnSizeConfirm.Name = "btnSizeConfirm"
        Me.btnSizeConfirm.Size = New System.Drawing.Size(81, 23)
        Me.btnSizeConfirm.TabIndex = 253
        Me.btnSizeConfirm.Text = "Confirm"
        '
        'dtgSize
        '
        Me.dtgSize.CaptionFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSize.CaptionVisible = False
        Me.dtgSize.DataMember = ""
        Me.dtgSize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSize.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgSize.Location = New System.Drawing.Point(7, 27)
        Me.dtgSize.Name = "dtgSize"
        Me.dtgSize.Size = New System.Drawing.Size(406, 185)
        Me.dtgSize.TabIndex = 0
        '
        'grpMain
        '
        Me.grpMain.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.Appearance.Options.UseFont = True
        Me.grpMain.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.AppearanceCaption.Options.UseFont = True
        Me.grpMain.Controls.Add(Me.cmbShade)
        Me.grpMain.Controls.Add(Me.cmbStyle)
        Me.grpMain.Controls.Add(Me.cmbProduct)
        Me.grpMain.Controls.Add(Me.btnUpdate)
        Me.grpMain.Controls.Add(Me.txtCommission)
        Me.grpMain.Controls.Add(Me.Label9)
        Me.grpMain.Controls.Add(Me.cmbLocation)
        Me.grpMain.Controls.Add(Me.Label7)
        Me.grpMain.Controls.Add(Me.chkBarcode)
        Me.grpMain.Controls.Add(Me.btnSearch)
        Me.grpMain.Controls.Add(Me.Label13)
        Me.grpMain.Controls.Add(Me.txtTakaNo)
        Me.grpMain.Controls.Add(Me.btnClear)
        Me.grpMain.Controls.Add(Me.txtQty)
        Me.grpMain.Controls.Add(Me.Label6)
        Me.grpMain.Controls.Add(Me.Label8)
        Me.grpMain.Controls.Add(Me.btnShow)
        Me.grpMain.Controls.Add(Me.cmbSize)
        Me.grpMain.Controls.Add(Me.Label5)
        Me.grpMain.Controls.Add(Me.Label4)
        Me.grpMain.Controls.Add(Me.Label3)
        Me.grpMain.Controls.Add(Me.txtBarcode)
        Me.grpMain.Controls.Add(Me.lblArticleNo)
        Me.grpMain.Controls.Add(Me.cmbBrand)
        Me.grpMain.Controls.Add(Me.lblBrand)
        Me.grpMain.Controls.Add(Me.cmbItmSubGroup)
        Me.grpMain.Controls.Add(Me.lblProduct)
        Me.grpMain.Controls.Add(Me.lblSubGroup)
        Me.grpMain.Controls.Add(Me.dtgDetails)
        Me.grpMain.Controls.Add(Me.cmbType)
        Me.grpMain.Controls.Add(Me.lblType)
        Me.grpMain.Location = New System.Drawing.Point(3, 2)
        Me.grpMain.LookAndFeel.SkinName = "Money Twins"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(964, 615)
        Me.grpMain.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Blue
        Me.btnUpdate.Location = New System.Drawing.Point(235, 55)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(71, 24)
        Me.btnUpdate.TabIndex = 50
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtCommission
        '
        Me.txtCommission.AllowAlphabets = False
        Me.txtCommission.AllowMoveToNextControl = False
        Me.txtCommission.BackColor = System.Drawing.Color.White
        Me.txtCommission.EditValue = 0
        Me.txtCommission.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommission.Location = New System.Drawing.Point(117, 56)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(102, 22)
        Me.txtCommission.TabIndex = 49
        Me.txtCommission.Tag = ""
        Me.txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 14)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "commission Amt"
        '
        'cmbLocation
        '
        Appearance2.FontData.Name = "Verdana"
        Appearance2.FontData.SizeInPoints = 8.0!
        Me.cmbLocation.Appearance = Appearance2
        Me.cmbLocation.AutoComplete = True
        Me.cmbLocation.AutoSize = False
        Me.cmbLocation.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbLocation.FlatMode = True
        Me.cmbLocation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.Location = New System.Drawing.Point(537, 81)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(134, 21)
        Me.cmbLocation.TabIndex = 47
        Me.cmbLocation.Tag = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(488, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Location"
        '
        'chkBarcode
        '
        Me.chkBarcode.Location = New System.Drawing.Point(13, 7)
        Me.chkBarcode.Name = "chkBarcode"
        Me.chkBarcode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chkBarcode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBarcode.Properties.Appearance.Options.UseBackColor = True
        Me.chkBarcode.Properties.Appearance.Options.UseFont = True
        Me.chkBarcode.Properties.Caption = "Barcode"
        Me.chkBarcode.Size = New System.Drawing.Size(68, 19)
        Me.chkBarcode.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Blue
        Me.btnSearch.Location = New System.Drawing.Point(885, 81)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(71, 24)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Searc&h"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Brown
        Me.Label13.Location = New System.Drawing.Point(674, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Barcode No"
        '
        'txtTakaNo
        '
        Me.txtTakaNo.BackColor = System.Drawing.Color.White
        Me.txtTakaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTakaNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTakaNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTakaNo.Location = New System.Drawing.Point(756, 83)
        Me.txtTakaNo.MaxLength = 20
        Me.txtTakaNo.Name = "txtTakaNo"
        Me.txtTakaNo.Size = New System.Drawing.Size(128, 21)
        Me.txtTakaNo.TabIndex = 16
        Me.txtTakaNo.Tag = "Code"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Brown
        Me.btnClear.Location = New System.Drawing.Point(425, 81)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 24)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtQty
        '
        Me.txtQty.AllowAlphabets = False
        Me.txtQty.AllowMoveToNextControl = False
        Me.txtQty.BackColor = System.Drawing.Color.MistyRose
        Me.txtQty.EditValue = 0
        Me.txtQty.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(254, 82)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(70, 22)
        Me.txtQty.TabIndex = 13
        Me.txtQty.Tag = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Brown
        Me.Label6.Location = New System.Drawing.Point(13, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Tag = ""
        Me.Label6.Text = "Show Stock is greater or equal (>=)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Brown
        Me.Label8.Location = New System.Drawing.Point(323, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Qty"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.Control
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Brown
        Me.btnShow.Location = New System.Drawing.Point(364, 81)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(60, 24)
        Me.btnShow.TabIndex = 14
        Me.btnShow.Text = "Sho&w"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'cmbSize
        '
        Appearance3.FontData.Name = "Verdana"
        Appearance3.FontData.SizeInPoints = 8.0!
        Me.cmbSize.Appearance = Appearance3
        Me.cmbSize.AutoComplete = True
        Me.cmbSize.AutoSize = False
        Me.cmbSize.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbSize.FlatMode = True
        Me.cmbSize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSize.Location = New System.Drawing.Point(774, 30)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(97, 21)
        Me.cmbSize.TabIndex = 11
        Me.cmbSize.Tag = "Sub-Group"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(735, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Shade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 14)
        Me.Label3.TabIndex = 45
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.SystemColors.Window
        Me.txtBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarcode.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(81, 5)
        Me.txtBarcode.MaxLength = 20
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(140, 22)
        Me.txtBarcode.TabIndex = 1
        Me.txtBarcode.Tag = "Barcode"
        '
        'lblArticleNo
        '
        Me.lblArticleNo.AutoSize = True
        Me.lblArticleNo.BackColor = System.Drawing.Color.Transparent
        Me.lblArticleNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticleNo.Location = New System.Drawing.Point(13, 33)
        Me.lblArticleNo.Name = "lblArticleNo"
        Me.lblArticleNo.Size = New System.Drawing.Size(45, 14)
        Me.lblArticleNo.TabIndex = 6
        Me.lblArticleNo.Text = "Design"
        '
        'cmbBrand
        '
        Appearance4.FontData.Name = "Verdana"
        Appearance4.FontData.SizeInPoints = 8.0!
        Me.cmbBrand.Appearance = Appearance4
        Me.cmbBrand.AutoComplete = True
        Me.cmbBrand.AutoSize = False
        Me.cmbBrand.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbBrand.FlatMode = True
        Me.cmbBrand.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrand.Location = New System.Drawing.Point(774, 6)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(182, 21)
        Me.cmbBrand.TabIndex = 5
        Me.cmbBrand.Tag = "Product"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(735, 9)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(39, 14)
        Me.lblBrand.TabIndex = 4
        Me.lblBrand.Text = "Brand"
        '
        'cmbItmSubGroup
        '
        Appearance5.FontData.Name = "Verdana"
        Appearance5.FontData.SizeInPoints = 8.0!
        Me.cmbItmSubGroup.Appearance = Appearance5
        Me.cmbItmSubGroup.AutoComplete = True
        Me.cmbItmSubGroup.AutoSize = False
        Me.cmbItmSubGroup.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbItmSubGroup.FlatMode = True
        Me.cmbItmSubGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItmSubGroup.Location = New System.Drawing.Point(291, 6)
        Me.cmbItmSubGroup.Name = "cmbItmSubGroup"
        Me.cmbItmSubGroup.Size = New System.Drawing.Size(160, 21)
        Me.cmbItmSubGroup.TabIndex = 2
        Me.cmbItmSubGroup.Tag = "Sub-Group"
        '
        'txtBillPurRate
        '
        Me.txtBillPurRate.AllowAlphabets = False
        Me.txtBillPurRate.AllowMoveToNextControl = True
        Me.txtBillPurRate.EditValue = 0
        Me.txtBillPurRate.Location = New System.Drawing.Point(137, 592)
        Me.txtBillPurRate.Name = "txtBillPurRate"
        Me.txtBillPurRate.Size = New System.Drawing.Size(10, 20)
        Me.txtBillPurRate.TabIndex = 56
        Me.txtBillPurRate.Tag = "Bill Purchase Rate"
        Me.txtBillPurRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBillPurRate.Visible = False
        '
        'txtBillSaleRate
        '
        Me.txtBillSaleRate.AllowAlphabets = False
        Me.txtBillSaleRate.AllowMoveToNextControl = True
        Me.txtBillSaleRate.EditValue = 0
        Me.txtBillSaleRate.Location = New System.Drawing.Point(162, 594)
        Me.txtBillSaleRate.Name = "txtBillSaleRate"
        Me.txtBillSaleRate.Size = New System.Drawing.Size(17, 20)
        Me.txtBillSaleRate.TabIndex = 58
        Me.txtBillSaleRate.Tag = "Bill Sale Rate"
        Me.txtBillSaleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBillSaleRate.Visible = False
        '
        'Search
        '
        Me.Search.DisplaySearchRecords = False
        Me.Search.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(4, 5)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(959, 614)
        Me.Search.TabIndex = 11
        Me.Search.Visible = False
        '
        'lnkPrintBarcode
        '
        Me.lnkPrintBarcode.AutoSize = True
        Me.lnkPrintBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lnkPrintBarcode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkPrintBarcode.Location = New System.Drawing.Point(873, 595)
        Me.lnkPrintBarcode.Name = "lnkPrintBarcode"
        Me.lnkPrintBarcode.Size = New System.Drawing.Size(82, 15)
        Me.lnkPrintBarcode.TabIndex = 70
        Me.lnkPrintBarcode.TabStop = True
        Me.lnkPrintBarcode.Text = "Print Barcode"
        Me.lnkPrintBarcode.Visible = False
        '
        'grpPrnBarcode
        '
        Me.grpPrnBarcode.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrnBarcode.Appearance.Options.UseFont = True
        Me.grpPrnBarcode.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrnBarcode.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon
        Me.grpPrnBarcode.AppearanceCaption.Options.UseFont = True
        Me.grpPrnBarcode.AppearanceCaption.Options.UseForeColor = True
        Me.grpPrnBarcode.AppearanceCaption.Options.UseTextOptions = True
        Me.grpPrnBarcode.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpPrnBarcode.Controls.Add(Me.Label64)
        Me.grpPrnBarcode.Controls.Add(Me.Label65)
        Me.grpPrnBarcode.Controls.Add(Me.txtNoOfColumns)
        Me.grpPrnBarcode.Controls.Add(Me.txtBlankLines)
        Me.grpPrnBarcode.Controls.Add(Me.btnBarCdClose)
        Me.grpPrnBarcode.Controls.Add(Me.btnBarCdView)
        Me.grpPrnBarcode.Controls.Add(Me.btnBarCdPrint)
        Me.grpPrnBarcode.Controls.Add(Me.txtSrTo)
        Me.grpPrnBarcode.Controls.Add(Me.txtSrFrom)
        Me.grpPrnBarcode.Controls.Add(Me.Label63)
        Me.grpPrnBarcode.Controls.Add(Me.Label46)
        Me.grpPrnBarcode.Controls.Add(Me.cmbFormat)
        Me.grpPrnBarcode.Controls.Add(Me.Label32)
        Me.grpPrnBarcode.Location = New System.Drawing.Point(731, 466)
        Me.grpPrnBarcode.LookAndFeel.SkinName = "Caramel"
        Me.grpPrnBarcode.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpPrnBarcode.Name = "grpPrnBarcode"
        Me.grpPrnBarcode.Size = New System.Drawing.Size(232, 146)
        Me.grpPrnBarcode.TabIndex = 71
        Me.grpPrnBarcode.Text = "Barcode Print Options"
        Me.grpPrnBarcode.Visible = False
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(140, 89)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(54, 14)
        Me.Label64.TabIndex = 8
        Me.Label64.Text = "Columns"
        Me.Label64.Visible = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(7, 89)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(82, 14)
        Me.Label65.TabIndex = 6
        Me.Label65.Text = "Blank Column"
        '
        'txtNoOfColumns
        '
        Me.txtNoOfColumns.EditValue = "0"
        Me.txtNoOfColumns.EnterMoveNextControl = True
        Me.txtNoOfColumns.Location = New System.Drawing.Point(201, 86)
        Me.txtNoOfColumns.Name = "txtNoOfColumns"
        Me.txtNoOfColumns.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfColumns.Properties.Appearance.Options.UseFont = True
        Me.txtNoOfColumns.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNoOfColumns.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNoOfColumns.Size = New System.Drawing.Size(21, 21)
        Me.txtNoOfColumns.TabIndex = 9
        Me.txtNoOfColumns.Tag = "MRP"
        Me.txtNoOfColumns.Visible = False
        '
        'txtBlankLines
        '
        Me.txtBlankLines.EditValue = "0"
        Me.txtBlankLines.EnterMoveNextControl = True
        Me.txtBlankLines.Location = New System.Drawing.Point(89, 86)
        Me.txtBlankLines.Name = "txtBlankLines"
        Me.txtBlankLines.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlankLines.Properties.Appearance.Options.UseFont = True
        Me.txtBlankLines.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBlankLines.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBlankLines.Size = New System.Drawing.Size(21, 21)
        Me.txtBlankLines.TabIndex = 7
        Me.txtBlankLines.Tag = "Blank Line"
        '
        'btnBarCdClose
        '
        Me.btnBarCdClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarCdClose.Appearance.Options.UseFont = True
        Me.btnBarCdClose.Location = New System.Drawing.Point(155, 116)
        Me.btnBarCdClose.LookAndFeel.SkinName = "Money Twins"
        Me.btnBarCdClose.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBarCdClose.Name = "btnBarCdClose"
        Me.btnBarCdClose.Size = New System.Drawing.Size(51, 23)
        Me.btnBarCdClose.TabIndex = 12
        Me.btnBarCdClose.Text = "Close"
        '
        'btnBarCdView
        '
        Me.btnBarCdView.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarCdView.Appearance.Options.UseFont = True
        Me.btnBarCdView.Location = New System.Drawing.Point(21, 116)
        Me.btnBarCdView.LookAndFeel.SkinName = "Money Twins"
        Me.btnBarCdView.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBarCdView.Name = "btnBarCdView"
        Me.btnBarCdView.Size = New System.Drawing.Size(51, 23)
        Me.btnBarCdView.TabIndex = 10
        Me.btnBarCdView.Text = "View"
        '
        'btnBarCdPrint
        '
        Me.btnBarCdPrint.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarCdPrint.Appearance.Options.UseFont = True
        Me.btnBarCdPrint.Location = New System.Drawing.Point(88, 116)
        Me.btnBarCdPrint.LookAndFeel.SkinName = "Money Twins"
        Me.btnBarCdPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBarCdPrint.Name = "btnBarCdPrint"
        Me.btnBarCdPrint.Size = New System.Drawing.Size(51, 23)
        Me.btnBarCdPrint.TabIndex = 11
        Me.btnBarCdPrint.Text = "Print"
        '
        'txtSrTo
        '
        Me.txtSrTo.EnterMoveNextControl = True
        Me.txtSrTo.Location = New System.Drawing.Point(180, 57)
        Me.txtSrTo.Name = "txtSrTo"
        Me.txtSrTo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrTo.Properties.Appearance.Options.UseFont = True
        Me.txtSrTo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSrTo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSrTo.Properties.Mask.EditMask = "f0"
        Me.txtSrTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSrTo.Size = New System.Drawing.Size(42, 21)
        Me.txtSrTo.TabIndex = 5
        Me.txtSrTo.Tag = "To Sr No"
        '
        'txtSrFrom
        '
        Me.txtSrFrom.EnterMoveNextControl = True
        Me.txtSrFrom.Location = New System.Drawing.Point(68, 57)
        Me.txtSrFrom.Name = "txtSrFrom"
        Me.txtSrFrom.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrFrom.Properties.Appearance.Options.UseFont = True
        Me.txtSrFrom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSrFrom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSrFrom.Properties.Mask.EditMask = "f0"
        Me.txtSrFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSrFrom.Size = New System.Drawing.Size(42, 21)
        Me.txtSrFrom.TabIndex = 3
        Me.txtSrFrom.Tag = "From Sr No"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(140, 60)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(32, 14)
        Me.Label63.TabIndex = 4
        Me.Label63.Text = "Sr To"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(7, 60)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(47, 14)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Sr From"
        '
        'cmbFormat
        '
        Me.cmbFormat.EnterMoveNextControl = True
        Me.cmbFormat.Location = New System.Drawing.Point(68, 31)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormat.Properties.Appearance.Options.UseFont = True
        Me.cmbFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbFormat.Size = New System.Drawing.Size(154, 21)
        Me.cmbFormat.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 34)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 14)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Format"
        '
        'BtnSave
        '
        Me.BtnSave.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Appearance.Options.UseFont = True
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(405, 578)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(77, 33)
        Me.BtnSave.TabIndex = 72
        Me.BtnSave.Text = "&Add"
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(486, 578)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 33)
        Me.btnClose.TabIndex = 73
        Me.btnClose.Text = "Cl&ose"
        '
        'imgButtonList
        '
        Me.imgButtonList.ImageStream = CType(resources.GetObject("imgButtonList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgButtonList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgButtonList.Images.SetKeyName(0, "Add-icon.png")
        Me.imgButtonList.Images.SetKeyName(1, "edit-icon.png")
        Me.imgButtonList.Images.SetKeyName(2, "Floppy-red-icon.png")
        Me.imgButtonList.Images.SetKeyName(3, "cancel-icon.png")
        Me.imgButtonList.Images.SetKeyName(4, "Sign-Shutdown-icon.png")
        '
        'cmbProduct
        '
        Me.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProduct.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(509, 6)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(213, 21)
        Me.cmbProduct.TabIndex = 3
        Me.cmbProduct.Tag = "Product"
        '
        'cmbStyle
        '
        Me.cmbStyle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStyle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStyle.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Location = New System.Drawing.Point(80, 30)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(141, 21)
        Me.cmbStyle.TabIndex = 7
        Me.cmbStyle.Tag = "Style"
        '
        'cmbShade
        '
        Me.cmbShade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbShade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbShade.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cmbShade.FormattingEnabled = True
        Me.cmbShade.Location = New System.Drawing.Point(509, 30)
        Me.cmbShade.Name = "cmbShade"
        Me.cmbShade.Size = New System.Drawing.Size(213, 21)
        Me.cmbShade.TabIndex = 10
        Me.cmbShade.Tag = "Shade"
        '
        'frmCommissionStockLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(969, 618)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lnkPrintBarcode)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.txtBillPurRate)
        Me.Controls.Add(Me.txtBillSaleRate)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.btnOccassion)
        Me.Controls.Add(Me.btnSeason)
        Me.Controls.Add(Me.btnQuality)
        Me.Controls.Add(Me.txtPurDocNo)
        Me.Controls.Add(Me.txtChlnNo)
        Me.Controls.Add(Me.dtpPurDocDt)
        Me.Controls.Add(Me.dtpChlnDate)
        Me.Controls.Add(Me.grpPrnBarcode)
        Me.Controls.Add(Me.grpSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(43, 50)
        Me.MaximizeBox = False
        Me.Name = "frmCommissionStockLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Item Wise Commission"
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        CType(Me.dtgSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.cmbLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbItmSubGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPrnBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrnBarcode.ResumeLayout(False)
        Me.grpPrnBarcode.PerformLayout()
        CType(Me.txtNoOfColumns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBlankLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSrTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSrFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgDetails As System.Windows.Forms.DataGrid
    Friend WithEvents btnSeason As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuality As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents Search As SearchWindow.SearchWindow
    Friend WithEvents grpSize As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSizeCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSizeConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtgSize As System.Windows.Forms.DataGrid
    Friend WithEvents lblTotSizeMinQty As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpPurDocDt As DateTimePick.DateTimePick
    Friend WithEvents txtChlnNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPurDocNo As System.Windows.Forms.TextBox
    Friend WithEvents btnOccassion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpChlnDate As DateTimePick.DateTimePick
    Friend WithEvents cmbItmSubGroup As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtBillSaleRate As NumericTextBox.NumericTextBox
    Friend WithEvents txtBillPurRate As NumericTextBox.NumericTextBox
    Friend WithEvents lnkPrintBarcode As System.Windows.Forms.LinkLabel
    Friend WithEvents grpPrnBarcode As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfColumns As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBlankLines As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBarCdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBarCdView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBarCdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSrTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSrFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cmbFormat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cmbBrand As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblArticleNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotSizeReOrderQty As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotSizeMaxQty As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSize As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTakaNo As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtQty As NumericTextBox.NumericTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkBarcode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents imgButtonList As System.Windows.Forms.ImageList
    Friend WithEvents cmbLocation As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCommission As NumericTextBox.NumericTextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents cmbShade As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStyle As System.Windows.Forms.ComboBox
End Class
