Public Class Classrooms
    Public adding As Boolean = False
    Public updating As Boolean = False
    Private cid As Integer = Nothing

    Private Sub Classrooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

        fill()
        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        GetQuery("SELECT * FROM classrooms", "classrooms")
        classview.Items.Clear()
        For i = 0 To ds.Tables("classrooms").Rows.Count - 1
            classview.Items.Add(ds.Tables("classrooms").Rows(i).Item("classid").ToString)
            With classview.Items(i).SubItems
                .Add(ds.Tables("classrooms").Rows(i).Item("bldgname").ToString)
                .Add(ds.Tables("classrooms").Rows(i).Item("roomnum").ToString)
                .Add(ds.Tables("classrooms").Rows(i).Item("capacity").ToString)
                .Add(ds.Tables("classrooms").Rows(i).Item("equipment").ToString)
            End With
        Next
    End Sub

    Public Sub enablebuttons()
        btnnew.Enabled = 0
        btnupdate.Enabled = 0
        btndelete.Enabled = 0
        btncancel.Enabled = 1
        btnsave.Enabled = 1
    End Sub

    Public Sub disablebuttons()
        btnnew.Enabled = 1
        btnupdate.Enabled = 1
        btndelete.Enabled = 1
        btncancel.Enabled = 1
        btnsave.Enabled = 0
    End Sub

    Public Sub clearfields()
        txtclassid.Text = Nothing
        cmbbldgname.Text = Nothing
        txtroomnum.Text = Nothing
        txtcapacity.Text = Nothing
        txtequipment.Text = Nothing
    End Sub

    Private Function validfields() As Boolean
        If cmbbldgname.Text.Trim = "" Or txtroomnum.Text.Trim = "" Or txtcapacity.Text.Trim = "" Or txtequipment.Text.Trim = "" Then
            MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Return False
        End If

        Dim capacity As Integer
        If Not Integer.TryParse(txtcapacity.Text.Trim, capacity) OrElse capacity <= 0 Then
            MsgBox("Capacity must be a whole number greater than zero.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Return False
        End If

        Return True
    End Function

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        cid = Nothing
        adding = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If cid = Nothing Then
            MsgBox("Select a classroom to update", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not validfields() Then Exit Sub

        If adding Then
            If MsgBox("Are you sure you want to add a new classroom?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("INSERT INTO classrooms (bldgname, roomnum, capacity, equipment) VALUES (@bldgname, @roomnum, @capacity, @equipment)",
                            P("@bldgname", cmbbldgname.Text.Trim), P("@roomnum", txtroomnum.Text.Trim),
                            P("@capacity", CInt(txtcapacity.Text.Trim)), P("@equipment", txtequipment.Text.Trim)) Then
                    fill()
                    disablebuttons()
                    clearfields()
                    pnlinput.Enabled = False
                    adding = False
                    updating = False
                    MsgBox("Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                End If
            End If
        ElseIf updating Then
            If MsgBox("Are you sure you want to update classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("UPDATE classrooms SET bldgname = @bldgname, roomnum = @roomnum, capacity = @capacity, equipment = @equipment WHERE classid = @id",
                            P("@bldgname", cmbbldgname.Text.Trim), P("@roomnum", txtroomnum.Text.Trim),
                            P("@capacity", CInt(txtcapacity.Text.Trim)), P("@equipment", txtequipment.Text.Trim), P("@id", cid)) Then
                    fill()
                    disablebuttons()
                    clearfields()
                    pnlinput.Enabled = False
                    adding = False
                    updating = False
                    cid = Nothing
                    MsgBox("Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                End If
            End If
        End If
    End Sub

    Private Sub classview_DoubleClick(sender As Object, e As EventArgs) Handles classview.DoubleClick
        If adding Or updating Or classview.SelectedItems.Count = 0 Then Exit Sub

        cid = CInt(classview.SelectedItems(0).SubItems(0).Text)
        GetQuery("SELECT * FROM classrooms WHERE classid = @id", "classrooms", P("@id", cid))
        If ds.Tables("classrooms").Rows.Count = 0 Then Exit Sub

        txtclassid.Text = ds.Tables("classrooms").Rows(0).Item("classid").ToString
        cmbbldgname.Text = ds.Tables("classrooms").Rows(0).Item("bldgname").ToString
        txtroomnum.Text = ds.Tables("classrooms").Rows(0).Item("roomnum").ToString
        txtcapacity.Text = ds.Tables("classrooms").Rows(0).Item("capacity").ToString
        txtequipment.Text = ds.Tables("classrooms").Rows(0).Item("equipment").ToString

        btnnew.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If cid = Nothing Then
            MsgBox("Select classroom to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("DELETE FROM classrooms WHERE classid = @id", P("@id", cid)) Then
                    fill()
                    clearfields()
                    cid = Nothing
                    disablebuttons()
                    MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                End If
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If updating Then
            If MsgBox("Are you sure you want to cancel updating classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                cid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                adding = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                cid = Nothing
            End If
        Else
            adding = False
            updating = False
            disablebuttons()
            clearfields()
            pnlinput.Enabled = False
            cid = Nothing
        End If
    End Sub

End Class
