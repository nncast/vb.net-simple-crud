Public Class Instructors

    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private cid As Integer = Nothing

    Private Sub Instructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dbstudent", "3306", "root", "")

        fill()
        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        GetQuery("SELECT * FROM instructors", "instructors")
        insview.Items.Clear()
        For i = 0 To ds.Tables("instructors").Rows.Count - 1
            insview.Items.Add(ds.Tables("instructors").Rows(i).Item("instrid").ToString)
            With insview.Items(i).SubItems
                .Add(ds.Tables("instructors").Rows(i).Item("fname").ToString)
                .Add(ds.Tables("instructors").Rows(i).Item("lname").ToString)
                .Add(ds.Tables("instructors").Rows(i).Item("email").ToString)
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
        txtinstrid.Text = Nothing
        txtfname.Text = Nothing
        txtlname.Text = Nothing
        txtemail.Text = Nothing
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        pnlinput.Enabled = True
        adding = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If adding Then
            If txtfname.Text = Nothing Or txtlname.Text = Nothing Or txtemail.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add a new instructor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO instructors (instrid, fname, lname, email) VALUES('" & txtinstrid.Text.Trim & "', '" & txtfname.Text.Trim & "', '" & txtlname.Text.Trim & "', '" & txtemail.Text.Trim & "')")

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
            If MsgBox("Are you sure you want to update instructor information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE instructors SET fname='" & txtfname.Text.Trim & "', lname='" & txtlname.Text.Trim & "', email='" & txtemail.Text.Trim & "' WHERE instrid='" & cid & "'")

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

    Private Sub insview_DoubleClick(sender As Object, e As EventArgs) Handles insview.DoubleClick
        cid = insview.FocusedItem.SubItems(0).Text
        GetQuery("SELECT * FROM instructors WHERE instrid='" & cid & "'", "instructors")

        txtinstrid.Text = ds.Tables("instructors").Rows(0).Item("instrid").ToString
        txtfname.Text = ds.Tables("instructors").Rows(0).Item("fname").ToString
        txtlname.Text = ds.Tables("instructors").Rows(0).Item("lname").ToString
        txtemail.Text = ds.Tables("instructors").Rows(0).Item("email").ToString

        btnnew.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If cid = Nothing Then
            MsgBox("Select instructor to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("DELETE FROM instructors WHERE instrid='" & cid & "'")
                fill()
                clearfields()
                id = Nothing
                MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If updating Then
            If MsgBox("Are you sure you want to cancel updating instructor information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                id = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new instructor information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                adding = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                id = Nothing
            End If
        Else
            id = Nothing
            adding = False
            updating = False
            disablebuttons()
            clearfields()
            pnlinput.Enabled = False
        End If
    End Sub

End Class
