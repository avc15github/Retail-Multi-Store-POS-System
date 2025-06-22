Imports System.Data.SqlClient

Public Class frmContactUs
    Implements IButtonProcs

    Dim RecordId As String = ""
    Dim EditMode As Boolean


    Private Sub frmContactUs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NewRecordId = RecordId
    End Sub

    Private Sub frmContactUs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmContactUs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'grpMain.Enabled = False

        Me.Cursor = Cursors.WaitCursor
        RetrieveRecord("")
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub AddRecord() Implements IButtonProcs.AddRecord
        ClearTextboxes()
        grpMain.Enabled = True
        EditMode = False
        txtName.Focus()
    End Sub

    Public Sub CancelAddEdit() Implements IButtonProcs.CancelAddEdit
        grpMain.Enabled = False
        EditMode = False
        RetrieveRecord(RecordId)
    End Sub

    Public Sub CloseForm() Implements IButtonProcs.CloseForm
        Me.Close()
    End Sub

    Public Sub DeleteRecord() Implements IButtonProcs.DeleteRecord
        If RecordId = "" Then Exit Sub
        If MsgBox(DeleteRecordMsg, MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

        Try
            'Query = "Exec Delete_Ledger '" & RecordId & "'"
            'Common.ExecuteQuery(Query)
            RecordId = ""
            ClearTextboxes()

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
        
    End Sub

    Public Function InsertRecord() As Byte Implements IButtonProcs.InsertRecord
        Try
            Dim RecId As Integer = Common.NewRecordId("Ledger", "Led_Id")

            'Query = "Exec Insert_Ledger '" & SelBranchId & "'," & RecId & ",'" & SelBranchId & RecId & "','" & ReplaceApostrophe(txtName.Text) & "','" & ReplaceApostrophe(txtAlias.Text) & "',Null,'L','','',Null,'','',Null,'',0,'" & ReplaceApostrophe(txtORegdAddress.Text) & "','" & cmbOStation.Value & "','" & ReplaceApostrophe(txtOArea.Text) & "','" & txtOPin.Text & "','" & txtOPhone1.Text & "','" & txtOPhone2.Text & "','" & txtOFax.Text & "','" & ReplaceApostrophe(txtOEmail.Text) & "','" & ReplaceApostrophe(txtOAltEmail.Text) & "','','','','','','','','','','','','" & txtMobile1.Text & "','" & txtMobile2.Text & "','" & txtSMSMobile1.Text & "','" & txtSMSMobile2.Text & "','','','','','',0,'','',0,0,0,0," & txtIntPerc.EditValue & ",'0','0','0','','" & cmbSubGroup.Value & "'," & IIf(cmbDrCr.Text = "Dr", Val(txtOpBalance.EditValue), -1 * Val(txtOpBalance.EditValue)) & ",'" & Format$(dtpOpDate.Value, "MM/dd/yyyy") & "','" & IIf(chkCostCtrAppbl.Checked, "1", "0") & "','" & IIf(chkBillWiseDtls.Checked, "1", "0") & "','','',Null,Null,0,0,0,0,Null,Null,Null,0,0," & IIf(cmbDrCr.Text = "Dr", Val(txtOpBalance.EditValue), -1 * Val(txtOpBalance.EditValue)) & ",'','','','',0,'',0,'0','','','',0,'','0','','','','','" & ReplaceApostrophe(txtRemark.Text) & "','" & IIf(chkStatus.Checked, "1", "0") & "'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm:ss tt") & "','',''"
            Common.ExecuteQuery(Query)


            RecordId = SelBranchId & RecId
            NewRecordId = RecordId

            Return 0

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
            'Query = "Exec Update_Ledger '" & RecordId & "','" & ReplaceApostrophe(txtName.Text) & "','" & ReplaceApostrophe(txtAlias.Text) & "',Null,'L','','',Null,'','',Null,'',0,'" & ReplaceApostrophe(txtORegdAddress.Text) & "','" & cmbOStation.Value & "','" & ReplaceApostrophe(txtOArea.Text) & "','" & txtOPin.Text & "','" & txtOPhone1.Text & "','" & txtOPhone2.Text & "','" & txtOFax.Text & "','" & ReplaceApostrophe(txtOEmail.Text) & "','" & ReplaceApostrophe(txtOAltEmail.Text) & "','','','','','','','','','','','','" & txtMobile1.Text & "','" & txtMobile2.Text & "','" & txtSMSMobile1.Text & "','" & txtSMSMobile2.Text & "','','','','','',0,'','',0,0,0,0," & txtIntPerc.EditValue & ",'0','0','0','','" & cmbSubGroup.Value & "'," & IIf(cmbDrCr.Text = "Dr", Val(txtOpBalance.EditValue), -1 * Val(txtOpBalance.EditValue)) & ",'" & Format$(dtpOpDate.Value, "MM/dd/yyyy") & "','" & IIf(chkCostCtrAppbl.Checked, "1", "0") & "','" & IIf(chkBillWiseDtls.Checked, "1", "0") & "','','',Null,Null,0,Null,Null,'','','','',0,'',0,'0','','','',0,'','0','','','','','" & ReplaceApostrophe(txtRemark.Text) & "','" & IIf(chkStatus.Checked, "1", "0") & "'," & UserId & ",'" & Format$(Now, "MM/dd/yyyy HH:mm:ss tt") & "','',''
            Common.ExecuteQuery(Query)

            NewRecordId = RecordId

            Return 0


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

    Public Sub RetrieveRecord(ByVal RecId As String) Implements IButtonProcs.RetrieveRecord
        Try
            Me.Cursor = Cursors.WaitCursor

            Query = "Select * From ContactUs"
            Dim ContactUs As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow

            For Each RecRow In ContactUs.Rows
                txtName.Text = RecRow("CompanyName") & ""
                txtContact.Text = RecRow("ContactPerson") & ""
                txtRegdAddress.Text = RecRow("RegdAddr") & ""
                txtPhone1.Text = RecRow("Phone1") & ""
                txtPhone2.Text = RecRow("Phone2") & ""
                txtFax.Text = RecRow("FaxNo") & ""
                txtMobile.Text = RecRow("Mobile") & ""
                txtEmail.Text = RecRow("Email") & ""
                txtWebsite.Text = RecRow("Website") & ""
                txtRemark.Text = RecRow("Remark") & ""
            Next RecRow
            ContactUs = Nothing


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtContact.KeyDown, txtPhone1.KeyDown, txtPhone2.KeyDown, txtFax.KeyDown, txtEmail.KeyDown, txtWebsite.KeyDown
        MoveToNextControl(e)
    End Sub

    Public Function InvalidRecord() As Boolean Implements IButtonProcs.InvalidRecord
        If txtName.Text.Trim.Length = 0 Then
            MsgBox(txtName.Tag & c_BlankMsg, MsgBoxStyle.Exclamation, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
            txtName.Focus()
            Return True
        End If

        Return False
    End Function

    Private Sub Search_SearchAndClose(ByRef CurrId As String) Handles Search.SearchAndClose
        'RetrieveRecord(CurrId)
        'Search.Visible = False
        'Search.SendToBack()
    End Sub

    Public Sub SearchRecord() Implements IButtonProcs.SearchRecord
        'Dim DisplayArray As New ArrayList

        'With DisplayArray
        '    .Add(New DisplayColumns("Ledger.Led_Name", "Ledger", 200, "Ledger.Led_Name"))
        '    .Add(New DisplayColumns("AccLGrp.AccLGrp_Name", "Sub-Group", 180, "AccLGrp.AccLGrp_Name"))
        '    .Add(New DisplayColumns("Stn_Name", "Station(O)", 90, "Stn_Name"))
        '    .Add(New DisplayColumns("Ledger.OPin", "Pin(O)", 70, "Ledger.OPin"))
        '    .Add(New DisplayColumns("Ledger.OTel1", "Tel(O)", 80, "Ledger.OTel1"))
        '    .Add(New DisplayColumns("Ledger.OEmail", "Email(O)", 150, "Ledger.OEmail"))
        '    .Add(New DisplayColumns("Case When Ledger.Mobile1 = '0' Then '' Else Ledger.Mobile1 End Mobile1", "Mobile", 80, "Mobile1"))
        '    .Add(New DisplayColumns("Case When Ledger.SMSMobile1 = '0' Then '' Else Ledger.SMSMobile1 End SMSMobile1", "SMS Mobile", 80, "SMSMobile1"))
        '    .Add(New DisplayColumns("Led_Key", "", 0, "Led_Key"))
        'End With

        'With Search
        '    .Connect = Common.ConnectionString
        '    .Table = "Ledger Inner Join Station On Ledger.OStn_Key = Station.Stn_Key " _
        '        & " Inner Join AccLGrp On Ledger.AccLGrp_Key = AccLGrp.AccLGrp_Key"
        '    .UniqueId = "Led_Key"
        '    .Where = "Ledger.Led_Name <> '' And Ledger.Led_Cat = 'L' And Ledger.CoBr_Id = '" & SelBranchId & "'"
        '    .Order = "Order By Ledger.Led_Name"
        '    .DisplayArrayList = DisplayArray
        '    .Caption = Me.Text
        '    .ViewCloseButton = True
        '    .FormLoading = True
        '    .Visible = True
        '    .MyForm = Me
        '    .LoadSearch()
        '    .BringToFront()
        'End With
    End Sub

    Public Sub ViewReport() Implements IButtonProcs.ViewReport
        
    End Sub

    Private Sub ClearTextboxes()
        txtName.Text = "" : txtContact.Text = ""
        txtRegdAddress.Text = "" : txtPhone1.Text = "" : txtPhone2.Text = ""
        txtFax.Text = "" : txtEmail.Text = ""

        txtMobile.Text = "" : txtEmail.Text = "" : txtWebsite.Clear()
        txtRemark.Text = ""
    End Sub

    Public Sub CloseSearch()

    End Sub

    Public Sub ButtonBehaveAsPerRights() Implements IButtonProcs.ButtonBehaveAsPerRights

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Query = "Select * From ContactUs"
        Dim Contact As DataTable = Common.GetDataTable(Query)

        If Contact.Rows.Count = 0 Then
            Query = "Insert Into ContactUs Values " _
                & "('" & ReplaceApostrophe(txtName.Text) & "','" & ReplaceApostrophe(txtRegdAddress.Text) & "','" & ReplaceApostrophe(txtContact.Text) & "','" & ReplaceApostrophe(txtPhone1.Text) & "','" & ReplaceApostrophe(txtPhone2.Text) & "','" & ReplaceApostrophe(txtFax.Text) & "','" & txtMobile.Text & "','" & ReplaceApostrophe(txtEmail.Text) & "','" & ReplaceApostrophe(txtWebsite.Text) & "','" & ReplaceApostrophe(txtRemark.Text) & "')"
        Else
            Query = "Update ContactUs " _
                & " Set CompanyName = '" & ReplaceApostrophe(txtName.Text) & "', ContactPerson = '" & ReplaceApostrophe(txtContact.Text) & "', RegdAddr = '" & ReplaceApostrophe(txtRegdAddress.Text) & "', Phone1 = '" & ReplaceApostrophe(txtPhone1.Text) & "', Phone2 = '" & ReplaceApostrophe(txtPhone2.Text) & "', FaxNo = '" & ReplaceApostrophe(txtFax.Text) & "', Mobile = '" & txtMobile.Text & "', Email = '" & ReplaceApostrophe(txtEmail.Text) & "', Website = '" & ReplaceApostrophe(txtWebsite.Text) & "', Remark = '" & ReplaceApostrophe(txtRemark.Text) & "'"
        End If
        Common.ExecuteQuery(Query)

        MsgBox("Data updated successfully", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
    End Sub

    Private Sub txtRegdAddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegdAddress.GotFocus
        txtRegdAddress.SelectionStart = 0
    End Sub
End Class