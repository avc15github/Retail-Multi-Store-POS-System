Imports System.Data.SqlClient
Imports System.IO

Public Class frmSettings
    Dim sqlConn As SqlConnection
    Dim strConnString As String = ""
    Dim blnCancelBtn As Boolean
    Dim CurrModule As String = "ndSetting"

    Private Sub btnSupplierField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplierField.Click
        Dim frmItemField As New frmItemUserField("S")
        frmItemField.ShowDialog()
    End Sub

    Private Sub btnItemField_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnItemField.Click
        Dim frmItemField As New frmItemUserField("I")

        frmItemField.ShowDialog()
        'Me.Close()
    End Sub
    Private Sub btnStoreLocationField_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStyleField.Click
        'Rajashri-14-03-2022
        Dim frmItemField As New frmItemUserField("B")
        frmItemField.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnItemField.Focus()
    End Sub

    Private Sub btnCustomerField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerField.Click
        Dim frmItemField As New frmItemUserField("C")
        frmItemField.ShowDialog()
    End Sub

    Private Sub btnCopyTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyTo.Click

    End Sub

    Private Sub btnEmployeeField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployeeField.Click
        Dim frmItemField As New frmItemUserField("E")
        frmItemField.ShowDialog()
    End Sub

End Class