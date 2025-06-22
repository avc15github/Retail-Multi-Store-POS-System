Imports System.Data.SqlClient

Public Class frmCommissionStockLevel


    Dim PurchSrId As Short = 1
    Dim EditMode, IsAdd As Boolean
    Dim DtlEditMode As Byte
    Dim Details As DataTable
    Dim WithEvents SizeDetails As DataTable
    Dim DelRow() As GridRows
    Dim RecordId As String = ""
    Dim CurrIntId As Integer
    Dim IsMainLocn, Tax1, Tax2, DtlTax As Boolean
    Dim IsMfr As Boolean
    Dim RowValChg As Boolean
    Dim InvalidCall As Boolean
    Dim NewDesign As Boolean
    Dim CurrModule As String = "ndCommissionWiseStockLevel"
    Dim PrnBarcode As String = ""
    Dim BarCdType As String = ""
    Dim MaintainStk As String = ""
    Dim AllowNegStk As String = ""
    Dim EANBarcd As String = ""
    Dim ItemCode As String = ""
    Dim blnLoading As Boolean
    Dim ChgBtnBehave As Boolean = True
    Structure GridRows
        Dim RecDtlId As Integer
        Dim Qty As Double
        Dim OldQty As Double
        Dim ProductKey As String
        Dim StyleKey As String
        Dim TypeKey As String
        Dim ShadeKey As String
        Dim SizeKey As String
        Dim LocKey As String
        Dim BrandKey As String
        Dim QualityKey As String
        Dim SeasonKey As String
        Dim PurRate As Double
        Dim MRP As Double
        Dim SuplKey As String
        Dim PrnBarcode As String
        Dim BarcodeType As String
        Dim DocNo As String
        Dim DocDt As DateTime

    End Structure

    Enum GridCols
        SrNo
        StyleName
        TypeName
        ShadeName
        SizeName
        BrandName
        Barcode
        Altbarcode
        PurNo
        PurDt
        Stock
        Mrp
        Comm

        DetailId
        RecStatus
        StyleKey
        TypeKey
        ShadeKey
        SizeKey
        BrandKey
        StkId
    End Enum

    Enum SizeGridCols
        SizeName
        Min
        Max
        ReOrder
        SizeKey
    End Enum

    Enum ImageIdx
        Add
        Edit
        Save
        Cancel
        Close
    End Enum


    Private Sub frmPurchase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'MDI.MDINaviBar.Collapsed = True

    End Sub
    Private Sub frmCommissionStockLevel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'MDI.MDINaviBar.Collapsed = False
    End Sub
    Private Sub frmCommissionStockLevel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape And grpSize.Visible = False Then
            Me.Close()
        End If
    End Sub
    Private Sub frmPurchase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grpMain.Enabled = False
        FillComboDetails()
        lblBrand.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand)
        lblArticleNo.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle)
        lblProduct.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct)
        lblSubGroup.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefSubGroup)
        lblType.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefType)
        cmbBrand.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand)
        cmbStyle.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle)
        cmbProduct.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct)
        cmbItmSubGroup.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefSubGroup)
        cmbType.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefType)
        grpSize.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefSize) & " Wise Details"

        Label7.Visible = AllowLocationStock : cmbLocation.Visible = AllowLocationStock
        cmbLocation.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefLocation)

        cmbItmSubGroup.Focus()
    End Sub
    Private Sub FormatDetailGrid(ByVal dtTable As DataTable)
        Dim tblStyle As DataGridTableStyle
        tblStyle = GridColumnCreateAndFormat.CreateTableStyle(dtTable.TableName)

        Dim colSrNo As New DataGridTextBoxColumn
        With colSrNo
            .MappingName = dtTable.Columns(GridCols.SrNo).ColumnName
            .HeaderText = "Sr"
            .Width = 35
            .NullText = 0 : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colStyle_Name As New DataGridTextBoxColumn
        With colStyle_Name
            .MappingName = dtTable.Columns(GridCols.StyleName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle)
            .Width = 125
            .NullText = ""
            .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colTypeName As New DataGridTextBoxColumn
        With colTypeName
            .MappingName = dtTable.Columns(GridCols.TypeName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefType)
            .Width = 60
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colShadeName As New DataGridTextBoxColumn
        With colShadeName
            .MappingName = dtTable.Columns(GridCols.ShadeName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefShade)
            .Width = 80
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colSizeName As New DataGridTextBoxColumn
        With colSizeName
            .MappingName = dtTable.Columns(GridCols.SizeName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefSize)
            .Width = 50
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colBrand As New DataGridTextBoxColumn
        With colBrand
            .MappingName = dtTable.Columns(GridCols.BrandName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand)
            .Width = 105
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colBarcode As New DataGridTextBoxColumn
        With colBarcode
            .MappingName = dtTable.Columns(GridCols.Barcode).ColumnName
            .HeaderText = "Barcode"
            .Width = 75
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colAltBarcode As New DataGridTextBoxColumn
        With colAltBarcode
            .MappingName = dtTable.Columns(GridCols.Altbarcode).ColumnName
            .HeaderText = "Alt Barcode"
            .Width = 90
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With


        Dim colPurNo As New DataGridTextBoxColumn
        With colPurNo
            .MappingName = dtTable.Columns(GridCols.PurNo).ColumnName
            .HeaderText = "Pur No."
            .Width = 60
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colPurDt As New DataGridTextBoxColumn
        With colPurDt
            .MappingName = dtTable.Columns(GridCols.PurDt).ColumnName
            .HeaderText = "Pur Dt."
            .Width = 75
            .NullText = "" : .ReadOnly = True
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colStock As New DataGridTextBoxColumn
        With colStock
            .MappingName = dtTable.Columns(GridCols.Stock).ColumnName
            .HeaderText = "Stock."
            .Width = 50
            .NullText = 0 : .ReadOnly = True
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With


        Dim colMrp As New DataGridTextBoxColumn
        With colMrp
            .MappingName = dtTable.Columns(GridCols.Mrp).ColumnName
            .HeaderText = "MRP."
            .Width = 53
            .NullText = 0 : .ReadOnly = True
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With

        Dim colComm As New DataGridTextBoxColumn
        With colComm
            .MappingName = dtTable.Columns(GridCols.Comm).ColumnName
            .HeaderText = "Comm."
            .Width = 60
            .NullText = 0 : .ReadOnly = False
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With

        Dim colDetailId As New DataGridTextBoxColumn
        With colDetailId
            .MappingName = dtTable.Columns(GridCols.DetailId).ColumnName
            .Width = 0
            .NullText = 0
            .Alignment = HorizontalAlignment.Right
        End With

        Dim colRecStatus As New DataGridTextBoxColumn
        With colRecStatus
            .MappingName = dtTable.Columns(GridCols.RecStatus).ColumnName
            .HeaderText = ""
            .Width = 0
            .NullText = 0
        End With

        Dim colStyle_Key As New DataGridTextBoxColumn
        With colStyle_Key
            .MappingName = dtTable.Columns(GridCols.StyleKey).ColumnName
            .Width = 0
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colType_Key As New DataGridTextBoxColumn
        With colType_Key
            .MappingName = dtTable.Columns(GridCols.TypeKey).ColumnName
            .Width = 0
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colShade_Key As New DataGridTextBoxColumn
        With colShade_Key
            .MappingName = dtTable.Columns(GridCols.ShadeKey).ColumnName
            .Width = 0
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colSize_Key As New DataGridTextBoxColumn
        With colSize_Key
            .MappingName = dtTable.Columns(GridCols.SizeKey).ColumnName
            .Width = 0
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colBrand_Key As New DataGridTextBoxColumn
        With colBrand_Key
            .MappingName = dtTable.Columns(GridCols.BrandKey).ColumnName
            .Width = 0
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colStkId As New DataGridTextBoxColumn
        With colStkId
            .MappingName = dtTable.Columns(GridCols.StkId).ColumnName
            .Width = 0
            .NullText = 0
            .Alignment = HorizontalAlignment.Left
        End With


        tblStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {colSrNo, colStyle_Name, colTypeName, colShadeName, colSizeName, colBrand, colBarcode, colAltBarcode, colPurNo, colPurDt, colStock, colMrp, colComm, colDetailId, colRecStatus, colStyle_Key, colType_Key, colShade_Key, colSize_Key, colBrand_Key, colStkId})
        colSrNo = Nothing : colStyle_Name = Nothing : colTypeName = Nothing : colShadeName = Nothing : colSizeName = Nothing : colBrand = Nothing
        colPurNo = Nothing : colPurDt = Nothing : colStock = Nothing : colMrp = Nothing : colComm = Nothing : colDetailId = Nothing : colRecStatus = Nothing
        colStyle_Key = Nothing : colType_Key = Nothing : colShade_Key = Nothing : colSize_Key = Nothing : colBrand_Key = Nothing : colStkId = Nothing : colBarcode = Nothing
        colAltBarcode = Nothing

        dtgDetails.TableStyles.Clear()
        dtgDetails.TableStyles.Add(tblStyle)
    End Sub
    Private Sub FillComboDetails()
        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select ITEMSUBGRP_KEY, ITEMSUBGRP_NAME " _
               & " From ITEMSUBGRP Where Status = '1' And ItemSubGrp_Name <> '' " _
               & BranchFilter _
               & " Order By ITEMSUBGRP_Name"
            Common.FillCombo2(Query, cmbItmSubGroup, "ITEMSUBGRP_NAME", "ITEMSUBGRP_KEY")


            Query = "Select '' TYPE_KEY, '' TYPE_NAME " _
               & " Union All " _
               & " Select Type.TYPE_KEY, TYPE_NAME  " _
               & " From Type  Where Status = '1' And TYPE_NAME <> '' " _
               & BranchFilter _
               & " Order By TYPE_NAME"
            Dim dttyp As DataTable = Common.GetDataTableWithAll(Query)

            With cmbType
                .DataSource = dttyp
                .DisplayMember = "TYPE_NAME"
                .ValueMember = "TYPE_KEY"
            End With



            Query = "Select '' SHADE_KEY, '' SHADE_NAME " _
                & " Union All " _
                & " Select SHADE_KEY, SHADE_NAME " _
                & " From Shade Where Status = '1' And Shade_Name <> '' " _
                & BranchFilter _
                & " Order By Shade_Name"
            Dim dtPrd As DataTable = Common.GetDataTableWithAll(Query)

            With cmbShade
                .DataSource = dtPrd
                .DisplayMember = "SHADE_NAME"
                .ValueMember = "SHADE_KEY"
            End With

            Query = "Select '' LOC_KEY, '' LOC_NAME " _
                & " Union All " _
                & "Select LOC_KEY, LOC_NAME " _
               & " From Location Where Status = '1' And Loc_Name <> '' " _
               & BranchFilter _
               & " Order By Loc_Name"
            Common.FillCombo2(Query, cmbLocation, "LOC_NAME", "LOC_KEY")


            cmbFormat.Properties.Items.Add("Format1.rpt")
            cmbFormat.Properties.Items.Add("Format2.rpt")
            cmbFormat.Properties.Items.Add("Format3.rpt")
            cmbFormat.Properties.Items.Add("Format4.rpt")

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProduct.KeyDown

        MoveToNextControl(e)
    End Sub


    Private Sub cmbProduct_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProduct.SelectedValueChanged
        If cmbProduct.SelectedIndex = -1 Then Exit Sub

        cmbStyle.DataSource = Nothing : cmbStyle.Text = "" : cmbType.DataSource = Nothing : cmbType.Text = "" : cmbBrand.DataSource = Nothing : cmbBrand.Text = ""

        Query = " Select Distinct  Brand.BRAND_KEY, Brand.BRAND_NAME " _
        & " From Brand Left Join Style on Brand.Brand_Key=Style.Brand_Key  Where  Style.Status = '1' And Brand_Name <> '' " _
        & " and Style.Item_Key ='" & cmbProduct.SelectedValue & "'" _
         & " Order By Brand_Name"

        Dim dtPrd As DataTable = Common.GetDataTableWithAll(Query)

        With cmbBrand
            .DataSource = dtPrd
            .DisplayMember = "BRAND_NAME"
            .ValueMember = "BRAND_KEY"
        End With

        If cmbBrand.Items.Count > 0 Then
            cmbBrand.SelectedIndex = 0
        End If

    End Sub

    Private Sub DisplayGridHeaders()
        Dim Grid As New GridColumnCreateAndFormat("PurDetails")

        With Grid
            .AddColumn("Sr..", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 40, "Sr.", , True)
            .AddColumn("StyleName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 100, GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle), , True)
            .AddColumn("TypeName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 60, GetSysCaptionAsPerId(SystemCaptionIdx.DefType), , True)
            .AddColumn("ShadeName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, GetSysCaptionAsPerId(SystemCaptionIdx.DefShade), , True)
            .AddColumn("SizeName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 50, GetSysCaptionAsPerId(SystemCaptionIdx.DefSize), , True)
            .AddColumn("BrandName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand), , True)

            .AddColumn("Barcode", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, "Barcode", , True)
            .AddColumn("Altbarcode", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, "Alt Barcode", , True)

            .AddColumn("PurNo", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, "Pur. No", , True)
            .AddColumn("PurDt", GridColumnCreateAndFormat.enmTypeIdx.DateTimeType, 80, "Pur. Dt", , True)
            .AddColumn("Stock", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 80, "Stock.", , True)

            .AddColumn("Mrp", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 100, "MRP.", , True)
            .AddColumn("Comm", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 100, "Comm.", , False)

            .AddColumn("DetailId", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "", , True)
            .AddColumn("RecStatus", GridColumnCreateAndFormat.enmTypeIdx.ByteType, 0, "", , True)
            .AddColumn("StyleKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "", , True)
            .AddColumn("TypeKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "", , True)
            .AddColumn("ShadeKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "", , True)
            .AddColumn("SizeKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "", , True)
            .AddColumn("BrandKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "", , True)
            .AddColumn("StkId", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 0, "", , True)

            .AddColumnToTable()
            Details = .GetTable
            Details.DefaultView.AllowNew = False
            Details.DefaultView.AllowEdit = True
            Details.DefaultView.AllowDelete = False

            dtgDetails.DataSource = Details
            .DisplayGridHeaders(Details, dtgDetails, False)

        End With
    End Sub

    Private Sub btnDtlAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbProduct.SelectedIndex = -1 Or cmbProduct.Text.Trim.Length = 0 Then
            MsgBox(cmbProduct.Tag & c_BlankMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbProduct.Focus()
            Exit Sub
        End If

        'grpMain.Enabled = False
        dtgDetails.Enabled = False
        SizeDetails = Nothing
        dtgSize.DataSource = Nothing
        DisplaySizeGridHeaders()
        NewDesign = True

        DtlEditMode = 1
    End Sub

    'Public Sub AddRecord() Implements IButtonProcs.AddRecord
    '    If cmbItmSubGroup.SelectedIndex = -1 Or cmbItmSubGroup.Text = "" Then
    '        MsgBox("Invalid SubGroup specified !", MsgBoxStyle.Exclamation)
    '        cmbItmSubGroup.Focus()
    '        Exit Sub
    '    End If

    '    If cmbProduct.SelectedIndex = -1 Or cmbProduct.Text = "" Then
    '        MsgBox("Invalid Product specified !", MsgBoxStyle.Exclamation)
    '        cmbProduct.Focus()
    '        Exit Sub
    '    End If


    '    grpMain.Enabled = False

    '    ReDim DelRow(0)
    '    lnkPrintBarcode.Enabled = False

    '    ChgBtnBehave = False
    '    EditMode = False
    '    IsAdd = True

    'End Sub

    Private Sub txtPurRt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)


        'CalcMarkUp(False)
        'CalcMarkDown(False)

        'CalcMarkUp(True)
        'CalcMarkDown(True)

    End Sub



    Private Function GetPurchaseRateCode(ByVal PurRate As Double, ByVal sqlTrans As SqlTransaction) As String
        If PurRate = 0 Then Return ""

        Query = "Select RateCd_Id, RateCd_Name " _
            & " From RateCode " _
            & " Where RateCd_Name <> ''"
        Dim RateCode As DataTable = Common.GetDataTable(Query, sqlTrans)

        Dim i As Byte
        Dim PurRateString As String = PurRate.ToString
        Dim NewPurRateCode As String = ""
        Dim CurrId As String = ""
        Dim RecRow As DataRow

        For i = 1 To Len(PurRateString)
            If Mid$(PurRateString, i, 1) = "." Then
                For Each RecRow In RateCode.Rows
                    If RecRow("RateCd_Id") = "Dec" Then
                        NewPurRateCode &= (RecRow("RateCd_Name") & "")
                        Exit For
                    End If
                Next RecRow
            Else
                CurrId = Mid$(PurRateString, i, 1)

                For Each RecRow In RateCode.Rows
                    If RecRow("RateCd_Id") = CurrId Then
                        NewPurRateCode &= (RecRow("RateCd_Name") & "")
                        Exit For
                    End If
                Next RecRow
            End If
        Next i
        RateCode = Nothing

        Return NewPurRateCode
    End Function

    Private Sub btnDtlDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If dtgDetails.CurrentRowIndex = -1 Then Exit Sub
        If MsgBox("Delete selected detail ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Try
            With dtgDetails
                'If MaintainProductStock(.Item(.CurrentRowIndex, GridCols.ProductKey), Nothing) _
                '    And Not CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenAllowNegativeStk))) Then

                '    If StockIsGoingNegative(.Item(.CurrentRowIndex, GridCols.ProductKey), .Item(.CurrentRowIndex, GridCols.StyleKey), .Item(.CurrentRowIndex, GridCols.TypeKey), .Item(.CurrentRowIndex, GridCols.ShadeKey), .Item(.CurrentRowIndex, GridCols.SizeKey), .Item(.CurrentRowIndex, GridCols.LocationKey), .Item(.CurrentRowIndex, GridCols.OldQty), Nothing) Then
                '        MsgBox("Stock is going negative for current record ?", MsgBoxStyle.Exclamation)
                '        Exit Sub
                '    End If
                'End If

                If .Item(.CurrentRowIndex, GridCols.DetailId) > 0 Then
                    ReDim Preserve DelRow(UBound(DelRow) + 1)

                    DelRow(UBound(DelRow) - 1).RecDtlId = .Item(.CurrentRowIndex, GridCols.DetailId)
                    DelRow(UBound(DelRow) - 1).ShadeKey = .Item(.CurrentRowIndex, GridCols.ShadeKey)
                    DelRow(UBound(DelRow) - 1).SizeKey = .Item(.CurrentRowIndex, GridCols.SizeKey)

                End If
            End With

            Details.Rows.RemoveAt(dtgDetails.CurrentRowIndex)
            Details.AcceptChanges()


            ReCalcSerial(False)

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        End Try
    End Sub
    Private Sub ClearTextboxes()
        'cmbItmSubGroup.SelectedIndex = -1 : cmbStyle.SelectedIndex = -1 : cmbType.SelectedIndex = -1 : cmbBrand.SelectedIndex = -1

    End Sub

    Private Sub btnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewRecordId = "" : frmType.Type = True
        If IsNothing(cmbType.Value) Or cmbType.Text.Trim.Length = 0 Then
            NewRecordId = ""
        Else
            NewRecordId = cmbType.Value
        End If

        Dim frmType1 As New frmType
        frmType1.MdiParent = Me.MdiParent
        frmType1.Tag = "TYPE"
        frmType1.Show()
    End Sub

    Private Sub btnType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cmbType.Focus()
    End Sub


    Private Sub btnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewRecordId = "" : frmBrand.Brand = True
        If IsNothing(cmbBrand.Value) Or cmbBrand.Text.Trim.Length = 0 Then
            NewRecordId = ""
        Else
            NewRecordId = cmbBrand.Value
        End If

        Dim frmBrand1 As New frmBrand
        frmBrand1.MdiParent = Me.MdiParent
        frmBrand1.Tag = "BRAND"
        frmBrand1.Show()
    End Sub



    Private Sub dtpDocDt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChlnNo.KeyDown, txtPurDocNo.KeyDown, cmbItmSubGroup.KeyDown, dtpPurDocDt.KeyDownEvent, dtpChlnDate.KeyDownEvent, cmbStyle.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Function StockIsGoingNegative(ByVal Product As String, ByVal Style As String, ByVal Type As String, ByVal Shade As String, ByVal Size As String, ByVal Location As String, ByVal Qty As Double, ByVal sqlTrans As SqlTransaction) As Boolean
        Query = "Select ClQty - " & Qty & " From ItemStock " _
            & " Where Item_Key ='" & Product & "'" _
            & " And Style_Key = '" & Style & "'" _
            & " And Type_Key = '" & Type & "'" _
            & " And Shade_Key  ='" & Shade & "'" _
            & " And ItemSize_Key = '" & Size & "'" _
            & " And Loc_Key = '" & Location & "'" _
            & " And CoBr_Id = '" & SelBranchId & "'"

        '    & " And FcYr_Id = '" & SelYearId & "'"
        Dim Stock As DataTable = Common.GetDataTable(Query, sqlTrans)

        If Stock.Rows.Count > 0 Then
            Return (Stock.Rows(0)(0) < 0)
        End If

        Return False
    End Function

    Private Sub Search_SearchAndClose(ByRef CurrId As Integer) Handles Search.SearchAndClose

        Dim RowIdx As Integer = -1

        Query = "Select Item_Key From ItemWiseStkLevel " _
                & " Where Doc_Id = " & CurrId
        Dim Item_Key As String = Common.ExecuteScalar(Query)


        Search.Visible = False
        Search.SendToBack()
    End Sub

    Private Sub cmbItmSubGroup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItmSubGroup.SelectionChanged
        If cmbItmSubGroup.SelectedIndex = -1 Then Exit Sub

        If chkBarcode.Checked = False Then
            dtgDetails.DataSource = Nothing
        End If

        cmbProduct.DataSource = Nothing : cmbProduct.Text = "" : cmbStyle.DataSource = Nothing : cmbStyle.Text = "" : cmbType.DataSource = Nothing : cmbType.Text = ""
        cmbBrand.DataSource = Nothing : cmbBrand.Text = ""
        Query = "Select ITEM_KEY, ITEM_NAME " _
            & " From Item Where Status = '1' " _
            & " And ItemSubGrp_Key = '" & cmbItmSubGroup.SelectedItem.DataValue & "'" _
            & BranchFilter _
            & " Order By Item_Name"
        Common.FillCombo2(Query, cmbProduct, "ITEM_NAME", "ITEM_KEY")


        If cmbProduct.Items.Count > 0 Then
            cmbProduct.SelectedIndex = 0
        End If



    End Sub


    Private Function PurchaseAdded() As Boolean
        Query = "Select IsNull(Count(Doc_Key), 0) " _
            & " From Purchase " _
            & " Where Doc_Key <> '' " _
            & " And CoBr_Id = '" & SelBranchId & "'" _
            & " And FcYr_Id = '" & SelYearId & "'"
        Dim RecCount As Integer = CType(Common.ExecuteScalar(Query), Integer)

        Return (RecCount > 0)
    End Function

    Private Function MaintainProductStock(ByVal ItemKey As String, ByVal sqlTrans As SqlTransaction) As Boolean
        If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMaintainStock))) Then Return True

        Query = "Select Maintain_Stk From Item Where Item_Key = '" & ItemKey & "'"
        Dim MaintainStk As Boolean = CType(Common.ExecuteScalar(Query, sqlTrans), Boolean)

        Return MaintainStk
    End Function

    Private Function MaintainBarCode(ByVal ItemKey As String) As Char
        Query = "Select Barcode_Type From Item Where Item_Key = '" & ItemKey & "'"
        Dim BarcodeType As Char = Common.ExecuteScalar(Query)

        Return BarcodeType
    End Function

    Private Sub DisplaySizeGridHeaders()
        Dim Grid As New GridColumnCreateAndFormat("SizeDetails")

        With Grid
            .AddColumn("SizeName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 50, "Size")
            .AddColumn("Min", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 60, "Min.", , False)
            .AddColumn("Max", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 60, "Max.", , False)
            .AddColumn("ReOrder", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 70, "ReOrder.", , False)
            .AddColumn("SizeKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            .AddColumnToTable()
            SizeDetails = .GetTable

            With SizeDetails.DefaultView
                .AllowNew = False
                .AllowDelete = False
            End With

            dtgSize.DataSource = SizeDetails
            .DisplayGridHeaders(SizeDetails, dtgSize, False, , , True)
        End With
    End Sub


    Private Function SizeCreatedForStyle(ByVal SizeKey As String) As Boolean
        'Dim RecRow As DataRow

        'For Each RecRow In Details.Rows
        '    If RecRow(GridCols.SizeKey) = SizeKey _
        '        And RecRow(GridCols.StyleName) = cmbStyle.Text _
        '        And RecRow(GridCols.TypeKey) = cmbType.Value And RecRow(GridCols.ShadeKey) = cmbShade.Value And RecRow(GridCols.BrandKey) = cmbBrand.Value Then

        '        Return True
        '    End If
        'Next RecRow

        'Return False
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If BtnSave.Text.ToUpper = "&ADD" Then Exit Function

        Dim rowNumber, rowCount, colNumber As Integer
        If keyData = Keys.Return Then
            If Me.ActiveControl.Parent Is CType(dtgDetails, DataGrid) Or Me.ActiveControl Is CType(dtgDetails, DataGrid) Then
                rowNumber = dtgDetails.CurrentCell.RowNumber
                colNumber = dtgDetails.CurrentCell.ColumnNumber
                rowCount = CType(dtgDetails.DataSource, DataTable).Rows.Count

                If colNumber < GridCols.Comm Then
                    colNumber += 1
                Else


                    If rowNumber + 1 < rowCount - 1 Then
                        rowNumber += 1
                    ElseIf rowNumber = rowCount - 1 Then
                        BtnSave.Focus()
                        Exit Function
                    Else
                        rowNumber = rowCount - 1
                    End If
                End If

                dtgDetails.CurrentCell = New DataGridCell(rowNumber, colNumber)
            End If
        End If
    End Function


    Private Sub GetProductDetails(ByVal ProdKey As String, ByRef PrnBarcode As String, ByRef BarCdType As String, ByRef MaintainStk As String, ByRef AllowNegStock As String, ByRef EANBarcode As String, ByRef ItemCode As String)
        Query = "Select Print_Barcode, BarCode_Type, Maintain_Stk, Allow_Neg_Stk, EAN_Barcode, Item_Code " _
            & " From Item " _
            & " Where Item_Key = '" & ProdKey & "'"
        Dim ProdDtls As DataTable = Common.GetDataTable(Query)

        If ProdDtls.Rows.Count > 0 Then
            Dim RecRow As DataRow = ProdDtls.Rows(0)

            PrnBarcode = RecRow("Print_Barcode") & ""
            BarCdType = RecRow("Barcode_Type") & ""
            MaintainStk = RecRow("Maintain_Stk") & ""
            AllowNegStock = RecRow("Allow_Neg_Stk") & ""
            EANBarcode = RecRow("EAN_Barcode") & ""
            ItemCode = RecRow("Item_Code") & ""
        End If
        ProdDtls = Nothing
    End Sub


    Private Sub DisplayStockDetails()
        If cmbProduct.SelectedIndex = -1 Then Exit Sub
        Dim dtQty As DataTable
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Brand As String = ""
            Dim Size As String = ""
            Dim Shade As String = ""
            Dim Type As String = ""
            Dim Location As String = ""

            Dim strFilter As String = ""


            If cmbStyle.Text = "( ALL )" Then
                strFilter = ""
            Else
                strFilter = " AND I.Style_Key = '" & StyleKey() & "'"
            End If
            '--------23-06-2016---------
            If cmbType.Text = "( ALL )" Then
                Type = ""
            Else
                Type = " AND I.Type_Key = " & cmbType.Value & ""
            End If

            If cmbBrand.Text = "( ALL )" Then
                Brand = ""
            Else
                Brand = " AND I.Brand_Key = " & cmbBrand.Value & ""
            End If

            If cmbSize.Text = "( ALL )" Then
                Size = ""
            Else
                Size = " AND I.ItemSize_Key = " & cmbSize.Value & ""
            End If

            If cmbShade.Text = "( ALL )" Then
                Shade = ""
            Else
                Shade = " AND I.Shade_Key = " & cmbShade.SelectedValue & ""
            End If

            If cmbLocation.Text = "" Then
                Location = ""
            Else
                Location = " And I.Loc_Key = '" & cmbLocation.Value & "'"
            End If

            If chkBarcode.Checked Then
                Query = "Select row_number() OVER (ORDER BY Stk_Id) As SrNo,Style.Style_Code, Type_Name,Shade.Shade_Name,ItemSize.Size_Name, Brand_Name,I.Barcode,I.AltBarcode1,I.LastPurNo,I.LastPurDt,I.ClQty,I.MRP,I.Comm, " _
                                    & " 0 as DetailId,0 as RecStatus,I.Style_Key,I.Type_Key,I.Shade_Key, I.ItemSize_Key ,I.Brand_Key,I.Stk_Id " _
                                    & " From ItemStock as I Left Join Item On I.Item_Key = Item.Item_Key " _
                                    & " Left Join Style On I.Style_Key = Style.Style_Key " _
                                    & " Left Join Type On I.Type_Key = Type.Type_Key " _
                                    & " Left Join Shade On I.Shade_Key = Shade.Shade_Key " _
                                    & " Left Join ItemSize On I.ItemSize_Key = ItemSize.ItemSize_Key " _
                                    & " Left Join Brand On Style.Brand_Key = Brand.Brand_Key " _
                                    & " Where (I.Barcode = '" & txtBarcode.Text & "' Or I.AltBarcode1 = '" & txtBarcode.Text & "' " _
                                    & " Or I.AltBarcode2 = '" & txtBarcode.Text & "')" _
                                    & " And I.ClQty >= " & Val(txtQty.Text) & " " _
                                    & " And I.CoBr_Id = '" & SelBranchId & "' " & Location
                If dtgDetails.CurrentRowIndex = -1 Then
                    DisplayGridHeaders()
                    Details = Common.GetDataTable(Query)
                    dtgDetails.DataSource = Details
                    FormatDetailGrid(Details)
                    GoTo F
                End If

            Else
                Query = "Select row_number() OVER (ORDER BY Stk_Id) As SrNo,Style.Style_Code, Type_Name,Shade.Shade_Name,ItemSize.Size_Name, Brand_Name,I.Barcode,I.AltBarcode1,I.LastPurNo,I.LastPurDt,I.ClQty,I.MRP,I.Comm, " _
                    & " 0 as DetailId,0 as RecStatus,I.Style_Key,I.Type_Key,I.Shade_Key, I.ItemSize_Key ,I.Brand_Key,I.Stk_Id " _
                    & " From ItemStock as I Left Join Item On I.Item_Key = Item.Item_Key " _
                    & " Left Join Style On I.Style_Key = Style.Style_Key " _
                    & " Left Join Type On I.Type_Key = Type.Type_Key " _
                    & " Left Join Shade On I.Shade_Key = Shade.Shade_Key " _
                    & " Left Join ItemSize On I.ItemSize_Key = ItemSize.ItemSize_Key " _
                    & " Left Join Brand On Style.Brand_Key = Brand.Brand_Key " _
                    & " Where I.Item_Key = '" & cmbProduct.SelectedValue & "'  " _
                    & " And I.ClQty >= " & Val(txtQty.Text) & " " & Location _
                    & " And I.CoBr_Id = '" & SelBranchId & "'" & strFilter & Brand & Shade & Size

                DisplayGridHeaders()
                Details = Common.GetDataTable(Query)
            End If




            If chkBarcode.Checked = False Then
                dtgDetails.DataSource = Details
                FormatDetailGrid(Details)
            Else

                Dim drNewRow As DataRow = Nothing

                dtQty = Common.GetDataTable(Query)

                If dtQty.Rows.Count > 0 Then
                    drNewRow = Details.NewRow
                    drNewRow(GridCols.StyleName) = dtQty.Rows(0).Item("Style_Code")
                    drNewRow(GridCols.TypeName) = dtQty.Rows(0).Item("Type_Name")
                    drNewRow(GridCols.ShadeName) = dtQty.Rows(0).Item("Shade_Name")
                    drNewRow(GridCols.SizeName) = dtQty.Rows(0).Item("Size_Name")
                    drNewRow(GridCols.BrandName) = dtQty.Rows(0).Item("Brand_Name")
                    drNewRow(GridCols.Barcode) = dtQty.Rows(0).Item("Barcode")
                    drNewRow(GridCols.Altbarcode) = dtQty.Rows(0).Item("AltBarcode1")
                    drNewRow(GridCols.PurNo) = dtQty.Rows(0).Item("LastPurNo")
                    drNewRow(GridCols.PurDt) = dtQty.Rows(0).Item("LastPurDt")
                    drNewRow(GridCols.Stock) = dtQty.Rows(0).Item("ClQty")
                    drNewRow(GridCols.Mrp) = dtQty.Rows(0).Item("MRP")
                    drNewRow(GridCols.Comm) = dtQty.Rows(0).Item("Comm")

                    drNewRow(GridCols.DetailId) = 0
                    drNewRow(GridCols.RecStatus) = 0
                    drNewRow(GridCols.StyleKey) = dtQty.Rows(0).Item("Style_Key")
                    drNewRow(GridCols.TypeKey) = dtQty.Rows(0).Item("Type_Key")
                    drNewRow(GridCols.ShadeKey) = dtQty.Rows(0).Item("Shade_Key")
                    drNewRow(GridCols.SizeKey) = dtQty.Rows(0).Item("ItemSize_Key")
                    drNewRow(GridCols.BrandKey) = dtQty.Rows(0).Item("Brand_Key")
                    drNewRow(GridCols.StkId) = dtQty.Rows(0).Item("Stk_Id")

                    Details.Rows.Add(drNewRow)


                End If


                If Details.Rows.Count > 0 Then
                    ReCalcSerial(False)
                End If
            End If
F:


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetUnit(ByVal Product As String) As String
        Query = "Select IsNull(Unit_Key, '') From Item " _
            & " Where Item_Key = '" & Product & "'"
        Dim Unit As String = Common.ExecuteScalar(Query)

        Return Unit
    End Function

    Private Sub GetConvUnit(ByVal Product As String, ByRef ConvUnit As String, ByRef ConvQty As Decimal)
        Query = "Select IsNull(ConvUnit_Key, '') ConvUnit_Key, Conv_Qty " _
            & " From Item " _
            & " Where Item_Key = '" & Product & "'"
        Dim Unit As DataTable = Common.GetDataTable(Query)

        If Unit.Rows.Count > 0 Then
            ConvUnit = Unit.Rows(0)("ConvUnit_Key")
            ConvQty = Unit.Rows(0)("Conv_Qty")
        End If
    End Sub
    Public Sub CloseSearch()

    End Sub
    Private Sub cmbStyle_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyle.SelectedValueChanged
        If cmbStyle.SelectedIndex = -1 Then Exit Sub

        '   cmbType.DataSource = Nothing : cmbType.Text = ""


        'Query = "Select Distinct Type.TYPE_KEY, TYPE_NAME " _
        '    & " From Style Inner Join Type On Style.Type_Key = Type.Type_Key " _
        '    & " Where Type.Status = '1' " _
        '    & " And Style_Code = '" & cmbStyle.Value & "' " _
        '    & " Order By Type_Name"
        'Common.FillCombo2(Query, cmbType, "TYPE_NAME", "TYPE_KEY")

        'If cmbType.Items.Count > 0 Then
        '    cmbType.SelectedIndex = 0
        'End If


        Query = "Select '' TYPE_KEY, '' TYPE_NAME " _
           & " Union All " _
           & " Select Type.TYPE_KEY, TYPE_NAME  " _
           & " From Type  Where Status = '1' And TYPE_NAME <> '' " _
           & BranchFilter _
           & " Order By TYPE_NAME"
        Dim dttyp As DataTable = Common.GetDataTableWithAll(Query)

        With cmbType
            .DataSource = dttyp
            .DisplayMember = "TYPE_NAME"
            .ValueMember = "TYPE_KEY"
        End With

        If cmbType.Items.Count > 0 Then
            cmbType.SelectedIndex = 0
        End If

        cmbType_SelectionChanged(cmbType, Nothing)







        cmbSize.DataSource = Nothing : cmbSize.Text = ""
        If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSizeWiseRate))) Then
            Dim Style_Key As String = StyleKey()
            Query = "Select StyleSize.ItemSize_Key ITEMSIZE_KEY, ItemSize.Size_Name SIZE_NAME " _
                & " from StyleSize Left Join ItemSize On ItemSize.ItemSize_Key = StyleSize.ItemSize_Key " _
                & " Where StyleSize.Item_Key = '" & cmbProduct.SelectedValue & "'" _
                & " And StyleSize.Style_Key = '" & Style_Key & "'" _
                & " And StyleSize.CoBr_Id = '" & SelBranchId & "'" _
                & " And ItemSize.Status = '1'  " _
                & " Order By SeqNo"
        Else
            Query = "Select ITEMSIZE_KEY, SIZE_NAME " _
            & " From ItemSize Where Status = '1' And Item_Key = '" & cmbProduct.SelectedValue & "' " _
            & BranchFilter _
            & " Order By SeqNo"
        End If
        Dim dtPrd As DataTable = Common.GetDataTableWithAll(Query)
        With cmbSize
            .DataSource = dtPrd
            .DisplayMember = "SIZE_NAME"
            .ValueMember = "ITEMSIZE_KEY"
        End With

        If cmbSize.Items.Count > 0 Then
            cmbSize.SelectedIndex = 0
        End If



    End Sub

    Private Sub DisplayStyleDetails()

        Dim strFilter As String = ""

        If cmbStyle.Text = "( ALL )" Then
            strFilter = ""
        Else
            strFilter = "AND  Style.Style_Key = '" & StyleKey() & "'"
        End If

        NewDesign = True

        Dim Style_Key As String = StyleKey()


        If cmbStyle.SelectedIndex = -1 Then Exit Sub



    End Sub

    Private Sub txtStyleCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            MoveToNextControl(e)
        End If

    End Sub



    Private Function StyleKey() As String
        Query = "Select Style_Key " _
            & " From Style " _
            & " Where Style_Code = '" & ReplaceApostrophe(cmbStyle.Text) & "'" _
            & " And Item_Key = '" & cmbProduct.SelectedValue & "'" _
            & " And CoBr_Id = '" & SelBranchId & "'"

        If cmbType.SelectedIndex <> -1 Then
            Query = Query + " And Type_Key = '" & cmbType.Value & "'"
        End If

        Dim StyleData As DataTable = Common.GetDataTable(Query)
        Dim Style As String = ""

        If StyleData.Rows.Count > 0 Then
            Return StyleData.Rows(0)(0) & ""


        End If

        StyleData = Nothing
        Return ""
    End Function



    Private Function MaintainStyle() As Boolean
        Query = "Select Maintain_Style " _
            & " From Item " _
            & " Where Item_Key ='" & cmbProduct.SelectedItem.DataValue & "'"
        Dim MaintStyle As Boolean = CBool(Val(Common.ExecuteScalar(Query)))

        Return MaintStyle
    End Function

    Private Sub cmbStyle_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbStyle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyle.Validated
        If cmbStyle.SelectedIndex = -1 Then cmbStyle.SelectedIndex = 0
    End Sub

    Private Sub cmbType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbType.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub cmbType_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectionChanged
        DisplayStyleDetails()
        'DisplayStockDetails()
    End Sub

    Private Sub cmbType_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.Validated
        If cmbType.SelectedIndex = -1 Then cmbType.SelectedIndex = 0
    End Sub

    Private Sub cmbBrand_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBrand.Validated
        If cmbBrand.SelectedIndex = -1 Then cmbBrand.SelectedIndex = 0
    End Sub

    Private Sub txtMRP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'CalcMarkUp(True)  04/06/2012
        'CalcMarkDown(False)
        'CalcMarkDown(True)

    End Sub


    Private Sub btnStyle_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        NewRecordId = "" : frmStyle.Style = True
        If IsNothing(cmbProduct.SelectedValue) Or cmbProduct.Text.Trim.Length = 0 Then
            NewRecordId = ""
        Else
            NewRecordId = cmbProduct.SelectedValue
        End If

        Dim frmStyle1 As New frmStyle
        frmStyle1.MdiParent = Me.MdiParent
        frmStyle1.Tag = "STYLE"
        frmStyle1.Show()
    End Sub

    Private Sub btnStyle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cmbStyle.Focus()
    End Sub

    Private Sub CreateCategoryWiseRate(ByVal StockId As Integer, ByVal StyleKey As String, ByVal PurDtlId As Integer, ByVal MRP As Double, ByVal SP As Double, ByVal PurRate As Double, Optional ByVal sqlTrans As SqlTransaction = Nothing)
        Query = "Select * From RateCat Where RateCat_Id > 0"
        Dim RateCat As DataTable = Common.GetDataTable(Query, sqlTrans)
        Dim RecRow As DataRow
        Dim MRPCatRt, PurCatRt, SPCatRt As Double

        For Each RecRow In RateCat.Rows
            If RecRow("MkUpPerc") > 0 Then
                PurCatRt = PurRate + (PurRate * (RecRow("MkUpPerc") / 100))
            ElseIf RecRow("MkUpRs") > 0 Then
                PurCatRt = PurRate + RecRow("MkUpRs")
            Else
                PurCatRt = PurRate
            End If

            If RecRow("MkUpPerc_MRP") > 0 Then
                MRPCatRt = MRP + (MRP * (RecRow("MkUpPerc_MRP") / 100))
            ElseIf RecRow("MkUpRs_MRP") > 0 Then
                MRPCatRt = MRP + RecRow("MkUpRs_MRP")
            Else
                MRPCatRt = MRP
            End If

            If RecRow("MkUpPerc_SP") > 0 Then
                SPCatRt = SP + (SP * (RecRow("MkUpPerc_SP") / 100))
            ElseIf RecRow("MkUpRs_SP") > 0 Then
                SPCatRt = SP + RecRow("MkUpRs_SP")
            Else
                SPCatRt = SP
            End If


            If PurDtlId = 0 Then
                Query = "Select IsNull(Count(*), 0) " _
                    & " From StkCatRt " _
                    & " Where PurDtl_Id = " & PurDtlId _
                    & " And RateCat_Id = " & RecRow("RateCat_Id") & " And Stk_Id = " & StockId
                Dim RateCategory As Byte = CType(Common.ExecuteScalar(Query, sqlTrans), Byte)

                If RateCategory > 0 Then
                    Query = "Update StkCatRt Set MRP = " & MRPCatRt _
                        & ", SP = " & SPCatRt & ", PurRt = " & PurCatRt _
                        & " Where PurDtl_Id = " & PurDtlId _
                        & " And RateCat_Id = " & RecRow("RateCat_Id") & " And Stk_Id = " & StockId
                    Common.ExecuteQuery(Query, sqlTrans)
                Else
                    Query = "Select IsNull(Count(StkCatRt_Id), 0) From StkCatRt " _
                        & " Where Stk_Id = " & StockId _
                        & " And RateCat_Id = " & RecRow("RateCat_Id")
                    Dim RateCatRec As Byte = CType(Common.ExecuteScalar(Query, sqlTrans), Byte)
                    Dim RecId As Integer


                    If RateCatRec = 0 Then
                        RecId = Common.NewRecordId("StkCatRt", "StkCatRt_Id", sqlTrans, False)

                        If GetSettingAsPerId(ApplnSettingsIdx.DataSynchToCloud) = "1" Then
                            Query = "Insert Into StkCatRt Values (" & RecId & "," & StockId & "," & RecRow("RateCat_Id") & ",'" & StyleKey & "'," & PurDtlId & "," & MRPCatRt & "," & SPCatRt & "," & PurCatRt & ",0,0,0)"
                        Else
                            Query = "Insert Into StkCatRt Values (" & RecId & "," & StockId & "," & RecRow("RateCat_Id") & ",'" & StyleKey & "'," & PurDtlId & "," & MRPCatRt & "," & SPCatRt & "," & PurCatRt & ",0,0)"
                        End If

                        Common.ExecuteQuery(Query, sqlTrans)
                    Else
                        Query = "Update StkCatRt Set MRP = " & MRPCatRt _
                           & ", SP = " & SPCatRt & ", PurRt = " & PurCatRt & ", PurDtl_Id = " & PurDtlId _
                           & " Where Stk_Id = " & StockId _
                           & " And RateCat_Id = " & RecRow("RateCat_Id")
                        Common.ExecuteQuery(Query, sqlTrans)
                    End If
                End If
            End If
        Next RecRow
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCLBUTTONDOWN As Integer = 161
        Const WM_SYSCOMMAND As Integer = 274
        Const HTCAPTION As Integer = 2
        Const SC_MOVE As Integer = 61456

        If (m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32() = SC_MOVE) Then
            Return
        End If

        If (m.Msg = WM_NCLBUTTONDOWN) AndAlso (m.WParam.ToInt32() = HTCAPTION) Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub lnkPrintBarcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkPrintBarcode.Click

    End Sub

    Private Sub btnBarCdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBarCdClose.Click
        grpPrnBarcode.Visible = False
        lnkPrintBarcode.Visible = True
    End Sub

    Private Sub btnBarCdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBarCdPrint.Click


        PrintReport(False)

        btnBarCdClose_Click(btnBarCdClose, Nothing)
    End Sub

    Private Sub btnBarCdView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBarCdView.Click
        PrintReport(True)

        btnBarCdClose_Click(btnBarCdClose, Nothing)
    End Sub


    Private Sub GetStockDetails(ByVal DocDtlId As Integer, ByRef StkId As Integer, ByVal SizeKey As String, ByRef Barcode As String, ByVal sqlTrans As SqlTransaction)
        Query = "Select Stk_Id, Barcode From ItemStock With(NoLock)" _
            & " Where PurDocDtl_Id = " & DocDtlId _
            & " And ItemSize_Key = '" & SizeKey & "'"
        Dim StockDtls As DataTable = Common.GetDataTable(Query, sqlTrans)

        If StockDtls.Rows.Count > 0 Then
            StkId = StockDtls.Rows(0)("Stk_Id")
            Barcode = StockDtls.Rows(0)("Barcode")
        End If
    End Sub


    Private Function UnitName(ByVal UnitKey As String, ByVal sqlTrans As SqlTransaction) As String
        Query = "Select Abbr " _
            & " From Unit Where Unit_Key = '" & UnitKey & "'"
        Dim UnitAbbr As String = Common.ExecuteScalar(Query, sqlTrans)

        Return UnitAbbr
    End Function

    Private Sub PrintReport(ByVal ViewReport As Boolean)
        'ReportParameters.ShowPrintButton = False
        If cmbFormat.SelectedIndex = 0 Then
            ReportParameters.rptFile = ReportPath & "\Misc\Format1.rpt"
            ReportParameters.rptFilter = "{BarcodePrn.CoBr_Id} = '" & SelBranchId & "' And {BarcodePrn.User_Id} = " & UserId

        ElseIf cmbFormat.SelectedIndex = 1 Then
            ReportParameters.rptFile = ReportPath & "\Misc\Format2.rpt"
            ReportParameters.rptFilter = "{BarcodePrn.CoBr_Id} = '" & SelBranchId & "' And {BarcodePrn.User_Id} = " & UserId

        ElseIf cmbFormat.SelectedIndex = 2 Then
            ReportParameters.rptFile = ReportPath & "\Misc\Format3.rpt"
            ReportParameters.rptFilter = "{BarcodePrn.CoBr_Id} = '" & SelBranchId & "' And {BarcodePrn.User_Id} = " & UserId

        ElseIf cmbFormat.SelectedIndex = 3 Then
            ReportParameters.rptFile = ReportPath & "\Misc\Format4.rpt"
            ReportParameters.rptFilter = "{BarcodePrn.CoBr_Id} = '" & SelBranchId & "' And {BarcodePrn.User_Id} = " & UserId
        End If

        'ReportParameters.ShowPrintButton = False

        ''FormType = "BarCode"

        If ViewReport Then
            ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToWindow

            Dim frmView As New frmViewReports
            frmView.Show()
        Else
            'ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToPrinter
            'ReportParameters.NoOfCopiesToPrint = 1

            'Dim PrintDoc As New Common
            'PrintDoc.PrintDocToPrinter()
            'PrintDoc = Nothing

            ReportParameters.PrintFormat = ReportParameters.PrintType.PrintToPrinter

            Dim frmView As New frmViewReports
            frmView.Show()
        End If
    End Sub

    Private Sub ReCalcSerial(ByVal ForBarcode As Boolean)
        If IsNothing(Details) Then Exit Sub

        Dim RecRow As DataRow
        Dim LastSrNo As Integer

        For Each RecRow In Details.Rows
            If LastSrNo = 0 Then
                LastSrNo = 1
            Else
                LastSrNo += 1
            End If

            RecRow(GridCols.SrNo) = LastSrNo
        Next RecRow

        Details.AcceptChanges()
    End Sub

    Private Sub cmbPBrand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBrand.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub cmbBrand_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBrand.SelectionChanged

        If cmbBrand.SelectedIndex = -1 Then Exit Sub



        Query = "Select DISTINCT STYLE_CODE, STYLE_CODE From Style " _
         & " Where Item_Key = '" & cmbProduct.SelectedValue & "' and  Brand_Key='" & cmbBrand.Value & "' " _
         & " And Status = '1' " _
         & " Order By Style.Style_Code"
        Dim dtStyle As DataTable = Common.GetDataTableWithAll(Query)

        With cmbStyle
            .DataSource = dtStyle
            .DisplayMember = "STYLE_CODE1"
            .ValueMember = "STYLE_CODE"
        End With

        If cmbStyle.Items.Count > 0 Then
            cmbStyle.SelectedIndex = 0
        End If
        'DisplayStockDetails()


    End Sub

    Private Sub cmbProduct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProduct.Validated
        If cmbProduct.SelectedIndex = -1 Then cmbProduct.SelectedIndex = 0
    End Sub

    Private Sub cmbSize_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSize.Validated
        If cmbSize.SelectedIndex = -1 Then cmbSize.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If btnClose.Text = "Cl&ose" Then
            Me.Close()
        Else
            dtgDetails.DataSource = Nothing : Details = Nothing
            grpMain.Enabled = False
            BtnSave.Text = "&Add" : BtnSave.Image = imgButtonList.Images(ImageIdx.Add)
            btnClose.Text = "Cl&ose" : btnClose.Image = imgButtonList.Images(ImageIdx.Close)

            chkBarcode.Checked = False : cmbItmSubGroup.SelectedIndex = -1 : cmbProduct.SelectedIndex = -1 : cmbBrand.SelectedIndex = -1 : cmbStyle.SelectedIndex = -1
            cmbType.SelectedIndex = -1 : cmbShade.SelectedIndex = -1 : cmbSize.SelectedIndex = -1 : txtBarcode.Text = "" : txtTakaNo.Text = "" : txtQty.Text = 0
            cmbItmSubGroup.Focus()

        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim Trans As SqlTransaction = Nothing

        If BtnSave.Text = "&Add" Then
            dtgDetails.DataSource = Nothing : Details = Nothing
            grpMain.Enabled = True
            chkBarcode.Checked = False

            BtnSave.Image = imgButtonList.Images(ImageIdx.Save) : BtnSave.Text = "&Save"
            btnClose.Image = imgButtonList.Images(ImageIdx.Cancel) : btnClose.Text = "&Cancel"
            If cmbLocation.Items.Count > 0 Then cmbLocation.SelectedIndex = 0
            cmbLocation.Value = SelLocId

            chkBarcode_CheckedChanged(chkBarcode, Nothing) : txtQty.Text = 0 : txtTakaNo.Text = ""
            cmbItmSubGroup.Focus()

        ElseIf BtnSave.Text = "&Save" Then

            If IsNothing(Details) Then
                MsgBox("Stock details not specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                btnShow.Focus()
                Exit Sub
            End If
            Trans = CreateSQLTransaction()
            For Each RecRow In Details.Rows
                If Val(RecRow(GridCols.StkId).ToString()) <> 0 Then
                    Query = " Update ItemStock Set Updated_Dt='" & Format$(Now, "MM/dd/yyyy HH:mm:ss tt") & "', Comm = " & Val(RecRow(GridCols.Comm)) & " where Stk_Id = " & Val(RecRow(GridCols.StkId))
                    Common.ExecuteQuery(Query, Trans)




                End If
            Next RecRow
            Trans.Commit()

            DisplayStockDetails()
            grpMain.Enabled = False
            BtnSave.Text = "&Add" : BtnSave.Image = imgButtonList.Images(ImageIdx.Add)
            btnClose.Text = "Cl&ose" : btnClose.Image = imgButtonList.Images(ImageIdx.Close)
        End If
    End Sub
    Private Sub chkBarcode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBarcode.CheckedChanged

        cmbItmSubGroup.SelectedIndex = -1 : cmbProduct.SelectedIndex = -1 : cmbBrand.SelectedIndex = -1 : cmbStyle.SelectedIndex = -1
        cmbType.SelectedIndex = -1 : cmbShade.SelectedIndex = -1 : cmbSize.SelectedIndex = -1 : txtBarcode.Text = ""
        If chkBarcode.Checked = True Then
            txtBarcode.Enabled = True
            cmbItmSubGroup.Enabled = False : cmbProduct.Enabled = False : cmbBrand.Enabled = False : cmbStyle.Enabled = False
            cmbType.Enabled = False : cmbShade.Enabled = False : cmbSize.Enabled = False
        Else
            cmbItmSubGroup.Enabled = True : cmbProduct.Enabled = True : cmbBrand.Enabled = True : cmbStyle.Enabled = True
            cmbType.Enabled = True : cmbShade.Enabled = True : cmbSize.Enabled = True : txtBarcode.Enabled = False
            If cmbItmSubGroup.Items.Count > 0 Then cmbItmSubGroup.SelectedIndex = 0 : cmbShade.SelectedIndex = 0
        End If
    End Sub

    Private Sub chkBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkBarcode.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click

        If chkBarcode.Checked = True And txtBarcode.Text.Trim.Length = 0 Then
            MsgBox("barcode no cannot be blank !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtBarcode.Text = ""
            txtBarcode.Focus() : Exit Sub
        End If
        DisplayStockDetails()

        If Details.Rows.Count > 0 Then
            For i As Integer = 0 To Details.Rows.Count - 1
                Dim dgcQty As DataGridCell = New DataGridCell(i, GridCols.Comm)
                dtgDetails.CurrentCell = dgcQty
                dtgDetails.CurrentRowIndex = i : dtgDetails.Focus()
                Exit For
            Next i
            dtgDetails.CurrentRowIndex = Details.Rows.Count - 1
        End If
    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub txtBarcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.LostFocus
        If txtBarcode.Text.Trim.Length = 0 Then Exit Sub


        If cmbLocation.Text <> "" Then
            Query = "Select IsNull(Stk_Id, 0)Stk_Id " _
                   & " From ItemStock With(NoLock) " _
                   & " Where (Barcode = '" & txtBarcode.Text & "' Or AltBarcode1 = '" & txtBarcode.Text & "' " _
                   & " Or AltBarcode2 = '" & txtBarcode.Text & "')" _
                   & " And Loc_Key = '" & cmbLocation.Value & "' And CoBr_Id = '" & SelBranchId & "' "
        Else
            Query = "Select IsNull(Stk_Id, 0)Stk_Id " _
                   & " From ItemStock With(NoLock) " _
                   & " Where (Barcode = '" & txtBarcode.Text & "' Or AltBarcode1 = '" & txtBarcode.Text & "' " _
                   & " Or AltBarcode2 = '" & txtBarcode.Text & "')" _
                   & " And CoBr_Id = '" & SelBranchId & "' "
        End If

        Dim BarcdStk As DataTable = Common.GetDataTable(Query)

        If BarcdStk.Rows.Count = 0 Then
            MsgBox("Invalid barcode specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtBarcode.Text = ""
            txtBarcode.Focus() : Exit Sub

        Else

            Query = "Select I.Item_Key,I.Style_Key,Style.Style_Code,I.Type_Key,I.Shade_Key,I.ItemSize_Key,I.Brand_Key,I.Loc_Key, Item.ItemSubGrp_Key " _
                & " From ItemStock I With(NoLock) Left Join Style On I.Style_Key = Style.Style_Key " _
                & " Left Join Item On I.Item_Key = Item.Item_Key " _
                & " Left Join ItemSubGrp On Item.ItemSubGrp_Key = ItemSubGrp.ItemSubGrp_Key " _
                & " Where I.Stk_Id = " & BarcdStk.Rows(0)("Stk_Id")
            Dim dt As DataTable = Common.GetDataTable(Query)
            If dt.Rows.Count > 0 Then
                cmbItmSubGroup.Value = dt.Rows(0)("ItemSubGrp_Key")
                cmbItmSubGroup_EditValueChanged(cmbItmSubGroup, Nothing)
                cmbProduct.SelectedValue = dt.Rows(0)("Item_Key")
                cmbBrand.Value = dt.Rows(0)("Brand_Key")
                cmbStyle.SelectedValue = dt.Rows(0)("Style_Code")
                cmbType.Value = dt.Rows(0)("Type_Key")
                cmbShade.SelectedValue = dt.Rows(0)("Shade_Key")
                cmbSize.Value = dt.Rows(0)("ItemSize_Key")
            End If
            btnShow_Click(btnShow, Nothing)
            txtBarcode.Text = ""
            txtBarcode.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dtgDetails.DataSource = Nothing
        Call DisplayGridHeaders() : FormatDetailGrid(Details)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim blnFlag As Boolean = False
        If dtgDetails.CurrentRowIndex = -1 Then Exit Sub
        If txtTakaNo.Text.Trim.Length = 0 Then
            dtgDetails.CurrentRowIndex = 0
            btnSearch.Focus()
        Else
            Details = CType(dtgDetails.DataSource, DataTable)
            For i As Integer = 0 To Details.Rows.Count - 1
                If Details.Rows(i).Item(6) = txtTakaNo.Text Or Details.Rows(i).Item(7) = txtTakaNo.Text Then
                    blnFlag = True
                    Dim dgcQty As DataGridCell = New DataGridCell(i, GridCols.Comm)
                    dtgDetails.CurrentCell = dgcQty
                    dtgDetails.CurrentRowIndex = i : dtgDetails.Focus()
                    Exit For
                End If
            Next i
            If blnFlag = False Then
                MsgBox("Barcode not found !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                dtgDetails.CurrentRowIndex = 0
                txtTakaNo.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmbShade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSize.KeyDown, cmbShade.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub cmbShade_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbShade.Validated
        If cmbShade.SelectedIndex = -1 Then cmbShade.SelectedIndex = 0
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown, txtTakaNo.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub cmbLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLocation.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub cmbLocation_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLocation.Validated
        If cmbLocation.SelectedIndex = -1 Then cmbLocation.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'With dtgDetails
        '    If .Item(.CurrentRowIndex, GridCols.DetailId) > 0 Then
        '        .Item(.CurrentRowIndex, GridCols.Comm) = txtCommission.EditValue
        '    End If


        'End With

        'For Each RecRow1 In Details.Rows
        '    'If LastSrNo = 0 Then
        '    '    LastSrNo = 1
        '    'Else
        '    '    LastSrNo += 1
        '    'End If

        '    .Item(.CurrentRowIndex, GridCols.Comm) = txtCommission.EditValue
        'Next RecRow1

        For Each RecRow In Details.Rows
            'If LastSrNo = 0 Then
            '    LastSrNo = 1
            'Else
            '    LastSrNo += 1
            'End If

            RecRow(GridCols.Comm) = txtCommission.EditValue
        Next RecRow

    End Sub


    Private Sub cmbProduct_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProduct.KeyPress
        cmbProduct.DroppedDown = False
    End Sub

    Private Sub cmbShade_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbShade.KeyPress
        cmbShade.DroppedDown = False
    End Sub


    Private Sub cmbStyle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbStyle.KeyPress
        cmbStyle.DroppedDown = False
    End Sub

End Class