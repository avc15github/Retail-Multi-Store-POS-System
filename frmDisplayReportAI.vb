Imports System.Xml

Public Class frmDisplayReportAI
    Dim RptName As String = ""

    Private Sub frmDisplayReportAI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Query = "Select Modules.Mod_Name, ModDescForReportAI " _
         & " From Modules " _
         & " Inner Join UserRights On Modules.Mod_Id = UserRights.Mod_Id " _
         & " Where User_Id = " & UserId & " And UserRights.AllowAccess = '1' And ModDescForReportAI <> '' And Category = 'F' And ModReq = '1' And Parent_Id <> 0 " _
         & " Order By Modules.Mod_Id"

        Dim dtReport As DataTable = Common.GetDataTable(Query)
        txtReport.TextDescription = "ModDescForReportAI"
        txtReport.TextKey = "Mod_Name"
        txtReport.SourceData = dtReport
        txtReport.SearchWhere = AutoCompleteTextBox.AutoCompleteTextBox.SearchOptions.Between
        txtReport.Text = ""
        txtReport.TextValue = ""
        txtReport.DefaultCustomer = GetBranchSettingAsPerId(BranchWiseSettings.SalesDefaultCustomer)
        txtReport.Focus()
    End Sub

    Private Sub txtReport_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReport.Leave
        'If txtReport.TextValue = "" Then

        '    Exit Sub
        'End If
        'RptName = ""
        'Query = "Select ReportName " _
        '              & " From ReportTypeAI  " _
        '              & " Where ReportTypeAI.RecId = " & txtReport.TextValue & ""
        'Dim DtReport As DataTable = Common.GetDataTable(Query)
        'If DtReport.Rows.Count > 0 Then
        '    RptName = DtReport.Rows(0).Item("ReportName")

        'End If
        btnConfirm.Focus()
    End Sub


    Private Function GetModName(ByVal SearchReport As String) As String
        Dim ModName As String = ""
        Query = " Select Mod_Name From Modules Where Mod_Id = '" & SearchReport & "'  "
        Dim Dt As DataTable = Common.GetDataTable(Query)
        If Dt.Rows.Count > 0 Then
            ModName = Dt.Rows(0).Item("Mod_Name")
        End If
        Return ModName
    End Function

    Private Sub DisplayForm(ByVal frmForm As Form, ByVal frmText As String, Optional ByVal DisplayModal As Boolean = False)
        If DisplayModal Then
            frmForm.Tag = frmText
            frmForm.Show()
        Else
            If Not Common.FormIsLoaded(Me, frmText) Then
                frmForm.Tag = frmText
                frmForm.StartPosition = FormStartPosition.CenterParent
                frmForm.Show()
            End If
        End If
    End Sub



    Private Sub CallReports(ByVal ModName As String)
        If ModName = "" Then Exit Sub
        Dim frmDispForm As Form

        Dim IsRegister As Boolean = False
        Dim ProdRegister As Boolean = False
        Dim DisplayRateValue As Boolean = False
        Dim ProductOptions As Boolean = False
        Dim WithRtnOption As Boolean = False
        Dim WithMonthOption As Boolean = False
        Dim StockRegister As Boolean = False
        Dim StockTransfer As Boolean = False
        Dim WithDetails As Boolean = False

        Select Case ModName.ToUpper
            Case "NDSTKTFRDATE"
                StockTransfer = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockTransfer, frmReportFilters.ReportType.StockTransfer_DateWise, frmReportFilters.DetailSummary.No, "Stock Transfer Register- Date Wise", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDSTKTFRDATE")

            Case "NDSTKTFRDOC"
                StockTransfer = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockTransfer, frmReportFilters.ReportType.StockTransfer_DocWise, frmReportFilters.DetailSummary.No, "Stock Transfer Register- Document Wise", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDSTKTFRDOC")

            Case "NDSTKTFRSALEPERSON"
                StockTransfer = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockTransfer, frmReportFilters.ReportType.StockTransfer_SalepersonWise, frmReportFilters.DetailSummary.No, "Stock Transfer Register- Salesperson Wise", False, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDSTKTFRSALEPERSON")

            Case "NDSTKTFROUT"
                StockTransfer = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockTransfer, frmReportFilters.ReportType.StockTransfer_TfrOut, frmReportFilters.DetailSummary.No, "Transfer Out Register- Transfer Out", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDSTKTFROUT")

            Case "NDSTKTFRIN"
                StockTransfer = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockTransfer, frmReportFilters.ReportType.StockTransfer_TfrIn, frmReportFilters.DetailSummary.No, "Transfer In Register - Transfer In", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDSTKTFRIN")

            Case "NDSTKTFROUTSALESPERSON"
                StockTransfer = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockTransfer, frmReportFilters.ReportType.StockTransfer_TfrOutSalesperson, frmReportFilters.DetailSummary.No, "Transfer Out Register - Salesperson Wise", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDSTKTFROUTSALESPERSON")

            Case "NDSTKTFRINSALESPERSON"
                StockTransfer = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockTransfer, frmReportFilters.ReportType.StockTransfer_TfrInSalesperson, frmReportFilters.DetailSummary.No, "Transfer In Register - Salesperson Wise", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDSTKTFRINSALESPERSON")





            Case "NDPURORDERREGDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDPURORDERREGDATE")

                'Purchase  order
            Case "NDPURORDERREGDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDPURORDERREGDATE")

                'Case "NDVEHPOREGBILL"
                '    IsRegister = True
                '    DisplayRateValue = True
                '    frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.VehPORegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Vehicle Purchase Order Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                '    DisplayForm(frmDispForm, "NDVEHPOREGBILL")


                'Case "NDRPTVEHPURCHASE"
                '    IsRegister = True
                '    DisplayRateValue = True
                '    frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Vehicle Purchase Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                '    DisplayForm(frmDispForm, "NDRPTVEHPURCHASE")

                'Case "NDVEHPURREGSUPPLIER"
                '    IsRegister = True
                '    DisplayRateValue = True
                '    frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Vehicle Purchase Register - Sub Group Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                '    DisplayForm(frmDispForm, "NDVEHPURREGSUPPLIER")

                'Case "NDVEHPURREGSUBGROUP"
                '    IsRegister = True
                '    DisplayRateValue = True
                '    frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Vehicle Purchase Register - Sub Group Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                '    DisplayForm(frmDispForm, "NDVEHPURREGSUBGROUP")

            Case "NDVEHPURREGMODEL"
                ProdRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, " Purchase Register - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHPURREGMODEL")

            Case "NDVEHPURREGBRAND"
                ProdRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, " Purchase Register - Brand Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDVEHPURREGBRAND")


            Case "NDVEHPOREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Order Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHPOREGBILL")

            Case "NDVEHOBREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.OrderBookingRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHOBREGBILL")

            Case "NDCUSTENQREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.CustEnquiryRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDCUSTENQREGBILL")

            Case "NDPURORDERREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPURORDERREGBILL")

            Case "NDPURORDERREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURORDERREGSUPPLIER")



            Case "NDVEHSJCREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.ServiceJobCard, frmReportFiltersForVehicle.ReportType.ServiceJobCardRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Service Job Card - Party Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHSJCREGPARTY")


            Case "NDVEHSJCSTATUSPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.ServiceJobCard, frmReportFiltersForVehicle.ReportType.ServiceJobCardStatus_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Service Job Card Status- Party Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHSJCSTATUSPARTY")



            Case "NDVEHPOREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Order Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHPOREGPARTY")

            Case "NDVEHOBREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.OrderBookingRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHOBREGPARTY")


            Case "NDCUSTENQREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.CustEnquiryRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDCUSTENQREGPARTY")

            Case "NDCUSTENQFOLLOWREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.CustEnquiryFollowUpRegister_PartyWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDCUSTENQFOLLOWREGPARTY")

            Case "NDPURORDERREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - Supplier Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDPURORDERREGSUPPLIER")



            Case "NDPURORDERREGLOCATION"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_LocationWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDPURORDERREGLOCATION")

            Case "NDPURORDERREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPURORDERREGSUBGROUP")

            Case "NDPURORDERREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPURORDERREGPRODUCT")

            Case "NDPURORDERREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Purchase Order Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPURORDERREGBRAND")


            Case "NDVEHPOREGBRAND"
                ProdRegister = True
                ' WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Order Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDVEHPOREGBRAND")

            Case "NDVEHOBREGBRAND"
                ProdRegister = True
                ' WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.OrderBookingRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDVEHOBREGBRAND")

            Case "NDCUSTENQREGBRAND"
                ProdRegister = True
                ' WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.CustEnquiryRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDCUSTENQREGBRAND")

            Case "NDVEHPOREGPRODUCT"
                ProdRegister = True
                ' WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Order Register - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHPOREGPRODUCT")
                ''
            Case "NDVEHOBREGPRODUCT"
                ProdRegister = True
                ' WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.OrderBookingRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Register - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHOBREGPRODUCT")


            Case "NDCUSTENQREGMODEL"
                ProdRegister = True
                ' WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.CustEnquiryRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Register - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDCUSTENQREGMODEL")

            Case "NDCUSTENQREGSHADE"
                ProdRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.CustEnquiryRegister_ShadeWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Register - Shade Wise", True, frmReportFiltersForVehicle.OptionType.Shade)
                DisplayForm(frmDispForm, "NDCUSTENQREGSHADE")

            Case "NDPURTAXREGDATE"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_DateWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - Date Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGDATE")

            Case "NDPURTAXREGDOC"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_DocWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - Doc Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGDOC")

            Case "NDPURTAXREGSUMMARY"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_Summary, frmReportFilters.DetailSummary.No, "Purchase Tax ", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGSUMMARY")
                '''Rohit 10082017
            Case "NDPURTAXREGSUMMARYGST"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.GSTPurTaxRegister_Summary, frmReportFilters.DetailSummary.No, "GST Purchase Tax ", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGSUMMARYGST")
                ''End Rohit 10082017

            Case "NDTAXREGPRODUCT"
                WithRtnOption = True
                WithTaxOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_ProductWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDTAXREGPRODUCT")

            Case "NDTAXREGSUPPLIER"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_SupplierWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - Supplier Wise", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDTAXREGSUPPLIER")

            Case "NDPURREGOPERATOR"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_OperatorWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Operator Wise", True, frmReportFilters.OptionType.OperatorWise)
                DisplayForm(frmDispForm, "NDPURREGOPERATOR")

            Case "NDPURREGCOUNTER"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_CounterWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Counter Wise", True, frmReportFilters.OptionType.Counter)
                DisplayForm(frmDispForm, "NDPURREGCOUNTER")

            Case "NDPURREGDATE"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDPURREGDATE")

            Case "NDPURREGBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPURREGBILL")

                '___shishil 15022017
            Case "NDRENTEDENTRYREGBILL"
                IsRegister = True
                'DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemEntry_BillWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDRENTEDENTRYREGBILL")


                '___shishil 16022017
            Case "NDRENTEDDELIVERYREGBILL"
                IsRegister = True
                ' DisplayRateValue = True
                ' WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItemDlv, frmReportFilters.ReportType.RentedItemDelivery_BillWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDRENTEDDELIVERYREGBILL")

                '___shishil 22022017
            Case "NDRENTEDENTRYREGPARTY"
                IsRegister = True
                'DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemEntry_PartyWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Party Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDRENTEDENTRYREGPARTY")

            Case "NDRENTEDENTRYREGPROD"
                ProdRegister = True
                WithDetails = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemEntry_Productwise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRENTEDENTRYREGPROD")
                '____shishil 25092017

            Case "NDRENTEDITEMSTATUS"
                ProdRegister = True
                WithDetails = True
                ' WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemStatus, frmReportFilters.DetailSummary.Yes, "Rented Item Status", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRENTEDITEMSTATUS")

            Case "NDRENTEDITEMDATEWISE"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemDateWise, frmReportFilters.DetailSummary.Yes, "Rented Items Date Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRENTEDITEMDATEWISE")

                '___________teju 17/01/2018
            Case "NDRENTEDENTRYREGSALEMAN"
                '   IsRegister = True
                'DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemEntry_SalesManWise, frmReportFilters.DetailSummary.Yes, "Rented SalesmanWise Register - Salesman Wise", True, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDRENTEDENTRYREGSALEMAN")


                '___________end teju

                '___________________________________

            Case "NDRENTEDDELIVERYREGPARTY"
                IsRegister = True
                ' DisplayRateValue = True
                ' WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItemDlv, frmReportFilters.ReportType.RentedItemDelivery_PartyWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Party Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDRENTEDDELIVERYREGPARTY")

            Case "NDRENTEDDELIVERYREGPROD"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItemDlv, frmReportFilters.ReportType.RentedItemDelivery_Productwise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRENTEDDELIVERYREGPROD")
                ''

            Case "NDVEHPURREGBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHPURREGBILL")

            Case "NDVEHPURRTNREGBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurRtnRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Return Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHPURRTNREGBILL")

            Case "NDVEHPURRTNREGSUBGROUP"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurRtnRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Return Register - Sub Gruop Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDVEHPURRTNREGSUBGROUP")

            Case "NDVEHPURRTNREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurRtnRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Return Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHPURRTNREGPARTY")

            Case "NDVEHPURRTNREGMODEL"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurRtnRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Return Register - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHPURRTNREGMODEL")


                'Case "NDSALESREGBILL"
                '    IsRegister = True
                '    DisplayRateValue = True
                '    WithRtnOption = True
                '    frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.SalesRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                '    DisplayForm(frmDispForm, "NDSALESREGBILL")


            Case "NDVEHSALESREGBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.SalesRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Sales Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHSALESREGBILL")


            Case "NDVEHISALESREGSUBGROUP"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Sales Register - Sub Group Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDVEHISALESREGSUBGROUP")

            Case "NDVEHSALESREGMODEL"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Sales Register - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHSALESREGMODEL")

            Case "NDVEHSALESPROFITABILITY"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesRegister_Profitability, frmReportFiltersForVehicle.DetailSummary.Yes, "Profitability Report (Bill Wise)", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHSALESPROFITABILITY")

            Case "NDVEHSALESPROFITABILITYPARTYWISE"
                'ProdRegister = True
                IsRegister = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesRegisterProfitability_PartyWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Profitability Report (Party Wise) ", True, frmReportFiltersForVehicle.OptionType.Customer)
                DisplayForm(frmDispForm, "NDVEHSALESPROFITABILITYPARTYWISE")


            Case "NDVEHSALESLEDGERBILL"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesLedger_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Sales Ledger (Bill Wise)", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHSALESPROFITABILITY")

            Case "NDVEHSALESLEDGERPARTYWISE"
                'ProdRegister = True
                IsRegister = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesLedger_PartyWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Sales Ledger (Party Wise) ", True, frmReportFiltersForVehicle.OptionType.Customer)
                DisplayForm(frmDispForm, "NDVEHSALESPROFITABILITYPARTYWISE")

            Case "NDVEHSALESREGMODEL"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Sales Register - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHSALESREGMODEL")

            Case "NDVEHSALESREGCUSTOMER"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Sales, frmReportFiltersForVehicle.ReportType.SalesRegister_CustomerWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Sales Register - Customer Wise", True, frmReportFiltersForVehicle.OptionType.Customer)
                DisplayForm(frmDispForm, "NDVEHSALESREGCUSTOMER")

            Case "NDVEHPURRTNREGBRAND"
                ProdRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurRtnRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Return Register - Brand Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDVEHPURRTNREGBRAND")

            Case "NDPURREGSUPPLIER"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURREGSUPPLIER")

            Case "NDWAYBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_WayBill, frmReportFilters.DetailSummary.Yes, " Way Bill Register", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDWAYBILL")

            Case "NDENTRYTAX"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_EnrtyTax, frmReportFilters.DetailSummary.Yes, " Entry Tax Register", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDENTRYTAX")

            Case "NDEXCISEDUTY"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                '  frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_exciseduty, frmReportFilters.DetailSummary.Yes, " Excise Duty Register -" & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurchaseRegister_exciseduty, frmReportFilters.DetailSummary.Yes, "Excise Duty Register - Bill Wise", True, frmReportFilters.OptionType.Bill)

                DisplayForm(frmDispForm, "NDEXCISEDUTY")



            Case "NDPURREGLOCATION"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_LocationWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDPURREGLOCATION")

            Case "NDPURREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPURREGSUBGROUP")


            Case "NDVEHPURREGSUPPLIER"
                IsRegister = True
                'WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Register - Supplier Wise Register", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHPURREGSUPPLIER")

            Case "NDVEHPURREGSUBGROUP"
                ProdRegister = True
                'WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurchaseRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDVEHPURREGSUBGROUP")

            Case "NDPURREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPURREGPRODUCT")

            Case "NDPURREGBRAND"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPURREGBRAND")

            Case "NDPURCHASEDOCWISESTOCK"
                'IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.SupplierDocWiseStock, frmReportFilters.DetailSummary.No, "Supplier Doc Wise Stock", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURREGPRODUCT")

            Case "NDPERIODICALPURCHASE"
                ProdRegister = True
                ProductOptions = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PeriodicalPurchase, frmReportFilters.DetailSummary.No, "Periodical Purchase")
                DisplayForm(frmDispForm, "NDPERIODICALPURCHASE")

            Case "NDMONTHLYPUR"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.MonthlyPurchase, frmReportFilters.DetailSummary.No, "Monthly Purchase", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYPUR")

            Case "NDMONTHLYPURDATE"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.MonthlyPurchaseDate, frmReportFilters.DetailSummary.No, "Monthly Purchase - Date Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYPURDATE")

            Case "NDTOPNSUPPLIERS"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.TopNSuppliers, frmReportFilters.DetailSummary.No, "Top N Suppliers", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDTOPNSUPPLIERS")

            Case "NDTOPNPURCHASE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.TopNPurchase, frmReportFilters.DetailSummary.No, "Top N " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " (Purchase)", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDTOPNPURCHASE")

            Case "NDCONSOPURDATEPROD"
                ProdRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.ConsolidatedPurchase_DtProduct, frmReportFilters.DetailSummary.No, "Consolidated Purchase - Date/" & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDCONSOPURDATEPROD")

            Case "NDEXCESSLESSQTYRECDAGAINSTORDER"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.ExcessLessQty_AgainstOrder, frmReportFilters.DetailSummary.No, "Excess/Less Quantity Purchased Against Order", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDEXCESSLESSQTYRECDAGAINSTORDER")

            Case "NDMARGINSUMONPUR"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.MarginSummary_Purchase, frmReportFilters.DetailSummary.No, "Margin Summary - Purchase", False, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDMARGINSUMONPUR")

            Case "NDPRODWISEBARCDPURCH"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.BarcodeWisePurchase, frmReportFilters.DetailSummary.No, "Barcode Wise Purchase", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPRODWISEBARCDPURCH")




                ''Pending 


            Case "NDPENDPURORDERREGDATE"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PendPurOrderRegister_DateWise, frmReportFilters.DetailSummary.Yes, "PO Status Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDPENDPURORDERREGDATE")

            Case "NDVEHPOREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Order Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHPOREGBILL")




            Case "NDPENDPURORDERREGBILL"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PendPurOrderRegister_BillWise, frmReportFilters.DetailSummary.Yes, "PO Status Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPENDPURORDERREGBILL")

            Case "NDVEHSJCREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.ServiceJobCard, frmReportFiltersForVehicle.ReportType.ServiceJobCardRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Service Job Card Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Service)
                DisplayForm(frmDispForm, "NDVEHSJCREGBILL")

            Case "NDVEHSJCSTATUSBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.ServiceJobCard, frmReportFiltersForVehicle.ReportType.ServiceJobCardStatus_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Service Job Card Status - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHSJCSTATUSBILL")


            Case "NDPENDVEHPOREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PendPurOrderRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "PO Status Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPENDVEHPOREGBILL")

            Case "NDPENDVEHOBREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.PendOrderBookingRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Status Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPENDVEHOBREGBILL")


            Case "NDPENDCUSTENQREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Status Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPENDCUSTENQREGBILL")



            Case "NDPENDPURORDERREGPARTY"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PendPurOrderRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "PO Status Register - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPENDPURORDERREGPARTY")



            Case "NDCNSTATUS"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.CnStatus, frmReportFilters.DetailSummary.No, "CN Status - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDCNSTATUS")

            Case "NDPENDVEHPOREGPARTY"
                IsRegister = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PendPurOrderRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "PO Status Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPENDVEHPOREGPARTY")

            Case "NDPENDVEHOBREGPARTY"
                IsRegister = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.PendOrderBookingRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Status Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPENDVEHOBREGPARTY")

            Case "NDPENDCUSTENQREGPARTY"
                IsRegister = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryRegister_SupplierWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Status Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPENDCUSTENQREGPARTY")

            Case "NDPENDCUSTFOLLOWUP"
                IsRegister = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryFollowRegister_PartyWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Follow Up Register - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Customer)
                DisplayForm(frmDispForm, "NDPENDCUSTFOLLOWUP")

            Case "NDPENDPURORDERREGLOCATION"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PendPurOrderRegister_LocationWise, frmReportFilters.DetailSummary.Yes, "PO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDPENDPURORDERREGLOCATION")

            Case "NDPENDPURORDERREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PendPurOrderRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "PO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPENDPURORDERREGSUBGROUP")

            Case "NDPENDVEHPOREGSUBGROUP"
                ProdRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PendPurOrderRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "PO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPENDVEHPOREGSUBGROUP")

            Case "NDPENDVEHOBREGSUBGROUP"
                ProdRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.PendOrderBookingRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Status Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPENDVEHOBREGSUBGROUP")

            Case "NDPENDCUSTENQREGSUBGROUP"
                ProdRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Status Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPENDCUSTENQREGSUBGROUP")


            Case "NDVEHPOREGSUBGROUP"
                ProdRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Order Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDVEHPOREGSUBGROUP")

            Case "NDVEHOBREGSUBGROUP"
                ProdRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.OrderBookingRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDVEHOBREGSUBGROUP")


            Case "NDCUSTENQREGSUBGROUP"
                ProdRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.CustEnquiryRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDCUSTENQREGSUBGROUP")



            Case "NDPENDPURORDERREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PendPurOrderRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "PO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPENDPURORDERREGPRODUCT")

            Case "NDPENDVEHPOREGMODEL"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PendPurOrderRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "PO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDPENDVEHPOREGMODEL")

            Case "NDPENDVEHOBREGMODEL"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.PendOrderBookingRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Status Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDPENDVEHOBREGMODEL")

            Case "NDPENDCUSTENQREGMODEL"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryRegister_ProductWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Status Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDPENDCUSTENQREGMODEL")


            Case "NDPENDPURORDERREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PendPurOrderRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "PO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPENDPURORDERREGBRAND")

            Case "NDPENDVEHPOREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PendPurOrderRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, "PO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPENDVEHPOREGBRAND")

            Case "NDPENDVEHOBREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.PendOrderBookingRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Order Booking Status Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPENDVEHOBREGBRAND")


            Case "NDPENDCUSTENQREGSHADE"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryRegister_ShadeWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Status Register - Shade Wise", True, frmReportFiltersForVehicle.OptionType.Shade)
                DisplayForm(frmDispForm, "NDPENDCUSTENQREGSHADE")

            Case "NDPENDCUSTENQREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryRegister_BrandWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Customer Enquiry Status Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPENDCUSTENQREGBRAND")




            Case "NDPURORDERCANCELLED"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderCancelled_SupplierWise, frmReportFilters.DetailSummary.No, "PO Cancelled Register - Supplier Wise", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURORDERCANCELLED")

            Case "NDVEHPOCANCELLED"
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderCancelled_SupplierWise, frmReportFiltersForVehicle.DetailSummary.No, "PO Cancelled Register - Supplier Wise", False, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHPOCANCELLED")

            Case "NDVEHOBCANCELLED"
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.BookingMaster, frmReportFiltersForVehicle.ReportType.OrderBookingCancelled_SupplierWise, frmReportFiltersForVehicle.DetailSummary.No, "Order Booking Cancelled Register - Supplier Wise", False, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHOBCANCELLED")

            Case "NDCUSTENQCANCELLED"
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.CustEnquiry, frmReportFiltersForVehicle.ReportType.PendCustEnquiryCancelled_SupplierWise, frmReportFiltersForVehicle.DetailSummary.No, "Customer Enquiry Cancelled Register - Supplier Wise", False, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDCUSTENQCANCELLED")


            Case "NDPURORDERSHORTCLOSE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.PurOrderShortClose_SupplierWise, frmReportFilters.DetailSummary.No, "PO Short Close Register - Supplier Wise", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURORDERSHORTCLOSE")

            Case "NDVEHPOSHORTCLOSE"
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.PurchaseOrder, frmReportFiltersForVehicle.ReportType.PurOrderShortClose_SupplierWise, frmReportFiltersForVehicle.DetailSummary.No, "PO Short Close Register - Supplier Wise", False, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDVEHPOSHORTCLOSE")
                ''Purchase

                'Purchase

            Case "NDPURTAXREGDATE"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_DateWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - Date Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGDATE")

            Case "NDPURTAXREGDOC"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_DocWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - Doc Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGDOC")

            Case "NDPURTAXREGSUMMARY"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_Summary, frmReportFilters.DetailSummary.No, "Purchase Tax Summary", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGSUMMARY")
                '''Rohit 10082017
            Case "NDPURTAXREGSUMMARYGST"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.GSTPurTaxRegister_Summary, frmReportFilters.DetailSummary.No, "Purchase Tax GST", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURTAXREGSUMMARYGST")
                ''End Rohit 10082017

            Case "NDTAXREGPRODUCT"
                WithRtnOption = True
                WithTaxOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_ProductWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDTAXREGPRODUCT")

            Case "NDTAXREGSUPPLIER"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurTaxRegister_SupplierWise, frmReportFilters.DetailSummary.No, "Purchase Tax Register - Supplier Wise", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDTAXREGSUPPLIER")

            Case "NDPURREGOPERATOR"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_OperatorWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Operator Wise", True, frmReportFilters.OptionType.OperatorWise)
                DisplayForm(frmDispForm, "NDPURREGOPERATOR")

            Case "NDPURREGCOUNTER"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_CounterWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Counter Wise", True, frmReportFilters.OptionType.Counter)
                DisplayForm(frmDispForm, "NDPURREGCOUNTER")

            Case "NDPURREGDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDPURREGDATE")

            Case "NDPURREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPURREGBILL")

                '___shishil 15022017
            Case "NDRENTEDENTRYREGBILL"
                IsRegister = True
                'DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemEntry_BillWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDRENTEDENTRYREGBILL")



                '___shishil 16022017
            Case "NDRENTEDDELIVERYREGBILL"
                IsRegister = True
                ' DisplayRateValue = True
                ' WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItemDlv, frmReportFilters.ReportType.RentedItemDelivery_BillWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDRENTEDDELIVERYREGBILL")

                '___shishil 22022017
            Case "NDRENTEDENTRYREGPARTY"
                IsRegister = True
                'DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemEntry_PartyWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Party Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDRENTEDENTRYREGPARTY")

            Case "NDRENTEDENTRYREGPROD"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItem, frmReportFilters.ReportType.RentedItemEntry_Productwise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRENTEDENTRYREGPROD")

            Case "NDRENTEDDELIVERYREGPARTY"
                IsRegister = True
                ' DisplayRateValue = True
                ' WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItemDlv, frmReportFilters.ReportType.RentedItemDelivery_PartyWise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - Party Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDRENTEDDELIVERYREGPARTY")

            Case "NDRENTEDDELIVERYREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.RentedItemDlv, frmReportFilters.ReportType.RentedItemDelivery_Productwise, frmReportFilters.DetailSummary.Yes, "Rented Items Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRENTEDDELIVERYREGPRODUCT")
                ''


            Case "NDVEHPURRTNREGBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurRtnRegister_BillWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Return Register - Bill Wise", True, frmReportFiltersForVehicle.OptionType.Bill)
                DisplayForm(frmDispForm, "NDVEHPURRTNREGBILL")

            Case "NDVEHPURRTNREGSUBGROUP"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Purchase, frmReportFiltersForVehicle.ReportType.PurRtnRegister_SubGroupWise, frmReportFiltersForVehicle.DetailSummary.Yes, "Purchase Return Register - Sub Group Wise", True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDVEHPURRTNREGSUBGROUP")

            Case "NDPURREGSUPPLIER"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURREGSUPPLIER")


            Case "NDWAYBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_WayBill, frmReportFilters.DetailSummary.Yes, " Way Bill Register", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDWAYBILL")

            Case "NDENTRYTAX"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_EnrtyTax, frmReportFilters.DetailSummary.Yes, " Entry Tax Register", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDENTRYTAX")

                ''
            Case "NDBILLWISEBARCODEDETAIL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.BillWiseBarcode_PrintDetail, frmReportFilters.DetailSummary.Yes, "Bill Wise Barcode Print Detail", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDBILLWISEBARCODEDETAIL")
                ''

            Case "NDPURREGLOCATION"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_LocationWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDPURREGLOCATION")

            Case "NDPURREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPURREGSUBGROUP")

            Case "NDPURREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPURREGPRODUCT")

            Case "NDPURREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PurchaseRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Purchase Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPURREGBRAND")

            Case "NDPURCHASEDOCWISESTOCK"
                'IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.SupplierDocWiseStock, frmReportFilters.DetailSummary.No, "Supplier Doc Wise Stock", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURREGPRODUCT")

            Case "NDPERIODICALPURCHASE"
                ProdRegister = True
                ProductOptions = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.PeriodicalPurchase, frmReportFilters.DetailSummary.No, "Periodical Purchase")
                DisplayForm(frmDispForm, "NDPERIODICALPURCHASE")

            Case "NDMONTHLYPUR"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.MonthlyPurchase, frmReportFilters.DetailSummary.No, "Monthly Purchase", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYPUR")

            Case "NDMONTHLYPURDATE"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.MonthlyPurchaseDate, frmReportFilters.DetailSummary.No, "Monthly Purchase - Date Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYPURDATE")

            Case "NDTOPNSUPPLIERS"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.TopNSuppliers, frmReportFilters.DetailSummary.No, "Top N Suppliers", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDTOPNSUPPLIERS")

            Case "NDTOPNPURCHASE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.TopNPurchase, frmReportFilters.DetailSummary.No, "Top N " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " (Purchase)", False, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDTOPNPURCHASE")

            Case "NDCONSOPURDATEPROD"
                ProdRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.ConsolidatedPurchase_DtProduct, frmReportFilters.DetailSummary.No, "Consoloidated Purchase - Date/" & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDCONSOPURDATEPROD")

            Case "NDEXCESSLESSQTYRECDAGAINSTORDER"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.ExcessLessQty_AgainstOrder, frmReportFilters.DetailSummary.No, "Excess/Less Quantity Purchased Against Order", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDEXCESSLESSQTYRECDAGAINSTORDER")

            Case "NDMARGINSUMONPUR"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.MarginSummary_Purchase, frmReportFilters.DetailSummary.No, "Margin Summary - Purchase", False, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDMARGINSUMONPUR")

            Case "NDPRODWISEBARCDPURCH"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.BarcodeWisePurchase, frmReportFilters.DetailSummary.No, "Barcode Wise Purchase", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPRODWISEBARCDPURCH")



                ''purchase  return

            Case "NDPURRTNREGOPERATOR"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_OperatorWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - Operator Wise", True, frmReportFilters.OptionType.OperatorWise)
                DisplayForm(frmDispForm, "NDPURRTNREGOPERATOR")

            Case "NDPURRTNREGCOUNTER"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_CounterWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - Counter Wise", True, frmReportFilters.OptionType.Counter)
                DisplayForm(frmDispForm, "NDPURRTNREGCOUNTER")

            Case "NDPURRTNREGDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDPURRTNREGDATE")

            Case "NDPURRTNREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPURRTNREGBILL")

            Case "NDPURRTNREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPURRTNREGPARTY")

            Case "NDPURRTNREGLOCATION"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_LocationWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDPURRTNREGLOCATION")

            Case "NDPURRTNREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPURRTNREGSUBGROUP")

            Case "NDPURRTNREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPURRTNREGPRODUCT")

            Case "NDPURRTNREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PurRtnRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Purchase Rtn Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPURRTNREGBRAND")

            Case "NDMONTHLYPURRTN"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.MonthlyPurchaseRtn, frmReportFilters.DetailSummary.No, "Monthly Purchase Return", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYPURRTN")

            Case "NDMONTHLYPURRTNDATE"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.MonthlyPurchaseDateRtn, frmReportFilters.DetailSummary.No, "Monthly Purchase Return - Date Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYPURRTNDATE")

            Case "NDPERIODICALPURCHASERTN"
                ProdRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.PeriodicalPurchaseRtn, frmReportFilters.DetailSummary.No, "Periodical Purchase Return")
                DisplayForm(frmDispForm, "NDPERIODICALPURCHASERTN")

            Case "NDALLINONEPURCHASE"
                IsRegister = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Purchase, frmReportFilters.ReportType.AllInOnePurchase, frmReportFilters.DetailSummary.No, "All-In-One Purchase", True)
                DisplayForm(frmDispForm, "NDALLINONEPURCHASE")

            Case "NDALLINONEPURCHASERTN"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.AllInOnePurchaseRtn, frmReportFilters.DetailSummary.No, "All-In-One Purchase Return", True)
                DisplayForm(frmDispForm, "NDALLINONEPURCHASERTN")

            Case "NDALLINPURORDER"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseOrder, frmReportFilters.ReportType.AllInOnePurchaseOrder, frmReportFilters.DetailSummary.No, "All-In-One Purchase Order", True)
                DisplayForm(frmDispForm, "NDALLINPURORDER")

            Case "NDSTOCKLEVEL"
                ProdRegister = True
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Stock_Level, frmReportFilters.DetailSummary.No, "Stock Level - Product Wise", True)
                DisplayForm(frmDispForm, "NDSTOCKLEVEL")

            Case "NDSTOCKLEVELDESIGN"
                ProdRegister = True
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Stock_Level_Design, frmReportFilters.DetailSummary.No, "Stock Level - Design Wise", True)
                DisplayForm(frmDispForm, "NDSTOCKLEVELDESIGN")
                'Sales
                '   Select Case e.Node.Name.ToUpper
            Case "NDSALESREGOPERATOR"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_OperatorWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Operator Wise", True, frmReportFilters.OptionType.OperatorWise)
                DisplayForm(frmDispForm, "NDSALESREGOPERATOR")

            Case "NDSALESREGCOUNTER"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_CounterWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Counter Wise", True, frmReportFilters.OptionType.Counter)
                DisplayForm(frmDispForm, "NDSALESREGCOUNTER")

            Case "NDSALESREGDATE"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSALESREGDATE")

            Case "NDSALESREGMOPGSTDATE"
                'IsRegister = True
                'DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_MOPGSTDateWise, frmReportFilters.DetailSummary.No, "GST Summary(Pay Mode Wise)", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSALESREGMOPGSTDATE")

            Case "NDSALESREGBILL"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDSALESREGBILL")

            Case "NDGVBILLWISE"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GiftVoucher_BillWise, frmReportFilters.DetailSummary.Yes, "Gift Voucher Bill Wise Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDGVBILLWISE")


            Case "NDGVRATEWISE"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GiftVoucher_RateWise, frmReportFilters.DetailSummary.Yes, "Gift Voucher Bill Wise Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDGVRATEWISE")


            Case "NDSALESREGCUSTOMER"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_CustomerWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Customer Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDSALESREGCUSTOMER")

            Case "NDSALESREGLOCATION"
                IsRegister = True
                DisplayRateValue = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_LocationWise, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDSALESREGLOCATION")

                '__shishil 04042017
            Case "NDLOCSALEREG"
                IsRegister = True
                DisplayRateValue = True
                ProdRegister = True
                'WithRtnOption = True

                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_StockLocationWise, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDLOCSALEREG")

                '_shishil(31052017)
            Case "NDDAYENDSALERPT"
                IsRegister = True
                DisplayRateValue = True
                ProdRegister = True
                'WithRtnOption = True

                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_DayEndLocationWise, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDDAYENDSALERPT")
                ''''''''''''''


            Case "NDSALESREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSALESREGSUBGROUP")

            Case "NDSALESREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSALESREGPRODUCT")

            Case "NDSALESREGBRAND"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDSALESREGBRAND")

            Case "NDSALESREGCUSTPRODUCT"
                ProdRegister = True
                ' WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_CustProductWise, frmReportFilters.DetailSummary.No, "Sales Register - Customer/" & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSALESREGCUSTPRODUCT")

            Case "NDSALESREGSUPPLIER"
                ProductOptions = True
                'WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "Supplier Wise Sales Register", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSALESREGSUPPLIER")

            Case "NDCONSOLIDATEDSALESNETTDATEWISE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.DailySalesReport_DateWise, frmReportFilters.DetailSummary.No, "Daily Sales Register (With Return) - Date Wise", False, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDCONSOLIDATEDSALESNETTDATEWISE")

            Case "NDSALESWITHRTNTAXDETAILSDATEWISE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegisterWithRtn_DateWise, frmReportFilters.DetailSummary.No, "Sales Register (With Return) - Date Wise", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSALESWITHRTNTAXDETAILSDATEWISE")

            Case "NDSALESWITHRTNTAXDETAILSPRODUCTWISE"
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegisterWithRtn_ProductWise, frmReportFilters.DetailSummary.No, "Sales Register (With Return) - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", False, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDSALESWITHRTNTAXDETAILSPRODUCTWISE")

            Case "NDSALESWITHRTNTAXDETAILSBRANDWISE"
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegisterWithRtn_BrandWise, frmReportFilters.DetailSummary.No, "Sales Register (With Return) - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", False, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDSALESWITHRTNTAXDETAILSBRANDWISE")

                '' ADDED BY RAHUL ON 16/07/2019
            Case "NDSALEPERSONPERF"
                'IsRegister = True
                'DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_Performance, frmReportFilters.DetailSummary.No, "Salesman Performance Sales Register", True, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDSALEPERSONPERF")
                '' END

            Case "NDDAILYSALESSALEPERSON"
                'IsRegister = True
                'DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesRegister_SalepersonWise, frmReportFilters.DetailSummary.Yes, "Saleperson Wise Sales Register", True, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDDAILYSALESSALEPERSON")

            Case "NDSALESTAXREGDOCNO"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesTaxRegister_DocWise, frmReportFilters.DetailSummary.No, "Tax Register - Doc Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESTAXREGDOCNO")

            Case "NDSALESTAXREGDAILY"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesTaxRegister_DateWise, frmReportFilters.DetailSummary.No, "Tax Register - Date Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESTAXREGDAILY")

            Case "NDSALESVATREGISTER"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesVATRegister, frmReportFilters.DetailSummary.No, "VAT Register", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDVATREGISTER")

            Case "NDSALESTAXREGSUMMARY"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesTaxRegister_Summary, frmReportFilters.DetailSummary.No, "VAT Tax Register", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESTAXREGSUMMARY")
                '''Rohit 10082017
            Case "NDSALESTAXREGSUMMARYGST"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GSTSalesTaxRegister_Summary, frmReportFilters.DetailSummary.No, "VAT Tax Register", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESTAXREGSUMMARYGST")
                '''End Rohit 10082017
            Case "NDTAXCOMPUTATION"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.TaxComputation, frmReportFilters.DetailSummary.No, "Tax Computation", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDTAXCOMPUTATION")

                '___shishil 12082017
            Case "NDGSTCOMP"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GSTComputation, frmReportFilters.DetailSummary.No, " GST Computation", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDGSTCOMP")
                '______

                '___shishil 11102017
            Case "NDKARIGARREG"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.KarigarRegister, frmReportFilters.DetailSummary.No, "Karigar Register", False, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDKARIGARREG")
                '______


            Case "NDCTRWISEPRODUCTSSOLD"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.CounterWiseProductSold, frmReportFilters.DetailSummary.No, GetSystemCaption(SystemCaptionIdx.DefProduct) & " Sold/Counter", False)
                DisplayForm(frmDispForm, "NDCTRWISEPRODUCTSSOLD")

            Case "                                                                                                                                                  "
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.TopSoldItems, frmReportFilters.DetailSummary.No, "Top N " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDTOPNITEMS")

            Case "NDTOPCUSTNOTVISITTHISMTH"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.TopCustomersNotVisitedThisMonth, frmReportFilters.DetailSummary.No, "Top Customers Not Visited This Month", False)
                DisplayForm(frmDispForm, "NDTOPCUSTNOTVISITTHISMTH")

            Case "NDPRODUCTSSOLDPERHOUR"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.ProductsSoldPerHour, frmReportFilters.DetailSummary.No, GetSystemCaption(SystemCaptionIdx.DefProduct) & " Sold Per Hour", False)
                DisplayForm(frmDispForm, "NDPRODUCTSSOLDPERHOUR")

            Case "NDTOPNCUSTOMERS"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.TopNCustomers, frmReportFilters.DetailSummary.No, "Top N Customers", False)
                DisplayForm(frmDispForm, "NDTOPNCUSTOMERS")

            Case "NDTOPNBILLS"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.TopNBills, frmReportFilters.DetailSummary.No, "Top N Bills", False)
                DisplayForm(frmDispForm, "NDTOPNBILLS")

            Case "NDBOTTOMNITEMS"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.BottomSoldItems, frmReportFilters.DetailSummary.No, "Bottom N " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDBOTTOMNITEMS")

            Case "NDBUSYDAYS"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.BusyDays, frmReportFilters.DetailSummary.No, "Busy Days", False, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDBUSYDAYS")

            Case "NDBUSYHOURS"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.BusyHours, frmReportFilters.DetailSummary.No, "Busy Hours", False, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDBUSYHOURS")

            Case "NDPROFITABLILITY"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.Profitability, frmReportFilters.DetailSummary.No, "Profitability Report", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPROFITABLILITY")

                '--------------11-06-2016------------------
            Case "NDPROFITABLILITYBILLWISE"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.ProfitabilityBillwise, frmReportFilters.DetailSummary.Yes, "Profitability Bill Wise Report", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPROFITABLILITYBILLWISE")


            Case "NDDATEWISEMARGINSUMMARY"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.MarginSummary_DateWise, frmReportFilters.DetailSummary.No, "Sales Margin Summary - Date Wise", False, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDDATEWISEMARGINSUMMARY")

            Case "NDSUBGRPMARGINSUMMARY"
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.MarginSummary_SubGroupWise, frmReportFilters.DetailSummary.No, "Sales Margin Summary - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSUBGRPMARGINSUMMARY")

            Case "NDCANCELLEDBILLS"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.CancelledBills_DateWise, frmReportFilters.DetailSummary.No, "Cancelled Bills", False, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDCANCELLEDBILLS")

            Case "NDSALESTAXREGPRODUCT"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesTaxRegister_ProductWise, frmReportFilters.DetailSummary.No, "Tax Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSALESTAXREGPRODUCT")

            Case "NDSALESTAXREGSUBGROUP"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesTaxRegister_SubGroupWise, frmReportFilters.DetailSummary.No, "Tax Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", False, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSALESTAXREGSUBGROUP")

            Case "NDSALESRTNREGOPERATOR"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_OperatorWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - Operator Wise", True, frmReportFilters.OptionType.OperatorWise)
                DisplayForm(frmDispForm, "NDSALESRTNREGOPERATOR")

            Case "NDSALESRTNREGCOUNTER"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_CounterWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - Counter Wise", True, frmReportFilters.OptionType.Counter)
                DisplayForm(frmDispForm, "NDSALESRTNREGCOUNTER")

            Case "NDSALESRTNREGLOCATION"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_LocationWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDSALESRTNREGLOCATION")

            Case "NDSALESRTNREGDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSALESRTNREGDATE")

            Case "NDSALESRTNREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDSALESRTNREGBILL")

            Case "NDSALESRTNREGCUSTOMER"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - Customer Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSALESRTNREGCUSTOMER")

            Case "NDSALESRTNREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSALESRTNREGSUBGROUP")

            Case "NDSALESRTNREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSALESRTNREGPRODUCT")

            Case "NDSALESRTNREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDSALESRTNREGBRAND")

            Case "NDSALESRTNSALESMAN"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_SalepersonWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - Saleperson Wise", False, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDSALESRTNSALESMAN")

            Case "NDSALESRTNPRODSALESMAN"
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnRegister_ProdSalepersonWise, frmReportFilters.DetailSummary.Yes, "Sales Rtn Register - Saleperson/" & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDSALESRTNPRODSALESMAN")

            Case "NDFASTMOVINGSUPPLIER"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.FastMovingSupplier, frmReportFilters.DetailSummary.Yes, "Fast Moving Items - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDFASTMOVINGSUPPLIER")

            Case "NDFASTMOVINGSUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.FastMovingSubGroup, frmReportFilters.DetailSummary.Yes, "Fast Moving Items - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDFASTMOVINGSUBGROUP")

            Case "NDFASTMOVINGPRODUCT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.FastMovingProduct, frmReportFilters.DetailSummary.Yes, "Fast Moving Items - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDFASTMOVINGPRODUCT")

            Case "NDSLOWMOVINGSUPPLIER"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SlowMovingSupplier, frmReportFilters.DetailSummary.Yes, "Slow Moving Items - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSLOWMOVINGSUPPLIER")

            Case "NDSLOWMOVINGSUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SlowMovingSubGroup, frmReportFilters.DetailSummary.Yes, "Slow Moving Items - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSLOWMOVINGSUBGROUP")

            Case "NDSLOWMOVINGPRODUCT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SlowMovingProduct, frmReportFilters.DetailSummary.Yes, "Slow Moving Items - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSLOWMOVINGPRODUCT")

            Case "NDDEADSTOCK"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.DeadStock, frmReportFilters.DetailSummary.Yes, "Dead Stock", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDDEADSTOCK")


            Case "NDSALESRTNTAXREGDOCNO"
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnTaxRegister_DocWise, frmReportFilters.DetailSummary.No, "Tax Register - Doc Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESRTNTAXREGDOCNO")

            Case "NDSALESRTNTAXREGDAILY"
                ' WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnTaxRegister_DateWise, frmReportFilters.DetailSummary.No, "Tax Register - Date Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESRTNTAXREGDAILY")

            Case "NDSALESRTNVATREGISTER"
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnVATRegister, frmReportFilters.DetailSummary.No, "VAT Register", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESRTNVATREGISTER")

            Case "NDSALESRTNTAXREGSUMMARY"
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnTaxRegister_Summary, frmReportFilters.DetailSummary.No, "Tax Summary", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESRTNTAXREGSUMMARY")

            Case "NDSALESRTNTAXREGPRODUCT"
                ' WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnTaxRegister_ProductWise, frmReportFilters.DetailSummary.No, "Tax Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESRTNTAXREGPRODUCT")

            Case "NDSALESRTNTAXREGSUBGROUP"
                'WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.SalesRtnTaxRegister_SubGroupWise, frmReportFilters.DetailSummary.No, "Tax Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDSALESRTNTAXREGSUBGROUP")

                ''''Satyam 16062023

            Case "NDPURCHASERETURNGSTTAXREGISTER"
                WithRtnOption = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.PurchaseRtn, frmReportFilters.ReportType.GSTPurchaseReturnTaxRegister, frmReportFilters.DetailSummary.No, "Purchase Return GST Tax Summery ", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDPURCHASERETURNGSTTAXREGISTER")
                '''

                ''Stock

            Case "NDOPENINGSTKSUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.OpeningStockSubGroup, frmReportFilters.DetailSummary.No, "Opening Stock - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup), True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDOPENINGSTKSUBGROUP")

            Case "NDOPENINGSTKPRODUCT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.OpeningStockProduct, frmReportFilters.DetailSummary.No, "Opening Stock - " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDOPENINGSTKPRODUCT")

            Case "NDOPENINGSTKBRAND"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.OpeningStockBrand, frmReportFilters.DetailSummary.No, "Opening Stock - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & "", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDOPENINGSTKBRAND")

            Case "NDOPENINGSTKLOCATION"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.OpeningStockLocation, frmReportFilters.DetailSummary.No, "Opening Stock - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & "", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDOPENINGSTKLOCATION")



            Case "NDSTOCKDOC"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.ClosingStockDocument, frmReportFilters.DetailSummary.No, "Closing Stock - Document", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSTOCKDOC")

            Case "NDCLOSINGSTKSUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.ClosingStockSubGroup, frmReportFilters.DetailSummary.Yes, "Closing Stock - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup), True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDCLOSINGSTKSUBGROUP")

            Case "NDCLOSINGVEHSTKSUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Stock, frmReportFiltersForVehicle.ReportType.ClosingStockSubGroup, frmReportFiltersForVehicle.DetailSummary.Yes, "Closing Stock - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup), True, frmReportFiltersForVehicle.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDCLOSINGVEHSTKSUBGROUP")

            Case "NDCLOSINGVEHSTKMODEL"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Stock, frmReportFiltersForVehicle.ReportType.ClosingStockProduct, frmReportFiltersForVehicle.DetailSummary.Yes, "Closing Stock - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDCLOSINGVEHSTKMODEL")

            Case "NDCLOSINGVEHSTKBRAND"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Stock, frmReportFiltersForVehicle.ReportType.ClosingStockBrand, frmReportFiltersForVehicle.DetailSummary.Yes, "Closing Stock - Brand Wise", True, frmReportFiltersForVehicle.OptionType.Brand)
                DisplayForm(frmDispForm, "NDCLOSINGVEHSTKBRAND")

            Case "NDCLOSINGVEHSTKSUPPLIER"
                IsRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Stock, frmReportFiltersForVehicle.ReportType.ClosingStockSupplier, frmReportFiltersForVehicle.DetailSummary.Yes, "Closing Stock - Supplier Wise", True, frmReportFiltersForVehicle.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDCLOSINGVEHSTKSUPPLIER")


            Case "NDCLOSINGSTKPRODUCT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.ClosingStockProduct, frmReportFilters.DetailSummary.Yes, "Closing Stock - " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDCLOSINGSTKPRODUCT")

            Case "NDCLOSINGSTKSUBBRAND"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.ClosingStockBrand, frmReportFilters.DetailSummary.Yes, "Closing Stock - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & "", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDCLOSINGSTKSUBBRAND")

            Case "NDCLOSINGSTKSUPPLIER"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.ClosingStockSupplier, frmReportFilters.DetailSummary.Yes, "Closing Stock - Supplier", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDCLOSINGSTKSUPPLIER")

            Case "NDCLOSINGSTKLOCATION"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.ClosingStockLocation, frmReportFilters.DetailSummary.Yes, "Closing Stock - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & "", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDCLOSINGSTKLOCATION")

            Case "NDVEHSTOCKASONPREVDATE"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Stock, frmReportFiltersForVehicle.ReportType.StockAsOnPrevDate, frmReportFiltersForVehicle.DetailSummary.No, "Stock As On", True, frmReportFiltersForVehicle.OptionType.Product)
                DisplayForm(frmDispForm, "NDVEHSTOCKASONPREVDATE")

                'frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Stock, frmReportFiltersForVehicle.ReportType.ClosingStockProduct, frmReportFiltersForVehicle.DetailSummary.Yes, "Closing Stock - Model Wise", True, frmReportFiltersForVehicle.OptionType.Product)
                'DisplayForm(frmDispForm, "NDCLOSINGVEHSTKMODEL")

            Case "NDNOSTOCKREPORT"
                'StockRegister = True
                'frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.NoStockReport, frmReportFilters.DetailSummary.No, "No Stock Report", False)
                'DisplayForm(frmDispForm, "NDNOSTOCKREPORT")
                Dim Formulas As New Hashtable

                Formulas.Add("GroupOn1#S", "P")
                Formulas.Add("GroupHeader#S", GetSystemCaption(SystemCaptionIdx.DefProduct))
                Formulas.Add("Header1#S", GetSystemCaption(SystemCaptionIdx.DefArticle))
                Formulas.Add("Header2#S", GetSystemCaption(SystemCaptionIdx.DefType))
                Formulas.Add("Header3#S", GetSystemCaption(SystemCaptionIdx.DefShade))
                Formulas.Add("Total1Text#S", GetSystemCaption(SystemCaptionIdx.DefProduct) & " Total")
                Formulas.Add("ViewSize#N", 0)
                Formulas.Add("DisplayRate#N", 0)
                Formulas.Add("DisplayValue#N", 0)
                Formulas.Add("ReportCaption#S", "No Stock Report")

                ReportParameters.rptFile = ReportPath & "\Reports\ClosingStkProd.rpt"
                ReportParameters.rptFilter = "{vw_ItemSizeStock.CoBr_Id} = '" & SelBranchId & "' And {vw_ItemSizeStock.ClQty} <= 0 "

                Dim frmRpt As New frmViewReports(Formulas)
                frmRpt.Show()

                Exit Sub

            Case "NDRPTBIRTHDAYLIST"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Others, frmReportFilters.ReportType.BirthdayList, frmReportFilters.DetailSummary.No, "Birthday List", False)
                DisplayForm(frmDispForm, "NDRPTBIRTHDAYLIST")

            Case "NDRPTANNIVLIST"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Others, frmReportFilters.ReportType.AnniversaryList, frmReportFilters.DetailSummary.No, "Anniversary List", False)
                DisplayForm(frmDispForm, "NDRPTANNIVLIST")

            Case "NDBARCODESTKSUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStockSubGroup, frmReportFilters.DetailSummary.No, "Barcode Stock - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup), True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDBARCODESTKSUBGROUP")

            Case "NDBARCODESTKPRODUCT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStockProduct, frmReportFilters.DetailSummary.No, "Barcode Stock - " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDBARCODESTKPRODUCT")

            Case "NDITEMWISECOMMISSIONRPT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Itemwisecommssion, frmReportFilters.DetailSummary.No, "Barcode Stock -" & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDITEMWISECOMMISSIONRPT")

            Case "NDBARCODESTKBRAND"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStockBrand, frmReportFilters.DetailSummary.No, "Barcode Stock - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & "", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDBARCODESTKBRAND")

            Case "NDBARCODESTKSUPPLIER"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStockSupplier, frmReportFilters.DetailSummary.No, "Barcode Stock - Supplier", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDBARCODESTKSUPPLIER")

            Case "NDBARCODESTKLOCATION"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStockLocation, frmReportFilters.DetailSummary.No, "Barcode Stock - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & "", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDBARCODESTKLOCATION")

            Case "NDCLOSINGVEHSTKLOCATION"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFiltersForVehicle(frmReportFiltersForVehicle.TransactionType.Stock, frmReportFiltersForVehicle.ReportType.ClosingStockLocation, frmReportFiltersForVehicle.DetailSummary.No, "Stock - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & "", True, frmReportFiltersForVehicle.OptionType.Location)
                DisplayForm(frmDispForm, "NDCLOSINGVEHSTKLOCATION")

                '___shishil 05122017

            Case "NDDAMAGESTKDATE"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.DamageStock, frmReportFilters.DetailSummary.No, "Damage Stock - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDDAMAGESTKDATE")
                '______________________


            Case "NDSTOCKATGLANCESUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAtAGlanceSubGroup, frmReportFilters.DetailSummary.No, "Stock At A Glance - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup), True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSTOCKATGLANCESUBGROUP")

            Case "NDSTOCKATGLANCEPRODUCT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAtAGlanceProduct, frmReportFilters.DetailSummary.No, "Stock At A Glance - " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSTOCKATGLANCEPRODUCT")

            Case "NDCLOSINGSTKPRODUCTWISEEXPIRY"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockProductWiseExpiry, frmReportFilters.DetailSummary.No, "Expiry Stock - Product Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDCLOSINGSTKPRODUCTWISEEXPIRY")

            Case "NDBARCODESTKPRODUCTWISEEXPIRY"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStkProductWiseExpiry, frmReportFilters.DetailSummary.No, "Expiry Stock - Barcode Wise ", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDBARCODESTKPRODUCTWISEEXPIRY")

            Case "NDSTOCKATGLANCEBRAND"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAtAGlanceBrand, frmReportFilters.DetailSummary.No, "Stock At A Glance - " & GetSystemCaption(SystemCaptionIdx.DefBrand), True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDSTOCKATGLANCEBRAND")

            Case "NDSTOCKATGLANCESUPPLIER"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAtAGlanceSupplier, frmReportFilters.DetailSummary.No, "Stock At A Glance - Supplier", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSTOCKATGLANCESUPPLIER")

            Case "NDSTOCKATGLANCELOCATION"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAtAGlanceLocation, frmReportFilters.DetailSummary.No, "Stock At A Glance - " & GetSystemCaption(SystemCaptionIdx.DefLocation), True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDSTOCKATGLANCELOCATION")
                'raju08032018
            Case "NDSTOCKATGLANCESIZETYPE"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAtAGlanceTypeWise, frmReportFilters.DetailSummary.No, "Stock At A Glance - TypeWise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDSTOCKATGLANCESIZETYPE")



            Case "NDSTKAGINGSUBGROUP"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAgingSubGroup, frmReportFilters.DetailSummary.No, "Stock Aging - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup), True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSTKAGINGSUBGROUP")

            Case "NDSTKAGINGPRODUCT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAgingProduct, frmReportFilters.DetailSummary.No, "Stock Aging - " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTKAGINGPRODUCT")

            Case "NDSTKAGINGBRAND"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAgingBrand, frmReportFilters.DetailSummary.No, "Stock Aging - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & "", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDSTKAGINGBRAND")

            Case "NDSTKAGINGSUPPLIER"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAgingSupplier, frmReportFilters.DetailSummary.No, "Stock Aging - Supplier", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSTKAGINGSUPPLIER")

            Case "NDSTKAGINGPRODUCTBARCODE"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAgingBarcode, frmReportFilters.DetailSummary.No, "Stock Aging - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & "/Barcode", True, frmReportFilters.OptionType.DefaultWise)
                DisplayForm(frmDispForm, "NDSTKAGINGPRODUCTBARCODE")


            Case "NDSTOCKCURRENT"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.CurrentStock, frmReportFilters.DetailSummary.No, "Closing Stock - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise")
                DisplayForm(frmDispForm, "NDSTOCKCURRENT")

            Case "NDSTOCKBRANDWISE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.CurrentStockBrandWise, frmReportFilters.DetailSummary.No, "Closing Stock - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise")
                DisplayForm(frmDispForm, "NDSTOCKBRANDWISE")

            Case "NDSTOCKWITHVALUEPRODUCTWISE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.CurrentStockWithValue, frmReportFilters.DetailSummary.No, "Closing Stock With Value")
                DisplayForm(frmDispForm, "NDSTOCKWITHVALUEPRODUCTWISE")

            Case "NDSTOCKBARCODEWISE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStock, frmReportFilters.DetailSummary.No, "Barcode Stock - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise")
                DisplayForm(frmDispForm, "NDSTOCKBARCODEWISE")

            Case "NDSTOCKBRANDBARCODEWISE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.BarcodeStockBrand, frmReportFilters.DetailSummary.No, "Barcode Stock - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise")
                DisplayForm(frmDispForm, "NDSTOCKBRANDBARCODEWISE")

            Case "NDSUPDOCSTK"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockSupplierWise, frmReportFilters.DetailSummary.No, "Closing Stock - Supplier Wise")
                DisplayForm(frmDispForm, "NDSTOCKSUPPLIERWISE")

            Case "NDSTOCKSTMT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockStatement, frmReportFilters.DetailSummary.Yes, "Stock Statement", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTOCKSTMT")

            Case "NDSTOCKASONPREVDATE"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAsOnPrevDate, frmReportFilters.DetailSummary.No, "Stock As On", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTOCKASONPREVDATE")

                '__shishil 12062017
            Case "NDSTOCKASONBRAND"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockAsOnBrand, frmReportFilters.DetailSummary.No, "Stock As On", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTOCKASONBRAND")

            Case "NDSTOCKUNSOLD"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockUnsold, frmReportFilters.DetailSummary.No, "Stock Unsold Report", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTOCKUNSOLD")

            Case "NDNOTYETSOLD"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockNotYetSold, frmReportFilters.DetailSummary.No, "Stock Not Yet Sold Report", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDNOTYETSOLD")

            Case "NDRPTSTOCKLEDGER"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockLedger, frmReportFilters.DetailSummary.Yes, "Stock Ledger", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTOCKLEDGER")


                ''
                '___shishil 28042017
            Case "NDSTOCKLEDGERLOCATION"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.StockLedgerLocationWise, frmReportFilters.DetailSummary.Yes, "Stock Ledger - Location Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTOCKLEDGERLOCATION")
                '''

                '''''SATYAM 11072023
            Case "NDDESIGNWISESTKWITHIMAGE"

                StockRegister = True
                ProductOptions = True

                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.DesignWiseStockWithImages, frmReportFilters.DetailSummary.No, "Design Wise Stock With Image", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDDESIGNWISESTKWITHIMAGE")

                'Suraj 26 12 2023
            Case "NDDRILLDOWNSTKRPT"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Ready_Stock_Multi, frmReportFilters.DetailSummary.Yes, "Stock Ledger", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDDRILLDOWNSTKRPT")

                ''
                '___shishil 12062017
            Case "NDSALESATAGLANCE"
                IsRegister = True
                DisplayRateValue = True
                ProdRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalesAtAGlanceLocationWise, frmReportFilters.DetailSummary.Yes, " Location Wise Sales At A Glance", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSALESATAGLANCE")
                '''
                'raju30082017start
            Case "NDGSTSUMMARIES"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GSTSummaries, frmReportFilters.DetailSummary.No, "GST Tax Summary", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDGSTSUMMARIES")
            Case "NDGSTR1"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GSTR1, frmReportFilters.DetailSummary.No, "GSTR1 Return", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDGSTR1")

                'raju30082017end

                'raju06102017
            Case "NDGSTR2"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GSTR2, frmReportFilters.DetailSummary.No, "GSTR2 Return", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDGSTR2")
                'rajuend

            Case "NDSALEPERSONCOMMISSION"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SalePersonCommission, frmReportFilters.DetailSummary.Yes, "Saleperson Commission", True, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDSALEPERSONCOMMISSION")

            Case "NDMOPANALYSIS"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.MOPAnalysis, frmReportFilters.DetailSummary.No, "MOP Analysis", False)
                DisplayForm(frmDispForm, "NDMOPANALYSIS")

            Case "NDALLINONESALES"
                IsRegister = True
                'WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.AllInOneSales, frmReportFilters.DetailSummary.No, "All-In-One Sales")
                DisplayForm(frmDispForm, "NDALLINONESALES")

            Case "NDDISCGIVENBILL"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.DiscountGiven_Bill, frmReportFilters.DetailSummary.No, "Discount Given - Bill", True)
                DisplayForm(frmDispForm, "NDDISCGIVENBILL")

            Case "NDDISCGIVENCUST"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.DiscountGiven_Customer, frmReportFilters.DetailSummary.No, "Discount Given - Customer", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDDISCGIVENCUSTOMER")

            Case "NDDISCGIVENPRODUCT"
                ProdRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.DiscountGiven_Product, frmReportFilters.DetailSummary.Yes, "Discount Given - " & GetSystemCaption(SystemCaptionIdx.DefProduct), True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDDISCGIVENPRODUCT")

            Case "NDHOURLYSALES"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.HourlySales, frmReportFilters.DetailSummary.No, "Hourly Sales", False)
                DisplayForm(frmDispForm, "NDHOURLYSALES")

            Case "NDPERIODICALSALES"
                ProdRegister = True
                ProductOptions = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.PeriodicalSales, frmReportFilters.DetailSummary.No, "Periodical Sales")
                DisplayForm(frmDispForm, "NDPERIODICALSALES")

            Case "NDMONTHLYSALES"
                ProdRegister = True
                WithMonthOption = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.MonthlySales, frmReportFilters.DetailSummary.No, "Monthly Sales", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYSALES")

            Case "NDMONTHLYSALESDATE"
                ProdRegister = True
                WithMonthOption = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.MonthlySalesDate, frmReportFilters.DetailSummary.No, "Monthly Sales - Date Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYSALESDATE")

            Case "NDMONTHLYSALESRTN"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.MonthlySalesRtn, frmReportFilters.DetailSummary.No, "Monthly Sales Return", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYSALESRTN")

            Case "NDMONTHLYSALESRTNDATE"
                ProdRegister = True
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.SalesRtn, frmReportFilters.ReportType.MonthlySalesRtnDate, frmReportFilters.DetailSummary.No, "Monthly Sales Return - Date Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDMONTHLYSALESRTNDATE")

            Case "NDSALESANALYSISBYTYPE"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.SaleByTypeAnalysis, frmReportFilters.DetailSummary.No, "Sales By Type", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSALESANALYSISBYTYPE")

            Case "NDMTHLYSALESSALEPERSON"
                WithMonthOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.MonthlySalesSaleperson, frmReportFilters.DetailSummary.No, "Monthly Sales Register - Saleperson Wise", False, frmReportFilters.OptionType.SalePerson)
                DisplayForm(frmDispForm, "NDMTHLYSALESSALEPERSON")

                'Stock Tracking Report

            Case "NDPHYSICALSTK"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Physical_Stock, frmReportFilters.DetailSummary.No, "Physical Stock", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPHYSICALSTK")

                'Nitin25012021
            Case "NDSTOCKADJUSTMENTREG"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Stock_Adjustment_Register, frmReportFilters.DetailSummary.No, "Stock Adjustment Register", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTOCKADJUSTMENTREG")

            Case "NDCNADJREG"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.CN_Adjustment_Register, frmReportFilters.DetailSummary.No, "CN Adjustment Register", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDCNADJREG")

            Case "NDCNBALREG"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.CN_Balance_Register, frmReportFilters.DetailSummary.No, "CN Balance Register", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDCNBALREG")

            Case "NDCNISU"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.CN_Issue_DateWise, frmReportFilters.DetailSummary.No, "CN Issue (Date Wise)", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDCNISU")

                'END

            Case "NDPHYSICALSTKSHORT"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Physical_StockShort, frmReportFilters.DetailSummary.No, "Physical Stock Short", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPHYSICALSTKSHORT")

            Case "NDPHYSICALSTKEXCESS"
                StockRegister = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Stock, frmReportFilters.ReportType.Physical_StockExcess, frmReportFilters.DetailSummary.No, "Physical Stock not in Books", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPHYSICALSTKEXCESS")

            Case "NDBARCODENOTINBOOK"

                ReportParameters.rptFile = ReportPath & "\Reports\BarcodeNotInBk.rpt"

                ReportParameters.rptFilter = "{StkTrack.CoBr_Id} = '" & SelBranchId & "' And {StkTrack.STATUS} = '0'"
                ReportParameters.rptCaption = "Barcode not in Books"

                Dim frmRpt As New frmViewReports
                frmRpt.Show()

                Exit Sub


                ''CRM report
            Case "NDCUSTOMERREPORT"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.CustomerReport, frmReportFilters.DetailSummary.No, "Customer Report", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDCUSTOMERREPORT")


            Case "NDGIFTVOUCHERRTP"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GifVoucher, frmReportFilters.DetailSummary.No, "Gift Voucher Report", False, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDGIFTVOUCHERRTP")


            Case "NDCUSTOMERSTMT"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.CustomerStmt, frmReportFilters.DetailSummary.No, "Customer Statement", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDCUSTOMERSTMT")

                'prabdeep
            Case "NDPENDSALESORDERREGBILL"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.PendPurOrderRegister_BillWise, frmReportFilters.DetailSummary.Yes, "SO Status Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDPENDSALESORDERREGBILL")

            Case "NDPENDSALESORDERREGDATE"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.PendPurOrderRegister_DateWise, frmReportFilters.DetailSummary.Yes, "SO Status Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDPENDSALESORDERREGDATE")

            Case "NDPENDSALESORDERREGPARTY"
                IsRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.PendPurOrderRegister_SupplierWise, frmReportFilters.DetailSummary.Yes, "SO Status Register - Supplier Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDPENDSALESORDERREGPARTY")

            Case "NDPENDSALESORDERREGSUBGROUP"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.PendPurOrderRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "SO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDPENDSALESORDERREGSUBGROUP")

            Case "NDPENDSALESORDERREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.PendPurOrderRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "SO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPENDSALESORDERREGPRODUCT")

            Case "NDPENDSALESORDERREGBRAND"
                ProdRegister = True
                WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.PendPurOrderRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "SO Status Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDPENDSALESORDERREGBRAND")

                'Stock Return From Franchise


            Case "NDSTKRTNFRMFRNCHBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnFrmFrnch, frmReportFilters.ReportType.StkRtnFrmFrnchRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Stock Retun From Franchise Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDSTKRTNFRMFRNCHBILL")

            Case "NDSTKRTNFRMFRNCHDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnFrmFrnch, frmReportFilters.ReportType.StkRtnFrmFrnchRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Stock Retun From Franchise Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSTKRTNFRMFRNCHDATE")

            Case "NDSTKRTNFRMFRNCHPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnFrmFrnch, frmReportFilters.ReportType.StkRtnFrmFrnchRegister_PartyWise, frmReportFilters.DetailSummary.Yes, "Stock Retun From Franchise Register - Party Wise", True, frmReportFilters.OptionType.Supplier)
                DisplayForm(frmDispForm, "NDSTKRTNFRMFRNCHPARTY")

            Case "NDSTKRTNFRMFRNCHPRODUCT"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnFrmFrnch, frmReportFilters.ReportType.StkRtnFrmFrnchRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Stock Retun From Franchise Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTKRTNFRMFRNCHPRODUCT")

            Case "NDSTKRTNFRMFRNCHBRAND"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnFrmFrnch, frmReportFilters.ReportType.StkRtnFrmFrnchRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Stock Retun From Franchise Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDSTKRTNFRMFRNCHBRAND")


            Case "NDSTKRTNFRMFRNCHPARTYPROD"
                ProdRegister = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnFrmFrnch, frmReportFilters.ReportType.StkRtnFrmFrnchRegister_PartyProdWise, frmReportFilters.DetailSummary.No, "Barcode Wise Stock Retun From Franchise", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTKRTNFRMFRNCHPARTYPROD")


                'Stock Inward From Head Office


            Case "NDSTKINWARDFRMHOBILL"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockInwardFrmHo, frmReportFilters.ReportType.StkInwardFrmHORegister_BillWise, frmReportFilters.DetailSummary.Yes, "Stock Inward from Head Office Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDSTKINWARDFRMHOBILL")

            Case "NDSTKINWARDFRMHODATE"
                IsRegister = True
                DisplayRateValue = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockInwardFrmHo, frmReportFilters.ReportType.StkInwardFrmHORegister_DateWise, frmReportFilters.DetailSummary.Yes, "Stock Inward From Head Office Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSTKINWARDFRMHODATE")


            Case "NDSTKINWARDFRMHOSUBGROUP"
                ProdRegister = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockInwardFrmHo, frmReportFilters.ReportType.StkInwardFrmHORegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Stock Inward From Head Office Register - " & GetSystemCaption(SystemCaptionIdx.DefSubGroup) & " Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDSTKINWARDFRMHOSUBGROUP")


            Case "NDSTKINWARDFRMHOPRODUCT"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockInwardFrmHo, frmReportFilters.ReportType.StkInwardFrmHORegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Stock Inward From Head Office Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTKINWARDFRMHOPRODUCT")

            Case "NDSTKINWARDFRMHOBRAND"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockInwardFrmHo, frmReportFilters.ReportType.StkInwardFrmHORegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Stock Inward From Head Office Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDSTKINWARDFRMHOBRAND")


            Case "NDSTKINWARDFRMHOPROBARCODE"
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockInwardFrmHo, frmReportFilters.ReportType.BarcodeWiseStkInwardFrmHO, frmReportFilters.DetailSummary.No, "Barcode Wise Stock Inward From Head Office", False, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTKINWARDFRMHOPROBARCODE")


                'Stock Return To Head Office
            Case "NDSTKRTNTOHOBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnToHO, frmReportFilters.ReportType.StkRtnToHoRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Stock Return To Head Office Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDSTKRTNTOHOBILL")

            Case "NDSTKRTNTOHODATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnToHO, frmReportFilters.ReportType.StkRtnToHoRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Stock Return To Head Office Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSTKRTNTOHODATE")

            Case "NDSTKRTNTOHOPRODUCT"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnToHO, frmReportFilters.ReportType.StkRtnToHoRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Stock Return To Head Office Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSTKRTNTOHOPRODUCT")

            Case "NDSTKRTNTOHOBRAND"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.StockRtnToHO, frmReportFilters.ReportType.StkRtnToHoRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Stock Return To Head Office Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDSTKRTNTOHOBRAND")


        End Select
        'WholeSale Bill
        Select Case ModName.ToUpper
            Case "NDWSREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDWSREGBILL")

            Case "NDWSREGDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDWSREGDATE")

            Case "NDWSSUBGROUPREGISTER"
                ProdRegister = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Sales Register - SubGroup Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDWSSUBGROUPREGISTER")

            Case "NDWSREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSRegister_PartyWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Party Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDWSREGPARTY")

            Case "NDWSPARTYPROD"
                ProdRegister = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSRegister_PartyProdWise, frmReportFilters.DetailSummary.Yes, "Sales Register - Party / " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDWSPARTYPROD")

            Case "NDWSREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDWSREGPRODUCT")

            Case "NDWSREGBRAND"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Sales  Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDWSREGBRAND")

            Case "NDPROFITABLILITYBILLWISEWH"
                WithRtnOption = True
                ProductOptions = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.ProfitabilityBillwiseWH, frmReportFilters.DetailSummary.Yes, "Profitability Bill Wise Report", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDPROFITABLILITYBILLWISEWH")

            Case "NDSALESREGLOCATIONWH"
                'IsRegister = True
                'DisplayRateValue = True
                ''WithRtnOption = True
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.SalesRegister_LocationWiseWH, frmReportFilters.DetailSummary.Yes, "Sales Register - " & GetSystemCaption(SystemCaptionIdx.DefLocation) & " Wise", True, frmReportFilters.OptionType.Location)
                DisplayForm(frmDispForm, "NDSALESREGLOCATIONWH")



            Case "NDWSALESTAXREGSUMMARY"
                'WithRtnOption = False
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSalesTaxRegister_Summary, frmReportFilters.DetailSummary.No, "VAT Tax Register", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDWSALESTAXREGSUMMARY")

                '__shishil 18082017
            Case "NDWSALESTAXREGSUMMARYGST"
                'WithRtnOption = False
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholeSale, frmReportFilters.ReportType.WSalesTaxRegister_SummaryGST, frmReportFilters.DetailSummary.No, "WholeSale GST Register", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDWSALESTAXREGSUMMARYGST")
                '_____



        End Select


        'WholeSale Return Bill
        Select Case ModName.ToUpper
            Case "NDWRREGBILL"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholseSaleRtn, frmReportFilters.ReportType.WRRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDWRREGBILL")

            Case "NDWRREGDATE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholseSaleRtn, frmReportFilters.ReportType.WRRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDWRREGDATE")

            Case "NDWRSUBGROUPREGISTER"
                ProdRegister = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholseSaleRtn, frmReportFilters.ReportType.WRRegister_SubGroupWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - SubGroup Wise", True, frmReportFilters.OptionType.SubGroup)
                DisplayForm(frmDispForm, "NDWRSUBGROUPREGISTER")

            Case "NDWRREGPARTY"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholseSaleRtn, frmReportFilters.ReportType.WRRegister_PartyWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - Party Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDWRREGPARTY")

            Case "NDWRPARTYPROD"
                ProdRegister = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholseSaleRtn, frmReportFilters.ReportType.WRRegister_PartyProdWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - Party / " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDWRPARTYPROD")

            Case "NDWRREGPRODUCT"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholseSaleRtn, frmReportFilters.ReportType.WRRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDWRREGPRODUCT")

            Case "NDWRREGBRAND"
                ProdRegister = True
                WithDetails = True
                SalesRegister = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.WholseSaleRtn, frmReportFilters.ReportType.WRRegister_BrandWise, frmReportFilters.DetailSummary.Yes, "Sales Return Register - " & GetSystemCaption(SystemCaptionIdx.DefBrand) & " Wise", True, frmReportFilters.OptionType.Brand)
                DisplayForm(frmDispForm, "NDWRREGBRAND")
        End Select

        '' Order Booking
        Select Case ModName.ToUpper
            Case "NDSALESORDERREGBILL"
                SalesRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.SaleOrderRegister_BillWise, frmReportFilters.DetailSummary.Yes, "Sales Order Register - Bill Wise", True, frmReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDSALESORDERREGBILL")

            Case "NDSALESORDERREGDATE"
                SalesRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.SaleOrderRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Sales Order Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSALESORDERREGDATE")

            Case "NDSALESORDERREGPARTY"
                SalesRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.OrderBooking, frmReportFilters.ReportType.SalesOrderRegister_CustomerWise, frmReportFilters.DetailSummary.Yes, "Sales Order Register - Customer Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDSALESORDERREGPARTY")

        End Select

        'Restaurant Reports '__SHISHIL 15112017
        Select Case ModName.ToUpper
            Case "NDRESTOORDDOCWISE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmRestoReportFilters(frmRestoReportFilters.TransactionType.RestaurantOrder, frmRestoReportFilters.ReportType.RestoOrderRegister_DocWise, frmRestoReportFilters.DetailSummary.Yes, "Restaurant Order Register - Doc Wise", True, frmRestoReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDRESTOORDDOCWISE")

            Case "NDRESTOORDPRODWISE"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmRestoReportFilters(frmRestoReportFilters.TransactionType.RestaurantOrder, frmRestoReportFilters.ReportType.RestoOrderRegister_ProdWise, frmRestoReportFilters.DetailSummary.Yes, "Restaurant Order Register - Item Wise", True, frmRestoReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRESTOORDPRODWISE")

            Case "NDRESTOKOTRPT"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmRestoReportFilters(frmRestoReportFilters.TransactionType.RestaurantKOT, frmRestoReportFilters.ReportType.RestoRegisterKOT, frmRestoReportFilters.DetailSummary.Yes, " Restaurant KOT Register ", True, frmRestoReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRESTOKOTRPT")


            Case "NDRESTOSALEDOCWISE"
                IsRegister = True
                DisplayRateValue = True
                frmDispForm = New frmRestoReportFilters(frmRestoReportFilters.TransactionType.RestaurantSales, frmRestoReportFilters.ReportType.RestoSalesRegister_DocWise, frmRestoReportFilters.DetailSummary.Yes, "Restaurant Sales Register - Doc Wise", True, frmRestoReportFilters.OptionType.Bill)
                DisplayForm(frmDispForm, "NDRESTOSALEDOCWISE")

            Case "NDRESTOSALEPRODWISE"
                ProdRegister = True
                WithDetails = True
                WithRtnOption = True
                frmDispForm = New frmRestoReportFilters(frmRestoReportFilters.TransactionType.RestaurantSales, frmRestoReportFilters.ReportType.RestoSalesRegister_ProdWise, frmRestoReportFilters.DetailSummary.Yes, "Restaurant Sales Register - Item Wise", True, frmRestoReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDRESTOSALEPRODWISE")

                '__RAJU 20022018
            Case "NDGSTTAXSUMMARYPAYMODEWISE"
                WithRtnOption = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.Sales, frmReportFilters.ReportType.GSTTaxSummaryPayModeWise, frmReportFilters.DetailSummary.Yes, "GST Tax Summary(Pay Mode Wise)", False, frmReportFilters.OptionType.Tax)
                DisplayForm(frmDispForm, "NDGSTTAXSUMMARYPAYMODEWISE")
                '_____

                '___shishil 20072018
            Case "NDSERVICEJOBREGISTERDATE"
                SalesRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.ServiceJob, frmReportFilters.ReportType.ServiceJoOrderRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Service Job Order Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSERVICEJOBREGISTERDATE")

            Case "NDSERVICEJOBREGISTERPARTY"
                SalesRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.ServiceJob, frmReportFilters.ReportType.ServiceJoOrderRegister_CustomerWise, frmReportFilters.DetailSummary.Yes, "Service Job  Order Register - Customer Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDSERVICEJOBREGISTERPARTY")

            Case "NDSERVICEJOBREGISTERPRODUCT"
                ProdRegister = True
                SalesRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.ServiceJob, frmReportFilters.ReportType.ServiceJoOrderRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Service Job  Order Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSERVICEJOBREGISTERPRODUCT")



                '___shishil 20072018
            Case "NDSERVICEJOBISUREGDATE"
                SalesRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.ServiceJob, frmReportFilters.ReportType.ServiceJoIsuOrderRegister_DateWise, frmReportFilters.DetailSummary.Yes, "Service Job Issue Register - Date Wise", True, frmReportFilters.OptionType.DateWise)
                DisplayForm(frmDispForm, "NDSERVICEJOBISUREGDATE")

            Case "NDSERVICEJOBISUREGJOBBER"
                SalesRegister = True
                DisplayRateValue = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.ServiceJob, frmReportFilters.ReportType.ServiceJoIsuOrderRegister_CustomerWise, frmReportFilters.DetailSummary.Yes, "Service Job Issue Register - Customer Wise", True, frmReportFilters.OptionType.Customer)
                DisplayForm(frmDispForm, "NDSERVICEJOBISUREGJOBBER")

            Case "NDSERVICEJOBISUREGPROD"
                ProdRegister = True
                SalesRegister = True
                'WithDetails = True
                frmDispForm = New frmReportFilters(frmReportFilters.TransactionType.ServiceJob, frmReportFilters.ReportType.ServiceJoIsuOrderRegister_ProductWise, frmReportFilters.DetailSummary.Yes, "Service Job Issue Register - " & GetSystemCaption(SystemCaptionIdx.DefProduct) & " Wise", True, frmReportFilters.OptionType.Product)
                DisplayForm(frmDispForm, "NDSERVICEJOBISUREGPROD")



        End Select

    End Sub


    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        CallReports(txtReport.TextValue.ToUpper)

        'If RptName = "" Then Exit Sub

        'Dim FromToDate As String = ""
        'Dim Series As String = ""

        'If GetSettingAsPerId(ApplnSettingsIdx.UserWiseSalesSummaryInBill) = 1 Then
        '    Series = " And {vw_SaleWithRtnSum.Bill_Sr} = 'A' And {vw_SaleWithRtnSum.Created_By} = " & UserId
        'Else
        '    Series = " And {vw_SaleWithRtnSum.Bill_Sr} = 'A'"
        'End If


        'Dim Formulas As New Hashtable

        'FromToDate = " And {vw_SaleWithRtnSum.Doc_Dt} >= Date(" & Format$(Common.GetDate(), "yyyy,MM,dd") & ") And {vw_SaleWithRtnSum.Doc_Dt} <= Date(" & Format$(Common.GetDate(), "yyyy,MM,dd") & ")" & Series
        'Formulas.Add("FromDate#S", Format$(Common.GetDate(), "dd/MM/yyyy"))

        'ReportParameters.rptFile = RptName 'ReportPath & "\Reports\" & RptName & ""
        'ReportParameters.rptFilter = "{vw_SaleWithRtnSum.CoBr_Id} = '" & SelBranchId & "' And {vw_SaleWithRtnSum.CTR_KEY} = '" & SelCounterId & "' " & FromToDate

        'Dim frmView As New frmViewReports(Formulas)
        'frmView.Show()
    End Sub

    Private Sub txtReport_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReport.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConfirm.Focus()
        End If
    End Sub
End Class