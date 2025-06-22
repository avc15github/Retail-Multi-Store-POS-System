Imports System.Management
Imports Microsoft.Win32

Public Class frmRegistration

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

        If Not RegisterCancel Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmRegistration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmRegistration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor

        Dim strCPUId As String = GetMachineDetails() 'GetCPUId()
        'Dim strMACId As String = GetMACAddress()
        Dim CPU(5) As String

        CPU(0) = Mid$(strCPUId, 1, 4)
        CPU(1) = Mid$(strCPUId, 5, 4)
        CPU(2) = Mid$(strCPUId, 9, 4)
        CPU(3) = Mid$(strCPUId, 13, 4)

        lblMachineKey.Text = CPU(0) & "-" & CPU(1) & "-" & CPU(2) & "-" & CPU(3) 'EncryptMachineKey(strCPUId & strMACId, 2)

        With cmbUsers.Items
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("5")
            .Add("6")
            .Add("7")
            .Add("8")
            .Add("9")
            .Add("10")
        End With

        cmbUsers.SelectedIndex = 0

        If InstallOpt = InstallOption.Client Then
            pnlCompany.Enabled = False
        End If

        ServerName = Environment.MachineName & "\SQLExpress"
        If Not DatabaseExists("VRSRetail") Then
            RestoreData = True
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Function EncryptMachineKey(ByVal strString As String, ByVal bytStep As Byte) As String
        Dim i As Short
        Dim EncrString As String = ""
        Dim NewString As String

        For i = 1 To strString.Length Step bytStep
            NewString = Asc(Mid$(strString, i, 1)) Xor 1
            EncrString &= Chr(NewString)
        Next i
        Return EncrString
    End Function

    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        If InstallOpt = InstallOption.Server Then
            If txtCompany.Text.Trim.Length = 0 Then
                MsgBox("Company name not specified !", MsgBoxStyle.Exclamation, "")
                txtCompany.Focus()
                Exit Sub

            ElseIf txtContact.Text.Trim.Length = 0 Then
                MsgBox("Contact person not specified !", MsgBoxStyle.Exclamation, "")
                txtContact.Focus()
                Exit Sub
            End If
        End If


        Try
            Me.Cursor = Cursors.WaitCursor

            If Not MachineVerified() Then
                MsgBox("Invalid registration key !", MsgBoxStyle.Exclamation, "")
                Exit Sub
            Else
                Dim CPUId As String = GetMachineDetails() 'GetCPUId()

                ''MessageBox.Show(CPUId)
                If DemoActivate Then
                    SharedVariables.RegnKey = txtRegistration.GetKeyValue
                    SharedVariables.RegnCompany = txtCompany.Text
                    SharedVariables.RegnContact = txtContact.Text
                    SharedVariables.RegnAddress = txtAddress.Text
                    SharedVariables.RegnStation = txtStation.Text
                    SharedVariables.RegnPin = txtPin.Text
                    SharedVariables.RegnPhone = txtPhone.Text
                    SharedVariables.RegnEmail = txtEmail.Text
                    SharedVariables.RegnUsers = cmbUsers.Text

                    InstallOpt = InstallOption.Server

                    RestoreData = False
                    'ServerName = Environment.MachineName & "\SQLExpress"
                    If Not DatabaseExists("VRSRetail") Then
                        RestoreData = True
                    End If
                    'ServerName = ""

                    Dim frmServerDtls As New frmServerDetails
                    frmServerDetails.ShowDialog()
                Else
                    Dim db As New CreateDatabase
                    If IsNothing(ReportParameters.RetServerName) Then
                        db.NewServerName = ServerName
                    Else
                        db.NewServerName = ReportParameters.RetServerName
                    End If
                    db.CreateSAPassword(InstallOpt)
                    'MessageBox.Show("After CreateSAPassword")

                    db.UpdateRegistration()
                    'MessageBox.Show("After UpdateRegistration")

                    If InstallOpt = InstallOption.Server Then
                        'If EditionType = Edition.Basic Then
                        '    db.ApplyBasic(ReportParameters.RetServerName, ReportParameters.RetDBName)

                        'Else
                        If EditionType = Edition.Professional Then
                            db.ApplyProfessional(ReportParameters.RetServerName, ReportParameters.RetDBName)

                        ElseIf EditionType = Edition.Enterprise Then
                            db.ApplyEnterprise(ReportParameters.RetServerName, ReportParameters.RetDBName)
                        End If
                    End If

                    db = Nothing

                    Dim EncCPU As String = EncryptValue(CPUId)

                    'MessageBox.Show("CPUId " & CPUId)

                    Query = "Select IsNull(Count(SerialNo), 0) " _
                        & " From Registration " _
                        & " Where SerialNo = '" & CPUId & "'"
                    Dim Reg As Byte = CType(Common.ExecuteScalar(Query), Byte)

                    'MessageBox.Show("Reg " & Reg)
                    If Reg > 0 Then
                        Query = "Update Registration Set ReInstalledOn = '" & Format$(Now.Date, "MM/dd/yyyy") & "'" _
                            & " Where SerialNo = '" & CPUId & "'"

                        'MessageBox.Show("Query " & Query)
                        Common.ExecuteQuery(Query)
                    Else
                        If InstallOpt = InstallOption.Server Then
                            Dim EdType As String = GetEditionKey(EditionType)

                            Query = "Insert Into Registration Values ('" & CPUId & "','" & txtRegistration.GetKeyValue & "','" & ReplaceApostrophe(txtCompany.Text) & "','" & ReplaceApostrophe(txtContact.Text) & "','" & ReplaceApostrophe(txtAddress.Text) & "','" & ReplaceApostrophe(txtStation.Text) & "','" & ReplaceApostrophe(txtPin.Text) & "','" & ReplaceApostrophe(txtPhone.Text) & "','" & ReplaceApostrophe(txtEmail.Text) & "'," & Val(cmbUsers.Text) & ",'" & Format$(Now, "MM/dd/yyyy hh:mm:ss tt") & "',Null,'" & IIf(InstallOpt = InstallOption.Server, "S", "C") & "','" & ReportParameters.RetServerName & "','" & ReportParameters.RetDBName & "','" & EdType & "')"
                            'MessageBox.Show("Query " & Query)
                            Common.ExecuteQuery(Query)
                        End If
                    End If

                    Me.Visible = False
                    Me.Opacity = 0
                    Me.ShowInTaskbar = False
                    'Dim frmLogin As New frmLogin
                    'frmLogin.Show()

                    Dim splash As New Splash
                    splash.Show()
                End If
            End If

        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function MachineVerified() As Boolean
        Dim Reg As New Register

        Dim CPUId As String = GetMachineDetails() 'GetCPUId()
        'Dim MACId As String = GetMACAddress()

        Dim MachKey As String = EncryptValue(CPUId)
        Dim RegKey As String = Reg.GenerateKey(CPUId)

        Return (RegKey = txtRegistration.GetKeyValue)
    End Function

    Private Sub txtCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompany.KeyDown, txtContact.KeyDown, txtStation.KeyDown, txtPin.KeyDown, txtPhone.KeyDown, txtEmail.KeyDown, cmbUsers.KeyDown, txtRegistration.KeyDown
        MoveToNextControl(e)
    End Sub
End Class