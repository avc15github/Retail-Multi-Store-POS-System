<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysConfiguration
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

    Sub New(ByVal Allow As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AdminAccess = Allow
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.tabPgGeneral = New System.Windows.Forms.TabPage
        Me.pnlGeneral = New DevExpress.XtraEditors.PanelControl
        Me.grpAccounts = New DevExpress.XtraEditors.GroupControl
        Me.cmbDefTreatmentAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label9 = New System.Windows.Forms.Label
        Me.ChkMasssageOnPrint = New DevExpress.XtraEditors.CheckEdit
        Me.ChkAutoPrintonSaveReceiptVoucher = New DevExpress.XtraEditors.CheckEdit
        Me.cmbCashAc = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label43 = New System.Windows.Forms.Label
        Me.cmbDefSalesRdOffAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesOthChgsAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.cmbDefSalesDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.cmbDefSalesRtnRdOffAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesRtnOthChgsAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbDefSalesRtnDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesRtnAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbDefPurRtnRdOffAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefPurRtnDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefPurRtnAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbDefPurRdOffAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefPurDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefPurAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.chkMaintainBalBillByBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkMaintainCostCtr = New DevExpress.XtraEditors.CheckEdit
        Me.grpOthers = New DevExpress.XtraEditors.GroupControl
        Me.btnCopyBackUpPath = New DevExpress.XtraEditors.SimpleButton
        Me.txtCopyBackUp = New System.Windows.Forms.TextBox
        Me.chkCopyBackUp = New DevExpress.XtraEditors.CheckEdit
        Me.txtDelBackupDays = New NumericTextBox.NumericTextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.chkEmail = New DevExpress.XtraEditors.CheckEdit
        Me.chkSMS = New DevExpress.XtraEditors.CheckEdit
        Me.pnlEmailSettings = New DevExpress.XtraEditors.PanelControl
        Me.chkMaintAcc = New DevExpress.XtraEditors.CheckEdit
        Me.txtEmailPassword = New System.Windows.Forms.TextBox
        Me.txtEmailSenderName = New System.Windows.Forms.TextBox
        Me.txtEmailUser = New System.Windows.Forms.TextBox
        Me.pnlSMSSettings = New DevExpress.XtraEditors.PanelControl
        Me.txtSMSPassword1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSMSUser1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSMSCompany = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtSMSPassword = New System.Windows.Forms.TextBox
        Me.txtSMSUser = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtBackupPath = New System.Windows.Forms.TextBox
        Me.btnReportPath = New DevExpress.XtraEditors.SimpleButton
        Me.cmbCalculateStockOn = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txtReportpath = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.btnProdImagePath = New DevExpress.XtraEditors.SimpleButton
        Me.cmbAutoBackupOptions = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtProdImgPath = New System.Windows.Forms.TextBox
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.chkAutoBackup = New DevExpress.XtraEditors.CheckEdit
        Me.chkDisplayImage = New DevExpress.XtraEditors.CheckEdit
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.grpCompanyInfo = New DevExpress.XtraEditors.GroupControl
        Me.txtBarcodeInfo2 = New System.Windows.Forms.TextBox
        Me.txtBarcodeInfo1 = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.chkUseMultiSalesperson = New DevExpress.XtraEditors.CheckEdit
        Me.cmbDefPriceLevel = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSystemSeries = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDecInQty = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefStation = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblDefSalesperson = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.cmbDefSalesperson = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtTerms = New System.Windows.Forms.TextBox
        Me.txtAddressOnBarcode = New System.Windows.Forms.TextBox
        Me.chkCRM = New DevExpress.XtraEditors.CheckEdit
        Me.chkBarcodeInfo2 = New DevExpress.XtraEditors.CheckEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.grpMaintainStock = New DevExpress.XtraEditors.GroupControl
        Me.Label50 = New System.Windows.Forms.Label
        Me.chkUseBarcode = New DevExpress.XtraEditors.CheckEdit
        Me.chkMaintainStk = New DevExpress.XtraEditors.CheckEdit
        Me.chkAllowNegativeStk = New DevExpress.XtraEditors.CheckEdit
        Me.cmbBarcodeSeries = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbBarcode = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label51 = New System.Windows.Forms.Label
        Me.grpApplyForProduct = New DevExpress.XtraEditors.GroupControl
        Me.chksup_design = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseOccassion = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseSeason = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseQuality = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseSize = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseShade = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseDesign = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseBrand = New DevExpress.XtraEditors.CheckEdit
        Me.lblApplyProduct = New System.Windows.Forms.Label
        Me.chkProdSeriesTwoDigitPrefix = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseTypeNo = New DevExpress.XtraEditors.CheckEdit
        Me.tabPgTrans = New System.Windows.Forms.TabPage
        Me.grpSales = New DevExpress.XtraEditors.GroupControl
        Me.PnlListOptions = New System.Windows.Forms.Panel
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnMinQtyDown = New DevExpress.XtraEditors.SimpleButton
        Me.BtnMinQtyUp = New DevExpress.XtraEditors.SimpleButton
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton
        Me.Label15 = New System.Windows.Forms.Label
        Me.QrCodePanel = New System.Windows.Forms.Panel
        Me.btnDelAllQr = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveQr = New DevExpress.XtraEditors.SimpleButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ListQrTo = New System.Windows.Forms.ListBox
        Me.btnMoveQrTo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnDelQr = New DevExpress.XtraEditors.SimpleButton
        Me.ListQrFrom = New System.Windows.Forms.ListBox
        Me.btnCloseQr = New DevExpress.XtraEditors.SimpleButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.lnkQRcodeSeq = New System.Windows.Forms.LinkLabel
        Me.PanelGrid = New System.Windows.Forms.Panel
        Me.btnDeleteAllGrid = New DevExpress.XtraEditors.SimpleButton
        Me.btnGridSave = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ListBoxTo = New System.Windows.Forms.ListBox
        Me.btnMoveTo = New DevExpress.XtraEditors.SimpleButton
        Me.btnDeleteGrid = New DevExpress.XtraEditors.SimpleButton
        Me.ListBoxFrom = New System.Windows.Forms.ListBox
        Me.btnCloseGrid = New DevExpress.XtraEditors.SimpleButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.lnkSaleGrid = New System.Windows.Forms.LinkLabel
        Me.lnkMinQty = New System.Windows.Forms.LinkLabel
        Me.cmbDefSalesCust = New System.Windows.Forms.ComboBox
        Me.lnkseqproduct = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalNoOfEdit = New NumericTextBox.NumericTextBox
        Me.chkAllowfocusonBillDiscount = New DevExpress.XtraEditors.CheckEdit
        Me.chkAllowBackDateBillDelete = New DevExpress.XtraEditors.CheckEdit
        Me.chkAllowBackDateBillEdit = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesUseSalesOrderinBill = New DevExpress.XtraEditors.CheckEdit
        Me.txtSalesEmailid = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.chkSalesAutoEmailOnBill = New DevExpress.XtraEditors.CheckEdit
        Me.cmbFocusOn = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label69 = New System.Windows.Forms.Label
        Me.chkSalesDisplayLastBillDetails = New DevExpress.XtraEditors.CheckEdit
        Me.txtSalesPageSize = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.txtSalesPrinterName = New System.Windows.Forms.TextBox
        Me.lblPrinterName = New System.Windows.Forms.Label
        Me.txtTimingFrom = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.txtMessageOnBill = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.txtSalesNoOfCopiesToPrint = New NumericTextBox.NumericTextBox
        Me.txtSalesNoOfItemsOnBill = New NumericTextBox.NumericTextBox
        Me.txtInvoiceHeadOnPrint = New System.Windows.Forms.TextBox
        Me.chkSalesAllowBackDtBillCreation = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesMsgOnAutoSMS = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesMsgOnAutoPrint = New DevExpress.XtraEditors.CheckEdit
        Me.cmbSalesDefPayMode = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSalesAllowBillDelete = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSalesAllowBillUpdate = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesCardDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkSalesPrnOnSave = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesMergeDupBarcode = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRestrictBillChgAfterPrint = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesLockBillDiscount = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesLockSalesRt = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAutoSMSBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAskForBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesExchAgainstBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAllowBkDtBillPrn = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.pnlSelectOption = New System.Windows.Forms.Panel
        Me.txtKeyword = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lstOption1 = New System.Windows.Forms.ListBox
        Me.btnGrp1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnDown = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelGrp1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnUp = New DevExpress.XtraEditors.SimpleButton
        Me.lstMain = New System.Windows.Forms.ListBox
        Me.btnCloseOption = New DevExpress.XtraEditors.SimpleButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.grpWholeSaleBill = New DevExpress.XtraEditors.GroupControl
        Me.txtInvoiceHeadingWithoutVATNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtInvoiceHeadingForVATNo = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.grpPurchaseRtn = New DevExpress.XtraEditors.GroupControl
        Me.chkPurRtnSupplierSpecificPurRtn = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurRtnAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.grpPurchase = New DevExpress.XtraEditors.GroupControl
        Me.chkPMessageOnPrintBarcode = New DevExpress.XtraEditors.CheckEdit
        Me.chkAutoBarcodePrintonSave = New DevExpress.XtraEditors.CheckEdit
        Me.txtPurBarcodePrinterName = New System.Windows.Forms.TextBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.txtPurBarcodePageSize = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.chkPurPickLastPurRate = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurAllowZeroValue = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.grpSalesRtn = New DevExpress.XtraEditors.GroupControl
        Me.Label61 = New System.Windows.Forms.Label
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn = New NumericTextBox.NumericTextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.cmbDefSalesRtnCardDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesRtnCust = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkSalesRtnMsgOnAutoPrint = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnPrnOnSave = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnAllowRtnWOSales = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.rdWholeSaleBill = New System.Windows.Forms.RadioButton
        Me.rdSalesRtn = New System.Windows.Forms.RadioButton
        Me.rdSales = New System.Windows.Forms.RadioButton
        Me.rdPurchaseRtn = New System.Windows.Forms.RadioButton
        Me.rdPurchase = New System.Windows.Forms.RadioButton
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.tabMain.SuspendLayout()
        Me.tabPgGeneral.SuspendLayout()
        CType(Me.pnlGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGeneral.SuspendLayout()
        CType(Me.grpAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAccounts.SuspendLayout()
        CType(Me.cmbDefTreatmentAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMasssageOnPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAutoPrintonSaveReceiptVoucher.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCashAc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRdOffAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesOthChgsAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRtnRdOffAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRtnOthChgsAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRtnDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRtnAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPurRtnRdOffAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPurRtnDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPurRtnAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPurRdOffAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPurDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPurAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaintainBalBillByBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaintainCostCtr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOthers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOthers.SuspendLayout()
        CType(Me.chkCopyBackUp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlEmailSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmailSettings.SuspendLayout()
        CType(Me.chkMaintAcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlSMSSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSMSSettings.SuspendLayout()
        CType(Me.cmbCalculateStockOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAutoBackupOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoBackup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisplayImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCompanyInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCompanyInfo.SuspendLayout()
        CType(Me.chkUseMultiSalesperson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPriceLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSystemSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDecInQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefStation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesperson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBarcodeInfo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMaintainStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaintainStock.SuspendLayout()
        CType(Me.chkUseBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaintainStk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllowNegativeStk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBarcodeSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpApplyForProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApplyForProduct.SuspendLayout()
        CType(Me.chksup_design.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseOccassion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseSeason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseQuality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseShade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseDesign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProdSeriesTwoDigitPrefix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseTypeNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPgTrans.SuspendLayout()
        CType(Me.grpSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSales.SuspendLayout()
        Me.PnlListOptions.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.QrCodePanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.chkAllowfocusonBillDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllowBackDateBillDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllowBackDateBillEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesUseSalesOrderinBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAutoEmailOnBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFocusOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesDisplayLastBillDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAllowBackDtBillCreation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesMsgOnAutoSMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesDefPayMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesAllowBillDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesAllowBillUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesCardDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesMergeDupBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRestrictBillChgAfterPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesLockBillDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesLockSalesRt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAutoSMSBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAskForBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesExchAgainstBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAllowBkDtBillPrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOptions.SuspendLayout()
        Me.pnlSelectOption.SuspendLayout()
        CType(Me.grpWholeSaleBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWholeSaleBill.SuspendLayout()
        CType(Me.grpPurchaseRtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPurchaseRtn.SuspendLayout()
        CType(Me.chkPurRtnSupplierSpecificPurRtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPurchase.SuspendLayout()
        CType(Me.chkPMessageOnPrintBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoBarcodePrintonSave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurPickLastPurRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurAllowZeroValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSalesRtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalesRtn.SuspendLayout()
        CType(Me.cmbDefSalesRtnCardDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRtnCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnAllowRtnWOSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabPgGeneral)
        Me.tabMain.Controls.Add(Me.tabPgTrans)
        Me.tabMain.Location = New System.Drawing.Point(-2, 10)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(790, 568)
        Me.tabMain.TabIndex = 0
        '
        'tabPgGeneral
        '
        Me.tabPgGeneral.Controls.Add(Me.pnlGeneral)
        Me.tabPgGeneral.Location = New System.Drawing.Point(4, 23)
        Me.tabPgGeneral.Name = "tabPgGeneral"
        Me.tabPgGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPgGeneral.Size = New System.Drawing.Size(782, 541)
        Me.tabPgGeneral.TabIndex = 0
        Me.tabPgGeneral.Text = "General"
        Me.tabPgGeneral.UseVisualStyleBackColor = True
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Appearance.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnlGeneral.Appearance.Options.UseBackColor = True
        Me.pnlGeneral.Controls.Add(Me.grpAccounts)
        Me.pnlGeneral.Controls.Add(Me.grpOthers)
        Me.pnlGeneral.Controls.Add(Me.grpCompanyInfo)
        Me.pnlGeneral.Controls.Add(Me.grpMaintainStock)
        Me.pnlGeneral.Controls.Add(Me.grpApplyForProduct)
        Me.pnlGeneral.Location = New System.Drawing.Point(1, 2)
        Me.pnlGeneral.LookAndFeel.SkinName = "Blue"
        Me.pnlGeneral.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(778, 562)
        Me.pnlGeneral.TabIndex = 1
        '
        'grpAccounts
        '
        Me.grpAccounts.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpAccounts.Appearance.Options.UseBackColor = True
        Me.grpAccounts.Controls.Add(Me.cmbDefTreatmentAccount)
        Me.grpAccounts.Controls.Add(Me.Label9)
        Me.grpAccounts.Controls.Add(Me.ChkMasssageOnPrint)
        Me.grpAccounts.Controls.Add(Me.ChkAutoPrintonSaveReceiptVoucher)
        Me.grpAccounts.Controls.Add(Me.cmbCashAc)
        Me.grpAccounts.Controls.Add(Me.Label43)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesRdOffAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesOthChgsAccount)
        Me.grpAccounts.Controls.Add(Me.Label25)
        Me.grpAccounts.Controls.Add(Me.Label26)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesDiscAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesAccount)
        Me.grpAccounts.Controls.Add(Me.Label28)
        Me.grpAccounts.Controls.Add(Me.Label30)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesRtnRdOffAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesRtnOthChgsAccount)
        Me.grpAccounts.Controls.Add(Me.Label17)
        Me.grpAccounts.Controls.Add(Me.Label18)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesRtnDiscAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefSalesRtnAccount)
        Me.grpAccounts.Controls.Add(Me.Label20)
        Me.grpAccounts.Controls.Add(Me.Label21)
        Me.grpAccounts.Controls.Add(Me.cmbDefPurRtnRdOffAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefPurRtnDiscAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefPurRtnAccount)
        Me.grpAccounts.Controls.Add(Me.Label10)
        Me.grpAccounts.Controls.Add(Me.Label13)
        Me.grpAccounts.Controls.Add(Me.Label14)
        Me.grpAccounts.Controls.Add(Me.cmbDefPurRdOffAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefPurDiscAccount)
        Me.grpAccounts.Controls.Add(Me.cmbDefPurAccount)
        Me.grpAccounts.Controls.Add(Me.Label5)
        Me.grpAccounts.Controls.Add(Me.Label2)
        Me.grpAccounts.Controls.Add(Me.Label1)
        Me.grpAccounts.Controls.Add(Me.Label57)
        Me.grpAccounts.Controls.Add(Me.chkMaintainBalBillByBill)
        Me.grpAccounts.Controls.Add(Me.chkMaintainCostCtr)
        Me.grpAccounts.Location = New System.Drawing.Point(3, 406)
        Me.grpAccounts.LookAndFeel.SkinName = "Blue"
        Me.grpAccounts.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpAccounts.Name = "grpAccounts"
        Me.grpAccounts.ShowCaption = False
        Me.grpAccounts.Size = New System.Drawing.Size(770, 156)
        Me.grpAccounts.TabIndex = 58
        Me.grpAccounts.Text = "GroupControl4"
        '
        'cmbDefTreatmentAccount
        '
        Me.cmbDefTreatmentAccount.AutoComplete = True
        Me.cmbDefTreatmentAccount.DisplayMember = "Led_Name"
        Me.cmbDefTreatmentAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefTreatmentAccount.Location = New System.Drawing.Point(428, 5)
        Me.cmbDefTreatmentAccount.Name = "cmbDefTreatmentAccount"
        Me.cmbDefTreatmentAccount.Size = New System.Drawing.Size(121, 22)
        Me.cmbDefTreatmentAccount.TabIndex = 71
        Me.cmbDefTreatmentAccount.Tag = "Cash A/c"
        Me.cmbDefTreatmentAccount.ValueMember = "Led_Key"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(349, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Treatment  A/c"
        '
        'ChkMasssageOnPrint
        '
        Me.ChkMasssageOnPrint.Location = New System.Drawing.Point(214, 131)
        Me.ChkMasssageOnPrint.Name = "ChkMasssageOnPrint"
        Me.ChkMasssageOnPrint.Properties.Caption = "Masssage On Print"
        Me.ChkMasssageOnPrint.Size = New System.Drawing.Size(153, 19)
        Me.ChkMasssageOnPrint.TabIndex = 69
        '
        'ChkAutoPrintonSaveReceiptVoucher
        '
        Me.ChkAutoPrintonSaveReceiptVoucher.Location = New System.Drawing.Point(8, 131)
        Me.ChkAutoPrintonSaveReceiptVoucher.Name = "ChkAutoPrintonSaveReceiptVoucher"
        Me.ChkAutoPrintonSaveReceiptVoucher.Properties.Caption = "Auto Print on Save Receipt Voucher"
        Me.ChkAutoPrintonSaveReceiptVoucher.Size = New System.Drawing.Size(196, 19)
        Me.ChkAutoPrintonSaveReceiptVoucher.TabIndex = 68
        '
        'cmbCashAc
        '
        Me.cmbCashAc.AutoComplete = True
        Me.cmbCashAc.DisplayMember = "Led_Name"
        Me.cmbCashAc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCashAc.Location = New System.Drawing.Point(617, 5)
        Me.cmbCashAc.Name = "cmbCashAc"
        Me.cmbCashAc.Size = New System.Drawing.Size(152, 22)
        Me.cmbCashAc.TabIndex = 67
        Me.cmbCashAc.Tag = "Cash A/c"
        Me.cmbCashAc.ValueMember = "Led_Key"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(553, 8)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(50, 13)
        Me.Label43.TabIndex = 66
        Me.Label43.Text = "Cash A/c"
        '
        'cmbDefSalesRdOffAccount
        '
        Me.cmbDefSalesRdOffAccount.AutoComplete = True
        Me.cmbDefSalesRdOffAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesRdOffAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesRdOffAccount.Location = New System.Drawing.Point(664, 84)
        Me.cmbDefSalesRdOffAccount.Name = "cmbDefSalesRdOffAccount"
        Me.cmbDefSalesRdOffAccount.Size = New System.Drawing.Size(105, 22)
        Me.cmbDefSalesRdOffAccount.TabIndex = 65
        Me.cmbDefSalesRdOffAccount.ValueMember = "Led_Key"
        '
        'cmbDefSalesOthChgsAccount
        '
        Me.cmbDefSalesOthChgsAccount.AutoComplete = True
        Me.cmbDefSalesOthChgsAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesOthChgsAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesOthChgsAccount.Location = New System.Drawing.Point(487, 82)
        Me.cmbDefSalesOthChgsAccount.Name = "cmbDefSalesOthChgsAccount"
        Me.cmbDefSalesOthChgsAccount.Size = New System.Drawing.Size(103, 22)
        Me.cmbDefSalesOthChgsAccount.TabIndex = 64
        Me.cmbDefSalesOthChgsAccount.ValueMember = "Led_Key"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(601, 90)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Rd Off A/c"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(401, 85)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 13)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "Other Chgs A/c"
        '
        'cmbDefSalesDiscAccount
        '
        Me.cmbDefSalesDiscAccount.AutoComplete = True
        Me.cmbDefSalesDiscAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesDiscAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesDiscAccount.Location = New System.Drawing.Point(289, 83)
        Me.cmbDefSalesDiscAccount.Name = "cmbDefSalesDiscAccount"
        Me.cmbDefSalesDiscAccount.Size = New System.Drawing.Size(103, 22)
        Me.cmbDefSalesDiscAccount.TabIndex = 61
        Me.cmbDefSalesDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefSalesAccount
        '
        Me.cmbDefSalesAccount.AutoComplete = True
        Me.cmbDefSalesAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesAccount.Location = New System.Drawing.Point(83, 82)
        Me.cmbDefSalesAccount.Name = "cmbDefSalesAccount"
        Me.cmbDefSalesAccount.Size = New System.Drawing.Size(119, 22)
        Me.cmbDefSalesAccount.TabIndex = 60
        Me.cmbDefSalesAccount.ValueMember = "Led_Key"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(214, 86)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 13)
        Me.Label28.TabIndex = 58
        Me.Label28.Text = "Discount A/c"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 83)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(51, 13)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "Sales A/c"
        '
        'cmbDefSalesRtnRdOffAccount
        '
        Me.cmbDefSalesRtnRdOffAccount.AutoComplete = True
        Me.cmbDefSalesRtnRdOffAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesRtnRdOffAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesRtnRdOffAccount.Location = New System.Drawing.Point(664, 109)
        Me.cmbDefSalesRtnRdOffAccount.Name = "cmbDefSalesRtnRdOffAccount"
        Me.cmbDefSalesRtnRdOffAccount.Size = New System.Drawing.Size(105, 22)
        Me.cmbDefSalesRtnRdOffAccount.TabIndex = 57
        Me.cmbDefSalesRtnRdOffAccount.ValueMember = "Led_Key"
        '
        'cmbDefSalesRtnOthChgsAccount
        '
        Me.cmbDefSalesRtnOthChgsAccount.AutoComplete = True
        Me.cmbDefSalesRtnOthChgsAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesRtnOthChgsAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesRtnOthChgsAccount.Location = New System.Drawing.Point(487, 107)
        Me.cmbDefSalesRtnOthChgsAccount.Name = "cmbDefSalesRtnOthChgsAccount"
        Me.cmbDefSalesRtnOthChgsAccount.Size = New System.Drawing.Size(103, 22)
        Me.cmbDefSalesRtnOthChgsAccount.TabIndex = 56
        Me.cmbDefSalesRtnOthChgsAccount.ValueMember = "Led_Key"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(601, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Rd Off A/c"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(401, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Other Chgs A/c"
        '
        'cmbDefSalesRtnDiscAccount
        '
        Me.cmbDefSalesRtnDiscAccount.AutoComplete = True
        Me.cmbDefSalesRtnDiscAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesRtnDiscAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesRtnDiscAccount.Location = New System.Drawing.Point(289, 109)
        Me.cmbDefSalesRtnDiscAccount.Name = "cmbDefSalesRtnDiscAccount"
        Me.cmbDefSalesRtnDiscAccount.Size = New System.Drawing.Size(103, 22)
        Me.cmbDefSalesRtnDiscAccount.TabIndex = 53
        Me.cmbDefSalesRtnDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefSalesRtnAccount
        '
        Me.cmbDefSalesRtnAccount.AutoComplete = True
        Me.cmbDefSalesRtnAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesRtnAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesRtnAccount.Location = New System.Drawing.Point(83, 107)
        Me.cmbDefSalesRtnAccount.Name = "cmbDefSalesRtnAccount"
        Me.cmbDefSalesRtnAccount.Size = New System.Drawing.Size(119, 22)
        Me.cmbDefSalesRtnAccount.TabIndex = 52
        Me.cmbDefSalesRtnAccount.ValueMember = "Led_Key"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(214, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Discount A/c"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 107)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Sales Rtn A/c"
        '
        'cmbDefPurRtnRdOffAccount
        '
        Me.cmbDefPurRtnRdOffAccount.AutoComplete = True
        Me.cmbDefPurRtnRdOffAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurRtnRdOffAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurRtnRdOffAccount.Location = New System.Drawing.Point(617, 60)
        Me.cmbDefPurRtnRdOffAccount.Name = "cmbDefPurRtnRdOffAccount"
        Me.cmbDefPurRtnRdOffAccount.Size = New System.Drawing.Size(152, 22)
        Me.cmbDefPurRtnRdOffAccount.TabIndex = 49
        Me.cmbDefPurRtnRdOffAccount.ValueMember = "Led_Key"
        '
        'cmbDefPurRtnDiscAccount
        '
        Me.cmbDefPurRtnDiscAccount.AutoComplete = True
        Me.cmbDefPurRtnDiscAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurRtnDiscAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurRtnDiscAccount.Location = New System.Drawing.Point(354, 58)
        Me.cmbDefPurRtnDiscAccount.Name = "cmbDefPurRtnDiscAccount"
        Me.cmbDefPurRtnDiscAccount.Size = New System.Drawing.Size(164, 22)
        Me.cmbDefPurRtnDiscAccount.TabIndex = 48
        Me.cmbDefPurRtnDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefPurRtnAccount
        '
        Me.cmbDefPurRtnAccount.AutoComplete = True
        Me.cmbDefPurRtnAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurRtnAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurRtnAccount.Location = New System.Drawing.Point(83, 58)
        Me.cmbDefPurRtnAccount.Name = "cmbDefPurRtnAccount"
        Me.cmbDefPurRtnAccount.Size = New System.Drawing.Size(157, 22)
        Me.cmbDefPurRtnAccount.TabIndex = 47
        Me.cmbDefPurRtnAccount.ValueMember = "Led_Key"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(554, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Rd Off A/c"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Discount A/c"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Purch Rtn A/c"
        '
        'cmbDefPurRdOffAccount
        '
        Me.cmbDefPurRdOffAccount.AutoComplete = True
        Me.cmbDefPurRdOffAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurRdOffAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurRdOffAccount.Location = New System.Drawing.Point(617, 33)
        Me.cmbDefPurRdOffAccount.Name = "cmbDefPurRdOffAccount"
        Me.cmbDefPurRdOffAccount.Size = New System.Drawing.Size(152, 22)
        Me.cmbDefPurRdOffAccount.TabIndex = 43
        Me.cmbDefPurRdOffAccount.ValueMember = "Led_Key"
        '
        'cmbDefPurDiscAccount
        '
        Me.cmbDefPurDiscAccount.AutoComplete = True
        Me.cmbDefPurDiscAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurDiscAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurDiscAccount.Location = New System.Drawing.Point(354, 32)
        Me.cmbDefPurDiscAccount.Name = "cmbDefPurDiscAccount"
        Me.cmbDefPurDiscAccount.Size = New System.Drawing.Size(164, 22)
        Me.cmbDefPurDiscAccount.TabIndex = 42
        Me.cmbDefPurDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefPurAccount
        '
        Me.cmbDefPurAccount.AutoComplete = True
        Me.cmbDefPurAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurAccount.Location = New System.Drawing.Point(83, 33)
        Me.cmbDefPurAccount.Name = "cmbDefPurAccount"
        Me.cmbDefPurAccount.Size = New System.Drawing.Size(157, 22)
        Me.cmbDefPurAccount.TabIndex = 41
        Me.cmbDefPurAccount.ValueMember = "Led_Key"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(554, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Rd Off A/c"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Discount A/c"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Purchase A/c"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Maroon
        Me.Label57.Location = New System.Drawing.Point(3, 8)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(59, 13)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Accounts"
        '
        'chkMaintainBalBillByBill
        '
        Me.chkMaintainBalBillByBill.Location = New System.Drawing.Point(64, 5)
        Me.chkMaintainBalBillByBill.Name = "chkMaintainBalBillByBill"
        Me.chkMaintainBalBillByBill.Properties.Caption = "Maintain balance bill-by-bill"
        Me.chkMaintainBalBillByBill.Size = New System.Drawing.Size(153, 19)
        Me.chkMaintainBalBillByBill.TabIndex = 22
        Me.chkMaintainBalBillByBill.Visible = False
        '
        'chkMaintainCostCtr
        '
        Me.chkMaintainCostCtr.Location = New System.Drawing.Point(223, 5)
        Me.chkMaintainCostCtr.Name = "chkMaintainCostCtr"
        Me.chkMaintainCostCtr.Properties.Caption = "Maintain Cost Center"
        Me.chkMaintainCostCtr.Size = New System.Drawing.Size(133, 19)
        Me.chkMaintainCostCtr.TabIndex = 22
        Me.chkMaintainCostCtr.Visible = False
        '
        'grpOthers
        '
        Me.grpOthers.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpOthers.Appearance.Options.UseBackColor = True
        Me.grpOthers.Controls.Add(Me.btnCopyBackUpPath)
        Me.grpOthers.Controls.Add(Me.txtCopyBackUp)
        Me.grpOthers.Controls.Add(Me.chkCopyBackUp)
        Me.grpOthers.Controls.Add(Me.txtDelBackupDays)
        Me.grpOthers.Controls.Add(Me.Label54)
        Me.grpOthers.Controls.Add(Me.chkEmail)
        Me.grpOthers.Controls.Add(Me.chkSMS)
        Me.grpOthers.Controls.Add(Me.pnlEmailSettings)
        Me.grpOthers.Controls.Add(Me.pnlSMSSettings)
        Me.grpOthers.Controls.Add(Me.txtBackupPath)
        Me.grpOthers.Controls.Add(Me.btnReportPath)
        Me.grpOthers.Controls.Add(Me.cmbCalculateStockOn)
        Me.grpOthers.Controls.Add(Me.txtReportpath)
        Me.grpOthers.Controls.Add(Me.Label41)
        Me.grpOthers.Controls.Add(Me.btnProdImagePath)
        Me.grpOthers.Controls.Add(Me.cmbAutoBackupOptions)
        Me.grpOthers.Controls.Add(Me.Label37)
        Me.grpOthers.Controls.Add(Me.Label56)
        Me.grpOthers.Controls.Add(Me.txtProdImgPath)
        Me.grpOthers.Controls.Add(Me.btnBrowse)
        Me.grpOthers.Controls.Add(Me.chkAutoBackup)
        Me.grpOthers.Controls.Add(Me.chkDisplayImage)
        Me.grpOthers.Controls.Add(Me.Label36)
        Me.grpOthers.Controls.Add(Me.Label48)
        Me.grpOthers.Location = New System.Drawing.Point(3, 258)
        Me.grpOthers.LookAndFeel.SkinName = "Blue"
        Me.grpOthers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.ShowCaption = False
        Me.grpOthers.Size = New System.Drawing.Size(770, 147)
        Me.grpOthers.TabIndex = 57
        Me.grpOthers.Text = "GroupControl3"
        '
        'btnCopyBackUpPath
        '
        Me.btnCopyBackUpPath.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyBackUpPath.Appearance.Options.UseFont = True
        Me.btnCopyBackUpPath.Location = New System.Drawing.Point(341, 54)
        Me.btnCopyBackUpPath.Name = "btnCopyBackUpPath"
        Me.btnCopyBackUpPath.Size = New System.Drawing.Size(28, 23)
        Me.btnCopyBackUpPath.TabIndex = 64
        Me.btnCopyBackUpPath.Text = "..."
        '
        'txtCopyBackUp
        '
        Me.txtCopyBackUp.BackColor = System.Drawing.Color.White
        Me.txtCopyBackUp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopyBackUp.Location = New System.Drawing.Point(109, 54)
        Me.txtCopyBackUp.Name = "txtCopyBackUp"
        Me.txtCopyBackUp.ReadOnly = True
        Me.txtCopyBackUp.Size = New System.Drawing.Size(229, 21)
        Me.txtCopyBackUp.TabIndex = 62
        Me.txtCopyBackUp.Tag = "CopyBackUp"
        '
        'chkCopyBackUp
        '
        Me.chkCopyBackUp.Location = New System.Drawing.Point(0, 55)
        Me.chkCopyBackUp.Name = "chkCopyBackUp"
        Me.chkCopyBackUp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopyBackUp.Properties.Appearance.Options.UseFont = True
        Me.chkCopyBackUp.Properties.Caption = "Copy BackUp Path"
        Me.chkCopyBackUp.Size = New System.Drawing.Size(111, 19)
        Me.chkCopyBackUp.TabIndex = 63
        '
        'txtDelBackupDays
        '
        Me.txtDelBackupDays.AllowAlphabets = False
        Me.txtDelBackupDays.AllowMoveToNextControl = True
        Me.txtDelBackupDays.EditValue = 0
        Me.txtDelBackupDays.Location = New System.Drawing.Point(110, 76)
        Me.txtDelBackupDays.Name = "txtDelBackupDays"
        Me.txtDelBackupDays.Size = New System.Drawing.Size(28, 22)
        Me.txtDelBackupDays.TabIndex = 61
        Me.txtDelBackupDays.Tag = "Delete Backup After N Days"
        Me.txtDelBackupDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Maroon
        Me.Label54.Location = New System.Drawing.Point(3, 2)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(45, 13)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Others"
        '
        'chkEmail
        '
        Me.chkEmail.Location = New System.Drawing.Point(477, 24)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmail.Properties.Appearance.Options.UseFont = True
        Me.chkEmail.Properties.Caption = "Email feature"
        Me.chkEmail.Size = New System.Drawing.Size(86, 19)
        Me.chkEmail.TabIndex = 22
        '
        'chkSMS
        '
        Me.chkSMS.Location = New System.Drawing.Point(383, 25)
        Me.chkSMS.Name = "chkSMS"
        Me.chkSMS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSMS.Properties.Appearance.Options.UseFont = True
        Me.chkSMS.Properties.Caption = "SMS feature"
        Me.chkSMS.Size = New System.Drawing.Size(86, 19)
        Me.chkSMS.TabIndex = 22
        '
        'pnlEmailSettings
        '
        Me.pnlEmailSettings.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.pnlEmailSettings.Controls.Add(Me.chkMaintAcc)
        Me.pnlEmailSettings.Controls.Add(Me.txtEmailPassword)
        Me.pnlEmailSettings.Controls.Add(Me.txtEmailSenderName)
        Me.pnlEmailSettings.Controls.Add(Me.txtEmailUser)
        Me.pnlEmailSettings.Location = New System.Drawing.Point(383, 121)
        Me.pnlEmailSettings.LookAndFeel.SkinName = "Blue"
        Me.pnlEmailSettings.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlEmailSettings.Name = "pnlEmailSettings"
        Me.pnlEmailSettings.Size = New System.Drawing.Size(378, 25)
        Me.pnlEmailSettings.TabIndex = 25
        '
        'chkMaintAcc
        '
        Me.chkMaintAcc.Location = New System.Drawing.Point(251, 3)
        Me.chkMaintAcc.Name = "chkMaintAcc"
        Me.chkMaintAcc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaintAcc.Properties.Appearance.Options.UseFont = True
        Me.chkMaintAcc.Properties.Caption = "Maintain Accounts"
        Me.chkMaintAcc.Size = New System.Drawing.Size(119, 19)
        Me.chkMaintAcc.TabIndex = 41
        '
        'txtEmailPassword
        '
        Me.txtEmailPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailPassword.Location = New System.Drawing.Point(150, 31)
        Me.txtEmailPassword.Name = "txtEmailPassword"
        Me.txtEmailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmailPassword.Size = New System.Drawing.Size(17, 21)
        Me.txtEmailPassword.TabIndex = 1
        Me.txtEmailPassword.Tag = "Email Password"
        Me.txtEmailPassword.Visible = False
        '
        'txtEmailSenderName
        '
        Me.txtEmailSenderName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailSenderName.Location = New System.Drawing.Point(92, 27)
        Me.txtEmailSenderName.Name = "txtEmailSenderName"
        Me.txtEmailSenderName.Size = New System.Drawing.Size(17, 21)
        Me.txtEmailSenderName.TabIndex = 1
        Me.txtEmailSenderName.Tag = "Sender Name"
        Me.txtEmailSenderName.Visible = False
        '
        'txtEmailUser
        '
        Me.txtEmailUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailUser.Location = New System.Drawing.Point(115, 29)
        Me.txtEmailUser.Name = "txtEmailUser"
        Me.txtEmailUser.Size = New System.Drawing.Size(17, 21)
        Me.txtEmailUser.TabIndex = 1
        Me.txtEmailUser.Tag = "Email User"
        Me.txtEmailUser.Visible = False
        '
        'pnlSMSSettings
        '
        Me.pnlSMSSettings.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSPassword1)
        Me.pnlSMSSettings.Controls.Add(Me.Label8)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSUser1)
        Me.pnlSMSSettings.Controls.Add(Me.Label7)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSCompany)
        Me.pnlSMSSettings.Controls.Add(Me.Label38)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSPassword)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSUser)
        Me.pnlSMSSettings.Controls.Add(Me.Label47)
        Me.pnlSMSSettings.Controls.Add(Me.Label46)
        Me.pnlSMSSettings.Location = New System.Drawing.Point(383, 46)
        Me.pnlSMSSettings.LookAndFeel.SkinName = "Blue"
        Me.pnlSMSSettings.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlSMSSettings.Name = "pnlSMSSettings"
        Me.pnlSMSSettings.Size = New System.Drawing.Size(380, 73)
        Me.pnlSMSSettings.TabIndex = 25
        '
        'txtSMSPassword1
        '
        Me.txtSMSPassword1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMSPassword1.Location = New System.Drawing.Point(257, 51)
        Me.txtSMSPassword1.Name = "txtSMSPassword1"
        Me.txtSMSPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMSPassword1.Size = New System.Drawing.Size(118, 21)
        Me.txtSMSPassword1.TabIndex = 7
        Me.txtSMSPassword1.Tag = "SMS Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(178, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Password1"
        '
        'txtSMSUser1
        '
        Me.txtSMSUser1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMSUser1.Location = New System.Drawing.Point(54, 51)
        Me.txtSMSUser1.Name = "txtSMSUser1"
        Me.txtSMSUser1.Size = New System.Drawing.Size(118, 21)
        Me.txtSMSUser1.TabIndex = 5
        Me.txtSMSUser1.Tag = "SMS User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "User1"
        '
        'txtSMSCompany
        '
        Me.txtSMSCompany.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMSCompany.Location = New System.Drawing.Point(179, 27)
        Me.txtSMSCompany.MaxLength = 20
        Me.txtSMSCompany.Name = "txtSMSCompany"
        Me.txtSMSCompany.Size = New System.Drawing.Size(197, 21)
        Me.txtSMSCompany.TabIndex = 3
        Me.txtSMSCompany.Tag = "SMS Company"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(184, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(118, 13)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Company Name In SMS"
        '
        'txtSMSPassword
        '
        Me.txtSMSPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMSPassword.Location = New System.Drawing.Point(54, 27)
        Me.txtSMSPassword.Name = "txtSMSPassword"
        Me.txtSMSPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMSPassword.Size = New System.Drawing.Size(118, 21)
        Me.txtSMSPassword.TabIndex = 1
        Me.txtSMSPassword.Tag = "SMS Password"
        '
        'txtSMSUser
        '
        Me.txtSMSUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMSUser.Location = New System.Drawing.Point(54, 4)
        Me.txtSMSUser.Name = "txtSMSUser"
        Me.txtSMSUser.Size = New System.Drawing.Size(118, 21)
        Me.txtSMSUser.TabIndex = 1
        Me.txtSMSUser.Tag = "SMS User"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(2, 32)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(53, 13)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Password"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(2, 8)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(29, 13)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "User"
        '
        'txtBackupPath
        '
        Me.txtBackupPath.BackColor = System.Drawing.Color.White
        Me.txtBackupPath.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupPath.Location = New System.Drawing.Point(109, 8)
        Me.txtBackupPath.Name = "txtBackupPath"
        Me.txtBackupPath.ReadOnly = True
        Me.txtBackupPath.Size = New System.Drawing.Size(229, 21)
        Me.txtBackupPath.TabIndex = 1
        Me.txtBackupPath.Tag = "Backup Path"
        '
        'btnReportPath
        '
        Me.btnReportPath.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportPath.Appearance.Options.UseFont = True
        Me.btnReportPath.Location = New System.Drawing.Point(341, 30)
        Me.btnReportPath.Name = "btnReportPath"
        Me.btnReportPath.Size = New System.Drawing.Size(28, 23)
        Me.btnReportPath.TabIndex = 26
        Me.btnReportPath.Text = "..."
        '
        'cmbCalculateStockOn
        '
        Me.cmbCalculateStockOn.AutoComplete = True
        Me.cmbCalculateStockOn.DisplayMember = "Led_Name"
        Me.cmbCalculateStockOn.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbCalculateStockOn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCalculateStockOn.Location = New System.Drawing.Point(681, 4)
        Me.cmbCalculateStockOn.Name = "cmbCalculateStockOn"
        Me.cmbCalculateStockOn.Size = New System.Drawing.Size(84, 22)
        Me.cmbCalculateStockOn.TabIndex = 39
        Me.cmbCalculateStockOn.Tag = "Calculate Stock On"
        Me.cmbCalculateStockOn.ValueMember = "Led_Key"
        '
        'txtReportpath
        '
        Me.txtReportpath.BackColor = System.Drawing.Color.White
        Me.txtReportpath.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportpath.Location = New System.Drawing.Point(109, 31)
        Me.txtReportpath.Name = "txtReportpath"
        Me.txtReportpath.ReadOnly = True
        Me.txtReportpath.Size = New System.Drawing.Size(229, 21)
        Me.txtReportpath.TabIndex = 1
        Me.txtReportpath.Tag = "Report Path"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(7, 37)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 13)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Report Path"
        '
        'btnProdImagePath
        '
        Me.btnProdImagePath.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdImagePath.Appearance.Options.UseFont = True
        Me.btnProdImagePath.Location = New System.Drawing.Point(341, 95)
        Me.btnProdImagePath.Name = "btnProdImagePath"
        Me.btnProdImagePath.Size = New System.Drawing.Size(28, 23)
        Me.btnProdImagePath.TabIndex = 26
        Me.btnProdImagePath.Text = "..."
        '
        'cmbAutoBackupOptions
        '
        Me.cmbAutoBackupOptions.AutoComplete = True
        Me.cmbAutoBackupOptions.DisplayMember = "Led_Name"
        Me.cmbAutoBackupOptions.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbAutoBackupOptions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAutoBackupOptions.Location = New System.Drawing.Point(479, 4)
        Me.cmbAutoBackupOptions.Name = "cmbAutoBackupOptions"
        Me.cmbAutoBackupOptions.Size = New System.Drawing.Size(84, 22)
        Me.cmbAutoBackupOptions.TabIndex = 39
        Me.cmbAutoBackupOptions.ValueMember = "Led_Key"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(7, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(66, 13)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Backup Path"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(585, 7)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(97, 13)
        Me.Label56.TabIndex = 51
        Me.Label56.Text = "Calculate Stock On"
        '
        'txtProdImgPath
        '
        Me.txtProdImgPath.BackColor = System.Drawing.Color.White
        Me.txtProdImgPath.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdImgPath.Location = New System.Drawing.Point(109, 98)
        Me.txtProdImgPath.Name = "txtProdImgPath"
        Me.txtProdImgPath.ReadOnly = True
        Me.txtProdImgPath.Size = New System.Drawing.Size(229, 21)
        Me.txtProdImgPath.TabIndex = 1
        Me.txtProdImgPath.Tag = "Product Image Path"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(341, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(28, 23)
        Me.btnBrowse.TabIndex = 26
        Me.btnBrowse.Text = "..."
        '
        'chkAutoBackup
        '
        Me.chkAutoBackup.Location = New System.Drawing.Point(383, 5)
        Me.chkAutoBackup.Name = "chkAutoBackup"
        Me.chkAutoBackup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoBackup.Properties.Appearance.Options.UseFont = True
        Me.chkAutoBackup.Properties.Caption = "Auto Backup"
        Me.chkAutoBackup.Size = New System.Drawing.Size(85, 19)
        Me.chkAutoBackup.TabIndex = 18
        '
        'chkDisplayImage
        '
        Me.chkDisplayImage.Location = New System.Drawing.Point(7, 99)
        Me.chkDisplayImage.Name = "chkDisplayImage"
        Me.chkDisplayImage.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayImage.Properties.Appearance.Options.UseFont = True
        Me.chkDisplayImage.Properties.Caption = "Maintain Image"
        Me.chkDisplayImage.Size = New System.Drawing.Size(101, 19)
        Me.chkDisplayImage.TabIndex = 18
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 78)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 13)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Delete backup after"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(144, 82)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(30, 13)
        Me.Label48.TabIndex = 8
        Me.Label48.Text = "days"
        '
        'grpCompanyInfo
        '
        Me.grpCompanyInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpCompanyInfo.Appearance.Options.UseBackColor = True
        Me.grpCompanyInfo.Controls.Add(Me.txtBarcodeInfo2)
        Me.grpCompanyInfo.Controls.Add(Me.txtBarcodeInfo1)
        Me.grpCompanyInfo.Controls.Add(Me.Label40)
        Me.grpCompanyInfo.Controls.Add(Me.Label52)
        Me.grpCompanyInfo.Controls.Add(Me.chkUseMultiSalesperson)
        Me.grpCompanyInfo.Controls.Add(Me.cmbDefPriceLevel)
        Me.grpCompanyInfo.Controls.Add(Me.cmbSystemSeries)
        Me.grpCompanyInfo.Controls.Add(Me.cmbDecInQty)
        Me.grpCompanyInfo.Controls.Add(Me.cmbDefStation)
        Me.grpCompanyInfo.Controls.Add(Me.lblDefSalesperson)
        Me.grpCompanyInfo.Controls.Add(Me.Label53)
        Me.grpCompanyInfo.Controls.Add(Me.cmbDefSalesperson)
        Me.grpCompanyInfo.Controls.Add(Me.Label34)
        Me.grpCompanyInfo.Controls.Add(Me.Label45)
        Me.grpCompanyInfo.Controls.Add(Me.txtTerms)
        Me.grpCompanyInfo.Controls.Add(Me.txtAddressOnBarcode)
        Me.grpCompanyInfo.Controls.Add(Me.chkCRM)
        Me.grpCompanyInfo.Controls.Add(Me.chkBarcodeInfo2)
        Me.grpCompanyInfo.Controls.Add(Me.Label42)
        Me.grpCompanyInfo.Controls.Add(Me.Label35)
        Me.grpCompanyInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpCompanyInfo.LookAndFeel.SkinName = "Blue"
        Me.grpCompanyInfo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpCompanyInfo.Name = "grpCompanyInfo"
        Me.grpCompanyInfo.ShowCaption = False
        Me.grpCompanyInfo.Size = New System.Drawing.Size(770, 156)
        Me.grpCompanyInfo.TabIndex = 56
        Me.grpCompanyInfo.Text = "Apply For Product"
        '
        'txtBarcodeInfo2
        '
        Me.txtBarcodeInfo2.Enabled = False
        Me.txtBarcodeInfo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeInfo2.Location = New System.Drawing.Point(520, 77)
        Me.txtBarcodeInfo2.MaxLength = 50
        Me.txtBarcodeInfo2.Name = "txtBarcodeInfo2"
        Me.txtBarcodeInfo2.Size = New System.Drawing.Size(242, 21)
        Me.txtBarcodeInfo2.TabIndex = 64
        Me.txtBarcodeInfo2.Tag = ""
        Me.txtBarcodeInfo2.Text = "Contains Qty Unit Only"
        '
        'txtBarcodeInfo1
        '
        Me.txtBarcodeInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeInfo1.Location = New System.Drawing.Point(126, 77)
        Me.txtBarcodeInfo1.MaxLength = 50
        Me.txtBarcodeInfo1.Name = "txtBarcodeInfo1"
        Me.txtBarcodeInfo1.Size = New System.Drawing.Size(261, 21)
        Me.txtBarcodeInfo1.TabIndex = 64
        Me.txtBarcodeInfo1.Tag = "Barcode Info 1"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(5, 81)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(78, 13)
        Me.Label40.TabIndex = 63
        Me.Label40.Text = "Barcode Info 1"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Maroon
        Me.Label52.Location = New System.Drawing.Point(5, 5)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(110, 13)
        Me.Label52.TabIndex = 0
        Me.Label52.Text = "Company Settings"
        '
        'chkUseMultiSalesperson
        '
        Me.chkUseMultiSalesperson.Location = New System.Drawing.Point(217, 25)
        Me.chkUseMultiSalesperson.Name = "chkUseMultiSalesperson"
        Me.chkUseMultiSalesperson.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMultiSalesperson.Properties.Appearance.Options.UseFont = True
        Me.chkUseMultiSalesperson.Properties.Caption = "Multi SalesPerson"
        Me.chkUseMultiSalesperson.Size = New System.Drawing.Size(108, 19)
        Me.chkUseMultiSalesperson.TabIndex = 18
        '
        'cmbDefPriceLevel
        '
        Me.cmbDefPriceLevel.AutoComplete = True
        Me.cmbDefPriceLevel.DisplayMember = "Led_Name"
        Me.cmbDefPriceLevel.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbDefPriceLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPriceLevel.Location = New System.Drawing.Point(712, 24)
        Me.cmbDefPriceLevel.Name = "cmbDefPriceLevel"
        Me.cmbDefPriceLevel.Size = New System.Drawing.Size(54, 22)
        Me.cmbDefPriceLevel.TabIndex = 39
        Me.cmbDefPriceLevel.ValueMember = "Led_Key"
        Me.cmbDefPriceLevel.Visible = False
        '
        'cmbSystemSeries
        '
        Me.cmbSystemSeries.AutoComplete = True
        Me.cmbSystemSeries.DisplayMember = "Led_Name"
        Me.cmbSystemSeries.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSystemSeries.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSystemSeries.Location = New System.Drawing.Point(609, 23)
        Me.cmbSystemSeries.Name = "cmbSystemSeries"
        Me.cmbSystemSeries.Size = New System.Drawing.Size(48, 22)
        Me.cmbSystemSeries.TabIndex = 40
        Me.cmbSystemSeries.Tag = "System Series"
        Me.cmbSystemSeries.ValueMember = "Led_Key"
        '
        'cmbDecInQty
        '
        Me.cmbDecInQty.AutoComplete = True
        Me.cmbDecInQty.DisplayMember = "Led_Name"
        Me.cmbDecInQty.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbDecInQty.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDecInQty.Location = New System.Drawing.Point(301, 49)
        Me.cmbDecInQty.Name = "cmbDecInQty"
        Me.cmbDecInQty.Size = New System.Drawing.Size(60, 22)
        Me.cmbDecInQty.TabIndex = 40
        Me.cmbDecInQty.ValueMember = "Led_Key"
        '
        'cmbDefStation
        '
        Me.cmbDefStation.AutoComplete = True
        Me.cmbDefStation.DisplayMember = "Led_Name"
        Me.cmbDefStation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefStation.Location = New System.Drawing.Point(71, 49)
        Me.cmbDefStation.Name = "cmbDefStation"
        Me.cmbDefStation.Size = New System.Drawing.Size(117, 22)
        Me.cmbDefStation.TabIndex = 38
        Me.cmbDefStation.Tag = "Default Station"
        Me.cmbDefStation.ValueMember = "Led_Key"
        '
        'lblDefSalesperson
        '
        Me.lblDefSalesperson.AutoSize = True
        Me.lblDefSalesperson.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefSalesperson.Location = New System.Drawing.Point(329, 28)
        Me.lblDefSalesperson.Name = "lblDefSalesperson"
        Me.lblDefSalesperson.Size = New System.Drawing.Size(85, 13)
        Me.lblDefSalesperson.TabIndex = 51
        Me.lblDefSalesperson.Text = "Def Salesperson"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(534, 28)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(74, 13)
        Me.Label53.TabIndex = 10
        Me.Label53.Text = "System Series"
        '
        'cmbDefSalesperson
        '
        Me.cmbDefSalesperson.AutoComplete = True
        Me.cmbDefSalesperson.DisplayMember = "Led_Name"
        Me.cmbDefSalesperson.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesperson.Location = New System.Drawing.Point(416, 23)
        Me.cmbDefSalesperson.Name = "cmbDefSalesperson"
        Me.cmbDefSalesperson.Size = New System.Drawing.Size(111, 22)
        Me.cmbDefSalesperson.TabIndex = 52
        Me.cmbDefSalesperson.ValueMember = "Led_Key"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(189, 54)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(112, 13)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "Digits in Decimal (Qty)"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(5, 54)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(61, 13)
        Me.Label45.TabIndex = 12
        Me.Label45.Text = "Def Station"
        '
        'txtTerms
        '
        Me.txtTerms.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerms.Location = New System.Drawing.Point(520, 102)
        Me.txtTerms.MaxLength = 500
        Me.txtTerms.Multiline = True
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTerms.Size = New System.Drawing.Size(242, 48)
        Me.txtTerms.TabIndex = 16
        Me.txtTerms.Tag = "Terms and Conditions"
        '
        'txtAddressOnBarcode
        '
        Me.txtAddressOnBarcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressOnBarcode.Location = New System.Drawing.Point(126, 102)
        Me.txtAddressOnBarcode.MaxLength = 500
        Me.txtAddressOnBarcode.Multiline = True
        Me.txtAddressOnBarcode.Name = "txtAddressOnBarcode"
        Me.txtAddressOnBarcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddressOnBarcode.Size = New System.Drawing.Size(261, 48)
        Me.txtAddressOnBarcode.TabIndex = 17
        Me.txtAddressOnBarcode.Tag = "Address On Barcode"
        '
        'chkCRM
        '
        Me.chkCRM.Location = New System.Drawing.Point(659, 24)
        Me.chkCRM.Name = "chkCRM"
        Me.chkCRM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCRM.Properties.Appearance.Options.UseFont = True
        Me.chkCRM.Properties.Caption = "CRM"
        Me.chkCRM.Size = New System.Drawing.Size(45, 19)
        Me.chkCRM.TabIndex = 18
        '
        'chkBarcodeInfo2
        '
        Me.chkBarcodeInfo2.Location = New System.Drawing.Point(399, 78)
        Me.chkBarcodeInfo2.Name = "chkBarcodeInfo2"
        Me.chkBarcodeInfo2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBarcodeInfo2.Properties.Appearance.Options.UseFont = True
        Me.chkBarcodeInfo2.Properties.Caption = "Barcode Info 2"
        Me.chkBarcodeInfo2.Size = New System.Drawing.Size(110, 19)
        Me.chkBarcodeInfo2.TabIndex = 18
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(5, 119)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(105, 13)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = "Address On Barcode"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(399, 119)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(110, 13)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Terms and Conditions"
        '
        'grpMaintainStock
        '
        Me.grpMaintainStock.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpMaintainStock.Appearance.Options.UseBackColor = True
        Me.grpMaintainStock.Controls.Add(Me.Label50)
        Me.grpMaintainStock.Controls.Add(Me.chkUseBarcode)
        Me.grpMaintainStock.Controls.Add(Me.chkMaintainStk)
        Me.grpMaintainStock.Controls.Add(Me.chkAllowNegativeStk)
        Me.grpMaintainStock.Controls.Add(Me.cmbBarcodeSeries)
        Me.grpMaintainStock.Controls.Add(Me.cmbBarcode)
        Me.grpMaintainStock.Controls.Add(Me.Label51)
        Me.grpMaintainStock.Location = New System.Drawing.Point(393, 161)
        Me.grpMaintainStock.LookAndFeel.SkinName = "Blue"
        Me.grpMaintainStock.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpMaintainStock.Name = "grpMaintainStock"
        Me.grpMaintainStock.ShowCaption = False
        Me.grpMaintainStock.Size = New System.Drawing.Size(380, 91)
        Me.grpMaintainStock.TabIndex = 55
        Me.grpMaintainStock.Text = "Apply For Product"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Maroon
        Me.Label50.Location = New System.Drawing.Point(3, 5)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(91, 13)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "Maintain Stock"
        '
        'chkUseBarcode
        '
        Me.chkUseBarcode.Location = New System.Drawing.Point(4, 59)
        Me.chkUseBarcode.Name = "chkUseBarcode"
        Me.chkUseBarcode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseBarcode.Properties.Appearance.Options.UseFont = True
        Me.chkUseBarcode.Properties.Caption = "Use Barcode"
        Me.chkUseBarcode.Size = New System.Drawing.Size(87, 19)
        Me.chkUseBarcode.TabIndex = 20
        '
        'chkMaintainStk
        '
        Me.chkMaintainStk.Location = New System.Drawing.Point(3, 24)
        Me.chkMaintainStk.Name = "chkMaintainStk"
        Me.chkMaintainStk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaintainStk.Properties.Appearance.Options.UseFont = True
        Me.chkMaintainStk.Properties.Caption = "Maintain stock"
        Me.chkMaintainStk.Size = New System.Drawing.Size(95, 19)
        Me.chkMaintainStk.TabIndex = 20
        '
        'chkAllowNegativeStk
        '
        Me.chkAllowNegativeStk.Location = New System.Drawing.Point(141, 24)
        Me.chkAllowNegativeStk.Name = "chkAllowNegativeStk"
        Me.chkAllowNegativeStk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllowNegativeStk.Properties.Appearance.Options.UseFont = True
        Me.chkAllowNegativeStk.Properties.Caption = "Allow Negative Stock"
        Me.chkAllowNegativeStk.Size = New System.Drawing.Size(128, 19)
        Me.chkAllowNegativeStk.TabIndex = 19
        '
        'cmbBarcodeSeries
        '
        Me.cmbBarcodeSeries.AutoComplete = True
        Me.cmbBarcodeSeries.DisplayMember = "Led_Name"
        Me.cmbBarcodeSeries.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbBarcodeSeries.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarcodeSeries.Location = New System.Drawing.Point(305, 58)
        Me.cmbBarcodeSeries.Name = "cmbBarcodeSeries"
        Me.cmbBarcodeSeries.Size = New System.Drawing.Size(71, 22)
        Me.cmbBarcodeSeries.TabIndex = 41
        Me.cmbBarcodeSeries.ValueMember = "Led_Key"
        '
        'cmbBarcode
        '
        Me.cmbBarcode.AutoComplete = True
        Me.cmbBarcode.DisplayMember = "Led_Name"
        Me.cmbBarcode.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbBarcode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarcode.Location = New System.Drawing.Point(91, 58)
        Me.cmbBarcode.Name = "cmbBarcode"
        Me.cmbBarcode.Size = New System.Drawing.Size(97, 22)
        Me.cmbBarcode.TabIndex = 41
        Me.cmbBarcode.ValueMember = "Led_Key"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(189, 61)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(105, 13)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Barcode Series From"
        '
        'grpApplyForProduct
        '
        Me.grpApplyForProduct.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpApplyForProduct.Appearance.Options.UseBackColor = True
        Me.grpApplyForProduct.Controls.Add(Me.chksup_design)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseOccassion)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseSeason)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseQuality)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseSize)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseShade)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseDesign)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseBrand)
        Me.grpApplyForProduct.Controls.Add(Me.lblApplyProduct)
        Me.grpApplyForProduct.Controls.Add(Me.chkProdSeriesTwoDigitPrefix)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseTypeNo)
        Me.grpApplyForProduct.Location = New System.Drawing.Point(3, 161)
        Me.grpApplyForProduct.LookAndFeel.SkinName = "Blue"
        Me.grpApplyForProduct.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpApplyForProduct.Name = "grpApplyForProduct"
        Me.grpApplyForProduct.ShowCaption = False
        Me.grpApplyForProduct.Size = New System.Drawing.Size(388, 95)
        Me.grpApplyForProduct.TabIndex = 54
        Me.grpApplyForProduct.Text = "Apply For Product"
        '
        'chksup_design
        '
        Me.chksup_design.Location = New System.Drawing.Point(266, 76)
        Me.chksup_design.Name = "chksup_design"
        Me.chksup_design.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chksup_design.Properties.Appearance.Options.UseFont = True
        Me.chksup_design.Properties.Caption = "Use Supl Design"
        Me.chksup_design.Size = New System.Drawing.Size(104, 19)
        Me.chksup_design.TabIndex = 25
        '
        'chkUseOccassion
        '
        Me.chkUseOccassion.Location = New System.Drawing.Point(266, 50)
        Me.chkUseOccassion.Name = "chkUseOccassion"
        Me.chkUseOccassion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseOccassion.Properties.Appearance.Options.UseFont = True
        Me.chkUseOccassion.Properties.Caption = "Use Occassion"
        Me.chkUseOccassion.Size = New System.Drawing.Size(103, 19)
        Me.chkUseOccassion.TabIndex = 24
        '
        'chkUseSeason
        '
        Me.chkUseSeason.Location = New System.Drawing.Point(177, 50)
        Me.chkUseSeason.Name = "chkUseSeason"
        Me.chkUseSeason.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseSeason.Properties.Appearance.Options.UseFont = True
        Me.chkUseSeason.Properties.Caption = "Use Season"
        Me.chkUseSeason.Size = New System.Drawing.Size(103, 19)
        Me.chkUseSeason.TabIndex = 23
        '
        'chkUseQuality
        '
        Me.chkUseQuality.Location = New System.Drawing.Point(88, 50)
        Me.chkUseQuality.Name = "chkUseQuality"
        Me.chkUseQuality.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseQuality.Properties.Appearance.Options.UseFont = True
        Me.chkUseQuality.Properties.Caption = "Use Quality"
        Me.chkUseQuality.Size = New System.Drawing.Size(86, 19)
        Me.chkUseQuality.TabIndex = 21
        '
        'chkUseSize
        '
        Me.chkUseSize.Location = New System.Drawing.Point(266, 25)
        Me.chkUseSize.Name = "chkUseSize"
        Me.chkUseSize.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseSize.Properties.Appearance.Options.UseFont = True
        Me.chkUseSize.Properties.Caption = "Use Size"
        Me.chkUseSize.Size = New System.Drawing.Size(70, 19)
        Me.chkUseSize.TabIndex = 19
        '
        'chkUseShade
        '
        Me.chkUseShade.Location = New System.Drawing.Point(177, 25)
        Me.chkUseShade.Name = "chkUseShade"
        Me.chkUseShade.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseShade.Properties.Appearance.Options.UseFont = True
        Me.chkUseShade.Properties.Caption = "Use Shade"
        Me.chkUseShade.Size = New System.Drawing.Size(87, 19)
        Me.chkUseShade.TabIndex = 19
        '
        'chkUseDesign
        '
        Me.chkUseDesign.Location = New System.Drawing.Point(3, 25)
        Me.chkUseDesign.Name = "chkUseDesign"
        Me.chkUseDesign.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseDesign.Properties.Appearance.Options.UseFont = True
        Me.chkUseDesign.Properties.Caption = "Use Design"
        Me.chkUseDesign.Size = New System.Drawing.Size(83, 19)
        Me.chkUseDesign.TabIndex = 19
        '
        'chkUseBrand
        '
        Me.chkUseBrand.Location = New System.Drawing.Point(3, 48)
        Me.chkUseBrand.Name = "chkUseBrand"
        Me.chkUseBrand.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseBrand.Properties.Appearance.Options.UseFont = True
        Me.chkUseBrand.Properties.Caption = "Use Brand"
        Me.chkUseBrand.Size = New System.Drawing.Size(82, 19)
        Me.chkUseBrand.TabIndex = 19
        '
        'lblApplyProduct
        '
        Me.lblApplyProduct.AutoSize = True
        Me.lblApplyProduct.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplyProduct.ForeColor = System.Drawing.Color.Maroon
        Me.lblApplyProduct.Location = New System.Drawing.Point(5, 5)
        Me.lblApplyProduct.Name = "lblApplyProduct"
        Me.lblApplyProduct.Size = New System.Drawing.Size(107, 13)
        Me.lblApplyProduct.TabIndex = 0
        Me.lblApplyProduct.Text = "Apply For Product"
        '
        'chkProdSeriesTwoDigitPrefix
        '
        Me.chkProdSeriesTwoDigitPrefix.Location = New System.Drawing.Point(4, 76)
        Me.chkProdSeriesTwoDigitPrefix.Name = "chkProdSeriesTwoDigitPrefix"
        Me.chkProdSeriesTwoDigitPrefix.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProdSeriesTwoDigitPrefix.Properties.Appearance.Options.UseFont = True
        Me.chkProdSeriesTwoDigitPrefix.Properties.Caption = "Product Series 2 digit as prefix"
        Me.chkProdSeriesTwoDigitPrefix.Size = New System.Drawing.Size(173, 19)
        Me.chkProdSeriesTwoDigitPrefix.TabIndex = 18
        '
        'chkUseTypeNo
        '
        Me.chkUseTypeNo.Location = New System.Drawing.Point(88, 25)
        Me.chkUseTypeNo.Name = "chkUseTypeNo"
        Me.chkUseTypeNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseTypeNo.Properties.Appearance.Options.UseFont = True
        Me.chkUseTypeNo.Properties.Caption = "Use Type"
        Me.chkUseTypeNo.Size = New System.Drawing.Size(91, 19)
        Me.chkUseTypeNo.TabIndex = 18
        '
        'tabPgTrans
        '
        Me.tabPgTrans.BackColor = System.Drawing.Color.AliceBlue
        Me.tabPgTrans.Controls.Add(Me.grpSales)
        Me.tabPgTrans.Controls.Add(Me.grpWholeSaleBill)
        Me.tabPgTrans.Controls.Add(Me.grpPurchaseRtn)
        Me.tabPgTrans.Controls.Add(Me.grpPurchase)
        Me.tabPgTrans.Controls.Add(Me.grpSalesRtn)
        Me.tabPgTrans.Controls.Add(Me.rdWholeSaleBill)
        Me.tabPgTrans.Controls.Add(Me.rdSalesRtn)
        Me.tabPgTrans.Controls.Add(Me.rdSales)
        Me.tabPgTrans.Controls.Add(Me.rdPurchaseRtn)
        Me.tabPgTrans.Controls.Add(Me.rdPurchase)
        Me.tabPgTrans.Location = New System.Drawing.Point(4, 23)
        Me.tabPgTrans.Name = "tabPgTrans"
        Me.tabPgTrans.Size = New System.Drawing.Size(782, 541)
        Me.tabPgTrans.TabIndex = 2
        Me.tabPgTrans.Text = "Transaction"
        Me.tabPgTrans.UseVisualStyleBackColor = True
        '
        'grpSales
        '
        Me.grpSales.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSales.AppearanceCaption.Options.UseFont = True
        Me.grpSales.AppearanceCaption.Options.UseTextOptions = True
        Me.grpSales.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpSales.Controls.Add(Me.pnlOptions)
        Me.grpSales.Controls.Add(Me.PnlListOptions)
        Me.grpSales.Controls.Add(Me.QrCodePanel)
        Me.grpSales.Controls.Add(Me.lnkQRcodeSeq)
        Me.grpSales.Controls.Add(Me.PanelGrid)
        Me.grpSales.Controls.Add(Me.lnkSaleGrid)
        Me.grpSales.Controls.Add(Me.lnkMinQty)
        Me.grpSales.Controls.Add(Me.cmbDefSalesCust)
        Me.grpSales.Controls.Add(Me.lnkseqproduct)
        Me.grpSales.Controls.Add(Me.Label3)
        Me.grpSales.Controls.Add(Me.txtTotalNoOfEdit)
        Me.grpSales.Controls.Add(Me.chkAllowfocusonBillDiscount)
        Me.grpSales.Controls.Add(Me.chkAllowBackDateBillDelete)
        Me.grpSales.Controls.Add(Me.chkAllowBackDateBillEdit)
        Me.grpSales.Controls.Add(Me.chkSalesUseSalesOrderinBill)
        Me.grpSales.Controls.Add(Me.txtSalesEmailid)
        Me.grpSales.Controls.Add(Me.Label67)
        Me.grpSales.Controls.Add(Me.chkSalesAutoEmailOnBill)
        Me.grpSales.Controls.Add(Me.cmbFocusOn)
        Me.grpSales.Controls.Add(Me.Label69)
        Me.grpSales.Controls.Add(Me.chkSalesDisplayLastBillDetails)
        Me.grpSales.Controls.Add(Me.txtSalesPageSize)
        Me.grpSales.Controls.Add(Me.Label68)
        Me.grpSales.Controls.Add(Me.txtSalesPrinterName)
        Me.grpSales.Controls.Add(Me.lblPrinterName)
        Me.grpSales.Controls.Add(Me.txtTimingFrom)
        Me.grpSales.Controls.Add(Me.Label44)
        Me.grpSales.Controls.Add(Me.txtMessageOnBill)
        Me.grpSales.Controls.Add(Me.Label49)
        Me.grpSales.Controls.Add(Me.txtSalesNoOfCopiesToPrint)
        Me.grpSales.Controls.Add(Me.txtSalesNoOfItemsOnBill)
        Me.grpSales.Controls.Add(Me.txtInvoiceHeadOnPrint)
        Me.grpSales.Controls.Add(Me.chkSalesAllowBackDtBillCreation)
        Me.grpSales.Controls.Add(Me.chkSalesMsgOnAutoSMS)
        Me.grpSales.Controls.Add(Me.chkSalesMsgOnAutoPrint)
        Me.grpSales.Controls.Add(Me.cmbSalesDefPayMode)
        Me.grpSales.Controls.Add(Me.cmbSalesAllowBillDelete)
        Me.grpSales.Controls.Add(Me.cmbSalesAllowBillUpdate)
        Me.grpSales.Controls.Add(Me.cmbDefSalesCardDiscAccount)
        Me.grpSales.Controls.Add(Me.chkSalesPrnOnSave)
        Me.grpSales.Controls.Add(Me.chkSalesMergeDupBarcode)
        Me.grpSales.Controls.Add(Me.chkSalesRestrictBillChgAfterPrint)
        Me.grpSales.Controls.Add(Me.chkSalesLockBillDiscount)
        Me.grpSales.Controls.Add(Me.chkSalesLockSalesRt)
        Me.grpSales.Controls.Add(Me.chkSalesAutoSMSBill)
        Me.grpSales.Controls.Add(Me.chkSalesAskForBill)
        Me.grpSales.Controls.Add(Me.chkSalesExchAgainstBill)
        Me.grpSales.Controls.Add(Me.chkSalesAllowBkDtBillPrn)
        Me.grpSales.Controls.Add(Me.chkSalesAutoRdOff)
        Me.grpSales.Controls.Add(Me.Label31)
        Me.grpSales.Controls.Add(Me.Label32)
        Me.grpSales.Controls.Add(Me.Label58)
        Me.grpSales.Controls.Add(Me.Label66)
        Me.grpSales.Controls.Add(Me.Label27)
        Me.grpSales.Controls.Add(Me.Label65)
        Me.grpSales.Controls.Add(Me.Label39)
        Me.grpSales.Controls.Add(Me.Label29)
        Me.grpSales.Location = New System.Drawing.Point(5, 56)
        Me.grpSales.LookAndFeel.SkinName = "Money Twins"
        Me.grpSales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpSales.Name = "grpSales"
        Me.grpSales.Size = New System.Drawing.Size(776, 494)
        Me.grpSales.TabIndex = 4
        Me.grpSales.Text = "Sales"
        Me.grpSales.Visible = False
        '
        'PnlListOptions
        '
        Me.PnlListOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlListOptions.Controls.Add(Me.SimpleButton3)
        Me.PnlListOptions.Controls.Add(Me.SimpleButton4)
        Me.PnlListOptions.Controls.Add(Me.Panel2)
        Me.PnlListOptions.Controls.Add(Me.ListBox2)
        Me.PnlListOptions.Controls.Add(Me.SimpleButton9)
        Me.PnlListOptions.Controls.Add(Me.Label15)
        Me.PnlListOptions.Location = New System.Drawing.Point(206, 223)
        Me.PnlListOptions.Name = "PnlListOptions"
        Me.PnlListOptions.Size = New System.Drawing.Size(297, 254)
        Me.PnlListOptions.TabIndex = 555
        Me.PnlListOptions.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(93, 212)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(66, 26)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "Delete All"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Location = New System.Drawing.Point(20, 212)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(59, 26)
        Me.SimpleButton4.TabIndex = 3
        Me.SimpleButton4.Text = "Save"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnMinQtyDown)
        Me.Panel2.Controls.Add(Me.BtnMinQtyUp)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.SimpleButton5)
        Me.Panel2.Controls.Add(Me.SimpleButton7)
        Me.Panel2.Location = New System.Drawing.Point(105, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 177)
        Me.Panel2.TabIndex = 1
        '
        'BtnMinQtyDown
        '
        Me.BtnMinQtyDown.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinQtyDown.Appearance.Options.UseFont = True
        Me.BtnMinQtyDown.Location = New System.Drawing.Point(5, 70)
        Me.BtnMinQtyDown.Name = "BtnMinQtyDown"
        Me.BtnMinQtyDown.Size = New System.Drawing.Size(53, 18)
        Me.BtnMinQtyDown.TabIndex = 15
        Me.BtnMinQtyDown.Text = "v"
        '
        'BtnMinQtyUp
        '
        Me.BtnMinQtyUp.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinQtyUp.Appearance.Options.UseFont = True
        Me.BtnMinQtyUp.Location = New System.Drawing.Point(5, 46)
        Me.BtnMinQtyUp.Name = "BtnMinQtyUp"
        Me.BtnMinQtyUp.Size = New System.Drawing.Size(53, 18)
        Me.BtnMinQtyUp.TabIndex = 14
        Me.BtnMinQtyUp.Text = "^"
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(68, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(106, 158)
        Me.ListBox1.TabIndex = 1
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Location = New System.Drawing.Point(5, 16)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(53, 22)
        Me.SimpleButton5.TabIndex = 0
        Me.SimpleButton5.Text = ">>"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.Location = New System.Drawing.Point(4, 98)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(55, 22)
        Me.SimpleButton7.TabIndex = 2
        Me.SimpleButton7.Text = "Delete"
        '
        'ListBox2
        '
        Me.ListBox2.AllowDrop = True
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Items.AddRange(New Object() {"Product", "Type", "Brand", "Quality", "Season", "Occassion", "Size", ""})
        Me.ListBox2.Location = New System.Drawing.Point(2, 29)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(101, 158)
        Me.ListBox2.TabIndex = 0
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton9.Appearance.Options.UseFont = True
        Me.SimpleButton9.Location = New System.Drawing.Point(165, 212)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(75, 26)
        Me.SimpleButton9.TabIndex = 2
        Me.SimpleButton9.Text = "Close"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(102, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Options"
        '
        'QrCodePanel
        '
        Me.QrCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QrCodePanel.Controls.Add(Me.btnDelAllQr)
        Me.QrCodePanel.Controls.Add(Me.btnSaveQr)
        Me.QrCodePanel.Controls.Add(Me.Panel4)
        Me.QrCodePanel.Controls.Add(Me.ListQrFrom)
        Me.QrCodePanel.Controls.Add(Me.btnCloseQr)
        Me.QrCodePanel.Controls.Add(Me.Label16)
        Me.QrCodePanel.Location = New System.Drawing.Point(227, 223)
        Me.QrCodePanel.Name = "QrCodePanel"
        Me.QrCodePanel.Size = New System.Drawing.Size(297, 254)
        Me.QrCodePanel.TabIndex = 559
        Me.QrCodePanel.Visible = False
        '
        'btnDelAllQr
        '
        Me.btnDelAllQr.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAllQr.Appearance.Options.UseFont = True
        Me.btnDelAllQr.Location = New System.Drawing.Point(93, 212)
        Me.btnDelAllQr.Name = "btnDelAllQr"
        Me.btnDelAllQr.Size = New System.Drawing.Size(66, 26)
        Me.btnDelAllQr.TabIndex = 4
        Me.btnDelAllQr.Text = "Delete All"
        '
        'btnSaveQr
        '
        Me.btnSaveQr.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveQr.Appearance.Options.UseFont = True
        Me.btnSaveQr.Location = New System.Drawing.Point(20, 212)
        Me.btnSaveQr.Name = "btnSaveQr"
        Me.btnSaveQr.Size = New System.Drawing.Size(59, 26)
        Me.btnSaveQr.TabIndex = 3
        Me.btnSaveQr.Text = "Save"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ListQrTo)
        Me.Panel4.Controls.Add(Me.btnMoveQrTo)
        Me.Panel4.Controls.Add(Me.BtnDelQr)
        Me.Panel4.Location = New System.Drawing.Point(105, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(186, 177)
        Me.Panel4.TabIndex = 1
        '
        'ListQrTo
        '
        Me.ListQrTo.AllowDrop = True
        Me.ListQrTo.FormattingEnabled = True
        Me.ListQrTo.ItemHeight = 14
        Me.ListQrTo.Location = New System.Drawing.Point(68, 2)
        Me.ListQrTo.Name = "ListQrTo"
        Me.ListQrTo.Size = New System.Drawing.Size(106, 158)
        Me.ListQrTo.TabIndex = 1
        '
        'btnMoveQrTo
        '
        Me.btnMoveQrTo.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveQrTo.Appearance.Options.UseFont = True
        Me.btnMoveQrTo.Location = New System.Drawing.Point(5, 45)
        Me.btnMoveQrTo.Name = "btnMoveQrTo"
        Me.btnMoveQrTo.Size = New System.Drawing.Size(53, 22)
        Me.btnMoveQrTo.TabIndex = 0
        Me.btnMoveQrTo.Text = ">>"
        '
        'BtnDelQr
        '
        Me.BtnDelQr.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelQr.Appearance.Options.UseFont = True
        Me.BtnDelQr.Location = New System.Drawing.Point(4, 98)
        Me.BtnDelQr.Name = "BtnDelQr"
        Me.BtnDelQr.Size = New System.Drawing.Size(55, 22)
        Me.BtnDelQr.TabIndex = 2
        Me.BtnDelQr.Text = "Delete"
        '
        'ListQrFrom
        '
        Me.ListQrFrom.AllowDrop = True
        Me.ListQrFrom.FormattingEnabled = True
        Me.ListQrFrom.ItemHeight = 14
        Me.ListQrFrom.Items.AddRange(New Object() {"Product", "Design", "Type", "Shade", "Size", "Brand", "Particulars"})
        Me.ListQrFrom.Location = New System.Drawing.Point(2, 29)
        Me.ListQrFrom.Name = "ListQrFrom"
        Me.ListQrFrom.Size = New System.Drawing.Size(101, 158)
        Me.ListQrFrom.TabIndex = 0
        '
        'btnCloseQr
        '
        Me.btnCloseQr.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseQr.Appearance.Options.UseFont = True
        Me.btnCloseQr.Location = New System.Drawing.Point(165, 212)
        Me.btnCloseQr.Name = "btnCloseQr"
        Me.btnCloseQr.Size = New System.Drawing.Size(75, 26)
        Me.btnCloseQr.TabIndex = 2
        Me.btnCloseQr.Text = "Close"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(59, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 18)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "QrCode Sequence SetUp"
        '
        'lnkQRcodeSeq
        '
        Me.lnkQRcodeSeq.AutoSize = True
        Me.lnkQRcodeSeq.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkQRcodeSeq.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkQRcodeSeq.Location = New System.Drawing.Point(6, 383)
        Me.lnkQRcodeSeq.Name = "lnkQRcodeSeq"
        Me.lnkQRcodeSeq.Size = New System.Drawing.Size(153, 17)
        Me.lnkQRcodeSeq.TabIndex = 558
        Me.lnkQRcodeSeq.TabStop = True
        Me.lnkQRcodeSeq.Text = "QrCode Sequence SetUp"
        Me.lnkQRcodeSeq.Visible = False
        '
        'PanelGrid
        '
        Me.PanelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGrid.Controls.Add(Me.btnDeleteAllGrid)
        Me.PanelGrid.Controls.Add(Me.btnGridSave)
        Me.PanelGrid.Controls.Add(Me.Panel3)
        Me.PanelGrid.Controls.Add(Me.ListBoxFrom)
        Me.PanelGrid.Controls.Add(Me.btnCloseGrid)
        Me.PanelGrid.Controls.Add(Me.Label12)
        Me.PanelGrid.Location = New System.Drawing.Point(211, 220)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(297, 254)
        Me.PanelGrid.TabIndex = 557
        Me.PanelGrid.Visible = False
        '
        'btnDeleteAllGrid
        '
        Me.btnDeleteAllGrid.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAllGrid.Appearance.Options.UseFont = True
        Me.btnDeleteAllGrid.Location = New System.Drawing.Point(93, 212)
        Me.btnDeleteAllGrid.Name = "btnDeleteAllGrid"
        Me.btnDeleteAllGrid.Size = New System.Drawing.Size(66, 26)
        Me.btnDeleteAllGrid.TabIndex = 4
        Me.btnDeleteAllGrid.Text = "Delete All"
        '
        'btnGridSave
        '
        Me.btnGridSave.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGridSave.Appearance.Options.UseFont = True
        Me.btnGridSave.Location = New System.Drawing.Point(20, 212)
        Me.btnGridSave.Name = "btnGridSave"
        Me.btnGridSave.Size = New System.Drawing.Size(59, 26)
        Me.btnGridSave.TabIndex = 3
        Me.btnGridSave.Text = "Save"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ListBoxTo)
        Me.Panel3.Controls.Add(Me.btnMoveTo)
        Me.Panel3.Controls.Add(Me.btnDeleteGrid)
        Me.Panel3.Location = New System.Drawing.Point(105, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(186, 177)
        Me.Panel3.TabIndex = 1
        '
        'ListBoxTo
        '
        Me.ListBoxTo.AllowDrop = True
        Me.ListBoxTo.FormattingEnabled = True
        Me.ListBoxTo.ItemHeight = 14
        Me.ListBoxTo.Location = New System.Drawing.Point(68, 2)
        Me.ListBoxTo.Name = "ListBoxTo"
        Me.ListBoxTo.Size = New System.Drawing.Size(106, 158)
        Me.ListBoxTo.TabIndex = 1
        '
        'btnMoveTo
        '
        Me.btnMoveTo.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveTo.Appearance.Options.UseFont = True
        Me.btnMoveTo.Location = New System.Drawing.Point(5, 45)
        Me.btnMoveTo.Name = "btnMoveTo"
        Me.btnMoveTo.Size = New System.Drawing.Size(53, 22)
        Me.btnMoveTo.TabIndex = 0
        Me.btnMoveTo.Text = ">>"
        '
        'btnDeleteGrid
        '
        Me.btnDeleteGrid.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteGrid.Appearance.Options.UseFont = True
        Me.btnDeleteGrid.Location = New System.Drawing.Point(4, 98)
        Me.btnDeleteGrid.Name = "btnDeleteGrid"
        Me.btnDeleteGrid.Size = New System.Drawing.Size(55, 22)
        Me.btnDeleteGrid.TabIndex = 2
        Me.btnDeleteGrid.Text = "Delete"
        '
        'ListBoxFrom
        '
        Me.ListBoxFrom.AllowDrop = True
        Me.ListBoxFrom.FormattingEnabled = True
        Me.ListBoxFrom.ItemHeight = 14
        Me.ListBoxFrom.Items.AddRange(New Object() {"Product", "Design", "Type", "Shade", "Size", "Brand", "Particulars"})
        Me.ListBoxFrom.Location = New System.Drawing.Point(2, 29)
        Me.ListBoxFrom.Name = "ListBoxFrom"
        Me.ListBoxFrom.Size = New System.Drawing.Size(101, 158)
        Me.ListBoxFrom.TabIndex = 0
        '
        'btnCloseGrid
        '
        Me.btnCloseGrid.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseGrid.Appearance.Options.UseFont = True
        Me.btnCloseGrid.Location = New System.Drawing.Point(165, 212)
        Me.btnCloseGrid.Name = "btnCloseGrid"
        Me.btnCloseGrid.Size = New System.Drawing.Size(75, 26)
        Me.btnCloseGrid.TabIndex = 2
        Me.btnCloseGrid.Text = "Close"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(59, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Bill Grid Sequence SetUp"
        '
        'lnkSaleGrid
        '
        Me.lnkSaleGrid.AutoSize = True
        Me.lnkSaleGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkSaleGrid.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSaleGrid.Location = New System.Drawing.Point(6, 365)
        Me.lnkSaleGrid.Name = "lnkSaleGrid"
        Me.lnkSaleGrid.Size = New System.Drawing.Size(118, 17)
        Me.lnkSaleGrid.TabIndex = 556
        Me.lnkSaleGrid.TabStop = True
        Me.lnkSaleGrid.Text = "Sale Bill Grid Setup"
        Me.lnkSaleGrid.Visible = False
        '
        'lnkMinQty
        '
        Me.lnkMinQty.AutoSize = True
        Me.lnkMinQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkMinQty.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkMinQty.Location = New System.Drawing.Point(6, 346)
        Me.lnkMinQty.Name = "lnkMinQty"
        Me.lnkMinQty.Size = New System.Drawing.Size(158, 17)
        Me.lnkMinQty.TabIndex = 554
        Me.lnkMinQty.TabStop = True
        Me.lnkMinQty.Text = "Minimum Quantity Setup"
        Me.lnkMinQty.Visible = False
        '
        'cmbDefSalesCust
        '
        Me.cmbDefSalesCust.FormattingEnabled = True
        Me.cmbDefSalesCust.Location = New System.Drawing.Point(152, 27)
        Me.cmbDefSalesCust.Name = "cmbDefSalesCust"
        Me.cmbDefSalesCust.Size = New System.Drawing.Size(136, 22)
        Me.cmbDefSalesCust.TabIndex = 1
        '
        'lnkseqproduct
        '
        Me.lnkseqproduct.AutoSize = True
        Me.lnkseqproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkseqproduct.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkseqproduct.Location = New System.Drawing.Point(6, 327)
        Me.lnkseqproduct.Name = "lnkseqproduct"
        Me.lnkseqproduct.Size = New System.Drawing.Size(116, 17)
        Me.lnkseqproduct.TabIndex = 553
        Me.lnkseqproduct.TabStop = True
        Me.lnkseqproduct.Text = "Sequence Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Total no. of Edit"
        '
        'txtTotalNoOfEdit
        '
        Me.txtTotalNoOfEdit.AllowAlphabets = False
        Me.txtTotalNoOfEdit.AllowMoveToNextControl = True
        Me.txtTotalNoOfEdit.EditValue = 0
        Me.txtTotalNoOfEdit.Location = New System.Drawing.Point(433, 299)
        Me.txtTotalNoOfEdit.Name = "txtTotalNoOfEdit"
        Me.txtTotalNoOfEdit.Size = New System.Drawing.Size(43, 22)
        Me.txtTotalNoOfEdit.TabIndex = 83
        Me.txtTotalNoOfEdit.Tag = "Total No. of Edit"
        Me.txtTotalNoOfEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkAllowfocusonBillDiscount
        '
        Me.chkAllowfocusonBillDiscount.Location = New System.Drawing.Point(561, 334)
        Me.chkAllowfocusonBillDiscount.Name = "chkAllowfocusonBillDiscount"
        Me.chkAllowfocusonBillDiscount.Properties.Caption = "Allow focus on Bill Discount"
        Me.chkAllowfocusonBillDiscount.Size = New System.Drawing.Size(166, 19)
        Me.chkAllowfocusonBillDiscount.TabIndex = 82
        '
        'chkAllowBackDateBillDelete
        '
        Me.chkAllowBackDateBillDelete.Location = New System.Drawing.Point(561, 314)
        Me.chkAllowBackDateBillDelete.Name = "chkAllowBackDateBillDelete"
        Me.chkAllowBackDateBillDelete.Properties.Caption = "Allow Back Date Bill Delete"
        Me.chkAllowBackDateBillDelete.Size = New System.Drawing.Size(166, 19)
        Me.chkAllowBackDateBillDelete.TabIndex = 81
        '
        'chkAllowBackDateBillEdit
        '
        Me.chkAllowBackDateBillEdit.Location = New System.Drawing.Point(560, 293)
        Me.chkAllowBackDateBillEdit.Name = "chkAllowBackDateBillEdit"
        Me.chkAllowBackDateBillEdit.Properties.Caption = "Allow Back Date Bill Edit"
        Me.chkAllowBackDateBillEdit.Size = New System.Drawing.Size(166, 19)
        Me.chkAllowBackDateBillEdit.TabIndex = 80
        '
        'chkSalesUseSalesOrderinBill
        '
        Me.chkSalesUseSalesOrderinBill.Location = New System.Drawing.Point(560, 273)
        Me.chkSalesUseSalesOrderinBill.Name = "chkSalesUseSalesOrderinBill"
        Me.chkSalesUseSalesOrderinBill.Properties.Caption = "Use Sales Order "
        Me.chkSalesUseSalesOrderinBill.Size = New System.Drawing.Size(166, 19)
        Me.chkSalesUseSalesOrderinBill.TabIndex = 79
        '
        'txtSalesEmailid
        '
        Me.txtSalesEmailid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesEmailid.Location = New System.Drawing.Point(607, 211)
        Me.txtSalesEmailid.MaxLength = 50
        Me.txtSalesEmailid.Name = "txtSalesEmailid"
        Me.txtSalesEmailid.Size = New System.Drawing.Size(127, 21)
        Me.txtSalesEmailid.TabIndex = 78
        Me.txtSalesEmailid.Tag = "Page Size"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(557, 214)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(44, 13)
        Me.Label67.TabIndex = 76
        Me.Label67.Text = "Email Id"
        '
        'chkSalesAutoEmailOnBill
        '
        Me.chkSalesAutoEmailOnBill.Location = New System.Drawing.Point(554, 187)
        Me.chkSalesAutoEmailOnBill.Name = "chkSalesAutoEmailOnBill"
        Me.chkSalesAutoEmailOnBill.Properties.Caption = "Auto Email "
        Me.chkSalesAutoEmailOnBill.Size = New System.Drawing.Size(78, 19)
        Me.chkSalesAutoEmailOnBill.TabIndex = 75
        '
        'cmbFocusOn
        '
        Me.cmbFocusOn.AutoComplete = True
        Me.cmbFocusOn.DisplayMember = "Led_Name"
        Me.cmbFocusOn.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbFocusOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFocusOn.Location = New System.Drawing.Point(434, 272)
        Me.cmbFocusOn.Name = "cmbFocusOn"
        Me.cmbFocusOn.Size = New System.Drawing.Size(106, 21)
        Me.cmbFocusOn.TabIndex = 65
        Me.cmbFocusOn.Tag = "Focus On"
        Me.cmbFocusOn.ValueMember = "Led_Key"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(366, 275)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(56, 14)
        Me.Label69.TabIndex = 64
        Me.Label69.Text = "Focus On"
        '
        'chkSalesDisplayLastBillDetails
        '
        Me.chkSalesDisplayLastBillDetails.Location = New System.Drawing.Point(554, 89)
        Me.chkSalesDisplayLastBillDetails.Name = "chkSalesDisplayLastBillDetails"
        Me.chkSalesDisplayLastBillDetails.Properties.Caption = " Display Last Bill Details"
        Me.chkSalesDisplayLastBillDetails.Size = New System.Drawing.Size(166, 19)
        Me.chkSalesDisplayLastBillDetails.TabIndex = 72
        '
        'txtSalesPageSize
        '
        Me.txtSalesPageSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPageSize.Location = New System.Drawing.Point(102, 295)
        Me.txtSalesPageSize.MaxLength = 50
        Me.txtSalesPageSize.Name = "txtSalesPageSize"
        Me.txtSalesPageSize.Size = New System.Drawing.Size(186, 21)
        Me.txtSalesPageSize.TabIndex = 29
        Me.txtSalesPageSize.Tag = "Page Size"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(6, 299)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(53, 13)
        Me.Label68.TabIndex = 28
        Me.Label68.Text = "Page Size"
        '
        'txtSalesPrinterName
        '
        Me.txtSalesPrinterName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPrinterName.Location = New System.Drawing.Point(102, 267)
        Me.txtSalesPrinterName.MaxLength = 50
        Me.txtSalesPrinterName.Name = "txtSalesPrinterName"
        Me.txtSalesPrinterName.Size = New System.Drawing.Size(186, 21)
        Me.txtSalesPrinterName.TabIndex = 27
        Me.txtSalesPrinterName.Tag = "Printer Name"
        '
        'lblPrinterName
        '
        Me.lblPrinterName.AutoSize = True
        Me.lblPrinterName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrinterName.Location = New System.Drawing.Point(4, 271)
        Me.lblPrinterName.Name = "lblPrinterName"
        Me.lblPrinterName.Size = New System.Drawing.Size(72, 13)
        Me.lblPrinterName.TabIndex = 26
        Me.lblPrinterName.Text = " Printer Name"
        '
        'txtTimingFrom
        '
        Me.txtTimingFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimingFrom.Location = New System.Drawing.Point(102, 240)
        Me.txtTimingFrom.MaxLength = 50
        Me.txtTimingFrom.Name = "txtTimingFrom"
        Me.txtTimingFrom.Size = New System.Drawing.Size(186, 21)
        Me.txtTimingFrom.TabIndex = 25
        Me.txtTimingFrom.Tag = "Timing From"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(5, 243)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(37, 13)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "Timing"
        '
        'txtMessageOnBill
        '
        Me.txtMessageOnBill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessageOnBill.Location = New System.Drawing.Point(102, 216)
        Me.txtMessageOnBill.MaxLength = 50
        Me.txtMessageOnBill.Name = "txtMessageOnBill"
        Me.txtMessageOnBill.Size = New System.Drawing.Size(186, 21)
        Me.txtMessageOnBill.TabIndex = 23
        Me.txtMessageOnBill.Tag = "Message on bill"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(5, 220)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(79, 13)
        Me.Label49.TabIndex = 22
        Me.Label49.Text = "Message on bill"
        '
        'txtSalesNoOfCopiesToPrint
        '
        Me.txtSalesNoOfCopiesToPrint.AllowAlphabets = False
        Me.txtSalesNoOfCopiesToPrint.AllowMoveToNextControl = True
        Me.txtSalesNoOfCopiesToPrint.EditValue = 0
        Me.txtSalesNoOfCopiesToPrint.Location = New System.Drawing.Point(245, 186)
        Me.txtSalesNoOfCopiesToPrint.Name = "txtSalesNoOfCopiesToPrint"
        Me.txtSalesNoOfCopiesToPrint.Size = New System.Drawing.Size(43, 22)
        Me.txtSalesNoOfCopiesToPrint.TabIndex = 21
        Me.txtSalesNoOfCopiesToPrint.Tag = "No Of Copies To Print"
        Me.txtSalesNoOfCopiesToPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalesNoOfItemsOnBill
        '
        Me.txtSalesNoOfItemsOnBill.AllowAlphabets = False
        Me.txtSalesNoOfItemsOnBill.AllowMoveToNextControl = True
        Me.txtSalesNoOfItemsOnBill.EditValue = 0
        Me.txtSalesNoOfItemsOnBill.Location = New System.Drawing.Point(245, 117)
        Me.txtSalesNoOfItemsOnBill.Name = "txtSalesNoOfItemsOnBill"
        Me.txtSalesNoOfItemsOnBill.Size = New System.Drawing.Size(43, 22)
        Me.txtSalesNoOfItemsOnBill.TabIndex = 17
        Me.txtSalesNoOfItemsOnBill.Tag = "No Of Items On Bill"
        Me.txtSalesNoOfItemsOnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInvoiceHeadOnPrint
        '
        Me.txtInvoiceHeadOnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceHeadOnPrint.Location = New System.Drawing.Point(139, 155)
        Me.txtInvoiceHeadOnPrint.MaxLength = 50
        Me.txtInvoiceHeadOnPrint.Name = "txtInvoiceHeadOnPrint"
        Me.txtInvoiceHeadOnPrint.Size = New System.Drawing.Size(149, 21)
        Me.txtInvoiceHeadOnPrint.TabIndex = 19
        Me.txtInvoiceHeadOnPrint.Tag = "Invoice Head On Print"
        '
        'chkSalesAllowBackDtBillCreation
        '
        Me.chkSalesAllowBackDtBillCreation.Location = New System.Drawing.Point(554, 138)
        Me.chkSalesAllowBackDtBillCreation.Name = "chkSalesAllowBackDtBillCreation"
        Me.chkSalesAllowBackDtBillCreation.Properties.Caption = "Allow Back Date Bill Creation"
        Me.chkSalesAllowBackDtBillCreation.Size = New System.Drawing.Size(172, 19)
        Me.chkSalesAllowBackDtBillCreation.TabIndex = 55
        '
        'chkSalesMsgOnAutoSMS
        '
        Me.chkSalesMsgOnAutoSMS.Location = New System.Drawing.Point(555, 113)
        Me.chkSalesMsgOnAutoSMS.Name = "chkSalesMsgOnAutoSMS"
        Me.chkSalesMsgOnAutoSMS.Properties.Caption = "Message On SMS"
        Me.chkSalesMsgOnAutoSMS.Size = New System.Drawing.Size(116, 19)
        Me.chkSalesMsgOnAutoSMS.TabIndex = 54
        '
        'chkSalesMsgOnAutoPrint
        '
        Me.chkSalesMsgOnAutoPrint.Location = New System.Drawing.Point(555, 162)
        Me.chkSalesMsgOnAutoPrint.Name = "chkSalesMsgOnAutoPrint"
        Me.chkSalesMsgOnAutoPrint.Properties.Caption = "Message On Print"
        Me.chkSalesMsgOnAutoPrint.Size = New System.Drawing.Size(116, 19)
        Me.chkSalesMsgOnAutoPrint.TabIndex = 53
        '
        'cmbSalesDefPayMode
        '
        Me.cmbSalesDefPayMode.AutoComplete = True
        Me.cmbSalesDefPayMode.DisplayMember = "Led_Name"
        Me.cmbSalesDefPayMode.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesDefPayMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesDefPayMode.Location = New System.Drawing.Point(152, 82)
        Me.cmbSalesDefPayMode.Name = "cmbSalesDefPayMode"
        Me.cmbSalesDefPayMode.Size = New System.Drawing.Size(136, 21)
        Me.cmbSalesDefPayMode.TabIndex = 11
        Me.cmbSalesDefPayMode.ValueMember = "Led_Key"
        '
        'cmbSalesAllowBillDelete
        '
        Me.cmbSalesAllowBillDelete.AutoComplete = True
        Me.cmbSalesAllowBillDelete.DisplayMember = "Led_Name"
        Me.cmbSalesAllowBillDelete.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesAllowBillDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesAllowBillDelete.Location = New System.Drawing.Point(661, 239)
        Me.cmbSalesAllowBillDelete.Name = "cmbSalesAllowBillDelete"
        Me.cmbSalesAllowBillDelete.Size = New System.Drawing.Size(106, 21)
        Me.cmbSalesAllowBillDelete.TabIndex = 63
        Me.cmbSalesAllowBillDelete.Tag = "Allow Bill Delete"
        Me.cmbSalesAllowBillDelete.ValueMember = "Led_Key"
        '
        'cmbSalesAllowBillUpdate
        '
        Me.cmbSalesAllowBillUpdate.AutoComplete = True
        Me.cmbSalesAllowBillUpdate.DisplayMember = "Led_Name"
        Me.cmbSalesAllowBillUpdate.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesAllowBillUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesAllowBillUpdate.Location = New System.Drawing.Point(433, 239)
        Me.cmbSalesAllowBillUpdate.Name = "cmbSalesAllowBillUpdate"
        Me.cmbSalesAllowBillUpdate.Size = New System.Drawing.Size(106, 21)
        Me.cmbSalesAllowBillUpdate.TabIndex = 61
        Me.cmbSalesAllowBillUpdate.Tag = "Allow Bill Update"
        Me.cmbSalesAllowBillUpdate.ValueMember = "Led_Key"
        '
        'cmbDefSalesCardDiscAccount
        '
        Me.cmbDefSalesCardDiscAccount.AutoComplete = True
        Me.cmbDefSalesCardDiscAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesCardDiscAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesCardDiscAccount.Location = New System.Drawing.Point(152, 54)
        Me.cmbDefSalesCardDiscAccount.Name = "cmbDefSalesCardDiscAccount"
        Me.cmbDefSalesCardDiscAccount.Size = New System.Drawing.Size(136, 21)
        Me.cmbDefSalesCardDiscAccount.TabIndex = 3
        Me.cmbDefSalesCardDiscAccount.ValueMember = "Led_Key"
        '
        'chkSalesPrnOnSave
        '
        Me.chkSalesPrnOnSave.Location = New System.Drawing.Point(325, 162)
        Me.chkSalesPrnOnSave.Name = "chkSalesPrnOnSave"
        Me.chkSalesPrnOnSave.Properties.Caption = "Auto Print on save"
        Me.chkSalesPrnOnSave.Size = New System.Drawing.Size(114, 19)
        Me.chkSalesPrnOnSave.TabIndex = 42
        '
        'chkSalesMergeDupBarcode
        '
        Me.chkSalesMergeDupBarcode.Location = New System.Drawing.Point(325, 212)
        Me.chkSalesMergeDupBarcode.Name = "chkSalesMergeDupBarcode"
        Me.chkSalesMergeDupBarcode.Properties.Caption = "Merge Duplicate Barcode"
        Me.chkSalesMergeDupBarcode.Size = New System.Drawing.Size(150, 19)
        Me.chkSalesMergeDupBarcode.TabIndex = 45
        '
        'chkSalesRestrictBillChgAfterPrint
        '
        Me.chkSalesRestrictBillChgAfterPrint.Location = New System.Drawing.Point(325, 188)
        Me.chkSalesRestrictBillChgAfterPrint.Name = "chkSalesRestrictBillChgAfterPrint"
        Me.chkSalesRestrictBillChgAfterPrint.Properties.Caption = "Restrict Bill Change After Print"
        Me.chkSalesRestrictBillChgAfterPrint.Size = New System.Drawing.Size(176, 19)
        Me.chkSalesRestrictBillChgAfterPrint.TabIndex = 44
        '
        'chkSalesLockBillDiscount
        '
        Me.chkSalesLockBillDiscount.Location = New System.Drawing.Point(325, 87)
        Me.chkSalesLockBillDiscount.Name = "chkSalesLockBillDiscount"
        Me.chkSalesLockBillDiscount.Properties.Caption = "Lock Bill Discount"
        Me.chkSalesLockBillDiscount.Size = New System.Drawing.Size(106, 19)
        Me.chkSalesLockBillDiscount.TabIndex = 40
        '
        'chkSalesLockSalesRt
        '
        Me.chkSalesLockSalesRt.Location = New System.Drawing.Point(325, 62)
        Me.chkSalesLockSalesRt.Name = "chkSalesLockSalesRt"
        Me.chkSalesLockSalesRt.Properties.Caption = "Lock Sale Rate"
        Me.chkSalesLockSalesRt.Size = New System.Drawing.Size(96, 19)
        Me.chkSalesLockSalesRt.TabIndex = 39
        '
        'chkSalesAutoSMSBill
        '
        Me.chkSalesAutoSMSBill.Location = New System.Drawing.Point(324, 111)
        Me.chkSalesAutoSMSBill.Name = "chkSalesAutoSMSBill"
        Me.chkSalesAutoSMSBill.Properties.Caption = "Auto SMS Bill"
        Me.chkSalesAutoSMSBill.Size = New System.Drawing.Size(98, 19)
        Me.chkSalesAutoSMSBill.TabIndex = 43
        '
        'chkSalesAskForBill
        '
        Me.chkSalesAskForBill.Location = New System.Drawing.Point(554, 38)
        Me.chkSalesAskForBill.Name = "chkSalesAskForBill"
        Me.chkSalesAskForBill.Properties.Caption = "Ask For Bill"
        Me.chkSalesAskForBill.Size = New System.Drawing.Size(84, 19)
        Me.chkSalesAskForBill.TabIndex = 49
        '
        'chkSalesExchAgainstBill
        '
        Me.chkSalesExchAgainstBill.Location = New System.Drawing.Point(325, 37)
        Me.chkSalesExchAgainstBill.Name = "chkSalesExchAgainstBill"
        Me.chkSalesExchAgainstBill.Properties.Caption = "Exchange against bill"
        Me.chkSalesExchAgainstBill.Size = New System.Drawing.Size(126, 19)
        Me.chkSalesExchAgainstBill.TabIndex = 38
        '
        'chkSalesAllowBkDtBillPrn
        '
        Me.chkSalesAllowBkDtBillPrn.Location = New System.Drawing.Point(325, 137)
        Me.chkSalesAllowBkDtBillPrn.Name = "chkSalesAllowBkDtBillPrn"
        Me.chkSalesAllowBkDtBillPrn.Properties.Caption = "Allow back date bill print"
        Me.chkSalesAllowBkDtBillPrn.Size = New System.Drawing.Size(148, 19)
        Me.chkSalesAllowBkDtBillPrn.TabIndex = 41
        '
        'chkSalesAutoRdOff
        '
        Me.chkSalesAutoRdOff.Location = New System.Drawing.Point(554, 63)
        Me.chkSalesAutoRdOff.Name = "chkSalesAutoRdOff"
        Me.chkSalesAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkSalesAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkSalesAutoRdOff.TabIndex = 52
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(5, 121)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(107, 14)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "No Of Items In Bill"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 190)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 14)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "Copies to print (Max 3)"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(5, 158)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(128, 14)
        Me.Label58.TabIndex = 18
        Me.Label58.Text = "Invoice Heading(Print)"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(554, 242)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(100, 14)
        Me.Label66.TabIndex = 62
        Me.Label66.Text = "Allow Bill Delete"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 14)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Card Disc A/c"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(322, 242)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(103, 14)
        Me.Label65.TabIndex = 60
        Me.Label65.Text = "Allow Bill Update"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(5, 85)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(103, 14)
        Me.Label39.TabIndex = 10
        Me.Label39.Text = "Default Pay Mode"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(5, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 14)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Def Customer"
        '
        'pnlOptions
        '
        Me.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOptions.Controls.Add(Me.SimpleButton2)
        Me.pnlOptions.Controls.Add(Me.SimpleButton1)
        Me.pnlOptions.Controls.Add(Me.pnlSelectOption)
        Me.pnlOptions.Controls.Add(Me.lstMain)
        Me.pnlOptions.Controls.Add(Me.btnCloseOption)
        Me.pnlOptions.Controls.Add(Me.Label6)
        Me.pnlOptions.Location = New System.Drawing.Point(202, 220)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(297, 254)
        Me.pnlOptions.TabIndex = 6
        Me.pnlOptions.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(93, 212)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(66, 26)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Delete All"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(20, 212)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(59, 26)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Save"
        '
        'pnlSelectOption
        '
        Me.pnlSelectOption.Controls.Add(Me.txtKeyword)
        Me.pnlSelectOption.Controls.Add(Me.Label11)
        Me.pnlSelectOption.Controls.Add(Me.lstOption1)
        Me.pnlSelectOption.Controls.Add(Me.btnGrp1)
        Me.pnlSelectOption.Controls.Add(Me.btnDown)
        Me.pnlSelectOption.Controls.Add(Me.btnDelGrp1)
        Me.pnlSelectOption.Controls.Add(Me.btnUp)
        Me.pnlSelectOption.Location = New System.Drawing.Point(105, 29)
        Me.pnlSelectOption.Name = "pnlSelectOption"
        Me.pnlSelectOption.Size = New System.Drawing.Size(186, 177)
        Me.pnlSelectOption.TabIndex = 1
        '
        'txtKeyword
        '
        Me.txtKeyword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyword.Location = New System.Drawing.Point(11, 130)
        Me.txtKeyword.MaxLength = 50
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(40, 21)
        Me.txtKeyword.TabIndex = 79
        Me.txtKeyword.Tag = "Page Size"
        Me.txtKeyword.Text = "-->"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Keyword"
        '
        'lstOption1
        '
        Me.lstOption1.AllowDrop = True
        Me.lstOption1.FormattingEnabled = True
        Me.lstOption1.ItemHeight = 14
        Me.lstOption1.Location = New System.Drawing.Point(68, 2)
        Me.lstOption1.Name = "lstOption1"
        Me.lstOption1.Size = New System.Drawing.Size(106, 158)
        Me.lstOption1.TabIndex = 1
        '
        'btnGrp1
        '
        Me.btnGrp1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrp1.Appearance.Options.UseFont = True
        Me.btnGrp1.Location = New System.Drawing.Point(5, 2)
        Me.btnGrp1.Name = "btnGrp1"
        Me.btnGrp1.Size = New System.Drawing.Size(53, 22)
        Me.btnGrp1.TabIndex = 0
        Me.btnGrp1.Text = ">>"
        '
        'btnDown
        '
        Me.btnDown.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Appearance.Options.UseFont = True
        Me.btnDown.Location = New System.Drawing.Point(5, 54)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(53, 18)
        Me.btnDown.TabIndex = 13
        Me.btnDown.Text = "v"
        '
        'btnDelGrp1
        '
        Me.btnDelGrp1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelGrp1.Appearance.Options.UseFont = True
        Me.btnDelGrp1.Location = New System.Drawing.Point(4, 87)
        Me.btnDelGrp1.Name = "btnDelGrp1"
        Me.btnDelGrp1.Size = New System.Drawing.Size(55, 22)
        Me.btnDelGrp1.TabIndex = 2
        Me.btnDelGrp1.Text = "Delete"
        '
        'btnUp
        '
        Me.btnUp.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Appearance.Options.UseFont = True
        Me.btnUp.Location = New System.Drawing.Point(5, 30)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(53, 18)
        Me.btnUp.TabIndex = 12
        Me.btnUp.Text = "^"
        '
        'lstMain
        '
        Me.lstMain.AllowDrop = True
        Me.lstMain.FormattingEnabled = True
        Me.lstMain.ItemHeight = 14
        Me.lstMain.Items.AddRange(New Object() {"SubGroup", "Brand", "Product", "Type", "Shade", "Size", "Sales Rate", "Quantity", "Barcode", "Design", "Supl Dsgn"})
        Me.lstMain.Location = New System.Drawing.Point(2, 29)
        Me.lstMain.Name = "lstMain"
        Me.lstMain.Size = New System.Drawing.Size(101, 158)
        Me.lstMain.TabIndex = 0
        '
        'btnCloseOption
        '
        Me.btnCloseOption.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseOption.Appearance.Options.UseFont = True
        Me.btnCloseOption.Location = New System.Drawing.Point(165, 212)
        Me.btnCloseOption.Name = "btnCloseOption"
        Me.btnCloseOption.Size = New System.Drawing.Size(75, 26)
        Me.btnCloseOption.TabIndex = 2
        Me.btnCloseOption.Text = "Close"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Options"
        '
        'grpWholeSaleBill
        '
        Me.grpWholeSaleBill.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWholeSaleBill.AppearanceCaption.Options.UseFont = True
        Me.grpWholeSaleBill.AppearanceCaption.Options.UseTextOptions = True
        Me.grpWholeSaleBill.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpWholeSaleBill.Controls.Add(Me.txtInvoiceHeadingWithoutVATNo)
        Me.grpWholeSaleBill.Controls.Add(Me.Label4)
        Me.grpWholeSaleBill.Controls.Add(Me.txtInvoiceHeadingForVATNo)
        Me.grpWholeSaleBill.Controls.Add(Me.Label23)
        Me.grpWholeSaleBill.Location = New System.Drawing.Point(204, 45)
        Me.grpWholeSaleBill.LookAndFeel.SkinName = "Money Twins"
        Me.grpWholeSaleBill.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpWholeSaleBill.Name = "grpWholeSaleBill"
        Me.grpWholeSaleBill.Size = New System.Drawing.Size(385, 221)
        Me.grpWholeSaleBill.TabIndex = 86
        Me.grpWholeSaleBill.Text = "Whole Sale Bill"
        Me.grpWholeSaleBill.Visible = False
        '
        'txtInvoiceHeadingWithoutVATNo
        '
        Me.txtInvoiceHeadingWithoutVATNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceHeadingWithoutVATNo.Location = New System.Drawing.Point(207, 65)
        Me.txtInvoiceHeadingWithoutVATNo.MaxLength = 50
        Me.txtInvoiceHeadingWithoutVATNo.Name = "txtInvoiceHeadingWithoutVATNo"
        Me.txtInvoiceHeadingWithoutVATNo.Size = New System.Drawing.Size(149, 21)
        Me.txtInvoiceHeadingWithoutVATNo.TabIndex = 21
        Me.txtInvoiceHeadingWithoutVATNo.Tag = "Invoice Head On Print"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Invoice Heading Without VAT No"
        '
        'txtInvoiceHeadingForVATNo
        '
        Me.txtInvoiceHeadingForVATNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceHeadingForVATNo.Location = New System.Drawing.Point(207, 38)
        Me.txtInvoiceHeadingForVATNo.MaxLength = 50
        Me.txtInvoiceHeadingForVATNo.Name = "txtInvoiceHeadingForVATNo"
        Me.txtInvoiceHeadingForVATNo.Size = New System.Drawing.Size(149, 21)
        Me.txtInvoiceHeadingForVATNo.TabIndex = 19
        Me.txtInvoiceHeadingForVATNo.Tag = "Invoice Head On Print"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 14)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Invoice Heading for VAT No"
        '
        'grpPurchaseRtn
        '
        Me.grpPurchaseRtn.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPurchaseRtn.AppearanceCaption.Options.UseFont = True
        Me.grpPurchaseRtn.AppearanceCaption.Options.UseTextOptions = True
        Me.grpPurchaseRtn.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpPurchaseRtn.Controls.Add(Me.chkPurRtnSupplierSpecificPurRtn)
        Me.grpPurchaseRtn.Controls.Add(Me.chkPurRtnAutoRdOff)
        Me.grpPurchaseRtn.Location = New System.Drawing.Point(258, 34)
        Me.grpPurchaseRtn.LookAndFeel.SkinName = "Money Twins"
        Me.grpPurchaseRtn.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpPurchaseRtn.Name = "grpPurchaseRtn"
        Me.grpPurchaseRtn.Size = New System.Drawing.Size(248, 206)
        Me.grpPurchaseRtn.TabIndex = 2
        Me.grpPurchaseRtn.Text = "Purchase Return"
        Me.grpPurchaseRtn.Visible = False
        '
        'chkPurRtnSupplierSpecificPurRtn
        '
        Me.chkPurRtnSupplierSpecificPurRtn.Location = New System.Drawing.Point(30, 97)
        Me.chkPurRtnSupplierSpecificPurRtn.Name = "chkPurRtnSupplierSpecificPurRtn"
        Me.chkPurRtnSupplierSpecificPurRtn.Properties.Caption = "Supplier Specific Pur Rtn"
        Me.chkPurRtnSupplierSpecificPurRtn.Size = New System.Drawing.Size(139, 19)
        Me.chkPurRtnSupplierSpecificPurRtn.TabIndex = 2
        '
        'chkPurRtnAutoRdOff
        '
        Me.chkPurRtnAutoRdOff.Location = New System.Drawing.Point(30, 68)
        Me.chkPurRtnAutoRdOff.Name = "chkPurRtnAutoRdOff"
        Me.chkPurRtnAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkPurRtnAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkPurRtnAutoRdOff.TabIndex = 2
        '
        'grpPurchase
        '
        Me.grpPurchase.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPurchase.AppearanceCaption.Options.UseFont = True
        Me.grpPurchase.AppearanceCaption.Options.UseTextOptions = True
        Me.grpPurchase.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpPurchase.Controls.Add(Me.chkPMessageOnPrintBarcode)
        Me.grpPurchase.Controls.Add(Me.chkAutoBarcodePrintonSave)
        Me.grpPurchase.Controls.Add(Me.txtPurBarcodePrinterName)
        Me.grpPurchase.Controls.Add(Me.Label71)
        Me.grpPurchase.Controls.Add(Me.txtPurBarcodePageSize)
        Me.grpPurchase.Controls.Add(Me.Label70)
        Me.grpPurchase.Controls.Add(Me.chkPurPickLastPurRate)
        Me.grpPurchase.Controls.Add(Me.chkPurAllowZeroValue)
        Me.grpPurchase.Controls.Add(Me.chkPurAutoRdOff)
        Me.grpPurchase.Location = New System.Drawing.Point(193, 48)
        Me.grpPurchase.LookAndFeel.SkinName = "Money Twins"
        Me.grpPurchase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpPurchase.Name = "grpPurchase"
        Me.grpPurchase.Size = New System.Drawing.Size(308, 283)
        Me.grpPurchase.TabIndex = 1
        Me.grpPurchase.Text = "Purchase"
        Me.grpPurchase.Visible = False
        '
        'chkPMessageOnPrintBarcode
        '
        Me.chkPMessageOnPrintBarcode.Location = New System.Drawing.Point(9, 225)
        Me.chkPMessageOnPrintBarcode.Name = "chkPMessageOnPrintBarcode"
        Me.chkPMessageOnPrintBarcode.Properties.Caption = "Message On Print Barcode"
        Me.chkPMessageOnPrintBarcode.Size = New System.Drawing.Size(170, 19)
        Me.chkPMessageOnPrintBarcode.TabIndex = 17
        '
        'chkAutoBarcodePrintonSave
        '
        Me.chkAutoBarcodePrintonSave.Location = New System.Drawing.Point(9, 200)
        Me.chkAutoBarcodePrintonSave.Name = "chkAutoBarcodePrintonSave"
        Me.chkAutoBarcodePrintonSave.Properties.Caption = "Auto Barcode Print on Save"
        Me.chkAutoBarcodePrintonSave.Size = New System.Drawing.Size(179, 19)
        Me.chkAutoBarcodePrintonSave.TabIndex = 16
        '
        'txtPurBarcodePrinterName
        '
        Me.txtPurBarcodePrinterName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurBarcodePrinterName.Location = New System.Drawing.Point(122, 142)
        Me.txtPurBarcodePrinterName.MaxLength = 50
        Me.txtPurBarcodePrinterName.Name = "txtPurBarcodePrinterName"
        Me.txtPurBarcodePrinterName.Size = New System.Drawing.Size(164, 21)
        Me.txtPurBarcodePrinterName.TabIndex = 13
        Me.txtPurBarcodePrinterName.Tag = "Printer Name"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(8, 146)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(111, 13)
        Me.Label71.TabIndex = 12
        Me.Label71.Text = "Barcode Printer Name"
        '
        'txtPurBarcodePageSize
        '
        Me.txtPurBarcodePageSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurBarcodePageSize.Location = New System.Drawing.Point(121, 168)
        Me.txtPurBarcodePageSize.MaxLength = 50
        Me.txtPurBarcodePageSize.Name = "txtPurBarcodePageSize"
        Me.txtPurBarcodePageSize.Size = New System.Drawing.Size(164, 21)
        Me.txtPurBarcodePageSize.TabIndex = 15
        Me.txtPurBarcodePageSize.Tag = "Page Size"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(8, 172)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(95, 13)
        Me.Label70.TabIndex = 14
        Me.Label70.Text = "Barcode Page Size"
        '
        'chkPurPickLastPurRate
        '
        Me.chkPurPickLastPurRate.Location = New System.Drawing.Point(5, 66)
        Me.chkPurPickLastPurRate.Name = "chkPurPickLastPurRate"
        Me.chkPurPickLastPurRate.Properties.Caption = "Pick Last Purchase Rt"
        Me.chkPurPickLastPurRate.Size = New System.Drawing.Size(133, 19)
        Me.chkPurPickLastPurRate.TabIndex = 8
        '
        'chkPurAllowZeroValue
        '
        Me.chkPurAllowZeroValue.Location = New System.Drawing.Point(5, 91)
        Me.chkPurAllowZeroValue.Name = "chkPurAllowZeroValue"
        Me.chkPurAllowZeroValue.Properties.Caption = "Allow Zero Value"
        Me.chkPurAllowZeroValue.Size = New System.Drawing.Size(103, 19)
        Me.chkPurAllowZeroValue.TabIndex = 10
        '
        'chkPurAutoRdOff
        '
        Me.chkPurAutoRdOff.Location = New System.Drawing.Point(6, 42)
        Me.chkPurAutoRdOff.Name = "chkPurAutoRdOff"
        Me.chkPurAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkPurAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkPurAutoRdOff.TabIndex = 7
        '
        'grpSalesRtn
        '
        Me.grpSalesRtn.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSalesRtn.AppearanceCaption.Options.UseFont = True
        Me.grpSalesRtn.AppearanceCaption.Options.UseTextOptions = True
        Me.grpSalesRtn.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpSalesRtn.Controls.Add(Me.Label61)
        Me.grpSalesRtn.Controls.Add(Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn)
        Me.grpSalesRtn.Controls.Add(Me.Label63)
        Me.grpSalesRtn.Controls.Add(Me.cmbDefSalesRtnCardDiscAccount)
        Me.grpSalesRtn.Controls.Add(Me.cmbDefSalesRtnCust)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnMsgOnAutoPrint)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnPrnOnSave)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnAllowRtnWOSales)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnAutoRdOff)
        Me.grpSalesRtn.Controls.Add(Me.Label19)
        Me.grpSalesRtn.Controls.Add(Me.Label22)
        Me.grpSalesRtn.Location = New System.Drawing.Point(227, 36)
        Me.grpSalesRtn.LookAndFeel.SkinName = "Money Twins"
        Me.grpSalesRtn.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpSalesRtn.Name = "grpSalesRtn"
        Me.grpSalesRtn.Size = New System.Drawing.Size(301, 280)
        Me.grpSalesRtn.TabIndex = 3
        Me.grpSalesRtn.Text = "Sales Return"
        Me.grpSalesRtn.Visible = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.Color.Maroon
        Me.Label61.Location = New System.Drawing.Point(215, 91)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(33, 14)
        Me.Label61.TabIndex = 63
        Me.Label61.Text = "Days"
        '
        'txtSalesRtnAcceptLastNDaysInvoiceOnReturn
        '
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.AllowAlphabets = False
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.AllowMoveToNextControl = True
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.EditValue = 0
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Location = New System.Drawing.Point(188, 87)
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Name = "txtSalesRtnAcceptLastNDaysInvoiceOnReturn"
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Size = New System.Drawing.Size(27, 22)
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.TabIndex = 62
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Tag = "Accept Last N Days Invoice On Return"
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(2, 91)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(186, 14)
        Me.Label63.TabIndex = 61
        Me.Label63.Text = "Do not Accept Goods Return After"
        '
        'cmbDefSalesRtnCardDiscAccount
        '
        Me.cmbDefSalesRtnCardDiscAccount.AutoComplete = True
        Me.cmbDefSalesRtnCardDiscAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesRtnCardDiscAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesRtnCardDiscAccount.Location = New System.Drawing.Point(91, 55)
        Me.cmbDefSalesRtnCardDiscAccount.Name = "cmbDefSalesRtnCardDiscAccount"
        Me.cmbDefSalesRtnCardDiscAccount.Size = New System.Drawing.Size(201, 21)
        Me.cmbDefSalesRtnCardDiscAccount.TabIndex = 41
        Me.cmbDefSalesRtnCardDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefSalesRtnCust
        '
        Me.cmbDefSalesRtnCust.AutoComplete = True
        Me.cmbDefSalesRtnCust.DisplayMember = "Led_Name"
        Me.cmbDefSalesRtnCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesRtnCust.Location = New System.Drawing.Point(91, 31)
        Me.cmbDefSalesRtnCust.Name = "cmbDefSalesRtnCust"
        Me.cmbDefSalesRtnCust.Size = New System.Drawing.Size(201, 21)
        Me.cmbDefSalesRtnCust.TabIndex = 38
        Me.cmbDefSalesRtnCust.ValueMember = "Led_Key"
        '
        'chkSalesRtnMsgOnAutoPrint
        '
        Me.chkSalesRtnMsgOnAutoPrint.Location = New System.Drawing.Point(178, 154)
        Me.chkSalesRtnMsgOnAutoPrint.Name = "chkSalesRtnMsgOnAutoPrint"
        Me.chkSalesRtnMsgOnAutoPrint.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalesRtnMsgOnAutoPrint.Properties.Appearance.Options.UseFont = True
        Me.chkSalesRtnMsgOnAutoPrint.Properties.Caption = "Message On Print"
        Me.chkSalesRtnMsgOnAutoPrint.Size = New System.Drawing.Size(117, 19)
        Me.chkSalesRtnMsgOnAutoPrint.TabIndex = 2
        '
        'chkSalesRtnPrnOnSave
        '
        Me.chkSalesRtnPrnOnSave.Location = New System.Drawing.Point(3, 156)
        Me.chkSalesRtnPrnOnSave.Name = "chkSalesRtnPrnOnSave"
        Me.chkSalesRtnPrnOnSave.Properties.Caption = "Auto Print on save"
        Me.chkSalesRtnPrnOnSave.Size = New System.Drawing.Size(114, 19)
        Me.chkSalesRtnPrnOnSave.TabIndex = 2
        '
        'chkSalesRtnAllowRtnWOSales
        '
        Me.chkSalesRtnAllowRtnWOSales.Location = New System.Drawing.Point(3, 128)
        Me.chkSalesRtnAllowRtnWOSales.Name = "chkSalesRtnAllowRtnWOSales"
        Me.chkSalesRtnAllowRtnWOSales.Properties.Caption = "Allow Return w/o Sale Bill"
        Me.chkSalesRtnAllowRtnWOSales.Size = New System.Drawing.Size(161, 19)
        Me.chkSalesRtnAllowRtnWOSales.TabIndex = 2
        '
        'chkSalesRtnAutoRdOff
        '
        Me.chkSalesRtnAutoRdOff.Location = New System.Drawing.Point(178, 129)
        Me.chkSalesRtnAutoRdOff.Name = "chkSalesRtnAutoRdOff"
        Me.chkSalesRtnAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkSalesRtnAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkSalesRtnAutoRdOff.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(2, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 14)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Card Disc A/c"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(2, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 14)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Def Customer"
        '
        'rdWholeSaleBill
        '
        Me.rdWholeSaleBill.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdWholeSaleBill.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdWholeSaleBill.ForeColor = System.Drawing.Color.Navy
        Me.rdWholeSaleBill.Location = New System.Drawing.Point(373, 3)
        Me.rdWholeSaleBill.Name = "rdWholeSaleBill"
        Me.rdWholeSaleBill.Size = New System.Drawing.Size(90, 25)
        Me.rdWholeSaleBill.TabIndex = 5
        Me.rdWholeSaleBill.Text = "Whole Sale Bill"
        Me.rdWholeSaleBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdWholeSaleBill.UseVisualStyleBackColor = True
        '
        'rdSalesRtn
        '
        Me.rdSalesRtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdSalesRtn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSalesRtn.ForeColor = System.Drawing.Color.Navy
        Me.rdSalesRtn.Location = New System.Drawing.Point(281, 3)
        Me.rdSalesRtn.Name = "rdSalesRtn"
        Me.rdSalesRtn.Size = New System.Drawing.Size(90, 25)
        Me.rdSalesRtn.TabIndex = 0
        Me.rdSalesRtn.Text = "Sales Rtn"
        Me.rdSalesRtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdSalesRtn.UseVisualStyleBackColor = True
        '
        'rdSales
        '
        Me.rdSales.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdSales.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSales.ForeColor = System.Drawing.Color.Navy
        Me.rdSales.Location = New System.Drawing.Point(189, 3)
        Me.rdSales.Name = "rdSales"
        Me.rdSales.Size = New System.Drawing.Size(90, 25)
        Me.rdSales.TabIndex = 0
        Me.rdSales.Text = "Sales"
        Me.rdSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdSales.UseVisualStyleBackColor = True
        '
        'rdPurchaseRtn
        '
        Me.rdPurchaseRtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdPurchaseRtn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPurchaseRtn.ForeColor = System.Drawing.Color.Navy
        Me.rdPurchaseRtn.Location = New System.Drawing.Point(97, 3)
        Me.rdPurchaseRtn.Name = "rdPurchaseRtn"
        Me.rdPurchaseRtn.Size = New System.Drawing.Size(90, 25)
        Me.rdPurchaseRtn.TabIndex = 0
        Me.rdPurchaseRtn.Text = "Purchase Rtn"
        Me.rdPurchaseRtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdPurchaseRtn.UseVisualStyleBackColor = True
        '
        'rdPurchase
        '
        Me.rdPurchase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdPurchase.Checked = True
        Me.rdPurchase.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPurchase.ForeColor = System.Drawing.Color.Navy
        Me.rdPurchase.Location = New System.Drawing.Point(5, 3)
        Me.rdPurchase.Name = "rdPurchase"
        Me.rdPurchase.Size = New System.Drawing.Size(90, 25)
        Me.rdPurchase.TabIndex = 0
        Me.rdPurchase.TabStop = True
        Me.rdPurchase.Text = "Purchase"
        Me.rdPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdPurchase.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Location = New System.Drawing.Point(328, 584)
        Me.btnSave.LookAndFeel.SkinName = "Money Twins"
        Me.btnSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 25)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Location = New System.Drawing.Point(417, 584)
        Me.btnCancel.LookAndFeel.SkinName = "Money Twins"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Close"
        '
        'frmSysConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 613)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmSysConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Configuration"
        Me.tabMain.ResumeLayout(False)
        Me.tabPgGeneral.ResumeLayout(False)
        CType(Me.pnlGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGeneral.ResumeLayout(False)
        CType(Me.grpAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAccounts.ResumeLayout(False)
        Me.grpAccounts.PerformLayout()
        CType(Me.cmbDefTreatmentAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMasssageOnPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAutoPrintonSaveReceiptVoucher.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCashAc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRdOffAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesOthChgsAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRtnRdOffAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRtnOthChgsAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRtnDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRtnAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPurRtnRdOffAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPurRtnDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPurRtnAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPurRdOffAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPurDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPurAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaintainBalBillByBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaintainCostCtr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOthers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOthers.ResumeLayout(False)
        Me.grpOthers.PerformLayout()
        CType(Me.chkCopyBackUp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlEmailSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmailSettings.ResumeLayout(False)
        Me.pnlEmailSettings.PerformLayout()
        CType(Me.chkMaintAcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlSMSSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSMSSettings.ResumeLayout(False)
        Me.pnlSMSSettings.PerformLayout()
        CType(Me.cmbCalculateStockOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAutoBackupOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoBackup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisplayImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCompanyInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCompanyInfo.ResumeLayout(False)
        Me.grpCompanyInfo.PerformLayout()
        CType(Me.chkUseMultiSalesperson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPriceLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSystemSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDecInQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefStation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesperson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBarcodeInfo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMaintainStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaintainStock.ResumeLayout(False)
        Me.grpMaintainStock.PerformLayout()
        CType(Me.chkUseBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaintainStk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllowNegativeStk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBarcodeSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpApplyForProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApplyForProduct.ResumeLayout(False)
        Me.grpApplyForProduct.PerformLayout()
        CType(Me.chksup_design.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseOccassion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseSeason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseQuality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseShade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseDesign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProdSeriesTwoDigitPrefix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseTypeNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPgTrans.ResumeLayout(False)
        CType(Me.grpSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        Me.PnlListOptions.ResumeLayout(False)
        Me.PnlListOptions.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.QrCodePanel.ResumeLayout(False)
        Me.QrCodePanel.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        Me.PanelGrid.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.chkAllowfocusonBillDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllowBackDateBillDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllowBackDateBillEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesUseSalesOrderinBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAutoEmailOnBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFocusOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesDisplayLastBillDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAllowBackDtBillCreation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesMsgOnAutoSMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesDefPayMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesAllowBillDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesAllowBillUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesCardDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesMergeDupBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRestrictBillChgAfterPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesLockBillDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesLockSalesRt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAutoSMSBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAskForBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesExchAgainstBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAllowBkDtBillPrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlOptions.PerformLayout()
        Me.pnlSelectOption.ResumeLayout(False)
        Me.pnlSelectOption.PerformLayout()
        CType(Me.grpWholeSaleBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWholeSaleBill.ResumeLayout(False)
        Me.grpWholeSaleBill.PerformLayout()
        CType(Me.grpPurchaseRtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPurchaseRtn.ResumeLayout(False)
        CType(Me.chkPurRtnSupplierSpecificPurRtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPurchase.ResumeLayout(False)
        Me.grpPurchase.PerformLayout()
        CType(Me.chkPMessageOnPrintBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoBarcodePrintonSave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurPickLastPurRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurAllowZeroValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSalesRtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalesRtn.ResumeLayout(False)
        Me.grpSalesRtn.PerformLayout()
        CType(Me.cmbDefSalesRtnCardDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRtnCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnAllowRtnWOSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabPgGeneral As System.Windows.Forms.TabPage
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlGeneral As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents pnlSMSSettings As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSMSPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSMSUser As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents chkAutoBackup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSMS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAllowNegativeStk As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMaintainStk As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtBackupPath As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProdImagePath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProdImgPath As System.Windows.Forms.TextBox
    Friend WithEvents btnReportPath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReportpath As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtAddressOnBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents chkDisplayImage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDefPriceLevel As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefStation As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbBarcode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDecInQty As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesperson As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblDefSalesperson As System.Windows.Forms.Label
    Friend WithEvents chkUseMultiSalesperson As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseTypeNo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseBrand As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpApplyForProduct As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkUseSize As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseShade As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseDesign As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblApplyProduct As System.Windows.Forms.Label
    Friend WithEvents grpMaintainStock As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents chkUseBarcode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbBarcodeSeries As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents grpCompanyInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cmbSystemSeries As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents grpOthers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbAutoBackupOptions As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cmbCalculateStockOn As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents grpAccounts As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents chkMaintainCostCtr As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMaintainBalBillByBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDefPurRdOffAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefPurDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefPurAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDefPurRtnRdOffAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefPurRtnDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefPurRtnAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbDefSalesRtnRdOffAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesRtnOthChgsAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbDefSalesRtnDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesRtnAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbDefSalesRdOffAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesOthChgsAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbDefSalesDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents pnlEmailSettings As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtEmailPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailUser As System.Windows.Forms.TextBox
    Friend WithEvents chkEmail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEmailSenderName As System.Windows.Forms.TextBox
    Friend WithEvents chkCRM As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtBarcodeInfo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcodeInfo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents chkBarcodeInfo2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tabPgTrans As System.Windows.Forms.TabPage
    Friend WithEvents rdSalesRtn As System.Windows.Forms.RadioButton
    Friend WithEvents rdSales As System.Windows.Forms.RadioButton
    Friend WithEvents rdPurchaseRtn As System.Windows.Forms.RadioButton
    Friend WithEvents rdPurchase As System.Windows.Forms.RadioButton
    Friend WithEvents grpSalesRtn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents cmbDefSalesRtnCardDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesRtnCust As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkSalesRtnMsgOnAutoPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnPrnOnSave As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnAllowRtnWOSales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents grpPurchaseRtn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkPurRtnSupplierSpecificPurRtn As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurRtnAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpPurchase As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkPurPickLastPurRate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurAllowZeroValue As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpSales As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTimingFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtMessageOnBill As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceHeadOnPrint As System.Windows.Forms.TextBox
    Friend WithEvents chkSalesAllowBackDtBillCreation As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesMsgOnAutoSMS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesMsgOnAutoPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbSalesDefPayMode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSalesAllowBillDelete As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSalesAllowBillUpdate As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesCardDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkSalesPrnOnSave As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesMergeDupBarcode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRestrictBillChgAfterPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesLockBillDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesLockSalesRt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAutoSMSBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAskForBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesExchAgainstBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAllowBkDtBillPrn As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbCashAc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents chkMaintAcc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSMSCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtSalesPrinterName As System.Windows.Forms.TextBox
    Friend WithEvents lblPrinterName As System.Windows.Forms.Label
    Friend WithEvents txtSalesPageSize As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents chkSalesDisplayLastBillDetails As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbFocusOn As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txtPurBarcodePageSize As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtPurBarcodePrinterName As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents chkSalesAutoEmailOnBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents chkProdSeriesTwoDigitPrefix As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSalesEmailid As System.Windows.Forms.TextBox
    Friend WithEvents chkSalesUseSalesOrderinBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseQuality As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseOccassion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseSeason As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCopyBackUpPath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCopyBackUp As System.Windows.Forms.TextBox
    Friend WithEvents chkCopyBackUp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAllowfocusonBillDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAllowBackDateBillDelete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAllowBackDateBillEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkAutoPrintonSaveReceiptVoucher As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkMasssageOnPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPMessageOnPrintBarcode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAutoBarcodePrintonSave As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rdWholeSaleBill As System.Windows.Forms.RadioButton
    Friend WithEvents grpWholeSaleBill As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtInvoiceHeadingWithoutVATNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceHeadingForVATNo As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lnkseqproduct As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents lstMain As System.Windows.Forms.ListBox
    Friend WithEvents btnCloseOption As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlSelectOption As System.Windows.Forms.Panel
    Friend WithEvents lstOption1 As System.Windows.Forms.ListBox
    Friend WithEvents btnGrp1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelGrp1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chksup_design As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSMSPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSMSUser1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbDefTreatmentAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbDefSalesCust As System.Windows.Forms.ComboBox
    Friend WithEvents lnkMinQty As System.Windows.Forms.LinkLabel
    Friend WithEvents txtDelBackupDays As NumericTextBox.NumericTextBox
    Friend WithEvents txtSalesRtnAcceptLastNDaysInvoiceOnReturn As NumericTextBox.NumericTextBox
    Friend WithEvents txtSalesNoOfCopiesToPrint As NumericTextBox.NumericTextBox
    Friend WithEvents txtSalesNoOfItemsOnBill As NumericTextBox.NumericTextBox
    Friend WithEvents txtTotalNoOfEdit As NumericTextBox.NumericTextBox
    Friend WithEvents PnlListOptions As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lnkSaleGrid As System.Windows.Forms.LinkLabel
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteAllGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGridSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ListBoxTo As System.Windows.Forms.ListBox
    Friend WithEvents btnMoveTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListBoxFrom As System.Windows.Forms.ListBox
    Friend WithEvents btnCloseGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents QrCodePanel As System.Windows.Forms.Panel
    Friend WithEvents btnDelAllQr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveQr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ListQrTo As System.Windows.Forms.ListBox
    Friend WithEvents btnMoveQrTo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelQr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListQrFrom As System.Windows.Forms.ListBox
    Friend WithEvents btnCloseQr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lnkQRcodeSeq As System.Windows.Forms.LinkLabel
    Friend WithEvents BtnMinQtyDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnMinQtyUp As DevExpress.XtraEditors.SimpleButton
End Class
