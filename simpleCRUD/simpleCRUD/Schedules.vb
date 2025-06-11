Public Class Schedules

    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private cid As Integer = Nothing


    Private Sub Schedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dbstudent", "3306", "root", "")

        fill()
        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        GetQuery("SELECT * FROM schedules", "schedules")
        schedview.Items.Clear()
        For i = 0 To ds.Tables("schedules").Rows.Count - 1
            schedview.Items.Add(ds.Tables("schedules").Rows(i).Item("schedid").ToString)
            With schedview.Items(i).SubItems
                .Add(ds.Tables("schedules").Rows(i).Item("dayofweek").ToString)
                .Add(ds.Tables("schedules").Rows(i).Item("timeslot").ToString)
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
        txtschedid.Text = Nothing
        cmbdayofweek.Text = Nothing
        dtptimeslot.Value = DateTime.Now
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
            If cmbdayofweek.Text = Nothing Or dtptimeslot.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add a new schedule?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO schedules (dayofweek, timeslot) VALUES('" & cmbdayofweek.Text.Trim & "', '" & dtptimeslot.Text & "')")

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
            If MsgBox("Are you sure you want to update schedule information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE schedules SET dayofweek='" & cmbdayofweek.Text.Trim & "', timeslot='" & dtptimeslot.Text & "' WHERE schedid='" & cid & "'")

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

    Private Sub schedview_DoubleClick(sender As Object, e As EventArgs) Handles schedview.DoubleClick
        cid = schedview.FocusedItem.SubItems(0).Text
        GetQuery("SELECT * FROM schedules WHERE schedid='" & cid & "'", "schedules")

        txtschedid.Text = ds.Tables("schedules").Rows(0).Item("schedid").ToString
        cmbdayofweek.Text = ds.Tables("schedules").Rows(0).Item("dayofweek").ToString
        dtptimeslot.Text = ds.Tables("schedules").Rows(0).Item("timeslot").ToString

        btnnew.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If cid = Nothing Then
            MsgBox("Select schedule to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("DELETE FROM schedules WHERE schedid='" & cid & "'")
                fill()
                clearfields()
                schedid = Nothing
                MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If updating Then
            If MsgBox("Are you sure you want to cancel updating schedule information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                schedid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new schedule information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                adding = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                schedid = Nothing
            End If
        Else
            schedid = Nothing
            adding = False
            updating = False
            disablebuttons()
            clearfields()
            pnlinput.Enabled = False
        End If
    End Sub

End Class
