<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemWiseStockLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemWiseStockLevel))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.pnlDtlButtons = New System.Windows.Forms.Panel
        Me.btnDtlDelete = New DevExpress.XtraEditors.SimpleButton
        Me.btnDtlEdit = New DevExpress.XtraEditors.SimpleButton
        Me.btnDtlAdd = New DevExpress.XtraEditors.SimpleButton
        Me.dtgDetails = New System.Windows.Forms.DataGrid
        Me.grpDetails = New DevExpress.XtraEditors.GroupControl
        Me.lblStyleKey = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbDtlBrand = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbDtlStyle = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDtlType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSizeQty = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtReOrderLevel = New NumericTextBox.NumericTextBox
        Me.txtMaxLevel = New NumericTextBox.NumericTextBox
        Me.txtMinLevel = New NumericTextBox.NumericTextBox
        Me.cmbSize = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbShade = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.btnDtlCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSizeQty = New DevExpress.XtraEditors.SimpleButton
        Me.btnDtlSave = New DevExpress.XtraEditors.SimpleButton
        Me.txtImage = New System.Windows.Forms.TextBox
        Me.lblUnitKey = New System.Windows.Forms.Label
        Me.lblOpQty = New System.Windows.Forms.Label
        Me.lblSize = New System.Windows.Forms.Label
        Me.lblShade = New System.Windows.Forms.Label
        Me.cmbStyle = New Infragistics.Win.UltraWinEditors.UltraComboEditor
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
        Me.lblArticleNo = New System.Windows.Forms.Label
        Me.cmbBrand = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblBrand = New System.Windows.Forms.Label
        Me.cmbProduct = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbItmSubGroup = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.grpTotal = New DevExpress.XtraEditors.GroupControl
        Me.lblTotRecords = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.NavRecords = New Navigate.Navigate
        Me.FuncButtons = New FunctionButtons.FunctionButtons
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
        Me.pnlDtlButtons.SuspendLayout()
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetails.SuspendLayout()
        CType(Me.cmbDtlBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDtlStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDtlType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbShade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSize.SuspendLayout()
        CType(Me.dtgSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        CType(Me.cmbBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbItmSubGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotal.SuspendLayout()
        CType(Me.grpPrnBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrnBarcode.SuspendLayout()
        CType(Me.txtNoOfColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBlankLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDtlButtons
        '
        Me.pnlDtlButtons.Controls.Add(Me.btnDtlDelete)
        Me.pnlDtlButtons.Controls.Add(Me.btnDtlEdit)
        Me.pnlDtlButtons.Controls.Add(Me.btnDtlAdd)
        Me.pnlDtlButtons.Location = New System.Drawing.Point(4, 485)
        Me.pnlDtlButtons.Name = "pnlDtlButtons"
        Me.pnlDtlButtons.Size = New System.Drawing.Size(193, 28)
        Me.pnlDtlButtons.TabIndex = 2
        '
        'btnDtlDelete
        '
        Me.btnDtlDelete.Image = CType(resources.GetObject("btnDtlDelete.Image"), System.Drawing.Image)
        Me.btnDtlDelete.Location = New System.Drawing.Point(129, 3)
        Me.btnDtlDelete.Name = "btnDtlDelete"
        Me.btnDtlDelete.Size = New System.Drawing.Size(61, 23)
        Me.btnDtlDelete.TabIndex = 2
        Me.btnDtlDelete.Text = "Delete"
        '
        'btnDtlEdit
        '
        Me.btnDtlEdit.Image = CType(resources.GetObject("btnDtlEdit.Image"), System.Drawing.Image)
        Me.btnDtlEdit.Location = New System.Drawing.Point(66, 3)
        Me.btnDtlEdit.Name = "btnDtlEdit"
        Me.btnDtlEdit.Size = New System.Drawing.Size(61, 23)
        Me.btnDtlEdit.TabIndex = 1
        Me.btnDtlEdit.Text = "Edit"
        '
        'btnDtlAdd
        '
        Me.btnDtlAdd.Image = CType(resources.GetObject("btnDtlAdd.Image"), System.Drawing.Image)
        Me.btnDtlAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnDtlAdd.Name = "btnDtlAdd"
        Me.btnDtlAdd.Size = New System.Drawing.Size(61, 23)
        Me.btnDtlAdd.TabIndex = 0
        Me.btnDtlAdd.Text = "Add"
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
        Me.dtgDetails.Location = New System.Drawing.Point(4, 44)
        Me.dtgDetails.Name = "dtgDetails"
        Me.dtgDetails.Size = New System.Drawing.Size(964, 449)
        Me.dtgDetails.TabIndex = 1
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.lblStyleKey)
        Me.grpDetails.Controls.Add(Me.Label5)
        Me.grpDetails.Controls.Add(Me.cmbDtlBrand)
        Me.grpDetails.Controls.Add(Me.Label6)
        Me.grpDetails.Controls.Add(Me.cmbDtlStyle)
        Me.grpDetails.Controls.Add(Me.cmbDtlType)
        Me.grpDetails.Controls.Add(Me.Label8)
        Me.grpDetails.Controls.Add(Me.lblSizeQty)
        Me.grpDetails.Controls.Add(Me.Label4)
        Me.grpDetails.Controls.Add(Me.Label3)
        Me.grpDetails.Controls.Add(Me.txtReOrderLevel)
        Me.grpDetails.Controls.Add(Me.txtMaxLevel)
        Me.grpDetails.Controls.Add(Me.txtMinLevel)
        Me.grpDetails.Controls.Add(Me.cmbSize)
        Me.grpDetails.Controls.Add(Me.cmbShade)
        Me.grpDetails.Controls.Add(Me.btnDtlCancel)
        Me.grpDetails.Controls.Add(Me.btnSizeQty)
        Me.grpDetails.Controls.Add(Me.btnDtlSave)
        Me.grpDetails.Controls.Add(Me.txtImage)
        Me.grpDetails.Controls.Add(Me.lblUnitKey)
        Me.grpDetails.Controls.Add(Me.lblOpQty)
        Me.grpDetails.Controls.Add(Me.lblSize)
        Me.grpDetails.Controls.Add(Me.lblShade)
        Me.grpDetails.Location = New System.Drawing.Point(5, 513)
        Me.grpDetails.LookAndFeel.SkinName = "Caramel"
        Me.grpDetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.ShowCaption = False
        Me.grpDetails.Size = New System.Drawing.Size(959, 64)
        Me.grpDetails.TabIndex = 3
        Me.grpDetails.Text = "GroupControl2"
        '
        'lblStyleKey
        '
        Me.lblStyleKey.AutoSize = True
        Me.lblStyleKey.BackColor = System.Drawing.Color.Transparent
        Me.lblStyleKey.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStyleKey.Location = New System.Drawing.Point(702, 38)
        Me.lblStyleKey.Name = "lblStyleKey"
        Me.lblStyleKey.Size = New System.Drawing.Size(0, 14)
        Me.lblStyleKey.TabIndex = 530
        Me.lblStyleKey.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Design"
        '
        'cmbDtlBrand
        '
        Appearance1.FontData.Name = "Verdana"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.cmbDtlBrand.Appearance = Appearance1
        Me.cmbDtlBrand.AutoComplete = True
        Me.cmbDtlBrand.AutoSize = False
        Me.cmbDtlBrand.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbDtlBrand.FlatMode = True
        Me.cmbDtlBrand.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDtlBrand.Location = New System.Drawing.Point(570, 7)
        Me.cmbDtlBrand.Name = "cmbDtlBrand"
        Me.cmbDtlBrand.Size = New System.Drawing.Size(143, 21)
        Me.cmbDtlBrand.TabIndex = 5
        Me.cmbDtlBrand.Tag = "Product"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(513, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Brand"
        '
        'cmbDtlStyle
        '
        Appearance2.FontData.Name = "Verdana"
        Appearance2.FontData.SizeInPoints = 8.0!
        Me.cmbDtlStyle.Appearance = Appearance2
        Me.cmbDtlStyle.AutoComplete = True
        Me.cmbDtlStyle.AutoSize = False
        Me.cmbDtlStyle.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbDtlStyle.FlatMode = True
        Me.cmbDtlStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDtlStyle.Location = New System.Drawing.Point(50, 7)
        Me.cmbDtlStyle.Name = "cmbDtlStyle"
        Me.cmbDtlStyle.Size = New System.Drawing.Size(225, 21)
        Me.cmbDtlStyle.TabIndex = 1
        Me.cmbDtlStyle.Tag = "Style"
        '
        'cmbDtlType
        '
        Appearance3.FontData.Name = "Verdana"
        Appearance3.FontData.SizeInPoints = 8.0!
        Me.cmbDtlType.Appearance = Appearance3
        Me.cmbDtlType.AutoComplete = True
        Me.cmbDtlType.AutoSize = False
        Me.cmbDtlType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbDtlType.FlatMode = True
        Me.cmbDtlType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDtlType.Location = New System.Drawing.Point(332, 7)
        Me.cmbDtlType.Name = "cmbDtlType"
        Me.cmbDtlType.Size = New System.Drawing.Size(162, 21)
        Me.cmbDtlType.TabIndex = 3
        Me.cmbDtlType.Tag = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(298, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 14)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Type"
        '
        'lblSizeQty
        '
        Me.lblSizeQty.AutoSize = True
        Me.lblSizeQty.BackColor = System.Drawing.Color.Transparent
        Me.lblSizeQty.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSizeQty.Location = New System.Drawing.Point(473, 65)
        Me.lblSizeQty.Name = "lblSizeQty"
        Me.lblSizeQty.Size = New System.Drawing.Size(13, 14)
        Me.lblSizeQty.TabIndex = 355
        Me.lblSizeQty.Text = "0"
        Me.lblSizeQty.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(513, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Re-Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(399, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Max"
        '
        'txtReOrderLevel
        '
        Me.txtReOrderLevel.AllowAlphabets = False
        Me.txtReOrderLevel.AllowMoveToNextControl = False
        Me.txtReOrderLevel.EditValue = 0
        Me.txtReOrderLevel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReOrderLevel.Location = New System.Drawing.Point(573, 35)
        Me.txtReOrderLevel.Name = "txtReOrderLevel"
        Me.txtReOrderLevel.Size = New System.Drawing.Size(60, 22)
        Me.txtReOrderLevel.TabIndex = 16
        Me.txtReOrderLevel.Tag = "Re-Order Level"
        Me.txtReOrderLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaxLevel
        '
        Me.txtMaxLevel.AllowAlphabets = False
        Me.txtMaxLevel.AllowMoveToNextControl = False
        Me.txtMaxLevel.EditValue = 0
        Me.txtMaxLevel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxLevel.Location = New System.Drawing.Point(434, 35)
        Me.txtMaxLevel.Name = "txtMaxLevel"
        Me.txtMaxLevel.Size = New System.Drawing.Size(60, 22)
        Me.txtMaxLevel.TabIndex = 14
        Me.txtMaxLevel.Tag = "Maximum Level"
        Me.txtMaxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinLevel
        '
        Me.txtMinLevel.AllowAlphabets = False
        Me.txtMinLevel.AllowMoveToNextControl = False
        Me.txtMinLevel.EditValue = 0
        Me.txtMinLevel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinLevel.Location = New System.Drawing.Point(332, 35)
        Me.txtMinLevel.Name = "txtMinLevel"
        Me.txtMinLevel.Size = New System.Drawing.Size(62, 22)
        Me.txtMinLevel.TabIndex = 12
        Me.txtMinLevel.Tag = "Opening Qty"
        Me.txtMinLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbSize
        '
        Appearance4.FontData.Name = "Verdana"
        Appearance4.FontData.SizeInPoints = 8.0!
        Me.cmbSize.Appearance = Appearance4
        Me.cmbSize.AutoComplete = True
        Me.cmbSize.AutoSize = False
        Me.cmbSize.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbSize.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSize.FlatMode = True
        Me.cmbSize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSize.Location = New System.Drawing.Point(50, 36)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(88, 21)
        Me.cmbSize.TabIndex = 9
        Me.cmbSize.Tag = "Size"
        '
        'cmbShade
        '
        Appearance5.FontData.Name = "Verdana"
        Appearance5.FontData.SizeInPoints = 8.0!
        Me.cmbShade.Appearance = Appearance5
        Me.cmbShade.AutoComplete = True
        Me.cmbShade.AutoSize = False
        Me.cmbShade.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbShade.FlatMode = True
        Me.cmbShade.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShade.Location = New System.Drawing.Point(778, 7)
        Me.cmbShade.Name = "cmbShade"
        Me.cmbShade.Size = New System.Drawing.Size(175, 21)
        Me.cmbShade.TabIndex = 7
        Me.cmbShade.Tag = "Shade"
        '
        'btnDtlCancel
        '
        Me.btnDtlCancel.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDtlCancel.Appearance.Options.UseFont = True
        Me.btnDtlCancel.Image = CType(resources.GetObject("btnDtlCancel.Image"), System.Drawing.Image)
        Me.btnDtlCancel.Location = New System.Drawing.Point(873, 35)
        Me.btnDtlCancel.Name = "btnDtlCancel"
        Me.btnDtlCancel.Size = New System.Drawing.Size(81, 23)
        Me.btnDtlCancel.TabIndex = 18
        Me.btnDtlCancel.Text = "Cancel"
        '
        'btnSizeQty
        '
        Me.btnSizeQty.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSizeQty.Appearance.Options.UseFont = True
        Me.btnSizeQty.Location = New System.Drawing.Point(145, 35)
        Me.btnSizeQty.Name = "btnSizeQty"
        Me.btnSizeQty.Size = New System.Drawing.Size(65, 23)
        Me.btnSizeQty.TabIndex = 10
        Me.btnSizeQty.TabStop = False
        Me.btnSizeQty.Text = "Size Qty"
        '
        'btnDtlSave
        '
        Me.btnDtlSave.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDtlSave.Appearance.Options.UseFont = True
        Me.btnDtlSave.Image = CType(resources.GetObject("btnDtlSave.Image"), System.Drawing.Image)
        Me.btnDtlSave.Location = New System.Drawing.Point(785, 35)
        Me.btnDtlSave.Name = "btnDtlSave"
        Me.btnDtlSave.Size = New System.Drawing.Size(82, 23)
        Me.btnDtlSave.TabIndex = 17
        Me.btnDtlSave.Text = "Confirm"
        '
        'txtImage
        '
        Me.txtImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImage.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage.Location = New System.Drawing.Point(655, 210)
        Me.txtImage.MaxLength = 15
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(24, 22)
        Me.txtImage.TabIndex = 11
        Me.txtImage.TabStop = False
        Me.txtImage.Tag = "Image"
        Me.txtImage.Visible = False
        '
        'lblUnitKey
        '
        Me.lblUnitKey.BackColor = System.Drawing.Color.Transparent
        Me.lblUnitKey.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitKey.Location = New System.Drawing.Point(665, 80)
        Me.lblUnitKey.Name = "lblUnitKey"
        Me.lblUnitKey.Size = New System.Drawing.Size(32, 22)
        Me.lblUnitKey.TabIndex = 37
        '
        'lblOpQty
        '
        Me.lblOpQty.AutoSize = True
        Me.lblOpQty.BackColor = System.Drawing.Color.Transparent
        Me.lblOpQty.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpQty.ForeColor = System.Drawing.Color.Maroon
        Me.lblOpQty.Location = New System.Drawing.Point(298, 39)
        Me.lblOpQty.Name = "lblOpQty"
        Me.lblOpQty.Size = New System.Drawing.Size(28, 15)
        Me.lblOpQty.TabIndex = 11
        Me.lblOpQty.Text = "Min"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.BackColor = System.Drawing.Color.Transparent
        Me.lblSize.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(5, 39)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(29, 14)
        Me.lblSize.TabIndex = 8
        Me.lblSize.Text = "Size"
        '
        'lblShade
        '
        Me.lblShade.AutoSize = True
        Me.lblShade.BackColor = System.Drawing.Color.Transparent
        Me.lblShade.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShade.Location = New System.Drawing.Point(737, 10)
        Me.lblShade.Name = "lblShade"
        Me.lblShade.Size = New System.Drawing.Size(41, 14)
        Me.lblShade.TabIndex = 6
        Me.lblShade.Text = "Shade"
        '
        'cmbStyle
        '
        Appearance6.FontData.Name = "Verdana"
        Appearance6.FontData.SizeInPoints = 8.0!
        Me.cmbStyle.Appearance = Appearance6
        Me.cmbStyle.AutoComplete = True
        Me.cmbStyle.AutoSize = False
        Me.cmbStyle.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbStyle.FlatMode = True
        Me.cmbStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStyle.Location = New System.Drawing.Point(662, 9)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(164, 21)
        Me.cmbStyle.TabIndex = 7
        Me.cmbStyle.Tag = "Style"
        '
        'cmbType
        '
        Appearance7.FontData.Name = "Verdana"
        Appearance7.FontData.SizeInPoints = 8.0!
        Me.cmbType.Appearance = Appearance7
        Me.cmbType.AutoComplete = True
        Me.cmbType.AutoSize = False
        Me.cmbType.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbType.FlatMode = True
        Me.cmbType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.Location = New System.Drawing.Point(870, 9)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(91, 21)
        Me.cmbType.TabIndex = 9
        Me.cmbType.Tag = "Type"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(839, 12)
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
        Me.dtpChlnDate.Value = New Date(2016, 7, 22, 0, 0, 0, 0)
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
        Me.dtpPurDocDt.Value = New Date(2016, 7, 22, 0, 0, 0, 0)
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
        Me.lblSubGroup.Location = New System.Drawing.Point(4, 12)
        Me.lblSubGroup.Name = "lblSubGroup"
        Me.lblSubGroup.Size = New System.Drawing.Size(60, 14)
        Me.lblSubGroup.TabIndex = 0
        Me.lblSubGroup.Text = "SubGroup"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.BackColor = System.Drawing.Color.Transparent
        Me.lblProduct.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(218, 12)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(47, 14)
        Me.lblProduct.TabIndex = 2
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
        Me.grpMain.Controls.Add(Me.lblArticleNo)
        Me.grpMain.Controls.Add(Me.cmbBrand)
        Me.grpMain.Controls.Add(Me.lblBrand)
        Me.grpMain.Controls.Add(Me.cmbProduct)
        Me.grpMain.Controls.Add(Me.cmbItmSubGroup)
        Me.grpMain.Controls.Add(Me.lblProduct)
        Me.grpMain.Controls.Add(Me.lblSubGroup)
        Me.grpMain.Controls.Add(Me.cmbStyle)
        Me.grpMain.Controls.Add(Me.cmbType)
        Me.grpMain.Controls.Add(Me.lblType)
        Me.grpMain.Location = New System.Drawing.Point(3, 5)
        Me.grpMain.LookAndFeel.SkinName = "Caramel"
        Me.grpMain.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMain.Name = "grpMain"
        Me.grpMain.ShowCaption = False
        Me.grpMain.Size = New System.Drawing.Size(964, 40)
        Me.grpMain.TabIndex = 0
        '
        'lblArticleNo
        '
        Me.lblArticleNo.AutoSize = True
        Me.lblArticleNo.BackColor = System.Drawing.Color.Transparent
        Me.lblArticleNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticleNo.Location = New System.Drawing.Point(617, 12)
        Me.lblArticleNo.Name = "lblArticleNo"
        Me.lblArticleNo.Size = New System.Drawing.Size(45, 14)
        Me.lblArticleNo.TabIndex = 6
        Me.lblArticleNo.Text = "Design"
        '
        'cmbBrand
        '
        Appearance8.FontData.Name = "Verdana"
        Appearance8.FontData.SizeInPoints = 8.0!
        Me.cmbBrand.Appearance = Appearance8
        Me.cmbBrand.AutoComplete = True
        Me.cmbBrand.AutoSize = False
        Me.cmbBrand.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbBrand.FlatMode = True
        Me.cmbBrand.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrand.Location = New System.Drawing.Point(489, 9)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(118, 21)
        Me.cmbBrand.TabIndex = 5
        Me.cmbBrand.Tag = "Product"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(452, 12)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(39, 14)
        Me.lblBrand.TabIndex = 4
        Me.lblBrand.Text = "Brand"
        '
        'cmbProduct
        '
        Appearance9.FontData.Name = "Verdana"
        Appearance9.FontData.SizeInPoints = 8.0!
        Me.cmbProduct.Appearance = Appearance9
        Me.cmbProduct.AutoComplete = True
        Me.cmbProduct.AutoSize = False
        Me.cmbProduct.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbProduct.FlatMode = True
        Me.cmbProduct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.Location = New System.Drawing.Point(264, 9)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(171, 21)
        Me.cmbProduct.TabIndex = 3
        Me.cmbProduct.Tag = "Product"
        '
        'cmbItmSubGroup
        '
        Appearance10.FontData.Name = "Verdana"
        Appearance10.FontData.SizeInPoints = 8.0!
        Me.cmbItmSubGroup.Appearance = Appearance10
        Me.cmbItmSubGroup.AutoComplete = True
        Me.cmbItmSubGroup.AutoSize = False
        Me.cmbItmSubGroup.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoft
        Me.cmbItmSubGroup.FlatMode = True
        Me.cmbItmSubGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItmSubGroup.Location = New System.Drawing.Point(67, 9)
        Me.cmbItmSubGroup.Name = "cmbItmSubGroup"
        Me.cmbItmSubGroup.Size = New System.Drawing.Size(141, 21)
        Me.cmbItmSubGroup.TabIndex = 1
        Me.cmbItmSubGroup.Tag = "Sub-Group"
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.lblTotRecords)
        Me.grpTotal.Controls.Add(Me.Label7)
        Me.grpTotal.Location = New System.Drawing.Point(198, 485)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.ShowCaption = False
        Me.grpTotal.Size = New System.Drawing.Size(766, 28)
        Me.grpTotal.TabIndex = 43
        '
        'lblTotRecords
        '
        Me.lblTotRecords.BackColor = System.Drawing.Color.Transparent
        Me.lblTotRecords.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotRecords.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotRecords.Location = New System.Drawing.Point(678, 7)
        Me.lblTotRecords.Name = "lblTotRecords"
        Me.lblTotRecords.Size = New System.Drawing.Size(71, 15)
        Me.lblTotRecords.TabIndex = 62
        Me.lblTotRecords.Text = "0"
        Me.lblTotRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(588, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Total Records"
        '
        'NavRecords
        '
        Me.NavRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.NavRecords.Location = New System.Drawing.Point(202, 584)
        Me.NavRecords.Name = "NavRecords"
        Me.NavRecords.Size = New System.Drawing.Size(161, 31)
        Me.NavRecords.TabIndex = 5
        Me.NavRecords.Visible = False
        '
        'FuncButtons
        '
        Me.FuncButtons.ContinueToChangeImage = False
        Me.FuncButtons.DisplaySearchButton = True
        Me.FuncButtons.ExitButton = Nothing
        Me.FuncButtons.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncButtons.IsTransaction = False
        Me.FuncButtons.Location = New System.Drawing.Point(399, 583)
        Me.FuncButtons.Name = "FuncButtons"
        Me.FuncButtons.Size = New System.Drawing.Size(397, 33)
        Me.FuncButtons.TabIndex = 5
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
        Me.lnkPrintBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
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
        'frmItemWiseStockLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 618)
        Me.Controls.Add(Me.lnkPrintBarcode)
        Me.Controls.Add(Me.grpTotal)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.NavRecords)
        Me.Controls.Add(Me.FuncButtons)
        Me.Controls.Add(Me.txtBillPurRate)
        Me.Controls.Add(Me.txtBillSaleRate)
        Me.Controls.Add(Me.pnlDtlButtons)
        Me.Controls.Add(Me.dtgDetails)
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
        Me.Name = "frmItemWiseStockLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Item-Wise Stock Level"
        Me.pnlDtlButtons.ResumeLayout(False)
        CType(Me.dtgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        CType(Me.cmbDtlBrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDtlStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDtlType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbShade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        CType(Me.dtgSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.cmbBrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbItmSubGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
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
    Friend WithEvents pnlDtlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnDtlDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDtlEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDtlAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtgDetails As System.Windows.Forms.DataGrid
    Friend WithEvents grpDetails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnDtlCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDtlSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtImage As System.Windows.Forms.TextBox
    Friend WithEvents btnSeason As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuality As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblShade As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents NavRecords As Navigate.Navigate
    Friend WithEvents FuncButtons As FunctionButtons.FunctionButtons
    Friend WithEvents lblSubGroup As System.Windows.Forms.Label
    Friend WithEvents Search As SearchWindow.SearchWindow
    Friend WithEvents grpSize As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSizeCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSizeConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtgSize As System.Windows.Forms.DataGrid
    Friend WithEvents lblTotSizeMinQty As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnSizeQty As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpPurDocDt As DateTimePick.DateTimePick
    Friend WithEvents txtChlnNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPurDocNo As System.Windows.Forms.TextBox
    Friend WithEvents lblOpQty As System.Windows.Forms.Label
    Friend WithEvents grpTotal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblTotRecords As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnOccassion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpChlnDate As DateTimePick.DateTimePick
    Friend WithEvents cmbItmSubGroup As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbProduct As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbShade As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSize As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtMinLevel As NumericTextBox.NumericTextBox
    Friend WithEvents cmbStyle As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtBillSaleRate As NumericTextBox.NumericTextBox
    Friend WithEvents txtBillPurRate As NumericTextBox.NumericTextBox
    Friend WithEvents lblUnitKey As System.Windows.Forms.Label
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
    Friend WithEvents txtReOrderLevel As NumericTextBox.NumericTextBox
    Friend WithEvents txtMaxLevel As NumericTextBox.NumericTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSizeQty As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotSizeReOrderQty As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotSizeMaxQty As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDtlBrand As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDtlStyle As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDtlType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblStyleKey As System.Windows.Forms.Label
End Class
