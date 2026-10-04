Public Class Courses

    Public adding As Boolean = False
    Public updating As Boolean = False
    Private cid As Integer = Nothing

    Private Sub Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

        fill()
        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub


    Public Sub fill()
        GetQuery("SELECT * FROM courses", "courses")
        courseview.Items.Clear()
        For i = 0 To ds.Tables("courses").Rows.Count - 1
            courseview.Items.Add(ds.Tables("courses").Rows(i).Item("courseid").ToString)
            With courseview.Items(i).SubItems
                .Add(ds.Tables("courses").Rows(i).Item("coursename").ToString)
                .Add(ds.Tables("courses").Rows(i).Item("credits").ToString)
                .Add(ds.Tables("courses").Rows(i).Item("coursetype").ToString)
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
        txtcourseid.Text = Nothing
        txtcoursename.Text = Nothing
        numcredits.Value = numcredits.Minimum
        cmbcoursetype.Text = Nothing
    End Sub

    Private Function validfields() As Boolean
        If txtcoursename.Text.Trim = "" Or cmbcoursetype.Text.Trim = "" Then
            MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Return False
        End If

        If numcredits.Value <= 0 Then
            MsgBox("Credits must be greater than zero.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
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
            MsgBox("Select a course to update", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not validfields() Then Exit Sub

        If adding Then
            If MsgBox("Are you sure you want to add a new course?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("INSERT INTO courses (coursename, credits, coursetype) VALUES (@coursename, @credits, @coursetype)",
                            P("@coursename", txtcoursename.Text.Trim), P("@credits", CInt(numcredits.Value)), P("@coursetype", cmbcoursetype.Text.Trim)) Then
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
            If MsgBox("Are you sure you want to update course information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("UPDATE courses SET coursename = @coursename, credits = @credits, coursetype = @coursetype WHERE courseid = @id",
                            P("@coursename", txtcoursename.Text.Trim), P("@credits", CInt(numcredits.Value)), P("@coursetype", cmbcoursetype.Text.Trim), P("@id", cid)) Then
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

    Private Sub courseview_DoubleClick(sender As Object, e As EventArgs) Handles courseview.DoubleClick
        If adding Or updating Or courseview.SelectedItems.Count = 0 Then Exit Sub

        cid = CInt(courseview.SelectedItems(0).SubItems(0).Text)
        GetQuery("SELECT * FROM courses WHERE courseid = @id", "courses", P("@id", cid))
        If ds.Tables("courses").Rows.Count = 0 Then Exit Sub

        txtcourseid.Text = ds.Tables("courses").Rows(0).Item("courseid").ToString
        txtcoursename.Text = ds.Tables("courses").Rows(0).Item("coursename").ToString
        numcredits.Text = ds.Tables("courses").Rows(0).Item("credits").ToString
        cmbcoursetype.Text = ds.Tables("courses").Rows(0).Item("coursetype").ToString

        btnnew.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If cid = Nothing Then
            MsgBox("Select course to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("DELETE FROM courses WHERE courseid = @id", P("@id", cid)) Then
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
            If MsgBox("Are you sure you want to cancel updating course information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                cid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new course information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
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
