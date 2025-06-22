Imports System.Data.SqlClient

Public Class frmRenumbering

    Enum VchrType
        Contra
        Journal
        Payment
        Receipt
        CreditNote
        DebitNote
    End Enum


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmRenumbering_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmRenumbering_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With cmbTransaction.Items
            .Add("Purchase Order")  '0
            .Add("Purchase")        '1
            .Add("Purchase Return") '2
            .Add("Sales")           '3
            .Add("Sales Return")    '4
            .Add("Contra")          '5
            .Add("Journal")         '6
            .Add("Payment")         '7
            .Add("Receipt")         '8
            .Add("Debit Note")      '9
            .Add("Credit Note")     '10
        End With

        cmbTransaction.SelectedIndex = 0
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If MsgBox("Continue renumbering ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            If cmbTransaction.SelectedIndex = 0 Then    ''Pur Order
                RenumberPurchaseOrder()
            ElseIf cmbTransaction.SelectedIndex = 1 Then    ''Purchase
                RenumberPurchase()
            ElseIf cmbTransaction.SelectedIndex = 2 Then    ''Purchase Rtn
                RenumberPurReturn()
            ElseIf cmbTransaction.SelectedIndex = 3 Then    ''Sales
                RenumberSales()
            ElseIf cmbTransaction.SelectedIndex = 4 Then    ''Sales Rtn
                RenumberSalesReturn()
            ElseIf cmbTransaction.SelectedIndex = 5 Then    ''Contra
                RenumberVoucher(VchrType.Contra)
            ElseIf cmbTransaction.SelectedIndex = 6 Then    ''Journal
                RenumberVoucher(VchrType.Journal)
            ElseIf cmbTransaction.SelectedIndex = 7 Then    ''Payment
                RenumberVoucher(VchrType.Payment)
            ElseIf cmbTransaction.SelectedIndex = 8 Then    ''Receipt
                RenumberVoucher(VchrType.Receipt)
            ElseIf cmbTransaction.SelectedIndex = 9 Then    ''Debit Note
                RenumberVoucher(VchrType.DebitNote)
            ElseIf cmbTransaction.SelectedIndex = 10 Then    ''Credit Note
                RenumberVoucher(VchrType.CreditNote)
            End If

            MsgBox("Document renumbering completed successfully", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub RenumberPurchaseOrder()
        Dim Trans As SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            Query = "Select Doc_Id, Bill_Sr, Doc_Sr, Doc_Dt From PurOrder " _
                & " Where Doc_Id > 0 " _
                & " Order By Doc_Id"
            Dim PurOrder As DataTable = Common.GetDataTable(Query, Trans)
            Dim RecRow As DataRow
            Dim Series As String = ""
            Dim SysSeries As String = ""
            Dim NewNum As String = ""
            Dim DocNoFormat As String = ""
            Dim DocKey As String = ""
            Dim KeyFlag As String = ""

            Query = "Alter Table PurOrder NoCheck Constraint Uq_PurOrder_CoBr_Id_FcYr_Id_Doc_No"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update PurOrder Set Doc_No = ''"
            Common.ExecuteQuery(Query, Trans)

            For Each RecRow In PurOrder.Rows
                If GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "F" Then ''Fin Year
                    KeyFlag = "13"
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "M" Then ''Monthly
                    KeyFlag = Format$(Month(RecRow("Doc_Dt")), "00")
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "C" Then ''Continuous
                    KeyFlag = "00"
                End If

                SysSeries = " And Bill_Sr = '" & (RecRow("Bill_Sr") & "") & "'"
                Series = RecRow("Doc_Sr")
                DocNoFormat = GetDocNoFormat(GetSettingAsPerId(ApplnSettingsIdx.PurDocStartNo), Val(GetSettingAsPerId(ApplnSettingsIdx.PurDigit)))
                NewNum = TranNewDocNo(GetSettingAsPerId(ApplnSettingsIdx.PurNumberSystem), Series, "PurOrder", "Doc_No", "", DocNoFormat, SysSeries, GetSettingAsPerId(ApplnSettingsIdx.PurDocStartNo), , Trans)
                DocKey = SelYearId & SelBranchId & KeyFlag & Series & NewNum


                Query = "Update PurOrder Set Old_Doc_No = Doc_Number " _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)

                Query = "Update PurOrder Set Doc_No = '" & Series & NewNum & "', Doc_Key = '" & DocKey & "', Doc_Number = '" & NewNum & "'" _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)
            Next RecRow
            PurOrder = Nothing

            Query = "Alter Table PurOrder Check Constraint Uq_PurOrder_CoBr_Id_FcYr_Id_Doc_No"
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

    Private Sub RenumberPurchase()
        Dim Trans As SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            Query = "Select Doc_Id, Bill_Sr, Doc_Sr, Doc_Dt From Purchase " _
                & " Where Doc_Id > 0 " _
                & " Order By Doc_Id"
            Dim Purchase As DataTable = Common.GetDataTable(Query, Trans)
            Dim RecRow As DataRow
            Dim Series As String = ""
            Dim SysSeries As String = ""
            Dim NewNum As String = ""
            Dim DocNoFormat As String = ""
            Dim DocKey As String = ""
            Dim KeyFlag As String = ""

            Query = "Alter Table Purchase NoCheck Constraint Uq_Purchase_Doc_Key"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update Purchase Set Doc_No = ''"
            Common.ExecuteQuery(Query, Trans)

            For Each RecRow In Purchase.Rows
                If GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "F" Then ''Fin Year
                    KeyFlag = "13"
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "M" Then ''Monthly
                    KeyFlag = Format$(Month(RecRow("Doc_Dt")), "00")
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "C" Then ''Continuous
                    KeyFlag = "00"
                End If

                SysSeries = " And Bill_Sr = '" & (RecRow("Bill_Sr") & "") & "'"
                Series = RecRow("Doc_Sr")
                DocNoFormat = GetDocNoFormat(GetSettingAsPerId(ApplnSettingsIdx.PurDocStartNo), Val(GetSettingAsPerId(ApplnSettingsIdx.PurDigit)))
                NewNum = TranNewDocNo(GetSettingAsPerId(ApplnSettingsIdx.PurNumberSystem), Series, "Purchase", "Doc_No", "", DocNoFormat, SysSeries, GetSettingAsPerId(ApplnSettingsIdx.PurDocStartNo), , Trans)
                DocKey = SelYearId & SelBranchId & KeyFlag & Series & NewNum

                Query = "Update Purchase Set Old_Doc_No = Doc_Number " _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)

                Query = "Update Purchase Set Doc_No = '" & Series & NewNum & "', Doc_Key = '" & DocKey & "', Doc_Number = '" & NewNum & "'" _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)
            Next RecRow
            Purchase = Nothing

            Query = "Alter Table Purchase Check Constraint Uq_Purchase_Doc_Key"
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

    Private Sub RenumberPurReturn()
        Dim Trans As SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            Query = "Select Doc_Id, Bill_Sr, Doc_Sr, Doc_Dt From PurchaseRtn " _
                & " Where Doc_Id > 0 " _
                & " Order By Doc_Id"
            Dim Purchase As DataTable = Common.GetDataTable(Query, Trans)
            Dim RecRow As DataRow
            Dim Series As String = ""
            Dim SysSeries As String = ""
            Dim NewNum As String = ""
            Dim DocNoFormat As String = ""
            Dim DocKey As String = ""
            Dim KeyFlag As String = ""

            Query = "Alter Table PurchaseRtn NoCheck Constraint Uq_PurchaseRtn_CoBr_Id_FcYr_Id_Doc_No"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update PurchaseRtn Set Doc_No = ''"
            Common.ExecuteQuery(Query, Trans)

            For Each RecRow In Purchase.Rows
                If GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "F" Then ''Fin Year
                    KeyFlag = "13"
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "M" Then ''Monthly
                    KeyFlag = Format$(Month(RecRow("Doc_Dt")), "00")
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "C" Then ''Continuous
                    KeyFlag = "00"
                End If

                SysSeries = " And Bill_Sr = '" & (RecRow("Bill_Sr") & "") & "'"
                Series = RecRow("Doc_Sr")
                DocNoFormat = GetDocNoFormat(GetSettingAsPerId(ApplnSettingsIdx.PurRtnDocStartNo), Val(GetSettingAsPerId(ApplnSettingsIdx.PurRtnDigit)))
                NewNum = TranNewDocNo(GetSettingAsPerId(ApplnSettingsIdx.PurRtnNumberSystem), Series, "PurchaseRtn", "Doc_No", "", DocNoFormat, SysSeries, GetSettingAsPerId(ApplnSettingsIdx.PurRtnDocStartNo), , Trans)
                DocKey = SelYearId & SelBranchId & KeyFlag & Series & NewNum

                Query = "Update PurchaseRtn Set Old_Doc_No = Doc_Number " _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)

                Query = "Update PurchaseRtn Set Doc_No = '" & Series & NewNum & "', Doc_Key = '" & DocKey & "', Doc_Number = '" & NewNum & "'" _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)
            Next RecRow
            Purchase = Nothing

            Query = "Alter Table PurchaseRtn Check Constraint Uq_PurchaseRtn_CoBr_Id_FcYr_Id_Doc_No"
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

    Private Sub RenumberSales()
        Dim Trans As SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            Query = "Select Doc_Id, Bill_Sr, Doc_Sr, Doc_Dt From Bill " _
                & " Where Doc_Id > 0 And Doc_Type = 'SI'" _
                & " Order By Doc_Id"
            Dim Sales As DataTable = Common.GetDataTable(Query, Trans)
            Dim RecRow As DataRow
            Dim Series As String = ""
            Dim SysSeries As String = ""
            Dim NewNum As String = ""
            Dim DocNoFormat As String = ""
            Dim DocKey As String = ""
            Dim KeyFlag As String = ""

            Query = "Alter Table Bill NoCheck Constraint Uq_Bill_Doc_Key"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update Bill Set Old_Doc_No = Doc_No Where Doc_Type = 'SI'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update Bill Set Doc_No = '' Where Doc_Type = 'SI'"
            Common.ExecuteQuery(Query, Trans)

            For Each RecRow In Sales.Rows
                If GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "F" Then ''Fin Year
                    KeyFlag = "13"
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "M" Then ''Monthly
                    KeyFlag = Format$(Month(RecRow("Doc_Dt")), "00")
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "C" Then ''Continuous
                    KeyFlag = "00"
                End If

                SysSeries = " And Bill_Sr = '" & (RecRow("Bill_Sr") & "") & "'"
                Series = RecRow("Doc_Sr")

                DocNoFormat = GetDocNoFormat(GetSettingAsPerId(ApplnSettingsIdx.SalesDocStartNo), Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDigit)))
                NewNum = BillDocNo(GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem), Series, "Bill", "Doc_No", "", DocNoFormat, SysSeries, GetSettingAsPerId(ApplnSettingsIdx.SalesDocStartNo), "SI", Trans)
                DocKey = SelYearId & SelBranchId & KeyFlag & Series & NewNum

                Query = "Update Bill Set PDoc_No = '" & Series & NewNum & "', Doc_Key = '" & DocKey & "', Doc_No = '" & NewNum & "'" _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)
            Next RecRow
            Sales = Nothing

            Query = "Alter Table Bill Check Constraint Uq_Bill_Doc_Key"
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

    Private Sub RenumberSalesReturn()
        Dim Trans As SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            Query = "Select Doc_Id, Bill_Sr, Doc_Sr, Doc_Dt From Bill " _
                & " Where Doc_Id > 0 And Doc_Type = 'SR'" _
                & " Order By Doc_Id"
            Dim Sales As DataTable = Common.GetDataTable(Query, Trans)
            Dim RecRow As DataRow
            Dim Series As String = ""
            Dim SysSeries As String = ""
            Dim NewNum As String = ""
            Dim DocNoFormat As String = ""
            Dim DocKey As String = ""
            Dim KeyFlag As String = ""

            Query = "Alter Table Bill NoCheck Constraint Uq_Bill_Doc_Key"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update Bill Set Old_Doc_No = Doc_No Where Doc_Type = 'SR'"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update Bill Set Doc_No = '' Where Doc_Type = 'SR'"
            Common.ExecuteQuery(Query, Trans)

            For Each RecRow In Sales.Rows
                If GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "F" Then ''Fin Year
                    KeyFlag = "13"
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "M" Then ''Monthly
                    KeyFlag = Format$(Month(RecRow("Doc_Dt")), "00")
                ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem) = "C" Then ''Continuous
                    KeyFlag = "00"
                End If

                SysSeries = " And Bill_Sr = '" & (RecRow("Bill_Sr") & "") & "'"
                Series = RecRow("Doc_Sr")
                DocNoFormat = GetDocNoFormat(GetSettingAsPerId(ApplnSettingsIdx.SalesDocStartNo), Val(GetSettingAsPerId(ApplnSettingsIdx.SalesDigit)))
                NewNum = BillDocNo(GetSettingAsPerId(ApplnSettingsIdx.SalesNumberSystem), Series, "Bill", "Doc_No", "", DocNoFormat, SysSeries, GetSettingAsPerId(ApplnSettingsIdx.SalesDocStartNo), "SR", Trans)
                DocKey = SelYearId & SelBranchId & KeyFlag & Series & NewNum

                Query = "Update Bill Set PDoc_No = '" & Series & NewNum & "', Doc_Key = '" & DocKey & "', Doc_No = '" & NewNum & "'" _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)
            Next RecRow
            Sales = Nothing

            Query = "Alter Table Bill Check Constraint Uq_Bill_Doc_Key"
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

    Private Sub RenumberVoucher(ByVal Type As VchrType)
        Dim Trans As SqlTransaction = Nothing
        Dim TypeFltr As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            If Type = VchrType.Contra Then
                TypeFltr = " Where VchrType = 'CT'"

            ElseIf Type = VchrType.Journal Then
                TypeFltr = " Where VchrType = 'JV'"

            ElseIf Type = VchrType.Payment Then
                TypeFltr = " Where VchrType = 'PY'"

            ElseIf Type = VchrType.Receipt Then
                TypeFltr = " Where VchrType = 'RC'"

            ElseIf Type = VchrType.DebitNote Then
                TypeFltr = " Where VchrType = 'DN'"

            ElseIf Type = VchrType.CreditNote Then
                TypeFltr = " Where VchrType = 'CN'"
            End If

            Query = "Select Doc_Id, Doc_Sr From Vchr " _
                & TypeFltr & " And Doc_Id > 0 " _
                & " Order By Doc_Id"
            Dim Voucher As DataTable = Common.GetDataTable(Query, Trans)
            Dim RecRow As DataRow
            Dim Series As String = ""
            Dim NewNum As String = ""
            Dim DocKey As String = ""
            Dim KeyFlag As String = ""

            Query = "Alter Table Vchr NoCheck Constraint Uq_Vchr_Doc_Key"
            Common.ExecuteQuery(Query, Trans)

            Query = "Update Vchr Set OldVchrNo = Doc_No" _
                & TypeFltr
            Common.ExecuteQuery(Query, Trans)

            Query = "Update Vchr Set Doc_No = ''" _
                & TypeFltr
            Common.ExecuteQuery(Query, Trans)

            For Each RecRow In Voucher.Rows
                Series = RecRow("Doc_Sr")
                NewNum = VoucherDocNo(Series, "VCHR", "DOC_NO", 1, 2, "", "00000", Trans)
                DocKey = SelYearId & SelBranchId & Series & NewNum

                Query = "Update Vchr Set PDoc_No = '" & Series & NewNum & "', Doc_Key = '" & DocKey & "', Doc_No = '" & NewNum & "'" _
                    & " Where Doc_Id = " & RecRow("Doc_Id")
                Common.ExecuteQuery(Query, Trans)
            Next RecRow
            Voucher = Nothing

            Query = "Alter Table Vchr Check Constraint Uq_Vchr_Doc_Key"
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

    Private Function VoucherDocNo(ByVal strSeries As String, ByVal strTable As String, ByVal strField As String, ByVal bytNumStartPos As Byte, ByVal bytSeriesLen As Byte, ByRef strLastKey As String, Optional ByVal strFormat As String = "00000", Optional ByVal sqlTrans As SqlTransaction = Nothing) As String
        Dim strNewCode As String = ""
        Dim strSrch As String = ""
        Dim DtTemp As DataTable
        Dim Check As Boolean = False
        Dim strLastCode As String = ""


        strSrch = " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID ='" & SelYearId & "' "

        If strSeries.Trim.Length <> 0 Then
            Query = "SELECT DOC_KEY FROM " & strTable & " WHERE DOC_SR= '" & strSeries & "'" _
                & " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID ='" & SelYearId & "'"
            DtTemp = Common.GetDataTable(Query, sqlTrans)

            If DtTemp.Rows.Count = 0 Then
                Check = True
                strLastCode = GetSettingAsPerId(ApplnSettingsIdx.SalesDocStartNo)
            Else
                Query = "SELECT ISNULL(MAX(SUBSTRING(" & strField & "," & bytNumStartPos & ",LEN(" & strField & "))),0) MAX_ID " _
                    & " FROM " & strTable & " WHERE DOC_SR= '" & strSeries & "'" _
                    & strSrch
                strLastCode = Common.ExecuteScalar(Query, sqlTrans)
            End If
        End If

        If Not Check Then
            strNewCode = Format$(Val(strLastCode) + 1, strFormat)
        Else
            strNewCode = Format$(Val(strLastCode), strFormat)
        End If

        If Val(strLastCode) <> 0 Then
            strLastCode = IIf(Check = False, Format$(Val(strLastCode), strFormat), 0)
        Else
            strLastCode = ""
        End If

        Return strNewCode
    End Function

    Private Function BillDocNo(ByVal NumberSystem As String, ByVal Series As String, ByVal Table As String, ByVal Field As String, ByRef LastKey As String, ByVal NumFormat As String, ByVal SysSeries As String, ByVal DocStartNo As String, ByVal DocType As String, Optional ByVal sqlTrans As SqlTransaction = Nothing) As String
        Dim NewCode As String = ""
        Dim Filter As String = ""
        Dim Check As Boolean
        Dim NumStartPos As Byte = 1
        Dim strLastCode As String = ""
        Dim DocRec As Integer

        If Series.Trim.Length > 0 Then NumStartPos = 3

        If DocType = "SI" Then
            If GetSettingAsPerId(ApplnSettingsIdx.SalesCounterWiseSeries) = "0" Then
                If NumberSystem = "F" Then ''Fin Year
                    Filter = " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID = '" & SelYearId & "'" & SysSeries
                ElseIf NumberSystem = "M" Then ''Monthly
                    Filter = " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID = '" & SelYearId & "' AND MONTH(DOC_DT) = '" & Now.Date.Month & "'" & SysSeries
                ElseIf NumberSystem = "C" Then ''Continuous
                    Filter = " AND COBR_ID = '" & SelBranchId & "'" & SysSeries
                End If
            ElseIf GetSettingAsPerId(ApplnSettingsIdx.SalesCounterWiseSeries) = "1" Then
                If NumberSystem = "F" Then ''Fin Year
                    Filter = " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID = '" & SelYearId & "' AND CTR_KEY ='" & SelCounterId & "'" & SysSeries
                ElseIf NumberSystem = "M" Then ''Monthly
                    Filter = " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID = '" & SelYearId & "' AND CTR_KEY ='" & SelCounterId & "' AND MONTH(DOC_DT) = '" & Now.Date.Month & "'" & SysSeries
                ElseIf NumberSystem = "C" Then ''Continuous
                    Filter = " AND COBR_ID = '" & SelBranchId & "' AND CTR_KEY ='" & SelCounterId & "'" & SysSeries
                End If
            End If

        ElseIf DocType = "SR" Then
            If NumberSystem = "F" Then ''Fin Year
                Filter = " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID = '" & SelYearId & "'" & SysSeries
            ElseIf NumberSystem = "M" Then ''Monthly
                Filter = " AND COBR_ID = '" & SelBranchId & "' AND FCYR_ID = '" & SelYearId & "' AND MONTH(DOC_DT) = '" & Now.Date.Month & "'" & SysSeries
            ElseIf NumberSystem = "C" Then ''Continuous
                Filter = " AND COBR_ID = '" & SelBranchId & "'" & SysSeries
            End If
        End If

        Dim DocFltr As String = " And Bill.Doc_Type ='" & DocType & "'"

        Query = "SELECT IsNull(Count(*), 0) FROM " & Table _
            & " WHERE DOC_SR = '" & Series & "'" & Filter & DocFltr
        DocRec = CType(Common.ExecuteScalar(Query, sqlTrans), Integer)

        If DocRec = 0 Then
            Check = True
            strLastCode = DocStartNo
        Else
            Query = "SELECT IsNull(Max(DOC_NO), 0) MAX_ID " _
                & " FROM " & Table & " WHERE DOC_SR= '" & Series & "'" _
                & Filter & DocFltr
            strLastCode = Common.ExecuteScalar(Query, sqlTrans)
        End If

        If NumFormat.Trim.Length = 0 Then
            If Not Check Then
                NewCode = CStr(Val(strLastCode) + 1)
            Else
                NewCode = strLastCode
            End If
        Else
            If Not Check Then
                NewCode = Format$(Val(strLastCode) + 1, NumFormat)
            Else
                NewCode = Format$(Val(strLastCode), NumFormat)
            End If
        End If

        Return NewCode
    End Function
End Class