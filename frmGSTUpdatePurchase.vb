Imports System.Data.SqlClient

Public Class frmGSTUpdatePurchase

    Private Sub frmGSTUpdatePurchase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grpOpen.Visible = True
        dtpFrom.Value = "2017-07-01"
        dtpTo.Value = Now.Date
        dtpFrom.Focus()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If MsgBox("Update Purchase GST  ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        If MsgBox("Confirm Update GST ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Dim Trans As SqlTransaction = Nothing

        Try

            Me.Cursor = Cursors.WaitCursor

            Dim ITEM_KEY, Tax_Included As String
            Dim NoTax_key, Tax_Key, Tax1_Key, Tax2_Key, Tax3_Key As String
            Dim Tax_Perc, Tax1_Perc, Tax2_Perc, Tax3_Perc As Double
            Dim NoTax_Amt, Tax_Amt, Tax1_Amt, Tax2_Amt, Tax3_Amt, Taxable_amt, TempTaxable_amt1, TempTaxable_amt2, TempTaxable_amt3 As Double

            ITEM_KEY = "" : NoTax_key = "" : Tax_Key = "" : Tax1_Key = "" : Tax2_Key = "" : Tax3_Key = ""
            Tax_Perc = 0 : Tax1_Perc = 0 : Tax2_Perc = 0 : Tax3_Perc = 0
            NoTax_Amt = 0 : Tax_Amt = 0 : Tax1_Amt = 0 : Tax2_Amt = 0 : Tax3_Amt = 0 : Taxable_amt = 0 : TempTaxable_amt1 = 0 : TempTaxable_amt2 = 0 : TempTaxable_amt3 = 0

          

            '-______________________FOR PURCHASE__________________________________________________________________
            Dim PSUPL_KEY As String = ""
            Dim PDOC_ID As Integer = 0
            Dim PDocDtl_id As Integer = 0

            Dim PTax_Key, PTax1_Key, PTax2_Key, PTax3_Key As String
            Dim PTax_Perc, PTax1_Perc, PTax2_Perc, PTax3_Perc As Double
            Dim PTax_Amt, PTax1_Amt, PTax2_Amt, PTax3_Amt, PTaxable_amt, PNetAmtDtl, PRdOff As Double

            PTax_Key = "" : PTax1_Key = "" : PTax2_Key = "" : PTax3_Key = ""
            PTax_Perc = 0 : PTax1_Perc = 0 : PTax2_Perc = 0 : PTax3_Perc = 0
            PTax_Amt = 0 : PTax1_Amt = 0 : PTax2_Amt = 0 : PTax3_Amt = 0 : PTaxable_amt = 0 : PNetAmtDtl = 0 : PRdOff = 0

            Dim PRtnRate, RDisc As Double



            Query = "SELECT * FROM PURCHASE WHERE DOC_DT  > = '2017-07-01'   AND  DOC_DT between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "' And CoBr_Id = '" & SelBranchFixId & "'"
            '    Query = "SELECT * FROM PURCHASE WHERE DOC_DT  > = '2017-11-20' and doc_id=1666"
            Dim PGSTDT As DataTable = Common.GetDataTable(Query)

            For Each PRecRow In PGSTDT.Rows
                PDOC_ID = PRecRow("DOC_ID")
                PSUPL_KEY = PRecRow("SUPL_KEY")

                Query = "SELECT GSTLed_Type FROM LEDGER WHERE LED_KEY='" & PSUPL_KEY & "'"
                Dim WGSTDTL As DataTable = Common.GetDataTable(Query)

                Query = "SELECT GSTTYPE FROM TAXTERMSTDS WHERE TXTMTDS_KEY IN ( SELECT TAX_KEY FROM PURCHASEDTL WHERE DOC_ID=" & PDOC_ID & ")"
                Dim TaxGST As DataTable = Common.GetDataTable(Query)
                'If WGSTDTL(0)("GSTLed_Type") <> TaxGST(0)("GSTTYPE") Then

                Query = "Select * from PurchaseDtl where DOC_ID=" & PDOC_ID & ""
                Dim PG As DataTable = Common.GetDataTable(Query)

                For Each PGRow In PG.Rows

                    PTax_Perc = PGRow("TaxPerc")
                    Query = "Select * from TaxTERMSTDS WHERE TxTmTDS_Perc=" & PTax_Perc & " AND GSTTYPE='" & WGSTDTL(0)("GSTLed_Type") & "' AND ApplySalePur='P'  AND TAXCLASS='GST' "
                    Dim PTaxGST As DataTable = Common.GetDataTable(Query)

                    Query = "UPDATE PURCHASEDTL SET TAX_KEY='" & PTaxGST(0)("TxTmTDS_Key") & "' WHERE DOCDTL_ID=" & PGRow("Docdtl_id") & ""
                    Common.ExecuteQuery(Query)

                    If WGSTDTL(0)("GSTLed_Type") = "R" Then

                        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS WHERE TxTmTDS_Key = '" & PTaxGST(0)("TxTmTDS_Key") & "'"
                        Dim ptax1 As DataTable = Common.GetDataTable(Query)
                        If ptax1.Rows.Count > 0 Then
                            PTax1_Key = ptax1.Rows(0)("Tax1Led_Key")
                            PTax1_Perc = ptax1.Rows(0)("Tax1Led_Perc")
                            PTax2_Key = ptax1.Rows(0)("Tax2Led_Key")
                            PTax2_Perc = ptax1.Rows(0)("Tax2Led_Perc")
                            PTax3_Key = ptax1.Rows(0)("Tax3Led_Key")
                            PTax3_Perc = ptax1.Rows(0)("Tax3Led_Perc")


                            If PTax1_Key <> "" Then
                                PTax1_Amt = Format$((PTax1_Perc / 100) * Val(PGRow("Taxable")), "0.00")
                            Else
                                PTax1_Perc = 0
                                PTax1_Amt = 0
                            End If

                            If PTax2_Key <> "" Then
                                PTax2_Amt = Format$((PTax2_Perc / 100) * Val(PGRow("Taxable")), "0.00")
                            Else
                                PTax2_Perc = 0
                                PTax2_Amt = 0
                            End If

                            If PTax3_Key <> "" Then
                                PTax3_Amt = Format$((PTax3_Perc / 100) * Val(PGRow("Taxable")), "0.00")

                            Else
                                PTax3_Perc = 0
                                PTax3_Amt = 0
                            End If

                            PTax_Amt = Format$(Val(PTax1_Amt) + Val(PTax2_Amt) + Val(PTax3_Amt), "0.00")
                            PNetAmtDtl = Format$(Val(PGRow("Taxable")) + Val(PTax_Amt), "0.00")

                            Query = " Update PurchaseDtl set Tax_Amt=" & PTax_Amt & ",NetAmt=" & PNetAmtDtl & "," _
                               & " Tax1_Key='" & PTax1_Key & "',Tax1Perc=" & PTax1_Perc & ",Tax1_Amt=" & PTax1_Amt & "," _
                               & " Tax2_Key='" & PTax2_Key & "',Tax2Perc=" & PTax2_Perc & ",Tax2_Amt=" & PTax2_Amt & "," _
                               & " Tax3_Key='" & PTax3_Key & "',Tax3Perc=" & PTax3_Perc & ",Tax3_Amt=" & PTax3_Amt & " WHERE DOCDTL_ID=" & PGRow("DOCDTL_ID")

                            Common.ExecuteQuery(Query, Trans)
                        End If

                    ElseIf WGSTDTL(0)("GSTLed_Type") = "I" Then


                        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS WHERE TxTmTDS_Key = '" & PTaxGST(0)("TxTmTDS_Key") & "'"
                        Dim ptax1 As DataTable = Common.GetDataTable(Query)
                        If ptax1.Rows.Count > 0 Then
                            PTax1_Key = ptax1.Rows(0)("Tax1Led_Key")
                            PTax1_Perc = ptax1.Rows(0)("Tax1Led_Perc")
                            PTax2_Key = ptax1.Rows(0)("Tax2Led_Key")
                            PTax2_Perc = ptax1.Rows(0)("Tax2Led_Perc")
                            PTax3_Key = ptax1.Rows(0)("Tax3Led_Key")
                            PTax3_Perc = ptax1.Rows(0)("Tax3Led_Perc")
                            '__________________________
                            '    If PTax1_Key <> "" Then
                            '        PTax1_Amt = Format$((PTax1_Perc / 100) * Val(PGRow("Taxable")), "0.00")
                            '    Else
                            '        PTax1_Perc = 0
                            '        PTax1_Amt = 0
                            '    End If

                            '    If PTax2_Key <> "" Then
                            '        PTax2_Amt = Format$((PTax2_Perc / 100) * Val(PGRow("Taxable")), "0.00")
                            '    Else
                            '        PTax2_Perc = 0
                            '        PTax2_Amt = 0
                            '    End If

                            '    If PTax3_Key <> "" Then
                            '        '   PTax3_Amt = Format$((PTax3_Perc / 100) * Val(PGRow("Taxable")), "0.00")
                            '        PTax3_Amt = Format$(PGRow("Taxable") * (PTax3_Perc / 100), "0.00")

                            '        '     Format$(txtTaxableAmt.EditValue * (txtDtlTaxPerc.EditValue / 100), "0.00")
                            '    Else
                            '        PTax3_Perc = 0
                            '        PTax3_Amt = 0
                            '    End If

                            '    PTax_Amt = Format$(Val(PTax1_Amt) + Val(PTax2_Amt) + Val(PTax3_Amt), "0.00")
                            '    PNetAmtDtl = Format$(Val(PGRow("Taxable")) + Val(PTax_Amt), "0.00")


                            '    Query = " Update PurchaseDtl set Tax_Amt=" & PTax_Amt & ",NetAmt=" & PNetAmtDtl & "," _
                            '& " Tax1_Key='" & PTax1_Key & "',Tax1Perc=" & PTax1_Perc & ",Tax1_Amt=" & PTax1_Amt & "," _
                            '& " Tax2_Key='" & PTax2_Key & "',Tax2Perc=" & PTax2_Perc & ",Tax2_Amt=" & PTax2_Amt & "," _
                            '& " Tax3_Key='" & PTax3_Key & "',Tax3Perc=" & PTax3_Perc & ",Tax3_Amt=" & PTax3_Amt & " WHERE DOCDTL_ID=" & PGRow("DOCDTL_ID")

                            '    Common.ExecuteQuery(Query, Trans)


                            '_______________________________________________________________________________________
                            Query = " Update PurchaseDtl set  Tax1_Key='',Tax1Perc=0,Tax1_Amt=0," _
                             & " Tax2_Key='',Tax2Perc=0,Tax2_Amt=0," _
                             & " Tax3_Key='" & PTax3_Key & "',Tax3Perc=" & PTax3_Perc & ",Tax3_Amt=" & PGRow("Tax_Amt") & " WHERE DOCDTL_ID=" & PGRow("DOCDTL_ID")

                            Common.ExecuteQuery(Query, Trans)

                        End If


                    End If

                Next PGRow

                '   End If

                Dim PTAX, PTAXABLE, POTHAMT, PNETAMT, PTotal As Double

                Query = "SELECT SUM(TAX_AMT) AS TAX_AMT,SUM(TAXABLE) AS TAXABLE FROM PURCHASEDTL WHERE DOC_ID = " & PDOC_ID & ""
                Dim PSUM As DataTable = Common.GetDataTable(Query)
                If PSUM.Rows.Count > 0 Then
                    PTAX = PSUM.Rows(0)("TAX_AMT")
                    PTAXABLE = PSUM.Rows(0)("TAXABLE")
                End If


                Query = " Update PURCHASE set TAX_AMT=" & PTAX & " ,TAXABLE_AMT=" & PTAXABLE & " where  DOC_Id= " & PDOC_ID & ""
                Common.ExecuteQuery(Query, Trans)


                Query = "SELECT TAXABLE_AMT, TAX_AMT, OTHCHGS_AMT FROM PURCHASE WHERE DOC_ID = " & PDOC_ID & ""
                Dim PRSUM As DataTable = Common.GetDataTable(Query)
                If PRSUM.Rows.Count > 0 Then
                    PTAX = PRSUM.Rows(0)("TAX_AMT")
                    PTAXABLE = PRSUM.Rows(0)("TAXABLE_AMT")
                    POTHAMT = PRSUM.Rows(0)("OTHCHGS_AMT")
                End If

                PNETAMT = Format$((PRSUM.Rows(0)("TAX_AMT") + PRSUM.Rows(0)("TAXABLE_AMT") + PRSUM.Rows(0)("OTHCHGS_AMT")), "0.00")

                PTotal = Format$(Math.Round(Val(PNETAMT), 0), "0.00")
                PRdOff = Format$(Val(PTotal) - Val(PNETAMT), "0.00")

                If PRdOff = -0.5 Then
                    PTotal = Format$(Val(PTotal) + 1, "0.00")
                    PRdOff = "0.50"
                End If

                Query = " Update PURCHASE set RDOFF=" & PRdOff & " where  DOC_Id= " & PDOC_ID & ""
                Common.ExecuteQuery(Query, Trans)


            Next PRecRow




            '' ''-______________________START PURCHASERTN__________________________________________________________________


            Dim PrSUPL_KEY As String = ""
            Dim PrDOC_ID As Integer = 0
            Dim PrDocDtl_id As Integer = 0

            Dim PRTax_Key, PRTax1_Key, PRTax2_Key, PRTax3_Key As String
            Dim PRTax_Perc, PRTax1_Perc, PRTax2_Perc, PRTax3_Perc As Double
            Dim PRTax_Amt, PRTax1_Amt, PRTax2_Amt, PRTax3_Amt, PRTaxable_amt, PrNetAmtDtl, PrRdOff As Double

            PRTax_Key = "" : PRTax1_Key = "" : PRTax2_Key = "" : PRTax3_Key = ""
            PRTax_Perc = 0 : PRTax1_Perc = 0 : PRTax2_Perc = 0 : PRTax3_Perc = 0
            PRTax_Amt = 0 : PRTax1_Amt = 0 : PRTax2_Amt = 0 : PRTax3_Amt = 0 : PRTaxable_amt = 0 : PrNetAmtDtl = 0 : PrRdOff = 0

            Dim PrRtnRate, RrDisc As Double



            Query = "SELECT * FROM PURCHASERTN WHERE DOC_DT  > = '2017-07-01' AND  DOC_DT between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"

            Dim PrGSTDT As DataTable = Common.GetDataTable(Query)

            For Each PRRecRow In PrGSTDT.Rows
                PrDOC_ID = PRRecRow("DOC_ID")
                PrSUPL_KEY = PRRecRow("SUPL_KEY")

                Query = "SELECT GSTLed_Type FROM LEDGER WHERE LED_KEY='" & PrSUPL_KEY & "'"
                Dim WrGSTDTL As DataTable = Common.GetDataTable(Query)

                Query = "SELECT GSTTYPE FROM TAXTERMSTDS WHERE TXTMTDS_KEY IN ( SELECT TAX_KEY FROM PURCHASERTNDTL WHERE DOC_ID=" & PrDOC_ID & ")"
                Dim pTaxGST As DataTable = Common.GetDataTable(Query)
                'If WGSTDTL(0)("GSTLed_Type") <> TaxGST(0)("GSTTYPE") Then

                Query = "Select * from PURCHASERTNDtl where DOC_ID=" & PrDOC_ID & ""
                Dim PrG As DataTable = Common.GetDataTable(Query)

                For Each PrGRow In PrG.Rows

                    PRTax_Perc = PrGRow("TaxPerc")
                    Query = "Select * from TaxTERMSTDS WHERE TxTmTDS_Perc=" & PRTax_Perc & " AND GSTTYPE='" & WrGSTDTL(0)("GSTLed_Type") & "' AND ApplySalePur='P'  AND TAXCLASS='GST' "
                    Dim PRTaxGST As DataTable = Common.GetDataTable(Query)

                    Query = "UPDATE PURCHASERTNDTL SET TAX_KEY='" & PRTaxGST(0)("TxTmTDS_Key") & "' WHERE DOCDTL_ID=" & PrGRow("Docdtl_id") & ""
                    Common.ExecuteQuery(Query)

                    If WrGSTDTL(0)("GSTLed_Type") = "R" Then

                        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS WHERE TxTmTDS_Key = '" & PRTaxGST(0)("TxTmTDS_Key") & "'"
                        Dim PRTax1 As DataTable = Common.GetDataTable(Query)
                        If PRTax1.Rows.Count > 0 Then
                            PRTax1_Key = PRTax1.Rows(0)("Tax1Led_Key")
                            PRTax1_Perc = PRTax1.Rows(0)("Tax1Led_Perc")
                            PRTax2_Key = PRTax1.Rows(0)("Tax2Led_Key")
                            PRTax2_Perc = PRTax1.Rows(0)("Tax2Led_Perc")
                            PRTax3_Key = PRTax1.Rows(0)("Tax3Led_Key")
                            PRTax3_Perc = PRTax1.Rows(0)("Tax3Led_Perc")


                            If PRTax1_Key <> "" Then
                                PRTax1_Amt = Format$((PRTax1_Perc / 100) * Val(PrGRow("Taxable")), "0.00")
                            Else
                                PRTax1_Perc = 0
                                PRTax1_Amt = 0
                            End If

                            If PRTax2_Key <> "" Then
                                PRTax2_Amt = Format$((PRTax2_Perc / 100) * Val(PrGRow("Taxable")), "0.00")
                            Else
                                PRTax2_Perc = 0
                                PRTax2_Amt = 0
                            End If

                            If PRTax3_Key <> "" Then
                                PRTax3_Amt = Format$((PRTax3_Perc / 100) * Val(PrGRow("Taxable")), "0.00")
                            Else
                                PRTax3_Perc = 0
                                PRTax3_Amt = 0
                            End If

                            PRTax_Amt = Format$(Val(PRTax1_Amt) + Val(PRTax2_Amt) + Val(PRTax3_Amt), "0.00")
                            PrNetAmtDtl = Format$(Val(PrGRow("Taxable")) + Val(PRTax_Amt), "0.00")

                            Query = " Update PURCHASERTNDtl set Tax_Amt=" & PRTax_Amt & ",NetAmt=" & PNetAmtDtl & "," _
                               & " Tax1_Key='" & PRTax1_Key & "',Tax1Perc=" & PRTax1_Perc & ",Tax1_Amt=" & PRTax1_Amt & "," _
                               & " Tax2_Key='" & PRTax2_Key & "',Tax2Perc=" & PRTax2_Perc & ",Tax2_Amt=" & PRTax2_Amt & "," _
                               & " Tax3_Key='" & PRTax3_Key & "',Tax3Perc=" & PRTax3_Perc & ",Tax3_Amt=" & PRTax3_Amt & " WHERE DOCDTL_ID=" & PrGRow("DOCDTL_ID")

                            Common.ExecuteQuery(Query, Trans)
                        End If

                    ElseIf WrGSTDTL(0)("GSTLed_Type") = "I" Then


                        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS WHERE TxTmTDS_Key = '" & PRTaxGST(0)("TxTmTDS_Key") & "'"
                        Dim PRTax1 As DataTable = Common.GetDataTable(Query)
                        If PRTax1.Rows.Count > 0 Then
                            PRTax1_Key = PRTax1.Rows(0)("Tax1Led_Key")
                            PRTax1_Perc = PRTax1.Rows(0)("Tax1Led_Perc")
                            PRTax2_Key = PRTax1.Rows(0)("Tax2Led_Key")
                            PRTax2_Perc = PRTax1.Rows(0)("Tax2Led_Perc")
                            PRTax3_Key = PRTax1.Rows(0)("Tax3Led_Key")
                            PRTax3_Perc = PRTax1.Rows(0)("Tax3Led_Perc")

                            Query = " Update PURCHASERTNDtl set  Tax1_Key='',Tax1Perc=0,Tax1_Amt=0," _
                             & " Tax2_Key='',Tax2Perc=0,Tax2_Amt=0," _
                             & " Tax3_Key='" & PRTax3_Key & "',Tax3Perc=" & PRTax3_Perc & ",Tax3_Amt=" & PrGRow("Tax_Amt") & " WHERE DOCDTL_ID=" & PrGRow("DOCDTL_ID")

                            Common.ExecuteQuery(Query, Trans)

                        End If


                    End If

                Next PrGRow

                '   End If

                Dim PRTax, PRTaxABLE, PrOTHAMT, PrNETAMT, PrTotal As Double

                Query = "SELECT SUM(TAX_AMT) AS TAX_AMT,SUM(TAXABLE) AS TAXABLE FROM PURCHASERTNDTL WHERE DOC_ID = " & PrDOC_ID & ""
                Dim PrSUM As DataTable = Common.GetDataTable(Query)
                If PrSUM.Rows.Count > 0 Then
                    PRTax = PrSUM.Rows(0)("TAX_AMT")
                    PRTaxABLE = PrSUM.Rows(0)("TAXABLE")
                End If


                Query = " Update PURCHASERTN set TAX_AMT=" & PRTax & " ,TAXABLE_AMT=" & PRTaxABLE & " where  DOC_Id= " & PrDOC_ID & ""
                Common.ExecuteQuery(Query, Trans)


                Query = "SELECT TAXABLE_AMT, TAX_AMT, OTHCHGS_AMT FROM PURCHASERTN WHERE DOC_ID = " & PrDOC_ID & ""
                Dim PRSUM1 As DataTable = Common.GetDataTable(Query)
                If PRSUM1.Rows.Count > 0 Then
                    PRTax = PRSUM1.Rows(0)("TAX_AMT")
                    PRTaxABLE = PRSUM1.Rows(0)("TAXABLE_AMT")
                    PrOTHAMT = PRSUM1.Rows(0)("OTHCHGS_AMT")
                End If

                PrNETAMT = Format$((PRSUM1.Rows(0)("TAX_AMT") + PRSUM1.Rows(0)("TAXABLE_AMT") + PRSUM1.Rows(0)("OTHCHGS_AMT")), "0.00")

                PrTotal = Format$(Math.Round(Val(PrNETAMT), 0), "0.00")
                PrRdOff = Format$(Val(PrTotal) - Val(PrNETAMT), "0.00")

                If PrRdOff = -0.5 Then
                    PrTotal = Format$(Val(PrTotal) + 1, "0.00")
                    PrRdOff = "0.50"
                End If

                Query = " Update PURCHASERTN set RDOFF=" & PrRdOff & " where  DOC_Id= " & PrDOC_ID & ""
                Common.ExecuteQuery(Query, Trans)


            Next PRRecRow



            MsgBox("Record Saved Successfully !", MsgBoxStyle.Exclamation)


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
    Private Sub grpOpen_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpOpen.Enter

    End Sub

    Private Sub btnOpenCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenCancel.Click
        Me.Close()
    End Sub
End Class