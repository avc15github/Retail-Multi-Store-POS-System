Imports System.Data.SqlClient

Public Class frmReleaseLockFast

    Private Sub frmReleaseLock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmChangeLockStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Query = "Select '<< ALL >>' CATEGORY, '<< ALL >>' MOD_DESC" _
            & " UNION ALL " _
            & " Select CATEGORY, MOD_DESC " _
            & " From Modules " _
            & " Where Parent_Id = 0 And Category In ('C','B') " _
            & " Order By Category"
        Common.FillCombo2(Query, cmbMenu, "MOD_DESC", "CATEGORY")

        cmbMenu.SelectedIndex = 0

        
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If chkLstRecordId.CheckedItems.Count = 0 Then Exit Sub

        If MsgBox("Release locked records for selected transaction ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Dim obj As Object

        Dim DocType As String = ""
        If lstTables.Items(lstTables.SelectedIndex) = "Retail Invoice" Then
            DocType = " Doc_Type = 'SI'"
        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Sales Return" Then
            DocType = " Doc_Type = 'SR'"
        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Goods on Approval" Then
            DocType = " Doc_Type = 'GA'"
        ElseIf lstTables.Items(lstTables.SelectedIndex) = "Approval Return" Then
            DocType = " Doc_Type = 'AR'"
        End If
        If chkLstRecordId.GetItemChecked(0) Then            
            Query = "Update " & GetTableName(lstTables.Items(lstTables.SelectedIndex).ToString) & " Set Edit_Status = '' " & IIf(DocType <> "", "Where " & DocType & "", "") & " "
            Common.ExecuteQuery(Query)
        Else
            For Each obj In chkLstRecordId.CheckedItems
                Query = "Update " & GetTableName(lstTables.Items(lstTables.SelectedIndex).ToString) & " Set Edit_Status = '' " _
                        & " Where Doc_Key = '" & CType(obj, DataRowView)(0) & "' " & IIf(DocType <> "", "And " & DocType & "", "") & " "
                Common.ExecuteQuery(Query)
            Next obj
        End If

        
        lstTables_DoubleClick(lstTables, Nothing)
    End Sub


    'Private Function GetDocType(ByVal ModDesc As String) As String
    '    Dim DocType As String = ""

    '    Query = "SELECT Doc_Type  FROM Bill With(NoLock) " _
    '        & " WHERE Mod_Desc = '" & ModDesc & "'"
    '    Dim DtDocType As DataTable = Common.GetDataTable(Query)

    '    If DtDocType.Rows.Count > 0 Then
    '        DocType = DtDocType.Rows(0).Item("Doc_Type")
    '    End If

    '    Return DocType
    'End Function

    Private Function GetTableName(ByVal ModDesc As String) As String
        Dim TableName As String = ""

        Query = "SELECT TableName  FROM Modules With(NoLock) " _
            & " WHERE Mod_Desc = '" & ModDesc & "'"
        Dim DtTableName As DataTable = Common.GetDataTable(Query)

        If DtTableName.Rows.Count > 0 Then
            TableName = DtTableName.Rows(0).Item("TableName")
        End If

        Return TableName
    End Function

    Private Sub lstTables_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTables.DoubleClick

        Query = "Select 'ALL' DOC_KEY, 'ALL' DOC_NO " _
               & " Union All " _
               & " Select DOC_KEY, DOC_NO " _
               & " From " & GetTableName(lstTables.Items(lstTables.SelectedIndex).ToString) & " With(NoLock) " _
               & " Where Edit_Status = '1' " _
               & " And Doc_Key <> '' " _
               & " And CoBr_Id = '" & SelBranchId & "' And FcYr_Id = " & SelYearId _
               & " Order By Doc_No"

        Common.FillInListBox(Query, chkLstRecordId, "DOC_NO", "DOC_KEY")

        Dim i As Short

        For i = 0 To chkLstRecordId.Items.Count - 1
            chkLstRecordId.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        DisplayRights()
    End Sub


    Private Sub DisplayRights()
        Try
            Dim ModCat As String = ""

            Me.Cursor = Cursors.WaitCursor
            lstTables.Items.Clear()
            If cmbMenu.SelectedIndex > 0 Then
                ModCat = " And Modules.Category = '" & cmbMenu.Value & "'"
            Else
                ModCat = " And Modules.Category In ('C','B')"
            End If

            Query = " Select Case When TreeLevel = 0 Then '' + Mod_Desc When TreeLevel = 1 Then '' + Mod_Desc When TreeLevel = 2 Then '      ' + Mod_Desc When TreeLevel = 3 Then '            ' + Mod_Desc Else '  ' + Mod_Desc End Mod_Desc, Mod_Name, ModReq AllowAccess, IsNull(Parent_Id, 0) Parent_Id, Modules.Mod_Id, Seqno, Category, HasChild, IsReport " _
                & " From Modules " _
                & " Inner Join UserRights On Modules.Mod_Id = UserRights.Mod_Id " _
                & " Where Parent_Id > 0 And User_Id = " & UserId & " And UserRights.AllowAccess = '1' And RecordUnLock = 1 And Modreq = 1  " & ModCat _
                & " Order By Category, SeqNo"
            Dim UserRights As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow
            For Each RecRow In UserRights.Rows
                With lstTables.Items
                    .Add(RecRow("Mod_Desc"))
                End With
            Next

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then

            For i = 0 To lstTables.Items.Count - 1                              
                If lstTables.Items(i).ToString.ToLower.StartsWith(txtSearch.Text.Trim().ToLower) Then
                    lstTables.SelectedIndex = i                   
                End If
            Next
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown

    End Sub
End Class