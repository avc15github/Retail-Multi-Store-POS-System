Imports System.Data.SqlClient

Public Class frmVoiceSearch
    Enum GridCols
        ModName
        AllowAccess
        IsFavourites
        FavCaption
        FavSeq
        FavShortcutKey
        ParentId
        ModId
        SeqNo
        Category
        HasChild
        IsReport
        RecStatus
    End Enum

    Dim currPos As DataGrid.HitTestInfo
    Dim WithEvents UserRights As DataTable
    Dim NewUserId As String = ""
    Dim change As Boolean


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmUserRights_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmUserRights_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Query = "Select USERS.LED_Key, LED_NAME " _
            & " From Users Inner Join Ledger On Users.Led_Key = Ledger.Led_Key " _
            & " Where Users.User_Id > 0" _
            & " Order By Led_Name"
        Common.FillCombo2(Query, cmbUser, "LED_NAME", "LED_Key")

        If cmbUser.Items.Count > 0 Then
            cmbUser.SelectedIndex = 0
        End If

        Query = "Select '<< ALL >>' CATEGORY, '<< ALL >>' MOD_DESC" _
            & " UNION ALL " _
            & " Select CATEGORY, MOD_DESC " _
            & " From Modules " _
            & " Where Parent_Id = 0 And Status = '1'" _
            & " Order By Category"
        Common.FillCombo2(Query, cmbMenu, "MOD_DESC", "CATEGORY")

        cmbMenu.SelectedIndex = 0

        'dtgDetails.ContextMenuStrip = mnuOption

        If NewUserId <> "" Then
            cmbUser.Value = NewUserId
            btnView_Click(btnView, Nothing)

            cmbUser.Enabled = False
        End If
    End Sub

    Private Sub FormatDataGrid(ByVal dtTable As DataTable)
        UserRights.DefaultView.AllowNew = False
        UserRights.DefaultView.AllowDelete = False
        dtgDetails.DataSource = UserRights

        Dim colSize As Byte = 60
        Dim tblStyle As New DataGridTableStyle

        With tblStyle
            .MappingName = UserRights.TableName
            .HeaderFont = New System.Drawing.Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point)
            .RowHeaderWidth = 12
            .ReadOnly = False
            .ForeColor = Color.DarkBlue
            .SelectionBackColor = Color.Lavender
            .SelectionForeColor = Color.DarkBlue
            .GridLineColor = Color.SteelBlue
            .HeaderForeColor = Color.Maroon
            .AllowSorting = False
            '    .ReadOnly = True
        End With

        Dim ModDesc As New DataGridTextBoxColumn()
        With ModDesc
            .MappingName = "Mod_Desc"
            .HeaderText = "Module"
            .Width = 300
            .ReadOnly = True
        End With

        Dim AllowAccess As New DataGridBoolColumn()
        With AllowAccess
            .MappingName = "AllowAccess"
            .TrueValue = "1"
            .FalseValue = "0"
            '.HeaderText = "Menu Access"
            .Width = 0
            .AllowNull = False
            .NullValue = False
        End With

        ''Add Favourites
        Dim IsFavourites As New DataGridBoolColumn()
        With IsFavourites
            .MappingName = "IsFavourites"
            .TrueValue = "1"
            .FalseValue = "0"
            .HeaderText = "Is Favourite"
            .AllowNull = False
            .NullValue = False
            .Width = 0
        End With

        Dim FavCaption As New DataGridTextBoxColumn()
        With FavCaption
            .MappingName = "FavCaption"
            .HeaderText = "Voice Character"
            .ReadOnly = False
            .Width = 300
        End With

        Dim FavSeq As New DataGridTextBoxColumn()
        With FavSeq
            .MappingName = "FavSeq"
            .HeaderText = "Favourites Seq"
            .ReadOnly = False
            .Width = 0
        End With

        Dim FavShortcut As New DataGridTextBoxColumn()
        With FavShortcut
            .MappingName = "FavShortcut"
            .HeaderText = "Favourites Shortcut"
            .ReadOnly = False
            .Width = 0
        End With
        '''''''''''''''''''''''''''''''''''''''

        Dim ParentId As New DataGridTextBoxColumn()
        With ParentId
            .MappingName = "Parent_Id"
            .HeaderText = "Par"
            .Width = 0
        End With

        Dim ModId As New DataGridTextBoxColumn()
        With ModId
            .MappingName = "Mod_Id"
            .HeaderText = "Mod"
            .Width = 0
        End With

        Dim SeqNo As New DataGridTextBoxColumn()
        With SeqNo
            .MappingName = "SeqNo"
            .HeaderText = ""
            .Width = 0
        End With

        Dim Category As New DataGridTextBoxColumn()
        With Category
            .MappingName = "Category"
            .HeaderText = ""
            .Width = 0
        End With

        Dim HasChild As New DataGridTextBoxColumn()
        With HasChild
            .MappingName = "HasChild"
            .HeaderText = ""
            .Width = 0
        End With

        Dim IsReport As New DataGridTextBoxColumn()
        With IsReport
            .MappingName = "IsReport"
            .HeaderText = ""
            .Width = 0
        End With

        Dim RecStatus As New DataGridTextBoxColumn()
        With RecStatus
            .MappingName = "RecStatus"
            .HeaderText = ""
            .Width = 0
        End With

        tblStyle.GridColumnStyles.Clear()
        tblStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {ModDesc, AllowAccess, IsFavourites, FavCaption, FavSeq, FavShortcut, ParentId, ModId, SeqNo, Category, HasChild, IsReport, RecStatus})

        ModDesc = Nothing : AllowAccess = Nothing : IsReport = Nothing : RecStatus = Nothing
        ParentId = Nothing : ModId = Nothing : SeqNo = Nothing : Category = Nothing
        IsFavourites = Nothing : FavCaption = Nothing : FavSeq = Nothing : FavShortcut = Nothing

        dtgDetails.TableStyles.Clear()
        dtgDetails.TableStyles.Add(tblStyle)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim RecRow As DataRow
        Dim Table As DataTable = CType(dtgDetails.DataSource, DataTable)

        If IsNothing(Table) Then Exit Sub
        If Table.Rows.Count = 0 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim recRows() As DataRow = Table.Select("RecStatus = 2", "")


            Dim Trans As SqlTransaction = CreateSQLTransaction()

            For Each RecRow In recRows
                If RecRow(GridCols.FavCaption) <> "" Then
                    Query = "Update Modules Set VoiceCharacter = '" & RecRow(GridCols.FavCaption).ToString.Trim & "'" _
                       & " Where Mod_Id = " & RecRow(GridCols.ModId)
                    Common.ExecuteQuery(Query, Trans)
                End If
               
            Next RecRow

            Trans.Commit()

            'MsgBox("Data updated successfully", MsgBoxStyle.Information, GetSettingAsPerId(ApplnSettingsIdx.SoftwareFor))

            btnView_Click(btnView, Nothing)


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuAllowDisallowAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAllowDisallow.Click
        If currPos.Row = -1 Then Exit Sub

        Try
            Dim LastRow As Short = currPos.Row
            Dim LastCol As Short = currPos.Column

            With dtgDetails
                Dim RowCount As Short = CType(.DataSource, DataTable).Rows.Count
                Dim ModId As Integer = .Item(LastRow, GridCols.ModId)

                ' If Not CBool(Val(.Item(currPos.Row, GridCols.HasChild))) Then
                '    If currPos.Column = GridCols.AllowAccess Then
                '        If CBool(Val(.Item(currPos.Row, GridCols.AllowAccess))) Then
                '            .Item(currPos.Row, GridCols.IsFavourites) = False
                '            .Item(currPos.Row, GridCols.FavCaption) = ""
                '            .Item(currPos.Row, GridCols.FavSeq) = 0
                '            .Item(currPos.Row, GridCols.FavShortcutKey) = ""
                '        Else
                '            .Item(currPos.Row, GridCols.IsFavourites) = True
                '        End If
                '    End If

                '    If .Item(currPos.Row, GridCols.RecStatus) = 0 Then
                '        .Item(currPos.Row, GridCols.RecStatus) = 2
                '    End If

                '    CType(dtgDetails.DataSource, DataTable).AcceptChanges()

                'Else
                '    If currPos.Column = GridCols.AllowAccess Then
                '        If CBool(Val(.Item(currPos.Row, GridCols.AllowAccess))) Then
                '            .Item(currPos.Row, GridCols.IsFavourites) = False
                '            .Item(currPos.Row, GridCols.FavCaption) = ""
                '            .Item(currPos.Row, GridCols.FavSeq) = 0
                '            .Item(currPos.Row, GridCols.FavShortcutKey) = ""
                '        Else
                '            .Item(currPos.Row, GridCols.IsFavourites) = True
                '        End If
                '    End If

                '    If .Item(currPos.Row, GridCols.RecStatus) = 0 Then
                '        .Item(currPos.Row, GridCols.RecStatus) = 2
                '    End If
                '    CType(dtgDetails.DataSource, DataTable).AcceptChanges()

                '    FirstLevel(ModId, LastRow, LastCol)

                '    dtgDetails.CurrentRowIndex = LastRow

                Try

                    If currPos.Column = GridCols.IsFavourites Then
                        If CBool(Val(dtgDetails.Item(currPos.Row, GridCols.HasChild))) Then
                            .Item(currPos.Row, GridCols.IsFavourites) = False

                        End If

                        If CBool(Val(.Item(currPos.Row, GridCols.IsFavourites))) Then
                            .Item(currPos.Row, GridCols.IsFavourites) = False
                            .Item(currPos.Row, GridCols.FavCaption) = ""
                            .Item(currPos.Row, GridCols.FavSeq) = 0
                            .Item(currPos.Row, GridCols.FavShortcutKey) = ""
                        Else
                            .Item(currPos.Row, GridCols.IsFavourites) = True
                        End If

                        'If .Item(currPos.Row, GridCols.RecStatus) = 0 Then
                        '    .Item(currPos.Row, GridCols.RecStatus) = 2
                        'End If
                        CType(.DataSource, DataTable).AcceptChanges()

                        'FirstLevel(ModId, LastRow, LastCol)

                        dtgDetails.CurrentRowIndex = LastRow
                        'End If
                    End If


                Catch
                End Try

            End With


        Catch Invex As InvalidCastException
            'Common.LogAndDisplayException(Invex)
            Exit Sub
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        End Try
    End Sub

    Private Sub FirstLevel(ByVal ModId As Integer, ByRef RowPos As Short, ByVal CurrCol As Byte)
        Dim i As Short
        Dim RowCount As Integer = CType(dtgDetails.DataSource, DataTable).Rows.Count
        Dim Flag As Boolean

        Try
            For i = RowPos + 1 To RowCount - 1
                With dtgDetails
                    If dtgDetails.Item(i, GridCols.ParentId) = ModId Then
                        If CBool(Val(dtgDetails.Item(i, GridCols.HasChild))) Then
                            If CurrCol = GridCols.AllowAccess Then
                                Flag = CBool(Val(.Item(RowPos, GridCols.AllowAccess)))
                                .Item(i, GridCols.IsFavourites) = Flag
                            End If

                            If .Item(i, GridCols.RecStatus) = 0 Then
                                .Item(i, GridCols.RecStatus) = 2
                            End If
                            CType(dtgDetails.DataSource, DataTable).AcceptChanges()

                            SecondLevel(dtgDetails.Item(i, GridCols.ModId), i, CurrCol)
                        Else
                            If CurrCol = GridCols.AllowAccess Then
                                Flag = CBool(Val(.Item(RowPos, GridCols.AllowAccess)))

                                .Item(i, GridCols.AllowAccess) = Flag
                                .Item(i, GridCols.IsFavourites) = Flag
                            End If

                            If .Item(i, GridCols.RecStatus) = 0 Then
                                .Item(i, GridCols.RecStatus) = 2
                            End If

                            CType(dtgDetails.DataSource, DataTable).AcceptChanges()
                        End If
                    Else
                        Exit For
                    End If
                End With
            Next i


        Catch Invex As InvalidCastException
            'Common.LogAndDisplayException(Invex)
            Exit Sub
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        End Try
    End Sub

    Private Sub SecondLevel(ByVal ModId As Integer, ByRef RowPos As Short, ByVal CurrCol As Byte)
        Dim i As Short
        Dim RowCount As Integer = CType(dtgDetails.DataSource, DataTable).Rows.Count
        Dim Flag As Boolean

        Try
            For i = RowPos + 1 To RowCount - 1
                With dtgDetails
                    If dtgDetails.Item(i, GridCols.ParentId) = ModId Then
                        If CBool(Val(dtgDetails.Item(i, GridCols.HasChild))) Then
                            If CurrCol = GridCols.AllowAccess Then
                                Flag = CBool(Val(.Item(RowPos, GridCols.AllowAccess)))

                                .Item(i, GridCols.IsFavourites) = Flag
                            End If

                            If .Item(i, GridCols.RecStatus) = 0 Then
                                .Item(i, GridCols.RecStatus) = 2
                            End If
                            CType(dtgDetails.DataSource, DataTable).AcceptChanges()

                            ThirdLevel(dtgDetails.Item(i, GridCols.ModId), i, CurrCol)
                        Else
                            If CurrCol = GridCols.AllowAccess Then
                                Flag = CBool(Val(.Item(RowPos, GridCols.AllowAccess)))

                                .Item(i, GridCols.AllowAccess) = Flag
                                .Item(i, GridCols.IsFavourites) = Flag
                            End If

                            If .Item(i, GridCols.RecStatus) = 0 Then
                                .Item(i, GridCols.RecStatus) = 2
                            End If

                            CType(dtgDetails.DataSource, DataTable).AcceptChanges()
                        End If
                    Else
                        Exit For
                    End If
                End With
            Next i

            RowPos = i - 1


        Catch Invex As InvalidCastException
            'Common.LogAndDisplayException(Invex)
            Exit Sub
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        End Try
    End Sub

    Private Sub ThirdLevel(ByVal ModId As Integer, ByRef RowPos As Short, ByVal CurrCol As Byte)
        Dim i As Short
        Dim RowCount As Integer = CType(dtgDetails.DataSource, DataTable).Rows.Count
        Dim Flag As Boolean

        Try
            For i = RowPos + 1 To RowCount - 1
                With dtgDetails
                    If dtgDetails.Item(i, GridCols.ParentId) = ModId Then
                        If CBool(Val(dtgDetails.Item(i, GridCols.HasChild))) Then
                            If CurrCol = GridCols.AllowAccess Then
                                Flag = CBool(Val(.Item(RowPos, GridCols.AllowAccess)))

                                .Item(i, GridCols.AllowAccess) = Flag
                                .Item(i, GridCols.IsFavourites) = Flag
                            End If

                            If .Item(i, GridCols.RecStatus) = 0 Then
                                .Item(i, GridCols.RecStatus) = 2
                            End If
                            CType(dtgDetails.DataSource, DataTable).AcceptChanges()

                            FirstLevel(dtgDetails.Item(i, GridCols.ModId), i, CurrCol)
                        Else
                            If CurrCol = GridCols.AllowAccess Then
                                Flag = CBool(Val(.Item(RowPos, GridCols.AllowAccess)))

                                .Item(i, GridCols.AllowAccess) = Flag
                                .Item(i, GridCols.IsFavourites) = Flag
                            End If

                            If .Item(i, GridCols.RecStatus) = 0 Then
                                .Item(i, GridCols.RecStatus) = 2
                            End If

                            CType(dtgDetails.DataSource, DataTable).AcceptChanges()
                        End If
                    Else
                        Exit For
                    End If
                End With
            Next i

            RowPos = i - 1


        Catch Invex As InvalidCastException
            'Common.LogAndDisplayException(Invex)
            Exit Sub
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        End Try
    End Sub

    Private Sub dtgDetails_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtgDetails.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                currPos = dtgDetails.HitTest(e.X, e.Y)

                If currPos.Row = -1 Then Exit Sub
            End If


        Catch Invex As InvalidCastException
            Exit Sub
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        End Try
    End Sub

    Private Sub AllowAllAccess(ByVal RowId As Short, ByVal currValue As Boolean)
        With dtgDetails
            If currValue And Not .Item(RowId, GridCols.AllowAccess) Then
                .Item(RowId, GridCols.AllowAccess) = True
            Else
                'If Not .Item(RowId, GridCols.AllowAdd) And Not .Item(RowId, GridCols.AllowEdit) And Not .Item(RowId, GridCols.AllowDelete) And Not .Item(RowId, GridCols.AllowView) And Not .Item(RowId, GridCols.AllowPrint) Then
                'If And Not .Item(RowId, GridCols.AllowView) And Not .Item(RowId, GridCols.AllowPrint) Then
                '    .Item(RowId, GridCols.AllowAccess) = False
                'End If
            End If
        End With
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If cmbUser.SelectedIndex = -1 Then Exit Sub

        Try
            Dim ModCat As String = ""

            Me.Cursor = Cursors.WaitCursor

            If cmbMenu.SelectedIndex > 0 Then
                ModCat = " And Modules.Category = '" & cmbMenu.Value & "'"
            End If

            'Query = "Select '<< ' + Mod_Desc + ' >>' Mod_Desc, '1' AllowAccess, '0' IsFavourites, '' FavCaption, 0 FavSeq, '' FavShortcut, Parent_Id, Modules.Mod_Id, Modules.Seqno, Modules.Category, Modules.HasChild, Modules.IsReport, 2 RecStatus " _
            '    & " From Modules Where Parent_Id = 0 And ModReq = '1' And Status = '1'" & ModCat _
            '    & " Union All " _
            '    & " Select Case When TreeLevel = 0 Then '' + Mod_Desc When TreeLevel = 1 Then '' + Mod_Desc When TreeLevel = 2 Then '      ' + Mod_Desc When TreeLevel = 3 Then '            ' + Mod_Desc Else '  ' + Mod_Desc End Mod_Desc, '0' AllowAccess, '0' IsFavourites, '' FavCaption, 0 FavSeq, '' FavShortcut, IsNull(Parent_Id, 0) Parent_Id, Modules.Mod_Id, Modules.Seqno, Modules.Category, Modules.HasChild, Modules.IsReport, 2 " _
            '    & " From Modules Where Mod_Id Not In (Select Mod_Id From UserRights Where User_Id = (Select User_Id From Users Where Led_Key = '" & cmbUser.Value & "'))" _
            '    & " And Parent_Id > 0  And ModReq = '1' And Status = '1'" & ModCat _
            '    & " Union All " _
            '    & " Select Case When TreeLevel = 0 Then '' + Mod_Desc When TreeLevel = 1 Then '' + Mod_Desc When TreeLevel = 2 Then '      ' + Mod_Desc  When TreeLevel = 3 Then '            ' + Mod_Desc Else '  ' + Mod_Desc End Mod_Desc, AllowAccess, IsFavourites, FavCaption, FavSeq, FavShortcut, Parent_Id, Modules.Mod_Id, Modules.Seqno, Modules.Category, Modules.HasChild, Modules.IsReport, 2 " _
            '    & " From UserRights Left Join Modules On UserRights.Mod_Id = Modules.Mod_Id " _
            '    & " Where User_Id = (Select User_Id From Users Where Led_Key = '" & cmbUser.Value & "')" _
            '    & " And Parent_Id > 0  And ModReq = '1' And Modules.Status = '1' and AllowAccess = '1' " & ModCat _
            '    & " Order By Modules.Category, Modules.SeqNo"

            Query = "Select '<< ' + Mod_Desc + ' >>' Mod_Desc, '1' AllowAccess, '0' IsFavourites, Modules.VoiceCharacter FavCaption, 0 FavSeq, '' FavShortcut, Parent_Id, Modules.Mod_Id, Modules.Seqno, Modules.Category, Modules.HasChild, Modules.IsReport, 2 RecStatus " _
                & " From Modules Where Parent_Id = 0 And ModReq = '1' And Status = '1'" & ModCat _
                & " Union All " _
                & " Select Case When TreeLevel = 0 Then '' + Mod_Desc When TreeLevel = 1 Then '' + Mod_Desc When TreeLevel = 2 Then '      ' + Mod_Desc When TreeLevel = 3 Then '            ' + Mod_Desc Else '  ' + Mod_Desc End Mod_Desc, '0' AllowAccess, '0' IsFavourites, Modules.VoiceCharacter  FavCaption, 0 FavSeq, '' FavShortcut, IsNull(Parent_Id, 0) Parent_Id, Modules.Mod_Id, Modules.Seqno, Modules.Category, Modules.HasChild, Modules.IsReport, 2 " _
                & " From Modules Where Mod_Id Not In (Select Mod_Id From UserRights Where User_Id = (Select User_Id From Users Where Led_Key = " & cmbUser.Value & "))" _
                & " And Parent_Id > 0  And ModReq = '1' And Status = '1'" & ModCat _
                & " Union All " _
                & " Select Case When TreeLevel = 0 Then '' + Mod_Desc When TreeLevel = 1 Then '' + Mod_Desc When TreeLevel = 2 Then '      ' + Mod_Desc  When TreeLevel = 3 Then '            ' + Mod_Desc Else '  ' + Mod_Desc End Mod_Desc, AllowAccess, IsFavourites, Modules.VoiceCharacter  FavCaption, FavSeq, FavShortcut, Parent_Id, Modules.Mod_Id, Modules.Seqno, Modules.Category, Modules.HasChild, Modules.IsReport, 2 " _
                & " From UserRights Left Join Modules On UserRights.Mod_Id = Modules.Mod_Id " _
                & " Where User_Id = (Select User_Id From Users Where Led_Key = " & cmbUser.Value & ")" _
                & " And Parent_Id > 0  And ModReq = '1' And Modules.Status = '1' and AllowAccess = '1' " & ModCat _
                & " Order By Modules.Category, Modules.SeqNo"
            UserRights = Common.GetDataTable(Query)

            FormatDataGrid(UserRights)


        Catch sqlEx As SqlException
            Common.LogAndDisplayException(sqlEx)
        Catch ex As Exception
            Common.LogAndDisplayException(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMenu.KeyDown, cmbUser.KeyDown
        MoveToNextControl(e)
    End Sub

    Private Sub cmbUser_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUser.ValueChanged, cmbMenu.ValueChanged
        'If cmbUser.SelectedIndex = -1 Then Exit Sub

        'Query = "Select Login_Name From Users Where Led_Key = '" & cmbUser.Value & "'"
        'Dim Login As String = Common.ExecuteScalar(Query)

        'lblLogin.Text = Login

        'dtgDetails.DataSource = Nothing
    End Sub

    Private Sub UserRights_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles UserRights.ColumnChanged
        'If change Then change = False : Exit Sub

        'If e.Column.Ordinal = GridCols.FavCaption Or e.Column.Ordinal = GridCols.FavSeq Or e.Column.Ordinal = GridCols.FavShortcutKey Then
        '    If Not CBool(Val(e.Row(GridCols.IsFavourites))) Then
        '        change = True
        '        e.Row(GridCols.FavCaption) = ""
        '        change = True
        '        e.Row(GridCols.FavSeq) = 0
        '        change = True
        '        e.Row(GridCols.FavShortcutKey) = ""
        '    End If
        'End If
    End Sub
End Class