Imports System.Data.SqlClient

Public Class frmAllowVoiceForOpenModule

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Try

            Me.Cursor = Cursors.WaitCursor

            If MsgBox("Are you sure, you want to " & IIf(rdOpen.Checked, "Open", "Close") & " the module as per voice ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName)) = MsgBoxResult.No Then Exit Sub

            Query = "UPDATE ApplnSettings Set AppSett_Value = " & IIf(rdOpen.Checked, 1, 0) & " Where AppSett_Id = " & ApplnSettingsIdx.AllowVoiceForOpenModule & " "
            Common.ExecuteQuery(Query)



        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmrptRecordHistory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmAllowVoiceForOpenModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Query = "Select AppSett_Value From ApplnSettings With(Nolock)  Where AppSett_Id = " & ApplnSettingsIdx.AllowVoiceForOpenModule & " "
        Dim DtAppSettValue As DataTable = Common.GetDataTable(Query)
        If DtAppSettValue.Rows.Count > 0 Then
            If DtAppSettValue.Rows(0).Item("AppSett_Value") = 1 Then
                rdOpen.Checked = True
            Else
                rdClose.Checked = True
            End If
        End If

    End Sub




End Class