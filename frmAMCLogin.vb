Imports System.Data.SqlClient

Public Class frmAMCLogin
    Dim RecordId As String = ""
    Private Sub frmAMCLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub RetrieveRecord()

        Try
            Me.Cursor = Cursors.WaitCursor
            Query = "Select * From ApplnSettings where AppSett_Id = '296'"
            Dim ALogin As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow
            If ALogin.Rows.Count > 0 Then
                For Each RecRow In ALogin.Rows

                    txtUser.Text = Common.EncryptDecryptValue(RecRow("AppSett_Value") & "", "0")

                Next RecRow
                ALogin = Nothing
            End If

        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub RetrieveRecord1()

        Try
            Me.Cursor = Cursors.WaitCursor
            Query = "Select * From ApplnSettings where AppSett_Id = '297'"
            Dim ALogin As DataTable = Common.GetDataTable(Query)
            Dim RecRow As DataRow
            If ALogin.Rows.Count > 0 Then
                For Each RecRow In ALogin.Rows

                    txtPwd.Text = Common.EncryptDecryptValue(RecRow("AppSett_Value") & "", "0")

                Next RecRow
                ALogin = Nothing
            End If


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Query = "Select * From ApplnSettings"
        Dim ALogin As DataTable = Common.GetDataTable(Query)
        Query = "Update ApplnSettings " _
           & " Set AppSett_Value='" & Common.EncryptDecryptValue(txtUser.Text, "1") & "' where AppSett_Id='296'"
        Common.ExecuteQuery(Query)

        Query1 = "Select * From ApplnSettings"
        Dim ALogin1 As DataTable = Common.GetDataTable(Query1)
        Query1 = "Update ApplnSettings " _
             & " Set AppSett_Value='" & Common.EncryptDecryptValue(txtPwd.Text, "1") & "' where AppSett_Id='297'"
        Common.ExecuteQuery(Query1)

        MsgBox("Data updated successfully", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareName))

    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown, txtPwd.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub frmAMCLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RetrieveRecord()
        RetrieveRecord1()
    End Sub
End Class