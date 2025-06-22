Imports System.Data.SqlClient

Public Class frmGSTUpdate

    Private Sub frmGSTUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grpOpen.Visible = True
        dtpFrom.Value = Now.Date
        dtpTo.Value = Now.Date
        dtpFrom.Focus()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If MsgBox("Update GST  ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        If MsgBox("Confirm Update GST ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Dim Trans As SqlTransaction = Nothing

        Try
            Trans = CreateSQLTransaction()
            Me.Cursor = Cursors.WaitCursor

            Dim ITEM_KEY, Tax_Included As String
            Dim NoTax_key, Tax_Key, Tax1_Key, Tax2_Key, Tax3_Key As String
            Dim Tax_Perc, Tax1_Perc, Tax2_Perc, Tax3_Perc As Double
            Dim NoTax_Amt, Tax_Amt, Tax1_Amt, Tax2_Amt, Tax3_Amt, Taxable_amt, TempTaxable_amt1, TempTaxable_amt2, TempTaxable_amt3 As Double

            ITEM_KEY = "" : NoTax_key = "" : Tax_Key = "" : Tax1_Key = "" : Tax2_Key = "" : Tax3_Key = ""
            Tax_Perc = 0 : Tax1_Perc = 0 : Tax2_Perc = 0 : Tax3_Perc = 0
            NoTax_Amt = 0 : Tax_Amt = 0 : Tax1_Amt = 0 : Tax2_Amt = 0 : Tax3_Amt = 0 : Taxable_amt = 0 : TempTaxable_amt1 = 0 : TempTaxable_amt2 = 0 : TempTaxable_amt3 = 0

            Dim SaleRate, AutoDiscPerc, ManualDiscPerc, SplDiscPerc, CardDiscPerc, TotDiscPerc, TotDiscAmt As Double
            Dim AutoDiscAmt, ManualDiscAmt, SplDiscAmt, CardDiscAmt As Double
            Dim FSaleRate, FAutoDiscAmt, FManualDiscAmt, FSplDiscAmt, FCardDiscAmt, FTotDiscAmt As Double

            Dim Doc_id, DocDtl_id, stk_id As Integer



            Query = " UPDATE ITEM SET NOTAX_AMT=1050 WHERE NOTAX_AMT=1000 OR NOTAX_AMT=999  "
            Common.ExecuteQuery(Query, Trans)

            Query = " UPDATE BILLDTL SET BILLDTL.NOTAX_AMT = ITEM.NOTAX_AMT  FROM BILLDTL LEFT JOIN ITEMSTOCK ON ITEMSTOCK.STK_ID = BILLDTL.STK_ID " _
                         & " LEFT JOIN ITEM ON ITEM.ITEM_KEY = ITEMSTOCK.ITEM_KEY  WHERE BILLDTL.NOTAX_AMT <>  ITEM.NOTAX_AMT  AND BILLDTL.Created_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
            Common.ExecuteQuery(Query, Trans)


            Query = " UPDATE BILLDTL SET BILLDTL.TAX_INCLUDED = ITEM.TAX_INCLUDED  FROM BILLDTL LEFT JOIN ITEMSTOCK ON ITEMSTOCK.STK_ID = BILLDTL.STK_ID " _
                         & " LEFT JOIN ITEM ON ITEM.ITEM_KEY = ITEMSTOCK.ITEM_KEY  WHERE BILLDTL.TAX_INCLUDED =''  AND BILLDTL.Created_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "' "
            Common.ExecuteQuery(Query, Trans)


            Query = "SELECT BILL.DOC_ID, LEDGER.GSTLed_Type  FROM BILL  With(NoLock) LEFT JOIN LEDGER  With(NoLock) ON LEDGER.LED_KEY = BILL.PARTY_KEY WHERE DOC_DT  > = '2017-07-01'   AND DOC_DT between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "' And BILL.CoBr_Id = '" & SelBranchFixId & "'"
            Dim GSTDT As DataTable = Common.GetDataTable(Query, Trans)

            For Each RecRow In GSTDT.Rows
                Doc_id = RecRow("DOC_ID")

                'Query = "SELECT DOCDTL_ID FROM BILLDTL WHERE DOC_ID = " & Doc_id & ""
                'Dim DocDt As DataTable = Common.GetDataTable(Query)
                'If DocDt.Rows.Count > 0 Then
                '    DocDtl_id = DocDt.Rows(0)("DocDtl_id")
                'End If

                '_______________________________________________________
                Query = "SELECT * FROM BILLDTL  With(NoLock) WHERE DOC_ID=" & Doc_id & " " 'AND BILLDTL.Created_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "' "


                Dim GSTDTL As DataTable = Common.GetDataTable(Query, Trans)

                For Each RecRow1 In GSTDTL.Rows
                    'SaleRate = RecRow1("SaleRate")
                    'AutoDiscPerc = RecRow1("AutoDisc_Perc")
                    'ManualDiscPerc = RecRow1("ManualDisc_Perc")
                    'SplDiscPerc = RecRow1("SplDisc_Perc")
                    'CardDiscPerc = RecRow1("CardDisc_Perc")
                    Tax_Included = RecRow1("Tax_Included")
                    DocDtl_id = RecRow1("DocDtl_id")

                    'If AutoDiscPerc > 0 Then
                    '    AutoDiscAmt = Format$((SaleRate * AutoDiscPerc) / 100, "0.00")
                    '    FAutoDiscAmt = Format$((SaleRate - AutoDiscAmt), "0.00")
                    'Else
                    '    AutoDiscAmt = 0
                    '    FAutoDiscAmt = 0
                    'End If

                    'If ManualDiscPerc > 0 Then
                    '    If FAutoDiscAmt > 0 Then
                    '        ManualDiscAmt = Format$((FAutoDiscAmt * ManualDiscPerc) / 100, "0.00")
                    '        FManualDiscAmt = Format$((FAutoDiscAmt - ManualDiscAmt), "0.00")
                    '    Else
                    '        ManualDiscAmt = Format$((SaleRate * ManualDiscPerc) / 100, "0.00")
                    '        FManualDiscAmt = Format$((SaleRate - ManualDiscAmt), "0.00")
                    '    End If

                    'Else
                    '    ManualDiscAmt = 0
                    '    FManualDiscAmt = 0
                    'End If


                    'If SplDiscPerc > 0 Then
                    '    If FManualDiscAmt > 0 Then
                    '        SplDiscAmt = Format$((FManualDiscAmt * SplDiscPerc) / 100, "0.00")
                    '        FSplDiscAmt = Format$((FManualDiscAmt - SplDiscAmt), "0.00")
                    '    Else
                    '        SplDiscAmt = Format$((SaleRate * SplDiscPerc) / 100, "0.00")
                    '        FSplDiscAmt = Format$((SaleRate - SplDiscAmt), "0.00")
                    '    End If

                    'Else
                    '    SplDiscAmt = 0
                    '    FSplDiscAmt = 0
                    'End If

                    'If CardDiscPerc > 0 Then
                    '    If SplDiscPerc > 0 Then
                    '        CardDiscAmt = Format$((FSplDiscAmt * CardDiscPerc) / 100, "0.00")
                    '        FCardDiscAmt = Format$((FSplDiscAmt - CardDiscAmt), "0.00")
                    '    Else
                    '        CardDiscAmt = Format$((SaleRate * CardDiscPerc) / 100, "0.00")
                    '        FCardDiscAmt = Format$((SaleRate - CardDiscAmt), "0.00")
                    '    End If

                    'Else
                    '    CardDiscAmt=0
                    '    FCardDiscAmt = 0
                    'End If

                    'TotDiscAmt = Format$(Val(AutoDiscAmt) + Val(ManualDiscAmt) + Val(SplDiscAmt) + Val(CardDiscAmt), "0.00")
                    'FTotDiscAmt = Format$((SaleRate - TotDiscAmt), "0.00")


                    'If FTotDiscAmt > 0 Then
                    '    FSaleRate = FTotDiscAmt
                    'Else
                    '    FSaleRate = SaleRate
                    'End If

                    FSaleRate = RecRow1("SaleRate")
                    AutoDiscAmt = 0

                    If Val(RecRow1("AutoDisc_Perc")) > 0 Then
                        AutoDiscAmt = Format$((FSaleRate * RecRow1("AutoDisc_Perc")) / 100, "0.00")
                        FSaleRate = FSaleRate - AutoDiscAmt
                    End If

                    If Val(RecRow1("ManualDisc_Perc")) > 0 Then
                        AutoDiscAmt = Format$((FSaleRate * RecRow1("ManualDisc_Perc")) / 100, "0.00")
                        FSaleRate = FSaleRate - AutoDiscAmt
                    End If

                    If Val(RecRow1("SplDisc_Perc")) > 0 Then
                        AutoDiscAmt = Format$((FSaleRate * RecRow1("SplDisc_Perc")) / 100, "0.00")
                        FSaleRate = FSaleRate - AutoDiscAmt
                    End If

                    If Val(RecRow1("CardDisc_Perc")) > 0 Then
                        AutoDiscAmt = Format$((FSaleRate * RecRow1("CardDisc_Perc")) / 100, "0.00")
                        FSaleRate = FSaleRate - AutoDiscAmt
                    End If

                    FSaleRate = Format$(FSaleRate, "0.00")

                    Dim dblTaxRate As Double = 0
                    Dim dblNoTaxRate As Double = 0

                    Query = "SELECT ITEM.NOTAX_KEY,ITEM.NOTAX_AMT,ITEM.Tax_Key, TaxTermsTDS.TxTmTDS_Perc, IsNull(NOTax.TxTmTDS_Perc,0) NoTaxPerc FROM ITEM  With(NoLock) " _
                          & " LEFT JOIN TaxTermsTDS  With(NoLock) ON TaxTermsTDS.TxTmTDS_Key = ITEM.Tax_Key AND TaxTermsTDS.ApplySalePur='S' and TaxTermsTDS.GSTTYPE='R' " _
                          & " LEFT JOIN TaxTermsTDS NOTax  With(NoLock) ON NOTax.TxTmTDS_Key = ITEM.NOTAX_KEY AND NOTax.ApplySalePur='S' and TaxTermsTDS.GSTTYPE='R' " _
                          & " INNER JOIN ITEMSTOCK  With(NoLock) ON ITEMSTOCK.ITEM_KEY=ITEM.ITEM_KEY WHERE STK_ID=" & RecRow1("STK_ID") & ""
                    Dim NT As DataTable = Common.GetDataTable(Query, Trans)
                    If NT.Rows.Count > 0 Then
                        NoTax_key = NT.Rows(0)("NOTAX_KEY")
                        NoTax_Amt = NT.Rows(0)("NOTAX_AMT")
                        Tax_Key = NT.Rows(0)("Tax_Key")
                        dblTaxRate = NT.Rows(0)("TxTmTDS_Perc")
                        dblNoTaxRate = NT.Rows(0)("NoTaxPerc")
                    End If

                    If RecRow("GSTLed_Type") = "I" And GetSettingAsPerId(ApplnSettingsIdx.IGSTInBill) = 1 Then
                        Query = "Select TxTmTDS_Key FROM TAXTERMSTDS  With(NoLock) " _
                            & " WHERE  ApplySalePur='S' and GSTTYPE='I' AND TxTmTDS_Perc=" & dblTaxRate
                        Dim IgstTax As DataTable = Common.GetDataTable(Query)
                        If IgstTax.Rows.Count > 0 Then
                            Tax_Key = IgstTax.Rows(0)("TxTmTDS_Key")
                        End If

                        If NoTax_key <> "" Then
                            Query = "Select TxTmTDS_Key FROM TAXTERMSTDS  With(NoLock) " _
                            & " WHERE  ApplySalePur='S' and GSTTYPE='I' AND TxTmTDS_Perc=" & dblNoTaxRate
                            Dim IgstTax1 As DataTable = Common.GetDataTable(Query)
                            If IgstTax1.Rows.Count > 0 Then
                                NoTax_key = IgstTax1.Rows(0)("TxTmTDS_Key")
                            End If
                        End If

                    End If



                    If FSaleRate > NoTax_Amt Then

                        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS  With(NoLock) WHERE TxTmTDS_Key = '" & Tax_Key & "'"
                        Dim tax1 As DataTable = Common.GetDataTable(Query, Trans)
                        If tax1.Rows.Count > 0 Then
                            Tax_Perc = tax1.Rows(0)("TxTmTDS_Perc")

                            If Val(Tax_Included) = 1 Then
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")) / (100 + Tax_Perc) * 100, "0.00")
                                Tax_Amt = Format$(Val(RecRow1("TotAftDisc_Amt")) - Taxable_amt, "0.00")
                            Else
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")), "0.00")
                                Tax_Amt = Format$((Tax_Perc / 100) * Val(RecRow1("TotAftDisc_Amt")), "0.00")
                            End If



                            Tax1_Key = tax1.Rows(0)("Tax1Led_Key")
                            Tax1_Perc = tax1.Rows(0)("Tax1Led_Perc")

                            If Tax1_Key <> "" Then
                                If Val(Tax_Included) = 1 Then
                                    TempTaxable_amt1 = Format$(Val(Taxable_amt) / (100 + Val(Tax1_Perc)) * 100, "0.00")
                                    Tax1_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                Else
                                    TempTaxable_amt1 = Format$((Val(Taxable_amt) * Tax1_Perc) / 100, "0.00")
                                    Tax1_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                End If

                            Else
                                Tax1_Perc = 0
                                Tax1_Amt = 0
                            End If


                            Tax2_Key = tax1.Rows(0)("Tax2Led_Key")
                            Tax2_Perc = tax1.Rows(0)("Tax2Led_Perc")
                            If Tax2_Key <> "" Then
                                If Val(Tax_Included) = 1 Then
                                    TempTaxable_amt2 = Format$(Val(Taxable_amt) / (100 + Val(Tax2_Perc)) * 100, "0.00")
                                    Tax2_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                Else
                                    TempTaxable_amt2 = Format$((Val(Taxable_amt) * Tax2_Perc) / 100, "0.00")
                                    Tax2_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                End If

                            Else
                                Tax2_Perc = 0
                                Tax2_Amt = 0
                            End If


                            Tax3_Key = tax1.Rows(0)("Tax3Led_Key")
                            Tax3_Perc = tax1.Rows(0)("Tax3Led_Perc")

                            If Tax3_Key <> "" Then
                                If Val(Tax_Included) = 1 Then
                                    TempTaxable_amt3 = Format$(Val(RecRow1("TotAftDisc_Amt")) / (100 + Val(Tax3_Perc)) * 100, "0.00")
                                    Tax3_Amt = Format$(Val(RecRow1("TotAftDisc_Amt")) - TempTaxable_amt3, "0.00")
                                Else
                                    TempTaxable_amt3 = Format$(Val(RecRow1("TotAftDisc_Amt")), "0.00")
                                    Tax3_Amt = Format$((Tax3_Perc / 100) * Val(RecRow1("TotAftDisc_Amt")), "0.00")
                                End If
                            Else
                                Tax3_Perc = 0
                                Tax3_Amt = 0
                            End If

                            Tax_Amt = Format$(Val(Tax1_Amt) + Val(Tax2_Amt) + Val(Tax3_Amt), "0.00")

                            If Val(Tax_Included) = 1 Then
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")) - Val(Tax_Amt), "0.00")
                            Else
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")), "0.00")
                            End If

                            Query = " Update BillDtl set  FSaleRate = " & FSaleRate & ", Tax_Key='" & Tax_Key & "',TaxPerc=" & Tax_Perc & ", Tax_Amt=" & Tax_Amt & ",Taxable_amt=" & Taxable_amt & "," _
                            & " Tax1_Key='" & Tax1_Key & "',Tax1Perc=" & Tax1_Perc & ",Tax1_Amt=" & Tax1_Amt & "," _
                            & " Tax2_Key='" & Tax2_Key & "',Tax2Perc=" & Tax2_Perc & ",Tax2_Amt=" & Tax2_Amt & "," _
                            & " Tax3_Key='" & Tax3_Key & "',Tax3Perc=" & Tax3_Perc & ",Tax3_Amt=" & Tax3_Amt & " WHERE DOCDTL_ID=" & DocDtl_id & "" ' AND Created_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"

                            Common.ExecuteQuery(Query, Trans)



                        End If

                    ElseIf FSaleRate <= NoTax_Amt Then


                        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS  With(NoLock) WHERE TxTmTDS_Key = '" & NoTax_key & "'"
                        Dim tax1 As DataTable = Common.GetDataTable(Query, Trans)
                        If tax1.Rows.Count > 0 Then
                            Tax_Perc = tax1.Rows(0)("TxTmTDS_Perc")

                            If Val(Tax_Included) = 1 Then
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")) / (100 + Tax_Perc) * 100, "0.00")
                                Tax_Amt = Format$(Val(RecRow1("TotAftDisc_Amt")) - Taxable_amt, "0.00")
                            Else
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")), "0.00")
                                Tax_Amt = Format$((Tax_Perc / 100) * Val(RecRow1("TotAftDisc_Amt")), "0.00")
                            End If

                            Tax1_Key = tax1.Rows(0)("Tax1Led_Key")
                            Tax1_Perc = tax1.Rows(0)("Tax1Led_Perc")

                            If Tax1_Key <> "" Then
                                If Val(Tax_Included) = 1 Then
                                    TempTaxable_amt1 = Format$(Val(Taxable_amt) / (100 + Val(Tax1_Perc)) * 100, "0.00")
                                    Tax1_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                Else
                                    TempTaxable_amt1 = Format$((Val(Taxable_amt) * Tax1_Perc) / 100, "0.00")
                                    Tax1_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                End If

                            Else
                                Tax1_Perc = 0
                                Tax1_Amt = 0
                            End If


                            Tax2_Key = tax1.Rows(0)("Tax2Led_Key")
                            Tax2_Perc = tax1.Rows(0)("Tax2Led_Perc")
                            If Tax2_Key <> "" Then
                                If Val(Tax_Included) = 1 Then
                                    TempTaxable_amt2 = Format$(Val(Taxable_amt) / (100 + Val(Tax2_Perc)) * 100, "0.00")
                                    Tax2_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                Else
                                    TempTaxable_amt2 = Format$((Val(Taxable_amt) * Tax2_Perc) / 100, "0.00")
                                    Tax2_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                End If

                            Else
                                Tax2_Perc = 0
                                Tax2_Amt = 0
                            End If


                            Tax3_Key = tax1.Rows(0)("Tax3Led_Key")
                            Tax3_Perc = tax1.Rows(0)("Tax3Led_Perc")
                            If Tax3_Key <> "" Then
                                If Val(Tax_Included) = 1 Then
                                    TempTaxable_amt3 = Format$(Val(RecRow1("TotAftDisc_Amt")) / (100 + Val(Tax3_Perc)) * 100, "0.00")
                                    Tax3_Amt = Format$(Val(RecRow1("TotAftDisc_Amt")) - TempTaxable_amt3, "0.00")
                                Else
                                    'TempTaxable_amt3 = Format$((Val(Taxable_amt) * Tax3_Perc) / 100, "0.00")
                                    'Tax3_Amt = Format$(Val(Tax_Amt) / 2, "0.00")
                                    TempTaxable_amt3 = Format$(Val(RecRow1("TotAftDisc_Amt")), "0.00")
                                    Tax3_Amt = Format$((Tax3_Perc / 100) * Val(RecRow1("TotAftDisc_Amt")), "0.00")
                                End If
                            Else
                                Tax3_Perc = 0
                                Tax3_Amt = 0
                            End If

                            Tax_Amt = Format$(Val(Tax1_Amt) + Val(Tax2_Amt) + Val(Tax3_Amt), "0.00")

                            If Val(Tax_Included) = 1 Then
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")) - Val(Tax_Amt), "0.00")
                            Else
                                Taxable_amt = Format$(Val(RecRow1("TotAftDisc_Amt")), "0.00")
                            End If

                            Query = " Update BillDtl set FSaleRate = " & FSaleRate & ", Tax_Key='" & NoTax_key & "',TaxPerc=" & Tax_Perc & ",Tax_Amt=" & Tax_Amt & ",Taxable_amt=" & Taxable_amt & "," _
                            & " Tax1_Key='" & Tax1_Key & "',Tax1Perc=" & Tax1_Perc & ",Tax1_Amt=" & Tax1_Amt & "," _
                            & " Tax2_Key='" & Tax2_Key & "',Tax2Perc=" & Tax2_Perc & ",Tax2_Amt=" & Tax2_Amt & "," _
                            & " Tax3_Key='" & Tax3_Key & "',Tax3Perc=" & Tax3_Perc & ",Tax3_Amt=" & Tax3_Amt & " WHERE DOCDTL_ID=" & DocDtl_id & "" ' AND Created_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
                            Common.ExecuteQuery(Query, Trans)


                        End If

                    End If




                Next RecRow1
                '______________________________________________________________________________________

                Dim TAX, TAXABLE, TAXM, TAXABLEM As Double
                TAX = 0
                TAXM = 0
                TAXABLE = 0
                TAXABLEM = 0


                Dim OtherTaxAmt As Double = 0
                Dim OtherTaxableAmt As Double = 0
                Query = "SELECT ISNULL(SUM(ISNULL(TTAX_AMT,0)),0) TAXAMT, ISNULL(SUM(ISNULL(TTERMS_AMT,0)),0) TAXABLE  FROM BILLTXTM  With(NoLock) WHERE DOC_ID =" & Doc_id
                Dim DtOtherTaxAmt As DataTable = Common.GetDataTable(Query, Trans)
                If DtOtherTaxAmt.Rows.Count > 0 Then
                    OtherTaxAmt = DtOtherTaxAmt.Rows(0)(0)
                    OtherTaxableAmt = DtOtherTaxAmt.Rows(0)(1)
                End If

                Query = "SELECT  ISNULL(SUM(TAX_AMT) ,0) AS TAX_AMT,  ISNULL(SUM(TAXABLE_AMT),0) AS TAXABLE_AMT FROM BILLDTL  With(NoLock) WHERE DOC_ID = " & Doc_id & "  AND  QTY >=0 " 'AND Created_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
                Dim SUM As DataTable = Common.GetDataTable(Query, Trans)
                If SUM.Rows.Count > 0 Then
                    TAX = SUM.Rows(0)("TAX_AMT")
                    TAXABLE = SUM.Rows(0)("TAXABLE_AMT")
                End If

                Query = "SELECT ISNULL(SUM(TAX_AMT),0) AS TAX_AMT, ISNULL(SUM(TAXABLE_AMT),0) AS TAXABLE_AMT FROM BILLDTL  With(NoLock) WHERE DOC_ID = " & Doc_id & "  AND  QTY <0 " ' AND Created_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
                Dim SUM1 As DataTable = Common.GetDataTable(Query, Trans)
                If SUM1.Rows.Count > 0 Then
                    TAXM = SUM1.Rows(0)("TAX_AMT")
                    TAXABLEM = SUM1.Rows(0)("TAXABLE_AMT")
                End If

                TAX = Format$(((TAX + OtherTaxAmt) - TAXM), "0.00")
                TAXABLE = Format$(((TAXABLE + OtherTaxableAmt) - TAXABLEM), "0.00")

                Query = " Update BILL set TAX_AMT=" & TAX & " ,TAXABLE_AMT=" & TAXABLE & "  where  DOC_Id= " & Doc_id & "" ' and Doc_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
                Common.ExecuteQuery(Query, Trans)

                
            Next RecRow

            If Val(GetSettingAsPerId(ApplnSettingsIdx.SoftwareForA1)) = 1 Then
                Query = "Update BILL set Chg_YN ='0' where Doc_Dt between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
                Common.ExecuteQuery(Query, Trans)
            End If

            '__________________________-END BILL _____________________________________________________________

            '-______________________FOR PURCHASERTN__________________________________________________________________

            'Dim PDOC_ID As Integer = 0
            'Dim PDocDtl_id As Integer = 0

            'Dim PTax_Key, PTax1_Key, PTax2_Key, PTax3_Key As String
            'Dim PTax_Perc, PTax1_Perc, PTax2_Perc, PTax3_Perc As Double
            'Dim PTax_Amt, PTax1_Amt, PTax2_Amt, PTax3_Amt, PTaxable_amt, PNetAmtDtl, PRdOff As Double

            'PTax_Key = "" : PTax1_Key = "" : PTax2_Key = "" : PTax3_Key = ""
            'PTax_Perc = 0 : PTax1_Perc = 0 : PTax2_Perc = 0 : PTax3_Perc = 0
            'PTax_Amt = 0 : PTax1_Amt = 0 : PTax2_Amt = 0 : PTax3_Amt = 0 : PTaxable_amt = 0 : PNetAmtDtl = 0 : PRdOff = 0

            'Dim PRtnRate, RDisc As Double



            'Query = "SELECT DOC_ID FROM PURCHASERTN WHERE DOC_DT  > = '2017-07-01' AND DOC_DT between '" & Format$(dtpFrom.Value, "MM/dd/yyyy") & "' And  '" & Format$(dtpTo.Value, "MM/dd/yyyy") & "'"
            'Dim PGSTDT As DataTable = Common.GetDataTable(Query)
            'For Each PRecRow In PGSTDT.Rows
            '    PDOC_ID = PRecRow("DOC_ID")

            '    'Query = "SELECT DOCDTL_ID FROM PURCHASERTNDTL WHERE DOC_ID = " & PDOC_ID & ""
            '    'Dim PDocDt As DataTable = Common.GetDataTable(Query)
            '    'If PDocDt.Rows.Count > 0 Then
            '    '    PDocDtl_id = PDocDt.Rows(0)("DocDtl_id")
            '    'End If

            '    Query = "SELECT * FROM PURCHASERTNDTL WHERE DOC_ID=" & PDOC_ID
            '    Dim WGSTDTL As DataTable = Common.GetDataTable(Query)

            '    For Each PRecRow1 In WGSTDTL.Rows
            '        PTaxable_amt = PRecRow1("Taxable")
            '        PTax_Perc = PRecRow1("TaxPerc")
            '        PTax_Key = PRecRow1("Tax_Key")

            '        PDocDtl_id = PRecRow1("DocDtl_id")

            '        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS WHERE TxTmTDS_Key = '" & PTax_Key & "'"
            '        Dim ptax1 As DataTable = Common.GetDataTable(Query)
            '        If ptax1.Rows.Count > 0 Then
            '            PTax1_Key = ptax1.Rows(0)("Tax1Led_Key")
            '            PTax1_Perc = ptax1.Rows(0)("Tax1Led_Perc")
            '            PTax2_Key = ptax1.Rows(0)("Tax2Led_Key")
            '            PTax2_Perc = ptax1.Rows(0)("Tax2Led_Perc")
            '            PTax3_Key = ptax1.Rows(0)("Tax3Led_Key")
            '            PTax3_Perc = ptax1.Rows(0)("Tax3Led_Perc")

            '            '  PTax_Amt = Format$((PTax_Perc / 100) * Val(PTaxable_amt), "0.00")

            '            If PTax1_Key <> "" Then
            '                PTax1_Amt = Format$((PTax1_Perc / 100) * Val(PTaxable_amt), "0.00")
            '            Else
            '                PTax1_Perc = 0
            '                PTax1_Amt = 0
            '            End If

            '            If PTax2_Key <> "" Then
            '                PTax2_Amt = Format$((PTax2_Perc / 100) * Val(PTaxable_amt), "0.00")
            '            Else
            '                PTax2_Perc = 0
            '                PTax2_Amt = 0
            '            End If

            '            If PTax3_Key <> "" Then
            '                PTax3_Amt = Format$((PTax3_Perc / 100) * Val(PTaxable_amt), "0.00")
            '            Else
            '                PTax3_Perc = 0
            '                PTax3_Amt = 0
            '            End If

            '            PTax_Amt = Format$(Val(PTax1_Amt) + Val(PTax2_Amt) + Val(PTax3_Amt), "0.00")
            '            PNetAmtDtl = Format$(Val(PTaxable_amt) + Val(PTax_Amt), "0.00")

            '            Query = " Update PurchaseRtnDtl set Tax_Key='" & PTax_Key & "',TaxPerc=" & PTax_Perc & ",Tax_Amt=" & PTax_Amt & ",Taxable=" & PTaxable_amt & ",NetAmt=" & PNetAmtDtl & "," _
            '               & " Tax1_Key='" & PTax1_Key & "',Tax1Perc=" & PTax1_Perc & ",Tax1_Amt=" & PTax1_Amt & "," _
            '               & " Tax2_Key='" & PTax2_Key & "',Tax2Perc=" & PTax2_Perc & ",Tax2_Amt=" & PTax2_Amt & "," _
            '               & " Tax3_Key='" & PTax3_Key & "',Tax3Perc=" & PTax3_Perc & ",Tax3_Amt=" & PTax3_Amt & " WHERE DOCDTL_ID=" & PDocDtl_id

            '            Common.ExecuteQuery(Query, Trans)


            '        End If

            '    Next PRecRow1

            '    Dim PTAX, PTAXABLE, POTHAMT, PNETAMT, PTotal As Double

            '    Query = "SELECT SUM(TAX_AMT) AS TAX_AMT,SUM(TAXABLE) AS TAXABLE FROM PURCHASERTNDTL WHERE DOC_ID = " & PDOC_ID & ""
            '    Dim PSUM As DataTable = Common.GetDataTable(Query)
            '    If PSUM.Rows.Count > 0 Then
            '        PTAX = PSUM.Rows(0)("TAX_AMT")
            '        PTAXABLE = PSUM.Rows(0)("TAXABLE")
            '    End If




            '    'Query = " Update PURCHASERTN set TAX_AMT=" & PTAX & " ,TAXABLE_AMT=" & PTAXABLE & ",RdOff=" & PRdOff & ", NET_AMT=" & PTotal & " where  DOC_Id= " & PDOC_ID & ""
            '    'Common.ExecuteQuery(Query, Trans)

            '    Query = " Update PURCHASERTN set TAX_AMT=" & PTAX & " ,TAXABLE_AMT=" & PTAXABLE & " where  DOC_Id= " & PDOC_ID & ""
            '    Common.ExecuteQuery(Query, Trans)


            '    Query = "SELECT TAXABLE_AMT, TAX_AMT, OTHCHGS_AMT FROM PURCHASERTN WHERE DOC_ID = " & PDOC_ID & ""
            '    Dim PRSUM As DataTable = Common.GetDataTable(Query)
            '    If PRSUM.Rows.Count > 0 Then
            '        PTAX = PRSUM.Rows(0)("TAX_AMT")
            '        PTAXABLE = PRSUM.Rows(0)("TAXABLE_AMT")
            '        POTHAMT = PRSUM.Rows(0)("OTHCHGS_AMT")
            '    End If

            '    PNETAMT = Format$((PRSUM.Rows(0)("TAX_AMT") + PRSUM.Rows(0)("TAXABLE_AMT") + PRSUM.Rows(0)("OTHCHGS_AMT")), "0.00")

            '    PTotal = Format$(Math.Round(Val(PNETAMT), 0), "0.00")
            '    PRdOff = Format$(Val(PTotal) - Val(PNETAMT), "0.00")

            '    If PRdOff = -0.5 Then
            '        PTotal = Format$(Val(PTotal) + 1, "0.00")
            '        PRdOff = "0.50"
            '    End If

            '    Query = " Update PURCHASERTN set RDOFF=" & PRdOff & " where  DOC_Id= " & PDOC_ID & ""
            '    Common.ExecuteQuery(Query, Trans)


            'Next PRecRow




            '' ''-______________________END PURCHASERTN__________________________________________________________________


            '' ''-______________________FOR WHOLESALE__________________________________________________________________
            ' ''Dim WDOC_ID As Integer = 0
            ' ''Dim WDocDtl_id As Integer = 0

            ' ''Dim WTax_Key, WTax1_Key, WTax2_Key, WTax3_Key As String
            ' ''Dim WTax_Perc, WTax1_Perc, WTax2_Perc, WTax3_Perc As Double
            ' ''Dim WTax_Amt, WTax1_Amt, WTax2_Amt, WTax3_Amt, WTaxable_amt, WNetAmtDtl, WRdOff, OthChgs As Double

            ' ''WTax_Key = "" : WTax1_Key = "" : WTax2_Key = "" : WTax3_Key = ""
            ' ''WTax_Perc = 0 : WTax1_Perc = 0 : WTax2_Perc = 0 : WTax3_Perc = 0
            ' ''WTax_Amt = 0 : WTax1_Amt = 0 : WTax2_Amt = 0 : WTax3_Amt = 0 : WTaxable_amt = 0 : WNetAmtDtl = 0 : WRdOff = 0 : OthChgs = 0



            ' ''Query = "SELECT DOC_ID,OTHCHGS_AMT FROM PACKING WHERE DOC_DT  > = '2017-07-01'"
            ' ''Dim WGSTDT As DataTable = Common.GetDataTable(Query)
            ' ''For Each WRecRow In WGSTDT.Rows
            ' ''    WDOC_ID = WRecRow("DOC_ID")
            ' ''    OthChgs = WRecRow("OTHCHGS_AMT")

            ' ''    Query = "SELECT DOCDTL_ID FROM PACKINGDTL WHERE DOC_ID = " & WDOC_ID & ""
            ' ''    Dim WDocDt As DataTable = Common.GetDataTable(Query)
            ' ''    If WDocDt.Rows.Count > 0 Then
            ' ''        WDocDtl_id = WDocDt.Rows(0)("DocDtl_id")
            ' ''    End If

            ' ''    Query = "SELECT * FROM PACKINGDTL WHERE DOC_ID=" & WDOC_ID & " AND DOCDTL_ID=" & WDocDtl_id & ""
            ' ''    Dim WGSTDTL As DataTable = Common.GetDataTable(Query)

            ' ''    For Each WRecRow1 In WGSTDTL.Rows

            ' ''        WTaxable_amt = WRecRow1("Taxable")
            ' ''        WTax_Perc = WRecRow1("TaxPerc")
            ' ''        WTax_Key = WRecRow1("Tax_Key")

            ' ''        Query = "SELECT TxTmTDS_Perc,Tax1Led_Key,Tax1Led_Perc,Tax2Led_Key,Tax2Led_Perc,Tax3Led_Key,Tax3Led_Perc FROM TaxTermsTDS WHERE TxTmTDS_Key = '" & WTax_Key & "'"
            ' ''        Dim wtax1 As DataTable = Common.GetDataTable(Query)
            ' ''        If wtax1.Rows.Count > 0 Then
            ' ''            WTax1_Key = wtax1.Rows(0)("Tax1Led_Key")
            ' ''            WTax1_Perc = wtax1.Rows(0)("Tax1Led_Perc")
            ' ''            WTax2_Key = wtax1.Rows(0)("Tax2Led_Key")
            ' ''            WTax2_Perc = wtax1.Rows(0)("Tax2Led_Perc")
            ' ''            WTax3_Key = wtax1.Rows(0)("Tax3Led_Key")
            ' ''            WTax3_Perc = wtax1.Rows(0)("Tax3Led_Perc")

            ' ''            WTax_Amt = (WTax_Perc / 100) * Format$(Val(WTaxable_amt), "0.00")

            ' ''            If WTax1_Key <> "" Then
            ' ''                WTax1_Amt = Format$(Val(WTax_Amt) / 2, "0.00")
            ' ''            Else
            ' ''                WTax1_Perc = 0
            ' ''                WTax1_Amt = 0
            ' ''            End If

            ' ''            If WTax2_Key <> "" Then
            ' ''                WTax2_Amt = Format$(Val(WTax_Amt) / 2, "0.00")
            ' ''            Else
            ' ''                WTax2_Perc = 0
            ' ''                WTax2_Amt = 0
            ' ''            End If

            ' ''            If WTax3_Key <> "" Then
            ' ''                WTax3_Amt = Format$(Val(WTax_Amt) / 2, "0.00")
            ' ''            Else
            ' ''                WTax3_Perc = 0
            ' ''                WTax3_Amt = 0
            ' ''            End If

            ' ''            WTax_Amt = Format$(Val(WTax1_Amt) + Val(WTax2_Amt) + Val(WTax3_Amt), "0.00")
            ' ''            WNetAmtDtl = Format$(Val(WTaxable_amt) + Val(WTax_Amt), "0.00")

            ' ''            Query = " Update PACKINGDTL set Tax_Key='" & WTax_Key & "',TaxPerc=" & WTax_Perc & ",Tax_Amt=" & WTax_Amt & ",Taxable=" & WTaxable_amt & ",NetAmt=" & WNetAmtDtl & "," _
            ' ''               & " Tax1_Key='" & WTax1_Key & "',Tax1Perc=" & WTax1_Perc & ",Tax1_Amt=" & WTax1_Amt & "," _
            ' ''               & " Tax2_Key='" & WTax2_Key & "',Tax2Perc=" & WTax2_Perc & ",Tax2_Amt=" & WTax2_Amt & "," _
            ' ''               & " Tax3_Key='" & WTax3_Key & "',Tax3Perc=" & WTax3_Perc & ",Tax3_Amt=" & WTax3_Amt & " WHERE DOCDTL_ID=" & WDocDtl_id & " AND DOC_ID=" & WDOC_ID & ""

            ' ''            Common.ExecuteQuery(Query, Trans)
            ' ''        End If



            ' ''    Next WRecRow1

            ' ''    Dim WTAX, WTAXABLE, WNETAMT, WTotal As Double

            ' ''    Query = "SELECT SUM(TAX_AMT) AS TAX_AMT,SUM(TAXABLE) AS TAXABLE FROM PACKINGDTL WHERE DOC_ID = " & WDOC_ID & ""
            ' ''    Dim WSUM As DataTable = Common.GetDataTable(Query)
            ' ''    If WSUM.Rows.Count > 0 Then
            ' ''        WTAX = WSUM.Rows(0)("TAX_AMT")
            ' ''        WTAXABLE = WSUM.Rows(0)("TAXABLE")
            ' ''        WNETAMT = Format$(Val(WTAX) + Val(WTAXABLE) + Val(OthChgs), "0.00")
            ' ''    End If

            ' ''    WTotal = Format$(Math.Round(Val(WNETAMT), 0), "0.00")
            ' ''    WRdOff = Format$(Val(WTotal) - Val(WNETAMT), "0.00")

            ' ''    Query = " Update PACKING set TAX_AMT=" & WTAX & " ,TAXABLE_AMT=" & WTAXABLE & ",RDOFF=" & WRdOff & ",NET_AMT= " & WTotal & " where  DOC_Id= " & WDOC_ID & ""
            ' ''    Common.ExecuteQuery(Query, Trans)

            ' ''Next WRecRow



            '-______________________FOR WHOLESALE__________________________________________________________________
            Trans.Commit()

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