Imports System.Data.SqlClient

Public Class frmSysConfiguration
    Dim Loading As Boolean = True
    Dim Relogin As Boolean
    Dim AdminAccess As Boolean


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FillInComboDetails()
        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select RATECAT_ID, RATECAT_NAME " _
                & " From RateCat  With(NoLock) " _
                & " Where RateCat_Id <> 0 And Status = '1' " _
                & " Order By RateCat_Id"
            Common.FillCombo2(Query, cmbDefPriceLevel, "RATECAT_NAME", "RATECAT_ID")

            Query = "Select STN_KEY, STN_NAME " _
                & " From Station  With(NoLock) " _
                & " Where Stn_Name <> '' And Status = '1' " _
                & BranchFixFilter _
                & " Order By Stn_Name"
            Common.FillCombo2(Query, cmbDefStation, "STN_NAME", "STN_KEY")

            ''Default customer
            Query = "Select LED_KEY, LED_NAME " _
                & " From Ledger  With(NoLock)  " _
                & " Where Led_Name <> '' And Status = '1' And Led_Cat In ('R', 'W', 'D') " _
                & BranchFixFilter _
                & " Order By Led_Name"
            Common.FillCombo2(Query, cmbDefSalesCust, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesRtnCust, "LED_NAME", "LED_KEY")

            ''Default salesperson
            Query = "Select LED_KEY, LED_NAME " _
                & " From Ledger  With(NoLock) " _
                & " Where Led_Name <> '' And Status = '1' And Led_Cat = 'S' " _
                & BranchFixFilter _
                & " Order By Led_Name"
            Common.FillCombo2(Query, cmbDefSalesperson, "LED_NAME", "LED_KEY")

            ''Default A/c
            Query = "Select '' LED_KEY, ''LED_NAME " _
                & " Union All " _
                & " Select LED_KEY, LED_NAME " _
                & " From Ledger  With(NoLock) " _
                & " Where Led_Name <> '' And Status = '1' And Led_Cat = 'L' " _
                & BranchFixFilter _
                & " Order By Led_Name"
            Common.FillCombo2(Query, cmbDefPurAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefPurRtnAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesRtnAccount, "LED_NAME", "LED_KEY")


            ''Default Discount A/c
            Common.FillCombo2(Query, cmbDefPurDiscAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefPurRtnDiscAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesDiscAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesRtnDiscAccount, "LED_NAME", "LED_KEY")


            ''Default Other Discount A/c
            Common.FillCombo2(Query, cmbDefSalesCardDiscAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesRtnCardDiscAccount, "LED_NAME", "LED_KEY")


            ''Default Other Cahrges A/c
            Common.FillCombo2(Query, cmbDefSalesOthChgsAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesRtnOthChgsAccount, "LED_NAME", "LED_KEY")


            ''Default Rd Off A/c
            Common.FillCombo2(Query, cmbDefPurRdOffAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefPurRtnRdOffAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesRdOffAccount, "LED_NAME", "LED_KEY")

            Common.FillCombo2(Query, cmbDefSalesRtnRdOffAccount, "LED_NAME", "LED_KEY")

            ''Treatment Rd Off A/c
            Common.FillCombo2(Query, cmbDefTreatmentAccount, "LED_NAME", "LED_KEY")


            Query = "Select '' LED_KEY, ''LED_NAME " _
                & " Union All " _
                & " Select LED_KEY, LED_NAME " _
                & " From Ledger  With(NoLock) " _
                & " Where Led_Name <> '' And Status = '1' And Led_Cat = 'L' And AccLGrp_Key = '" & SelBranchFixId & "1'" _
                & BranchFixFilter _
                & " Order By Led_Name"
            Common.FillCombo2(Query, cmbCashAc, "LED_NAME", "LED_KEY")

            With cmbBarcode.Items
                .Add("Product Wise")
                .Add("Document Wise")
                .Add("Unique")
            End With

            cmbBarcodeSeries.Items.Add("Product")
            cmbBarcodeSeries.Items.Add("Series")

            ''Number System
            'With cmbPurNoSystem.Items
            '    .Add("Continuous")
            '    .Add("Financial Year")
            '    .Add("Monthly")
            'End With

            'With cmbPurRtnNoSystem.Items
            '    .Add("Continuous")
            '    .Add("Financial Year")
            '    .Add("Monthly")
            'End With

            'With cmbSalesNoSystem.Items
            '    .Add("Continuous")
            '    .Add("Financial Year")
            '    .Add("Monthly")
            'End With

            'With cmbSalesRtnNoSystem.Items
            '    .Add("Continuous")
            '    .Add("Financial Year")
            '    .Add("Monthly")
            'End With

            With cmbDecInQty.Items
                .Add("No")
                .Add("Two")
                .Add("Three")
            End With

            cmbSystemSeries.Items.Add("A")
            cmbSystemSeries.Items.Add("B")

            cmbAutoBackupOptions.Items.Add("Daily")
            cmbAutoBackupOptions.Items.Add("Hourly")

            'With cmbStockTransferOn.Items
            '    .Add("MRP")
            '    .Add("Purchase Rate")
            '    .Add("Sale Rate")
            'End With

            cmbCalculateStockOn.Items.Add("Actual Rate")
            cmbCalculateStockOn.Items.Add("Average Rate")

            With cmbSalesDefPayMode.Items
                .Add("Cash")
                .Add("Credit Card")
                .Add("Credit Sale")
            End With

            'cmbSalesShowItemSelList.Items.Add("None")
            'cmbSalesShowItemSelList.Items.Add("All Items")
            'cmbSalesShowItemSelList.Items.Add("Items Having Stock")

            'cmbSalesToBeBilledOn.Items.Add("MRP")
            'cmbSalesToBeBilledOn.Items.Add("Purchase Rate")
            'cmbSalesToBeBilledOn.Items.Add("Normal")

            cmbSalesAllowBillUpdate.Items.Add("Only Payment")
            cmbSalesAllowBillUpdate.Items.Add("All Details")

            cmbSalesAllowBillDelete.Items.Add("No")
            cmbSalesAllowBillDelete.Items.Add("Last Bill")
            cmbSalesAllowBillDelete.Items.Add("All Bills")

            ' cmbApplnType.Items.Add("Both")
            ' cmbApplnType.Items.Add("Retail")
            ' cmbApplnType.Items.Add("Distribution")

            With cmbFocusOn.Items
                .Add("Barcode")
                .Add("Party")
                .Add("RefNo")
                .Add("Sales Person")
                .Add("Mobile No")
            End With



            btnBrowse.Enabled = IsServer()


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmSysConfiguration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillInComboDetails()
        RetrieveData()

        'chkUseMultiLocation.Text = "Multi " & GetSysCaptionAsPerId(SystemCaptionIdx.DefLocation)
        'chkProductMeasure.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefUnit)
        lblApplyProduct.Text = "Apply For " & GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct)
        chkUseBrand.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand)
        chkUseDesign.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle)
        'chkGenBarcodeOnStyleCreation.Text = "Generate " & GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle) & " on style creation"
        'chkUseOccassion.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefOccassion)
        chkProdSeriesTwoDigitPrefix.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct) & " Series 2 digit as prefix"
        'chkUseItemCode.Text = "Use " & GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct) & " Code"
        'chkUseQuality.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefQuality)
        'chkRackWiseStock.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefRack) & " Wise Stock"
        'chkUseSeason.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefSeason)
        chkUseShade.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefShade)
        chkUseSize.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefSize)
        ' chkPurRtnLocWiseStockCheck.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefLocation) & " Wise Stock Check"
        'chkSalesLocationWiseStockCheck.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefLocation) & " Wise Stock Check"

        '---------------18-01-2016----------------------
        'chksup_design.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefDisplaySupDesign)

        SetAsPerEdition()

        If Not AdminAccess Then
            'chkUseMultiBranch.Enabled = False
            'chkUseMultiCounter.Enabled = False
            'chkUseMultiLocation.Enabled = False
            'chkUseMultiSalesperson.Enabled = False
            'chkCRM.Enabled = False
            'cmbSystemSeries.Enabled = False
            'chkUseMultiPriceLevel.Enabled = False
            'chkDayClose.Enabled = False
            'chkUseSizeWiseRate.Enabled = False
            'chkUseQuality.Enabled = False
            'chkUseSeason.Enabled = False
            'chkUseOccassion.Enabled = False
            'chkUseMfgDt.Enabled = False
            'chkUseExpiryDate.Enabled = False
            'chkMaintainStk.Enabled = False
            'chkAllowNegativeStk.Enabled = False
            'chkRackWiseStock.Enabled = False
            'chkStockAlerts.Enabled = False
            'chkMaintAcc.Enabled = False

        Else
            Me.Text &= " (Administrator)"
        End If

        lnkMinQty.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.NewSoftware)))
        lnkSaleGrid.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.NewSoftware)))

        Loading = False
    End Sub

    Private Sub chkSMSFeature_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSMS.CheckedChanged
        pnlSMSSettings.Enabled = chkSMS.Checked

        chkSalesAutoSMSBill.Enabled = True
        chkSalesMsgOnAutoSMS.Enabled = True
        If Not chkSMS.Checked Then
            txtSMSUser.Clear()
            txtSMSPassword.Clear()
            '--------------24-05-2016--------------
            txtSMSUser1.Clear()
            txtSMSPassword1.Clear()

            chkSalesAutoSMSBill.Enabled = False
            chkSalesMsgOnAutoSMS.Enabled = False
        End If
    End Sub

    Private Sub RetrieveData()
        Try
            Me.Cursor = Cursors.WaitCursor

            ''General
            ''----------------------------------------------------------------------------------------------
            'chkUseMultiBranch.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiBranch)))
            'chkUseMultiLocation.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiLocation)))
            'chkUseMultiLocation_CheckedChanged(chkUseMultiLocation, Nothing)
            'chkUseMultiCounter.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiCounter)))
            ' If GetSettingAsPerId(ApplnSettingsIdx.GenMutiSalesPerson) = True Then
            chkUseMultiSalesperson.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiSalesPerson)))
            chkUseMultiSalesperson.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiSalesPerson)))


            lblDefSalesperson.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiSalesPerson)))
            cmbDefSalesperson.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiSalesPerson)))


            chkUseMultiSalesperson_CheckedChanged(chkUseMultiSalesperson, Nothing)



            If GetSettingAsPerId(ApplnSettingsIdx.GenSystemSeries) = "B" Then
                Label53.Visible = True : cmbSystemSeries.Visible = True
                cmbSystemSeries.SelectedIndex = 1

            Else
                Label53.Visible = False : cmbSystemSeries.Visible = False
                cmbSystemSeries.SelectedIndex = 0

            End If
            cmbDefStation.Value = GetBranchSettingAsPerId(BranchWiseSettings.GenDefStation)
            cmbDecInQty.SelectedIndex = Val(GetSettingAsPerId(ApplnSettingsIdx.GenDigitsInDecimalQty))
            ' chkUseMultiPriceLevel.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseMultiPriceLevel)))
            cmbDefPriceLevel.SelectedIndex = Val(GetSettingAsPerId(ApplnSettingsIdx.GenPriceLevel))

            txtMessageOnBill.Text = GetSettingAsPerId(ApplnSettingsIdx.GenMessageOnBill) & ""
            txtTimingFrom.Text = GetSettingAsPerId(ApplnSettingsIdx.GenTiming) & ""
            txtAddressOnBarcode.Text = GetSettingAsPerId(ApplnSettingsIdx.GenAddressOnBarcode) & ""
            txtTerms.Text = GetSettingAsPerId(ApplnSettingsIdx.GenTermsAndConditions) & ""

            ' chkGenBarcodeOnStyleCreation.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenGenerateBarcodeOnStyleCreation)))
            chkUseDesign.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseDesign)))
            chkUseDesign_CheckedChanged(chkUseDesign, Nothing)
            chkUseShade.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseShade)))
            chkUseSize.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSize)))
            'chkUseSizeWiseRate.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSizeWiseRate)))
            chkUseBrand.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseBrand)))

            '---------------------------18-01-2016------------------
            '  chksup_design.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenDisplaySupDesign)))
            '__shishil 03052017
            chksup_design.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenSupplierDesignDisplay)))
            ''
            chkUseQuality.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseQuality)))
            chkUseQuality.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseQuality)))
            chkUseSeason.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSeason)))
            chkUseSeason.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSeason)))
            chkUseOccassion.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseOccassion)))
            chkUseOccassion.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseOccassion)))
            'chkUseMfgDt.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseMfgDt)))
            '  chkUseExpiryDate.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseExpiryDt)))
            chkUseTypeNo.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseType)))

            txtInvoiceHeadingForVATNo.Text = GetSettingAsPerId(ApplnSettingsIdx.InvoiceHeadingForVatNo)
            txtInvoiceHeadingWithoutVATNo.Text = GetSettingAsPerId(ApplnSettingsIdx.InvoiceHeadingWithoutVatNo)


            'chkUseItemCode.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseItemCode)))
            'chkUseItemCode_CheckedChanged(chkUseItemCode, Nothing)

            ' chkAutoGenCode.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenAutoGenerateCode)))
            chkProdSeriesTwoDigitPrefix.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenProductSeries2DigitsAsPrefix)))
            chkProdSeriesTwoDigitPrefix.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenProductSeries2DigitsAsPrefix)))
            chkMaintainStk.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMaintainStock)))
            chkAllowNegativeStk.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenAllowNegativeStock)))
            ' chkRackWiseStock.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenRackWise)))

            chkUseBarcode.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseBarcode)))
            cmbBarcode.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseBarcode)))
            chkUseBarcode.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseBarcode)))
            If GetSettingAsPerId(ApplnSettingsIdx.GenMaintainBarcode) = "P" Then
                cmbBarcode.SelectedIndex = 0
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.GenMaintainBarcode) = "D" Then
                cmbBarcode.SelectedIndex = 1
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.GenMaintainBarcode) = "U" Then
                cmbBarcode.SelectedIndex = 2
            End If

            If GetSettingAsPerId(ApplnSettingsIdx.GenBarcodeSeriesFrom) = "P" Then
                cmbBarcodeSeries.SelectedIndex = 0
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.GenBarcodeSeriesFrom) = "S" Then
                cmbBarcodeSeries.SelectedIndex = 1
            End If


            'chkStockAlerts.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenStockLevelAlerts)))
            'chkStockAlerts_CheckedChanged(chkStockAlerts, Nothing)

            'If chkStockAlerts.Checked Then
            '    If Val(GetSettingAsPerId(ApplnSettingsIdx.GenStockAlerts)) = 0 Then
            '        rdStockMin.Checked = True
            '    ElseIf Val(GetSettingAsPerId(ApplnSettingsIdx.GenStockAlerts)) = 1 Then
            '        rdStockMax.Checked = True
            '    ElseIf Val(GetSettingAsPerId(ApplnSettingsIdx.GenStockAlerts)) = 2 Then
            '        rdStockReorder.Checked = True
            '    End If
            'End If

            chkSMS.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenSMSFeature)))
            chkSMS.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenSMSFeature)))
            pnlSMSSettings.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenSMSFeature)))
            chkSMSFeature_CheckedChanged(chkSMS, Nothing)
            txtSMSUser.Text = GetSettingAsPerId(ApplnSettingsIdx.GenSMSUser)
            txtSMSPassword.Text = GetSettingAsPerId(ApplnSettingsIdx.GenSMSPassword)

            txtSMSUser1.Text = GetSettingAsPerId(ApplnSettingsIdx.GenSMSUser1)
            txtSMSPassword1.Text = GetSettingAsPerId(ApplnSettingsIdx.GenSMSPassword1)

            chkEmail.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenEmailFeature)))
            chkEmail.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenEmailFeature)))
            chkEmail_CheckedChanged(chkEmail, Nothing)
            txtEmailSenderName.Text = GetSettingAsPerId(ApplnSettingsIdx.GenEmailSenderName)
            txtEmailUser.Text = GetSettingAsPerId(ApplnSettingsIdx.GenEmailUser)
            txtEmailPassword.Text = GetSettingAsPerId(ApplnSettingsIdx.GenEmailPassword)

            txtBackupPath.Text = GetSettingAsPerId(ApplnSettingsIdx.GenBackupPath)
            chkAutoBackup.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenAutoBackup)))
            chkAutoBackup_CheckedChanged(chkAutoBackup, Nothing)
            txtCopyBackUp.Text = GetSettingAsPerId(ApplnSettingsIdx.GenCopyBackupPath)
            chkCopyBackUp.Checked = CBool(IIf(txtCopyBackUp.Text.Length > 0, 1, 0))
            chkCopyBackUp_CheckedChanged(chkCopyBackUp, Nothing)
            If GetSettingAsPerId(ApplnSettingsIdx.GenBackupPeriod) = "D" Then
                cmbAutoBackupOptions.SelectedIndex = 0
            Else
                cmbAutoBackupOptions.SelectedIndex = 1
            End If

            txtDelBackupDays.Text = GetSettingAsPerId(ApplnSettingsIdx.GenDeleteBackupAfterDays)

            'If GetSettingAsPerId(ApplnSettingsIdx.GenStockTransferOn) = "M" Then
            '    cmbStockTransferOn.SelectedIndex = 0
            'ElseIf GetSettingAsPerId(ApplnSettingsIdx.GenStockTransferOn) = "P" Then
            '    cmbStockTransferOn.SelectedIndex = 1
            'ElseIf GetSettingAsPerId(ApplnSettingsIdx.GenStockTransferOn) = "S" Then
            '    cmbStockTransferOn.SelectedIndex = 2
            'End If

            If GetSettingAsPerId(ApplnSettingsIdx.GenCalculateStockOn) = "C" Then
                cmbCalculateStockOn.SelectedIndex = 0
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.GenCalculateStockOn) = "V" Then
                cmbCalculateStockOn.SelectedIndex = 1
            End If

            chkDisplayImage.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenDisplayImage)))
            txtProdImgPath.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenDisplayImage)))
            btnProdImagePath.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenDisplayImage)))
            chkDisplayImage.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenDisplayImage)))
            chkDisplayImage_CheckedChanged(chkDisplayImage, Nothing)
            txtProdImgPath.Text = GetSettingAsPerId(ApplnSettingsIdx.GenImagePath)
            txtReportpath.Text = GetSettingAsPerId(ApplnSettingsIdx.GenReportPath)
            chkMaintainBalBillByBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMaintainBalanceBillByBill)))

            chkMaintainCostCtr.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMaintainCostCenter)))
            'chkAllowMultiPurRate.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenAllowMultiplePurRate)))
            ' chkProductMeasure.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenProductMeasurement)))
            chkCRM.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenCRM)))
            chkCRM.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenCRM)))
            txtBarcodeInfo1.Text = GetSettingAsPerId(ApplnSettingsIdx.GenBarcodeInfo1)
            chkBarcodeInfo2.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenBarcodeInfo2Flag)))
            txtBarcodeInfo2.Text = GetSettingAsPerId(ApplnSettingsIdx.GenBarcodeInfo2)
            ' chkDayClose.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenDayClose)))
            'chkDayClose_CheckedChanged(chkDayClose, Nothing)

            If GetSettingAsPerId(ApplnSettingsIdx.GenTypeOfSoftware) = "B" Then
                'cmbApplnType.SelectedIndex = 0
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.GenTypeOfSoftware) = "R" Then
                'cmbApplnType.SelectedIndex = 1
            Else
                'cmbApplnType.SelectedIndex = 2
            End If
            chkMaintAcc.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMaintainAccounts)))
            Loading = True
            chkMaintAcc_CheckedChanged(chkMaintAcc, Nothing)
            Loading = False

            txtSMSCompany.Text = GetSettingAsPerId(ApplnSettingsIdx.GenSMSCompany)

            ''Purchase
            ''----------------------------------------------------------------------------------------------
            cmbDefPurAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurAccount)
            cmbDefPurDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurDiscAccount)
            cmbDefPurRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRdOffAccount)

            'Dim NumSys As String = GetSettingAsPerId(ApplnSettingsIdx.PurNumberSystem)
            'If NumSys = "C" Then
            '    cmbPurNoSystem.SelectedIndex = 0    ''Continuous
            'ElseIf NumSys = "F" Then
            '    cmbPurNoSystem.SelectedIndex = 1    ''Financial Yr
            'ElseIf NumSys = "M" Then
            '    cmbPurNoSystem.SelectedIndex = 2    ''Monthly
            'End If

            'chkPurUseSeries.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurUseSeries)))
            'txtPurDocStartNo.Text = GetSettingAsPerId(ApplnSettingsIdx.PurDocStartNo)
            'txtPurDigit.Text = GetSettingAsPerId(ApplnSettingsIdx.PurDigit)
            chkPurAutoRdOff.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurAutoRdOff)))
            chkPurAutoRdOff.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurAutoRdOff)))
            chkPurPickLastPurRate.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurPickLastPurchaseRate)))
            chkPurPickLastPurRate.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurPickLastPurchaseRate)))
            chkPurAllowZeroValue.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurAllowZeroValue)))

            chkAutoBarcodePrintonSave.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.AutoBarcodePrintOnSaveInPurchase)))
            chkPMessageOnPrintBarcode.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.MessageOnPrintBarcodeInPurchase)))


            chkPurAllowZeroValue.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurAllowZeroValue)))
            ' chkPurDayClose.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurDayClose)))
            txtPurBarcodePrinterName.Text = GetSettingAsPerId(ApplnSettingsIdx.BarcodePrinterName)
            txtPurBarcodePageSize.Text = GetSettingAsPerId(ApplnSettingsIdx.BarcodePageSize)
            ' chkDisplaySalesOrderInPurchase.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurchaseDisplaySalesOrderinPurchase)))
            'chkPurDisplayStockUpdate.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.DisplayStockUpdateInPurchase)))


            ''Purchase Return
            ''----------------------------------------------------------------------------------------------
            cmbDefPurRtnAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRtnAccount)
            cmbDefPurRtnDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRtnDiscAccount)
            cmbDefPurRtnRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRtnRdOffAccount)

            'NumSys = GetSettingAsPerId(ApplnSettingsIdx.PurRtnNumberSystem)
            'If NumSys = "C" Then    ''Continuous
            '    ' cmbPurRtnNoSystem.SelectedIndex = 0
            'ElseIf NumSys = "F" Then    ''Financial Yr
            '    ' cmbPurRtnNoSystem.SelectedIndex = 1
            'ElseIf NumSys = "M" Then    ''Monthly
            '    ' cmbPurRtnNoSystem.SelectedIndex = 2
            'End If

            'chkPurRtnUseSeries.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurRtnUseSeries)))
            'txtPurRtnDocStartNo.Text = GetSettingAsPerId(ApplnSettingsIdx.PurRtnDocStartNo)
            ' txtPurRtnDigit.Text = GetSettingAsPerId(ApplnSettingsIdx.PurRtnDigit)
            chkPurRtnAutoRdOff.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurRtnAutoRdOff)))
            chkPurRtnSupplierSpecificPurRtn.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurRtnSupplierSpecificPurRtn)))
            ' chkPurRtnLocWiseStockCheck.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurRtnLocationWiseStockCheck)))
            'chkPurRtnDayClose.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.PurRtnDayClose)))


            ''Sales
            ''----------------------------------------------------------------------------------------------
            cmbDefSalesCust.SelectedValue = GetBranchSettingAsPerId(BranchWiseSettings.SalesDefaultCustomer)
            cmbDefSalesAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesAccount)
            cmbDefSalesDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesDiscAccount)
            cmbDefSalesCardDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesCardDiscAccount)
            cmbDefSalesOthChgsAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesOthChargesAccount)
            cmbDefSalesRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRdOffAccount)

            'NumSys = GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem)
            'If NumSys = "C" Then    ''Continuous
            '    cmbSalesNoSystem.SelectedIndex = 0
            'ElseIf NumSys = "F" Then    ''Finanacial Yr
            '    cmbSalesNoSystem.SelectedIndex = 1
            'ElseIf NumSys = "M" Then    ''Monthly
            '    cmbSalesNoSystem.SelectedIndex = 2
            'End If

            'chkSalesUseSeries.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesUseSeries)))
            'chkSalesCtrWiseSeries.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesCounterWiseSeries)))
            'txtSalesDocStartNo.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesDocStartNo)
            'txtSalesDigit.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesDigit)
            'chkSalesDisplayImageOnBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDisplayImageOnBill)))
            'chkSalesAllowZeroValueEntry.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowZeroValueEntry)))
            'cmbSalesShowItemSelList.SelectedIndex = Val(GetSettingAsPerId(ApplnSettingsIdx.SalesShowItemWiseSelectionList))
            'cmbSalesToBeBilledOn.SelectedIndex = Val(GetSettingAsPerId(ApplnSettingsIdx.SalesToBeBilledOn))
            txtSalesNoOfItemsOnBill.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesNoOfItemsInBill)
            cmbSalesDefPayMode.SelectedIndex = Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDefaultPayMode))
            'chkSalesChkCrLimitOnCrSale.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesCheckCreditLimitCreditSale)))
            'chkSalesLocationWiseStockCheck.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesLocationWiseStockCheck)))
            chkSalesExchAgainstBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesExchangeAgainstBill)))
            chkSalesAskForBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAskForBill)))
            chkSalesLockSalesRt.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesLockSaleRate)))
            ' chkSalesLockManualDiscount.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesLockManualDiscount)))
            chkSalesLockBillDiscount.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesLockBillDiscount)))
            'chkSalesSchemeDisc.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowDiscountScheme)))
            'chkSalesSchemeItemWiseDisc.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowItemWiseDiscount)))
            'chkSalesSchemeBillWiseDisc.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBillWiseDiscount)))
            chkSalesAutoRdOff.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoRoundOff)))
            txtInvoiceHeadOnPrint.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesInvoiceHeadingInPrint)
            txtSalesNoOfCopiesToPrint.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesNoOfCopiesToPrint)
            chkSalesAllowBkDtBillPrn.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBackDtBillPrint)))
            chkSalesPrnOnSave.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoPrintOnSave)))
            chkSalesMsgOnAutoPrint.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesMessageOnAutoPrint)))
            chkSalesAutoSMSBill.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoSMSBill)))
            chkSalesAutoSMSBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoSMSBill)))
            chkSalesMsgOnAutoSMS.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesMessageOnAutoSMS)))
            chkSalesMsgOnAutoSMS.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesMessageOnAutoSMS)))
            chkSalesRestrictBillChgAfterPrint.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRestrictBillChangeAfterPrint)))
            'chkSalesDayClose.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDayClose)))
            chkSalesAllowBackDtBillCreation.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBackDateBillCreation)))
            chkSalesAllowBackDtBillCreation.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBackDateBillCreation)))
            chkSalesMergeDupBarcode.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowMergeBarCode)))

            If GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBillUpdate) = "P" Then
                cmbSalesAllowBillUpdate.SelectedIndex = 0   'Only Payment
            Else
                cmbSalesAllowBillUpdate.SelectedIndex = 1   'All Bills
            End If

            If GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBillDelete) = "N" Then
                cmbSalesAllowBillDelete.SelectedIndex = 0   'No
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBillDelete) = "L" Then
                cmbSalesAllowBillDelete.SelectedIndex = 1   'Last Bill
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBillDelete) = "A" Then
                cmbSalesAllowBillDelete.SelectedIndex = 1   'All Bills
            End If

            'chkSalesPickLastSaleDiscinExchWOBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesPickDiscofLastSalesinExchWOBill)))
            'chkSalesApplySchemeinExchWOBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesApplySchemeonSoldIteminExchWOBill)))
            'chkSalesCheckSoldStatus.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesCheckforSoldStatusinExchBill)))
            'chkSalesPickLastSalePersonWOBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesPickLastSalesPersoninExchWOBill)))
            'chkSalesCarryforwardSalePersonAtItemLevel.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesCarryforwardSalespersonEntryatItemLevel)))
            'txtSalesDeliveryDays.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesEstimatedDeliveryDays)
            txtSalesPrinterName.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesPrinterName)
            txtSalesPageSize.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesPageSize)
            'ChkSalesDisplayHold.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDisplayHold)))
            'chkSalesDisplayDeliveryDetail.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDisplayDeliveryDetail)))
            'ChkSalesDisplayPrintName.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesPrintName)))
            'chkSalesUseCoupon.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesUseCoupon)))
            chkSalesDisplayLastBillDetails.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDisplayLastBillDetails)))
            'chkSalesDisplayTodaySales.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDisplayTodaySales)))
            chkSalesAutoEmailOnBill.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoEmail)))
            Label67.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoEmail)))
            txtSalesEmailid.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoEmail)))
            chkSalesAutoEmailOnBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAutoEmail)))
            chkSalesAutoEmailOnBill_CheckedChanged(chkSalesAutoEmailOnBill, Nothing)
            txtSalesEmailid.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesEmailId)
            chkSalesUseSalesOrderinBill.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesOrderInBill)))
            chkSalesUseSalesOrderinBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesOrderInBill)))
            chkSalesUseSalesOrderinBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesOrderInBill)))

            chkAllowBackDateBillDelete.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBackDtBillDelete)))
            chkAllowBackDateBillEdit.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowBackDtBillEdit)))
            chkAllowfocusonBillDiscount.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesAllowFocusOnBillDisc)))
            txtTotalNoOfEdit.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesAllowNoOfTimesforBillEdit)

            If GetSettingAsPerId(ApplnSettingsIdx.SalesFocusOn) = "B" Then
                cmbFocusOn.SelectedIndex = 0   'Barcode
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesFocusOn) = "C" Then
                cmbFocusOn.SelectedIndex = 1   'Party
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesFocusOn) = "R" Then
                cmbFocusOn.SelectedIndex = 2   'RefNo
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesFocusOn) = "S" Then
                cmbFocusOn.SelectedIndex = 3   'Sales Person
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesFocusOn) = "M" Then
                cmbFocusOn.SelectedIndex = 4   'Mobile No
            End If



            ''Sales Rtn
            ''----------------------------------------------------------------------------------------------
            cmbDefSalesRtnCust.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnDefaultCustomer)
            cmbDefSalesRtnAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnAccount)
            cmbDefSalesRtnDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnDiscAccount)
            cmbDefSalesRtnCardDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnCardDiscAccount)
            cmbDefSalesRtnOthChgsAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnOthChargesAccount)
            cmbDefSalesRtnRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnRdOffAccount)

            'NumSys = GetSettingAsPerId(ApplnSettingsIdx.SalesRtnNumberSystem)
            'If NumSys = "C" Then    ''Continuous
            '    ' cmbSalesRtnNoSystem.SelectedIndex = 0
            'ElseIf NumSys = "F" Then    ''Financial Yr
            '    ' cmbSalesRtnNoSystem.SelectedIndex = 1
            'ElseIf NumSys = "M" Then    ''Monthly
            '    ' cmbSalesRtnNoSystem.SelectedIndex = 2
            'End If

            'chkSalesRtnUseSeries.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnUseSeries)))
            'txtSalesRtnDocStartNo.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesRtnDocStartNo)
            'txtSalesRtnDigit.Text = GetSettingAsPerId(ApplnSettingsIdx.SalesRtnDigit)
            chkSalesRtnAutoRdOff.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnAutoRoundOff)))
            chkSalesRtnAllowRtnWOSales.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnAllowRtnWithoutSales)))
            chkSalesRtnPrnOnSave.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnAutoPrintOnSave)))
            chkSalesRtnMsgOnAutoPrint.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnMessageOnAutoPrint)))
            'chkSalesRtnDayClose.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnDayClose)))
            txtSalesRtnAcceptLastNDaysInvoiceOnReturn.EditValue = Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnAcceptLastNDaysInvoiceForRtn))

            'chkSalesRtnPickLastSaleDiscWOBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnPickDiscofLastSalesWOBill)))
            'chkSalesRtnCheckSoldStatus.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnCheckforSoldStatusofItems)))
            'chkSalesRtnPickLastSalePersonWOBill.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.SalesRtnPickLastSalesPersonWOBill)))


            Query = "Select * from ApplnBrSettings  With(NoLock) " _
                & " Where CoBr_Id = '" & SelBranchId & "'"
            Dim Settings As DataTable = Common.GetDataTable(Query)
            'Dim recRow As DataRow

            'For Each recRow In Settings.Rows
            cmbDefPurAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurAccount)
            cmbDefPurDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurDiscAccount)
            cmbDefPurRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRdOffAccount)

            cmbDefPurRtnAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRtnAccount)
            cmbDefPurRtnDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRtnDiscAccount)
            cmbDefPurRtnRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.PurRtnRdOffAccount)

            cmbDefSalesAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesAccount)
            cmbDefSalesDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesDiscAccount)
            cmbDefSalesCardDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesCardDiscAccount)
            cmbDefSalesOthChgsAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesOthChargesAccount)
            cmbDefSalesRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRdOffAccount)
            cmbDefSalesCust.SelectedValue = GetBranchSettingAsPerId(BranchWiseSettings.SalesDefaultCustomer)

            cmbDefSalesRtnAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnAccount)
            cmbDefSalesRtnDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnDiscAccount)
            cmbDefSalesRtnCardDiscAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnCardDiscAccount)
            cmbDefSalesRtnOthChgsAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnOthChargesAccount)
            cmbDefSalesRtnRdOffAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnRdOffAccount)
            cmbDefSalesRtnCust.Value = GetBranchSettingAsPerId(BranchWiseSettings.SalesRtnDefaultCustomer)

            cmbDefTreatmentAccount.Value = GetBranchSettingAsPerId(BranchWiseSettings.GenTreatmentAccount)

            cmbDefStation.Value = GetBranchSettingAsPerId(BranchWiseSettings.GenDefStation)
            cmbDefSalesperson.Value = GetBranchSettingAsPerId(BranchWiseSettings.GenDefSalesPerson)
            If cmbCashAc.Items.Count > 0 Then
                cmbCashAc.Value = GetBranchSettingAsPerId(BranchWiseSettings.GenCashAccount)
            Else
                cmbCashAc.Value = ""
            End If

            ReportPath = GetSettingAsPerId(ApplnSettingsIdx.GenReportPath)
            Emai_Id = GetSettingAsPerId(ApplnSettingsIdx.GenEmailUser)
            Emai_Pass = GetSettingAsPerId(ApplnSettingsIdx.GenEmailPassword)

            ChkAutoPrintonSaveReceiptVoucher.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.AutoPrintOnSaveReceiptVoucher)))
            ChkMasssageOnPrint.Checked = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.MasssageOnPrint)))
            'Next recRow

            'chkUseMultiCounter_CheckedChanged(chkUseMultiCounter, Nothing)


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub SaveSettings()
        Dim Trans As SqlTransaction = Nothing
        Dim NumSys As String = ""
        Dim ComboValue As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()



            ''Purchase
            ''----------------------------------------------------------------------------------------------



            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefPurAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.PurAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefPurDiscAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.PurDiscAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefPurRdOffAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.PurRdOffAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)


            'If cmbPurNoSystem.SelectedIndex = 0 Then
            '    NumSys = "C"
            'ElseIf cmbPurNoSystem.SelectedIndex = 1 Then
            '    NumSys = "F"
            'ElseIf cmbPurNoSystem.SelectedIndex = 2 Then
            '    NumSys = "M"
            'End If

            'Query = "Update ApplnSettings Set AppSett_Value = '" & NumSys & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurNumberSystem
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurUseSeries.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurUseSeries
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtPurDocStartNo.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurDocStartNo
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtPurDigit.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurDigit
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurAutoRdOff.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.PurAutoRdOff
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurPickLastPurRate.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.PurPickLastPurchaseRate
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurAllowZeroValue.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.PurAllowZeroValue
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAutoBarcodePrintonSave.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.AutoBarcodePrintOnSaveInPurchase
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPMessageOnPrintBarcode.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.MessageOnPrintBarcodeInPurchase
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurDayClose.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurDayClose
            'Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & txtPurBarcodePrinterName.Text & "'" _
              & " Where AppSett_Id = " & ApplnSettingsIdx.BarcodePrinterName
            Common.ExecuteQuery(Query, Trans)



            Query = "Update ApplnSettings Set AppSett_Value = '" & txtPurBarcodePageSize.Text & "'" _
              & " Where AppSett_Id = " & ApplnSettingsIdx.BarcodePageSize
            Common.ExecuteQuery(Query, Trans)


            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkDisplaySalesOrderInPurchase.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurchaseDisplaySalesOrderinPurchase
            'Common.ExecuteQuery(Query, Trans)



            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurDisplayStockUpdate.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.DisplayStockUpdateInPurchase
            'Common.ExecuteQuery(Query, Trans)

            ''Purchase Return
            ''----------------------------------------------------------------------------------------------
            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefPurRtnAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.PurRtnAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefPurRtnDiscAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.PurRtnDiscAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefPurRtnRdOffAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.PurRtnRdOffAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            'If cmbPurRtnNoSystem.SelectedIndex = 0 Then
            '    NumSys = "C"
            'ElseIf cmbPurRtnNoSystem.SelectedIndex = 1 Then
            '    NumSys = "F"
            'ElseIf cmbPurRtnNoSystem.SelectedIndex = 2 Then
            '    NumSys = "M"
            'End If

            'Query = "Update ApplnSettings Set AppSett_Value = '" & NumSys & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnNumberSystem
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurRtnUseSeries.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnUseSeries
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtPurRtnDocStartNo.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnDocStartNo
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtPurRtnDigit.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnDigit
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurRtnAutoRdOff.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnAutoRdOff
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurRtnSupplierSpecificPurRtn.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnSupplierSpecificPurRtn
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurRtnLocWiseStockCheck.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnLocationWiseStockCheck
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPurRtnDayClose.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.PurRtnDayClose
            'Common.ExecuteQuery(Query, Trans)



            ''Sales
            ''----------------------------------------------------------------------------------------------
            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesCust.SelectedValue & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesDefaultCustomer _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesDiscAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesDiscAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesCardDiscAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesCardDiscAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesOthChgsAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesOthChargesAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesRdOffAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesRdOffAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)


            'If cmbSalesNoSystem.SelectedIndex = 0 Then
            '    NumSys = "C"
            'ElseIf cmbSalesNoSystem.SelectedIndex = 1 Then
            '    NumSys = "F"
            'ElseIf cmbSalesNoSystem.SelectedIndex = 2 Then
            '    NumSys = "M"
            'End If

            'Query = "Update ApplnSettings Set AppSett_Value = '" & NumSys & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesNumberSystem
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesUseSeries.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesUseSeries
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesCtrWiseSeries.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesCounterWiseSeries
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesDocStartNo.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDocStartNo
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesDigit.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDigit
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesDisplayImageOnBill.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDisplayImageOnBill
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesAllowZeroValueEntry.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowZeroValueEntry
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & cmbSalesShowItemSelList.SelectedIndex & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesShowItemWiseSelectionList
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & cmbSalesToBeBilledOn.SelectedIndex & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesToBeBilledOn
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesNoOfItemsOnBill.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesNoOfItemsInBill
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & cmbSalesDefPayMode.SelectedIndex & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDefaultPayMode
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesChkCrLimitOnCrSale.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesCheckCreditLimitCreditSale
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesLocationWiseStockCheck.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesLocationWiseStockCheck
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesExchAgainstBill.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesExchangeAgainstBill
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesAskForBill.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAskForBill
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesLockSalesRt.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesLockSaleRate
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesLockManualDiscount.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesLockManualDiscount
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesLockBillDiscount.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesLockBillDiscount
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesSchemeDisc.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowDiscountScheme
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesSchemeItemWiseDisc.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowItemWiseDiscount
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesSchemeBillWiseDisc.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowBillWiseDiscount
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesAutoRdOff.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAutoRoundOff
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtInvoiceHeadOnPrint.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesInvoiceHeadingInPrint
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesNoOfCopiesToPrint.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesNoOfCopiesToPrint
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesAllowBkDtBillPrn.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowBackDtBillPrint
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesPrnOnSave.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAutoPrintOnSave
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesMsgOnAutoPrint.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesMessageOnAutoPrint
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesAutoSMSBill.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAutoSMSBill
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesMsgOnAutoSMS.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesMessageOnAutoSMS
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRestrictBillChgAfterPrint.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRestrictBillChangeAfterPrint
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesDayClose.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDayClose
            'Common.ExecuteQuery(Query, Trans)


            NumSys = ""
            If cmbSalesAllowBillUpdate.SelectedIndex = 0 Then
                NumSys = "P"    'Only Payment
            ElseIf cmbSalesAllowBillUpdate.SelectedIndex = 1 Then
                NumSys = "A"    'All Bills
            End If

            Query = "Update ApplnSettings Set AppSett_Value = '" & NumSys & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowBillUpdate
            Common.ExecuteQuery(Query, Trans)


            NumSys = ""
            If cmbSalesAllowBillDelete.SelectedIndex = 0 Then
                NumSys = "N"    ''No
            ElseIf cmbSalesAllowBillDelete.SelectedIndex = 1 Then
                NumSys = "L"    ''Last Bill
            ElseIf cmbSalesAllowBillDelete.SelectedIndex = 2 Then
                NumSys = "A"    ''All Bills
            End If

            Query = "Update ApplnSettings Set AppSett_Value = '" & NumSys & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowBillDelete
            Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesAllowBackDtBillCreation.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowBackDateBillCreation
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesMergeDupBarcode.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowMergeBarCode
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesPickLastSaleDiscinExchWOBill.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesPickDiscofLastSalesinExchWOBill
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesApplySchemeinExchWOBill.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesApplySchemeonSoldIteminExchWOBill
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesCheckSoldStatus.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesCheckforSoldStatusinExchBill
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesPickLastSalePersonWOBill.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesPickLastSalesPersoninExchWOBill
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesCarryforwardSalePersonAtItemLevel.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesCarryforwardSalespersonEntryatItemLevel
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = " & Val(txtSalesDeliveryDays.Text) _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesEstimatedDeliveryDays
            'Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesPrinterName.Text & "'" _
               & " Where AppSett_Id = " & ApplnSettingsIdx.SalesPrinterName
            Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesPageSize.Text & "'" _
               & " Where AppSett_Id = " & ApplnSettingsIdx.SalesPageSize
            Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesEmailid.Text & "'" _
               & " Where AppSett_Id = " & ApplnSettingsIdx.SalesEmailId
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(ChkSalesDisplayHold.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDisplayHold
            'Common.ExecuteQuery(Query, Trans)


            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesDisplayDeliveryDetail.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDisplayDeliveryDetail
            'Common.ExecuteQuery(Query, Trans)



            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(ChkSalesDisplayPrintName.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesPrintName
            'Common.ExecuteQuery(Query, Trans)



            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesUseCoupon.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesUseCoupon
            'Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesDisplayLastBillDetails.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDisplayLastBillDetails
            Common.ExecuteQuery(Query, Trans)


            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesDisplayTodaySales.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesDisplayTodaySales
            'Common.ExecuteQuery(Query, Trans)



            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesUseSalesOrderinBill.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesOrderInBill
            Common.ExecuteQuery(Query, Trans)



            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesAutoEmailOnBill.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAutoEmail
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAllowBackDateBillEdit.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowBackDtBillEdit
            Common.ExecuteQuery(Query, Trans) 'aanchal

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAllowBackDateBillDelete.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowBackDtBillDelete
            Common.ExecuteQuery(Query, Trans) 'aanchal

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAllowfocusonBillDiscount.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowFocusOnBillDisc
            Common.ExecuteQuery(Query, Trans) 'aanchal

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtTotalNoOfEdit.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesAllowNoOfTimesforBillEdit
            Common.ExecuteQuery(Query, Trans) 'aanchal

            NumSys = ""
            If cmbFocusOn.SelectedIndex = 0 Then
                NumSys = "B"    'Barcode
            ElseIf cmbFocusOn.SelectedIndex = 1 Then
                NumSys = "C"    'Party
            ElseIf cmbFocusOn.SelectedIndex = 2 Then
                NumSys = "R"    'RefNo
            ElseIf cmbFocusOn.SelectedIndex = 3 Then
                NumSys = "S"    'Sales Person
            ElseIf cmbFocusOn.SelectedIndex = 4 Then
                NumSys = "M"    'Mobile No
            End If

            Query = "Update ApplnSettings Set AppSett_Value = '" & NumSys & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesFocusOn
            Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesUseSalesOrderinBill.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesOrderInBill
            Common.ExecuteQuery(Query, Trans)




            'Sales Return
            ''-------------------------------------------------------------------------------------------
            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesRtnCust.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesRtnDefaultCustomer _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesRtnAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesRtnAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesRtnDiscAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesRtnDiscAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesRtnCardDiscAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesRtnCardDiscAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesRtnOthChgsAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesRtnOthChargesAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesRtnRdOffAccount.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.SalesRtnRdOffAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            'If cmbSalesRtnNoSystem.SelectedIndex = 0 Then
            '    NumSys = "C"
            'ElseIf cmbSalesRtnNoSystem.SelectedIndex = 1 Then
            '    NumSys = "F"
            'ElseIf cmbSalesRtnNoSystem.SelectedIndex = 2 Then
            '    NumSys = "M"
            'End If

            'Query = "Update ApplnSettings Set AppSett_Value = '" & NumSys & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnNumberSystem
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnUseSeries.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnUseSeries
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesRtnDocStartNo.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnDocStartNo
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesRtnDigit.Text & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnDigit
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnAutoRdOff.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnAutoRoundOff
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnAllowRtnWOSales.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnAllowRtnWithoutSales
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnPrnOnSave.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnAutoPrintOnSave
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnMsgOnAutoPrint.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnMessageOnAutoPrint
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnDayClose.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnDayClose
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSalesRtnAcceptLastNDaysInvoiceOnReturn.EditValue & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnAcceptLastNDaysInvoiceForRtn
            Common.ExecuteQuery(Query, Trans)


            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnPickLastSaleDiscWOBill.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnPickDiscofLastSalesWOBill
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnCheckSoldStatus.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnCheckforSoldStatusofItems
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSalesRtnPickLastSalePersonWOBill.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.SalesRtnPickLastSalesPersonWOBill
            'Common.ExecuteQuery(Query, Trans)


            ''General
            ''----------------------------------------------------------------------------------------------
            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseMultiBranch.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenMutiBranch
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseMultiLocation.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenMutiLocation
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseMultiCounter.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenMutiCounter
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseMultiSalesperson.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenMutiSalesPerson
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefSalesperson.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.GenDefSalesPerson _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(cmbSystemSeries.SelectedIndex = 0, "A", "B") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenSystemSeries
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefStation.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.GenDefStation _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbCashAc.Value & "'" _
                & " Where AppBr_Id = " & BranchWiseSettings.GenCashAccount _
                & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnBrSettings Set AppBr_Value = '" & cmbDefTreatmentAccount.Value & "'" _
             & " Where AppBr_Id = " & BranchWiseSettings.GenTreatmentAccount _
             & " And CoBr_Id = '" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)



            Query = "Update ApplnSettings Set AppSett_Value = '" & cmbDecInQty.SelectedIndex & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenDigitsInDecimalQty
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseMultiPriceLevel.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseMultiPriceLevel
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & cmbDefPriceLevel.SelectedIndex & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenPriceLevel
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtMessageOnBill.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenMessageOnBill
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtTimingFrom.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenTiming
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtAddressOnBarcode.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenAddressOnBarcode
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtTerms.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenTermsAndConditions
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkGenBarcodeOnStyleCreation.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseBarcode
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkGenBarcodeOnStyleCreation.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenGenerateBarcodeOnStyleCreation
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseDesign.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseDesign
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseShade.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseShade
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseSize.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseSize
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseSizeWiseRate.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseSizeWiseRate
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseBrand.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseBrand
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseQuality.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseQuality
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseSeason.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseSeason
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseOccassion.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseOccassion
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseMfgDt.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseMfgDt
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseExpiryDate.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseExpiryDt
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseTypeNo.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseType
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseItemCode.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseItemCode
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAutoGenCode.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenAutoGenerateCode
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkProdSeriesTwoDigitPrefix.Checked, "1", "0") & "'" _
               & " Where AppSett_Id = " & ApplnSettingsIdx.GenProductSeries2DigitsAsPrefix
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkMaintainStk.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenMaintainStock
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAllowNegativeStk.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenAllowNegativeStock
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkRackWiseStock.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenRackWise
            'Common.ExecuteQuery(Query, Trans)

            '---------------------------------18-01-2016--------------------------------------



            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chksup_design.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenSupplierDesignDisplay '_shishil
            Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkUseBarcode.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenUseBarcode
            Common.ExecuteQuery(Query, Trans)


            If cmbBarcode.SelectedIndex = 0 Then
                ComboValue = "P"
            ElseIf cmbBarcode.SelectedIndex = 1 Then
                ComboValue = "D"
            ElseIf cmbBarcode.SelectedIndex = 2 Then
                ComboValue = "U"
            End If

            Query = "Update ApplnSettings Set AppSett_Value = '" & ComboValue & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenMaintainBarcode
            Common.ExecuteQuery(Query, Trans)
            ComboValue = ""

            If cmbBarcodeSeries.SelectedIndex = 0 Then
                ComboValue = "P"
            ElseIf cmbBarcodeSeries.SelectedIndex = 1 Then
                ComboValue = "S"
            End If

            Query = "Update ApplnSettings Set AppSett_Value = '" & ComboValue & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenBarcodeSeriesFrom
            Common.ExecuteQuery(Query, Trans)
            ComboValue = ""


            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkStockAlerts.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenStockLevelAlerts
            'Common.ExecuteQuery(Query, Trans)
            'ComboValue = ""

            'If chkStockAlerts.Checked Then
            '    If rdStockMin.Checked Then
            '        ComboValue = "0"
            '    ElseIf rdStockMax.Checked Then
            '        ComboValue = "1"
            '    ElseIf rdStockReorder.Checked Then
            '        ComboValue = "2"
            '    End If
            'End If

            Query = "Update ApplnSettings Set AppSett_Value = '" & ComboValue & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenStockAlerts
            Common.ExecuteQuery(Query, Trans)
            ComboValue = ""


            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkSMS.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenSMSFeature
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSMSUser.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenSMSUser
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSMSPassword.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenSMSPassword
            Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkEmail.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenEmailFeature
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & ReplaceApostrophe(txtEmailSenderName.Text) & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenEmailSenderName
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtEmailUser.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenEmailUser
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtEmailPassword.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenEmailPassword
            Common.ExecuteQuery(Query, Trans)



            Query = "Update ApplnSettings Set AppSett_Value = '" & txtBackupPath.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenBackupPath
            Common.ExecuteQuery(Query, Trans)


            Query = "Update ApplnSettings Set AppSett_Value = '" & txtCopyBackUp.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenCopyBackupPath
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAutoBackup.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenAutoBackup
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(cmbAutoBackupOptions.SelectedIndex = 0, "D", "H") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenBackupPeriod
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtDelBackupDays.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenDeleteBackupAfterDays
            Common.ExecuteQuery(Query, Trans)


            'If cmbStockTransferOn.SelectedIndex = 0 Then
            '    ComboValue = "M"    'MRP
            'ElseIf cmbStockTransferOn.SelectedIndex = 1 Then
            '    ComboValue = "P"    'Purchase Rt
            'ElseIf cmbStockTransferOn.SelectedIndex = 2 Then
            '    ComboValue = "S"    'Sale Rt
            'End If

            'SUNIL 13/10/2020
            'Query = "Update ApplnSettings Set AppSett_Value = '" & ComboValue & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenStockTransferOn
            'Common.ExecuteQuery(Query, Trans)


            ComboValue = ""


            If cmbCalculateStockOn.SelectedIndex = 0 Then
                ComboValue = "C"    'Actual Rt
            ElseIf cmbCalculateStockOn.SelectedIndex = 1 Then
                ComboValue = "V"    'Avg Rt
            End If

            Query = "Update ApplnSettings Set AppSett_Value = '" & ComboValue & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenCalculateStockOn
            Common.ExecuteQuery(Query, Trans)
            ComboValue = ""

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkDisplayImage.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenDisplayImage
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtProdImgPath.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenImagePath
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtReportpath.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenReportPath
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkMaintainBalBillByBill.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenMaintainBalanceBillByBill
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(ChkAutoPrintonSaveReceiptVoucher.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.AutoPrintOnSaveReceiptVoucher
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkPMessageOnPrintBarcode.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.MessageOnPrintBarcodeInPurchase
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkMaintainCostCtr.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenMaintainCostCenter
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkAllowMultiPurRate.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenAllowMultiplePurRate
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkProductMeasure.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenProductMeasurement
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkCRM.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenCRM
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtBarcodeInfo1.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenBarcodeInfo1
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtBarcodeInfo2.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenBarcodeInfo2
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkBarcodeInfo2.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenBarcodeInfo2Flag
            Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkDayClose.Checked, "1", "0") & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenDayClose
            'Common.ExecuteQuery(Query, Trans)

            'Query = "Update ApplnSettings " _
            '    & " Set AppSett_Value = '" & IIf(cmbApplnType.SelectedIndex = 0, "B", IIf(cmbApplnType.SelectedIndex = 1, "R", "D")) & "'" _
            '    & " Where AppSett_Id = " & ApplnSettingsIdx.GenTypeOfSoftware
            'Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & IIf(chkMaintAcc.Checked, "1", "0") & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenMaintainAccounts
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSMSCompany.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenSMSCompany
            Common.ExecuteQuery(Query, Trans)


            'Sys Config
            Query = "Update ApplnSettings Set AppSett_Value = '" & ReplaceApostrophe(txtInvoiceHeadingWithoutVATNo.Text) & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.InvoiceHeadingWithoutVatNo
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & ReplaceApostrophe(txtInvoiceHeadingForVATNo.Text) & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.InvoiceHeadingForVatNo
            Common.ExecuteQuery(Query, Trans)



            '-------------poonam ---------------------

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSMSUser1.Text & "'" _
             & " Where AppSett_Id = " & ApplnSettingsIdx.GenSMSUser1
            Common.ExecuteQuery(Query, Trans)

            Query = "Update ApplnSettings Set AppSett_Value = '" & txtSMSPassword1.Text & "'" _
                & " Where AppSett_Id = " & ApplnSettingsIdx.GenSMSPassword1
            Common.ExecuteQuery(Query, Trans)

            Trans.Commit()


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
            Trans.Rollback()
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Trans.Rollback()
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If Mid(txtPurDocStartNo.Text, 1, 1) = "0" Then
        '    If txtPurDocStartNo.Text.Trim.Length <> txtPurDigit.EditValue Then
        '        MsgBox("Invalid purchase doc start no specified !", MsgBoxStyle.Exclamation)
        '        txtPurDocStartNo.Focus()
        '        Exit Sub
        '    End If
        'End If

        'If Mid(txtPurRtnDocStartNo.Text, 1, 1) = "0" Then
        '    If txtPurRtnDocStartNo.Text.Trim.Length <> txtPurRtnDigit.EditValue Then
        '        MsgBox("Invalid purchase return doc start no specified !", MsgBoxStyle.Exclamation)
        '        txtPurRtnDocStartNo.Focus()
        '        Exit Sub
        '    End If
        'End If

        'If Mid(txtSalesDocStartNo.Text, 1, 1) = "0" Then
        '    If txtSalesDocStartNo.Text.Trim.Length <> txtSalesDigit.EditValue Then
        '        MsgBox("Invalid sales doc start no specified !", MsgBoxStyle.Exclamation)
        '        txtSalesDocStartNo.Focus()
        '        Exit Sub
        '    End If
        'End If

        'If Mid(txtSalesRtnDocStartNo.Text, 1, 1) = "0" Then
        '    If txtSalesRtnDocStartNo.Text.Trim.Length <> txtSalesRtnDigit.EditValue Then
        '        MsgBox("Invalid sales return doc start no specified !", MsgBoxStyle.Exclamation)
        '        txtSalesRtnDocStartNo.Focus()
        '        Exit Sub
        '    End If
        'End If

        SaveSettings()
        MaintainAccounts()

        ApplnSettingsData = Nothing
        Query = "Select AppSett_Id, AppSett_Value From ApplnSettings  With(NoLock) "
        ApplnSettingsData = Common.GetDataTable(Query)

        BranchSettingsData = Nothing
        Query = "Select AppBr_Id, AppBr_Value " _
            & " From ApplnBrSettings  With(NoLock) " _
            & " Where CoBr_Id = '" & SelBranchFixId & "'"
        BranchSettingsData = Common.GetDataTable(Query)


        RetrieveData()

        If Relogin Then
            MsgBox("Please Re-Login to affect changes", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))

            Me.Close()
            Application.Exit()
        Else
            MsgBox("Settings saved successfully", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
        End If
    End Sub
    Private Sub btnCopyBackUpPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopyBackUpPath.Click
        Dim BkUpFldr As New FolderBrowserDialog

        With BkUpFldr
            .Description = "Backup Path"
            .RootFolder = Environment.SpecialFolder.Desktop
            .SelectedPath = Application.StartupPath
            .ShowNewFolderButton = True
            .ShowDialog()

            If .SelectedPath <> "" Then
                txtCopyBackUp.Text = .SelectedPath
            End If
        End With
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim BkUpFldr As New FolderBrowserDialog

        With BkUpFldr
            .Description = "Backup Path"
            .RootFolder = Environment.SpecialFolder.Desktop
            .SelectedPath = Application.StartupPath
            .ShowNewFolderButton = True
            .ShowDialog()

            If .SelectedPath <> "" Then
                txtBackupPath.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub chkAutoBackup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutoBackup.CheckedChanged
        cmbAutoBackupOptions.Enabled = chkAutoBackup.Checked
        If chkAutoBackup.Checked Then
            txtDelBackupDays.Text = "7"
        Else
            txtDelBackupDays.Text = ""
        End If
    End Sub

    Private Sub btnProdImagePath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProdImagePath.Click
        Dim PrdImgFldr As New FolderBrowserDialog

        With PrdImgFldr
            .Description = "Article Image Path"
            .RootFolder = Environment.SpecialFolder.Desktop
            .SelectedPath = Application.StartupPath
            .ShowNewFolderButton = True
            .ShowDialog()

            If .SelectedPath <> "" Then
                txtProdImgPath.Text = .SelectedPath
            End If
        End With
    End Sub

    ''Private Sub chkUseMultiCounter_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSalesUseSeries.CheckedChanged
    ''    chkSalesCtrWiseSeries.Enabled = (chkUseMultiCounter.Checked And chkSalesUseSeries.Checked)
    ''    If Not chkSalesCtrWiseSeries.Enabled Then
    ''        chkSalesCtrWiseSeries.Checked = False
    ''    End If
    ''End Sub

    Private Sub btnReportPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReportPath.Click
        Dim PrdImgFldr As New FolderBrowserDialog

        With PrdImgFldr
            .Description = "Report Path"
            .RootFolder = Environment.SpecialFolder.Desktop
            .SelectedPath = Application.StartupPath
            .ShowNewFolderButton = True
            .ShowDialog()

            If .SelectedPath <> "" Then
                txtReportpath.Text = .SelectedPath
            End If
        End With
    End Sub

    'Private Sub chkUseMultiPriceLevel_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    cmbDefPriceLevel.Enabled = chkUseMultiPriceLevel.Checked
    '    cmbDefPriceLevel.SelectedIndex = -1

    '    If Not chkUseMultiPriceLevel.Checked Then
    '        cmbDefPriceLevel.SelectedIndex = 0
    '    End If
    'End Sub
    Private Sub chkCopyBackUp_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCopyBackUp.CheckedChanged
        txtCopyBackUp.Enabled = True
        btnCopyBackUpPath.Enabled = True

        If Not chkCopyBackUp.Checked Then
            txtCopyBackUp.Text = ""
            txtCopyBackUp.Enabled = False
            btnCopyBackUpPath.Enabled = False
        End If
    End Sub
    Private Sub chkDisplayImage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDisplayImage.CheckedChanged
        txtProdImgPath.Enabled = True
        btnProdImagePath.Enabled = True

        If Not chkDisplayImage.Checked Then
            txtProdImgPath.Text = ""
            txtProdImgPath.Enabled = False
            btnProdImagePath.Enabled = False
        End If
    End Sub

    Private Sub chkUseMultiSalesperson_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseMultiSalesperson.CheckedChanged
        cmbDefSalesperson.Enabled = chkUseMultiSalesperson.Checked
        cmbDefSalesperson.SelectedIndex = -1

        If chkUseMultiSalesperson.Checked Then
            cmbDefSalesperson.SelectedIndex = 0
        End If
    End Sub

    'Private Sub chkUseItemCode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    chkAutoGenCode.Enabled = chkUseItemCode.Checked
    '    chkProdSeriesTwoDigitPrefix.Enabled = chkUseItemCode.Checked

    '    If Not chkUseItemCode.Checked Then
    '        chkAutoGenCode.Checked = False
    '        chkProdSeriesTwoDigitPrefix.Checked = False
    '    End If
    'End Sub

    'Private Sub txtPurDigit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If txtPurDigit.EditValue = 0 Then
    '        MsgBox("Digit should be greater than zero !", MsgBoxStyle.Exclamation)
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub txtPurRtnDigit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If txtPurRtnDigit.EditValue = 0 Then
    '        MsgBox("Digit should be greater than zero !", MsgBoxStyle.Exclamation)
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub txtSalesDigit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If txtSalesDigit.EditValue = 0 Then
    '        MsgBox("Digit should be greater than zero !", MsgBoxStyle.Exclamation)
    '        e.Cancel = True
    '    End If
    'End Sub

    'Private Sub txtSalesRtnDigit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If txtSalesRtnDigit.EditValue = 0 Then
    '        MsgBox("Digit should be greater than zero !", MsgBoxStyle.Exclamation)
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub chkUseDesign_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseDesign.CheckedChanged
        If chkUseDesign.Checked Then
            ''chkUseShade.Enabled = True
            ''chkUseSize.Enabled = True


            ' chkUseSizeWiseRate.Enabled = True
            'chkUseBrand.Enabled = True
            'chkUseQuality.Enabled = True
            'chkUseSeason.Enabled = True
            'chkUseOccassion.Enabled = True
            ' chkUseMfgDt.Enabled = True
            'chkUseExpiryDate.Enabled = True
            chkUseTypeNo.Enabled = True
            'chkGenBarcodeOnStyleCreation.Enabled = True
        Else
            ''chkUseShade.Checked = False
            ''chkUseSize.Checked = False

            'chkUseSizeWiseRate.Enabled = False
            ' chkUseBrand.Checked = False
            ' chkUseQuality.Checked = False
            'chkUseSeason.Checked = False
            'chkUseOccassion.Checked = False
            'chkUseMfgDt.Checked = False
            ' chkUseExpiryDate.Checked = False
            chkUseTypeNo.Checked = False
            'chkGenBarcodeOnStyleCreation.Checked = False

            ''chkUseShade.Enabled = False
            ''chkUseSize.Enabled = False
            'chkUseSizeWiseRate.Enabled = False
            'chkUseBrand.Enabled = False
            'chkUseQuality.Enabled = False
            ' chkUseSeason.Enabled = False
            'chkUseOccassion.Enabled = False
            'chkUseMfgDt.Enabled = False
            ' chkUseExpiryDate.Enabled = False
            chkUseTypeNo.Enabled = False
            'chkGenBarcodeOnStyleCreation.Enabled = False
        End If
    End Sub

    Private Sub chkEmail_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEmail.CheckedChanged
        'pnlEmailSettings.Enabled = chkEmail.Checked

        'If Not chkEmail.Checked Then
        '    txtEmailUser.Clear()
        '    txtEmailPassword.Clear()
        'End If
    End Sub

    'Private Sub chkStockAlerts_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkStockAlerts.CheckedChanged
    '    pnlStockAlerts.Enabled = chkStockAlerts.Checked

    '    If Not chkStockAlerts.Checked Then
    '        rdStockMax.Checked = False
    '        rdStockMin.Checked = False
    '        rdStockReorder.Checked = False
    '    Else
    '        rdStockMin.Checked = True
    '    End If
    'End Sub

    'Private Sub chkDayClose_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDayClose.CheckedChanged
    '    If Not chkDayClose.Checked Then
    '        chkPurDayClose.Checked = False
    '        chkPurRtnDayClose.Checked = False
    '        chkSalesDayClose.Checked = False
    '        chkSalesRtnDayClose.Checked = False

    '        chkPurDayClose.Enabled = False
    '        chkPurRtnDayClose.Enabled = False
    '        chkSalesDayClose.Enabled = False
    '        chkSalesRtnDayClose.Enabled = False
    '    Else
    '        chkPurDayClose.Checked = True
    '        chkPurRtnDayClose.Checked = True
    '        chkSalesDayClose.Checked = True
    '        chkSalesRtnDayClose.Checked = True

    '        chkPurDayClose.Enabled = True
    '        chkPurRtnDayClose.Enabled = True
    '        chkSalesDayClose.Enabled = True
    '        chkSalesRtnDayClose.Enabled = True
    '    End If
    'End Sub

    Private Sub rdPurchase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPurchase.CheckedChanged
        grpPurchase.Visible = False
        grpPurchaseRtn.Visible = False
        grpSales.Visible = False
        grpSalesRtn.Visible = False
        grpWholeSaleBill.Visible = False
        If rdPurchase.Checked Then
            grpPurchase.Visible = True
        End If
    End Sub

    Private Sub rdPurchaseRtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPurchaseRtn.CheckedChanged
        grpPurchase.Visible = False
        grpPurchaseRtn.Visible = False
        grpSales.Visible = False
        grpSalesRtn.Visible = False
        grpWholeSaleBill.Visible = False
        If rdPurchaseRtn.Checked Then
            grpPurchaseRtn.Visible = True
        End If
    End Sub

    Private Sub rdSales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSales.CheckedChanged
        grpPurchase.Visible = False
        grpPurchaseRtn.Visible = False
        grpSales.Visible = False
        grpSalesRtn.Visible = False
        grpWholeSaleBill.Visible = False
        If rdSales.Checked Then
            grpSales.Visible = True
        End If
    End Sub

    Private Sub rdSalesRtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSalesRtn.CheckedChanged
        grpPurchase.Visible = False
        grpPurchaseRtn.Visible = False
        grpSales.Visible = False
        grpSalesRtn.Visible = False
        grpWholeSaleBill.Visible = False
        If rdSalesRtn.Checked Then
            grpSalesRtn.Visible = True
        End If
    End Sub

    Private Sub SetAsPerEdition()
        If TypeOfEdition = Edition.Basic Then
            'chkUseMultiBranch.Enabled = False
            ' chkUseMultiLocation.Enabled = False
            'chkUseMultiCounter.Enabled = False
            'chkSalesCtrWiseSeries.Enabled = False
            'chkUseMultiSalesperson.Enabled = False
            'chkDayClose.Enabled = False
            'chkRackWiseStock.Enabled = False
            'cmbDefSalesperson.Enabled = False
            ' chkCRM.Enabled = False
            'chkUseMultiPriceLevel.Enabled = False
            ' chkSalesAutoSMSBill.Enabled = False
            ' chkSalesMsgOnAutoSMS.Enabled = False
            ' chkSMS.Enabled = False
            'chkEmail.Enabled = False
            ' pnlSMSSettings.Enabled = False

        ElseIf TypeOfEdition = Edition.Professional Then
            'chkUseMultiBranch.Enabled = False
            'chkUseMultiLocation.Enabled = False
            'chkUseMultiCounter.Enabled = False
            ' chkSalesCtrWiseSeries.Enabled = False
            'chkRackWiseStock.Enabled = False

        ElseIf TypeOfEdition = Edition.Enterprise Then

        End If


        'If Not chkDayClose.Enabled Then
        '    chkPurDayClose.Enabled = False
        '    chkPurRtnDayClose.Enabled = False
        '    chkSalesDayClose.Enabled = False
        '    chkSalesRtnDayClose.Enabled = False
        'End If
    End Sub

    'Private Sub chkUseMultiLocation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Not chkUseMultiLocation.Checked Then
    '        chkRackWiseStock.Enabled = False
    '        chkRackWiseStock.Checked = False

    '        chkSalesLocationWiseStockCheck.Checked = False
    '        chkPurRtnLocWiseStockCheck.Checked = False
    '    Else
    '        chkRackWiseStock.Enabled = True
    '    End If

    '    chkSalesLocationWiseStockCheck.Enabled = chkUseMultiLocation.Checked
    '    chkPurRtnLocWiseStockCheck.Enabled = chkUseMultiLocation.Checked
    'End Sub

    Private Sub chkMaintAcc_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMaintAcc.CheckedChanged
        If Not chkMaintAcc.Checked Then
            chkMaintainBalBillByBill.Checked = False
            chkMaintainCostCtr.Checked = False
            cmbCashAc.SelectedIndex = 0
            cmbDefPurAccount.SelectedIndex = 0
            cmbDefPurDiscAccount.SelectedIndex = 0
            cmbDefPurRdOffAccount.SelectedIndex = 0
            cmbDefPurRtnAccount.SelectedIndex = 0
            cmbDefPurRtnDiscAccount.SelectedIndex = 0
            cmbDefPurRtnRdOffAccount.SelectedIndex = 0
            cmbDefSalesAccount.SelectedIndex = 0
            cmbDefSalesDiscAccount.SelectedIndex = 0
            cmbDefSalesOthChgsAccount.SelectedIndex = 0
            cmbDefSalesRdOffAccount.SelectedIndex = 0
            cmbDefSalesRtnAccount.SelectedIndex = 0
            cmbDefSalesRtnDiscAccount.SelectedIndex = 0
            cmbDefSalesRtnOthChgsAccount.SelectedIndex = 0
            cmbDefSalesRtnRdOffAccount.SelectedIndex = 0
            cmbDefTreatmentAccount.SelectedIndex = 0
        End If

        grpAccounts.Enabled = chkMaintAcc.Checked
        If Not Loading And chkMaintAcc.Checked Then
            Relogin = True
        Else
            'If Relogin Then Relogin = False
        End If
    End Sub

    Private Sub MaintainAccounts()
        If Not chkMaintAcc.Checked Then
            Dim BandId As Byte = GetBandId("BandAccounts", MDI)
            If BandId > 0 Then
                MDI.MDINaviBar.Bands.RemoveAt(BandId)
            End If

            BandId = GetBandId("BandAccReports", MDI)
            If BandId > 0 Then
                MDI.MDINaviBar.Bands.RemoveAt(BandId)

                MDI.MDINaviBar.Update()
                MDI.MDINaviBar.VisibleLargeButtons = 5
            End If

            Dim tvw As TreeView = MDI.tvwMasters
            Dim ndNode() As TreeNode

            If Not chkMaintAcc.Checked Then
                ndNode = tvw.Nodes.Find("ndTDSRef", True)
                For Each obj As Object In ndNode
                    obj.Remove()
                Next obj

                ndNode = tvw.Nodes.Find("ndPaymentType", True)
                For Each obj As Object In ndNode
                    obj.Remove()
                Next obj

                ndNode = tvw.Nodes.Find("ndDeducteeType", True)
                For Each obj As Object In ndNode
                    obj.Remove()
                Next obj

                ndNode = tvw.Nodes.Find("ndTDS", True)
                For Each obj As Object In ndNode
                    obj.Remove()
                Next obj
            End If
        Else
            'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
            'Dim BandAccounts As New Guifreaks.NavigationBar.NaviBand
            'BandAccounts.Name = "BandAccounts"
            'BandAccounts.Text = "&Accounts"
            'BandAccounts.LargeImage = CType(resources.GetObject("BandAccounts.LargeImage"), System.Drawing.Image)
            'MDI.MDINaviBar.Bands.Add(BandAccounts)

            'Dim BandAccReports As New Guifreaks.NavigationBar.NaviBand
            'BandAccReports.Name = "BandAccReports"
            'BandAccReports.Text = "A&ccounts Reports"
            'BandAccReports.LargeImage = CType(resources.GetObject("BandAccReports.LargeImage"), System.Drawing.Image)
            'MDI.MDINaviBar.Bands.Add(BandAccReports)

            'MDI.MDINaviBar.Update()
            'MDI.MDINaviBar.VisibleLargeButtons = 7
        End If

        Query = "Update Modules Set Status = '" & IIf(chkMaintAcc.Checked, "1", "0") & "'" _
            & " Where Category In ('E', 'G')"
        Common.ExecuteQuery(Query)

        Query = "Update Series Set Status = '" & IIf(chkMaintAcc.Checked, "1", "0") & "'" _
            & " Where Rec_Id In (9,10,11,12,13,14)"
        Common.ExecuteQuery(Query)
    End Sub




    Private Sub chkSalesAutoEmailOnBill_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSalesAutoEmailOnBill.CheckedChanged

        txtSalesEmailid.Enabled = chkSalesAutoEmailOnBill.Checked
        If chkSalesAutoEmailOnBill.Checked Then
            txtSalesEmailid.Enabled = True
        Else
            txtSalesEmailid.Text = ""
            txtSalesEmailid.Enabled = False

        End If


    End Sub


    Private Sub rdSysConfig_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdWholeSaleBill.CheckedChanged
        grpPurchase.Visible = False
        grpPurchaseRtn.Visible = False
        grpSales.Visible = False
        grpSalesRtn.Visible = False
        grpSalesRtn.Visible = False
        If rdWholeSaleBill.Checked = True Then
            grpWholeSaleBill.Visible = True
        End If
    End Sub

    Private Sub lnkseqproduct_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkseqproduct.LinkClicked
        pnlOptions.Visible = True : pnlOptions.BringToFront()
        DisplayExistRecord()
    End Sub

    Private Sub btnGrp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrp1.Click
        If lstMain.SelectedIndex = -1 Then Exit Sub

        If lstOption1.Items.Count >= 0 Then
            lstOption1.Items.Add(lstMain.SelectedItem)

            EnableFilters(lstOption1.Items(0), True)

            If lstOption1.Items.Count > 0 Then


            End If
        End If
    End Sub

    Private Sub SIMPLEBUTTON5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If ListBox2.SelectedIndex = -1 Then Exit Sub

        If ListBox1.Items.Count >= 0 Then
            ListBox1.Items.Add(ListBox2.SelectedItem)

            EnableFilters(ListBox1.Items(0), True)

            If ListBox1.Items.Count > 0 Then


            End If
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lstOption1.SelectedIndex = -1 Then Exit Sub

        Dim Idx As Byte
        If lstOption1.SelectedIndex - 1 >= 0 Then
            Idx = lstOption1.SelectedIndex
            Dim obj As String = lstOption1.Items(lstOption1.SelectedIndex - 1)

            lstOption1.Items.RemoveAt(Idx - 1)
            lstOption1.Items.Insert(Idx, obj)
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lstOption1.SelectedIndex = -1 Then Exit Sub

        Dim Idx As Byte
        If lstOption1.SelectedIndex + 1 <= lstOption1.Items.Count - 1 Then
            Idx = lstOption1.SelectedIndex
            Dim obj As String = lstOption1.Items(lstOption1.SelectedIndex + 1)

            lstOption1.Items.RemoveAt(Idx + 1)
            lstOption1.Items.Insert(Idx, obj)
        End If
    End Sub

    Private Sub BtnMinQtyUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinQtyUp.Click
        If ListBox1.SelectedIndex = -1 Then Exit Sub

        Dim Idx As Byte
        If ListBox1.SelectedIndex - 1 >= 0 Then
            Idx = ListBox1.SelectedIndex
            Dim obj As String = ListBox1.Items(ListBox1.SelectedIndex - 1)

            ListBox1.Items.RemoveAt(Idx - 1)
            ListBox1.Items.Insert(Idx, obj)
        End If
    End Sub

    Private Sub BtnMinQtyDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinQtyDown.Click
        If ListBox1.SelectedIndex = -1 Then Exit Sub

        Dim Idx As Byte
        If ListBox1.SelectedIndex + 1 <= ListBox1.Items.Count - 1 Then
            Idx = ListBox1.SelectedIndex
            Dim obj As String = ListBox1.Items(ListBox1.SelectedIndex + 1)

            ListBox1.Items.RemoveAt(Idx + 1)
            ListBox1.Items.Insert(Idx, obj)
        End If
    End Sub

    Private Sub btnCloseOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseOption.Click
        pnlOptions.Visible = False
        pnlOptions.SendToBack()
    End Sub
    Private Sub btnCloseOption1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        PnlListOptions.Visible = False
        PnlListOptions.SendToBack()
    End Sub

    Private Sub btnDelGrp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelGrp1.Click
        Dim Text As String = ""

        If lstOption1.Items.Count = 1 Then
            Text = lstOption1.Items(0)
            lstOption1.Items.Clear()
        Else
            If lstOption1.SelectedIndex = -1 Then Exit Sub

            Text = lstOption1.Items(0)
            lstOption1.Items.RemoveAt(lstOption1.SelectedIndex)
        End If


        EnableFilters(Text, False)



        Add_bill_seq()
    End Sub

    Private Sub SIMPLEbUTTON7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Dim Text As String = ""

        If ListBox1.Items.Count = 1 Then
            Text = ListBox1.Items(0)
            ListBox1.Items.Clear()
        Else
            If ListBox1.SelectedIndex = -1 Then Exit Sub

            Text = ListBox1.Items(0)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If


        EnableFilters(Text, False)



        Add_Min_seq()
    End Sub

    Private Sub EnableFilters(ByVal SelectedText As String, ByVal EnableDisable As Boolean)

    End Sub

    Private Sub btnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If lstMain.SelectedIndex = -1 Then Exit Sub

        'If lstDetails.Items.Count < 3 Then
        '    Dim Idx As Byte
        '    Dim Found As Boolean

        '    If lstDetails.Items.Count >= 0 Then
        '        For Idx = 0 To lstDetails.Items.Count - 1
        '            If UCase(lstDetails.Items(Idx)) = lstMain.Text.ToUpper Then
        '                Found = True
        '                Exit For
        '            End If
        '        Next Idx
        '    End If

        '    If Not Found Then
        '        lstDetails.Items.Add(lstMain.SelectedItem)
        '    End If

        '    EnableFilters(lstDetails.Items(lstDetails.Items.Count - 1), True)


        '    If lstDetails.Items.Count >= 0 Then

        '    End If
        'End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If lstOption1.Items.Count > 0 Then
            If txtKeyword.Text = "" Then
                MsgBox("Keyword can not be blank!", MsgBoxStyle.OkOnly)
                Exit Sub
            End If

        End If
        Add_bill_seq()
        MessageBox.Show("successfully saved")
        pnlOptions.Visible = False
        pnlOptions.SendToBack()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If lstOption1.Items.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to DELETE All record ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        ' Dim Trans As SqlTransaction = Nothing

        If MsgBox("confirm delete ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        Dim Trans As SqlTransaction = Nothing


        Try
            Trans = CreateSQLTransaction()
            'Query = "Delete From ItemShadeBrand Where Item_Key = " & lvwSelectWishList.Items(0).SubItems(lvwAllItem.Item_Key).Text & ""
            Query = "Delete From ProdSeqBill "
            Common.ExecuteQuery(Query, Trans)
            Trans.Commit()

        Catch ex As Exception

        End Try
        ' Label32.Text = lstOption1.Items.Count


        MessageBox.Show("successfully deleted All Recode")
        lstOption1.Items.Clear()
        pnlOptions.Visible = False
        pnlOptions.SendToBack()
    End Sub



    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If ListBox1.Items.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to DELETE All record ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        ' Dim Trans As SqlTransaction = Nothing

        If MsgBox("confirm delete ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        Dim Trans As SqlTransaction = Nothing


        Try
            Trans = CreateSQLTransaction()
            'Query = "Delete From ItemShadeBrand Where Item_Key = " & lvwSelectWishList.Items(0).SubItems(lvwAllItem.Item_Key).Text & ""
            Query = "Delete From MinQtySeq "
            Common.ExecuteQuery(Query, Trans)
            Trans.Commit()

        Catch ex As Exception

        End Try
        ' Label32.Text = lstOption1.Items.Count


        MessageBox.Show("successfully deleted All Recode")
        ListBox1.Items.Clear()
        PnlListOptions.Visible = False
        PnlListOptions.SendToBack()
    End Sub
    Sub DisplayExistRecord()

        Query = "select *  From ProdSeqBill  With(NoLock) "
        Dim DtTable As DataTable = Common.GetDataTable(Query)

        lstOption1.Items.Clear()

        'da.Fill(DtTable)
        'For i As Integer = 0 To DtTable.Rows.Count - 1
        '    lstOption1.add(DtTable.Rows(i)("SeqId").ToString())
        'Next


        For Each tempRow In DtTable.Rows
            If tempRow("SeqId") = "A" Then
                lstOption1.Items.Add("SubGroup")
            ElseIf tempRow("SeqId") = "B" Then
                lstOption1.Items.Add("Brand")
            ElseIf tempRow("SeqId") = "C" Then
                lstOption1.Items.Add("Product")
            ElseIf tempRow("SeqId") = "D" Then
                lstOption1.Items.Add("Type")
            ElseIf tempRow("SeqId") = "E" Then
                lstOption1.Items.Add("Shade")
            ElseIf tempRow("SeqId") = "F" Then
                lstOption1.Items.Add("Size")
            ElseIf tempRow("SeqId") = "G" Then
                lstOption1.Items.Add("Sales Rate")
            ElseIf tempRow("SeqId") = "H" Then
                lstOption1.Items.Add("Quantity")
            ElseIf tempRow("SeqId") = "I" Then
                lstOption1.Items.Add("Barcode")
            ElseIf tempRow("SeqId") = "J" Then
                lstOption1.Items.Add("Design")
            End If
            'raju27022018
            txtKeyword.Text = tempRow("Keyword")
            'end
        Next

    End Sub

    Sub Add_bill_seq()
        Dim Trans1 As SqlTransaction = Nothing
        Try
            Trans1 = CreateSQLTransaction()

            Query = "Delete From ProdSeqBill "
            Common.ExecuteQuery(Query, Trans1)

            Trans1.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try

        Dim Trans As SqlTransaction = Nothing
        Try
            Trans = CreateSQLTransaction()

            Dim sr_no As Integer = 0
            For i As Integer = 0 To lstOption1.Items.Count - 1
                ' Dim sr_no As Integer = 0
                Dim new_sr_no As Integer = 0
                Dim SeqId As String



                'If lstOption1.Items(i).subitem("SubGroup") = "A" Then
                '    SeqId = "A"
                'Else

                'End If

                If lstOption1.Items(i) = "SubGroup" Then
                    SeqId = "A"
                ElseIf lstOption1.Items(i) = "Brand" Then
                    SeqId = "B"
                ElseIf lstOption1.Items(i) = "Product" Then
                    SeqId = "C"
                ElseIf lstOption1.Items(i) = "Type" Then
                    SeqId = "D"
                ElseIf lstOption1.Items(i) = "Shade" Then
                    SeqId = "E"
                ElseIf lstOption1.Items(i) = "Size" Then
                    SeqId = "F"
                ElseIf lstOption1.Items(i) = "Sales Rate" Then
                    SeqId = "G"
                ElseIf lstOption1.Items(i) = "Quantity" Then
                    SeqId = "H"
                ElseIf lstOption1.Items(i) = "Barcode" Then
                    SeqId = "I"
                ElseIf lstOption1.Items(i) = "Design" Then
                    SeqId = "J"
                End If
                sr_no = sr_no + 1

                Query = " insert into ProdSeqBill (SNo,SeqId,Keyword) values( " & sr_no & ",'" & SeqId & "','" & txtKeyword.Text & "')"
                Common.ExecuteQuery(Query)
            Next
            Trans.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub lnkMinQty_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMinQty.LinkClicked
        PnlListOptions.Visible = True
        PnlListOptions.BringToFront()
        DisplayExistRecord1()
    End Sub

    Private Sub btnSaveMinSeq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Add_Min_seq()
        MessageBox.Show("successfully saved")
        PnlListOptions.Visible = False
        PnlListOptions.SendToBack()
    End Sub
    Sub DisplayExistRecord1()

        Query = "select *  From MinQtySeq  With(NoLock) "
        Dim DtTable As DataTable = Common.GetDataTable(Query)

        ListBox1.Items.Clear()

        'da.Fill(DtTable)
        'For i As Integer = 0 To DtTable.Rows.Count - 1
        '    lstOption1.add(DtTable.Rows(i)("SeqId").ToString())
        'Next


        For Each tempRow In DtTable.Rows
            If tempRow("SeqId") = "A" Then
                ListBox1.Items.Add("Product")
                'ElseIf tempRow("SeqId") = "B" Then
                '    lstMinSeq1.Items.Add("Design")
            ElseIf tempRow("SeqId") = "B" Then
                ListBox1.Items.Add("Type")
                'ElseIf tempRow("SeqId") = "D" Then
                '    lstMinSeq1.Items.Add("Shade")
            ElseIf tempRow("SeqId") = "C" Then
                ListBox1.Items.Add("Brand")
            ElseIf tempRow("SeqId") = "D" Then
                ListBox1.Items.Add("Quality")
            ElseIf tempRow("SeqId") = "E" Then
                ListBox1.Items.Add("Season")
            ElseIf tempRow("SeqId") = "F" Then
                ListBox1.Items.Add("Occassion")
            ElseIf tempRow("SeqId") = "G" Then
                ListBox1.Items.Add("Size")
                'ElseIf tempRow("SeqId") = "J" Then
                '    lstMinSeq1.Items.Add("Supp Degn")
            End If
            'raju27022018
            '  txtMinKeyword.Text = tempRow("Keyword")
            'end
        Next

    End Sub
    Sub Add_Min_seq()
        Dim Trans1 As SqlTransaction = Nothing
        Try
            Trans1 = CreateSQLTransaction()

            Query = "Delete From MinQtySeq "
            Common.ExecuteQuery(Query, Trans1)

            Trans1.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try

        Dim Trans As SqlTransaction = Nothing
        Try
            Trans = CreateSQLTransaction()

            Dim sr_no As Integer = 0
            For i As Integer = 0 To ListBox1.Items.Count - 1
                ' Dim sr_no As Integer = 0
                Dim new_sr_no As Integer = 0
                Dim SeqId As String



                If ListBox1.Items(i) = "Product" Then
                    SeqId = "A"
                    'ElseIf lstMinSeq1.Items(i) = "Design" Then
                    '    SeqId = "B"
                ElseIf ListBox1.Items(i) = "Type" Then
                    SeqId = "B"
                    'ElseIf lstMinSeq1.Items(i) = "Shade" Then
                    '    SeqId = "D"
                ElseIf ListBox1.Items(i) = "Brand" Then
                    SeqId = "C"
               
                ElseIf ListBox1.Items(i) = "Quality" Then
                    SeqId = "D"
                ElseIf ListBox1.Items(i) = "Season" Then
                    SeqId = "E"
                ElseIf ListBox1.Items(i) = "Occassion" Then
                    SeqId = "F"
                ElseIf ListBox1.Items(i) = "Size" Then
                    SeqId = "G"
                    'ElseIf lstMinSeq1.Items(i) = "Supp Degn" Then
                    '    SeqId = "J"
                End If
                sr_no = sr_no + 1

                Query = " insert into MinQtySeq (SNo,SeqId) values( " & sr_no & ",'" & SeqId & "')"
                Common.ExecuteQuery(Query)
            Next
            Trans.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try
    End Sub



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Sub Add_Grid_seq()
        Dim Trans1 As SqlTransaction = Nothing
        Try
            Trans1 = CreateSQLTransaction()

            Query = "Delete From SaleGridSeq "
            Common.ExecuteQuery(Query, Trans1)

            Trans1.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try

        Dim Trans As SqlTransaction = Nothing
        Try
            Trans = CreateSQLTransaction()

            Dim sr_no As Integer = 0
            For i As Integer = 0 To ListBoxTo.Items.Count - 1
                ' Dim sr_no As Integer = 0
                Dim new_sr_no As Integer = 0
                Dim SeqId As String



                If ListBoxTo.Items(i) = "Product" Then
                    SeqId = "I"
                ElseIf ListBoxTo.Items(i) = "Design" Then
                    SeqId = "D"
                ElseIf ListBoxTo.Items(i) = "Type" Then
                    SeqId = "T"
                ElseIf ListBoxTo.Items(i) = "Shade" Then
                    SeqId = "C"
                ElseIf ListBoxTo.Items(i) = "Size" Then
                    SeqId = "S"
                ElseIf ListBoxTo.Items(i) = "Brand" Then
                    SeqId = "B"

                ElseIf ListBoxTo.Items(i) = "Particulars" Then
                    SeqId = "P"
                End If
                sr_no = sr_no + 1

                Query = " insert into SaleGridSeq (SNo,SeqId) values( " & sr_no & ",'" & SeqId & "')"
                Common.ExecuteQuery(Query)
            Next
            Trans.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try
    End Sub
    Sub DisplayExistRecord2()

        Query = "select *  From SaleGridSeq  With(NoLock) "
        Dim DtTable As DataTable = Common.GetDataTable(Query)

        ListBoxTo.Items.Clear()

        'da.Fill(DtTable)
        'For i As Integer = 0 To DtTable.Rows.Count - 1
        '    lstOption1.add(DtTable.Rows(i)("SeqId").ToString())
        'Next


        For Each tempRow In DtTable.Rows
            If tempRow("SeqId") = "I" Then
                ListBoxTo.Items.Add("Product")
            ElseIf tempRow("SeqId") = "D" Then
                ListBoxTo.Items.Add("Design")
            ElseIf tempRow("SeqId") = "T" Then
                ListBoxTo.Items.Add("Type")
            ElseIf tempRow("SeqId") = "C" Then
                ListBoxTo.Items.Add("Shade")
            ElseIf tempRow("SeqId") = "S" Then
                ListBoxTo.Items.Add("Size")
            ElseIf tempRow("SeqId") = "B" Then
                ListBoxTo.Items.Add("Brand")

          
            ElseIf tempRow("SeqId") = "P" Then
                ListBoxTo.Items.Add("Particulars")
            End If
            'raju27022018
            '  txtMinKeyword.Text = tempRow("Keyword")
            'end
        Next

    End Sub
    Private Sub lnkSaleGrid_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSaleGrid.LinkClicked
        PanelGrid.Visible = True
        DisplayExistRecord2()
    End Sub

    Private Sub btnGridSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridSave.Click
        Add_Grid_seq()
        MessageBox.Show("Successfully Saved")
        PanelGrid.Visible = False
    End Sub
    Private Sub btnDeleteAllGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAllGrid.Click
        If ListBoxTo.Items.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to DELETE All record ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        ' Dim Trans As SqlTransaction = Nothing

        If MsgBox("confirm delete ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        Dim Trans As SqlTransaction = Nothing


        Try
            Trans = CreateSQLTransaction()
            'Query = "Delete From ItemShadeBrand Where Item_Key = " & lvwSelectWishList.Items(0).SubItems(lvwAllItem.Item_Key).Text & ""
            Query = "Delete From SaleGridSeq "
            Common.ExecuteQuery(Query, Trans)
            Trans.Commit()

        Catch ex As Exception

        End Try
        ' Label32.Text = lstOption1.Items.Count


        MessageBox.Show("Successfully Deleted All Recode")
        ListBoxTo.Items.Clear()
        PanelGrid.Visible = False

    End Sub

    Private Sub btnCloseGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseGrid.Click
        PanelGrid.Visible = False
    End Sub

    Private Sub btnDeleteGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteGrid.Click
        Dim Text As String = ""

        If ListBoxTo.Items.Count = 1 Then
            Text = ListBoxTo.Items(0)
            ListBoxTo.Items.Clear()
        Else
            If ListBoxTo.SelectedIndex = -1 Then Exit Sub

            Text = ListBoxTo.Items(0)
            ListBoxTo.Items.RemoveAt(ListBoxTo.SelectedIndex)
        End If


        EnableFilters(Text, False)



        Add_Grid_seq()
    End Sub
    Private Sub btnMoveTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveTo.Click
        If ListBoxFrom.SelectedIndex = -1 Then Exit Sub

        If ListBoxTo.Items.Count >= 0 Then
            ListBoxTo.Items.Add(ListBoxFrom.SelectedItem)

            EnableFilters(ListBoxTo.Items(0), True)

            If ListBoxTo.Items.Count > 0 Then


            End If
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




    Sub Add_QrCode_seq()
        Dim Trans1 As SqlTransaction = Nothing
        Try
            Trans1 = CreateSQLTransaction()

            Query = "Delete From QrCodeSeq "
            Common.ExecuteQuery(Query, Trans1)

            Trans1.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try

        Dim Trans As SqlTransaction = Nothing
        Try
            Trans = CreateSQLTransaction()

            Dim sr_no As Integer = 0
            For i As Integer = 0 To ListBoxTo.Items.Count - 1
                ' Dim sr_no As Integer = 0
                Dim new_sr_no As Integer = 0
                Dim SeqId As String



                If ListBoxTo.Items(i) = "Product" Then
                    SeqId = "I"
                ElseIf ListBoxTo.Items(i) = "Design" Then
                    SeqId = "D"
                ElseIf ListBoxTo.Items(i) = "Type" Then
                    SeqId = "T"
                ElseIf ListBoxTo.Items(i) = "Shade" Then
                    SeqId = "C"
                ElseIf ListBoxTo.Items(i) = "Size" Then
                    SeqId = "S"
                ElseIf ListBoxTo.Items(i) = "Brand" Then
                    SeqId = "B"

                ElseIf ListBoxTo.Items(i) = "Sale Rate" Then
                    SeqId = "X"
                ElseIf ListBoxTo.Items(i) = "MRP" Then
                    SeqId = "M"
                ElseIf ListBoxTo.Items(i) = "Barcode" Then
                    SeqId = "U"
                End If
                sr_no = sr_no + 1

                Query = " insert into QrCodeSeq (SNo,SeqId) values( " & sr_no & ",'" & SeqId & "')"
                Common.ExecuteQuery(Query)
            Next
            Trans.Commit()

        Catch ex As Exception

        Finally
            '  Me.Cursor = Cursors.Default
        End Try
    End Sub
    Sub DisplayExistRecord3()

        Query = "select *  From QrCodeSeq  With(NoLock) "
        Dim DtTable As DataTable = Common.GetDataTable(Query)

        ListQrTo.Items.Clear()

        'da.Fill(DtTable)
        'For i As Integer = 0 To DtTable.Rows.Count - 1
        '    lstOption1.add(DtTable.Rows(i)("SeqId").ToString())
        'Next


        For Each tempRow In DtTable.Rows
            If tempRow("SeqId") = "I" Then
                ListQrTo.Items.Add("Product")
            ElseIf tempRow("SeqId") = "D" Then
                ListQrTo.Items.Add("Design")
            ElseIf tempRow("SeqId") = "T" Then
                ListQrTo.Items.Add("Type")
            ElseIf tempRow("SeqId") = "C" Then
                ListQrTo.Items.Add("Shade")
            ElseIf tempRow("SeqId") = "S" Then
                ListQrTo.Items.Add("Size")
            ElseIf tempRow("SeqId") = "B" Then
                ListQrTo.Items.Add("Brand")


            ElseIf tempRow("SeqId") = "X" Then
                ListQrTo.Items.Add("Sale Rate")
            ElseIf tempRow("SeqId") = "M" Then
                ListQrTo.Items.Add("MRP")
            ElseIf tempRow("SeqId") = "U" Then
                ListQrTo.Items.Add("Barcode")
            End If
            'raju27022018
            '  txtMinKeyword.Text = tempRow("Keyword")
            'end
        Next

    End Sub
    Private Sub lnkQrCode_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkQRcodeSeq.LinkClicked
        QrCodePanel.Visible = True
        DisplayExistRecord3()
    End Sub

    Private Sub btnSaveQr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveQr.Click
        Add_QrCode_seq()
        MessageBox.Show("Successfully Saved")
        QrCodePanel.Visible = False
    End Sub
    Private Sub btnDelAllQr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAllQr.Click
        If ListQrTo.Items.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("Do you want to DELETE All record ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        ' Dim Trans As SqlTransaction = Nothing

        If MsgBox("confirm delete ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub
        Dim Trans As SqlTransaction = Nothing


        Try
            Trans = CreateSQLTransaction()
            'Query = "Delete From ItemShadeBrand Where Item_Key = " & lvwSelectWishList.Items(0).SubItems(lvwAllItem.Item_Key).Text & ""
            Query = "Delete From QrCodeSeq "
            Common.ExecuteQuery(Query, Trans)
            Trans.Commit()

        Catch ex As Exception

        End Try
        ' Label32.Text = lstOption1.Items.Count


        MessageBox.Show("Successfully Deleted All Recode")
        ListQrTo.Items.Clear()
        QrCodePanel.Visible = False

    End Sub

    Private Sub btnCloseQrcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseQr.Click
        QrCodePanel.Visible = False
    End Sub

    Private Sub BtnDelQr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelQr.Click
        Dim Text As String = ""

        If ListQrTo.Items.Count = 1 Then
            Text = ListQrTo.Items(0)
            ListQrTo.Items.Clear()
        Else
            If ListQrTo.SelectedIndex = -1 Then Exit Sub

            Text = ListQrTo.Items(0)
            ListQrTo.Items.RemoveAt(ListQrTo.SelectedIndex)
        End If


        EnableFilters(Text, False)



        Add_QrCode_seq()
    End Sub
    Private Sub btnMoveQrTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveQrTo.Click
        If ListQrFrom.SelectedIndex = -1 Then Exit Sub

        If ListBoxTo.Items.Count >= 0 Then
            ListQrTo.Items.Add(ListQrFrom.SelectedItem)

            EnableFilters(ListQrTo.Items(0), True)

            If ListQrTo.Items.Count > 0 Then


            End If
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
End Class