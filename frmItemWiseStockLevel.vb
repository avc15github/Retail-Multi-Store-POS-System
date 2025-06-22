Imports System.Data.SqlClient

Public Class frmItemWiseStockLevel
    Implements IButtonProcs

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
    Dim CurrModule As String = "ndOpeningStock"
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
        Min
        Max
        ReOrder
        DetailId
        RecStatus
        StyleKey
        TypeKey
        ShadeKey
        SizeKey
        BrandKey
    End Enum

    Enum SizeGridCols
        SizeName
        Min
        Max
        ReOrder
        SizeKey
    End Enum


    Private Sub frmPurchase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'MDI.MDINaviBar.Collapsed = True

        
        If ChgBtnBehave Then
            If FuncButtons.EditButton.Text.ToUpper <> CancelCaption.ToUpper Then
                ButtonRights(FuncButtons, CurrModule)
                If dtgDetails.CurrentRowIndex = -1 Then
                    FuncButtons.AddButton.Enabled = True
                Else
                    FuncButtons.AddButton.Enabled = False
                End If
            End If
        End If


    End Sub

    Private Sub frmItemWiseStockLevel_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'MDI.MDINaviBar.Collapsed = False
    End Sub

    Private Sub frmItemWiseStockLevel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Control.ModifierKeys = Keys.Control And e.KeyCode = Keys.S Then
            If grpSize.Visible Then
                btnSizeConfirm_Click(btnSizeConfirm, Nothing)
            ElseIf btnSizeQty.Enabled Then
                If cmbSize.Focused Then
                    btnSizeQty_Click(btnSizeQty, Nothing)
                End If
            End If

        ElseIf Control.ModifierKeys = Keys.Control And e.KeyCode = Keys.C Then
            If grpSize.Visible Then
                btnSizeConfirm_Click(btnSizeConfirm, Nothing)
            End If
        End If

        'For F3 and Escap'

        If grpDetails.Enabled = True Then

            If e.KeyCode = Keys.F3 Then
                If cmbStyle.Focused = True Then
                    btnStyle_Click(Nothing, Nothing)
                End If
                If cmbShade.Focused = True Then

                End If
              
            End If
        Else
            If e.KeyCode = Keys.Escape And grpSize.Visible = False And pnlDtlButtons.Enabled = False Then
                Me.Close()
            End If


        End If

    End Sub

    Private Sub frmPurchase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        FuncButtons.FormObj = Me
        grpMain.Enabled = True
        grpDetails.Enabled = False
        pnlDtlButtons.Enabled = False


        'If Val(GetSettingAsPerId(ApplnSettingsIdx.GenDigitsInDecimalQty)) = 2 Then
        '    txtQty.Properties.Mask.EditMask = "n2"
        '    txtClQty.Properties.Mask.EditMask = "n2"

        'ElseIf Val(GetSettingAsPerId(ApplnSettingsIdx.GenDigitsInDecimalQty)) = 3 Then
        '    txtQty.Properties.Mask.EditMask = "n3"
        '    txtClQty.Properties.Mask.EditMask = "n3"

        'Else
        '    txtQty.Properties.Mask.EditMask = "n0"
        '    txtClQty.Properties.Mask.EditMask = "n0"
        'End If


        'Dim MultiPurRate As Boolean = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiSalesPerson)))

        'lblBillPurRate.Visible = MultiPurRate
        'txtBillPurRate.Visible = MultiPurRate

        'lblBillSaleRate.Visible = MultiPurRate
        'txtBillSaleRate.Visible = MultiPurRate

        FuncButtons.AddButton.Enabled = False

        'If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseBatchNo))) Then
        '    lblLotNo.Visible = True
        '    txtLotNo.Visible = True
        'End If

        'If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseExpiryDt))) Then
        '    lblExpiryDate.Visible = True
        '    dtpExpiryDt.Visible = True
        'End If


        With NavRecords
            .TableName = "ItemWiseStkLevel"
            .FieldName = "Item_Key"
            .Connect = Common.ConnectionString
            .WhereFilter = " Where  " _
                & " CoBr_Id = " & SelYearId & ""
            .AndFilter = " And Item_Key <> ''"
            .Branch = ""
            .OrderBy = " Order By  Item_Key"
            .MyForm = Me
        End With

        FillComboDetails()
        lblBrand.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand)
        lblArticleNo.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle)

        lblProduct.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct)
        lblShade.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefShade)
        lblSize.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefSize)
        lblSubGroup.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefSubGroup)
        lblType.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefType)

        cmbBrand.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand)
        cmbStyle.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle)

        cmbProduct.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct)
      
        cmbShade.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefShade)
        cmbSize.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefSize)
        cmbItmSubGroup.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefSubGroup)
        cmbType.Tag = GetSysCaptionAsPerId(SystemCaptionIdx.DefType)

        grpSize.Text = GetSysCaptionAsPerId(SystemCaptionIdx.DefSize) & " Wise Details"
        cmbItmSubGroup.Focus()
      
    End Sub
    Private Sub FormatDetailGrid(ByVal dtTable As DataTable)
        Dim tblStyle As DataGridTableStyle
        tblStyle = GridColumnCreateAndFormat.CreateTableStyle(dtTable.TableName)

        Dim colSrNo As New DataGridTextBoxColumn
        With colSrNo
            .MappingName = dtTable.Columns(GridCols.SrNo).ColumnName
            .HeaderText = "Sr"
            .Width = 30
            .NullText = 0
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colStyle_Name As New DataGridTextBoxColumn
        With colStyle_Name
            .MappingName = dtTable.Columns(GridCols.StyleName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle)
            .Width = 150
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colTypeName As New DataGridTextBoxColumn
        With colTypeName
            .MappingName = dtTable.Columns(GridCols.TypeName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefType)
            .Width = 60
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colShadeName As New DataGridTextBoxColumn
        With colShadeName
            .MappingName = dtTable.Columns(GridCols.ShadeName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefShade)
            .Width = 80
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colSizeName As New DataGridTextBoxColumn
        With colSizeName
            .MappingName = dtTable.Columns(GridCols.SizeName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefSize)
            .Width = 60
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colBrand As New DataGridTextBoxColumn
        With colBrand
            .MappingName = dtTable.Columns(GridCols.BrandName).ColumnName
            .HeaderText = GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand)
            .Width = 120
            .NullText = ""
            .Alignment = HorizontalAlignment.Left
        End With

        Dim colMin As New DataGridTextBoxColumn
        With colMin
            .MappingName = dtTable.Columns(GridCols.Min).ColumnName
            .HeaderText = "Min Level."
            .Width = 80
            .NullText = 0
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With

        Dim colMax As New DataGridTextBoxColumn
        With colMax
            .MappingName = dtTable.Columns(GridCols.Max).ColumnName
            .HeaderText = "Max Level."
            .Width = 80
            .NullText = 0
            .Alignment = HorizontalAlignment.Right
            .Format = "0.00"
        End With

        Dim colReOrder As New DataGridTextBoxColumn
        With colReOrder
            .MappingName = dtTable.Columns(GridCols.ReOrder).ColumnName
            .HeaderText = "ReOrder Level."
            .Width = 100
            .NullText = 0
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


        tblStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {colSrNo, colStyle_Name, colTypeName, colShadeName, colSizeName, colBrand, colMin, colMax, colReOrder, colDetailId, colRecStatus, colStyle_Key, colType_Key, colShade_Key, colSize_Key, colBrand_Key})
        colSrNo = Nothing : colStyle_Name = Nothing : colTypeName = Nothing : colShadeName = Nothing : colSizeName = Nothing : colBrand = Nothing
        colMin = Nothing : colMax = Nothing : colReOrder = Nothing : colDetailId = Nothing : colRecStatus = Nothing
        colStyle_Key = Nothing : colType_Key = Nothing : colShade_Key = Nothing : colSize_Key = Nothing : colBrand_Key = Nothing


        dtgDetails.TableStyles.Clear()
        dtgDetails.TableStyles.Add(tblStyle)
    End Sub

    Private Sub FillComboDetails()
        Try
            Me.Cursor = Cursors.WaitCursor


            Query = "Select '' SHADE_KEY, '' SHADE_NAME " _
                & " Union All " _
                & " Select SHADE_KEY, SHADE_NAME " _
                & " From Shade Where Status = '1' And Shade_Name <> '' " _
                & BranchFilter _
                & " Order By Shade_Name"
            Common.FillCombo2(Query, cmbShade, "SHADE_NAME", "SHADE_KEY")



            Query = "Select ITEMSUBGRP_KEY, ITEMSUBGRP_NAME " _
               & " From ITEMSUBGRP Where Status = '1' And ItemSubGrp_Name <> '' " _
               & BranchFilter _
               & " Order By ITEMSUBGRP_Name"
            Common.FillCombo2(Query, cmbItmSubGroup, "ITEMSUBGRP_NAME", "ITEMSUBGRP_KEY")


            'Query = "Select '' BRAND_KEY, '' BRAND_NAME " _
            '   & " Union All " _
            '   & " Select BRAND_KEY, BRAND_NAME " _
            '   & " From Brand Where Status = '1' And Brand_Name <> '' " _
            '   & BranchFilter _
            '   & " Order By Brand_Name"
            'Common.FillCombo2(Query, cmbBrand, "BRAND_NAME", "BRAND_KEY")
            'Common.FillCombo2(Query, cmbDtlBrand, "BRAND_NAME", "BRAND_KEY")

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

    Private Sub cmbProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProduct.KeyDown, cmbDtlBrand.KeyDown, cmbDtlType.KeyDown, cmbDtlStyle.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    cmbBrand.Focus()
        'End If
        MoveToNextControl(e)
    End Sub


    Private Sub cmbProduct_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProduct.SelectionChanged
        If cmbProduct.SelectedIndex = -1 Then Exit Sub


        cmbStyle.DataSource = Nothing : cmbStyle.Text = "" : cmbType.DataSource = Nothing : cmbType.Text = "" : cmbBrand.DataSource = Nothing : cmbBrand.Text = ""

        'Query = "Select DISTINCT STYLE_CODE, STYLE_CODE From Style " _
        ' & " Where Item_Key = '" & cmbProduct.Value & "'" _
        ' & " And Status = '1' " _
        ' & " Order By Style_Code"
        'Common.FillCombo2(Query, cmbDtlStyle, "STYLE_CODE", "STYLE_CODE")
        'Dim dtStyle As DataTable = Common.GetDataTableWithAll(Query)

        'With cmbStyle
        '    .DataSource = dtStyle
        '    .DisplayMember = "STYLE_CODE1"
        '    .ValueMember = "STYLE_CODE"
        'End With



        'If cmbStyle.Items.Count > 0 Then
        '    cmbStyle.SelectedIndex = 0
        'End If

        Query = " Select Distinct  Brand.BRAND_KEY, Brand.BRAND_NAME " _
        & " From Brand Left Join Style on Brand.Brand_Key=Style.Brand_Key  Where  Style.Status = '1' And Brand_Name <> '' " _
        & " and Style.Item_Key ='" & cmbProduct.Value & "'" _
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


        DisplayStockDetails()

        If dtgDetails.CurrentRowIndex = -1 Then
            FuncButtons.AddButton.Enabled = True
        Else
            FuncButtons.AddButton.Enabled = False
        End If
    End Sub

    Private Sub DisplayGridHeaders()
        Dim Grid As New GridColumnCreateAndFormat("PurDetails")

        With Grid
            .AddColumn("Sr..", GridColumnCreateAndFormat.enmTypeIdx.IntegerType, 40, "Sr.")
            .AddColumn("StyleName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 100, GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle))
            .AddColumn("TypeName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 60, GetSysCaptionAsPerId(SystemCaptionIdx.DefType))
            .AddColumn("ShadeName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, GetSysCaptionAsPerId(SystemCaptionIdx.DefShade))
            .AddColumn("SizeName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 50, GetSysCaptionAsPerId(SystemCaptionIdx.DefSize))
            .AddColumn("BrandName", GridColumnCreateAndFormat.enmTypeIdx.StringType, 80, GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand))

            .AddColumn("Min", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 80, "Min Level.")
            .AddColumn("Max", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 80, "Max Level.")
            .AddColumn("ReOrder", GridColumnCreateAndFormat.enmTypeIdx.DecimalType, 100, "ReOrder Level.")

            .AddColumn("DetailId", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("RecStatus", GridColumnCreateAndFormat.enmTypeIdx.ByteType, 0, "")
            .AddColumn("StyleKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("TypeKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("ShadeKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("SizeKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")
            .AddColumn("BrandKey", GridColumnCreateAndFormat.enmTypeIdx.StringType, 0, "")

            
            .AddColumnToTable()
            Details = .GetTable
            Details.DefaultView.AllowNew = False
            Details.DefaultView.AllowEdit = False
            Details.DefaultView.AllowDelete = False

            dtgDetails.DataSource = Details
            .DisplayGridHeaders(Details, dtgDetails)

        End With
    End Sub

    Private Sub btnDtlAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDtlAdd.Click
        If cmbProduct.SelectedIndex = -1 Or cmbProduct.Text.Trim.Length = 0 Then
            MsgBox(cmbProduct.Tag & c_BlankMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbProduct.Focus()
            Exit Sub
        End If

        'grpMain.Enabled = False
        dtgDetails.Enabled = False
        grpDetails.Enabled = True
        pnlDtlButtons.Enabled = False
        ClearDetailTextBoxes()
        FuncButtons.Enabled = False

        If Details.Rows.Count = 0 Then
            cmbShade.SelectedIndex = 0 : cmbSize.SelectedIndex = 0
        End If

      
        Query = "Select ITEMSIZE_KEY, SIZE_NAME " _
            & " From ItemSize Where Status = '1' " _
            & " And Item_Key = '" & cmbProduct.Value & "'" _
            & BranchFilter _
            & " Order By SeqNo"
        Common.FillCombo2(Query, cmbSize, "SIZE_NAME", "ITEMSIZE_KEY")

        If cmbSize.Items.Count > 0 Then
            cmbSize.SelectedIndex = 0
        End If



        SizeDetails = Nothing
        dtgSize.DataSource = Nothing
        DisplaySizeGridHeaders()
        NewDesign = True
        txtMinLevel.Enabled = True
        lblSizeQty.Text = 0
        If cmbDtlStyle.Items.Count > 0 Then
            cmbDtlStyle.SelectedIndex = 0
        End If
        cmbShade.Enabled = True
        cmbSize.Enabled = True : btnSizeQty.Enabled = True
        cmbDtlBrand.Enabled = True : cmbDtlStyle.Enabled = True : cmbDtlType.Enabled = True
        txtMinLevel.Focus()


        DtlEditMode = 1
        cmbDtlStyle.Focus()
    End Sub

    Private Sub btnDtlEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDtlEdit.Click
        If dtgDetails.CurrentRowIndex = -1 Then Exit Sub

        dtgDetails.Enabled = False
        grpDetails.Enabled = True
        pnlDtlButtons.Enabled = False
        FuncButtons.Enabled = False
        DtlEditMode = 2
        txtMinLevel.Enabled = True : txtMaxLevel.Enabled = True : txtReOrderLevel.Enabled = True
    
        btnSizeQty.Enabled = False

        If dtgDetails.Item(dtgDetails.CurrentRowIndex, GridCols.DetailId) > 0 Then
            cmbShade.Enabled = False
            cmbSize.Enabled = False : btnSizeQty.Enabled = False
            cmbDtlBrand.Enabled = False : cmbDtlStyle.Enabled = False : cmbDtlType.Enabled = False
            txtMinLevel.Focus()
        Else
            cmbShade.Focus()
        End If

        dtgDetails_Click(dtgDetails, Nothing)
    End Sub

    Private Sub btnDtlCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDtlCancel.Click
        grpDetails.Enabled = False
        dtgDetails.Enabled = True

        pnlDtlButtons.Enabled = True
        FuncButtons.Enabled = True
        NewDesign = False
        If Not IsNothing(Details) Then
            If Details.Rows.Count > 0 Then
                If DtlEditMode = 1 Then
                    dtgDetails.CurrentRowIndex = Details.Rows.Count - 1
                    dtgDetails_Click(dtgDetails, Nothing)
                ElseIf DtlEditMode = 2 Then
                    dtgDetails_Click(dtgDetails, Nothing)
                End If
            Else
                Common.ClearControls(grpDetails)
            End If
        End If
        btnDtlAdd.Focus()
        DtlEditMode = 0
    End Sub
    Private Function StyleExists() As Boolean
        Dim i As Short
        Dim RecRow As DataRow
        Dim Type As String = ""
        Dim Shade As String = ""
        Dim Size As String = ""
        Dim Brand As String = ""
        Dim Quality As String = ""
        Dim Season As String = ""
        Dim Occassion As String = ""
        Dim Mfr As String = ""
        Dim Location As String = ""

        For i = 0 To Details.Rows.Count - 1
            RecRow = Details.Rows(i)

            If DtlEditMode = 1 Then

                If Not IsNothing(cmbDtlType.Value) Then
                    Type = cmbDtlType.Value
                End If

                If Not IsNothing(cmbShade.Value) Then
                    Shade = cmbShade.Value
                End If

                If Not IsNothing(cmbSize.Value) Then
                    Size = cmbSize.Value
                End If

                If Not IsNothing(cmbDtlBrand.Value) Then
                    Brand = cmbDtlBrand.Value
                End If

                If RecRow(GridCols.StyleName) = cmbDtlStyle.Text.ToUpper And RecRow(GridCols.TypeKey) = Type And RecRow(GridCols.ShadeKey) = Shade And RecRow(GridCols.SizeKey) = Size And RecRow(GridCols.BrandKey) = Brand Then
                    MsgBox(cmbDtlStyle.Tag & " has already been added !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                    cmbDtlStyle.Focus()
                    Return True
                End If

            Else

                If i <> dtgDetails.CurrentRowIndex Then
                    If RecRow(GridCols.StyleName) = cmbDtlStyle.Text.ToUpper And RecRow(GridCols.TypeKey) = cmbDtlType.Value And RecRow(GridCols.ShadeKey) = cmbShade.Value And RecRow(GridCols.SizeKey) = cmbSize.Value And RecRow(GridCols.BrandKey) = cmbDtlBrand.Value Then
                        MsgBox(cmbStyle.Tag & " has already been added !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                        cmbShade.Focus()
                        Return True
                    End If
                End If

            End If
        Next i
    End Function


    Private Sub btnDtlSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDtlSave.Click
        Dim RecordsSeries As String = ""

        If cmbDtlStyle.SelectedIndex = -1 Or cmbStyle.Text = "" Then
            MsgBox("Invalid Style specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbDtlStyle.Focus()
            Exit Sub
        End If

        If cmbDtlType.SelectedIndex = -1 Then
            MsgBox("Invalid Type specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbDtlType.Focus()
            Exit Sub
        End If


        If cmbShade.SelectedIndex = -1 Then
            If cmbShade.Enabled Then
                MsgBox("Invalid " & cmbShade.Tag & " specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                cmbShade.Focus()
                Exit Sub
            End If
        End If

        If cmbSize.SelectedIndex = -1 Then
            If cmbSize.Enabled Then
                MsgBox("Invalid " & cmbSize.Tag & " specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                cmbSize.Focus()
                Exit Sub
            End If
        End If


        If StyleExists() Then Exit Sub


            If DtlEditMode = 1 Then
                If Val(lblTotSizeMaxQty.Text) > 0 Or Val(lblTotSizeMinQty.Text) Or Val(lblTotSizeReOrderQty.Text) Then
                    ConfirmSizeDetails()
                    CalcTotal()
                    Exit Sub
                End If
            End If

            Dim ConvUnit As String = ""
        'Dim ConvQty As Double

            If DtlEditMode = 1 Then
                Dim NewRow As DataRow = Details.NewRow

                NewRow(GridCols.StyleName) = cmbDtlStyle.Text
                NewRow(GridCols.TypeName) = cmbDtlType.Text
                NewRow(GridCols.ShadeName) = cmbShade.Text
                NewRow(GridCols.BrandName) = cmbDtlBrand.Text
                NewRow(GridCols.SizeName) = cmbSize.Text
                NewRow(GridCols.DetailId) = 0
                NewRow(GridCols.RecStatus) = 1
                NewRow(GridCols.StyleKey) = StyleKeyDtl()
                NewRow(GridCols.TypeKey) = cmbDtlType.Value
                NewRow(GridCols.ShadeKey) = cmbShade.Value
                If Not IsNothing(cmbSize.Value) Then
                    NewRow(GridCols.SizeKey) = cmbSize.Value
                Else
                    NewRow(GridCols.SizeKey) = ""
                End If
                NewRow(GridCols.BrandKey) = cmbDtlBrand.Value
                NewRow(GridCols.Min) = Val(txtMinLevel.EditValue)
                NewRow(GridCols.Max) = Val(txtMaxLevel.EditValue)
                NewRow(GridCols.ReOrder) = Val(txtReOrderLevel.EditValue)

                Details.Rows.Add(NewRow)

            ElseIf DtlEditMode = 2 Then
                With dtgDetails

                    .Item(.CurrentRowIndex, GridCols.Min) = Val(txtMinLevel.EditValue)
                    .Item(.CurrentRowIndex, GridCols.Max) = Val(txtMaxLevel.EditValue)
                    .Item(.CurrentRowIndex, GridCols.ReOrder) = Val(txtReOrderLevel.EditValue)

                If .Item(.CurrentRowIndex, GridCols.RecStatus).ToString = 0 Then
                    .Item(.CurrentRowIndex, GridCols.RecStatus) = 2
                End If
            End With
            End If

            Details.AcceptChanges()
            ReCalcSerial(False)
            CalcTotal()

            btnDtlCancel_Click(btnDtlCancel, Nothing)



    End Sub

    Public Sub AddRecord() Implements IButtonProcs.AddRecord
        If cmbItmSubGroup.SelectedIndex = -1 Or cmbItmSubGroup.Text = "" Then
            MsgBox("Invalid SubGroup specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbItmSubGroup.Focus()
            FuncButtons.ContinueToChangeImage = True
            Exit Sub
        End If

        If cmbProduct.SelectedIndex = -1 Or cmbProduct.Text = "" Then
            MsgBox("Invalid Product specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbProduct.Focus()
            FuncButtons.ContinueToChangeImage = True
            Exit Sub
        End If


        grpMain.Enabled = False
        pnlDtlButtons.Enabled = True
        NavRecords.Enabled = False
        FuncButtons.AddButton.Enabled = True

        ReDim DelRow(0)
        lnkPrintBarcode.Enabled = False

        ChgBtnBehave = False
        EditMode = False
        IsAdd = True
        If Details.Rows.Count = 0 Then
            btnDtlAdd_Click(btnDtlAdd, Nothing)
        End If
        cmbDtlStyle.Focus()
    End Sub

    Public Sub CancelAddEdit() Implements IButtonProcs.CancelAddEdit
        grpMain.Enabled = True
        pnlDtlButtons.Enabled = False
        NavRecords.Enabled = True
        'FuncButtons.AddButton.Enabled = False
        lnkPrintBarcode.Enabled = True
        EditMode = False
        IsAdd = False
        ChgBtnBehave = True
        ClearTextboxes()
        dtgDetails.DataSource = Nothing
        ButtonRights(FuncButtons, CurrModule)
        If Not IsNothing(cmbProduct.Value) Then
            RetrieveRecord(cmbProduct.SelectedItem.DataValue)
        End If
    End Sub

    Public Sub CloseForm() Implements IButtonProcs.CloseForm
        Me.Close()
    End Sub

    Public Sub DeleteRecord() Implements IButtonProcs.DeleteRecord
        If cmbProduct.SelectedIndex = -1 Then Exit Sub
        If dtgDetails.CurrentRowIndex = -1 Then Exit Sub

        If MsgBox(DeleteRecordMsg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Dim Trans As SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            Query = "Exec Delete_ItemWiseStkLevel '" & cmbProduct.SelectedItem.DataValue & "','" & SelBranchId & "'"
            Common.ExecuteQuery(Query, Trans)

            Trans.Commit()


            ClearTextboxes()
            Details = Nothing : dtgDetails.DataSource = Nothing


            cmbProduct_SelectionChanged(cmbProduct, Nothing)


        Catch sqlEx As SqlException
            If sqlEx.ErrorCode = c_FKeyRefCode Then
                MsgBox(c_FKeyRefMsg, MsgBoxStyle.Critical, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            Else
                Common.LogAndDisplayException(sqlEx)
            End If
            Trans.Rollback()

        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Trans.Rollback()
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub EditRecord() Implements IButtonProcs.EditRecord
        If cmbProduct.SelectedIndex = -1 Then Exit Sub
        'If dtgDetails.CurrentRowIndex = -1 Then Exit Sub

        grpMain.Enabled = False
        pnlDtlButtons.Enabled = True
        NavRecords.Enabled = False
        FuncButtons.AddButton.Enabled = True
        lnkPrintBarcode.Enabled = False

        ReDim DelRow(0)

        ChgBtnBehave = False
        EditMode = True
        'txtPurRt.Focus()
        btnDtlAdd.Focus()

        'Dim tblstyle As DataGridTableStyle = dtgDetails.TableStyles(0)

        'If tblstyle.GridColumnStyles(SizeGridCols.MRP).Width = 0 Then

        'End If
    End Sub

    Public Function InsertRecord() As Byte Implements IButtonProcs.InsertRecord
        Dim Trans As SqlTransaction = Nothing

        Try
            Dim RecRow As DataRow

            Trans = CreateSQLTransaction()

            Dim StockId As Integer
            Dim RateCode As String = ""
            Dim NewBarcd As String = ""
            'Dim i As Integer
            'Dim BillPurRate, BillSaleRate As Double
            Dim DocDt As String = "Null"
            Dim ExpiryDt As String = "Null"
            Dim MfgDt As String = "Null"
            Dim ChlnDt As String = "Null"

            Dim AddedRows() As DataRow = Details.Select("DetailId = 0 And RecStatus = 1", "")

            For Each RecRow In Details.Rows
                StockId = Common.NewRecordId("ItemWiseStkLevel", "Doc_Id", Trans, False)
                Query = "Exec Insert_ItemWiseStkLevel '" & SelBranchId & "'," & StockId & ",'" & cmbProduct.Value & "','" & RecRow(GridCols.StyleKey) & "'," _
                & " '" & RecRow(GridCols.TypeKey) & "','" & RecRow(GridCols.ShadeKey) & "','" & RecRow(GridCols.SizeKey) & "'," _
                & " " & RecRow(GridCols.Min) & "," & RecRow(GridCols.Max) & "," & RecRow(GridCols.ReOrder) & "," & UserId & ",'" & Format$(Now, "MM/dd/yyyy hh:mm tt") & "'"
                Common.ExecuteQuery(Query, Trans)
            Next RecRow

            Trans.Commit()

            'RecordId = DocKey
            'NavRecords.CurrentRecordId = DocKey
            CurrIntId = cmbProduct.Value   'StockId
            NavRecords.CurrentRecordId = cmbProduct.Value '  StockId


            Return 0


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
            Trans.Rollback()
            Return 1
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Trans.Rollback()
            Return 1
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Public Function InvalidRecord() As Boolean Implements IButtonProcs.InvalidRecord
        If Not (Details Is Nothing) Then

            If Details.Rows.Count = 0 Then
                MsgBox("Stock details not specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
                btnDtlAdd.Focus()
                Return True
            End If
        End If
        ' Dim RecRow As DataRow

       

        Return False
    End Function

    Public Sub RetrieveRecord(ByVal RecId As String) Implements IButtonProcs.RetrieveRecord
        If RecId = "" Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select ItemSubGrp_Key From Item " _
                & " Where Item_key = '" & RecId & "'"
            Dim SubGrp As String = Common.ExecuteScalar(Query)

            cmbItmSubGroup.Value = SubGrp
            cmbItmSubGroup_EditValueChanged(cmbItmSubGroup, Nothing)


            cmbProduct.Value = RecId
            cmbProduct_SelectionChanged(cmbProduct, Nothing)

            FuncButtons.AddButton.Enabled = True
            If CType(dtgDetails.DataSource, DataTable).Rows.Count > 0 Then
                FuncButtons.AddButton.Enabled = False
            End If

            

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub SaveRecord() Implements IButtonProcs.SaveRecord
        If InvalidRecord() Then Exit Sub

        Dim RetStatus As Byte

        Try
            If Not EditMode Then
                ''Insert Record
                RetStatus = InsertRecord()
            Else
                ''Update Record
                RetStatus = UpdateRecord()
            End If

            FuncButtons.CurrentRecordStatus = False
            If RetStatus = 0 Then
                CancelAddEdit()
                FuncButtons.CurrentRecordStatus = True
            End If
            FuncButtons.Focus()
        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Function UpdateRecord() As Byte Implements IButtonProcs.UpdateRecord
        Dim Trans As SqlTransaction = Nothing

        Try
            Dim RecRow As DataRow

            Trans = CreateSQLTransaction()

            Dim StockId As Integer
            Dim RateCode As String = ""
            Dim NewBarcd As String = ""
            Dim AddedRows() As DataRow
            Dim EditedRows() As DataRow
            Dim i As Integer
            '   Dim BillPurRate, BillSaleRate As Double
            Dim DocDt As String = "Null"
            Dim ExpiryDt As String = "Null"
            Dim MfgDt As String = "Null"
            Dim ChlnDt As String = "Null"

            AddedRows = Details.Select("DetailId = 0 And RecStatus = 1", "")
            EditedRows = Details.Select("DetailId > 0 And RecStatus = 2", "")

            For Each RecRow In AddedRows
              
                StockId = Common.NewRecordId("ItemWiseStkLevel", "Doc_Id", Trans, False)
                Query = "Exec Insert_ItemWiseStkLevel '" & SelBranchId & "'," & StockId & ",'" & cmbProduct.Value & "','" & RecRow(GridCols.StyleKey) & "'," _
                & " '" & RecRow(GridCols.TypeKey) & "','" & RecRow(GridCols.ShadeKey) & "','" & RecRow(GridCols.SizeKey) & "'," _
                & " " & RecRow(GridCols.Min) & "," & RecRow(GridCols.Max) & "," & RecRow(GridCols.ReOrder) & "," & UserId & ",'" & Format$(Now, "MM/dd/yyyy hh:mm tt") & "'"

                Common.ExecuteQuery(Query, Trans)

            Next RecRow


            For Each RecRow In EditedRows
                Query = "Exec Update_ItemWiseStkLevel " & RecRow(GridCols.DetailId) & "," _
                   & " " & RecRow(GridCols.Min) & "," & RecRow(GridCols.Max) & "," & RecRow(GridCols.ReOrder) & "," & UserId & ",'" & Format$(Now, "MM/dd/yyyy hh:mm tt") & "'"
                Common.ExecuteQuery(Query, Trans)

            Next RecRow


            If UBound(DelRow) > 0 Then
                For i = 0 To UBound(DelRow) - 1
                    Query = "Exec delete_ItemWiseStkLevelWithId " & DelRow(i).RecDtlId
                    Common.ExecuteQuery(Query, Trans)
                Next i
            End If

            Trans.Commit()

            NavRecords.CurrentRecordId = RecordId

            Return 0


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
            Trans.Rollback()
            Return 1
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Trans.Rollback()
            Return 1
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Public Sub ViewReport() Implements IButtonProcs.ViewReport
        Dim Formulas As New Hashtable
        'Dim StockParam As String = " And {ItemSubGrp.ItemSubGrp_Key} = '" & cmbItmSubGroup.Value & "' And {Item.Item_Key} = '" & cmbProduct.Value & "'"
        'Dim Series As String = " And {vw_ItemSizeStock.StkSr} = 'A'"

        'Formulas.Add("GroupOn1#S", "U")
        'Formulas.Add("GroupHeader#S", "Sub-Group")
        'ReportParameters.rptCaption = "Opening Stock"

        'Formulas.Add("GroupOn2#S", "P")
        'Formulas.Add("GroupOn3#S", "")

        'Formulas.Add("Text1#S", "T")
        'Formulas.Add("Text2#S", "Y")
        'Formulas.Add("Text3#S", "H")

        'Formulas.Add("ReportCaption#S", ReportParameters.rptCaption)
        'Formulas.Add("ViewSize#N", 1)
        'Formulas.Add("DisplayRate#N", 1)
        'Formulas.Add("DisplayValue#N", 1)
        'Formulas.Add("RateFlag#S", "P")

        ReportParameters.rptFile = ReportPath & "\Reports\StockLevel.rpt"
        ReportParameters.rptFilter = "{ItemStock.CoBr_Id} = '" & SelBranchId & "'" '& StockParam & Series

        Dim frmView As New frmViewReports(Formulas)
        'frmView.MdiParent = Me.MdiParent
        frmView.Show()
    End Sub

    Private Sub txtPurRt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)


        'CalcMarkUp(False)
        'CalcMarkDown(False)

        'CalcMarkUp(True)
        'CalcMarkDown(True)

    End Sub

    Private Sub dtgDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDetails.Click
        If dtgDetails.CurrentRowIndex = -1 Or IsDBNull(dtgDetails.Item(dtgDetails.CurrentRowIndex, GridCols.StyleKey)) Then
            Common.ClearControls(grpDetails)
            Exit Sub
        End If


        With dtgDetails
            cmbDtlStyle.Value = .Item(.CurrentRowIndex, GridCols.StyleName)
            cmbDtlType.Value = .Item(.CurrentRowIndex, GridCols.TypeKey)
            cmbShade.Value = .Item(.CurrentRowIndex, GridCols.ShadeKey)
            cmbDtlBrand.Value = .Item(.CurrentRowIndex, GridCols.BrandKey)

            cmbSize.Value = .Item(.CurrentRowIndex, GridCols.SizeKey)
            txtMinLevel.Text = .Item(.CurrentRowIndex, GridCols.Min)
            txtMaxLevel.Text = .Item(.CurrentRowIndex, GridCols.Max)
            txtReOrderLevel.Text = .Item(.CurrentRowIndex, GridCols.ReOrder)
        
        
        End With
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

    Private Sub btnDtlDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDtlDelete.Click
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

            CalcTotal()

            ReCalcSerial(False)

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        End Try
    End Sub
    Private Sub ClearTextboxes()
        'cmbItmSubGroup.SelectedIndex = -1 : cmbStyle.SelectedIndex = -1 : cmbType.SelectedIndex = -1 : cmbBrand.SelectedIndex = -1
        ClearDetailTextBoxes()
    End Sub
    Private Sub ClearDetailTextBoxes()
        txtMinLevel.EditValue = 0 : txtMaxLevel.EditValue = 0 : txtReOrderLevel.EditValue = 0
        txtBillPurRate.EditValue = 0 : txtBillSaleRate.EditValue = 0 : cmbShade.SelectedIndex = -1 : cmbSize.SelectedIndex = -1
        cmbDtlStyle.SelectedIndex = -1 : cmbDtlType.SelectedIndex = -1 : cmbDtlBrand.SelectedIndex = -1
        txtImage.Clear()
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

   
    Private Sub btnShade_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        cmbShade.Focus()
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

    
  
    Private Sub dtpDocDt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChlnNo.KeyDown, txtPurDocNo.KeyDown, cmbItmSubGroup.KeyDown, cmbStyle.KeyDown, cmbShade.KeyDown, cmbSize.KeyDown, txtMinLevel.KeyDown, txtMaxLevel.KeyDown, txtReOrderLevel.KeyDown, dtpPurDocDt.KeyDownEvent, dtpChlnDate.KeyDownEvent
        MoveToNextControl(e)
    End Sub

    Private Sub dtgDetails_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgDetails.MouseUp
        If dtgDetails.CurrentRowIndex = -1 Then Exit Sub

        dtgDetails.Select(dtgDetails.CurrentRowIndex)
        dtgDetails_Click(dtgDetails, Nothing)
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

        RetrieveRecord(Item_Key)

        Search.Visible = False
        Search.SendToBack()
    End Sub

    Private Sub cmbItmSubGroup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItmSubGroup.SelectionChanged
        If cmbItmSubGroup.SelectedIndex = -1 Then Exit Sub

        dtgDetails.DataSource = Nothing
        cmbProduct.DataSource = Nothing : cmbProduct.Text = "" : cmbStyle.DataSource = Nothing : cmbStyle.Text = "" : cmbType.DataSource = Nothing : cmbType.Text = ""
        cmbBrand.DataSource = Nothing : cmbBrand.Text = ""
        Query = "Select ITEM_KEY, ITEM_NAME " _
            & " From Item Where Status = '1' " _
            & " And ItemSubGrp_Key = '" & cmbItmSubGroup.SelectedItem.DataValue & "'" _
            & BranchFilter _
            & " Order By Item_Name"
        Common.FillCombo2(Query, cmbProduct, "ITEM_NAME", "ITEM_KEY")

        FuncButtons.AddButton.Enabled = True

        'If cmbProduct.Items.Count > 0 Then
        '    cmbProduct.SelectedIndex = 0
        '    cmbProduct_SelectionChanged(cmbProduct, Nothing)
        'End If



    End Sub

    Public Sub SearchRecord() Implements IButtonProcs.SearchRecord
        Dim DisplayArray As New ArrayList

        With DisplayArray
            .Add(New DisplayColumns("Item_Name", GetSysCaptionAsPerId(SystemCaptionIdx.DefProduct), 130, "Item_Name"))
            .Add(New DisplayColumns("Style.Style_Code", GetSysCaptionAsPerId(SystemCaptionIdx.DefArticle), 120, "Style.Style_Code"))
            .Add(New DisplayColumns("Type_Name", GetSysCaptionAsPerId(SystemCaptionIdx.DefType), 65, "Type_Name"))
            .Add(New DisplayColumns("Shade_Name", GetSysCaptionAsPerId(SystemCaptionIdx.DefShade), 100, "Shade_Name"))
            .Add(New DisplayColumns("Size_Name", GetSysCaptionAsPerId(SystemCaptionIdx.DefSize), 40, "Size_Name"))
            .Add(New DisplayColumns("I.Min_Level", "Min Level", 70, "I.Min_Level"))
            .Add(New DisplayColumns("I.Max_Level", "Max Level", 70, "I.Max_Level"))
            .Add(New DisplayColumns("I.ReOrder_Level", "ReOrder Level", 80, "I.ReOrder_Level"))
            .Add(New DisplayColumns("Brand_Name", GetSysCaptionAsPerId(SystemCaptionIdx.DefBrand), 90, "Brand_Name"))

            .Add(New DisplayColumns("I.Doc_Id", "", 0, "I.Doc_Id"))
        End With

        With Search
            .Connect = Common.ConnectionString
            .Table = "ItemWiseStkLevel as I Inner Join Item On I.Item_Key = Item.Item_Key " _
                & " Inner Join Style On I.Style_Key = Style.Style_Key " _
                & " Inner Join Type On I.Type_Key = Type.Type_Key " _
                & " Inner Join Shade On I.Shade_Key = Shade.Shade_Key " _
                & " Inner Join ItemSize On I.ItemSize_Key = ItemSize.ItemSize_Key " _
                & " Inner Join Brand On Style.Brand_Key = Brand.Brand_Key "
             
            .UniqueId = "I.Doc_Id"
            .Where = "I.Doc_Id <> 0 " _
                & " And I.CoBr_Id = '" & SelBranchId & "' "
            .Order = "Order By Item_Name, Style_Code, Type.Abbr, Shade_Name, ItemSize.SeqNo"
            .DisplayArrayList = DisplayArray
            .Caption = Me.Text
            .ViewCloseButton = True
            .FormLoading = True
            .Visible = True
            .MyForm = Me
            .DisplaySearchRecords = True
            .LoadSearch()
            .BringToFront()
        End With
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

    Private Sub btnSizeQty_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSizeQty.Click
        If cmbProduct.SelectedIndex = -1 Then
            MsgBox("Product not specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbProduct.Focus()
            Exit Sub

        ElseIf cmbStyle.SelectedIndex = -1 Then
            MsgBox("Style not specified !", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbStyle.Focus()
            Exit Sub
        End If


        Try
            Me.Cursor = Cursors.WaitCursor

            If NewDesign Then
                If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSizeWiseRate))) Then
                    Dim Style_Key As String = StyleKey()
                    Query = "Select ItemSize.Size_Name, StyleSize.ItemSize_Key, MRP, SPrice, PurRate " _
                        & " from StyleSize Left Join ItemSize On ItemSize.ItemSize_Key = StyleSize.ItemSize_Key " _
                        & " Where StyleSize.Item_Key = '" & cmbProduct.Value & "'" _
                        & " And StyleSize.Style_Key = '" & Style_Key & "'" _
                        & " And StyleSize.CoBr_Id = '" & SelBranchId & "'" _
                        & " And ItemSize.Status = '1'  " _
                        & " Order By SeqNo"

                Else
                    Query = "Select Size_Name, ItemSize_Key " _
                        & " from ItemSize " _
                        & " Where Item_Key = '" & cmbProduct.Value & "'" _
                        & " And CoBr_Id = '" & SelBranchId & "'" _
                        & " And Status = '1' " _
                        & " Order By SeqNo"
                End If

                Dim ItemSize As DataTable = Common.GetDataTable(Query)
                Dim RecRow, NewRow As DataRow

                SizeDetails = Nothing
                dtgSize.DataSource = Nothing
                DisplaySizeGridHeaders()

                RowValChg = True
                For Each RecRow In ItemSize.Rows
                    If Not SizeCreatedForStyle(RecRow("ItemSize_Key") & "") Then
                        NewRow = SizeDetails.NewRow
                        NewRow(SizeGridCols.SizeName) = RecRow("Size_Name") & ""
                        NewRow(SizeGridCols.Min) = 0
                        NewRow(SizeGridCols.Max) = 0
                        NewRow(SizeGridCols.ReOrder) = 0
                        NewRow(SizeGridCols.SizeKey) = RecRow("ItemSize_Key") & ""
                        SizeDetails.Rows.Add(NewRow)
                    End If
                Next RecRow

                SizeDetails.AcceptChanges()
                ItemSize = Nothing
                RowValChg = False
                NewDesign = False
            End If

            'CalcSizeQtyAmountSum()
            CalcSizeQtyAmountSum()
            dtgSize.ReadOnly = False
            grpSize.Visible = True
            dtgDetails.Enabled = False
            grpDetails.Enabled = False

            grpSize.BringToFront()
            Dim dgc As New DataGridCell(0, SizeGridCols.Min)
            dtgSize.CurrentCell = dgc
            dtgSize.Focus()




        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
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

    Private Sub btnSizeConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSizeConfirm.Click
        SizeDetails.AcceptChanges()
        CalcSizeQtyTotal()
        lblSizeQty.Text = lblTotSizeMinQty.Text
        btnSizeCancel_Click(btnSizeCancel, Nothing)
  
        If Val(txtMinLevel.Text) <> 0 Or Val(txtMaxLevel.Text) <> 0 Or Val(txtReOrderLevel.Text) <> 0 Then
            txtMinLevel.Enabled = False : txtMaxLevel.Enabled = False : txtReOrderLevel.Enabled = False
            NewDesign = False
            btnDtlSave.Focus()
        Else
            txtMinLevel.Text = 0
            txtMinLevel.Enabled = True : txtMaxLevel.Enabled = True : txtReOrderLevel.Enabled = True
            NewDesign = True
            cmbSize.Focus()
        End If
    End Sub
    Private Sub CalcSizeQtyAmountSum()
        lblTotSizeMaxQty.Text = 0 : lblTotSizeMinQty.Text = 0 : lblTotSizeReOrderQty.Text = 0

        If IsNothing(SizeDetails) Then Exit Sub
        If SizeDetails.Rows.Count = 0 Then Exit Sub
        Dim RecRow As DataRow
        Dim Min As Double = 0
        Dim Max As Double = 0
        Dim ReOrder As Double = 0

        For Each RecRow In SizeDetails.Rows
            Min += RecRow(SizeGridCols.Min)
            Max += RecRow(SizeGridCols.Max)
            ReOrder += RecRow(SizeGridCols.ReOrder)
        Next RecRow

        lblTotSizeMaxQty.Text = Format$(Max, "0.00")
        lblTotSizeMinQty.Text = Format$(Min, "0.00")
        lblTotSizeReOrderQty.Text = Format$(ReOrder, "0.00")

     
    End Sub



    Private Sub CalcSizeQtyTotal()
        lblSizeQty.Text = ""
        If IsNothing(SizeDetails) Then Exit Sub
        If SizeDetails.Rows.Count = 0 Then Exit Sub

        ' Dim ActQty As Double = SizeDetails.Compute("Sum(Qty)", "")
        Dim RecRow As DataRow

        'lblSizeQty.Text = Format$(ActQty, "0.00")

        For Each RecRow In SizeDetails.Rows
            If RecRow(SizeGridCols.Min) > 0 Or RecRow(SizeGridCols.Max) > 0 Or RecRow(SizeGridCols.ReOrder) > 0 Then
                cmbSize.Value = RecRow(SizeGridCols.SizeKey)
                txtMinLevel.EditValue = RecRow(SizeGridCols.Min)
                txtMaxLevel.EditValue = RecRow(SizeGridCols.Max)
                txtReOrderLevel.EditValue = RecRow(SizeGridCols.ReOrder)

                Exit Sub
            End If
        Next RecRow
    End Sub

    Private Sub ConfirmSizeDetails()
        Dim SizeRow As DataRow
        Dim NewRow As DataRow
        Dim ConvUnit As String = ""
        Dim ConvQty As Double

        Me.Cursor = Cursors.WaitCursor

        For Each SizeRow In SizeDetails.Rows
            If SizeRow(SizeGridCols.Min) > 0 Or SizeRow(SizeGridCols.Max) > 0 Or SizeRow(SizeGridCols.ReOrder) > 0 Then
                ConvUnit = "" : ConvQty = 0

                NewRow = Details.NewRow


                NewRow(GridCols.StyleName) = cmbDtlStyle.Text
                NewRow(GridCols.TypeName) = cmbDtlType.Text
                NewRow(GridCols.ShadeName) = cmbShade.Text
                NewRow(GridCols.SizeName) = SizeRow(SizeGridCols.SizeName)
                NewRow(GridCols.BrandName) = cmbDtlBrand.Text
                NewRow(GridCols.StyleKey) = StyleKeyDtl()
                NewRow(GridCols.TypeKey) = cmbDtlType.SelectedItem.DataValue
                NewRow(GridCols.ShadeKey) = cmbShade.SelectedItem.DataValue
                NewRow(GridCols.SizeKey) = SizeRow(SizeGridCols.SizeKey)
                NewRow(GridCols.BrandKey) = cmbDtlBrand.SelectedItem.DataValue

                NewRow(GridCols.Min) = SizeRow(SizeGridCols.Min)
                NewRow(GridCols.Max) = SizeRow(SizeGridCols.Max)
                NewRow(GridCols.ReOrder) = SizeRow(SizeGridCols.ReOrder)
                NewRow(GridCols.DetailId) = 0
                NewRow(GridCols.RecStatus) = 1

                Details.Rows.Add(NewRow)
            End If
        Next SizeRow

        Details.AcceptChanges()

        ReCalcSerial(False)
        btnDtlCancel_Click(btnDtlCancel, Nothing)

        'If Details.Rows.Count > 0 Then
        '    dtgDetails.CurrentRowIndex = Details.Rows.Count - 1
        '    dtgDetails_Click(dtgDetails, Nothing)
        'End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSizeCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSizeCancel.Click
        SizeDetails.RejectChanges()
        grpSize.Visible = False
        'grpMain.Enabled = True
        'dtgDetails.Enabled = True
        grpDetails.Enabled = True

        Dim Qty As Double
        ' Dim RecRow As DataRow

        'For Each RecRow In SizeDetails.Rows
        '    Qty += RecRow(SizeGridCols.ActualQty)
        'Next RecRow
        If Qty = 0 Then
            NewDesign = True
        End If
        cmbSize.Focus()

    End Sub


   

    Private Sub SizeDetails_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles SizeDetails.ColumnChanged
        If RowValChg Then Exit Sub

        If e.Column.Ordinal = SizeGridCols.Max _
            Or e.Column.Ordinal = SizeGridCols.Min _
            Or e.Column.Ordinal = SizeGridCols.ReOrder Then
            CalcSizeQtyAmountSum()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If Not grpSize.Visible Then Exit Function

        Dim rowNumber, rowCount, colNumber As Integer
        Dim ColPos As Byte

        If keyData = Keys.Return Then
            If Me.ActiveControl.Parent Is CType(dtgSize, DataGrid) Or Me.ActiveControl Is CType(dtgSize, DataGrid) Then
                rowNumber = dtgSize.CurrentCell.RowNumber
                colNumber = dtgSize.CurrentCell.ColumnNumber
                rowCount = SizeDetails.Rows.Count

              
                If colNumber < ColPos Then
                    'If Not CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSizeWiseRate))) Then
                    '    If colNumber + 1 = SizeGridCols.PurRate Then
                    '        'colNumber = SizeGridCols.AltBarcode
                    '    Else
                    '        colNumber += 1
                    '    End If
                    'Else
                    '    colNumber += 1
                    'End If

                Else
                    'colNumber = SizeGridCols.BillQty

                    If rowNumber + 1 < rowCount - 1 Then
                        rowNumber += 1
                    ElseIf rowNumber + 1 = rowCount - 1 Then
                        rowNumber = rowCount - 1
                    Else
                        btnSizeConfirm.Focus()
                        Exit Function
                    End If
                End If
                dtgSize.CurrentCell = New DataGridCell(rowNumber, colNumber)
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

        Try
            Me.Cursor = Cursors.WaitCursor
          
            Dim Brand As String = ""

            Query = "Select ITEMSIZE_KEY, SIZE_NAME " _
                & " From ItemSize Where Status = '1' " _
                & " And Item_Key = '" & cmbProduct.Value & "'" _
                & BranchFilter _
                & " Order By SeqNo"
            Common.FillCombo2(Query, cmbSize, "SIZE_NAME", "ITEMSIZE_KEY")

            If cmbSize.Items.Count > 0 Then
                cmbSize.SelectedIndex = 0
            End If

            Dim strFilter As String = ""

            If cmbStyle.Text = "( ALL )" Then
                strFilter = ""
            Else
                strFilter = " AND I.Style_Key = " & StyleKey() & ""
            End If

            If cmbBrand.Text = "( ALL )" Then
                Brand = ""
            Else
                Brand = " AND Style.Brand_Key = '" & cmbBrand.Value & "'"
            End If


            DisplayGridHeaders()

            Query = "Select row_number() OVER (ORDER BY doc_Id) As SrNo,Style.Style_Code, Type_Name,Shade.Shade_Name,ItemSize.Size_Name, Brand_Name,I.Min_Level,I.Max_Level,I.ReOrder_Level," _
                & " I.Doc_Id as DetailId,0 as RecStatus,I.Style_Key,I.Type_Key,I.Shade_Key, I.ItemSize_Key ,Style.Brand_Key " _
                & " From ItemWiseStkLevel as I Inner Join Item On I.Item_Key = Item.Item_Key " _
                & " Inner Join Style On I.Style_Key = Style.Style_Key " _
                & " Inner Join Type On I.Type_Key = Type.Type_Key " _
                & " Inner Join Shade On I.Shade_Key = Shade.Shade_Key " _
                & " Inner Join ItemSize On I.ItemSize_Key = ItemSize.ItemSize_Key " _
                & " Inner Join Brand On Style.Brand_Key = Brand.Brand_Key " _
                & " Where I.Item_Key = '" & cmbProduct.Value & "'  " _
                & " And I.CoBr_Id = '" & SelBranchId & "'" & strFilter & Brand



            Details = Common.GetDataTable(Query)

            dtgDetails.DataSource = Details
            FormatDetailGrid(Details)
            If Details.Rows.Count > 0 Then

                dtgDetails.CurrentRowIndex = Details.Rows.Count - 1
                dtgDetails_Click(dtgDetails, Nothing)

                ReCalcSerial(False)
                CalcTotal()
            End If

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub CalcTotal()
        lblTotRecords.Text = "0"

        If IsNothing(Details) Or Details.Rows.Count = 0 Then Exit Sub
        lblTotRecords.Text = Details.Rows.Count

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
    Private Sub cmbStyle_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyle.SelectionChanged
        If cmbStyle.SelectedIndex = -1 Then Exit Sub

        cmbType.DataSource = Nothing : cmbType.Text = ""


        Query = "Select Distinct Type.TYPE_KEY, TYPE_NAME " _
            & " From Style Inner Join Type On Style.Type_Key = Type.Type_Key " _
            & " Where Type.Status = '1' " _
            & " And Style_Code = '" & cmbStyle.Value & "' " _
            & " Order By Type_Name"
        Common.FillCombo2(Query, cmbType, "TYPE_NAME", "TYPE_KEY")

        If cmbType.Items.Count > 0 Then
            cmbType.SelectedIndex = 0
        End If

        cmbType_SelectionChanged(cmbType, Nothing)
        DisplayStockDetails()
    End Sub

    Private Sub DisplayStyleDetails()

        Dim strFilter As String = ""

        If cmbStyle.Text = "( ALL )" Then
            strFilter = ""
        Else
            strFilter = "AND  Style.Style_Key = '" & StyleKey() & "'"
        End If

        NewDesign = True : txtMinLevel.Enabled = True

        Dim Style_Key As String = StyleKey()


        If cmbStyle.SelectedIndex = -1 Then Exit Sub

       
      
    End Sub
    Private Sub DisplayStyleDtlDetails()

        NewDesign = True : txtMinLevel.Text = 0 : txtMinLevel.Enabled = True


        If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenUseSizeWiseRate))) Then
            cmbSize.DataSource = Nothing
            Dim StyleDtl_Key As String = StyleKeyDtl()
            Query = "Select StyleSize.ItemSize_Key ITEMSIZE_KEY, ItemSize.Size_Name SIZE_NAME " _
                & " from StyleSize Left Join ItemSize On ItemSize.ItemSize_Key = StyleSize.ItemSize_Key " _
                & " Where StyleSize.Item_Key = '" & cmbProduct.Value & "'" _
                & " And StyleSize.Style_Key = '" & StyleDtl_Key & "'" _
                & " And StyleSize.CoBr_Id = '" & SelBranchId & "'" _
                & " And ItemSize.Status = '1'  " _
                & " Order By SeqNo"
            Common.FillCombo2(Query, cmbSize, "SIZE_NAME", "ITEMSIZE_KEY")

            If cmbSize.Items.Count > 0 Then
                cmbSize.SelectedIndex = 0
            End If
        End If

        cmbDtlBrand.DataSource = Nothing : cmbDtlBrand.Text = ""

        If cmbDtlStyle.SelectedIndex = -1 Or cmbDtlType.SelectedIndex = -1 Then Exit Sub


        Query = " Select Brand.BRAND_KEY, Brand.BRAND_NAME " _
               & " From Brand Left Join Style on Brand.Brand_Key=Style.Brand_Key  Where Style.Style_Key = '" & StyleKeyDtl() & "' and Style.Status = '1' And Brand_Name <> '' " _
                & " Order By Brand_Name"
        Common.FillCombo2(Query, cmbDtlBrand, "BRAND_NAME", "BRAND_KEY")

        If cmbDtlBrand.Items.Count > 0 Then
            cmbDtlBrand.SelectedIndex = 0
        End If


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
            & " And Item_Key = '" & cmbProduct.Value & "'" _
            & " And CoBr_Id = '" & SelBranchId & "'"

        If cmbType.SelectedIndex <> -1 Then
            Query = Query + " And Type_Key = '" & cmbType.Value & "'"
        End If

        Dim StyleData As DataTable = Common.GetDataTable(Query)
        Dim Style As String = ""

        If StyleData.Rows.Count > 0 Then
            Return StyleData.Rows(0)(0) & ""

            'Else
            '    Dim NewStyleName As String = cmbStyle.Text
            '    Dim StyleId As Integer = Common.NewRecordId("Style", "Style_Id", Nothing)

            '    StyleKey = SelBranchId & StyleId

            '    Query = "Exec Insert_Style '" & SelBranchId & "'," & StyleId & ",'" & SelBranchId & StyleId & "','" & NewStyleName & "','" & cmbProduct.Value & "','" & cmbType.Value & "','','" & cmbBrand.Value & "','" & cmbQuality.Value & "','" & cmbSeason.Value & "','" & cmbOccassion.Value & "','" & txtSuplStyle.Text & "','B',''," & txtPurRt.EditValue & "," & txtMRP.EditValue & "," & txtSaleRate.EditValue & ",0,0,0,0,0,'','1'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm:ss tt") & "'"
            '    Common.ExecuteQuery(Query)

            '    Return StyleKey
        End If

        StyleData = Nothing
        Return ""
    End Function

    Private Function StyleKeyDtl() As String
        Query = "Select Style_Key " _
            & " From Style " _
            & " Where Style_Code = '" & ReplaceApostrophe(cmbDtlStyle.Text) & "'" _
            & " And Type_Key = '" & cmbDtlType.Value & "'" _
            & " And Item_Key = '" & cmbProduct.Value & "'" _
            & " And CoBr_Id = '" & SelBranchId & "'"
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

    Private Sub cmbStyle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStyle.Validated
        If cmbStyle.SelectedIndex = -1 Then cmbStyle.SelectedIndex = 0
    End Sub

    Private Sub cmbType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbType.KeyDown
        If e.KeyCode = Keys.Enter Then
            FuncButtons.EditButton.Focus()
        End If
    End Sub

    Private Sub cmbType_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectionChanged
        DisplayStyleDetails()
        DisplayStockDetails()
    End Sub

    Private Sub cmbType_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.Validated
        If cmbType.SelectedIndex = -1 Then cmbType.SelectedIndex = 0
    End Sub

    Private Sub cmbBrand_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBrand.Validated
        If cmbBrand.SelectedIndex = -1 Then cmbBrand.SelectedIndex = 0
    End Sub

    Private Sub cmbShade_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbShade.Validated
        If cmbShade.SelectedIndex = -1 Then cmbShade.SelectedIndex = 0
    End Sub

    Public Sub ButtonBehaveAsPerRights() Implements IButtonProcs.ButtonBehaveAsPerRights
        ButtonRights(FuncButtons, CurrModule)

        FuncButtons.AddButton.Enabled = True
        If Not IsNothing(dtgDetails.DataSource) Then
            FuncButtons.AddButton.Enabled = False
        End If
    End Sub

    Private Sub txtMRP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'CalcMarkUp(True)  04/06/2012
        'CalcMarkDown(False)
        'CalcMarkDown(True)

    End Sub

    
    Private Sub btnStyle_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        NewRecordId = "" : frmStyle.Style = True
        If IsNothing(cmbProduct.Value) Or cmbProduct.Text.Trim.Length = 0 Then
            NewRecordId = ""
        Else
            NewRecordId = cmbProduct.Value
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
                 & " Where Item_Key = '" & cmbProduct.Value & "' " _
                 & " And Status = '1' " _
                 & " Order By STYLE.Style_Code"
        Common.FillCombo2(Query, cmbDtlStyle, "STYLE_CODE", "STYLE_CODE")

        Query = "Select DISTINCT STYLE_CODE, STYLE_CODE From Style " _
         & " Where Item_Key = '" & cmbProduct.Value & "' and  Brand_Key='" & cmbBrand.Value & "' " _
         & " And Status = '1' " _
         & " Order By STYLE.Style_Code"
        Dim dtStyle As DataTable = Common.GetDataTableWithAll(Query)

        With cmbStyle
            .DataSource = dtStyle
            .DisplayMember = "STYLE_CODE1"
            .ValueMember = "STYLE_CODE"
        End With

        If cmbStyle.Items.Count > 0 Then
            cmbStyle.SelectedIndex = 0
        End If
        DisplayStockDetails()


    End Sub

    Private Sub cmbDtlStyle_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDtlStyle.SelectionChanged
        If cmbDtlStyle.SelectedIndex = -1 Then Exit Sub
        cmbDtlType.DataSource = Nothing : cmbDtlType.Text = "" : cmbDtlBrand.DataSource = Nothing : cmbDtlBrand.Text = ""
    

        Query = "Select Distinct Type.TYPE_KEY, TYPE_NAME " _
            & " From Style Inner Join Type On Style.Type_Key = Type.Type_Key " _
            & " Where Type.Status = '1' " _
            & " And Style_Code = '" & cmbDtlStyle.Value & "'" _
            & " Order By Type_Name"
        Common.FillCombo2(Query, cmbDtlType, "TYPE_NAME", "TYPE_KEY")

        If cmbDtlType.Items.Count > 0 Then
            cmbDtlType.SelectedIndex = 0
            cmbDtlType_SelectionChanged(cmbDtlType, Nothing)
        End If

    End Sub

    Private Sub cmbDtlType_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDtlType.SelectionChanged
        DisplayStyleDtlDetails()
    End Sub

   
    Private Sub cmbDtlBrand_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDtlBrand.Validated
        If cmbDtlBrand.SelectedIndex = -1 Then cmbDtlBrand.SelectedIndex = 0
    End Sub

    Private Sub cmbDtlStyle_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDtlStyle.Validated
        If cmbDtlStyle.SelectedIndex = -1 Then cmbDtlStyle.SelectedIndex = 0
    End Sub

    Private Sub cmbDtlType_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDtlType.Validated
        If cmbDtlType.SelectedIndex = -1 Then cmbDtlType.SelectedIndex = 0
    End Sub

    Private Sub cmbProduct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProduct.Validated
        If cmbProduct.SelectedIndex = -1 Then cmbProduct.SelectedIndex = 0
    End Sub

    Private Sub cmbSize_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSize.Validated
        If cmbSize.SelectedIndex = -1 Then cmbSize.SelectedIndex = 0
    End Sub
End Class