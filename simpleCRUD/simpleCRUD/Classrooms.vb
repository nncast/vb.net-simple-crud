Public Class Classrooms
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private cid As Integer = Nothing

    Private Sub Classrooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dbstudent", "3306", "root", "")

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

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        adding = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If adding Then
            If cmbbldgname.Text = Nothing Or txtroomnum.Text = Nothing Or txtcapacity.Text = Nothing Or txtequipment.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add a new classroom?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO classrooms(classid, bldgname, roomnum, capacity, equipment) VALUES('" & txtclassid.Text.Trim & "', '" & cmbbldgname.Text.Trim & "', '" & txtroomnum.Text.Trim & "', '" & txtcapacity.Text.Trim & "', '" & txtequipment.Text.Trim & "')")

                    fill()
                    disablebuttons()
                    clearfields()
                    pnlinput.Enabled = True
                    adding = False
                    updating = False
                    MsgBox("Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                End If
            End If
        ElseIf updating Then
            If MsgBox("Are you sure you want to update classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE classrooms SET bldgname='" & cmbbldgname.Text.Trim & "', roomnum='" & txtroomnum.Text.Trim & "', capacity='" & txtcapacity.Text.Trim & "', equipment='" & txtequipment.Text.Trim & "' WHERE classid='" & cid & "'")

                fill()
                disablebuttons()
                clearfields()
                pnlinput.Enabled = True
                adding = False
                updating = False
                MsgBox("Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            End If
        End If
    End Sub

    Private Sub classview_DoubleClick(sender As Object, e As EventArgs) Handles classview.DoubleClick
        cid = classview.FocusedItem.SubItems(0).Text
        GetQuery("SELECT * FROM classrooms WHERE classid='" & cid & "'", "classrooms")

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
                SetQuery("DELETE FROM classrooms WHERE classid='" & cid & "'")

                fill()
                clearfields()
                id = Nothing
                MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
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
                id = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                adding = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                id = Nothing
            End If
        Else
            adding = False
            updating = False
            disablebuttons()
            clearfields()
            pnlinput.Enabled = False
            id = Nothing
        End If
    End Sub

End Class
