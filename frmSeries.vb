Imports System.Data.SqlClient

Public Class frmSeries

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSeries_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmSeries_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbSeriesFor.Items.Clear()

        With cmbSeriesFor.Items
            .Add("<<ALL>>")
            .Add("Masters")
            .Add("Transaction")
        End With

        cmbSeriesFor.SelectedIndex = 0
    End Sub

    Private Sub cmbSeriesFor_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSeriesFor.SelectionChanged
        Dim strCoBr_Id As String = ""

        If cmbSeriesFor.SelectedIndex = -1 Then Exit Sub

        If cmbSeriesFor.SelectedIndex = 0 Then
            Query = "SELECT Distinct REC_ID, SR_TYPE, SR_FOR, SR_CODE, DOC_NO_GENERATEONSAVE, SR_AUTO_INCR_LOCK, STATUS " _
                & " FROM SERIES  With(NoLock) " _
                & " WHERE REC_ID <> 0 AND COBR_ID = '" & SelBranchId & "' And Status = '1'" _
                & " ORDER BY REC_ID"

        ElseIf cmbSeriesFor.SelectedIndex = 1 Then
            Query = "SELECT Distinct REC_ID, SR_TYPE, SR_FOR, SR_CODE, DOC_NO_GENERATEONSAVE, SR_AUTO_INCR_LOCK, STATUS " _
                & " FROM SERIES  With(NoLock)  " _
                & " WHERE REC_ID <> 0 AND SR_TYPE = 'M' AND COBR_ID = '" & SelBranchId & "' And Status = '1'" _
                & " ORDER BY REC_ID"

        ElseIf cmbSeriesFor.SelectedIndex = 2 Then
            Query = "SELECT Distinct REC_ID, SR_TYPE, SR_FOR, SR_CODE, DOC_NO_GENERATEONSAVE, SR_AUTO_INCR_LOCK, STATUS " _
                & " FROM SERIES  With(NoLock) " _
                & " WHERE REC_ID <> 0 AND SR_TYPE = 'T' AND COBR_ID = '" & SelBranchId & "' And Status = '1'" _
                & " ORDER BY REC_ID"
        End If

        Dim DtTable As DataTable = Common.GetDataTable(Query)
        DtTable.DefaultView.AllowNew = False
        DtTable.DefaultView.AllowDelete = False
        dtgSeries.DataSource = DtTable
        Call DisplaySeriesHeader(DtTable)
    End Sub

    Private Sub DisplaySeriesHeader(ByVal dtTable As DataTable)
        Dim tblStyle As New DataGridTableStyle '= GridColumnCreateAndFormat.CreateTableStyle(dtTable.TableName)

        With tblStyle
            .MappingName = dtTable.TableName
            .HeaderFont = New System.Drawing.Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point)
            .RowHeaderWidth = 12
            .ReadOnly = False
            .AllowSorting = True
            .ForeColor = Color.DarkBlue
            .SelectionBackColor = Color.Lavender
            .SelectionForeColor = Color.DarkBlue
            .GridLineColor = Color.SteelBlue
            .HeaderForeColor = Color.Maroon
        End With

        Dim colId As New DataGridTextBoxColumn
        With colId
            .Alignment = HorizontalAlignment.Right
            .MappingName = dtTable.Columns(0).ColumnName
            .HeaderText = "ID..."
            .ReadOnly = True
            .Width = 30
        End With

        Dim colType As New DataGridTextBoxColumn
        With colType
            .MappingName = dtTable.Columns(1).ColumnName
            .HeaderText = "Type"
            .ReadOnly = True
            .Width = 40
        End With

        Dim colFormName As New DataGridTextBoxColumn
        With colFormName
            .MappingName = dtTable.Columns(2).ColumnName
            .HeaderText = "Form Name"
            .Width = 200
            .ReadOnly = True
        End With

        Dim colSeries As New DataGridTextBoxColumn
        With colSeries
            .MappingName = dtTable.Columns(3).ColumnName
            .HeaderText = "Series"
            .Width = 50
            .TextBox.MaxLength = 2
        End With

        Dim colMultiSrAllow As New DataGridBoolColumn
        With colMultiSrAllow
            .MappingName = dtTable.Columns(4).ColumnName
            .HeaderText = "Gen Doc No On Save"
            .Width = 130
            .TrueValue = "Y"
            .FalseValue = "N"
            .AllowNull = False
        End With

        Dim colAutoIncrLock As New DataGridBoolColumn
        With colAutoIncrLock
            .MappingName = dtTable.Columns(5).ColumnName
            .HeaderText = "Auto Incr Lock "
            .Width = 100
            .TrueValue = "Y"
            .FalseValue = "N"
            .AllowNull = False
        End With

        Dim colStatus As New DataGridBoolColumn
        With colStatus
            .MappingName = dtTable.Columns(6).ColumnName
            .HeaderText = ""
            .Width = 0
            .TrueValue = "1"
            .FalseValue = "0"
            .AllowNull = False
        End With

        tblStyle.GridColumnStyles.Clear()
        tblStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {colId, colType, colFormName, colSeries, colMultiSrAllow, colAutoIncrLock, colStatus})
        colId = Nothing : colType = Nothing : colFormName = Nothing
        colSeries = Nothing : colMultiSrAllow = Nothing : colAutoIncrLock = Nothing
        colStatus = Nothing

        dtgSeries.TableStyles.Clear()
        dtgSeries.TableStyles.Add(tblStyle)
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Trans As SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()
            Dim DtSeries As DataTable = CType(dtgSeries.DataSource, DataTable)

            Dim drRow As DataRow

            For Each drRow In DtSeries.Rows
                Query = "UPDATE SERIES " _
                    & " SET SR_CODE = '" & drRow("Sr_Code") & "', " _
                    & " SR_AUTO_INCR_LOCK = '" & drRow("SR_AUTO_INCR_LOCK") & "', " _
                    & " DOC_NO_GENERATEONSAVE = '" & drRow("DOC_NO_GENERATEONSAVE") & "', " _
                    & " STATUS = '" & drRow("STATUS") & "', " _
                    & " UPDATED_BY = " & UserId & ", UPDATED_DT = '" & Format$(Now.Date, "MM/dd/yyyy") & "'" _
                    & " WHERE REC_ID = " & drRow("REC_ID") _
                    & " And CoBr_Id = '" & SelBranchId & "'"
                Call Common.ExecuteQuery(Query, Trans)
            Next drRow

            Trans.Commit()
            DtSeries = Nothing

            MsgBox("Updation complete", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))

        Catch sqlEx As SqlException
            Trans.Rollback()
            Call Common.LogAndDisplayException(sqlEx)

        Catch ex As Exception
            Trans.Rollback()
            Call Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Return Then
            If Me.ActiveControl.Parent Is CType(dtgSeries, DataGrid) Or Me.ActiveControl Is CType(dtgSeries, DataGrid) Then
                Dim currentCell As DataGridCell = dtgSeries.CurrentCell
                Dim rowNumber As Integer = currentCell.RowNumber
                Dim rowCount As Integer = CType(dtgSeries.DataSource, DataTable).Rows.Count
                Dim colNumber As Integer = currentCell.ColumnNumber

                If colNumber < 6 Then
                    colNumber += 1
                Else
                    colNumber = 3
                    If rowNumber + 1 <= rowCount - 1 Then rowNumber += 1
                End If

                dtgSeries.CurrentCell = New DataGridCell(rowNumber, colNumber)
            End If
        End If
    End Function
End Class