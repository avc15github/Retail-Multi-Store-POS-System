Public Class frmViewContactUs

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmViewContactUs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmViewContactUs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Query = "Select * From ContactUs"
        Dim ContactUs As DataTable = Common.GetDataTable(Query)

        If ContactUs.Rows.Count > 0 Then
            Dim RecRow As DataRow = ContactUs.Rows(0)

            txtCompany.Text = RecRow("CompanyName") & ""
            txtContact.Text = RecRow("ContactPerson") & ""
            txtAddress.Text = RecRow("RegdAddr") & ""
            txtPhone1.Text = RecRow("Phone1") & ""
            txtPhone2.Text = RecRow("Phone2") & ""
            txtFax.Text = RecRow("FaxNo") & ""
            txtMobile.Text = RecRow("Mobile") & ""
            txtEmail.Text = RecRow("Email") & ""
            txtWebsite.Text = RecRow("Website") & ""
        End If
    End Sub
End Class