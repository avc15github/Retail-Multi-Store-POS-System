Imports System.Data.SqlClient

Public Class frmModNoGenerate
    Implements IButtonProcs

    Dim RecordId As String
    Dim EditMode As Boolean
    Dim CurrModule As String = "NDMODULENOGENERATE"
    Public Shared ModuleNoGenerate As Boolean


    Private Sub frmTenderType_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If frmLedger.Ledger Then
            'Query = " Select LED_KEY, LED_NAME " _
            '    & " From Ledger  With(NoLock) Inner Join AccLGrp  With(NoLock) On Ledger.AccLGrp_Key = AccLgrp.AccLGrp_Key " _
            '    & " Where Ledger.AccLGrp_Key = '" & SelBranchFixId & "'+'2'" _
            '    & " And Ledger.Status = '1' " _
            '    & " And Ledger.CoBr_Id = '" & SelBranchFixId & "'" _
            '    & " Order By Led_Name"
            'Common.FillCombo(Query, cmbGatewayBank, "LED_NAME", "LED_KEY")

            'If NewRecordId <> "" Then
            '    cmbGatewayBank.EditValue = NewRecordId
            'End If
            'frmLedger.Ledger = False : NewRecordId = ""
            'cmbGatewayBank.Focus()
            Exit Sub
        End If

        ButtonRights(FuncButtons, CurrModule)
    End Sub

    Private Sub frmTenderType_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NewRecordId = RecordId
    End Sub

    Private Sub frmTenderType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If grpMain.Enabled = True Then
            If e.KeyCode = Keys.F3 Then
                'If cmbGatewayBank.ContainsFocus Then
                '    btnGatewayBank_Click(Nothing, Nothing)
                'End If
            End If
        Else
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End If



    End Sub

    Private Sub frmTenderType_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Cursor = Cursors.WaitCursor

         

            With cmbType.Items
                .Add("1", "Customer")
                .Add("2", "Vendor")
                .Add("3", "Employee")
                .Add("4", "Transporter")
                .Add("5", "Broker")
                .Add("6", "Item")
            End With


            CreateSearchWindow()
            FuncButtons.FormObj = Me
            grpMain.Enabled = False

            If ModuleNoGenerate And NewRecordId <> "" Then
                Search.CurrentRecord = NewRecordId
                RetrieveRecord(NewRecordId)
                Search.LoadSearch()
            End If



        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Search_CurrentRecordId(ByRef CurrId As String) Handles Search.CurrentRecordId
        RetrieveRecord(CurrId)
    End Sub

    Public Sub AddRecord() Implements IButtonProcs.AddRecord
        txtCodeLength.Text = "" : txtPrefix.Text = "" : txtSeqNo.Text = "" : cmbType.SelectedIndex = 0
        grpMain.Enabled = True
        chkStatus.Checked = True : chkStatus.Enabled = False
        EditMode = False


        Search.Enabled = False
        cmbType.Focus()
    End Sub

    Public Sub CancelAddEdit() Implements IButtonProcs.CancelAddEdit
        grpMain.Enabled = False
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
        If MsgBox(DeleteRecordMsg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Try
            Query = "Exec Delete_ModuleNoGenerate '" & RecordId & "'"
            Common.ExecuteQuery(Query)

            txtPrefix.Text = "" : txtSeqNo.Text = "" : cmbType.SelectedIndex = -1
            RecordId = "" : txtCodeLength.Text = ""
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
        chkStatus.Enabled = False
        If Not ModuleNoGenerate Then
            chkStatus.Enabled = True
        End If
        Search.Enabled = False
        EditMode = True
        cmbType.Focus()
    End Sub

    Public Function InsertRecord() As Byte Implements IButtonProcs.InsertRecord
        Try
            Dim RecId As Integer

            ' If CBool(Val(GetSettingAsPerId(ApplnSettingsIdx.GenBranchWiseMaster))) Then
            'RecId = Common.NewRecordId("CCBank", "CCBank_Id")
            ' Else
            RecId = Common.NewRecordId("ModuleNoGenerate", "ModuleNoGenerate_id", , False)
            ' End If

            Query = "Exec Insert_ModuleNoGenerate " & RecId & ",'" & cmbType.Value & "','" & ReplaceApostrophe(txtPrefix.Text) & "','" & ReplaceApostrophe(txtSeqNo.Text) & "'," & txtCodeLength.Text & ",'" & IIf(chkStatus.Checked, "1", "0") & "'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm tt") & "'"
            Common.ExecuteQuery(Query)


            'Query = "Update ModuleNoGenerate Set ModOfPayment='" & IIf(cmbType.SelectedIndex = 0, "1", "2") & "',Alt_Code='" & txtSeqNo.Text & "' where TenderType_id=" & Val(RecId)
            'Common.ExecuteQuery(Query)


            RecordId = RecId
            NewRecordId = RecordId
            Search.CurrentRecord = RecordId

            Return 0

        Catch When Err.Description.Contains("Uq_ModuleNoGenerate_ModuleNoGenerate_Mod_Type")
            MsgBox(cmbType.Text & c_ExistsMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbType.Focus()
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
            Query = "Exec Update_ModuleNoGenerate '" & RecordId & "','" & cmbType.Value & "','" & ReplaceApostrophe(txtPrefix.Text) & "','" & ReplaceApostrophe(txtSeqNo.Text) & "'," & txtCodeLength.Text & ",'" & IIf(chkStatus.Checked, "1", "0") & "'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm tt") & "'"
            Common.ExecuteQuery(Query)

            'Query = "Update ModuleNoGenerate Set ModOfPayment='" & IIf(cmbType.SelectedIndex = 0, "1", "2") & "',Alt_Code='" & txtSeqNo.Text & "' where ModuleNoGenerate_id=" & Val(RecordId)
            'Common.ExecuteQuery(Query)

            NewRecordId = RecordId
            Search.CurrentRecord = RecordId

            Return 0

        Catch When Err.Description.Contains("Uq_ModuleNoGenerate_ModuleNoGenerate_Mod_Type")
            MsgBox(cmbType.Text & c_ExistsMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbType.Focus()
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
            .Add(New DisplayColumns("case when Mod_Type='1' then 'Customer' when  Mod_Type='2' then 'Vendor' when  Mod_Type='3' then 'Employee' when  Mod_Type='4' then 'Transporter' when  Mod_Type='5' then 'Broker' when  Mod_Type='6' then 'Item'  else '' end ", "Mod Type", 120))

            .Add(New DisplayColumns("ModuleNoGenerate.prefix", "Prefix", 80))
            .Add(New DisplayColumns("ModuleNoGenerate.SeqNo", "Seq No", 80))
            .Add(New DisplayColumns("ModuleNoGenerate.CodeLength", "Code Length", 80))


            .Add(New DisplayColumns("ModuleNoGenerate.ModuleNoGenerate_id", "", 0))
        End With

        With Search
            .Connect = Common.ConnectionString
            .Table = "ModuleNoGenerate  With(NoLock)  "
            .UniqueId = "ModuleNoGenerate_id"
            .Where = "Mod_Type <> '' "
            .Order = "Order By Mod_Type "
            .DisplayArrayList = DisplayArray
            .Caption = Me.Text
            .LoadSearch()
        End With
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrefix.KeyDown, chkStatus.KeyDown, cmbType.KeyDown, txtSeqNo.KeyDown
        MoveToNextControl(e)
    End Sub
  

    Public Function InvalidRecord() As Boolean Implements IButtonProcs.InvalidRecord
        'If txtName.Text.Trim.Length = 0 Then
        '    MsgBox(txtName.Tag & c_BlankMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
        '    txtName.Focus()
        '    Return True

        If cmbType.SelectedIndex = -1 Then
            MsgBox("Mod Type Not Specified ..", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            cmbType.Focus()
            Return True

        End If
        If txtCodeLength.Text.Length = 0 Then
            MsgBox("Please Specify Code Length..", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtCodeLength.Focus()
            Return True
        End If

        If Val(txtPrefix.Text.Length + txtSeqNo.Text.Length) > Val(txtCodeLength.Text) Then
            MsgBox("Please Correct Code Length..", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtCodeLength.Focus()
            Return True
        End If

        If Val(txtCodeLength.Text) > 15 Then
            MsgBox("Code Length Cannot be Greater than 15 ", MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtCodeLength.Focus()
            Return True
        End If

        Return False
    End Function

    'Private Sub btnGatewayBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    NewRecordId = "" : frmLedger.Ledger = True
    '    If IsNothing(cmbGatewayBank.EditValue) Or cmbGatewayBank.Text.Trim.Length = 0 Then
    '        NewRecordId = ""
    '    Else
    '        NewRecordId = cmbGatewayBank.EditValue
    '    End If

    '    Dim frmLedger1 As New frmLedger
    '    frmLedger1.MdiParent = Me.MdiParent
    '    frmLedger1.Tag = "LEDGER"
    '    frmLedger1.Show()
    'End Sub

    Public Sub RetrieveRecord(ByVal RecId As String) Implements IButtonProcs.RetrieveRecord
        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select * From ModuleNoGenerate  With(NoLock) Where ModuleNoGenerate_ID = '" & RecId & "'"
            Dim State As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow

            For Each RecRow In State.Rows
                RecordId = RecRow("ModuleNoGenerate_ID")

                cmbType.Value = RecRow("Mod_Type")
                txtPrefix.Text = RecRow("Prefix") & ""

                txtSeqNo.Text = RecRow("SeqNo")
                txtCodeLength.Text = RecRow("CodeLength")
                chkStatus.Checked = CBool(Val(RecRow("Status")))
                

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

    Public Sub SearchRecord() Implements IButtonProcs.SearchRecord

    End Sub

    Public Sub ViewReport() Implements IButtonProcs.ViewReport
        ReportParameters.rptFile = ReportPath & "\Masters\ModuleNoGenerate.rpt"
        ' ReportParameters.rptFilter = "{TenderType.CoBr_Id} = '" & SelBranchFixId & "' And {CCBank.CCBankFlag} = '0'"
        ReportParameters.ApplyCompanyFilter = True
        ReportParameters.rptCaption = "Mod No Generate "

        Dim frmView As New frmViewReports()
        frmView.Show()
    End Sub

   

    Public Sub ButtonBehaveAsPerRights() Implements IButtonProcs.ButtonBehaveAsPerRights
        ButtonRights(FuncButtons, CurrModule)
    End Sub

    
    
End Class