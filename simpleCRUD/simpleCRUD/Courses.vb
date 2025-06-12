Public Class Courses

    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private cid As Integer = Nothing

    Private Sub Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dbstudent", "3306", "root", "")

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
        numcredits.Text = Nothing
        cmbcoursetype.Text = Nothing
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
            If txtcoursename.Text = Nothing Or numcredits.Text = Nothing Or cmbcoursetype.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add a new course?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO courses (courseid, coursename, credits, coursetype) VALUES('" & txtcourseid.Text.Trim & "', '" & txtcoursename.Text.Trim & "', '" & numcredits.Text.Trim & "', '" & cmbcoursetype.Text.Trim & "')")

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
            If MsgBox("Are you sure you want to update student information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE courses SET coursename='" & txtcoursename.Text.Trim & "', credits='" & numcredits.Text.Trim & "', coursetype='" & cmbcoursetype.Text.Trim & "' WHERE courseid='" & cid & "'")

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

    Private Sub courseview_DoubleClick(sender As Object, e As EventArgs) Handles courseview.DoubleClick
        cid = courseview.FocusedItem.SubItems(0).Text
        GetQuery("SELECT * FROM courses WHERE courseid='" & cid & "'", "courses")

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
                SetQuery("DELETE FROM courses WHERE courseid='" & cid & "'")
                fill()
                clearfields()
                id = Nothing
                MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
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
                id = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new student information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
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
