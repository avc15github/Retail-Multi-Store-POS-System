Imports System.Data.SqlClient

Public Class frmAMC

    Dim RecordId As String = ""
    Dim EditMode As Boolean
    Dim a, b, c, d As Boolean

   
    Private Sub frmAMC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NewRecordId = RecordId
    End Sub
    Private Sub frmAMC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAMC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ClearTextboxes()
        Me.Cursor = Cursors.WaitCursor
        Me.Cursor = Cursors.Default
      
      
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ClearTextboxes()
        chkALock.Checked = False
        chkAMsg.Checked = False
        chkPLock.Checked = False
        chkPMsg.Checked = False
        txtADays.Text = 0
        txtAMCMsg.Clear()
        txtPaymentMsg.Clear()
        txtPLockDays.Text = 0
        txtPMsgDays.Text = 0
        txtRenewDays.Text = 0
        txtALockMsg.Clear()
        txtPLockMsg.Clear()
        dtpRenewDate.Value = dtpRenewDate.Value.AddYears(1)
        RetrieveRecord()
    End Sub
    Private Sub RetrieveRecord()

        Try
            Me.Cursor = Cursors.WaitCursor
            Query = "Select * From RecHistory1"
            Dim AMC As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow
            If AMC.Rows.Count > 0 Then
                For Each RecRow In AMC.Rows
                    dtpRegDate.Value = RecRow("ADate1") & ""
                    dtpRenewDate.Value = RecRow("ADate2") & ""
                    chkAMsg.Checked = IIf(RecRow("AMsg") = 1, True, False)
                    txtADays.Text = RecRow("AMsgDays") & ""
                    txtAMCMsg.Text = RecRow("AMsgR") & ""
                    txtAMCMsg.SelectionStart = Len(txtAMCMsg.Text)
                    chkALock.Checked = IIf(RecRow("ALock") = 1, True, False)
                    txtRenewDays.Text = RecRow("ALockDays") & ""
                    txtALockMsg.Text = RecRow("ALockMsg") & ""
                    txtALockMsg.SelectionStart = Len(txtALockMsg.Text)

                    dtpPDate.Value = RecRow("PDate1") & ""
                    chkPMsg.Checked = IIf(RecRow("PMsg") = 1, True, False)
                    txtPMsgDays.Text = RecRow("PMsgDays") & ""
                    txtPaymentMsg.Text = RecRow("PMsgR") & ""
                    txtPaymentMsg.SelectionStart = Len(txtPaymentMsg.Text)
                    chkPLock.Checked = IIf(RecRow("PLock") = 1, True, False)
                    txtPLockDays.Text = RecRow("PLockDays") & ""
                    txtPLockMsg.Text = RecRow("PLockMsg") & ""
                    txtPLockMsg.SelectionStart = Len(txtPLockMsg.Text)
                Next RecRow
                AMC = Nothing
            End If

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Query = "Select * From RecHistory1"
        Dim AMC As DataTable = Common.GetDataTable(Query)
        If AMC.Rows.Count = 0 Then
            Query = "Insert Into RecHistory1 Values " _
               & "('" & Format$(dtpRegDate.Value, "MM/dd/yyyy") & "','" & Format$(dtpRenewDate.Value, "MM/dd/yyyy") & "','" & IIf(chkAMsg.Checked, "1", "0") & "'" _
               & ",'" & Val(txtADays.EditValue) & "','" & ReplaceApostrophe(txtAMCMsg.Text) & "','" & IIf(chkALock.Checked, "1", "0") & "','" & txtRenewDays.Text & "'" _
               & ",'" & ReplaceApostrophe(txtALockMsg.Text) & "','" & Format$(dtpPDate.Value, "MM/dd/yyyy") & "','" & IIf(chkPMsg.Checked, "1", "0") & "'" _
               & ",'" & txtPMsgDays.Text & "','" & ReplaceApostrophe(txtPaymentMsg.Text) & "','" & IIf(chkPLock.Checked, "1", "0") & "','" & Val(txtPLockDays.EditValue) & "','" & ReplaceApostrophe(txtPLockMsg.Text) & "')"

        Else

            Query = "Update RecHistory1 " _
               & " Set ADate1='" & Format$(dtpRegDate.Value, "MM/dd/yyyy") & "',ADate2='" & Format$(dtpRenewDate.Value, "MM/dd/yyyy") & "',AMsg='" & IIf(chkAMsg.Checked, "1", "0") & "'" _
               & ",AMsgDays='" & Val(txtADays.EditValue) & "',AMsgR='" & ReplaceApostrophe(txtAMCMsg.Text) & "',ALock='" & IIf(chkALock.Checked, "1", "0") & "',ALockDays='" & Val(txtRenewDays.EditValue) & "',ALockMsg='" & ReplaceApostrophe(txtALockMsg.Text) & "'" _
               & ",PDate1='" & Format$(dtpPDate.Value, "MM/dd/yyyy") & "',PMsg='" & IIf(chkPMsg.Checked, "1", "0") & "'" _
               & ",PMsgDays='" & Val(txtPMsgDays.EditValue) & "',PMsgR='" & ReplaceApostrophe(txtPaymentMsg.Text) & "',PLock='" & IIf(chkPLock.Checked, "1", "0") & "',PLockDays='" & Val(txtPLockDays.EditValue) & "',PLockMsg='" & ReplaceApostrophe(txtPLockMsg.Text) & "'"
        End If
        Common.ExecuteQuery(Query)

        MsgBox("Data updated successfully", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))
        ClearTextboxes()
    End Sub
   
    Private Sub dtpRegDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpRegDate.KeyDownEvent, dtpRenewDate.KeyDownEvent, chkAMsg.KeyDown, txtADays.KeyDown, chkALock.KeyDown, txtRenewDays.KeyDown, dtpPDate.KeyDownEvent, chkPMsg.KeyDown, txtPMsgDays.KeyDown, chkPLock.KeyDown, txtPLockDays.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub chkAMsg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAMsg.CheckedChanged
      
        If chkAMsg.Checked = True Then
            txtADays.Enabled = True
            txtAMCMsg.Enabled = True
        Else
            txtADays.Enabled = False
            txtADays.Text = "0"
            txtAMCMsg.Enabled = False
            txtAMCMsg.Clear()

        End If

    End Sub

    Private Sub chkPMsg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPMsg.CheckedChanged
        If chkPMsg.Checked = True Then
            txtPMsgDays.Enabled = True
            txtPaymentMsg.Enabled = True
        Else
            txtPMsgDays.Enabled = False
            txtPMsgDays.Text = "0"
            txtPaymentMsg.Enabled = False
            txtPaymentMsg.Clear()
        End If
    End Sub

    Private Sub chkALock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkALock.CheckedChanged
        If chkALock.Checked = True Then
            txtRenewDays.Enabled = True
            txtALockMsg.Enabled = True

        Else
            txtRenewDays.Enabled = False
            txtRenewDays.Text = "0"
            txtALockMsg.Clear()
            txtALockMsg.Enabled = False
        End If
    End Sub

    Private Sub chkPLock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPLock.CheckedChanged
        If chkPLock.Checked = True Then
            txtPLockDays.Enabled = True
            txtPLockMsg.Enabled = True
        Else
            txtPLockDays.Enabled = False
            txtPLockDays.Text = "0"
            txtPLockMsg.Clear()
            txtPLockMsg.Enabled = False
        End If
    End Sub

   
End Class