Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.Configuration
Imports System.Xml
Imports System.Reflection



Public Class frmServerDetails

    Private Sub btnDBFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBFile.Click
        Dim opDlg As New OpenFileDialog

        With opDlg
            .InitialDirectory = Application.StartupPath
            .Filter = "Backup Files (*.bak)|*.bak"
            .Title = "Backup file..."

            If opDlg.ShowDialog = DialogResult.OK Then
                txtFile.Text = .FileName
            End If
        End With
    End Sub

    Private Sub frmServerDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not DemoActivate Then
            Dim db As New CreateDatabase

            If InstallOpt = InstallOption.Client Then
                pnlServer.Visible = False
                txtServer.ReadOnly = False
                txtDatabase.ReadOnly = False
            End If

            chkDemo.Visible = IsDemo

            If db.CreateNewData Then

                MsgBox("2.1", MsgBoxStyle.OkOnly)

                Dim instance As System.Data.Sql.SqlDataSourceEnumerator = System.Data.Sql.SqlDataSourceEnumerator.Instance
                Dim table As System.Data.DataTable = instance.GetDataSources()

                If table.Rows.Count > 0 Then
                    txtServer.Text = Environment.MachineName & "\" & table.Rows(0).Item("InstanceName") & ""
                Else
                    txtServer.Text = Environment.MachineName & "\SQLExpress"
                End If


                txtDatabase.Text = IIf(IsDemo, "VRSDemo", "VRSRetail")
                MsgBox("3", MsgBoxStyle.OkOnly)
                If Not RestoreData Then
                    btnOK_Click(btnOK, Nothing)
                    MsgBox("4", MsgBoxStyle.OkOnly)
                End If
            Else
                Me.Visible = False
                Me.Opacity = 0
                Me.ShowInTaskbar = False
                'Dim frmLogin As New frmLogin
                'frmLogin.ShowDialog()

                Dim splash As New Splash
                splash.Show()
            End If
        Else
            Dim instance As System.Data.Sql.SqlDataSourceEnumerator = System.Data.Sql.SqlDataSourceEnumerator.Instance
            Dim table As System.Data.DataTable = instance.GetDataSources()

            If table.Rows.Count > 0 Then
                txtServer.Text = Environment.MachineName & "\" & table.Rows(0).Item("InstanceName") & ""
            Else

                txtServer.Text = Environment.MachineName & "\SQLExpress"
            End If
            txtDatabase.Text = "VRSRetail"

            If Not RestoreData Then
                btnOK_Click(btnOK, Nothing)
            End If
        End If

        'Me.Activate()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

        If Not DemoActivate Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not IsDemo And Not RestoreData Then
            ReportParameters.RetServerName = txtServer.Text
            ReportParameters.RetDBName = txtDatabase.Text
            ReportParameters.RetDBFile = txtFile.Text

            Me.Visible = False
            Me.Opacity = 0
            Me.ShowInTaskbar = False
            MsgBox("5", MsgBoxStyle.OkOnly)
            Dim frmRegistration As New frmRegistration
            frmRegistration.ShowDialog()
            MsgBox("STEP 0 DONE", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            If RestoreData Then
                If txtServer.Text.Trim.Length = 0 Then
                    MsgBox("Invalid server specified !", MsgBoxStyle.Exclamation, "")
                    txtServer.Focus()
                    Exit Sub

                ElseIf txtDatabase.Text.Trim.Length = 0 Then
                    MsgBox("Invalid database specified !", MsgBoxStyle.Exclamation, "")
                    txtDatabase.Focus()
                    Exit Sub

                ElseIf txtFile.Text.Trim.Length = 0 Then
                    If InstallOpt = InstallOption.Server Then
                        MsgBox("Invalid file specified !", MsgBoxStyle.Exclamation, "")
                        txtFile.Focus()
                        Exit Sub
                    End If
                End If
                MsgBox("6", MsgBoxStyle.OkOnly)
                If InstallOpt = InstallOption.Server Then
                    If Not IO.File.Exists(txtFile.Text) Then
                        MsgBox("Invalid data file specified !", MsgBoxStyle.Exclamation, "")
                        txtFile.Focus()
                        Exit Sub
                    End If
                End If
            End If
        End If
        

        Try
            Me.Cursor = Cursors.WaitCursor

            If DemoActivate Then
                Dim CPUId As String = GetMachineDetails()
                Dim OrigCPUId As String = CPUId

                Dim db As New CreateDatabase

                If Not DatabaseExists(txtDatabase.Text) Then
                    db.NewServerName = txtServer.Text
                    db.NewDBName = txtDatabase.Text
                    db.RestoreDBFile = txtFile.Text

                    db.CreateAndRestoreDB(txtDatabase.Text)



                    MsgBox("STEP 1 DONE", MsgBoxStyle.OkOnly)
                End If
                Database = txtDatabase.Text
                MsgBox("STEP 9 DONE", MsgBoxStyle.OkOnly)
                CPUId = EncryptValue(CPUId)
                Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftValue", CPUId)
                Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "SoftKey", "0")

                Dim EdType As String = GetEditionKey(EditionType)
                Registry.SetValue("HKEY_CURRENT_USER\Software\VRS", "Edition", EdType)

                If IO.File.Exists(sysFile) Then
                    IO.File.SetAttributes(sysFile, IO.FileAttributes.Normal)
                End If

                Dim File As New IO.StreamWriter(sysFile, False)
                File.Write(CPUId)
                File.Flush()
                File.Close()

                IO.File.SetAttributes(sysFile, IO.FileAttributes.ReadOnly)

                MsgBox("STEP 2 DONE", MsgBoxStyle.OkOnly)
                ''Update config file at startup
                ''************************************************************************************************
                '' load config document for current assembly
                Dim doc As XmlDocument = LoadConfigDocument()

                MsgBox("STEP 3 DONE", MsgBoxStyle.OkOnly)
                ' retrieve appSettings node
                Dim node As XmlNode = doc.SelectSingleNode("//appSettings")

                If IsNothing(node) Then
                    Throw New InvalidOperationException("appSettings section not found in config file.")
                End If
                MsgBox("STEP 4 DONE", MsgBoxStyle.OkOnly)
                ' select the 'add' element that contains the key
                Dim elem As XmlElement = CType(node.SelectSingleNode(String.Format("//add[@key='{0}']", "Server")), XmlElement)

                If Not IsNothing(elem) Then
                    ' add value for key
                    elem.SetAttribute("value", txtServer.Text)
                End If

                elem = CType(node.SelectSingleNode(String.Format("//add[@key='{0}']", "Database")), XmlElement)

                If Not IsNothing(elem) Then
                    ' add value for key
                    elem.SetAttribute("value", txtDatabase.Text)
                End If
                MsgBox("STEP 5 DONE", MsgBoxStyle.OkOnly)
                doc.Save(getConfigFilePath())
                ''************************************************************************************************

                Query = "Insert Into Registration Values ('" & OrigCPUId & "','" & SharedVariables.RegnKey & "','" & SharedVariables.RegnCompany & "','" & SharedVariables.RegnContact & "','" & SharedVariables.RegnAddress & "','" & SharedVariables.RegnStation & "','" & SharedVariables.RegnPin & "','" & SharedVariables.RegnPhone & "','" & SharedVariables.RegnEmail & "'," & SharedVariables.RegnUsers & ",'" & Format$(Now, "MM/dd/yyyy hh:mm:ss tt") & "',Null,'S','" & ReportParameters.RetServerName & "','" & ReportParameters.RetDBName & "','" & EdType & "')"
                Common.ExecuteQuery(Query)

                DemoActivate = False

                MsgBox("Activation completed succesfully" & vbCrLf _
                    & "Please Re-Login for changes to take effect", MsgBoxStyle.Information, "")

                Me.Close()
                Application.Exit()

                'Me.Visible = False
                'Me.Opacity = 0

                'Dim frmLogin As New frmLogin
                'frmLogin.Show()
            Else
                MsgBox("7", MsgBoxStyle.OkOnly)
                ReportParameters.RetServerName = txtServer.Text
                ReportParameters.RetDBName = txtDatabase.Text
                ReportParameters.RetDBFile = txtFile.Text

                If IsDemo Then
                    Dim db As New CreateDatabase
                    db.NewServerName = txtServer.Text
                    db.NewDBName = txtDatabase.Text
                    db.CreateSAPassword(InstallOpt)
                    MsgBox("8", MsgBoxStyle.OkOnly)
                    db.UpdateRegistration()

                    Me.Visible = False
                    Me.Opacity = 0
                    Me.ShowInTaskbar = False

                    If InstallOpt = InstallOption.Server Then
                        'If EditionType = Edition.Basic Then
                        '    db.ApplyBasic(txtServer.Text, txtDatabase.Text)

                        'Else
                        If EditionType = Edition.Professional Then
                            db.ApplyProfessional(txtServer.Text, txtDatabase.Text)

                        ElseIf EditionType = Edition.Enterprise Then
                            db.ApplyEnterprise(txtServer.Text, txtDatabase.Text)
                        End If
                    End If

                    db = Nothing

                    'Dim frmLogin As New frmLogin
                    'frmLogin.ShowDialog()

                    Dim splash As New Splash
                    splash.Show()
                Else
                    Me.Visible = False
                    Me.Opacity = 0
                    Me.ShowInTaskbar = False

                    Dim frmRegistration As New frmRegistration
                    frmRegistration.ShowDialog()
                End If
                End If



        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chkDemo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDemo.CheckedChanged
        txtDatabase.ReadOnly = True
        btnDBFile.Visible = True
        If chkDemo.Checked Then
            txtDatabase.Text = "VRSDemo"
            txtFile.Text = Application.StartupPath & "\Demo\VRSDemo.bak"
            txtFile.ReadOnly = True
            btnDBFile.Visible = False
        Else
            txtDatabase.Text = "VRSRetail"
            txtFile.Clear()

            If InstallOpt = InstallOption.Client Then
                txtDatabase.ReadOnly = False
            End If
        End If
    End Sub

    Private Function LoadConfigDocument() As XmlDocument
        Try
            Dim doc As New XmlDocument()
            doc.Load(getConfigFilePath())
            Return doc

        Catch e As System.IO.FileNotFoundException
            Throw New Exception("No configuration file found.", e)
        End Try
    End Function

    Private Function getConfigFilePath() As String
        Return Assembly.GetExecutingAssembly().Location + ".config"
    End Function

    Private Sub chkDemo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkDemo.KeyDown, txtServer.KeyDown, txtDatabase.KeyDown
        MoveToNextControl(e)
    End Sub
End Class