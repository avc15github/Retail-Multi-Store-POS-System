Imports System.Data.SqlClient

Public Class frmReportTypeAI
    Implements IButtonProcs

    Dim RecordId As String
    Dim EditMode As Boolean
    Public Shared Type As Boolean
    Dim CurrModule As String = "ndType"


    Private Sub frmType_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'ButtonRights(FuncButtons, CurrModule)
        'If Val(GetSettingAsPerId(ApplnSettingsIdx.GenProjectType)) = 0 Then
        '    EnableDisableBtn(FuncButtons)
        'End If
    End Sub

    Private Sub frmReportTypeAI_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NewRecordId = RecordId
    End Sub

    Private Sub frmReportTypeAI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If grpMain.Enabled = False Then
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmReportTypeAI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        CreateSearchWindow()
        FuncButtons.FormObj = Me
        FuncButtons.DisplaySearchButton = False
        grpMain.Enabled = False

        If Type And NewRecordId <> "" Then
            Search.CurrentRecord = NewRecordId
            RetrieveRecord(NewRecordId)
            Search.LoadSearch()
        End If
        ' chkAllBranch.Visible = CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenMutiBranch)))

    End Sub

    Private Sub Search_CurrentRecordId(ByRef CurrId As String) Handles Search.CurrentRecordId
        RetrieveRecord(CurrId)
    End Sub

    Public Sub AddRecord() Implements IButtonProcs.AddRecord
        Common.ClearControls(grpMain)
        chkShowDate.Checked = False
        chkShowFilter.Checked = False
        grpMain.Enabled = True

        chkAllBranch.Enabled = True
        chkAllBranch.Checked = False

        chkStatus.Checked = True : chkStatus.Enabled = False
        EditMode = False
        Search.Enabled = False
        txtSearchName.Focus()
    End Sub

    Public Sub CancelAddEdit() Implements IButtonProcs.CancelAddEdit
        grpMain.Enabled = False
        chkAllBranch.Checked = False

        Search.Enabled = True
        EditMode = False
        'ButtonRights(FuncButtons, CurrModule)
        'If Val(GetSettingAsPerId(ApplnSettingsIdx.GenProjectType)) = 0 Then
        '    EnableDisableBtn(FuncButtons)
        'End If
        RetrieveRecord(RecordId)
    End Sub

    Public Sub CloseForm() Implements IButtonProcs.CloseForm
        Me.Close()
    End Sub

    Public Sub DeleteRecord() Implements IButtonProcs.DeleteRecord
        If RecordId = "" Then Exit Sub
        If MsgBox(DeleteRecordMsg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Try


            Query = "Exec Delete_ReportTypeAI " & RecordId & ""
            Common.ExecuteQuery(Query)

            RecordId = ""
            Common.ClearControls(grpMain)
            Search.LoadSearch()

        Catch sqlEx As SqlException
            If sqlEx.ErrorCode = c_FKeyRefCode Then
                MsgBox(c_FKeyRefMsg, MsgBoxStyle.Critical, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
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
        If Not Type Then
            chkStatus.Enabled = True
        End If
        Search.Enabled = False
        EditMode = True
        txtSearchName.Focus()
    End Sub

    Public Function InsertRecord() As Byte Implements IButtonProcs.InsertRecord
        Dim Trans As SqlTransaction = Nothing
        Try
            Trans = CreateSQLTransaction()

            Dim RecId As Integer
            Dim autocode As String = ""

            
            RecId = Common.NewRecordId("ReportTypeAI", "RecId", , False)


            Query = "Exec Insert_ReportTypeAI " & RecId & ",'" & ReplaceApostrophe(txtSearchName.Text) & "','" & ReplaceApostrophe(txtReportName.Text) & "' , '" & IIf(chkShowDate.Checked, "1", "0") & "','" & IIf(chkShowFilter.Checked, "1", "0") & "','" & IIf(chkStatus.Checked, "1", "0") & "'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm tt") & "'"
            Common.ExecuteQuery(Query)


            Trans.Commit()

            RecordId = RecId
            NewRecordId = RecordId
            Search.CurrentRecord = RecordId

            Return 0

        Catch When Err.Description.Contains("Uq_ReportTypeAI_SearchName")
            MsgBox(txtSearchName.Text & c_ExistsMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtSearchName.Focus()
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
        Try
            Query = "Exec Update_ReportTypeAI " & RecordId & ",'" & ReplaceApostrophe(txtSearchName.Text) & "','" & ReplaceApostrophe(txtReportName.Text) & "','" & IIf(chkShowDate.Checked, "1", "0") & "','" & IIf(chkShowFilter.Checked, "1", "0") & "','" & IIf(chkStatus.Checked, "1", "0") & "'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm tt") & "'"
            Common.ExecuteQuery(Query)

            NewRecordId = RecordId
            Search.CurrentRecord = RecordId

            Return 0

        Catch When Err.Description.Contains("Uq_ReportTypeAI_SearchName")
            MsgBox(txtSearchName.Text & c_ExistsMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtSearchName.Focus()
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

        With DisplayArray
            .Add(New DisplayColumns("SearchName", "Search Name", 200))
            .Add(New DisplayColumns("ReportName", "Report Name", 350))
            .Add(New DisplayColumns("RecId", "", 0))
        End With

        With Search
            .Connect = Common.ConnectionString
            .Table = "ReportTypeAI "
            
            .UniqueId = "RecId"
            .Where = "SearchName <> '' "
            .Order = "Order By SearchName"
            .DisplayArrayList = DisplayArray
            .Caption = Me.Text
            .LoadSearch()
        End With
    End Sub

    Public Sub RetrieveRecord(ByVal RecId As String) Implements IButtonProcs.RetrieveRecord
        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select * From ReportTypeAI With(Nolock) Where RecId = " & RecId & ""
            Dim Type As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow

            For Each RecRow In Type.Rows
                RecordId = RecRow("RecId")
                txtSearchName.Text = RecRow("SearchName") & ""
                txtReportName.Text = RecRow("ReportName") & ""
                chkShowDate.Checked = CBool(Val(RecRow("ShowDate")))
                chkShowFilter.Checked = CBool(Val(RecRow("ShowFilter")))
                chkStatus.Checked = CBool(Val(RecRow("Status")))
            Next RecRow
            Type = Nothing


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtSearchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchName.KeyDown, txtReportName.KeyDown, chkShowDate.KeyDown, chkShowFilter.KeyDown, chkStatus.KeyDown
        MoveToNextControl(e)
    End Sub

    Public Function InvalidRecord() As Boolean Implements IButtonProcs.InvalidRecord
        If txtSearchName.Text.Trim.Length = 0 Then
            MsgBox(txtSearchName.Tag & c_BlankMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtSearchName.Focus()
            Return True
        End If

        Return False
    End Function

    Public Sub SearchRecord() Implements IButtonProcs.SearchRecord

    End Sub

    Public Sub ViewReport() Implements IButtonProcs.ViewReport
        ReportParameters.rptFile = ReportPath & "\Masters\Type.rpt"
        ReportParameters.rptFilter = "{Type.CoBr_Id} = '" & SelBranchFixId & "'"
        ReportParameters.ApplyCompanyFilter = True
        ReportParameters.rptCaption = GetSystemCaption(SystemCaptionIdx.DefType) & " Master"

        Dim formulas As New Hashtable
        formulas.Add("ReportCaption#S", ReportParameters.rptCaption)

        Dim frmView As New frmViewReports(formulas)
        frmView.Show()
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchName.TextChanged

    End Sub

    Public Sub ButtonBehaveAsPerRights() Implements IButtonProcs.ButtonBehaveAsPerRights
        ButtonRights(FuncButtons, CurrModule)
        If Val(GetSettingAsPerId(ApplnSettingsIdx.GenProjectType)) = 0 Then
            EnableDisableBtn(FuncButtons)
        End If
    End Sub

    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Dim opDlg As New OpenFileDialog

        With opDlg
            .InitialDirectory = Application.StartupPath
           
            If .ShowDialog() = DialogResult.OK Then               
                txtReportName.Text = .FileName
            End If
        End With
    End Sub
End Class