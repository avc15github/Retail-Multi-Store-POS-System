<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.chkWholeSaleBiling = New DevExpress.XtraEditors.CheckEdit
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
        Me.cmbApplnType = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txtEmailPassword = New System.Windows.Forms.TextBox
        Me.txtEmailSenderName = New System.Windows.Forms.TextBox
        Me.txtEmailUser = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.pnlSMSSettings = New DevExpress.XtraEditors.PanelControl
        Me.txtSMSPassword1 = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.txtSMSUser1 = New System.Windows.Forms.TextBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.txtSMSCompany = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtSMSPassword = New System.Windows.Forms.TextBox
        Me.txtSMSUser = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtBackupPath = New System.Windows.Forms.TextBox
        Me.btnReportPath = New DevExpress.XtraEditors.SimpleButton
        Me.cmbCalculateStockOn = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbStockTransferOn = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txtReportpath = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.btnProdImagePath = New DevExpress.XtraEditors.SimpleButton
        Me.cmbAutoBackupOptions = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtProdImgPath = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.chkAutoBackup = New DevExpress.XtraEditors.CheckEdit
        Me.chkDisplayImage = New DevExpress.XtraEditors.CheckEdit
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.grpCompanyInfo = New DevExpress.XtraEditors.GroupControl
        Me.txtSoftwareName = New System.Windows.Forms.TextBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.txtBarcodeInfo2 = New System.Windows.Forms.TextBox
        Me.txtBarcodeInfo1 = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.chkUseMultiCounter = New DevExpress.XtraEditors.CheckEdit
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
        Me.chkUseMultiBranch = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseMultiLocation = New DevExpress.XtraEditors.CheckEdit
        Me.txtAddressOnBarcode = New System.Windows.Forms.TextBox
        Me.chkAllowMultiPurRate = New DevExpress.XtraEditors.CheckEdit
        Me.chkDayClose = New DevExpress.XtraEditors.CheckEdit
        Me.chkCRM = New DevExpress.XtraEditors.CheckEdit
        Me.chkBarcodeInfo2 = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseMultiPriceLevel = New DevExpress.XtraEditors.CheckEdit
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.grpMaintainStock = New DevExpress.XtraEditors.GroupControl
        Me.pnlStockAlerts = New System.Windows.Forms.Panel
        Me.rdStockMin = New System.Windows.Forms.RadioButton
        Me.rdStockReorder = New System.Windows.Forms.RadioButton
        Me.rdStockMax = New System.Windows.Forms.RadioButton
        Me.chkRackWiseStock = New DevExpress.XtraEditors.CheckEdit
        Me.Label50 = New System.Windows.Forms.Label
        Me.chkStockAlerts = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseBarcode = New DevExpress.XtraEditors.CheckEdit
        Me.chkMaintainStk = New DevExpress.XtraEditors.CheckEdit
        Me.chkAllowNegativeStk = New DevExpress.XtraEditors.CheckEdit
        Me.cmbBarcodeSeries = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbBarcode = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label51 = New System.Windows.Forms.Label
        Me.grpApplyForProduct = New DevExpress.XtraEditors.GroupControl
        Me.chkUseSize = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseShade = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseDesign = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseBrand = New DevExpress.XtraEditors.CheckEdit
        Me.chkGenBarcodeOnStyleCreation = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseMfgDt = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseOccassion = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseQuality = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseSeason = New DevExpress.XtraEditors.CheckEdit
        Me.lblApplyProduct = New System.Windows.Forms.Label
        Me.chkUseExpiryDate = New DevExpress.XtraEditors.CheckEdit
        Me.chkProdSeriesTwoDigitPrefix = New DevExpress.XtraEditors.CheckEdit
        Me.chkAutoGenCode = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseItemCode = New DevExpress.XtraEditors.CheckEdit
        Me.chkProductMeasure = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseTypeNo = New DevExpress.XtraEditors.CheckEdit
        Me.chkUseSizeWiseRate = New DevExpress.XtraEditors.CheckEdit
        Me.tabPgTrans = New System.Windows.Forms.TabPage
        Me.grpPurchase = New DevExpress.XtraEditors.GroupControl
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.pnlSelectOption = New System.Windows.Forms.Panel
        Me.lstOption1 = New System.Windows.Forms.ListBox
        Me.btnGrp1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnCloseOption = New DevExpress.XtraEditors.SimpleButton
        Me.btnDown = New DevExpress.XtraEditors.SimpleButton
        Me.btnDelGrp1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnUp = New DevExpress.XtraEditors.SimpleButton
        Me.lstMain = New System.Windows.Forms.ListBox
        Me.lnkseqproduct = New System.Windows.Forms.LinkLabel
        Me.chkLanding_cc = New DevExpress.XtraEditors.CheckEdit
        Me.chkDisplayWayBillNoAndEntryTex = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurDisplayStockUpdate = New DevExpress.XtraEditors.CheckEdit
        Me.chkDisplaySalesOrderInPurchase = New DevExpress.XtraEditors.CheckEdit
        Me.txtPurBarcodePrinterName = New System.Windows.Forms.TextBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.txtPurBarcodePageSize = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.txtPurDigit = New NumericTextBox.NumericTextBox
        Me.txtPurDocStartNo = New System.Windows.Forms.TextBox
        Me.cmbPurNoSystem = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkPurDayClose = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurAllowMultiplePurRate = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurPickLastPurRate = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurAllowZeroValue = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurUseSeries = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.grpSalesRtn = New DevExpress.XtraEditors.GroupControl
        Me.chkSalesRtnPickLastSalePersonWOBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnCheckSoldStatus = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnPickLastSaleDiscWOBill = New DevExpress.XtraEditors.CheckEdit
        Me.Label61 = New System.Windows.Forms.Label
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn = New NumericTextBox.NumericTextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.txtSalesRtnDigit = New NumericTextBox.NumericTextBox
        Me.txtSalesRtnDocStartNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbSalesRtnNoSystem = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesRtnCardDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesRtnCust = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkSalesRtnDayClose = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnMsgOnAutoPrint = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnPrnOnSave = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnAllowRtnWOSales = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnUseSeries = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRtnAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.grpPurchaseRtn = New DevExpress.XtraEditors.GroupControl
        Me.txtPurRtnDigit = New NumericTextBox.NumericTextBox
        Me.txtPurRtnDocStartNo = New System.Windows.Forms.TextBox
        Me.cmbPurRtnNoSystem = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkPurRtnDayClose = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurRtnUseSeries = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurRtnLocWiseStockCheck = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurRtnSupplierSpecificPurRtn = New DevExpress.XtraEditors.CheckEdit
        Me.chkPurRtnAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdSalesRtn = New System.Windows.Forms.RadioButton
        Me.rdSales = New System.Windows.Forms.RadioButton
        Me.rdPurchaseRtn = New System.Windows.Forms.RadioButton
        Me.rdPurchase = New System.Windows.Forms.RadioButton
        Me.grpSales = New DevExpress.XtraEditors.GroupControl
        Me.GrpMoreFeatures = New DevExpress.XtraEditors.GroupControl
        Me.btnCloseGrpOptionsFeaturs = New DevExpress.XtraEditors.SimpleButton
        Me.ChkMsgOnEmailSend = New DevExpress.XtraEditors.CheckEdit
        Me.ChkAutoBillSendOnEmail = New DevExpress.XtraEditors.CheckEdit
        Me.ChkAutoSendBillOnWhatsApp = New DevExpress.XtraEditors.CheckEdit
        Me.ChkMsgOnBillSendWhatsApp = New DevExpress.XtraEditors.CheckEdit
        Me.lnkFeatues = New System.Windows.Forms.LinkLabel
        Me.chkCreateBarcodeOption = New DevExpress.XtraEditors.CheckEdit
        Me.chkMessageOnSeriesChangeOption = New DevExpress.XtraEditors.CheckEdit
        Me.chkSeriesChangeOption = New DevExpress.XtraEditors.CheckEdit
        Me.txtSalesEmailid = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.chkSalesAutoEmailOnBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesUseSalesOrderinBill = New DevExpress.XtraEditors.CheckEdit
        Me.cmbFocusOn = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label69 = New System.Windows.Forms.Label
        Me.chkSalesDisplayTodaySales = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesDisplayLastBillDetails = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesUseCoupon = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesDisplayDeliveryDetail = New DevExpress.XtraEditors.CheckEdit
        Me.ChkSalesDisplayHold = New DevExpress.XtraEditors.CheckEdit
        Me.ChkSalesDisplayPrintName = New DevExpress.XtraEditors.CheckEdit
        Me.txtSalesPageSize = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.txtSalesPrinterName = New System.Windows.Forms.TextBox
        Me.lblPrinterName = New System.Windows.Forms.Label
        Me.chkSalesApplySchemeinExchWOBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesPickLastSalePersonWOBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesCheckSoldStatus = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesPickLastSaleDiscinExchWOBill = New DevExpress.XtraEditors.CheckEdit
        Me.txtSalesDeliveryDays = New NumericTextBox.NumericTextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.chkSalesCarryforwardSalePersonAtItemLevel = New DevExpress.XtraEditors.CheckEdit
        Me.txtTimingFrom = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.txtMessageOnBill = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.txtSalesNoOfCopiesToPrint = New NumericTextBox.NumericTextBox
        Me.txtSalesNoOfItemsOnBill = New NumericTextBox.NumericTextBox
        Me.txtSalesDigit = New NumericTextBox.NumericTextBox
        Me.txtInvoiceHeadOnPrint = New System.Windows.Forms.TextBox
        Me.txtSalesDocStartNo = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.chkSalesAllowBackDtBillCreation = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesMsgOnAutoSMS = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesMsgOnAutoPrint = New DevExpress.XtraEditors.CheckEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbSalesDefPayMode = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSalesShowItemSelList = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSalesAllowBillDelete = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSalesAllowBillUpdate = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSalesToBeBilledOn = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbSalesNoSystem = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesCardDiscAccount = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmbDefSalesCust = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.chkSalesDisplayImageOnBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesDayClose = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesPrnOnSave = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesLocationWiseStockCheck = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesChkCrLimitOnCrSale = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesUseSeries = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesCtrWiseSeries = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesMergeDupBarcode = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesRestrictBillChgAfterPrint = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesLockBillDiscount = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesLockManualDiscount = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesLockSalesRt = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAllowZeroValueEntry = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesSchemeBillWiseDisc = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesSchemeItemWiseDisc = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesSchemeDisc = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAutoSMSBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAskForBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesExchAgainstBill = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAllowBkDtBillPrn = New DevExpress.XtraEditors.CheckEdit
        Me.chkSalesAutoRdOff = New DevExpress.XtraEditors.CheckEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.ChkDisplayAllOptionsInBill = New DevExpress.XtraEditors.CheckEdit
        Me.tabMain.SuspendLayout()
        Me.tabPgGeneral.SuspendLayout()
        CType(Me.pnlGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGeneral.SuspendLayout()
        CType(Me.grpAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAccounts.SuspendLayout()
        CType(Me.chkWholeSaleBiling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.cmbApplnType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlSMSSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSMSSettings.SuspendLayout()
        CType(Me.cmbCalculateStockOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStockTransferOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAutoBackupOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoBackup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisplayImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCompanyInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCompanyInfo.SuspendLayout()
        CType(Me.chkUseMultiCounter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseMultiSalesperson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefPriceLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSystemSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDecInQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefStation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesperson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseMultiBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseMultiLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllowMultiPurRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDayClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBarcodeInfo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseMultiPriceLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMaintainStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaintainStock.SuspendLayout()
        Me.pnlStockAlerts.SuspendLayout()
        CType(Me.chkRackWiseStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStockAlerts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMaintainStk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllowNegativeStk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBarcodeSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpApplyForProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApplyForProduct.SuspendLayout()
        CType(Me.chkUseSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseShade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseDesign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGenBarcodeOnStyleCreation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseMfgDt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseOccassion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseQuality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseSeason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseExpiryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProdSeriesTwoDigitPrefix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoGenCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProductMeasure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseTypeNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUseSizeWiseRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPgTrans.SuspendLayout()
        CType(Me.grpPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPurchase.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.pnlSelectOption.SuspendLayout()
        CType(Me.chkLanding_cc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisplayWayBillNoAndEntryTex.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurDisplayStockUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisplaySalesOrderInPurchase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPurNoSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurDayClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurAllowMultiplePurRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurPickLastPurRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurAllowZeroValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurUseSeries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSalesRtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalesRtn.SuspendLayout()
        CType(Me.chkSalesRtnPickLastSalePersonWOBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnCheckSoldStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnPickLastSaleDiscWOBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesRtnNoSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRtnCardDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesRtnCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnDayClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnAllowRtnWOSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnUseSeries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPurchaseRtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPurchaseRtn.SuspendLayout()
        CType(Me.cmbPurRtnNoSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurRtnDayClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurRtnUseSeries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurRtnLocWiseStockCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurRtnSupplierSpecificPurRtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPurRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSales.SuspendLayout()
        CType(Me.GrpMoreFeatures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpMoreFeatures.SuspendLayout()
        CType(Me.ChkMsgOnEmailSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAutoBillSendOnEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAutoSendBillOnWhatsApp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMsgOnBillSendWhatsApp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCreateBarcodeOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMessageOnSeriesChangeOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeriesChangeOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAutoEmailOnBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesUseSalesOrderinBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFocusOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesDisplayTodaySales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesDisplayLastBillDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesUseCoupon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesDisplayDeliveryDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkSalesDisplayHold.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkSalesDisplayPrintName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesApplySchemeinExchWOBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesPickLastSalePersonWOBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesCheckSoldStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesPickLastSaleDiscinExchWOBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesCarryforwardSalePersonAtItemLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAllowBackDtBillCreation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesMsgOnAutoSMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesDefPayMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesShowItemSelList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesAllowBillDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesAllowBillUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesToBeBilledOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSalesNoSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesCardDiscAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefSalesCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesDisplayImageOnBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesDayClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesLocationWiseStockCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesChkCrLimitOnCrSale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesUseSeries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesCtrWiseSeries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesMergeDupBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesRestrictBillChgAfterPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesLockBillDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesLockManualDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesLockSalesRt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAllowZeroValueEntry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesSchemeBillWiseDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesSchemeItemWiseDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesSchemeDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAutoSMSBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAskForBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesExchAgainstBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAllowBkDtBillPrn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkDisplayAllOptionsInBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabPgGeneral)
        Me.tabMain.Controls.Add(Me.tabPgTrans)
        Me.tabMain.Location = New System.Drawing.Point(3, 5)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(790, 590)
        Me.tabMain.TabIndex = 0
        '
        'tabPgGeneral
        '
        Me.tabPgGeneral.Controls.Add(Me.pnlGeneral)
        Me.tabPgGeneral.Location = New System.Drawing.Point(4, 23)
        Me.tabPgGeneral.Name = "tabPgGeneral"
        Me.tabPgGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPgGeneral.Size = New System.Drawing.Size(782, 563)
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
        Me.pnlGeneral.Location = New System.Drawing.Point(1, 3)
        Me.pnlGeneral.LookAndFeel.SkinName = "Blue"
        Me.pnlGeneral.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(778, 559)
        Me.pnlGeneral.TabIndex = 1
        '
        'grpAccounts
        '
        Me.grpAccounts.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpAccounts.Appearance.Options.UseBackColor = True
        Me.grpAccounts.Controls.Add(Me.chkWholeSaleBiling)
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
        Me.grpAccounts.Location = New System.Drawing.Point(3, 431)
        Me.grpAccounts.LookAndFeel.SkinName = "Blue"
        Me.grpAccounts.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpAccounts.Name = "grpAccounts"
        Me.grpAccounts.ShowCaption = False
        Me.grpAccounts.Size = New System.Drawing.Size(770, 128)
        Me.grpAccounts.TabIndex = 58
        Me.grpAccounts.Text = "GroupControl4"
        '
        'chkWholeSaleBiling
        '
        Me.chkWholeSaleBiling.Location = New System.Drawing.Point(242, 8)
        Me.chkWholeSaleBiling.Name = "chkWholeSaleBiling"
        Me.chkWholeSaleBiling.Properties.Caption = "Whole Sale Biling"
        Me.chkWholeSaleBiling.Size = New System.Drawing.Size(111, 19)
        Me.chkWholeSaleBiling.TabIndex = 58
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
        Me.cmbDefSalesRdOffAccount.Location = New System.Drawing.Point(664, 79)
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
        Me.cmbDefSalesOthChgsAccount.Location = New System.Drawing.Point(487, 79)
        Me.cmbDefSalesOthChgsAccount.Name = "cmbDefSalesOthChgsAccount"
        Me.cmbDefSalesOthChgsAccount.Size = New System.Drawing.Size(103, 22)
        Me.cmbDefSalesOthChgsAccount.TabIndex = 64
        Me.cmbDefSalesOthChgsAccount.ValueMember = "Led_Key"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(601, 84)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Rd Off A/c"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(401, 84)
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
        Me.cmbDefSalesDiscAccount.Location = New System.Drawing.Point(289, 79)
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
        Me.cmbDefSalesAccount.Location = New System.Drawing.Point(83, 79)
        Me.cmbDefSalesAccount.Name = "cmbDefSalesAccount"
        Me.cmbDefSalesAccount.Size = New System.Drawing.Size(119, 22)
        Me.cmbDefSalesAccount.TabIndex = 60
        Me.cmbDefSalesAccount.ValueMember = "Led_Key"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(214, 84)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 13)
        Me.Label28.TabIndex = 58
        Me.Label28.Text = "Discount A/c"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 84)
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
        Me.cmbDefSalesRtnRdOffAccount.Location = New System.Drawing.Point(664, 103)
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
        Me.cmbDefSalesRtnOthChgsAccount.Location = New System.Drawing.Point(487, 103)
        Me.cmbDefSalesRtnOthChgsAccount.Name = "cmbDefSalesRtnOthChgsAccount"
        Me.cmbDefSalesRtnOthChgsAccount.Size = New System.Drawing.Size(103, 22)
        Me.cmbDefSalesRtnOthChgsAccount.TabIndex = 56
        Me.cmbDefSalesRtnOthChgsAccount.ValueMember = "Led_Key"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(601, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Rd Off A/c"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(401, 108)
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
        Me.cmbDefSalesRtnDiscAccount.Location = New System.Drawing.Point(289, 103)
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
        Me.cmbDefSalesRtnAccount.Location = New System.Drawing.Point(83, 103)
        Me.cmbDefSalesRtnAccount.Name = "cmbDefSalesRtnAccount"
        Me.cmbDefSalesRtnAccount.Size = New System.Drawing.Size(119, 22)
        Me.cmbDefSalesRtnAccount.TabIndex = 52
        Me.cmbDefSalesRtnAccount.ValueMember = "Led_Key"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(214, 108)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Discount A/c"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 108)
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
        Me.cmbDefPurRtnRdOffAccount.Location = New System.Drawing.Point(617, 55)
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
        Me.cmbDefPurRtnDiscAccount.Location = New System.Drawing.Point(361, 55)
        Me.cmbDefPurRtnDiscAccount.Name = "cmbDefPurRtnDiscAccount"
        Me.cmbDefPurRtnDiscAccount.Size = New System.Drawing.Size(152, 22)
        Me.cmbDefPurRtnDiscAccount.TabIndex = 48
        Me.cmbDefPurRtnDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefPurRtnAccount
        '
        Me.cmbDefPurRtnAccount.AutoComplete = True
        Me.cmbDefPurRtnAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurRtnAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurRtnAccount.Location = New System.Drawing.Point(83, 55)
        Me.cmbDefPurRtnAccount.Name = "cmbDefPurRtnAccount"
        Me.cmbDefPurRtnAccount.Size = New System.Drawing.Size(157, 22)
        Me.cmbDefPurRtnAccount.TabIndex = 47
        Me.cmbDefPurRtnAccount.ValueMember = "Led_Key"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(554, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Rd Off A/c"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(291, 60)
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
        Me.cmbDefPurRdOffAccount.Location = New System.Drawing.Point(617, 30)
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
        Me.cmbDefPurDiscAccount.Location = New System.Drawing.Point(361, 30)
        Me.cmbDefPurDiscAccount.Name = "cmbDefPurDiscAccount"
        Me.cmbDefPurDiscAccount.Size = New System.Drawing.Size(152, 22)
        Me.cmbDefPurDiscAccount.TabIndex = 42
        Me.cmbDefPurDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefPurAccount
        '
        Me.cmbDefPurAccount.AutoComplete = True
        Me.cmbDefPurAccount.DisplayMember = "Led_Name"
        Me.cmbDefPurAccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefPurAccount.Location = New System.Drawing.Point(83, 30)
        Me.cmbDefPurAccount.Name = "cmbDefPurAccount"
        Me.cmbDefPurAccount.Size = New System.Drawing.Size(157, 22)
        Me.cmbDefPurAccount.TabIndex = 41
        Me.cmbDefPurAccount.ValueMember = "Led_Key"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(554, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Rd Off A/c"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Discount A/c"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 35)
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
        Me.chkMaintainBalBillByBill.Location = New System.Drawing.Point(81, 5)
        Me.chkMaintainBalBillByBill.Name = "chkMaintainBalBillByBill"
        Me.chkMaintainBalBillByBill.Properties.Caption = "Maintain balance bill-by-bill"
        Me.chkMaintainBalBillByBill.Size = New System.Drawing.Size(153, 19)
        Me.chkMaintainBalBillByBill.TabIndex = 22
        '
        'chkMaintainCostCtr
        '
        Me.chkMaintainCostCtr.Location = New System.Drawing.Point(359, 5)
        Me.chkMaintainCostCtr.Name = "chkMaintainCostCtr"
        Me.chkMaintainCostCtr.Properties.Caption = "Maintain Cost Center"
        Me.chkMaintainCostCtr.Size = New System.Drawing.Size(133, 19)
        Me.chkMaintainCostCtr.TabIndex = 22
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
        Me.grpOthers.Controls.Add(Me.cmbStockTransferOn)
        Me.grpOthers.Controls.Add(Me.txtReportpath)
        Me.grpOthers.Controls.Add(Me.Label41)
        Me.grpOthers.Controls.Add(Me.btnProdImagePath)
        Me.grpOthers.Controls.Add(Me.cmbAutoBackupOptions)
        Me.grpOthers.Controls.Add(Me.Label37)
        Me.grpOthers.Controls.Add(Me.Label56)
        Me.grpOthers.Controls.Add(Me.txtProdImgPath)
        Me.grpOthers.Controls.Add(Me.Label55)
        Me.grpOthers.Controls.Add(Me.btnBrowse)
        Me.grpOthers.Controls.Add(Me.chkAutoBackup)
        Me.grpOthers.Controls.Add(Me.chkDisplayImage)
        Me.grpOthers.Controls.Add(Me.Label36)
        Me.grpOthers.Controls.Add(Me.Label48)
        Me.grpOthers.Location = New System.Drawing.Point(3, 282)
        Me.grpOthers.LookAndFeel.SkinName = "Blue"
        Me.grpOthers.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.ShowCaption = False
        Me.grpOthers.Size = New System.Drawing.Size(770, 148)
        Me.grpOthers.TabIndex = 57
        Me.grpOthers.Text = "GroupControl3"
        '
        'btnCopyBackUpPath
        '
        Me.btnCopyBackUpPath.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyBackUpPath.Appearance.Options.UseFont = True
        Me.btnCopyBackUpPath.Location = New System.Drawing.Point(342, 28)
        Me.btnCopyBackUpPath.Name = "btnCopyBackUpPath"
        Me.btnCopyBackUpPath.Size = New System.Drawing.Size(28, 20)
        Me.btnCopyBackUpPath.TabIndex = 67
        Me.btnCopyBackUpPath.Text = "..."
        '
        'txtCopyBackUp
        '
        Me.txtCopyBackUp.BackColor = System.Drawing.Color.White
        Me.txtCopyBackUp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopyBackUp.Location = New System.Drawing.Point(109, 28)
        Me.txtCopyBackUp.Name = "txtCopyBackUp"
        Me.txtCopyBackUp.ReadOnly = True
        Me.txtCopyBackUp.Size = New System.Drawing.Size(229, 21)
        Me.txtCopyBackUp.TabIndex = 65
        Me.txtCopyBackUp.Tag = "CopyBackUp"
        '
        'chkCopyBackUp
        '
        Me.chkCopyBackUp.Location = New System.Drawing.Point(0, 30)
        Me.chkCopyBackUp.Name = "chkCopyBackUp"
        Me.chkCopyBackUp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopyBackUp.Properties.Appearance.Options.UseFont = True
        Me.chkCopyBackUp.Properties.Caption = "Copy BackUp Path"
        Me.chkCopyBackUp.Size = New System.Drawing.Size(111, 19)
        Me.chkCopyBackUp.TabIndex = 66
        '
        'txtDelBackupDays
        '
        Me.txtDelBackupDays.AllowAlphabets = False
        Me.txtDelBackupDays.AllowMoveToNextControl = True
        Me.txtDelBackupDays.EditValue = 0
        Me.txtDelBackupDays.Location = New System.Drawing.Point(109, 51)
        Me.txtDelBackupDays.Name = "txtDelBackupDays"
        Me.txtDelBackupDays.Size = New System.Drawing.Size(21, 22)
        Me.txtDelBackupDays.TabIndex = 61
        Me.txtDelBackupDays.Tag = "Delete Backup After N Days"
        Me.txtDelBackupDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Maroon
        Me.Label54.Location = New System.Drawing.Point(3, 1)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(45, 13)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Others"
        '
        'chkEmail
        '
        Me.chkEmail.Location = New System.Drawing.Point(586, 24)
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
        Me.pnlEmailSettings.Controls.Add(Me.cmbApplnType)
        Me.pnlEmailSettings.Controls.Add(Me.txtEmailPassword)
        Me.pnlEmailSettings.Controls.Add(Me.txtEmailSenderName)
        Me.pnlEmailSettings.Controls.Add(Me.txtEmailUser)
        Me.pnlEmailSettings.Controls.Add(Me.Label64)
        Me.pnlEmailSettings.Location = New System.Drawing.Point(383, 120)
        Me.pnlEmailSettings.LookAndFeel.SkinName = "Blue"
        Me.pnlEmailSettings.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlEmailSettings.Name = "pnlEmailSettings"
        Me.pnlEmailSettings.Size = New System.Drawing.Size(380, 27)
        Me.pnlEmailSettings.TabIndex = 25
        '
        'chkMaintAcc
        '
        Me.chkMaintAcc.Location = New System.Drawing.Point(251, 6)
        Me.chkMaintAcc.Name = "chkMaintAcc"
        Me.chkMaintAcc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaintAcc.Properties.Appearance.Options.UseFont = True
        Me.chkMaintAcc.Properties.Caption = "Maintain Accounts"
        Me.chkMaintAcc.Size = New System.Drawing.Size(119, 19)
        Me.chkMaintAcc.TabIndex = 41
        '
        'cmbApplnType
        '
        Me.cmbApplnType.AutoComplete = True
        Me.cmbApplnType.DisplayMember = "Led_Name"
        Me.cmbApplnType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbApplnType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbApplnType.Location = New System.Drawing.Point(109, 3)
        Me.cmbApplnType.Name = "cmbApplnType"
        Me.cmbApplnType.Size = New System.Drawing.Size(98, 22)
        Me.cmbApplnType.TabIndex = 40
        Me.cmbApplnType.Tag = "Calculate Stock On"
        Me.cmbApplnType.ValueMember = "Led_Key"
        Me.cmbApplnType.Visible = False
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
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(6, 7)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(101, 13)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "Type Of Application"
        Me.Label64.Visible = False
        '
        'pnlSMSSettings
        '
        Me.pnlSMSSettings.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSPassword1)
        Me.pnlSMSSettings.Controls.Add(Me.Label74)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSUser1)
        Me.pnlSMSSettings.Controls.Add(Me.Label73)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSCompany)
        Me.pnlSMSSettings.Controls.Add(Me.Label38)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSPassword)
        Me.pnlSMSSettings.Controls.Add(Me.txtSMSUser)
        Me.pnlSMSSettings.Controls.Add(Me.Label47)
        Me.pnlSMSSettings.Controls.Add(Me.Label46)
        Me.pnlSMSSettings.Location = New System.Drawing.Point(383, 44)
        Me.pnlSMSSettings.LookAndFeel.SkinName = "Blue"
        Me.pnlSMSSettings.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlSMSSettings.Name = "pnlSMSSettings"
        Me.pnlSMSSettings.Size = New System.Drawing.Size(380, 72)
        Me.pnlSMSSettings.TabIndex = 25
        '
        'txtSMSPassword1
        '
        Me.txtSMSPassword1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMSPassword1.Location = New System.Drawing.Point(256, 49)
        Me.txtSMSPassword1.Name = "txtSMSPassword1"
        Me.txtSMSPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMSPassword1.Size = New System.Drawing.Size(118, 21)
        Me.txtSMSPassword1.TabIndex = 7
        Me.txtSMSPassword1.Tag = "SMS Password"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(178, 51)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(59, 13)
        Me.Label74.TabIndex = 6
        Me.Label74.Text = "Password1"
        '
        'txtSMSUser1
        '
        Me.txtSMSUser1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSMSUser1.Location = New System.Drawing.Point(54, 50)
        Me.txtSMSUser1.Name = "txtSMSUser1"
        Me.txtSMSUser1.Size = New System.Drawing.Size(118, 21)
        Me.txtSMSUser1.TabIndex = 5
        Me.txtSMSUser1.Tag = "SMS User"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(2, 54)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(35, 13)
        Me.Label73.TabIndex = 4
        Me.Label73.Text = "User1"
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
        Me.txtBackupPath.Location = New System.Drawing.Point(109, 6)
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
        Me.btnReportPath.Location = New System.Drawing.Point(341, 98)
        Me.btnReportPath.Name = "btnReportPath"
        Me.btnReportPath.Size = New System.Drawing.Size(28, 20)
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
        'cmbStockTransferOn
        '
        Me.cmbStockTransferOn.AutoComplete = True
        Me.cmbStockTransferOn.DisplayMember = "Led_Name"
        Me.cmbStockTransferOn.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbStockTransferOn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStockTransferOn.Location = New System.Drawing.Point(292, 51)
        Me.cmbStockTransferOn.Name = "cmbStockTransferOn"
        Me.cmbStockTransferOn.Size = New System.Drawing.Size(77, 22)
        Me.cmbStockTransferOn.TabIndex = 39
        Me.cmbStockTransferOn.Tag = "Stock Transfer On"
        Me.cmbStockTransferOn.ValueMember = "Led_Key"
        '
        'txtReportpath
        '
        Me.txtReportpath.BackColor = System.Drawing.Color.White
        Me.txtReportpath.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportpath.Location = New System.Drawing.Point(109, 98)
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
        Me.Label41.Location = New System.Drawing.Point(7, 102)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 13)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Report Path"
        '
        'btnProdImagePath
        '
        Me.btnProdImagePath.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdImagePath.Appearance.Options.UseFont = True
        Me.btnProdImagePath.Location = New System.Drawing.Point(341, 74)
        Me.btnProdImagePath.Name = "btnProdImagePath"
        Me.btnProdImagePath.Size = New System.Drawing.Size(28, 20)
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
        Me.Label37.Location = New System.Drawing.Point(7, 15)
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
        Me.txtProdImgPath.Location = New System.Drawing.Point(109, 75)
        Me.txtProdImgPath.Name = "txtProdImgPath"
        Me.txtProdImgPath.ReadOnly = True
        Me.txtProdImgPath.Size = New System.Drawing.Size(229, 21)
        Me.txtProdImgPath.TabIndex = 1
        Me.txtProdImgPath.Tag = "Product Image Path"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(191, 56)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(94, 13)
        Me.Label55.TabIndex = 51
        Me.Label55.Text = "Stock Transfer On"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(342, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(28, 20)
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
        Me.chkDisplayImage.Location = New System.Drawing.Point(7, 77)
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
        Me.Label36.Location = New System.Drawing.Point(7, 56)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 13)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Delete backup after"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(132, 56)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(30, 13)
        Me.Label48.TabIndex = 8
        Me.Label48.Text = "days"
        '
        'grpCompanyInfo
        '
        Me.grpCompanyInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpCompanyInfo.Appearance.Options.UseBackColor = True
        Me.grpCompanyInfo.Controls.Add(Me.txtSoftwareName)
        Me.grpCompanyInfo.Controls.Add(Me.Label72)
        Me.grpCompanyInfo.Controls.Add(Me.txtBarcodeInfo2)
        Me.grpCompanyInfo.Controls.Add(Me.txtBarcodeInfo1)
        Me.grpCompanyInfo.Controls.Add(Me.Label40)
        Me.grpCompanyInfo.Controls.Add(Me.Label52)
        Me.grpCompanyInfo.Controls.Add(Me.chkUseMultiCounter)
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
        Me.grpCompanyInfo.Controls.Add(Me.chkUseMultiBranch)
        Me.grpCompanyInfo.Controls.Add(Me.chkUseMultiLocation)
        Me.grpCompanyInfo.Controls.Add(Me.txtAddressOnBarcode)
        Me.grpCompanyInfo.Controls.Add(Me.chkAllowMultiPurRate)
        Me.grpCompanyInfo.Controls.Add(Me.chkDayClose)
        Me.grpCompanyInfo.Controls.Add(Me.chkCRM)
        Me.grpCompanyInfo.Controls.Add(Me.chkBarcodeInfo2)
        Me.grpCompanyInfo.Controls.Add(Me.chkUseMultiPriceLevel)
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
        'txtSoftwareName
        '
        Me.txtSoftwareName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoftwareName.Location = New System.Drawing.Point(233, 4)
        Me.txtSoftwareName.MaxLength = 20
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(130, 21)
        Me.txtSoftwareName.TabIndex = 0
        Me.txtSoftwareName.Tag = ""
        Me.txtSoftwareName.Text = "Retail"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(148, 5)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(81, 13)
        Me.Label72.TabIndex = 65
        Me.Label72.Text = "Software Name"
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
        'chkUseMultiCounter
        '
        Me.chkUseMultiCounter.Location = New System.Drawing.Point(196, 25)
        Me.chkUseMultiCounter.Name = "chkUseMultiCounter"
        Me.chkUseMultiCounter.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMultiCounter.Properties.Appearance.Options.UseFont = True
        Me.chkUseMultiCounter.Properties.Caption = "Multi Counter"
        Me.chkUseMultiCounter.Size = New System.Drawing.Size(89, 19)
        Me.chkUseMultiCounter.TabIndex = 18
        '
        'chkUseMultiSalesperson
        '
        Me.chkUseMultiSalesperson.Location = New System.Drawing.Point(293, 25)
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
        Me.cmbDefPriceLevel.Location = New System.Drawing.Point(605, -2)
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
        Me.cmbSystemSeries.Location = New System.Drawing.Point(717, 23)
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
        Me.lblDefSalesperson.Location = New System.Drawing.Point(399, 28)
        Me.lblDefSalesperson.Name = "lblDefSalesperson"
        Me.lblDefSalesperson.Size = New System.Drawing.Size(85, 13)
        Me.lblDefSalesperson.TabIndex = 51
        Me.lblDefSalesperson.Text = "Def Salesperson"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(642, 28)
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
        Me.cmbDefSalesperson.Location = New System.Drawing.Point(520, 23)
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
        'chkUseMultiBranch
        '
        Me.chkUseMultiBranch.Location = New System.Drawing.Point(5, 25)
        Me.chkUseMultiBranch.Name = "chkUseMultiBranch"
        Me.chkUseMultiBranch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMultiBranch.Properties.Appearance.Options.UseFont = True
        Me.chkUseMultiBranch.Properties.Caption = "Multi Branch"
        Me.chkUseMultiBranch.Size = New System.Drawing.Size(83, 19)
        Me.chkUseMultiBranch.TabIndex = 18
        '
        'chkUseMultiLocation
        '
        Me.chkUseMultiLocation.Location = New System.Drawing.Point(93, 25)
        Me.chkUseMultiLocation.Name = "chkUseMultiLocation"
        Me.chkUseMultiLocation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMultiLocation.Properties.Appearance.Options.UseFont = True
        Me.chkUseMultiLocation.Properties.Caption = "Multi Location"
        Me.chkUseMultiLocation.Size = New System.Drawing.Size(92, 19)
        Me.chkUseMultiLocation.TabIndex = 18
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
        'chkAllowMultiPurRate
        '
        Me.chkAllowMultiPurRate.Location = New System.Drawing.Point(640, 52)
        Me.chkAllowMultiPurRate.Name = "chkAllowMultiPurRate"
        Me.chkAllowMultiPurRate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllowMultiPurRate.Properties.Appearance.Options.UseFont = True
        Me.chkAllowMultiPurRate.Properties.Caption = "Allow Multiple Pur Rt"
        Me.chkAllowMultiPurRate.Size = New System.Drawing.Size(127, 19)
        Me.chkAllowMultiPurRate.TabIndex = 18
        Me.chkAllowMultiPurRate.Visible = False
        '
        'chkDayClose
        '
        Me.chkDayClose.Location = New System.Drawing.Point(555, 51)
        Me.chkDayClose.Name = "chkDayClose"
        Me.chkDayClose.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDayClose.Properties.Appearance.Options.UseFont = True
        Me.chkDayClose.Properties.Caption = "Day Close"
        Me.chkDayClose.Size = New System.Drawing.Size(76, 19)
        Me.chkDayClose.TabIndex = 18
        '
        'chkCRM
        '
        Me.chkCRM.Location = New System.Drawing.Point(517, 1)
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
        'chkUseMultiPriceLevel
        '
        Me.chkUseMultiPriceLevel.Location = New System.Drawing.Point(399, 50)
        Me.chkUseMultiPriceLevel.Name = "chkUseMultiPriceLevel"
        Me.chkUseMultiPriceLevel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMultiPriceLevel.Properties.Appearance.Options.UseFont = True
        Me.chkUseMultiPriceLevel.Properties.Caption = "Use Multi Price Level"
        Me.chkUseMultiPriceLevel.Size = New System.Drawing.Size(127, 19)
        Me.chkUseMultiPriceLevel.TabIndex = 18
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
        Me.grpMaintainStock.Controls.Add(Me.pnlStockAlerts)
        Me.grpMaintainStock.Controls.Add(Me.chkRackWiseStock)
        Me.grpMaintainStock.Controls.Add(Me.Label50)
        Me.grpMaintainStock.Controls.Add(Me.chkStockAlerts)
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
        Me.grpMaintainStock.Size = New System.Drawing.Size(380, 119)
        Me.grpMaintainStock.TabIndex = 55
        Me.grpMaintainStock.Text = "Apply For Product"
        '
        'pnlStockAlerts
        '
        Me.pnlStockAlerts.Controls.Add(Me.rdStockMin)
        Me.pnlStockAlerts.Controls.Add(Me.rdStockReorder)
        Me.pnlStockAlerts.Controls.Add(Me.rdStockMax)
        Me.pnlStockAlerts.Location = New System.Drawing.Point(93, 90)
        Me.pnlStockAlerts.Name = "pnlStockAlerts"
        Me.pnlStockAlerts.Size = New System.Drawing.Size(252, 24)
        Me.pnlStockAlerts.TabIndex = 43
        '
        'rdStockMin
        '
        Me.rdStockMin.AutoSize = True
        Me.rdStockMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdStockMin.Location = New System.Drawing.Point(15, 3)
        Me.rdStockMin.Name = "rdStockMin"
        Me.rdStockMin.Size = New System.Drawing.Size(60, 17)
        Me.rdStockMin.TabIndex = 42
        Me.rdStockMin.TabStop = True
        Me.rdStockMin.Text = "<= Min"
        Me.rdStockMin.UseVisualStyleBackColor = True
        '
        'rdStockReorder
        '
        Me.rdStockReorder.AutoSize = True
        Me.rdStockReorder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdStockReorder.Location = New System.Drawing.Point(150, 3)
        Me.rdStockReorder.Name = "rdStockReorder"
        Me.rdStockReorder.Size = New System.Drawing.Size(83, 17)
        Me.rdStockReorder.TabIndex = 42
        Me.rdStockReorder.TabStop = True
        Me.rdStockReorder.Text = "<= Reorder"
        Me.rdStockReorder.UseVisualStyleBackColor = True
        '
        'rdStockMax
        '
        Me.rdStockMax.AutoSize = True
        Me.rdStockMax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdStockMax.Location = New System.Drawing.Point(83, 3)
        Me.rdStockMax.Name = "rdStockMax"
        Me.rdStockMax.Size = New System.Drawing.Size(56, 17)
        Me.rdStockMax.TabIndex = 42
        Me.rdStockMax.TabStop = True
        Me.rdStockMax.Text = "> Max"
        Me.rdStockMax.UseVisualStyleBackColor = True
        '
        'chkRackWiseStock
        '
        Me.chkRackWiseStock.Location = New System.Drawing.Point(298, 24)
        Me.chkRackWiseStock.Name = "chkRackWiseStock"
        Me.chkRackWiseStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRackWiseStock.Properties.Appearance.Options.UseFont = True
        Me.chkRackWiseStock.Properties.Caption = "Rack Wise"
        Me.chkRackWiseStock.Size = New System.Drawing.Size(74, 19)
        Me.chkRackWiseStock.TabIndex = 23
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
        'chkStockAlerts
        '
        Me.chkStockAlerts.Location = New System.Drawing.Point(5, 91)
        Me.chkStockAlerts.Name = "chkStockAlerts"
        Me.chkStockAlerts.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStockAlerts.Properties.Appearance.Options.UseFont = True
        Me.chkStockAlerts.Properties.Caption = "Stock Alerts"
        Me.chkStockAlerts.Size = New System.Drawing.Size(87, 19)
        Me.chkStockAlerts.TabIndex = 20
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
        Me.grpApplyForProduct.Controls.Add(Me.chkUseSize)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseShade)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseDesign)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseBrand)
        Me.grpApplyForProduct.Controls.Add(Me.chkGenBarcodeOnStyleCreation)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseMfgDt)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseOccassion)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseQuality)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseSeason)
        Me.grpApplyForProduct.Controls.Add(Me.lblApplyProduct)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseExpiryDate)
        Me.grpApplyForProduct.Controls.Add(Me.chkProdSeriesTwoDigitPrefix)
        Me.grpApplyForProduct.Controls.Add(Me.chkAutoGenCode)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseItemCode)
        Me.grpApplyForProduct.Controls.Add(Me.chkProductMeasure)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseTypeNo)
        Me.grpApplyForProduct.Controls.Add(Me.chkUseSizeWiseRate)
        Me.grpApplyForProduct.Location = New System.Drawing.Point(3, 161)
        Me.grpApplyForProduct.LookAndFeel.SkinName = "Blue"
        Me.grpApplyForProduct.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpApplyForProduct.Name = "grpApplyForProduct"
        Me.grpApplyForProduct.ShowCaption = False
        Me.grpApplyForProduct.Size = New System.Drawing.Size(388, 119)
        Me.grpApplyForProduct.TabIndex = 54
        Me.grpApplyForProduct.Text = "Apply For Product"
        '
        'chkUseSize
        '
        Me.chkUseSize.Location = New System.Drawing.Point(176, 25)
        Me.chkUseSize.Name = "chkUseSize"
        Me.chkUseSize.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseSize.Properties.Appearance.Options.UseFont = True
        Me.chkUseSize.Properties.Caption = "Use Size"
        Me.chkUseSize.Size = New System.Drawing.Size(70, 19)
        Me.chkUseSize.TabIndex = 19
        '
        'chkUseShade
        '
        Me.chkUseShade.Location = New System.Drawing.Point(87, 25)
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
        'chkGenBarcodeOnStyleCreation
        '
        Me.chkGenBarcodeOnStyleCreation.Location = New System.Drawing.Point(176, 3)
        Me.chkGenBarcodeOnStyleCreation.Name = "chkGenBarcodeOnStyleCreation"
        Me.chkGenBarcodeOnStyleCreation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGenBarcodeOnStyleCreation.Properties.Appearance.Options.UseFont = True
        Me.chkGenBarcodeOnStyleCreation.Properties.Caption = "Generate barcode on style creation"
        Me.chkGenBarcodeOnStyleCreation.Size = New System.Drawing.Size(197, 19)
        Me.chkGenBarcodeOnStyleCreation.TabIndex = 22
        Me.chkGenBarcodeOnStyleCreation.Visible = False
        '
        'chkUseMfgDt
        '
        Me.chkUseMfgDt.Location = New System.Drawing.Point(3, 71)
        Me.chkUseMfgDt.Name = "chkUseMfgDt"
        Me.chkUseMfgDt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseMfgDt.Properties.Appearance.Options.UseFont = True
        Me.chkUseMfgDt.Properties.Caption = "Use Mfg Dt"
        Me.chkUseMfgDt.Size = New System.Drawing.Size(76, 19)
        Me.chkUseMfgDt.TabIndex = 22
        '
        'chkUseOccassion
        '
        Me.chkUseOccassion.Location = New System.Drawing.Point(260, 48)
        Me.chkUseOccassion.Name = "chkUseOccassion"
        Me.chkUseOccassion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseOccassion.Properties.Appearance.Options.UseFont = True
        Me.chkUseOccassion.Properties.Caption = "Use Occassion"
        Me.chkUseOccassion.Size = New System.Drawing.Size(103, 19)
        Me.chkUseOccassion.TabIndex = 22
        '
        'chkUseQuality
        '
        Me.chkUseQuality.Location = New System.Drawing.Point(87, 48)
        Me.chkUseQuality.Name = "chkUseQuality"
        Me.chkUseQuality.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseQuality.Properties.Appearance.Options.UseFont = True
        Me.chkUseQuality.Properties.Caption = "Use Quality"
        Me.chkUseQuality.Size = New System.Drawing.Size(86, 19)
        Me.chkUseQuality.TabIndex = 20
        '
        'chkUseSeason
        '
        Me.chkUseSeason.Location = New System.Drawing.Point(176, 48)
        Me.chkUseSeason.Name = "chkUseSeason"
        Me.chkUseSeason.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseSeason.Properties.Appearance.Options.UseFont = True
        Me.chkUseSeason.Properties.Caption = "Use Season"
        Me.chkUseSeason.Size = New System.Drawing.Size(103, 19)
        Me.chkUseSeason.TabIndex = 21
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
        'chkUseExpiryDate
        '
        Me.chkUseExpiryDate.Location = New System.Drawing.Point(87, 71)
        Me.chkUseExpiryDate.Name = "chkUseExpiryDate"
        Me.chkUseExpiryDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseExpiryDate.Properties.Appearance.Options.UseFont = True
        Me.chkUseExpiryDate.Properties.Caption = "Use Expiry Dt"
        Me.chkUseExpiryDate.Size = New System.Drawing.Size(89, 19)
        Me.chkUseExpiryDate.TabIndex = 18
        '
        'chkProdSeriesTwoDigitPrefix
        '
        Me.chkProdSeriesTwoDigitPrefix.Location = New System.Drawing.Point(207, 93)
        Me.chkProdSeriesTwoDigitPrefix.Name = "chkProdSeriesTwoDigitPrefix"
        Me.chkProdSeriesTwoDigitPrefix.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProdSeriesTwoDigitPrefix.Properties.Appearance.Options.UseFont = True
        Me.chkProdSeriesTwoDigitPrefix.Properties.Caption = "Product Series 2 digit as prefix"
        Me.chkProdSeriesTwoDigitPrefix.Size = New System.Drawing.Size(173, 19)
        Me.chkProdSeriesTwoDigitPrefix.TabIndex = 18
        '
        'chkAutoGenCode
        '
        Me.chkAutoGenCode.Location = New System.Drawing.Point(104, 93)
        Me.chkAutoGenCode.Name = "chkAutoGenCode"
        Me.chkAutoGenCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoGenCode.Properties.Appearance.Options.UseFont = True
        Me.chkAutoGenCode.Properties.Caption = "Auto Gen Code"
        Me.chkAutoGenCode.Size = New System.Drawing.Size(97, 19)
        Me.chkAutoGenCode.TabIndex = 18
        '
        'chkUseItemCode
        '
        Me.chkUseItemCode.Location = New System.Drawing.Point(3, 93)
        Me.chkUseItemCode.Name = "chkUseItemCode"
        Me.chkUseItemCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseItemCode.Properties.Appearance.Options.UseFont = True
        Me.chkUseItemCode.Properties.Caption = "Use Item Code"
        Me.chkUseItemCode.Size = New System.Drawing.Size(95, 19)
        Me.chkUseItemCode.TabIndex = 18
        '
        'chkProductMeasure
        '
        Me.chkProductMeasure.Location = New System.Drawing.Point(260, 73)
        Me.chkProductMeasure.Name = "chkProductMeasure"
        Me.chkProductMeasure.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProductMeasure.Properties.Appearance.Options.UseFont = True
        Me.chkProductMeasure.Properties.Caption = "Product Measurement"
        Me.chkProductMeasure.Size = New System.Drawing.Size(127, 19)
        Me.chkProductMeasure.TabIndex = 18
        '
        'chkUseTypeNo
        '
        Me.chkUseTypeNo.Location = New System.Drawing.Point(176, 72)
        Me.chkUseTypeNo.Name = "chkUseTypeNo"
        Me.chkUseTypeNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseTypeNo.Properties.Appearance.Options.UseFont = True
        Me.chkUseTypeNo.Properties.Caption = "Use Type"
        Me.chkUseTypeNo.Size = New System.Drawing.Size(91, 19)
        Me.chkUseTypeNo.TabIndex = 18
        '
        'chkUseSizeWiseRate
        '
        Me.chkUseSizeWiseRate.Location = New System.Drawing.Point(260, 25)
        Me.chkUseSizeWiseRate.Name = "chkUseSizeWiseRate"
        Me.chkUseSizeWiseRate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseSizeWiseRate.Properties.Appearance.Options.UseFont = True
        Me.chkUseSizeWiseRate.Properties.Caption = "Use Size Wise Rate"
        Me.chkUseSizeWiseRate.Size = New System.Drawing.Size(127, 19)
        Me.chkUseSizeWiseRate.TabIndex = 18
        '
        'tabPgTrans
        '
        Me.tabPgTrans.BackColor = System.Drawing.Color.AliceBlue
        Me.tabPgTrans.Controls.Add(Me.grpPurchase)
        Me.tabPgTrans.Controls.Add(Me.grpSalesRtn)
        Me.tabPgTrans.Controls.Add(Me.grpPurchaseRtn)
        Me.tabPgTrans.Controls.Add(Me.rdSalesRtn)
        Me.tabPgTrans.Controls.Add(Me.rdSales)
        Me.tabPgTrans.Controls.Add(Me.rdPurchaseRtn)
        Me.tabPgTrans.Controls.Add(Me.rdPurchase)
        Me.tabPgTrans.Controls.Add(Me.grpSales)
        Me.tabPgTrans.Location = New System.Drawing.Point(4, 23)
        Me.tabPgTrans.Name = "tabPgTrans"
        Me.tabPgTrans.Size = New System.Drawing.Size(782, 563)
        Me.tabPgTrans.TabIndex = 2
        Me.tabPgTrans.Text = "Transaction"
        '
        'grpPurchase
        '
        Me.grpPurchase.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPurchase.AppearanceCaption.Options.UseFont = True
        Me.grpPurchase.AppearanceCaption.Options.UseTextOptions = True
        Me.grpPurchase.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpPurchase.Controls.Add(Me.pnlOptions)
        Me.grpPurchase.Controls.Add(Me.lnkseqproduct)
        Me.grpPurchase.Controls.Add(Me.chkLanding_cc)
        Me.grpPurchase.Controls.Add(Me.chkDisplayWayBillNoAndEntryTex)
        Me.grpPurchase.Controls.Add(Me.chkPurDisplayStockUpdate)
        Me.grpPurchase.Controls.Add(Me.chkDisplaySalesOrderInPurchase)
        Me.grpPurchase.Controls.Add(Me.txtPurBarcodePrinterName)
        Me.grpPurchase.Controls.Add(Me.Label71)
        Me.grpPurchase.Controls.Add(Me.txtPurBarcodePageSize)
        Me.grpPurchase.Controls.Add(Me.Label70)
        Me.grpPurchase.Controls.Add(Me.txtPurDigit)
        Me.grpPurchase.Controls.Add(Me.txtPurDocStartNo)
        Me.grpPurchase.Controls.Add(Me.cmbPurNoSystem)
        Me.grpPurchase.Controls.Add(Me.chkPurDayClose)
        Me.grpPurchase.Controls.Add(Me.chkPurAllowMultiplePurRate)
        Me.grpPurchase.Controls.Add(Me.chkPurPickLastPurRate)
        Me.grpPurchase.Controls.Add(Me.chkPurAllowZeroValue)
        Me.grpPurchase.Controls.Add(Me.chkPurUseSeries)
        Me.grpPurchase.Controls.Add(Me.chkPurAutoRdOff)
        Me.grpPurchase.Controls.Add(Me.Label3)
        Me.grpPurchase.Controls.Add(Me.Label7)
        Me.grpPurchase.Controls.Add(Me.Label6)
        Me.grpPurchase.Location = New System.Drawing.Point(238, 46)
        Me.grpPurchase.LookAndFeel.SkinName = "Money Twins"
        Me.grpPurchase.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpPurchase.Name = "grpPurchase"
        Me.grpPurchase.Size = New System.Drawing.Size(308, 509)
        Me.grpPurchase.TabIndex = 1
        Me.grpPurchase.Text = "Purchase"
        Me.grpPurchase.Visible = False
        '
        'pnlOptions
        '
        Me.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOptions.Controls.Add(Me.pnlSelectOption)
        Me.pnlOptions.Controls.Add(Me.lstMain)
        Me.pnlOptions.Location = New System.Drawing.Point(6, 349)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(297, 149)
        Me.pnlOptions.TabIndex = 555
        Me.pnlOptions.Visible = False
        '
        'pnlSelectOption
        '
        Me.pnlSelectOption.Controls.Add(Me.lstOption1)
        Me.pnlSelectOption.Controls.Add(Me.btnGrp1)
        Me.pnlSelectOption.Controls.Add(Me.btnCloseOption)
        Me.pnlSelectOption.Controls.Add(Me.btnDown)
        Me.pnlSelectOption.Controls.Add(Me.btnDelGrp1)
        Me.pnlSelectOption.Controls.Add(Me.btnUp)
        Me.pnlSelectOption.Location = New System.Drawing.Point(105, 2)
        Me.pnlSelectOption.Name = "pnlSelectOption"
        Me.pnlSelectOption.Size = New System.Drawing.Size(186, 142)
        Me.pnlSelectOption.TabIndex = 1
        '
        'lstOption1
        '
        Me.lstOption1.AllowDrop = True
        Me.lstOption1.FormattingEnabled = True
        Me.lstOption1.ItemHeight = 14
        Me.lstOption1.Location = New System.Drawing.Point(68, 2)
        Me.lstOption1.Name = "lstOption1"
        Me.lstOption1.Size = New System.Drawing.Size(106, 88)
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
        'btnCloseOption
        '
        Me.btnCloseOption.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseOption.Appearance.Options.UseFont = True
        Me.btnCloseOption.Location = New System.Drawing.Point(5, 106)
        Me.btnCloseOption.Name = "btnCloseOption"
        Me.btnCloseOption.Size = New System.Drawing.Size(55, 22)
        Me.btnCloseOption.TabIndex = 2
        Me.btnCloseOption.Text = "Close"
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
        Me.btnDelGrp1.Location = New System.Drawing.Point(4, 78)
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
        Me.lstMain.Items.AddRange(New Object() {"Vat Amt", "Other Charges", "", "", ""})
        Me.lstMain.Location = New System.Drawing.Point(2, 4)
        Me.lstMain.Name = "lstMain"
        Me.lstMain.Size = New System.Drawing.Size(101, 102)
        Me.lstMain.TabIndex = 0
        '
        'lnkseqproduct
        '
        Me.lnkseqproduct.AutoSize = True
        Me.lnkseqproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkseqproduct.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkseqproduct.Location = New System.Drawing.Point(8, 326)
        Me.lnkseqproduct.Name = "lnkseqproduct"
        Me.lnkseqproduct.Size = New System.Drawing.Size(116, 17)
        Me.lnkseqproduct.TabIndex = 554
        Me.lnkseqproduct.TabStop = True
        Me.lnkseqproduct.Text = "Sequence Product"
        '
        'chkLanding_cc
        '
        Me.chkLanding_cc.Location = New System.Drawing.Point(7, 304)
        Me.chkLanding_cc.Name = "chkLanding_cc"
        Me.chkLanding_cc.Properties.Caption = "Landing Cost Calculation"
        Me.chkLanding_cc.Size = New System.Drawing.Size(185, 19)
        Me.chkLanding_cc.TabIndex = 20
        '
        'chkDisplayWayBillNoAndEntryTex
        '
        Me.chkDisplayWayBillNoAndEntryTex.Location = New System.Drawing.Point(7, 281)
        Me.chkDisplayWayBillNoAndEntryTex.Name = "chkDisplayWayBillNoAndEntryTex"
        Me.chkDisplayWayBillNoAndEntryTex.Properties.Caption = "Display Way Bill No and Entry Tex"
        Me.chkDisplayWayBillNoAndEntryTex.Size = New System.Drawing.Size(194, 19)
        Me.chkDisplayWayBillNoAndEntryTex.TabIndex = 19
        '
        'chkPurDisplayStockUpdate
        '
        Me.chkPurDisplayStockUpdate.Location = New System.Drawing.Point(7, 258)
        Me.chkPurDisplayStockUpdate.Name = "chkPurDisplayStockUpdate"
        Me.chkPurDisplayStockUpdate.Properties.Caption = "Display Stock Update "
        Me.chkPurDisplayStockUpdate.Size = New System.Drawing.Size(185, 19)
        Me.chkPurDisplayStockUpdate.TabIndex = 17
        '
        'chkDisplaySalesOrderInPurchase
        '
        Me.chkDisplaySalesOrderInPurchase.Location = New System.Drawing.Point(7, 239)
        Me.chkDisplaySalesOrderInPurchase.Name = "chkDisplaySalesOrderInPurchase"
        Me.chkDisplaySalesOrderInPurchase.Properties.Caption = "Display Sales Order "
        Me.chkDisplaySalesOrderInPurchase.Size = New System.Drawing.Size(185, 19)
        Me.chkDisplaySalesOrderInPurchase.TabIndex = 16
        '
        'txtPurBarcodePrinterName
        '
        Me.txtPurBarcodePrinterName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurBarcodePrinterName.Location = New System.Drawing.Point(122, 186)
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
        Me.Label71.Location = New System.Drawing.Point(8, 190)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(111, 13)
        Me.Label71.TabIndex = 12
        Me.Label71.Text = "Barcode Printer Name"
        '
        'txtPurBarcodePageSize
        '
        Me.txtPurBarcodePageSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurBarcodePageSize.Location = New System.Drawing.Point(121, 212)
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
        Me.Label70.Location = New System.Drawing.Point(8, 216)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(95, 13)
        Me.Label70.TabIndex = 14
        Me.Label70.Text = "Barcode Page Size"
        '
        'txtPurDigit
        '
        Me.txtPurDigit.AllowAlphabets = False
        Me.txtPurDigit.AllowMoveToNextControl = True
        Me.txtPurDigit.EditValue = 0
        Me.txtPurDigit.Location = New System.Drawing.Point(209, 29)
        Me.txtPurDigit.Name = "txtPurDigit"
        Me.txtPurDigit.Size = New System.Drawing.Size(34, 22)
        Me.txtPurDigit.TabIndex = 3
        Me.txtPurDigit.Tag = "Purchase Digit"
        Me.txtPurDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurDocStartNo
        '
        Me.txtPurDocStartNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurDocStartNo.Location = New System.Drawing.Point(87, 30)
        Me.txtPurDocStartNo.MaxLength = 50
        Me.txtPurDocStartNo.Name = "txtPurDocStartNo"
        Me.txtPurDocStartNo.Size = New System.Drawing.Size(84, 21)
        Me.txtPurDocStartNo.TabIndex = 1
        Me.txtPurDocStartNo.Tag = "Doc Start No (Purchase)"
        '
        'cmbPurNoSystem
        '
        Me.cmbPurNoSystem.AutoComplete = True
        Me.cmbPurNoSystem.DisplayMember = "Led_Name"
        Me.cmbPurNoSystem.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbPurNoSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurNoSystem.Location = New System.Drawing.Point(87, 55)
        Me.cmbPurNoSystem.Name = "cmbPurNoSystem"
        Me.cmbPurNoSystem.Size = New System.Drawing.Size(156, 21)
        Me.cmbPurNoSystem.TabIndex = 5
        Me.cmbPurNoSystem.ValueMember = "Led_Key"
        '
        'chkPurDayClose
        '
        Me.chkPurDayClose.Location = New System.Drawing.Point(141, 111)
        Me.chkPurDayClose.Name = "chkPurDayClose"
        Me.chkPurDayClose.Properties.Caption = "Use Day Close"
        Me.chkPurDayClose.Size = New System.Drawing.Size(94, 19)
        Me.chkPurDayClose.TabIndex = 9
        '
        'chkPurAllowMultiplePurRate
        '
        Me.chkPurAllowMultiplePurRate.Location = New System.Drawing.Point(5, 160)
        Me.chkPurAllowMultiplePurRate.Name = "chkPurAllowMultiplePurRate"
        Me.chkPurAllowMultiplePurRate.Properties.Caption = "Allow Multiple Purchase Rate"
        Me.chkPurAllowMultiplePurRate.Size = New System.Drawing.Size(164, 19)
        Me.chkPurAllowMultiplePurRate.TabIndex = 11
        Me.chkPurAllowMultiplePurRate.Visible = False
        '
        'chkPurPickLastPurRate
        '
        Me.chkPurPickLastPurRate.Location = New System.Drawing.Point(5, 110)
        Me.chkPurPickLastPurRate.Name = "chkPurPickLastPurRate"
        Me.chkPurPickLastPurRate.Properties.Caption = "Pick Last Purchase Rt"
        Me.chkPurPickLastPurRate.Size = New System.Drawing.Size(133, 19)
        Me.chkPurPickLastPurRate.TabIndex = 8
        '
        'chkPurAllowZeroValue
        '
        Me.chkPurAllowZeroValue.Location = New System.Drawing.Point(5, 135)
        Me.chkPurAllowZeroValue.Name = "chkPurAllowZeroValue"
        Me.chkPurAllowZeroValue.Properties.Caption = "Allow Zero Value"
        Me.chkPurAllowZeroValue.Size = New System.Drawing.Size(103, 19)
        Me.chkPurAllowZeroValue.TabIndex = 10
        '
        'chkPurUseSeries
        '
        Me.chkPurUseSeries.Location = New System.Drawing.Point(5, 85)
        Me.chkPurUseSeries.Name = "chkPurUseSeries"
        Me.chkPurUseSeries.Properties.Caption = "Use Series"
        Me.chkPurUseSeries.Size = New System.Drawing.Size(83, 19)
        Me.chkPurUseSeries.TabIndex = 6
        '
        'chkPurAutoRdOff
        '
        Me.chkPurAutoRdOff.Location = New System.Drawing.Point(141, 86)
        Me.chkPurAutoRdOff.Name = "chkPurAutoRdOff"
        Me.chkPurAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkPurAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkPurAutoRdOff.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Digit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Reset Doc No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Doc Start #"
        '
        'grpSalesRtn
        '
        Me.grpSalesRtn.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSalesRtn.AppearanceCaption.Options.UseFont = True
        Me.grpSalesRtn.AppearanceCaption.Options.UseTextOptions = True
        Me.grpSalesRtn.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnPickLastSalePersonWOBill)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnCheckSoldStatus)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnPickLastSaleDiscWOBill)
        Me.grpSalesRtn.Controls.Add(Me.Label61)
        Me.grpSalesRtn.Controls.Add(Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn)
        Me.grpSalesRtn.Controls.Add(Me.Label63)
        Me.grpSalesRtn.Controls.Add(Me.txtSalesRtnDigit)
        Me.grpSalesRtn.Controls.Add(Me.txtSalesRtnDocStartNo)
        Me.grpSalesRtn.Controls.Add(Me.Label11)
        Me.grpSalesRtn.Controls.Add(Me.cmbSalesRtnNoSystem)
        Me.grpSalesRtn.Controls.Add(Me.cmbDefSalesRtnCardDiscAccount)
        Me.grpSalesRtn.Controls.Add(Me.cmbDefSalesRtnCust)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnDayClose)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnMsgOnAutoPrint)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnPrnOnSave)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnAllowRtnWOSales)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnUseSeries)
        Me.grpSalesRtn.Controls.Add(Me.chkSalesRtnAutoRdOff)
        Me.grpSalesRtn.Controls.Add(Me.Label15)
        Me.grpSalesRtn.Controls.Add(Me.Label16)
        Me.grpSalesRtn.Controls.Add(Me.Label19)
        Me.grpSalesRtn.Controls.Add(Me.Label22)
        Me.grpSalesRtn.Location = New System.Drawing.Point(246, 45)
        Me.grpSalesRtn.LookAndFeel.SkinName = "Money Twins"
        Me.grpSalesRtn.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpSalesRtn.Name = "grpSalesRtn"
        Me.grpSalesRtn.Size = New System.Drawing.Size(301, 280)
        Me.grpSalesRtn.TabIndex = 3
        Me.grpSalesRtn.Text = "Sales Return"
        Me.grpSalesRtn.Visible = False
        '
        'chkSalesRtnPickLastSalePersonWOBill
        '
        Me.chkSalesRtnPickLastSalePersonWOBill.Location = New System.Drawing.Point(3, 245)
        Me.chkSalesRtnPickLastSalePersonWOBill.Name = "chkSalesRtnPickLastSalePersonWOBill"
        Me.chkSalesRtnPickLastSalePersonWOBill.Properties.Caption = "In case of without Bill, Pick Last Sales Person"
        Me.chkSalesRtnPickLastSalePersonWOBill.Size = New System.Drawing.Size(289, 19)
        Me.chkSalesRtnPickLastSalePersonWOBill.TabIndex = 66
        '
        'chkSalesRtnCheckSoldStatus
        '
        Me.chkSalesRtnCheckSoldStatus.Location = New System.Drawing.Point(3, 226)
        Me.chkSalesRtnCheckSoldStatus.Name = "chkSalesRtnCheckSoldStatus"
        Me.chkSalesRtnCheckSoldStatus.Properties.Caption = "Check for Sold Status of Items"
        Me.chkSalesRtnCheckSoldStatus.Size = New System.Drawing.Size(289, 19)
        Me.chkSalesRtnCheckSoldStatus.TabIndex = 65
        '
        'chkSalesRtnPickLastSaleDiscWOBill
        '
        Me.chkSalesRtnPickLastSaleDiscWOBill.Location = New System.Drawing.Point(3, 207)
        Me.chkSalesRtnPickLastSaleDiscWOBill.Name = "chkSalesRtnPickLastSaleDiscWOBill"
        Me.chkSalesRtnPickLastSaleDiscWOBill.Properties.Caption = "In case of without Bill, Pick Discount of Last Sales"
        Me.chkSalesRtnPickLastSaleDiscWOBill.Size = New System.Drawing.Size(293, 19)
        Me.chkSalesRtnPickLastSaleDiscWOBill.TabIndex = 64
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.Color.Maroon
        Me.Label61.Location = New System.Drawing.Point(215, 131)
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
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Location = New System.Drawing.Point(188, 127)
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Name = "txtSalesRtnAcceptLastNDaysInvoiceOnReturn"
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Size = New System.Drawing.Size(27, 22)
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.TabIndex = 62
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.Tag = "Accept Last N Days Invoice On Return"
        Me.txtSalesRtnAcceptLastNDaysInvoiceOnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(2, 131)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(186, 14)
        Me.Label63.TabIndex = 61
        Me.Label63.Text = "Do not Accept Goods Return After"
        '
        'txtSalesRtnDigit
        '
        Me.txtSalesRtnDigit.AllowAlphabets = False
        Me.txtSalesRtnDigit.AllowMoveToNextControl = True
        Me.txtSalesRtnDigit.EditValue = 0
        Me.txtSalesRtnDigit.Location = New System.Drawing.Point(209, 78)
        Me.txtSalesRtnDigit.Name = "txtSalesRtnDigit"
        Me.txtSalesRtnDigit.Size = New System.Drawing.Size(34, 22)
        Me.txtSalesRtnDigit.TabIndex = 60
        Me.txtSalesRtnDigit.Tag = "Sales Return Digit"
        Me.txtSalesRtnDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalesRtnDocStartNo
        '
        Me.txtSalesRtnDocStartNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesRtnDocStartNo.Location = New System.Drawing.Point(91, 79)
        Me.txtSalesRtnDocStartNo.MaxLength = 50
        Me.txtSalesRtnDocStartNo.Name = "txtSalesRtnDocStartNo"
        Me.txtSalesRtnDocStartNo.Size = New System.Drawing.Size(84, 21)
        Me.txtSalesRtnDocStartNo.TabIndex = 60
        Me.txtSalesRtnDocStartNo.Tag = "Doc Start No (Sales Return)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(177, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 14)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Digit"
        '
        'cmbSalesRtnNoSystem
        '
        Me.cmbSalesRtnNoSystem.AutoComplete = True
        Me.cmbSalesRtnNoSystem.DisplayMember = "Led_Name"
        Me.cmbSalesRtnNoSystem.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesRtnNoSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesRtnNoSystem.Location = New System.Drawing.Point(91, 103)
        Me.cmbSalesRtnNoSystem.Name = "cmbSalesRtnNoSystem"
        Me.cmbSalesRtnNoSystem.Size = New System.Drawing.Size(152, 21)
        Me.cmbSalesRtnNoSystem.TabIndex = 44
        Me.cmbSalesRtnNoSystem.ValueMember = "Led_Key"
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
        'chkSalesRtnDayClose
        '
        Me.chkSalesRtnDayClose.Location = New System.Drawing.Point(186, 169)
        Me.chkSalesRtnDayClose.Name = "chkSalesRtnDayClose"
        Me.chkSalesRtnDayClose.Properties.Caption = "Use Day Close"
        Me.chkSalesRtnDayClose.Size = New System.Drawing.Size(106, 19)
        Me.chkSalesRtnDayClose.TabIndex = 27
        '
        'chkSalesRtnMsgOnAutoPrint
        '
        Me.chkSalesRtnMsgOnAutoPrint.Location = New System.Drawing.Point(186, 188)
        Me.chkSalesRtnMsgOnAutoPrint.Name = "chkSalesRtnMsgOnAutoPrint"
        Me.chkSalesRtnMsgOnAutoPrint.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalesRtnMsgOnAutoPrint.Properties.Appearance.Options.UseFont = True
        Me.chkSalesRtnMsgOnAutoPrint.Properties.Caption = "Message On Print"
        Me.chkSalesRtnMsgOnAutoPrint.Size = New System.Drawing.Size(117, 19)
        Me.chkSalesRtnMsgOnAutoPrint.TabIndex = 2
        '
        'chkSalesRtnPrnOnSave
        '
        Me.chkSalesRtnPrnOnSave.Location = New System.Drawing.Point(3, 188)
        Me.chkSalesRtnPrnOnSave.Name = "chkSalesRtnPrnOnSave"
        Me.chkSalesRtnPrnOnSave.Properties.Caption = "Auto Print on save"
        Me.chkSalesRtnPrnOnSave.Size = New System.Drawing.Size(114, 19)
        Me.chkSalesRtnPrnOnSave.TabIndex = 2
        '
        'chkSalesRtnAllowRtnWOSales
        '
        Me.chkSalesRtnAllowRtnWOSales.Location = New System.Drawing.Point(3, 169)
        Me.chkSalesRtnAllowRtnWOSales.Name = "chkSalesRtnAllowRtnWOSales"
        Me.chkSalesRtnAllowRtnWOSales.Properties.Caption = "Allow Return w/o Sale Bill"
        Me.chkSalesRtnAllowRtnWOSales.Size = New System.Drawing.Size(161, 19)
        Me.chkSalesRtnAllowRtnWOSales.TabIndex = 2
        '
        'chkSalesRtnUseSeries
        '
        Me.chkSalesRtnUseSeries.Location = New System.Drawing.Point(3, 150)
        Me.chkSalesRtnUseSeries.Name = "chkSalesRtnUseSeries"
        Me.chkSalesRtnUseSeries.Properties.Caption = "Use Series"
        Me.chkSalesRtnUseSeries.Size = New System.Drawing.Size(83, 19)
        Me.chkSalesRtnUseSeries.TabIndex = 2
        '
        'chkSalesRtnAutoRdOff
        '
        Me.chkSalesRtnAutoRdOff.Location = New System.Drawing.Point(186, 150)
        Me.chkSalesRtnAutoRdOff.Name = "chkSalesRtnAutoRdOff"
        Me.chkSalesRtnAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkSalesRtnAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkSalesRtnAutoRdOff.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 14)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "No. System"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 14)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Doc Start #"
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
        'grpPurchaseRtn
        '
        Me.grpPurchaseRtn.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPurchaseRtn.AppearanceCaption.Options.UseFont = True
        Me.grpPurchaseRtn.AppearanceCaption.Options.UseTextOptions = True
        Me.grpPurchaseRtn.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpPurchaseRtn.Controls.Add(Me.txtPurRtnDigit)
        Me.grpPurchaseRtn.Controls.Add(Me.txtPurRtnDocStartNo)
        Me.grpPurchaseRtn.Controls.Add(Me.cmbPurRtnNoSystem)
        Me.grpPurchaseRtn.Controls.Add(Me.chkPurRtnDayClose)
        Me.grpPurchaseRtn.Controls.Add(Me.chkPurRtnUseSeries)
        Me.grpPurchaseRtn.Controls.Add(Me.chkPurRtnLocWiseStockCheck)
        Me.grpPurchaseRtn.Controls.Add(Me.chkPurRtnSupplierSpecificPurRtn)
        Me.grpPurchaseRtn.Controls.Add(Me.chkPurRtnAutoRdOff)
        Me.grpPurchaseRtn.Controls.Add(Me.Label8)
        Me.grpPurchaseRtn.Controls.Add(Me.Label9)
        Me.grpPurchaseRtn.Controls.Add(Me.Label4)
        Me.grpPurchaseRtn.Location = New System.Drawing.Point(299, 48)
        Me.grpPurchaseRtn.LookAndFeel.SkinName = "Money Twins"
        Me.grpPurchaseRtn.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpPurchaseRtn.Name = "grpPurchaseRtn"
        Me.grpPurchaseRtn.Size = New System.Drawing.Size(248, 206)
        Me.grpPurchaseRtn.TabIndex = 2
        Me.grpPurchaseRtn.Text = "Purchase Return"
        Me.grpPurchaseRtn.Visible = False
        '
        'txtPurRtnDigit
        '
        Me.txtPurRtnDigit.AllowAlphabets = False
        Me.txtPurRtnDigit.AllowMoveToNextControl = True
        Me.txtPurRtnDigit.EditValue = 0
        Me.txtPurRtnDigit.Location = New System.Drawing.Point(209, 29)
        Me.txtPurRtnDigit.Name = "txtPurRtnDigit"
        Me.txtPurRtnDigit.Size = New System.Drawing.Size(34, 22)
        Me.txtPurRtnDigit.TabIndex = 60
        Me.txtPurRtnDigit.Tag = "Purchase Return Digit"
        Me.txtPurRtnDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurRtnDocStartNo
        '
        Me.txtPurRtnDocStartNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurRtnDocStartNo.Location = New System.Drawing.Point(91, 30)
        Me.txtPurRtnDocStartNo.MaxLength = 50
        Me.txtPurRtnDocStartNo.Name = "txtPurRtnDocStartNo"
        Me.txtPurRtnDocStartNo.Size = New System.Drawing.Size(84, 21)
        Me.txtPurRtnDocStartNo.TabIndex = 60
        Me.txtPurRtnDocStartNo.Tag = "Doc Start No (Purchase Return)"
        '
        'cmbPurRtnNoSystem
        '
        Me.cmbPurRtnNoSystem.AutoComplete = True
        Me.cmbPurRtnNoSystem.DisplayMember = "Led_Name"
        Me.cmbPurRtnNoSystem.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbPurRtnNoSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurRtnNoSystem.Location = New System.Drawing.Point(90, 55)
        Me.cmbPurRtnNoSystem.Name = "cmbPurRtnNoSystem"
        Me.cmbPurRtnNoSystem.Size = New System.Drawing.Size(153, 21)
        Me.cmbPurRtnNoSystem.TabIndex = 43
        Me.cmbPurRtnNoSystem.ValueMember = "Led_Key"
        '
        'chkPurRtnDayClose
        '
        Me.chkPurRtnDayClose.Location = New System.Drawing.Point(142, 111)
        Me.chkPurRtnDayClose.Name = "chkPurRtnDayClose"
        Me.chkPurRtnDayClose.Properties.Caption = "Use Day Close"
        Me.chkPurRtnDayClose.Size = New System.Drawing.Size(91, 19)
        Me.chkPurRtnDayClose.TabIndex = 27
        '
        'chkPurRtnUseSeries
        '
        Me.chkPurRtnUseSeries.Location = New System.Drawing.Point(2, 86)
        Me.chkPurRtnUseSeries.Name = "chkPurRtnUseSeries"
        Me.chkPurRtnUseSeries.Properties.Caption = "Use Series"
        Me.chkPurRtnUseSeries.Size = New System.Drawing.Size(83, 19)
        Me.chkPurRtnUseSeries.TabIndex = 2
        '
        'chkPurRtnLocWiseStockCheck
        '
        Me.chkPurRtnLocWiseStockCheck.Location = New System.Drawing.Point(2, 136)
        Me.chkPurRtnLocWiseStockCheck.Name = "chkPurRtnLocWiseStockCheck"
        Me.chkPurRtnLocWiseStockCheck.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPurRtnLocWiseStockCheck.Properties.Appearance.Options.UseForeColor = True
        Me.chkPurRtnLocWiseStockCheck.Properties.Caption = "Location Wise Stock Check"
        Me.chkPurRtnLocWiseStockCheck.Size = New System.Drawing.Size(161, 19)
        Me.chkPurRtnLocWiseStockCheck.TabIndex = 2
        '
        'chkPurRtnSupplierSpecificPurRtn
        '
        Me.chkPurRtnSupplierSpecificPurRtn.Location = New System.Drawing.Point(2, 111)
        Me.chkPurRtnSupplierSpecificPurRtn.Name = "chkPurRtnSupplierSpecificPurRtn"
        Me.chkPurRtnSupplierSpecificPurRtn.Properties.Caption = "Supplier Specific Pur Rtn"
        Me.chkPurRtnSupplierSpecificPurRtn.Size = New System.Drawing.Size(139, 19)
        Me.chkPurRtnSupplierSpecificPurRtn.TabIndex = 2
        '
        'chkPurRtnAutoRdOff
        '
        Me.chkPurRtnAutoRdOff.Location = New System.Drawing.Point(142, 86)
        Me.chkPurRtnAutoRdOff.Name = "chkPurRtnAutoRdOff"
        Me.chkPurRtnAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkPurRtnAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkPurRtnAutoRdOff.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Reset Doc No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Doc Start #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Digit"
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
        'grpSales
        '
        Me.grpSales.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSales.AppearanceCaption.Options.UseFont = True
        Me.grpSales.AppearanceCaption.Options.UseTextOptions = True
        Me.grpSales.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpSales.Controls.Add(Me.GrpMoreFeatures)
        Me.grpSales.Controls.Add(Me.lnkFeatues)
        Me.grpSales.Controls.Add(Me.chkCreateBarcodeOption)
        Me.grpSales.Controls.Add(Me.chkMessageOnSeriesChangeOption)
        Me.grpSales.Controls.Add(Me.chkSeriesChangeOption)
        Me.grpSales.Controls.Add(Me.txtSalesEmailid)
        Me.grpSales.Controls.Add(Me.Label67)
        Me.grpSales.Controls.Add(Me.chkSalesAutoEmailOnBill)
        Me.grpSales.Controls.Add(Me.chkSalesUseSalesOrderinBill)
        Me.grpSales.Controls.Add(Me.cmbFocusOn)
        Me.grpSales.Controls.Add(Me.Label69)
        Me.grpSales.Controls.Add(Me.chkSalesDisplayTodaySales)
        Me.grpSales.Controls.Add(Me.chkSalesDisplayLastBillDetails)
        Me.grpSales.Controls.Add(Me.chkSalesUseCoupon)
        Me.grpSales.Controls.Add(Me.chkSalesDisplayDeliveryDetail)
        Me.grpSales.Controls.Add(Me.ChkSalesDisplayHold)
        Me.grpSales.Controls.Add(Me.ChkSalesDisplayPrintName)
        Me.grpSales.Controls.Add(Me.txtSalesPageSize)
        Me.grpSales.Controls.Add(Me.Label68)
        Me.grpSales.Controls.Add(Me.txtSalesPrinterName)
        Me.grpSales.Controls.Add(Me.lblPrinterName)
        Me.grpSales.Controls.Add(Me.chkSalesApplySchemeinExchWOBill)
        Me.grpSales.Controls.Add(Me.chkSalesPickLastSalePersonWOBill)
        Me.grpSales.Controls.Add(Me.chkSalesCheckSoldStatus)
        Me.grpSales.Controls.Add(Me.chkSalesPickLastSaleDiscinExchWOBill)
        Me.grpSales.Controls.Add(Me.txtSalesDeliveryDays)
        Me.grpSales.Controls.Add(Me.Label62)
        Me.grpSales.Controls.Add(Me.chkSalesCarryforwardSalePersonAtItemLevel)
        Me.grpSales.Controls.Add(Me.txtTimingFrom)
        Me.grpSales.Controls.Add(Me.Label44)
        Me.grpSales.Controls.Add(Me.txtMessageOnBill)
        Me.grpSales.Controls.Add(Me.Label49)
        Me.grpSales.Controls.Add(Me.txtSalesNoOfCopiesToPrint)
        Me.grpSales.Controls.Add(Me.txtSalesNoOfItemsOnBill)
        Me.grpSales.Controls.Add(Me.txtSalesDigit)
        Me.grpSales.Controls.Add(Me.txtInvoiceHeadOnPrint)
        Me.grpSales.Controls.Add(Me.txtSalesDocStartNo)
        Me.grpSales.Controls.Add(Me.Label33)
        Me.grpSales.Controls.Add(Me.chkSalesAllowBackDtBillCreation)
        Me.grpSales.Controls.Add(Me.chkSalesMsgOnAutoSMS)
        Me.grpSales.Controls.Add(Me.chkSalesMsgOnAutoPrint)
        Me.grpSales.Controls.Add(Me.Label12)
        Me.grpSales.Controls.Add(Me.cmbSalesDefPayMode)
        Me.grpSales.Controls.Add(Me.cmbSalesShowItemSelList)
        Me.grpSales.Controls.Add(Me.cmbSalesAllowBillDelete)
        Me.grpSales.Controls.Add(Me.cmbSalesAllowBillUpdate)
        Me.grpSales.Controls.Add(Me.cmbSalesToBeBilledOn)
        Me.grpSales.Controls.Add(Me.cmbSalesNoSystem)
        Me.grpSales.Controls.Add(Me.cmbDefSalesCardDiscAccount)
        Me.grpSales.Controls.Add(Me.cmbDefSalesCust)
        Me.grpSales.Controls.Add(Me.chkSalesDisplayImageOnBill)
        Me.grpSales.Controls.Add(Me.chkSalesDayClose)
        Me.grpSales.Controls.Add(Me.chkSalesPrnOnSave)
        Me.grpSales.Controls.Add(Me.chkSalesLocationWiseStockCheck)
        Me.grpSales.Controls.Add(Me.chkSalesChkCrLimitOnCrSale)
        Me.grpSales.Controls.Add(Me.chkSalesUseSeries)
        Me.grpSales.Controls.Add(Me.chkSalesCtrWiseSeries)
        Me.grpSales.Controls.Add(Me.chkSalesMergeDupBarcode)
        Me.grpSales.Controls.Add(Me.chkSalesRestrictBillChgAfterPrint)
        Me.grpSales.Controls.Add(Me.chkSalesLockBillDiscount)
        Me.grpSales.Controls.Add(Me.chkSalesLockManualDiscount)
        Me.grpSales.Controls.Add(Me.chkSalesLockSalesRt)
        Me.grpSales.Controls.Add(Me.chkSalesAllowZeroValueEntry)
        Me.grpSales.Controls.Add(Me.chkSalesSchemeBillWiseDisc)
        Me.grpSales.Controls.Add(Me.chkSalesSchemeItemWiseDisc)
        Me.grpSales.Controls.Add(Me.chkSalesSchemeDisc)
        Me.grpSales.Controls.Add(Me.chkSalesAutoSMSBill)
        Me.grpSales.Controls.Add(Me.chkSalesAskForBill)
        Me.grpSales.Controls.Add(Me.chkSalesExchAgainstBill)
        Me.grpSales.Controls.Add(Me.chkSalesAllowBkDtBillPrn)
        Me.grpSales.Controls.Add(Me.chkSalesAutoRdOff)
        Me.grpSales.Controls.Add(Me.Label31)
        Me.grpSales.Controls.Add(Me.Label32)
        Me.grpSales.Controls.Add(Me.Label58)
        Me.grpSales.Controls.Add(Me.Label23)
        Me.grpSales.Controls.Add(Me.Label24)
        Me.grpSales.Controls.Add(Me.Label66)
        Me.grpSales.Controls.Add(Me.Label27)
        Me.grpSales.Controls.Add(Me.Label65)
        Me.grpSales.Controls.Add(Me.Label59)
        Me.grpSales.Controls.Add(Me.Label60)
        Me.grpSales.Controls.Add(Me.Label39)
        Me.grpSales.Controls.Add(Me.Label29)
        Me.grpSales.Location = New System.Drawing.Point(6, 47)
        Me.grpSales.LookAndFeel.SkinName = "Money Twins"
        Me.grpSales.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpSales.Name = "grpSales"
        Me.grpSales.Size = New System.Drawing.Size(780, 509)
        Me.grpSales.TabIndex = 4
        Me.grpSales.Text = "Sales"
        Me.grpSales.Visible = False
        '
        'GrpMoreFeatures
        '
        Me.GrpMoreFeatures.AppearanceCaption.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMoreFeatures.AppearanceCaption.Options.UseFont = True
        Me.GrpMoreFeatures.AppearanceCaption.Options.UseTextOptions = True
        Me.GrpMoreFeatures.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GrpMoreFeatures.Controls.Add(Me.ChkDisplayAllOptionsInBill)
        Me.GrpMoreFeatures.Controls.Add(Me.btnCloseGrpOptionsFeaturs)
        Me.GrpMoreFeatures.Controls.Add(Me.ChkMsgOnEmailSend)
        Me.GrpMoreFeatures.Controls.Add(Me.ChkAutoBillSendOnEmail)
        Me.GrpMoreFeatures.Controls.Add(Me.ChkAutoSendBillOnWhatsApp)
        Me.GrpMoreFeatures.Controls.Add(Me.ChkMsgOnBillSendWhatsApp)
        Me.GrpMoreFeatures.Location = New System.Drawing.Point(466, 273)
        Me.GrpMoreFeatures.LookAndFeel.SkinName = "Money Twins"
        Me.GrpMoreFeatures.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GrpMoreFeatures.Name = "GrpMoreFeatures"
        Me.GrpMoreFeatures.Size = New System.Drawing.Size(308, 106)
        Me.GrpMoreFeatures.TabIndex = 556
        Me.GrpMoreFeatures.Text = "More Options"
        Me.GrpMoreFeatures.Visible = False
        '
        'btnCloseGrpOptionsFeaturs
        '
        Me.btnCloseGrpOptionsFeaturs.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseGrpOptionsFeaturs.Appearance.Options.UseFont = True
        Me.btnCloseGrpOptionsFeaturs.Location = New System.Drawing.Point(162, 78)
        Me.btnCloseGrpOptionsFeaturs.Name = "btnCloseGrpOptionsFeaturs"
        Me.btnCloseGrpOptionsFeaturs.Size = New System.Drawing.Size(55, 22)
        Me.btnCloseGrpOptionsFeaturs.TabIndex = 10
        Me.btnCloseGrpOptionsFeaturs.Text = "Close"
        '
        'ChkMsgOnEmailSend
        '
        Me.ChkMsgOnEmailSend.Location = New System.Drawing.Point(155, 52)
        Me.ChkMsgOnEmailSend.Name = "ChkMsgOnEmailSend"
        Me.ChkMsgOnEmailSend.Properties.Caption = "Message On Email"
        Me.ChkMsgOnEmailSend.Size = New System.Drawing.Size(131, 19)
        Me.ChkMsgOnEmailSend.TabIndex = 9
        '
        'ChkAutoBillSendOnEmail
        '
        Me.ChkAutoBillSendOnEmail.Location = New System.Drawing.Point(5, 51)
        Me.ChkAutoBillSendOnEmail.Name = "ChkAutoBillSendOnEmail"
        Me.ChkAutoBillSendOnEmail.Properties.Caption = "Auto Email On Bill"
        Me.ChkAutoBillSendOnEmail.Size = New System.Drawing.Size(133, 19)
        Me.ChkAutoBillSendOnEmail.TabIndex = 8
        '
        'ChkAutoSendBillOnWhatsApp
        '
        Me.ChkAutoSendBillOnWhatsApp.Location = New System.Drawing.Point(5, 26)
        Me.ChkAutoSendBillOnWhatsApp.Name = "ChkAutoSendBillOnWhatsApp"
        Me.ChkAutoSendBillOnWhatsApp.Properties.Caption = "Auto WhatsApp On Bill"
        Me.ChkAutoSendBillOnWhatsApp.Size = New System.Drawing.Size(140, 19)
        Me.ChkAutoSendBillOnWhatsApp.TabIndex = 6
        '
        'ChkMsgOnBillSendWhatsApp
        '
        Me.ChkMsgOnBillSendWhatsApp.Location = New System.Drawing.Point(155, 27)
        Me.ChkMsgOnBillSendWhatsApp.Name = "ChkMsgOnBillSendWhatsApp"
        Me.ChkMsgOnBillSendWhatsApp.Properties.Caption = "Message On WhatsApp"
        Me.ChkMsgOnBillSendWhatsApp.Size = New System.Drawing.Size(138, 19)
        Me.ChkMsgOnBillSendWhatsApp.TabIndex = 7
        '
        'lnkFeatues
        '
        Me.lnkFeatues.AutoSize = True
        Me.lnkFeatues.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkFeatues.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkFeatues.Location = New System.Drawing.Point(557, 279)
        Me.lnkFeatues.Name = "lnkFeatues"
        Me.lnkFeatues.Size = New System.Drawing.Size(82, 15)
        Me.lnkFeatues.TabIndex = 555
        Me.lnkFeatues.TabStop = True
        Me.lnkFeatues.Text = "More Options"
        Me.lnkFeatues.Visible = False
        '
        'chkCreateBarcodeOption
        '
        Me.chkCreateBarcodeOption.Location = New System.Drawing.Point(585, 477)
        Me.chkCreateBarcodeOption.Name = "chkCreateBarcodeOption"
        Me.chkCreateBarcodeOption.Properties.Caption = "Create Barcode Option"
        Me.chkCreateBarcodeOption.Size = New System.Drawing.Size(134, 19)
        Me.chkCreateBarcodeOption.TabIndex = 80
        '
        'chkMessageOnSeriesChangeOption
        '
        Me.chkMessageOnSeriesChangeOption.Location = New System.Drawing.Point(585, 457)
        Me.chkMessageOnSeriesChangeOption.Name = "chkMessageOnSeriesChangeOption"
        Me.chkMessageOnSeriesChangeOption.Properties.Caption = "Message On Series Change Option"
        Me.chkMessageOnSeriesChangeOption.Size = New System.Drawing.Size(190, 19)
        Me.chkMessageOnSeriesChangeOption.TabIndex = 79
        '
        'chkSeriesChangeOption
        '
        Me.chkSeriesChangeOption.Location = New System.Drawing.Point(585, 438)
        Me.chkSeriesChangeOption.Name = "chkSeriesChangeOption"
        Me.chkSeriesChangeOption.Properties.Caption = "Series Change Option"
        Me.chkSeriesChangeOption.Size = New System.Drawing.Size(125, 19)
        Me.chkSeriesChangeOption.TabIndex = 78
        '
        'txtSalesEmailid
        '
        Me.txtSalesEmailid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesEmailid.Location = New System.Drawing.Point(636, 416)
        Me.txtSalesEmailid.MaxLength = 50
        Me.txtSalesEmailid.Name = "txtSalesEmailid"
        Me.txtSalesEmailid.Size = New System.Drawing.Size(127, 21)
        Me.txtSalesEmailid.TabIndex = 77
        Me.txtSalesEmailid.Tag = "Page Size"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(587, 420)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(44, 13)
        Me.Label67.TabIndex = 76
        Me.Label67.Text = "Email Id"
        '
        'chkSalesAutoEmailOnBill
        '
        Me.chkSalesAutoEmailOnBill.Location = New System.Drawing.Point(585, 397)
        Me.chkSalesAutoEmailOnBill.Name = "chkSalesAutoEmailOnBill"
        Me.chkSalesAutoEmailOnBill.Properties.Caption = "Auto Email "
        Me.chkSalesAutoEmailOnBill.Size = New System.Drawing.Size(139, 19)
        Me.chkSalesAutoEmailOnBill.TabIndex = 75
        '
        'chkSalesUseSalesOrderinBill
        '
        Me.chkSalesUseSalesOrderinBill.Location = New System.Drawing.Point(585, 376)
        Me.chkSalesUseSalesOrderinBill.Name = "chkSalesUseSalesOrderinBill"
        Me.chkSalesUseSalesOrderinBill.Properties.Caption = "Use Sales Order "
        Me.chkSalesUseSalesOrderinBill.Size = New System.Drawing.Size(109, 19)
        Me.chkSalesUseSalesOrderinBill.TabIndex = 74
        '
        'cmbFocusOn
        '
        Me.cmbFocusOn.AutoComplete = True
        Me.cmbFocusOn.DisplayMember = "Led_Name"
        Me.cmbFocusOn.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbFocusOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFocusOn.Location = New System.Drawing.Point(434, 337)
        Me.cmbFocusOn.Name = "cmbFocusOn"
        Me.cmbFocusOn.Size = New System.Drawing.Size(106, 21)
        Me.cmbFocusOn.TabIndex = 65
        Me.cmbFocusOn.Tag = "Focus On"
        Me.cmbFocusOn.ValueMember = "Led_Key"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(366, 340)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(56, 14)
        Me.Label69.TabIndex = 64
        Me.Label69.Text = "Focus On"
        '
        'chkSalesDisplayTodaySales
        '
        Me.chkSalesDisplayTodaySales.Location = New System.Drawing.Point(398, 477)
        Me.chkSalesDisplayTodaySales.Name = "chkSalesDisplayTodaySales"
        Me.chkSalesDisplayTodaySales.Properties.Caption = " Display Today Sales"
        Me.chkSalesDisplayTodaySales.Size = New System.Drawing.Size(166, 19)
        Me.chkSalesDisplayTodaySales.TabIndex = 73
        '
        'chkSalesDisplayLastBillDetails
        '
        Me.chkSalesDisplayLastBillDetails.Location = New System.Drawing.Point(397, 457)
        Me.chkSalesDisplayLastBillDetails.Name = "chkSalesDisplayLastBillDetails"
        Me.chkSalesDisplayLastBillDetails.Properties.Caption = " Display Last Bill Details"
        Me.chkSalesDisplayLastBillDetails.Size = New System.Drawing.Size(166, 19)
        Me.chkSalesDisplayLastBillDetails.TabIndex = 72
        '
        'chkSalesUseCoupon
        '
        Me.chkSalesUseCoupon.Location = New System.Drawing.Point(397, 438)
        Me.chkSalesUseCoupon.Name = "chkSalesUseCoupon"
        Me.chkSalesUseCoupon.Properties.Caption = " Use Coupon"
        Me.chkSalesUseCoupon.Size = New System.Drawing.Size(123, 19)
        Me.chkSalesUseCoupon.TabIndex = 71
        '
        'chkSalesDisplayDeliveryDetail
        '
        Me.chkSalesDisplayDeliveryDetail.Location = New System.Drawing.Point(397, 397)
        Me.chkSalesDisplayDeliveryDetail.Name = "chkSalesDisplayDeliveryDetail"
        Me.chkSalesDisplayDeliveryDetail.Properties.Caption = "Display Delivery Detail"
        Me.chkSalesDisplayDeliveryDetail.Size = New System.Drawing.Size(145, 19)
        Me.chkSalesDisplayDeliveryDetail.TabIndex = 69
        '
        'ChkSalesDisplayHold
        '
        Me.ChkSalesDisplayHold.Location = New System.Drawing.Point(398, 376)
        Me.ChkSalesDisplayHold.Name = "ChkSalesDisplayHold"
        Me.ChkSalesDisplayHold.Properties.Caption = "Display Hold"
        Me.ChkSalesDisplayHold.Size = New System.Drawing.Size(123, 19)
        Me.ChkSalesDisplayHold.TabIndex = 68
        '
        'ChkSalesDisplayPrintName
        '
        Me.ChkSalesDisplayPrintName.Location = New System.Drawing.Point(397, 418)
        Me.ChkSalesDisplayPrintName.Name = "ChkSalesDisplayPrintName"
        Me.ChkSalesDisplayPrintName.Properties.Caption = " Display Print Name"
        Me.ChkSalesDisplayPrintName.Size = New System.Drawing.Size(123, 19)
        Me.ChkSalesDisplayPrintName.TabIndex = 70
        '
        'txtSalesPageSize
        '
        Me.txtSalesPageSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPageSize.Location = New System.Drawing.Point(102, 340)
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
        Me.Label68.Location = New System.Drawing.Point(6, 344)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(53, 13)
        Me.Label68.TabIndex = 28
        Me.Label68.Text = "Page Size"
        '
        'txtSalesPrinterName
        '
        Me.txtSalesPrinterName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPrinterName.Location = New System.Drawing.Point(102, 312)
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
        Me.lblPrinterName.Location = New System.Drawing.Point(4, 316)
        Me.lblPrinterName.Name = "lblPrinterName"
        Me.lblPrinterName.Size = New System.Drawing.Size(72, 13)
        Me.lblPrinterName.TabIndex = 26
        Me.lblPrinterName.Text = " Printer Name"
        '
        'chkSalesApplySchemeinExchWOBill
        '
        Me.chkSalesApplySchemeinExchWOBill.Location = New System.Drawing.Point(5, 400)
        Me.chkSalesApplySchemeinExchWOBill.Name = "chkSalesApplySchemeinExchWOBill"
        Me.chkSalesApplySchemeinExchWOBill.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalesApplySchemeinExchWOBill.Properties.Appearance.Options.UseFont = True
        Me.chkSalesApplySchemeinExchWOBill.Properties.Caption = "In case of without Bill, Apply Scheme on Sold Items in Exchange"
        Me.chkSalesApplySchemeinExchWOBill.Size = New System.Drawing.Size(327, 19)
        Me.chkSalesApplySchemeinExchWOBill.TabIndex = 31
        '
        'chkSalesPickLastSalePersonWOBill
        '
        Me.chkSalesPickLastSalePersonWOBill.Location = New System.Drawing.Point(5, 450)
        Me.chkSalesPickLastSalePersonWOBill.Name = "chkSalesPickLastSalePersonWOBill"
        Me.chkSalesPickLastSalePersonWOBill.Properties.Caption = "In case of without Bill, Pick Last Sales Person in Exchange"
        Me.chkSalesPickLastSalePersonWOBill.Size = New System.Drawing.Size(302, 19)
        Me.chkSalesPickLastSalePersonWOBill.TabIndex = 33
        '
        'chkSalesCheckSoldStatus
        '
        Me.chkSalesCheckSoldStatus.Location = New System.Drawing.Point(4, 425)
        Me.chkSalesCheckSoldStatus.Name = "chkSalesCheckSoldStatus"
        Me.chkSalesCheckSoldStatus.Properties.Caption = "Check for Sold Status of Items in Exchange"
        Me.chkSalesCheckSoldStatus.Size = New System.Drawing.Size(289, 19)
        Me.chkSalesCheckSoldStatus.TabIndex = 32
        '
        'chkSalesPickLastSaleDiscinExchWOBill
        '
        Me.chkSalesPickLastSaleDiscinExchWOBill.Location = New System.Drawing.Point(6, 375)
        Me.chkSalesPickLastSaleDiscinExchWOBill.Name = "chkSalesPickLastSaleDiscinExchWOBill"
        Me.chkSalesPickLastSaleDiscinExchWOBill.Properties.Caption = "In case of without Bill, Pick Discount of Last Sales in Exchange"
        Me.chkSalesPickLastSaleDiscinExchWOBill.Size = New System.Drawing.Size(334, 19)
        Me.chkSalesPickLastSaleDiscinExchWOBill.TabIndex = 30
        '
        'txtSalesDeliveryDays
        '
        Me.txtSalesDeliveryDays.AllowAlphabets = False
        Me.txtSalesDeliveryDays.AllowMoveToNextControl = True
        Me.txtSalesDeliveryDays.EditValue = 0
        Me.txtSalesDeliveryDays.Location = New System.Drawing.Point(722, 336)
        Me.txtSalesDeliveryDays.Name = "txtSalesDeliveryDays"
        Me.txtSalesDeliveryDays.Size = New System.Drawing.Size(43, 22)
        Me.txtSalesDeliveryDays.TabIndex = 67
        Me.txtSalesDeliveryDays.Tag = "No Of Copies To Print"
        Me.txtSalesDeliveryDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(568, 341)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(137, 14)
        Me.Label62.TabIndex = 66
        Me.Label62.Text = "Estimated Delivery Days"
        '
        'chkSalesCarryforwardSalePersonAtItemLevel
        '
        Me.chkSalesCarryforwardSalePersonAtItemLevel.Location = New System.Drawing.Point(5, 474)
        Me.chkSalesCarryforwardSalePersonAtItemLevel.Name = "chkSalesCarryforwardSalePersonAtItemLevel"
        Me.chkSalesCarryforwardSalePersonAtItemLevel.Properties.Caption = "Carry forward Salesperson Entry at Item Level"
        Me.chkSalesCarryforwardSalePersonAtItemLevel.Size = New System.Drawing.Size(281, 19)
        Me.chkSalesCarryforwardSalePersonAtItemLevel.TabIndex = 34
        '
        'txtTimingFrom
        '
        Me.txtTimingFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimingFrom.Location = New System.Drawing.Point(102, 285)
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
        Me.Label44.Location = New System.Drawing.Point(5, 288)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(37, 13)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "Timing"
        '
        'txtMessageOnBill
        '
        Me.txtMessageOnBill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessageOnBill.Location = New System.Drawing.Point(102, 261)
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
        Me.Label49.Location = New System.Drawing.Point(5, 265)
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
        Me.txtSalesNoOfCopiesToPrint.Location = New System.Drawing.Point(245, 236)
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
        Me.txtSalesNoOfItemsOnBill.Location = New System.Drawing.Point(245, 189)
        Me.txtSalesNoOfItemsOnBill.Name = "txtSalesNoOfItemsOnBill"
        Me.txtSalesNoOfItemsOnBill.Size = New System.Drawing.Size(43, 22)
        Me.txtSalesNoOfItemsOnBill.TabIndex = 17
        Me.txtSalesNoOfItemsOnBill.Tag = "No Of Items On Bill"
        Me.txtSalesNoOfItemsOnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalesDigit
        '
        Me.txtSalesDigit.AllowAlphabets = False
        Me.txtSalesDigit.AllowMoveToNextControl = True
        Me.txtSalesDigit.EditValue = 0
        Me.txtSalesDigit.Location = New System.Drawing.Point(254, 73)
        Me.txtSalesDigit.Name = "txtSalesDigit"
        Me.txtSalesDigit.Size = New System.Drawing.Size(34, 22)
        Me.txtSalesDigit.TabIndex = 7
        Me.txtSalesDigit.Tag = "Sales Digit"
        Me.txtSalesDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInvoiceHeadOnPrint
        '
        Me.txtInvoiceHeadOnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceHeadOnPrint.Location = New System.Drawing.Point(139, 213)
        Me.txtInvoiceHeadOnPrint.MaxLength = 50
        Me.txtInvoiceHeadOnPrint.Name = "txtInvoiceHeadOnPrint"
        Me.txtInvoiceHeadOnPrint.Size = New System.Drawing.Size(149, 21)
        Me.txtInvoiceHeadOnPrint.TabIndex = 19
        Me.txtInvoiceHeadOnPrint.Tag = "Invoice Head On Print"
        '
        'txtSalesDocStartNo
        '
        Me.txtSalesDocStartNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesDocStartNo.Location = New System.Drawing.Point(152, 74)
        Me.txtSalesDocStartNo.MaxLength = 50
        Me.txtSalesDocStartNo.Name = "txtSalesDocStartNo"
        Me.txtSalesDocStartNo.Size = New System.Drawing.Size(63, 21)
        Me.txtSalesDocStartNo.TabIndex = 5
        Me.txtSalesDocStartNo.Tag = "Doc Start No (Sales)"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Maroon
        Me.Label33.Location = New System.Drawing.Point(684, 123)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(89, 13)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "Allow Discount"
        Me.Label33.Visible = False
        '
        'chkSalesAllowBackDtBillCreation
        '
        Me.chkSalesAllowBackDtBillCreation.Location = New System.Drawing.Point(554, 254)
        Me.chkSalesAllowBackDtBillCreation.Name = "chkSalesAllowBackDtBillCreation"
        Me.chkSalesAllowBackDtBillCreation.Properties.Caption = "Allow Back Date Bill Creation"
        Me.chkSalesAllowBackDtBillCreation.Size = New System.Drawing.Size(172, 19)
        Me.chkSalesAllowBackDtBillCreation.TabIndex = 55
        '
        'chkSalesMsgOnAutoSMS
        '
        Me.chkSalesMsgOnAutoSMS.Location = New System.Drawing.Point(554, 229)
        Me.chkSalesMsgOnAutoSMS.Name = "chkSalesMsgOnAutoSMS"
        Me.chkSalesMsgOnAutoSMS.Properties.Caption = "Message On SMS"
        Me.chkSalesMsgOnAutoSMS.Size = New System.Drawing.Size(116, 19)
        Me.chkSalesMsgOnAutoSMS.TabIndex = 54
        '
        'chkSalesMsgOnAutoPrint
        '
        Me.chkSalesMsgOnAutoPrint.Location = New System.Drawing.Point(554, 204)
        Me.chkSalesMsgOnAutoPrint.Name = "chkSalesMsgOnAutoPrint"
        Me.chkSalesMsgOnAutoPrint.Properties.Caption = "Message On Print"
        Me.chkSalesMsgOnAutoPrint.Size = New System.Drawing.Size(116, 19)
        Me.chkSalesMsgOnAutoPrint.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(221, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 14)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Digit"
        '
        'cmbSalesDefPayMode
        '
        Me.cmbSalesDefPayMode.AutoComplete = True
        Me.cmbSalesDefPayMode.DisplayMember = "Led_Name"
        Me.cmbSalesDefPayMode.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesDefPayMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesDefPayMode.Location = New System.Drawing.Point(152, 120)
        Me.cmbSalesDefPayMode.Name = "cmbSalesDefPayMode"
        Me.cmbSalesDefPayMode.Size = New System.Drawing.Size(136, 21)
        Me.cmbSalesDefPayMode.TabIndex = 11
        Me.cmbSalesDefPayMode.ValueMember = "Led_Key"
        '
        'cmbSalesShowItemSelList
        '
        Me.cmbSalesShowItemSelList.AutoComplete = True
        Me.cmbSalesShowItemSelList.DisplayMember = "Led_Name"
        Me.cmbSalesShowItemSelList.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesShowItemSelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesShowItemSelList.Location = New System.Drawing.Point(152, 143)
        Me.cmbSalesShowItemSelList.Name = "cmbSalesShowItemSelList"
        Me.cmbSalesShowItemSelList.Size = New System.Drawing.Size(136, 21)
        Me.cmbSalesShowItemSelList.TabIndex = 13
        Me.cmbSalesShowItemSelList.Tag = "Show Item Selection List"
        Me.cmbSalesShowItemSelList.ValueMember = "Led_Key"
        '
        'cmbSalesAllowBillDelete
        '
        Me.cmbSalesAllowBillDelete.AutoComplete = True
        Me.cmbSalesAllowBillDelete.DisplayMember = "Led_Name"
        Me.cmbSalesAllowBillDelete.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesAllowBillDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesAllowBillDelete.Location = New System.Drawing.Point(661, 304)
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
        Me.cmbSalesAllowBillUpdate.Location = New System.Drawing.Point(433, 304)
        Me.cmbSalesAllowBillUpdate.Name = "cmbSalesAllowBillUpdate"
        Me.cmbSalesAllowBillUpdate.Size = New System.Drawing.Size(106, 21)
        Me.cmbSalesAllowBillUpdate.TabIndex = 61
        Me.cmbSalesAllowBillUpdate.Tag = "Allow Bill Update"
        Me.cmbSalesAllowBillUpdate.ValueMember = "Led_Key"
        '
        'cmbSalesToBeBilledOn
        '
        Me.cmbSalesToBeBilledOn.AutoComplete = True
        Me.cmbSalesToBeBilledOn.DisplayMember = "Led_Name"
        Me.cmbSalesToBeBilledOn.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesToBeBilledOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesToBeBilledOn.Location = New System.Drawing.Point(152, 166)
        Me.cmbSalesToBeBilledOn.Name = "cmbSalesToBeBilledOn"
        Me.cmbSalesToBeBilledOn.Size = New System.Drawing.Size(136, 21)
        Me.cmbSalesToBeBilledOn.TabIndex = 15
        Me.cmbSalesToBeBilledOn.Tag = "To Be Billed On"
        Me.cmbSalesToBeBilledOn.ValueMember = "Led_Key"
        '
        'cmbSalesNoSystem
        '
        Me.cmbSalesNoSystem.AutoComplete = True
        Me.cmbSalesNoSystem.DisplayMember = "Led_Name"
        Me.cmbSalesNoSystem.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSalesNoSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesNoSystem.Location = New System.Drawing.Point(152, 97)
        Me.cmbSalesNoSystem.Name = "cmbSalesNoSystem"
        Me.cmbSalesNoSystem.Size = New System.Drawing.Size(136, 21)
        Me.cmbSalesNoSystem.TabIndex = 9
        Me.cmbSalesNoSystem.ValueMember = "Led_Key"
        '
        'cmbDefSalesCardDiscAccount
        '
        Me.cmbDefSalesCardDiscAccount.AutoComplete = True
        Me.cmbDefSalesCardDiscAccount.DisplayMember = "Led_Name"
        Me.cmbDefSalesCardDiscAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesCardDiscAccount.Location = New System.Drawing.Point(152, 50)
        Me.cmbDefSalesCardDiscAccount.Name = "cmbDefSalesCardDiscAccount"
        Me.cmbDefSalesCardDiscAccount.Size = New System.Drawing.Size(136, 21)
        Me.cmbDefSalesCardDiscAccount.TabIndex = 3
        Me.cmbDefSalesCardDiscAccount.ValueMember = "Led_Key"
        '
        'cmbDefSalesCust
        '
        Me.cmbDefSalesCust.AutoComplete = True
        Me.cmbDefSalesCust.DisplayMember = "Led_Name"
        Me.cmbDefSalesCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDefSalesCust.Location = New System.Drawing.Point(152, 27)
        Me.cmbDefSalesCust.Name = "cmbDefSalesCust"
        Me.cmbDefSalesCust.Size = New System.Drawing.Size(136, 21)
        Me.cmbDefSalesCust.TabIndex = 1
        Me.cmbDefSalesCust.ValueMember = "Led_Key"
        '
        'chkSalesDisplayImageOnBill
        '
        Me.chkSalesDisplayImageOnBill.Location = New System.Drawing.Point(325, 54)
        Me.chkSalesDisplayImageOnBill.Name = "chkSalesDisplayImageOnBill"
        Me.chkSalesDisplayImageOnBill.Properties.Caption = "Display Image On Bill"
        Me.chkSalesDisplayImageOnBill.Size = New System.Drawing.Size(126, 19)
        Me.chkSalesDisplayImageOnBill.TabIndex = 36
        '
        'chkSalesDayClose
        '
        Me.chkSalesDayClose.Location = New System.Drawing.Point(554, 153)
        Me.chkSalesDayClose.Name = "chkSalesDayClose"
        Me.chkSalesDayClose.Properties.Caption = "Use Day Close"
        Me.chkSalesDayClose.Size = New System.Drawing.Size(96, 19)
        Me.chkSalesDayClose.TabIndex = 51
        '
        'chkSalesPrnOnSave
        '
        Me.chkSalesPrnOnSave.Location = New System.Drawing.Point(325, 204)
        Me.chkSalesPrnOnSave.Name = "chkSalesPrnOnSave"
        Me.chkSalesPrnOnSave.Properties.Caption = "Auto Print on save"
        Me.chkSalesPrnOnSave.Size = New System.Drawing.Size(114, 19)
        Me.chkSalesPrnOnSave.TabIndex = 42
        '
        'chkSalesLocationWiseStockCheck
        '
        Me.chkSalesLocationWiseStockCheck.Location = New System.Drawing.Point(554, 79)
        Me.chkSalesLocationWiseStockCheck.Name = "chkSalesLocationWiseStockCheck"
        Me.chkSalesLocationWiseStockCheck.Properties.Caption = "Location Wise Stock Check"
        Me.chkSalesLocationWiseStockCheck.Size = New System.Drawing.Size(158, 19)
        Me.chkSalesLocationWiseStockCheck.TabIndex = 48
        '
        'chkSalesChkCrLimitOnCrSale
        '
        Me.chkSalesChkCrLimitOnCrSale.Location = New System.Drawing.Point(325, 79)
        Me.chkSalesChkCrLimitOnCrSale.Name = "chkSalesChkCrLimitOnCrSale"
        Me.chkSalesChkCrLimitOnCrSale.Properties.Caption = "Check Credit Limit On Credit Sale"
        Me.chkSalesChkCrLimitOnCrSale.Size = New System.Drawing.Size(187, 19)
        Me.chkSalesChkCrLimitOnCrSale.TabIndex = 37
        '
        'chkSalesUseSeries
        '
        Me.chkSalesUseSeries.Location = New System.Drawing.Point(325, 29)
        Me.chkSalesUseSeries.Name = "chkSalesUseSeries"
        Me.chkSalesUseSeries.Properties.Caption = "Use Series"
        Me.chkSalesUseSeries.Size = New System.Drawing.Size(83, 19)
        Me.chkSalesUseSeries.TabIndex = 35
        '
        'chkSalesCtrWiseSeries
        '
        Me.chkSalesCtrWiseSeries.Location = New System.Drawing.Point(554, 29)
        Me.chkSalesCtrWiseSeries.Name = "chkSalesCtrWiseSeries"
        Me.chkSalesCtrWiseSeries.Properties.Caption = "Use Counter Wise Series"
        Me.chkSalesCtrWiseSeries.Size = New System.Drawing.Size(158, 19)
        Me.chkSalesCtrWiseSeries.TabIndex = 46
        '
        'chkSalesMergeDupBarcode
        '
        Me.chkSalesMergeDupBarcode.Location = New System.Drawing.Point(325, 279)
        Me.chkSalesMergeDupBarcode.Name = "chkSalesMergeDupBarcode"
        Me.chkSalesMergeDupBarcode.Properties.Caption = "Merge Duplicate Barcode"
        Me.chkSalesMergeDupBarcode.Size = New System.Drawing.Size(150, 19)
        Me.chkSalesMergeDupBarcode.TabIndex = 45
        '
        'chkSalesRestrictBillChgAfterPrint
        '
        Me.chkSalesRestrictBillChgAfterPrint.Location = New System.Drawing.Point(325, 255)
        Me.chkSalesRestrictBillChgAfterPrint.Name = "chkSalesRestrictBillChgAfterPrint"
        Me.chkSalesRestrictBillChgAfterPrint.Properties.Caption = "Restrict Bill Change After Print"
        Me.chkSalesRestrictBillChgAfterPrint.Size = New System.Drawing.Size(176, 19)
        Me.chkSalesRestrictBillChgAfterPrint.TabIndex = 44
        '
        'chkSalesLockBillDiscount
        '
        Me.chkSalesLockBillDiscount.Location = New System.Drawing.Point(325, 154)
        Me.chkSalesLockBillDiscount.Name = "chkSalesLockBillDiscount"
        Me.chkSalesLockBillDiscount.Properties.Caption = "Lock Bill Discount"
        Me.chkSalesLockBillDiscount.Size = New System.Drawing.Size(106, 19)
        Me.chkSalesLockBillDiscount.TabIndex = 40
        '
        'chkSalesLockManualDiscount
        '
        Me.chkSalesLockManualDiscount.Location = New System.Drawing.Point(554, 127)
        Me.chkSalesLockManualDiscount.Name = "chkSalesLockManualDiscount"
        Me.chkSalesLockManualDiscount.Properties.Caption = "Lock Manual Discount"
        Me.chkSalesLockManualDiscount.Size = New System.Drawing.Size(128, 19)
        Me.chkSalesLockManualDiscount.TabIndex = 50
        '
        'chkSalesLockSalesRt
        '
        Me.chkSalesLockSalesRt.Location = New System.Drawing.Point(325, 129)
        Me.chkSalesLockSalesRt.Name = "chkSalesLockSalesRt"
        Me.chkSalesLockSalesRt.Properties.Caption = "Lock Sale Rate"
        Me.chkSalesLockSalesRt.Size = New System.Drawing.Size(96, 19)
        Me.chkSalesLockSalesRt.TabIndex = 39
        '
        'chkSalesAllowZeroValueEntry
        '
        Me.chkSalesAllowZeroValueEntry.Location = New System.Drawing.Point(554, 54)
        Me.chkSalesAllowZeroValueEntry.Name = "chkSalesAllowZeroValueEntry"
        Me.chkSalesAllowZeroValueEntry.Properties.Caption = "Allow Zero Value Entry"
        Me.chkSalesAllowZeroValueEntry.Size = New System.Drawing.Size(138, 19)
        Me.chkSalesAllowZeroValueEntry.TabIndex = 47
        '
        'chkSalesSchemeBillWiseDisc
        '
        Me.chkSalesSchemeBillWiseDisc.Location = New System.Drawing.Point(697, 144)
        Me.chkSalesSchemeBillWiseDisc.Name = "chkSalesSchemeBillWiseDisc"
        Me.chkSalesSchemeBillWiseDisc.Properties.Caption = "Bill Wise"
        Me.chkSalesSchemeBillWiseDisc.Size = New System.Drawing.Size(69, 19)
        Me.chkSalesSchemeBillWiseDisc.TabIndex = 57
        Me.chkSalesSchemeBillWiseDisc.Visible = False
        '
        'chkSalesSchemeItemWiseDisc
        '
        Me.chkSalesSchemeItemWiseDisc.Location = New System.Drawing.Point(688, 169)
        Me.chkSalesSchemeItemWiseDisc.Name = "chkSalesSchemeItemWiseDisc"
        Me.chkSalesSchemeItemWiseDisc.Properties.Caption = "Item Wise"
        Me.chkSalesSchemeItemWiseDisc.Size = New System.Drawing.Size(82, 19)
        Me.chkSalesSchemeItemWiseDisc.TabIndex = 58
        Me.chkSalesSchemeItemWiseDisc.Visible = False
        '
        'chkSalesSchemeDisc
        '
        Me.chkSalesSchemeDisc.Location = New System.Drawing.Point(701, 194)
        Me.chkSalesSchemeDisc.Name = "chkSalesSchemeDisc"
        Me.chkSalesSchemeDisc.Properties.Caption = "Scheme"
        Me.chkSalesSchemeDisc.Size = New System.Drawing.Size(64, 19)
        Me.chkSalesSchemeDisc.TabIndex = 59
        Me.chkSalesSchemeDisc.Visible = False
        '
        'chkSalesAutoSMSBill
        '
        Me.chkSalesAutoSMSBill.Location = New System.Drawing.Point(325, 229)
        Me.chkSalesAutoSMSBill.Name = "chkSalesAutoSMSBill"
        Me.chkSalesAutoSMSBill.Properties.Caption = "Auto SMS Bill"
        Me.chkSalesAutoSMSBill.Size = New System.Drawing.Size(98, 19)
        Me.chkSalesAutoSMSBill.TabIndex = 43
        '
        'chkSalesAskForBill
        '
        Me.chkSalesAskForBill.Location = New System.Drawing.Point(554, 104)
        Me.chkSalesAskForBill.Name = "chkSalesAskForBill"
        Me.chkSalesAskForBill.Properties.Caption = "Ask For Bill"
        Me.chkSalesAskForBill.Size = New System.Drawing.Size(84, 19)
        Me.chkSalesAskForBill.TabIndex = 49
        '
        'chkSalesExchAgainstBill
        '
        Me.chkSalesExchAgainstBill.Location = New System.Drawing.Point(325, 104)
        Me.chkSalesExchAgainstBill.Name = "chkSalesExchAgainstBill"
        Me.chkSalesExchAgainstBill.Properties.Caption = "Exchange against bill"
        Me.chkSalesExchAgainstBill.Size = New System.Drawing.Size(126, 19)
        Me.chkSalesExchAgainstBill.TabIndex = 38
        '
        'chkSalesAllowBkDtBillPrn
        '
        Me.chkSalesAllowBkDtBillPrn.Location = New System.Drawing.Point(325, 179)
        Me.chkSalesAllowBkDtBillPrn.Name = "chkSalesAllowBkDtBillPrn"
        Me.chkSalesAllowBkDtBillPrn.Properties.Caption = "Allow back date bill print"
        Me.chkSalesAllowBkDtBillPrn.Size = New System.Drawing.Size(148, 19)
        Me.chkSalesAllowBkDtBillPrn.TabIndex = 41
        '
        'chkSalesAutoRdOff
        '
        Me.chkSalesAutoRdOff.Location = New System.Drawing.Point(554, 179)
        Me.chkSalesAutoRdOff.Name = "chkSalesAutoRdOff"
        Me.chkSalesAutoRdOff.Properties.Caption = "Auto Round Off"
        Me.chkSalesAutoRdOff.Size = New System.Drawing.Size(103, 19)
        Me.chkSalesAutoRdOff.TabIndex = 52
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(5, 193)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(107, 14)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "No Of Items In Bill"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 240)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 14)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "Copies to print (Max 3)"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(5, 216)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(128, 14)
        Me.Label58.TabIndex = 18
        Me.Label58.Text = "Invoice Heading(Print)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 14)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "No. System"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(5, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 14)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Doc Start #"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(554, 307)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(100, 14)
        Me.Label66.TabIndex = 62
        Me.Label66.Text = "Allow Bill Delete"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 14)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Card Disc A/c"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(322, 307)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(103, 14)
        Me.Label65.TabIndex = 60
        Me.Label65.Text = "Allow Bill Update"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(5, 146)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(139, 14)
        Me.Label59.TabIndex = 12
        Me.Label59.Text = "Show Item Selection List"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(5, 169)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(90, 14)
        Me.Label60.TabIndex = 14
        Me.Label60.Text = "To be Billed On"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(5, 123)
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
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Location = New System.Drawing.Point(328, 597)
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
        Me.btnCancel.Location = New System.Drawing.Point(419, 597)
        Me.btnCancel.LookAndFeel.SkinName = "Money Twins"
        Me.btnCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Close"
        '
        'ChkDisplayAllOptionsInBill
        '
        Me.ChkDisplayAllOptionsInBill.Location = New System.Drawing.Point(6, 78)
        Me.ChkDisplayAllOptionsInBill.Name = "ChkDisplayAllOptionsInBill"
        Me.ChkDisplayAllOptionsInBill.Properties.Caption = "Display All Options"
        Me.ChkDisplayAllOptionsInBill.Size = New System.Drawing.Size(133, 19)
        Me.ChkDisplayAllOptionsInBill.TabIndex = 11
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 622)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Configuration"
        Me.tabMain.ResumeLayout(False)
        Me.tabPgGeneral.ResumeLayout(False)
        CType(Me.pnlGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGeneral.ResumeLayout(False)
        CType(Me.grpAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAccounts.ResumeLayout(False)
        Me.grpAccounts.PerformLayout()
        CType(Me.chkWholeSaleBiling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.cmbApplnType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlSMSSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSMSSettings.ResumeLayout(False)
        Me.pnlSMSSettings.PerformLayout()
        CType(Me.cmbCalculateStockOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStockTransferOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAutoBackupOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoBackup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisplayImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCompanyInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCompanyInfo.ResumeLayout(False)
        Me.grpCompanyInfo.PerformLayout()
        CType(Me.chkUseMultiCounter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseMultiSalesperson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefPriceLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSystemSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDecInQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefStation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesperson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseMultiBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseMultiLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllowMultiPurRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDayClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBarcodeInfo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseMultiPriceLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMaintainStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaintainStock.ResumeLayout(False)
        Me.grpMaintainStock.PerformLayout()
        Me.pnlStockAlerts.ResumeLayout(False)
        Me.pnlStockAlerts.PerformLayout()
        CType(Me.chkRackWiseStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStockAlerts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMaintainStk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllowNegativeStk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBarcodeSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpApplyForProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApplyForProduct.ResumeLayout(False)
        Me.grpApplyForProduct.PerformLayout()
        CType(Me.chkUseSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseShade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseDesign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGenBarcodeOnStyleCreation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseMfgDt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseOccassion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseQuality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseSeason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseExpiryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProdSeriesTwoDigitPrefix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoGenCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProductMeasure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseTypeNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUseSizeWiseRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPgTrans.ResumeLayout(False)
        CType(Me.grpPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPurchase.ResumeLayout(False)
        Me.grpPurchase.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlSelectOption.ResumeLayout(False)
        CType(Me.chkLanding_cc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisplayWayBillNoAndEntryTex.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurDisplayStockUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisplaySalesOrderInPurchase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPurNoSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurDayClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurAllowMultiplePurRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurPickLastPurRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurAllowZeroValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurUseSeries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSalesRtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalesRtn.ResumeLayout(False)
        Me.grpSalesRtn.PerformLayout()
        CType(Me.chkSalesRtnPickLastSalePersonWOBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnCheckSoldStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnPickLastSaleDiscWOBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesRtnNoSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRtnCardDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesRtnCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnDayClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnAllowRtnWOSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnUseSeries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPurchaseRtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPurchaseRtn.ResumeLayout(False)
        Me.grpPurchaseRtn.PerformLayout()
        CType(Me.cmbPurRtnNoSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurRtnDayClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurRtnUseSeries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurRtnLocWiseStockCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurRtnSupplierSpecificPurRtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPurRtnAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        CType(Me.GrpMoreFeatures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpMoreFeatures.ResumeLayout(False)
        CType(Me.ChkMsgOnEmailSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAutoBillSendOnEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAutoSendBillOnWhatsApp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMsgOnBillSendWhatsApp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCreateBarcodeOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMessageOnSeriesChangeOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeriesChangeOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAutoEmailOnBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesUseSalesOrderinBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFocusOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesDisplayTodaySales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesDisplayLastBillDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesUseCoupon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesDisplayDeliveryDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkSalesDisplayHold.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkSalesDisplayPrintName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesApplySchemeinExchWOBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesPickLastSalePersonWOBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesCheckSoldStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesPickLastSaleDiscinExchWOBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesCarryforwardSalePersonAtItemLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAllowBackDtBillCreation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesMsgOnAutoSMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesMsgOnAutoPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesDefPayMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesShowItemSelList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesAllowBillDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesAllowBillUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesToBeBilledOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSalesNoSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesCardDiscAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefSalesCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesDisplayImageOnBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesDayClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesPrnOnSave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesLocationWiseStockCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesChkCrLimitOnCrSale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesUseSeries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesCtrWiseSeries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesMergeDupBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesRestrictBillChgAfterPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesLockBillDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesLockManualDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesLockSalesRt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAllowZeroValueEntry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesSchemeBillWiseDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesSchemeItemWiseDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesSchemeDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAutoSMSBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAskForBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesExchAgainstBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAllowBkDtBillPrn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesAutoRdOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkDisplayAllOptionsInBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents chkUseMultiPriceLevel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseMultiCounter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnReportPath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReportpath As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtAddressOnBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents chkDisplayImage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseSizeWiseRate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDefPriceLevel As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefStation As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbBarcode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDecInQty As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesperson As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblDefSalesperson As System.Windows.Forms.Label
    Friend WithEvents chkUseMultiBranch As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseMultiSalesperson As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseMultiLocation As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseExpiryDate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseTypeNo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseOccassion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseSeason As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseQuality As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseBrand As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpApplyForProduct As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkUseSize As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseShade As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseDesign As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseMfgDt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblApplyProduct As System.Windows.Forms.Label
    Friend WithEvents chkGenBarcodeOnStyleCreation As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpMaintainStock As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents chkUseBarcode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rdStockReorder As System.Windows.Forms.RadioButton
    Friend WithEvents rdStockMax As System.Windows.Forms.RadioButton
    Friend WithEvents rdStockMin As System.Windows.Forms.RadioButton
    Friend WithEvents chkRackWiseStock As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbBarcodeSeries As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents grpCompanyInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cmbSystemSeries As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents grpOthers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbAutoBackupOptions As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cmbStockTransferOn As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents cmbCalculateStockOn As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents grpAccounts As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents chkMaintainCostCtr As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMaintainBalBillByBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAutoGenCode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUseItemCode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkProdSeriesTwoDigitPrefix As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txtDelBackupDays As NumericTextBox.NumericTextBox
    Friend WithEvents chkAllowMultiPurRate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents pnlStockAlerts As System.Windows.Forms.Panel
    Friend WithEvents chkStockAlerts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkProductMeasure As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCRM As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtBarcodeInfo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcodeInfo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents chkBarcodeInfo2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDayClose As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbApplnType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents tabPgTrans As System.Windows.Forms.TabPage
    Friend WithEvents rdSalesRtn As System.Windows.Forms.RadioButton
    Friend WithEvents rdSales As System.Windows.Forms.RadioButton
    Friend WithEvents rdPurchaseRtn As System.Windows.Forms.RadioButton
    Friend WithEvents rdPurchase As System.Windows.Forms.RadioButton
    Friend WithEvents grpSalesRtn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtSalesRtnAcceptLastNDaysInvoiceOnReturn As NumericTextBox.NumericTextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtSalesRtnDigit As NumericTextBox.NumericTextBox
    Friend WithEvents txtSalesRtnDocStartNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbSalesRtnNoSystem As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesRtnCardDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesRtnCust As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkSalesRtnDayClose As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnMsgOnAutoPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnPrnOnSave As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnAllowRtnWOSales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnUseSeries As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents grpPurchaseRtn As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPurRtnDigit As NumericTextBox.NumericTextBox
    Friend WithEvents txtPurRtnDocStartNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbPurRtnNoSystem As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkPurRtnDayClose As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurRtnUseSeries As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurRtnLocWiseStockCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurRtnSupplierSpecificPurRtn As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurRtnAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpPurchase As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPurDigit As NumericTextBox.NumericTextBox
    Friend WithEvents txtPurDocStartNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbPurNoSystem As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkPurDayClose As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurAllowMultiplePurRate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurPickLastPurRate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurAllowZeroValue As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurUseSeries As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpSales As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTimingFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtMessageOnBill As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtSalesNoOfCopiesToPrint As NumericTextBox.NumericTextBox
    Friend WithEvents txtSalesNoOfItemsOnBill As NumericTextBox.NumericTextBox
    Friend WithEvents txtSalesDigit As NumericTextBox.NumericTextBox
    Friend WithEvents txtInvoiceHeadOnPrint As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesDocStartNo As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents chkSalesAllowBackDtBillCreation As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesMsgOnAutoSMS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesMsgOnAutoPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbSalesDefPayMode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSalesShowItemSelList As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSalesAllowBillDelete As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSalesAllowBillUpdate As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSalesToBeBilledOn As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbSalesNoSystem As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesCardDiscAccount As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmbDefSalesCust As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chkSalesDisplayImageOnBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesDayClose As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesPrnOnSave As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesLocationWiseStockCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesChkCrLimitOnCrSale As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesUseSeries As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesCtrWiseSeries As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesMergeDupBarcode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRestrictBillChgAfterPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesLockBillDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesLockManualDiscount As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesLockSalesRt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAllowZeroValueEntry As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesSchemeBillWiseDisc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesSchemeItemWiseDisc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesSchemeDisc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAutoSMSBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAskForBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesExchAgainstBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAllowBkDtBillPrn As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAutoRdOff As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents chkSalesRtnPickLastSaleDiscWOBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnCheckSoldStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesRtnPickLastSalePersonWOBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesCarryforwardSalePersonAtItemLevel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSalesDeliveryDays As NumericTextBox.NumericTextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents chkSalesPickLastSalePersonWOBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesCheckSoldStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesPickLastSaleDiscinExchWOBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesApplySchemeinExchWOBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbCashAc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents chkMaintAcc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSMSCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtSalesPrinterName As System.Windows.Forms.TextBox
    Friend WithEvents lblPrinterName As System.Windows.Forms.Label
    Friend WithEvents txtSalesPageSize As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents ChkSalesDisplayPrintName As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkSalesDisplayHold As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesDisplayDeliveryDetail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesUseCoupon As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesDisplayLastBillDetails As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesDisplayTodaySales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbFocusOn As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txtPurBarcodePageSize As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtPurBarcodePrinterName As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents chkDisplaySalesOrderInPurchase As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesUseSalesOrderinBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPurDisplayStockUpdate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSalesAutoEmailOnBill As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSalesEmailid As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents btnCopyBackUpPath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCopyBackUp As System.Windows.Forms.TextBox
    Friend WithEvents chkCopyBackUp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMessageOnSeriesChangeOption As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSeriesChangeOption As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCreateBarcodeOption As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkWholeSaleBiling As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSoftwareName As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents chkDisplayWayBillNoAndEntryTex As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSMSPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents txtSMSUser1 As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents chkLanding_cc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lnkseqproduct As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents pnlSelectOption As System.Windows.Forms.Panel
    Friend WithEvents lstOption1 As System.Windows.Forms.ListBox
    Friend WithEvents btnGrp1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelGrp1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstMain As System.Windows.Forms.ListBox
    Friend WithEvents btnCloseOption As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lnkFeatues As System.Windows.Forms.LinkLabel
    Friend WithEvents GrpMoreFeatures As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ChkMsgOnEmailSend As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkAutoBillSendOnEmail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkAutoSendBillOnWhatsApp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkMsgOnBillSendWhatsApp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCloseGrpOptionsFeaturs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkDisplayAllOptionsInBill As DevExpress.XtraEditors.CheckEdit
End Class
