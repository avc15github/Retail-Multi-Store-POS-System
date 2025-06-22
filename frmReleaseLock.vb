Public Class frmReleaseLock

    Private Sub frmReleaseLock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmChangeLockStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With lstTables.Items
            .Add("Purchase Order")
            .Add("Purchase")
            .Add("Purchase Return")
            .Add("Sales")
            .Add("Sales Return")
            '.Add("Issued To Jobber")
            '.Add("Received From Jobber")
            If TypeOfEdition <> Edition.Basic Then
                .Add("Stock Transfer")
            End If

            If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMaintainAccounts))) Then
                .Add("Voucher")
            End If
            .Add("Opening Stock")

            .Add("Order Booking")
            .Add("Order Send To Vendor")
            .Add("Delivery Note")
            .Add("Stock Transfer To Franchisee")
            .Add("Sales Invoice")
            .Add("Sales Return")
            '____shishil_____-
            .Add("Goods On Approval")
            .Add("Approval Return")

            .Add("Vehicle PO")
            .Add("Vehicle Purchase")
            .Add("Vehicle Booking")
            .Add("Enquiry")
            .Add("Vehicle Sale")
            .Add("Vehicle Return")
            .Add("Service Job Card")
            .Add("Job Issue")
            .Add("Job Receipt")
            .Add("Treatment Entry")
            .Add("Jobber Work")
            .Add("Alteration Work")  '____teju 20-02-2018
            .Add("Transfer Of Matterial") ' ________teju 21-05-2018
        End With
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If chkLstRecordId.CheckedItems.Count = 0 Then Exit Sub

        If MsgBox("Release locked records for selected transaction ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Dim obj As Object

        If chkLstRecordId.GetItemChecked(0) Then
            If lstTables.Items(lstTables.SelectedIndex) = "Purchase Order" Then
                Query = "Update PurOrder Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Purchase" Then
                Query = "Update Purchase Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Purchase Return" Then
                Query = "Update PurchaseRtn Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales" Then
                Query = "Update Bill Set Edit_Status = '' Where Doc_Type='SI' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Return" Then
                Query = "Update Bill Set Edit_Status = '' Where Doc_Type='SR' "

                '_____shishil___

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Goods On Approval" Then
                Query = "Update Bill Set Edit_Status = '' Where Doc_Type='GA' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Approval Return" Then
                Query = "Update Bill Set Edit_Status = '' Where Doc_Type='AR' "


            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Issued To Jobber" Then
                Query = "Update JobIsu Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Received From Jobber" Then
                Query = "Update JobRcpt Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Stock Transfer" Then
                Query = "Update StockTfr Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Voucher" Then
                Query = "Update Vchr Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Opening Stock" Then
                Query = "Update Purchase Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Order Booking" Then
                Query = "Update SalesOrder Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Order Send To Vendor" Then
                Query = "Update SOV Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Delivery Note" Then
                Query = "Update SOVDlv Set Edit_Status = '' "


            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Stock Transfer To Franchisee" Then
                Query = "Update Packing Set Edit_Status = ''"


            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Invoice" Then
                Query = "Update Packing Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Return" Then
                Query = "Update Packing Set Edit_Status = ''"

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle PO" Then
                Query = "Update VehiclePO Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Purchase" Then
                Query = "Update VehiclePurchase Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Booking" Then
                Query = "Update VehicleBill Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Enquiry" Then
                Query = "Update PartyEnquiry Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Sale" Then
                Query = "Update VehicleSale Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Return" Then
                Query = "Update VehicleRtn Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Service Job Card" Then
                Query = "Update ServiceJobCard Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Job Issue" Then
                Query = "Update JobIsu Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Job Receipt" Then
                Query = "Update JobRcpt Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Treatment Entry" Then
                Query = "Update Partyjob Set Edit_Status = '' "

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Jobber Work" Then
                Query = "Update JobberWork Set Edit_Status = '' "

                '_teju 

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Alteration Work" Then
                Query = "Update jobisu Set Edit_Status = '' "

                '__________teju

            ElseIf lstTables.Items(lstTables.SelectedIndex) = "Transfer Of Matterial" Then
                Query = "Update PRDSET  Set Edit_Status = '' "
            End If

            Common.ExecuteQuery(Query)
        Else
            For Each obj In chkLstRecordId.CheckedItems
                If lstTables.Items(lstTables.SelectedIndex) = "Purchase Order" Then
                    Query = "Update PurOrder Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Purchase" Then
                    Query = "Update Purchase Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Purchase Return" Then
                    Query = "Update PurchaseRtn Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales" Then
                    Query = "Update Bill Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Return" Then
                    Query = "Update Bill Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                    '___shishil____---

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Goods On Approval" Then
                    Query = "Update Bill Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Approval Return" Then
                    Query = "Update Bill Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"


                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Issued To Jobber" Then
                    Query = "Update JobIsu Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Received From Jobber" Then
                    Query = "Update JobRcpt Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Stock Transfer" Then
                    Query = "Update StockTfr Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Voucher" Then
                    Query = "Update Vchr Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Opening Stock" Then
                    Query = "Update Purchase Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' And Opening = '1'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Order Booking" Then
                    Query = "Update SalesOrder Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Order Send To Vendor" Then
                    Query = "Update SOV Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Delivery Note" Then
                    Query = "Update SODlv Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Stock Transfer To Franchisee" Then
                    Query = "Update Packing Set Edit_Status = '' " _
                       & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Invoice" Then
                    Query = "Update Packing Set Edit_Status = '' " _
                    & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Return" Then
                    Query = "Update Packing Set Edit_Status = '' " _
                      & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "'"


                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle PO" Then
                    Query = "Update VehiclePo Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Purchase" Then
                    Query = "Update VehiclePurchase Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Booking" Then
                    Query = "Update VehicleBill Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Enquiry" Then
                    Query = "Update PartyEnquiry Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Sale" Then
                    Query = "Update PartyEnquiry Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Return" Then
                    Query = "Update Vehiclertn Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Service Job Card" Then
                    Query = "Update ServiceJobCard Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Job Issue" Then
                    Query = "Update JobIsu Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Job Receipt" Then
                    Query = "Update JobRcpt Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Treatment Entry" Then
                    Query = "Update Partyjob Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Jobber Work" Then
                    Query = "Update JobberWork Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "
                    '__________teju
                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Alteration Work" Then
                    Query = "Update jobisu Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                    '___________teju
                ElseIf lstTables.Items(lstTables.SelectedIndex) = "Transfer Of Matterial" Then
                    Query = "Update PRDSET  Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' "

                End If

                Common.ExecuteQuery(Query)
            Next obj
        End If

        lstTables_DoubleClick(lstTables, Nothing)
    End Sub

    Private Sub lstTables_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTables.DoubleClick
        If lstTables.Items(lstTables.SelectedIndex) = "Purchase Order" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From PurOrder With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Purchase" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From Purchase With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Purchase Return" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From PurchaseRtn With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO  " _
                & " Union All " _
                & " Select DOC_KEY, PDOC_NO DOC_NO " _
                & " From Bill With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' And Doc_Type='SI' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By DOC_NO"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Return" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, PDOC_NO DOC_NO " _
                & " From Bill With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' And Doc_Type='SR' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By DOC_NO"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Goods On Approval" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, PDOC_NO DOC_NO " _
                & " From Bill With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' And Doc_Type='GA' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By DOC_NO"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Approval Return" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, PDOC_NO DOC_NO " _
                & " From Bill With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' And Doc_Type='AR' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By DOC_NO"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Issued To Jobber" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From JobIsu With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Received From Jobber" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From JobRcpt With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Stock Transfer" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From StockTfr With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Voucher" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_SR + DOC_NO DOC_NO " _
                & " From Vchr With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Opening Stock" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From Purchase With(NoLock) " _
                & " Where Edit_Status = '1' And Opening = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Order Booking" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From SalesOrder With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Order Send To Vendor" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From SOV With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Delivery Note" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From SODlv With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Stock Transfer To Franchisee" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
               & " Union All " _
               & " Select DOC_KEY, DOC_NO " _
               & " From Packing With(NoLock) " _
               & " Where Edit_Status = '1' " _
               & " And Doc_Key <> '' " _
               & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
               & " Order By Doc_No"


        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Invoice" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
               & " Union All " _
               & " Select DOC_KEY, DOC_NO " _
               & " From Packing With(NoLock) " _
               & " Where Edit_Status = '1' " _
               & " And Doc_Key <> '' " _
               & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
               & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Return" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
              & " Union All " _
              & " Select DOC_KEY, DOC_NO " _
              & " From Packing With(NoLock) " _
              & " Where Edit_Status = '1' " _
              & " And Doc_Key <> '' " _
              & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
              & " Order By Doc_No"


        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle PO" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From VehiclePo   With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"


        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Purchase" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From VehiclePurchase  With(NoLock)  " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Booking" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From VehicleBill  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Enquiry" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From PartyEnquiry  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Sale" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From VehicleSale  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Vehicle Return" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From VehicleRtn  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Service Job Card" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From ServiceJobCard  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Job Issue" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From JobIsu  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Job Receipt" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From JobRcpt  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"




        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Treatment Entry" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From Partyjob  With(NoLock)  " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"



        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Jobber Work" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From JobberWork  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"

            '_________Teju 20022018
        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Alteration Work" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                & " Union All " _
                & " Select DOC_KEY, DOC_NO " _
                & " From jobisu  With(NoLock) " _
                & " Where Edit_Status = '1' " _
                & " And Doc_Key <> '' " _
                & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                & " Order By Doc_No"
            '________teju
        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Transfer Of Matterial" Then
            Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
                           & " Union All " _
                           & " Select DOC_KEY, DOC_NO " _
                           & " From PRDSET  With(NoLock) " _
                           & " Where Edit_Status = '1' " _
                           & " And Doc_Key <> '' " _
                           & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
                           & " Order By Doc_No"

        End If

        Common.FillInListBox(Query, chkLstRecordId, "DOC_NO", "DOC_KEY")

        Dim i As Short

        For i = 0 To chkLstRecordId.Items.Count - 1
            chkLstRecordId.SetItemChecked(i, False)
        Next
    End Sub
End Class