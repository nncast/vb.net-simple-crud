Public Class Instructors

    Public adding As Boolean = False
    Public updating As Boolean = False
    Private cid As Integer = Nothing

    Private Sub Instructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

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

    Private Function validfields() As Boolean
        If txtfname.Text.Trim = "" Or txtlname.Text.Trim = "" Or txtemail.Text.Trim = "" Then
            MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Return False
        End If

        Return True
    End Function

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        cid = Nothing
        pnlinput.Enabled = True
        adding = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If cid = Nothing Then
            MsgBox("Select an instructor to update", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not validfields() Then Exit Sub

        If adding Then
            If MsgBox("Are you sure you want to add a new instructor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("INSERT INTO instructors (fname, lname, email) VALUES (@fname, @lname, @email)",
                            P("@fname", txtfname.Text.Trim), P("@lname", txtlname.Text.Trim), P("@email", txtemail.Text.Trim)) Then
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
            If MsgBox("Are you sure you want to update instructor information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("UPDATE instructors SET fname = @fname, lname = @lname, email = @email WHERE instrid = @id",
                            P("@fname", txtfname.Text.Trim), P("@lname", txtlname.Text.Trim), P("@email", txtemail.Text.Trim), P("@id", cid)) Then
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

    Private Sub insview_DoubleClick(sender As Object, e As EventArgs) Handles insview.DoubleClick
        If adding Or updating Or insview.SelectedItems.Count = 0 Then Exit Sub

        cid = CInt(insview.SelectedItems(0).SubItems(0).Text)
        GetQuery("SELECT * FROM instructors WHERE instrid = @id", "instructors", P("@id", cid))
        If ds.Tables("instructors").Rows.Count = 0 Then Exit Sub

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
                If SetQuery("DELETE FROM instructors WHERE instrid = @id", P("@id", cid)) Then
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
            If MsgBox("Are you sure you want to cancel updating instructor information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                cid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new instructor information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                adding = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                cid = Nothing
            End If
        Else
            cid = Nothing
            adding = False
            updating = False
            disablebuttons()
            clearfields()
            pnlinput.Enabled = False
        End If
    End Sub

End Class
