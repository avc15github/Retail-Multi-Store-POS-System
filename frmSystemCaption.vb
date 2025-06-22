
Public Class frmSystemCaption

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSystemCaption_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmSystemCaption_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            DisplayDetails()

        Catch sqlEx As SqlClient.SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DisplayDetails()
        Query = "Select SystemName, DefCaption, SysId " _
            & " From SystemCaption " _
            & " Where SysId > 0 " _
            & " Order By SysId"
        Dim SysCaption As DataTable = Common.GetDataTable(Query)

        dgvCaption.DataSource = SysCaption
        FormatGrid(SysCaption)

        SystemCaption = Nothing
        Query = "Select SysId, SystemName, DefCaption From SystemCaption"
        SystemCaption = Common.GetDataTable(Query)

        'For i = 0 To dgvCaption.Rows.Count - 1
        '    If dgvCaption.Item("SysId", i).Value = 10 Or dgvCaption.Item("SysId", i).Value = 12 Then
        '        dgvCaption.Item("SystemName", i).Value = "Null"
        '        dgvCaption.Item("DefCaption", i).Value = "Null"
        '        dgvCaption.Item("SysId", i).Value = 0

        '        dgvCaption.Rows(i).Height = 0
        '        dgvCaption.Rows(i).Visible = False
        '    End If
        'Next i

        If SysCaption.Rows.Count > 0 Then
            dgvCaption.CurrentCell = dgvCaption(1, 0)
            dgvCaption.CurrentCell.Selected = True
        End If
    End Sub

    Private Sub FormatGrid(ByVal Table As DataTable)
        With dgvCaption
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AutoGenerateColumns = False
            .RowHeadersWidth = 21
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .VirtualMode = True
            .DataSource = Table
            .ReadOnly = False

            .ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 9, FontStyle.Bold, GraphicsUnit.Point)
            .DefaultCellStyle.Font = New Font("Calibri", 9, FontStyle.Regular, GraphicsUnit.Point)
            .DefaultCellStyle.ForeColor = Color.Navy
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        End With

        dgvCaption.Columns(0).HeaderText = "System Name"
        dgvCaption.Columns(0).Width = 110
        dgvCaption.Columns(0).ReadOnly = True
        dgvCaption.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable

        dgvCaption.Columns(1).HeaderText = "Default Caption"
        dgvCaption.Columns(1).Width = 150
        dgvCaption.Columns(1).ReadOnly = False
        dgvCaption.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable

        dgvCaption.Columns(2).Width = 0
        dgvCaption.Columns(2).Visible = False
        dgvCaption.Columns(2).ReadOnly = True
        dgvCaption.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Details As DataTable = CType(dgvCaption.DataSource, DataTable)

        If IsNothing(Details) Then Exit Sub
        If Details.Rows.Count = 0 Then Exit Sub

        Dim RecRow As DataRow
        Dim Trans As SqlClient.SqlTransaction = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Trans = CreateSQLTransaction()

            For Each RecRow In Details.Rows
                Query = "Update SystemCaption Set DefCaption = '" & ReplaceApostrophe(RecRow(1)) & "'" _
                    & " Where SysId = " & RecRow(2)
                Common.ExecuteQuery(Query, Trans)
            Next RecRow

            Trans.Commit()

            MsgBox("Data updated successfully", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))

            DisplayDetails()

        Catch sqlEx As SqlClient.SqlException
            Common.LogAndDisplayException(sqlEx)
            Trans.Rollback()
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Trans.Rollback()
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class