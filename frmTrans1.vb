Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Imports System.Drawing

Public Class frmTrans1

    Private Sub frmTrans1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'grpOpen.Visible = True
        'dtpFrom.Value = Now.Date
        'dtpTo.Value = Now.Date
        dtpFrom.Focus()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'If MsgBox("Update GST  ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        'If MsgBox("Confirm Update GST ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Dim Trans As SqlTransaction = Nothing

        Try
            Trans = CreateSQLTransaction()

            Me.Cursor = Cursors.WaitCursor

            Dim Doc_id, DocDtl_id, stk_id As Integer
            Dim StkQty As Double = 0
            Dim PurQty As Double = 0

            Query = "Delete from Trans1"
            Common.ExecuteQuery(Query)

            Query = " Update ItemStock set Max_Level= 0"
            Common.ExecuteQuery(Query)


            Query = "SELECT * FROM PURCHASE WHERE DOC_DT between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "' And Cobr_Id= '" & SelBranchId & "' And Bill_Sr ='A' And Opening ='0'"
            Dim DtPurchase As DataTable = Common.GetDataTable(Query)

            If DtPurchase.Rows.Count > 0 Then
                For Each RecRow In DtPurchase.Rows

                    Doc_id = RecRow("DOC_ID")

                    Query = "SELECT STK_ID, ACTQTY, DocDtl_id, HSNCODE, PURCHASEDTL.PurRate, PURCHASEDTL.TaxPerc FROM PURCHASEDTL LEFT JOIN STYLE ON STYLE.STYLE_KEY = PURCHASEDTL.STYLE_KEY " _
                            & " WHERE Doc_id = " & Doc_id

                    Dim DtPurchaseDtl As DataTable = Common.GetDataTable(Query, Trans)

                    Dim DiffQty As Double = 0
                    Dim RecQty, IsuQty, ExcisableAmt, TaxableAmt, NonTaxableAmt As Double


                    For Each RecRow1 In DtPurchaseDtl.Rows
                        RecQty = 0 : IsuQty = 0
                        ExcisableAmt = 0 : TaxableAmt = 0 : NonTaxableAmt = 0

                        Query = "SELECT ISNULL(sum(Qty),0) Qty FROM dbo.View_StockLedger Where STOCK_KEY = " & RecRow1("STK_ID") & " And DOC_DT <= '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "' " _
                             & " And Trj_Flg = 'R'"
                        Dim DtRecQty As DataTable = Common.GetDataTable(Query, Trans)

                        If DtRecQty.Rows.Count > 0 Then
                            RecQty = DtRecQty.Rows(0).Item(0)
                        End If


                        Query = "SELECT ISNULL(sum(Qty),0) Qty FROM dbo.View_StockLedger Where STOCK_KEY = " & RecRow1("STK_ID") & " And DOC_DT <= '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "' " _
                             & " And Trj_Flg = 'I'"
                        Dim DtIsuQty As DataTable = Common.GetDataTable(Query, Trans)

                        If DtIsuQty.Rows.Count > 0 Then
                            IsuQty = DtIsuQty.Rows(0).Item(0)
                        End If

                        Query = " Update ItemStock set Max_Level= " & RecQty - IsuQty & " Where Stk_Id = " & RecRow1("STK_ID")
                        Common.ExecuteQuery(Query, Trans)


                        Query = "SELECT Max_Level, Stk_Id From ItemStock  WHERE STK_ID=" & RecRow1("STK_ID")
                        Dim DtItemStock As DataTable = Common.GetDataTable(Query, Trans)

                        If DtItemStock.Rows(0).Item(0) > 0 Then
                            If DtItemStock.Rows(0).Item(0) >= RecRow1("ACTQTY") Then
                                Query = " Update ItemStock set Max_Level= Max_Level - " & RecRow1("ACTQTY") & " Where Stk_Id = " & DtItemStock.Rows(0).Item(1)
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow("Excise_Amt") > 0 Then
                                    ExcisableAmt = RecRow1("ACTQTY") * RecRow1("PurRate")
                                ElseIf RecRow1("TaxPerc") > 0 Then
                                    TaxableAmt = RecRow1("ACTQTY") * RecRow1("PurRate")
                                Else
                                    NonTaxableAmt = RecRow1("ACTQTY") * RecRow1("PurRate")
                                End If

                                Query = "Insert Into Trans1 VALUES (" & Doc_id & ",'" & RecRow1("HSNCODE") & "'," & RecRow1("ACTQTY") & "," & ExcisableAmt & "," & TaxableAmt & "," & NonTaxableAmt & ", " & DtItemStock.Rows(0).Item(1) & ")"
                                Common.ExecuteQuery(Query, Trans)

                            Else
                                DiffQty = DtItemStock.Rows(0).Item(0)

                                Query = " Update ItemStock set Max_Level= Max_Level - " & DiffQty & " Where Stk_Id = " & DtItemStock.Rows(0).Item(1)
                                Common.ExecuteQuery(Query, Trans)

                                If RecRow("Excise_Amt") > 0 Then
                                    ExcisableAmt = DiffQty * RecRow1("PurRate")
                                ElseIf RecRow1("TaxPerc") > 0 Then
                                    TaxableAmt = DiffQty * RecRow1("PurRate")
                                Else
                                    NonTaxableAmt = DiffQty * RecRow1("PurRate")
                                End If

                                Query = "Insert Into Trans1 VALUES (" & Doc_id & ",'" & RecRow1("HSNCODE") & "'," & DiffQty & "," & ExcisableAmt & "," & TaxableAmt & "," & NonTaxableAmt & ", " & DtItemStock.Rows(0).Item(1) & ")"
                                Common.ExecuteQuery(Query, Trans)

                            End If
                        End If

                    Next RecRow1

                Next RecRow

                Trans.Commit()

                MsgBox("Record Saved Successfully !", MsgBoxStyle.Exclamation)

                ''''Raju

                Dim xlApp As New Excel.Application
                Dim xlBook As Excel.Workbook = xlApp.Workbooks.Add
                Dim xlSheet As Excel.Worksheet = xlBook.ActiveSheet
                Dim dtDocId As DataTable
                xlSheet.Cells(1, 1) = "Sr No."
                xlSheet.Cells(1, 2) = "Doc No."
                xlSheet.Cells(1, 3) = "Date"
                xlSheet.Cells(1, 4) = "Party Ref No"
                xlSheet.Cells(1, 5) = "Date "
                xlSheet.Cells(1, 6) = "Place Name"
                xlSheet.Cells(1, 7) = "HSN Code"
                xlSheet.Cells(1, 8) = "Total Qty"
                xlSheet.Cells(1, 9) = "Excisable" & vbLf & " Value"
                xlSheet.Cells(1, 10) = "Taxable" & vbLf & "Value"
                xlSheet.Cells(1, 11) = "Non-Taxable" & vbLf & "Value"
                xlSheet.Range(xlSheet.Cells(1, 1), xlSheet.Cells(1, 11)).Font.Bold = True
               
                'Query = "Select Doc_id,HSN_Code from trans1 group by  Doc_id,HSN_Code"
                'dtDocId = Common.GetDataTable(Query, Trans)
                Dim Row As DataRow
                Dim recrow2 As DataRow
                Dim i As Integer = 2
                Dim k As Integer = 1
                ' For Each Row In dtDocId.Rows
                Query = "select purchase.Doc_No,Doc_Dt,Chln_No,Chln_Dt,Ledger.Led_Name,trans1.HSN_Code,Sum(trans1.HSN_Qty) TotQty,Sum(trans1.Excisable) TotExcisable, " _
                        & " Sum(trans1.Taxable) TotTaxable,Sum(trans1.NonTaxable) TotNonTaxable " _
                        & " from trans1 inner join purchase " _
                        & " on purchase.Doc_id =trans1.Doc_id " _
                        & " LEFT JOIN LEDGER ON LEDGER.LED_KEY = purchase.SUPL_KEY " _
                        & " group by  Doc_No,Doc_Dt,Chln_No,Chln_Dt,Ledger.Led_Name,trans1.HSN_Code Order By Doc_Dt"
                'Common.ExecuteQuery(Query)

                ' & " where purchase.Doc_id = " & Row("Doc_id") & " " _

                Dim dt As DataTable = Common.GetDataTable(Query)

                For Each recrow2 In dt.Rows
                    xlSheet.Cells(i, 1) = k
                    xlSheet.Cells(i, 2) = recrow2("Doc_No")
                    xlSheet.Cells(i, 3) = recrow2("Doc_Dt")
                    xlSheet.Cells(i, 4) = recrow2("Chln_No")
                    xlSheet.Cells(i, 5) = recrow2("Chln_Dt")
                    xlSheet.Cells(i, 6) = recrow2("Led_Name")
                    xlSheet.Cells(i, 7) = recrow2("HSN_Code")
                    xlSheet.Cells(i, 8) = recrow2("TotQty")
                    xlSheet.Cells(i, 9) = recrow2("TotExcisable")
                    xlSheet.Cells(i, 10) = recrow2("TotTaxable")
                    xlSheet.Cells(i, 11) = recrow2("TotNonTaxable")
                    i += 1
                    k += 1
                Next

                ' Next

                Query = "select sum(HSN_Qty) Qty,sum(Excisable) Excisable,sum(Taxable) Taxable,sum(NonTaxable) NonTaxable from trans1"
                Dim DtSumAmt As DataTable = Common.GetDataTable(Query)
                xlSheet.Cells(i + 1, 7) = "GRAND TOTAL"
                xlSheet.Cells(i + 1, 8) = DtSumAmt.Rows(0)("Qty")
                xlSheet.Cells(i + 1, 9) = DtSumAmt.Rows(0)("Excisable")
                xlSheet.Cells(i + 1, 10) = DtSumAmt.Rows(0)("Taxable")
                xlSheet.Cells(i + 1, 11) = DtSumAmt.Rows(0)("NonTaxable")

                xlSheet.Cells(i + 3, 7) = "Excisable Qty"
                xlSheet.Cells(i + 4, 7) = "Taxable Qty"
                xlSheet.Cells(i + 5, 7) = "NonTaxable Qty"

                Query = "select sum(HSN_Qty) ExcisableQty  from trans1 where  Excisable<>0"
                Dim dtSumExcQty As DataTable = Common.GetDataTable(Query)
                xlSheet.Cells(i + 3, 8) = dtSumExcQty.Rows(0)("ExcisableQty")
                Query = "select sum(HSN_Qty) TaxableQty from trans1 where Taxable<>0"
                Dim dtSumtaxQty As DataTable = Common.GetDataTable(Query)
                xlSheet.Cells(i + 4, 8) = dtSumtaxQty.Rows(0)("TaxableQty")
                Query = "select sum(HSN_Qty) NonTaxableQty from trans1 where NonTaxable<>0"
                Dim dtSumNonTaxQty As DataTable = Common.GetDataTable(Query)
                xlSheet.Cells(i + 5, 8) = dtSumNonTaxQty.Rows(0)("NonTaxableQty")
                xlSheet.Range(xlSheet.Cells(i + 1, 2), xlSheet.Cells(i + 1, 34)).Font.Bold = True
                xlSheet.Range(xlSheet.Cells(i + 3, 2), xlSheet.Cells(i + 1, 34)).Font.Bold = True
                xlSheet.Range(xlSheet.Cells(i + 4, 2), xlSheet.Cells(i + 1, 34)).Font.Bold = True
                xlSheet.Range(xlSheet.Cells(i + 5, 2), xlSheet.Cells(i + 1, 34)).Font.Bold = True


                xlSheet.Rows(1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                xlSheet.Columns.AutoFit()

                'xlSheet.SaveAs(Application.StartupPath & "Trans1--" & ".xls")
                xlApp.Visible = True


            Else

                MsgBox("Record not found !", MsgBoxStyle.Exclamation)

            End If

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
            Trans.Rollback()
            ' Return 1
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Trans.Rollback()
            '  Return 1
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub dtpFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFrom.KeyDownEvent, dtpTo.KeyDownEvent
        MoveToNextControl(e)
    End Sub

    Private Sub btnOpenCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenCancel.Click
        Me.Close()
    End Sub
End Class