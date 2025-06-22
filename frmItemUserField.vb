Imports System.Data.SqlClient

Public Class frmItemUserField
    Implements IButtonProcs
    Dim Field_Type As Char
    Dim Field_Name As String = ""
    Dim Datatype As String = ""
    Dim RecordId As String
    Dim EditMode As Boolean
    Public Shared State As Boolean
    Dim CurrModule As String = "ndState"


    Private Sub frmState_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If FuncButtons.EditButton.Text.ToUpper <> CancelCaption.ToUpper Then
            ButtonRights(FuncButtons, CurrModule)
        End If
    End Sub

    Private Sub frmState_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NewRecordId = RecordId
    End Sub

    Private Sub frmState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If grpMain.Enabled = True Then
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmState_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CreateSearchWindow()

        With cmbFieldType.Items
            .Add("Text")
            .Add("Date Time")
            .Add("Fractional Number")
            .Add("Number")
            .Add("Check Box")
        End With

        FuncButtons.FormObj = Me
        grpMain.Enabled = False

        If State And NewRecordId <> "" Then
            Search.CurrentRecord = NewRecordId
            RetrieveRecord(NewRecordId)
            Search.LoadSearch()
        End If
        chkStatus.Enabled = True
        chkStatus.Checked = False

        ' chkAllBranch.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiBranch)))

    End Sub

    Private Sub Search_CurrentRecordId(ByRef CurrId As String) Handles Search.CurrentRecordId
        RetrieveRecord(CurrId)
    End Sub

    Public Sub AddRecord() Implements IButtonProcs.AddRecord
        Common.ClearControls(grpMain)
        txtName.Text = "" : txtAlias.Text = ""
        grpMain.Enabled = True
        chkStatus.Checked = False : chkStatus.Enabled = True
        EditMode = False
        Search.Enabled = False
        txtAltCode.Text = ""
        txtName.Focus()
        If Field_Type = "I" Then
            Query = "select * FROM UserFieldDefinitions with (nolock) WHERE UserField_ID=(SELECT max(UserField_ID) FROM UserFieldDefinitions with (nolock) WHERE Master_Type = 'I' )  "
            Dim UserField As DataTable = Common.GetDataTable(Query)
            Dim displayIndex As Integer
            If UserField.Rows.Count > 0 Then
                displayIndex = UserField.Rows(0).Item("DisplayIndex")
                txtDisplaySeq.Text = displayIndex + 1
            End If
        ElseIf Field_Type = "C" Then
            Query = "select * FROM UserFieldDefinitions with (nolock) WHERE UserField_ID=(SELECT max(UserField_ID) FROM UserFieldDefinitions WHERE Master_Type = 'C')   "
            Dim UserField As DataTable = Common.GetDataTable(Query)
            Dim displayIndex As Integer
            If UserField.Rows.Count > 0 Then
                displayIndex = UserField.Rows(0).Item("DisplayIndex")
                txtDisplaySeq.Text = displayIndex + 1
            End If
        ElseIf Field_Type = "S" Then
            Query = "select * FROM UserFieldDefinitions with (nolock) WHERE UserField_ID=(SELECT max(UserField_ID) FROM UserFieldDefinitions  with (nolock) WHERE Master_Type = 'S')   "
            Dim UserField As DataTable = Common.GetDataTable(Query)
            Dim displayIndex As Integer
            If UserField.Rows.Count > 0 Then
                displayIndex = UserField.Rows(0).Item("DisplayIndex")
                txtDisplaySeq.Text = displayIndex + 1
            End If
        ElseIf Field_Type = "E" Then
            Query = "select * FROM UserFieldDefinitions with (nolock) WHERE UserField_ID=(SELECT max(UserField_ID) FROM UserFieldDefinitions with (nolock) WHERE Master_Type = 'E')   "
            Dim UserField As DataTable = Common.GetDataTable(Query)
            Dim displayIndex As Integer
            If UserField.Rows.Count > 0 Then
                displayIndex = UserField.Rows(0).Item("DisplayIndex")
                txtDisplaySeq.Text = displayIndex + 1
            End If
        ElseIf Field_Type = "B" Then  'Rajashri-14-03-2022
            Query = "select * FROM UserFieldDefinitions WHERE UserField_ID=(SELECT max(UserField_ID) FROM UserFieldDefinitions WHERE Master_Type = 'B')   "
            Dim UserField As DataTable = Common.GetDataTable(Query)
            Dim displayIndex As Integer
            If UserField.Rows.Count > 0 Then
                displayIndex = UserField.Rows(0).Item("DisplayIndex")
                txtDisplaySeq.Text = displayIndex + 1
            End If
        End If

    End Sub

    Public Sub CancelAddEdit() Implements IButtonProcs.CancelAddEdit
        grpMain.Enabled = False

        chkAllBranch.Checked = False

        Search.Enabled = True
        EditMode = False
        ButtonRights(FuncButtons, CurrModule)

        RetrieveRecord(RecordId)
    End Sub

    Public Sub CloseForm() Implements IButtonProcs.CloseForm
        Me.Close()
    End Sub

    Public Sub DeleteRecord() Implements IButtonProcs.DeleteRecord
        If RecordId = "" Then Exit Sub
        If MsgBox(DeleteRecordMsg, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim Trans As SqlTransaction = Nothing
        Try
            Trans = CreateSQLTransaction()
            Query = "Exec delete_UserFieldDefinitions '" & RecordId & "'"
            Common.ExecuteQuery(Query, Trans)

            If Field_Type = "I" Then
                Query = " ALTER TABLE UserFieldDataItem Drop Column  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "  "
            ElseIf Field_Type = "S" Then
                Query = " ALTER TABLE UserFieldDataSupplier Drop Column  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "  "
            ElseIf Field_Type = "C" Then
                Query = " ALTER TABLE UserFieldDataCustomer Drop Column  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "  "
            ElseIf Field_Type = "E" Then
                Query = " ALTER TABLE UserFieldDataEmployee Drop Column  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "  "
            ElseIf Field_Type = "B" Then 'Rajashri-14-03-2022
                Query = " ALTER TABLE UserFieldDataStyle Drop Column  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "  "
            End If
            Common.ExecuteQuery(Query, Trans)

            Trans.Commit()
            txtName.Text = "" : txtAlias.Text = "" : RecordId = ""
            Search.LoadSearch()

        Catch sqlEx As SqlException
            If sqlEx.ErrorCode = c_FKeyRefCode Then
                MsgBox(c_FKeyRefMsg, MsgBoxStyle.Critical)
            Else
                Common.LogAndDisplayException(sqlEx)
            End If
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub EditRecord() Implements IButtonProcs.EditRecord
        FuncButtons.ContinueToChangeImage = False
        If RecordId = "" Then
            FuncButtons.ContinueToChangeImage = True
            Exit Sub
        End If
        grpMain.Enabled = True
        chkAllBranch.Enabled = False

        chkStatus.Enabled = False
        If Not State Then
            chkStatus.Enabled = True
        End If

        Search.Enabled = False
        EditMode = True
        txtName.Focus()
    End Sub

    Public Function InsertRecord() As Byte Implements IButtonProcs.InsertRecord
        Dim Trans As SqlTransaction = Nothing

        Try
            If cmbFieldType.SelectedIndex = -1 Then
                cmbFieldType.SelectedIndex = 0
            End If
            Trans = CreateSQLTransaction()
            Dim RecId As Integer
            RecId = Common.NewRecordId("UserFieldDefinitions", "UserField_Id", , False)
            Query = "Exec insert_UserFieldDefinitions " & RecId & ",'" & Field_Type & "','" & ReplaceApostrophe(txtName.Text) & "','" & ReplaceApostrophe(txtAlias.Text) & "','" & cmbFieldType.Text & "','" & ReplaceApostrophe(Val(txtDisplaySeq.Text)) & "','" & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "','" & Environment.MachineName & "','1'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm tt") & "'"
            Common.ExecuteQuery(Query, Trans)

            If cmbFieldType.SelectedIndex = 0 Then
                Datatype = "[varchar](200)"
            ElseIf cmbFieldType.SelectedIndex = 1 Then
                Datatype = "[datetime]"
            ElseIf cmbFieldType.SelectedIndex = 2 Then
                Datatype = "[float]"
            ElseIf cmbFieldType.SelectedIndex = 3 Then
                Datatype = "[bigint]"
            ElseIf cmbFieldType.SelectedIndex = 4 Then
                Datatype = "[char](1)"
            End If
            If Field_Type = "I" Then
                Query = " ALTER TABLE UserFieldDataItem ADD  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & " " & Datatype & " "
                'Query = " ALTER TABLE UserFieldData ADD  " & "Ud_" & ReplaceApostrophe(txtName.Text) & " " & Datatype & " "
            ElseIf Field_Type = "S" Then
                Query = " ALTER TABLE UserFieldDataSupplier ADD  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & " " & Datatype & " "
            ElseIf Field_Type = "C" Then
                Query = " ALTER TABLE UserFieldDataCustomer ADD  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & " " & Datatype & " "
            ElseIf Field_Type = "E" Then
                Query = " ALTER TABLE UserFieldDataEmployee ADD  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & " " & Datatype & " "
            ElseIf Field_Type = "B" Then 'Rajashri-14-03-2022
                Query = " ALTER TABLE UserFieldDataStyle ADD  " & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & " " & Datatype & " "
            End If
            Common.ExecuteQuery(Query, Trans)

            Trans.Commit()

            RecordId = RecId
            NewRecordId = RecordId
            Search.CurrentRecord = RecordId

            Return 0

        Catch When Err.Description.Contains("Uq_UserFieldDefinitions_FieldName")
            MsgBox(txtName.Text & c_ExistsMsg, MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return 1
        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
            Return 1
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Return 1
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

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
                Search.LoadSearch()
                FuncButtons.CurrentRecordStatus = True
                FuncButtons.Focus()
            End If

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
            Trans = CreateSQLTransaction()
            Query = "Exec Update_UserFieldDefinitions " & RecordId & ",'" & ReplaceApostrophe(txtName.Text) & "','" & ReplaceApostrophe(txtAlias.Text) & "','" & cmbFieldType.Text & "'," & ReplaceApostrophe(Val(txtDisplaySeq.Text)) & ",'" & "UD_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "','" & Environment.MachineName & "','1'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm tt") & "'"
            Common.ExecuteQuery(Query, Trans)


            Query = " EXEC sp_rename '" & Field_Name & "', '" & "Ud_" & (ReplaceApostrophe(txtName.Text)).Replace(" ", "") & "' "
            Common.ExecuteQuery(Query, Trans)

            Trans.Commit()

            NewRecordId = RecordId
            Search.CurrentRecord = RecordId

            Return 0

        Catch When Err.Description.Contains("Uq_UserFieldDefinitions_FieldName")
            MsgBox(txtName.Text & c_ExistsMsg, MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return 1
        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
            Return 1
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
            Return 1
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub CreateSearchWindow()
        Dim DisplayArray As New ArrayList
        Dim a As String = DateTime.Now().ToString("hh:mm tt")
        With DisplayArray
            .Add(New DisplayColumns("FieldName", "Field Name", 150))
            .Add(New DisplayColumns("DisplayText", "Display Name", 150))
            .Add(New DisplayColumns("FieldType", "Field Type", 120))
            .Add(New DisplayColumns("DisplayIndex", "Display Seq", 100))
            '.Add(New DisplayColumns("case when UserFieldDefinitions.Created_By = '0' then '' else Created.User_Name  end Created_By", "UserFieldDefinitions.Created By", 120))
            .Add(New DisplayColumns("case when UserFieldDefinitions.Created_Dt = '1900-01-01' then '' else Convert(nvarchar,Created_Dt,100) end Created_Dt", "Created On", 120))
            '.Add(New DisplayColumns("case when UserFieldDefinitions.Updated_By = '0' then '' else Updated.User_Name  end Updated_By", "UserFieldDefinitions.Updated By", 120))
            .Add(New DisplayColumns("case when UserFieldDefinitions.Updated_Dt = '1900-01-01' then '' else Convert(nvarchar,Updated_Dt,100) end Updated_Dt", "Updated On", 120))
            .Add(New DisplayColumns("UserField_Id", "", 0))
        End With

        With Search
            .Connect = Common.ConnectionString
            .Table = "UserFieldDefinitions with (nolock) "
            '& "Left Join Users Created On UserFieldDefinitions.Created_By = Created.User_ID " _
            '& "Left Join Users Updated On UserFieldDefinitions.Updated_By = Updated.User_ID "
            .UniqueId = "UserField_Id"
            .Where = "FieldName <> '' And Master_Type = '" & Field_Type & "' "
            .Order = "Order By DisplayIndex"
            .DisplayArrayList = DisplayArray
            .Caption = Me.Text
            .LoadSearch()
        End With
    End Sub

    Public Sub RetrieveRecord(ByVal RecId As String) Implements IButtonProcs.RetrieveRecord
        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select * From UserFieldDefinitions with (nolock) Where UserField_Id = '" & RecId & "'"
            Dim State As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow

            For Each RecRow In State.Rows
                RecordId = RecRow("UserField_Id")
                NewRecordId = RecordId
                txtName.Text = RecRow("FieldName") & ""
                txtAlias.Text = RecRow("DisplayText") & ""
                cmbFieldType.Text = RecRow("FieldType")
                txtDisplaySeq.Text = RecRow("DisplayIndex") & ""
                chkStatus.Checked = CBool(Val(RecRow("Status")))
                If Field_Type = "I" Then
                    Field_Name = "UserFieldDataItem.Ud_" & ReplaceApostrophe(RecRow("FieldName")).Replace(" ", "") & ""
                ElseIf Field_Type = "S" Then
                    Field_Name = "UserFieldDataSupplier.Ud_" & ReplaceApostrophe(RecRow("FieldName")).Replace(" ", "") & ""
                ElseIf Field_Type = "C" Then
                    Field_Name = "UserFieldDataCustomer.Ud_" & ReplaceApostrophe(RecRow("FieldName")).Replace(" ", "") & ""
                ElseIf Field_Type = "E" Then
                    Field_Name = "UserFieldDataEmployee.Ud_" & ReplaceApostrophe(RecRow("FieldName")).Replace(" ", "") & ""
                ElseIf Field_Type = "B" Then 'Rajashri--14-03-2022
                    Field_Name = "UserFieldDataStyle.Ud_" & ReplaceApostrophe(RecRow("FieldName")).Replace(" ", "") & ""
                End If
                '& ReplaceApostrophe(txtName.Text) & " " & Datatype & "" '(ReplaceApostrophe(txtName.Text)).Replace(" ", "") 
            Next RecRow
            State = Nothing


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, chkStatus.KeyDown, txtAlias.KeyDown, txtAltCode.KeyDown, cmbFieldType.KeyDown, txtDisplaySeq.KeyDown
        MoveToNextControl(e)
    End Sub

    Public Function InvalidRecord() As Boolean Implements IButtonProcs.InvalidRecord
        If txtName.Text.Trim.Length = 0 Then
            MsgBox("Field Name cannot be blank", MsgBoxStyle.Exclamation)
            txtName.Focus()
            Return True
        End If

        'Dim pattern As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")
        'If pattern.IsMatch(txtName.Text) = True Then
        '    Return pattern.IsMatch(txtName.Text)
        'Else
        '    MsgBox("Field Name not in correct format", MsgBoxStyle.Exclamation)
        '    txtName.Focus()
        '    Return True
        'End If
        Return False
    End Function

    Private Sub btnCountry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCountry.Click

    End Sub

    Public Sub SearchRecord() Implements IButtonProcs.SearchRecord

    End Sub

    Public Sub ViewReport() Implements IButtonProcs.ViewReport
        'ReportParameters.rptFile = ReportPath & "\Masters\State.rpt"
        'ReportParameters.rptFilter = "{State.CoBr_Id} = '" & SelBranchFixId & "'"
        'ReportParameters.ApplyCompanyFilter = True
        'ReportParameters.rptCaption = "State"

        'Dim frmView As New frmViewReports()
        'frmView.Show()
    End Sub

    Private Sub btnCountry_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCountry.GotFocus
        cmbFieldType.Focus()
    End Sub

    Private Sub cmbFieldType_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFieldType.Validated
        If cmbFieldType.SelectedIndex = -1 Then cmbFieldType.SelectedIndex = 0
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        txtAlias.Text = txtName.Text
    End Sub

    Public Sub ButtonBehaveAsPerRights() Implements IButtonProcs.ButtonBehaveAsPerRights
        ButtonRights(FuncButtons, CurrModule)
    End Sub
End Class