Public Class frmSoftwareExtend

    Private Sub lnkExtend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkExtend.Click
        Dim Res As Byte = MsgBox("Do you want to extend software for another 15 days ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")

        If Res = Windows.Forms.DialogResult.No Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        ElseIf Res = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class