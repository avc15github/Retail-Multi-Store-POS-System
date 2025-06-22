Imports Microsoft.Win32

Public Class frmActivation

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If rd30Days.Checked Then
                IsDemo = True

                Dim ValidTill As Date = DateAdd(DateInterval.Day, 30, Now.Date)
                Dim EncVal As String = Format$(ValidTill, "ddMMyyyy")
                Dim SoftKey As String = ""
                Dim SoftValue As String = ""
                Dim EncCPU As String = ""
                Dim CPUId As String = GetMachineDetails()

                EncCPU = EncryptValue(CPUId)
                EncVal = EncryptValue(CPUId) & "1" & EncryptValue(EncVal)
                ReportParameters.NewCPUId = EncVal
                Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\VRS", True)

                MsgBox("1", MsgBoxStyle.OkOnly)
                If IsNothing(regKey) Then
                    'If IO.File.Exists(sysFile) Then
                    '    IO.File.SetAttributes(sysFile, IO.FileAttributes.Normal)
                    'End If

                    'Dim File As New IO.StreamWriter(sysFile, False)
                    'File.Write(EncVal)
                    'File.Flush()
                    'File.Close()

                    'IO.File.SetAttributes(sysFile, IO.FileAttributes.ReadOnly)

                    'regKey = Registry.CurrentUser.CreateSubKey("Software\VRS")

                    'Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftValue", EncVal)
                    'Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftKey", "0")

                Else
                    SoftKey = Registry.GetValue("HKEY_CURRENT_USER\Software\VRS", "SoftKey", "")
                    If SoftKey = "" Then
                        SoftValue = Registry.GetValue("HKEY_CURRENT_USER\Software\VRS", "SoftValue", "")
                        If SoftValue <> "" Then
                            SoftValue = EncryptValue(SoftValue)
                            If IsDate(Mid$(SoftValue, 1, 2) & "/" & Mid$(SoftValue, 3, 2) & "/" & Mid$(SoftValue, 5)) Then
                                Dim SoftValDate As Date = CDate(Mid$(SoftValue, 1, 2) & "/" & Mid$(SoftValue, 3, 2) & "/" & Mid$(SoftValue, 5))

                                If Now.Date > SoftValDate Then
                                    Me.Close()
                                    Application.Exit()
                                Else
                                    Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftKey", "0")
                                End If
                            End If
                        End If
                        MsgBox("2", MsgBoxStyle.OkOnly)
                    ElseIf SoftKey <> "0" Then
                        SoftwareExpired()

                    ElseIf SoftKey = "0" Then
                        SoftValue = Registry.GetValue("HKEY_CURRENT_USER\Software\VRS", "SoftValue", "")
                        If SoftValue <> "" Then
                            SoftValue = EncryptValue(SoftValue)
                            If IsDate(Mid$(SoftValue, 1, 2) & "/" & Mid$(SoftValue, 3, 2) & "/" & Mid$(SoftValue, 5)) Then
                                Dim SoftValDate As Date = CDate(Mid$(SoftValue, 1, 2) & "/" & Mid$(SoftValue, 3, 2) & "/" & Mid$(SoftValue, 5))

                                If Now.Date > SoftValDate Then
                                    SoftwareExpired()
                                End If
                            End If
                        End If
                    End If
                End If

                If rdServer.Checked Then
                    InstallOpt = InstallOption.Server
                Else
                    InstallOpt = InstallOption.Client
                End If

                If rdBasic.Checked Then
                    EditionType = Edition.Basic
                ElseIf rdProfessional.Checked Then
                    EditionType = Edition.Professional
                ElseIf rdEnterprise.Checked Then
                    EditionType = Edition.Enterprise
                End If

                Dim EdType As String = GetEditionKey(EditionType)
                Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "Edition", EdType)

                RestoreData = False
                ServerName = Environment.MachineName & "\SQLExpress"
                If Not DatabaseExists("VRSDemo") Then
                    RestoreData = True
                End If
                ServerName = ""

                Me.Visible = False
                Me.Opacity = 0
                Me.ShowInTaskbar = False
                Dim frmServerDetails As New frmServerDetails
                frmServerDetails.Show()
            Else
                IsDemo = False

                If rdServer.Checked Then
                    InstallOpt = InstallOption.Server
                Else
                    InstallOpt = InstallOption.Client
                End If

                If rdBasic.Checked Then
                    EditionType = Edition.Basic
                ElseIf rdProfessional.Checked Then
                    EditionType = Edition.Professional
                ElseIf rdEnterprise.Checked Then
                    EditionType = Edition.Enterprise
                End If

                RestoreData = False
                ServerName = Environment.MachineName & "\SQLExpress"
                If Not DatabaseExists("VRSRetail") Then
                    RestoreData = True
                End If
                ServerName = ""

                Me.Visible = False
                Me.Opacity = 0
                Me.ShowInTaskbar = False
                Dim frmServerDetails As New frmServerDetails
                frmServerDetails.Show()
            End If


        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmActivation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmActivation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Opacity = 0
        Dim SoftKey As String = Registry.GetValue("HKEY_CURRENT_USER\Software\VRS", "SoftKey", "")
        Dim SoftValue As String = ""

        Dim RegKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\International", True)
        RegKey.SetValue("sShortDate", "dd/MM/yyyy")
        Console.WriteLine(RegKey.GetValue("sShortDate"))

        IsDemo = False
        If SoftKey <> "" And SoftKey <> "0" Then
            SoftwareExpired()


        ElseIf SoftKey = "0" Then
            SoftValue = Registry.GetValue("HKEY_CURRENT_USER\Software\VRS", "SoftValue", "")
            Dim DateIs As String = Mid(SoftValue, Len(SoftValue) - 7)

            If SoftValue.Trim.Length <= 16 Then
                If IO.File.Exists(sysFile) Then
                    Dim CPURead As New IO.StreamReader(sysFile)
                    Dim CPUFile As String = CPURead.ReadLine.Trim
                    CPURead.Close()

                    If SoftValue <> CPUFile Then
                        SoftwareExpired()
                    Else
                        Me.Visible = False
                        Me.Opacity = 0
                        Me.ShowInTaskbar = False
                        Dim frmServerDetails As New frmServerDetails
                        frmServerDetails.Show()
                    End If
                Else
                    SoftValue = EncryptValue(SoftValue)
                    Dim CPUId As String = GetMachineDetails() 'GetCPUId()

                    If CPUId = SoftValue Then
                        Dim File As New IO.StreamWriter(sysFile, False)
                        File.Write(EncryptValue(SoftValue))
                        File.Flush()
                        File.Close()

                        IO.File.SetAttributes(sysFile, IO.FileAttributes.ReadOnly)

                        Me.Visible = False
                        Me.Opacity = 0
                        Me.ShowInTaskbar = False
                        Dim frmServerDetails As New frmServerDetails
                        frmServerDetails.Show()
                    End If
                End If

            ElseIf SoftValue.Trim.Length > 16 Then

                IsDemo = True
                Dim CPUReg As String = Mid(SoftValue, 1, Len(SoftValue) - 9)
                CPUReg = EncryptValue(CPUReg)
                DateIs = EncryptValue(DateIs)

                If IsDate(Mid$(DateIs, 1, 2) & "/" & Mid$(DateIs, 3, 2) & "/" & Mid$(DateIs, 5)) Then
                    Dim SoftValDate As Date = CDate(Mid$(DateIs, 1, 2) & "/" & Mid$(DateIs, 3, 2) & "/" & Mid$(DateIs, 5))

                    If IO.File.Exists(sysFile) Then
                        Dim CPURead As New IO.StreamReader(sysFile)
                        Dim CPUFile As String = CPURead.ReadLine
                        CPURead.Close()

                        Dim ExtendFlag As String = ""

                        If CPUFile.Trim.Length > 0 Then
                            ExtendFlag = Mid$(CPUFile, Len(CPUFile) - 8, 1)

                            CPUFile = Mid$(CPUFile, 1, Len(CPUFile) - 9)
                            CPUFile = EncryptValue(CPUFile)
                        End If

                        If Now.Date > SoftValDate Or CPUReg <> CPUFile Then
                            If Now.Date > SoftValDate Then
                                'If ExtendFlag = "1" Then
                                '    Dim frmExtend As New frmSoftwareExtend
                                '    Dim Res As Byte = frmExtend.ShowDialog

                                '    If Res = Windows.Forms.DialogResult.Yes Then
                                '        ExtendDemoVersion()
                                '        Exit Sub

                                '    ElseIf Res = Windows.Forms.DialogResult.Cancel Then
                                '        Me.Close()
                                '        Application.Exit()
                                '    End If

                                'ElseIf ExtendFlag = "2" Then
                                '    Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftKey", "1")
                                '    SoftwareExpired()
                                '    Exit Sub
                                'End If

                                SoftwareExpired()
                            End If
                        Else
                            Dim ServerName As String = Registry.GetValue("HKEY_CURRENT_USER\Software\VRS\DataKeys", "Server", "")

                            If Not IsNothing(ServerName) Then
                                If ServerName.Trim.Length > 0 Then
                                    Me.Visible = False
                                    Me.Opacity = 0
                                    Me.ShowInTaskbar = False
                                    Dim frmServerDetails As New frmServerDetails
                                    frmServerDetails.Show()
                                End If
                            End If
                        End If
                    Else
                        Dim File As New IO.StreamWriter(sysFile, False)
                        File.Write(SoftValue)
                        File.Flush()
                        File.Close()

                        IO.File.SetAttributes(sysFile, IO.FileAttributes.ReadOnly)

                        Me.Visible = False
                        Me.Opacity = 0
                        Me.ShowInTaskbar = False
                        Dim frmServerDetails As New frmServerDetails
                        frmServerDetails.Show()
                    End If
                Else
                    SoftwareExpired()
                End If
            Else
                SoftwareExpired()
            End If
        End If

        IsInstalling = True
    End Sub

    Private Sub ExtendDemoVersion()
        IsDemo = True

        Dim ValidTill As Date = DateAdd(DateInterval.Day, 15, Now.Date)
        Dim EncVal As String = Format$(ValidTill, "ddMMyyyy")
        Dim EncCPU As String = EncryptValue(GetMachineDetails)

        EncVal = EncCPU & "2" & EncryptValue(EncVal)

        If IO.File.Exists(sysFile) Then
            IO.File.SetAttributes(sysFile, IO.FileAttributes.Normal)
            IO.File.Delete(sysFile)
        End If

        Dim File As New IO.StreamWriter(sysFile, False)
        File.Write(EncVal)
        File.Flush()
        File.Close()

        IO.File.SetAttributes(sysFile, IO.FileAttributes.ReadOnly)

        Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftValue", EncVal)
        Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftKey", "0")

        Dim EdType As String = GetEditionKey(EditionType)
        Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "Edition", EncryptValue(EdType))

        Me.Visible = False
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Dim frmServerDetails As New frmServerDetails
        frmServerDetails.Show()
    End Sub

    Private Sub SoftwareExpired()
        MsgBox("Software Expired, Contact Administrator !", MsgBoxStyle.Critical, "")
        'Me.Close()
        'Application.Exit()
    End Sub

    Private Sub frmActivation_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'If Me.Visible Then Me.Opacity = 100
    End Sub

    Private Sub rd30Days_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rd30Days.CheckedChanged
        pnlInstallOption.Enabled = True
        If rd30Days.Checked Then
            rdServer.Checked = True
            pnlInstallOption.Enabled = False
        End If
    End Sub
End Class