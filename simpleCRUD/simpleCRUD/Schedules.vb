Public Class Schedules

    Public adding As Boolean = False
    Public updating As Boolean = False
    Private cid As Integer = Nothing


    Private Sub Schedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

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
        cid = Nothing
        pnlinput.Enabled = True
        adding = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If cid = Nothing Then
            MsgBox("Select a schedule to update", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cmbdayofweek.Text.Trim = "" Then
            MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        If adding Then
            If MsgBox("Are you sure you want to add a new schedule?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("INSERT INTO schedules (dayofweek, timeslot) VALUES (@dayofweek, @timeslot)",
                            P("@dayofweek", cmbdayofweek.Text.Trim), P("@timeslot", dtptimeslot.Text)) Then
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
            If MsgBox("Are you sure you want to update schedule information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("UPDATE schedules SET dayofweek = @dayofweek, timeslot = @timeslot WHERE schedid = @id",
                            P("@dayofweek", cmbdayofweek.Text.Trim), P("@timeslot", dtptimeslot.Text), P("@id", cid)) Then
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

    Private Sub schedview_DoubleClick(sender As Object, e As EventArgs) Handles schedview.DoubleClick
        If adding Or updating Or schedview.SelectedItems.Count = 0 Then Exit Sub

        cid = CInt(schedview.SelectedItems(0).SubItems(0).Text)
        GetQuery("SELECT * FROM schedules WHERE schedid = @id", "schedules", P("@id", cid))
        If ds.Tables("schedules").Rows.Count = 0 Then Exit Sub

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
                If SetQuery("DELETE FROM schedules WHERE schedid = @id", P("@id", cid)) Then
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
            If MsgBox("Are you sure you want to cancel updating schedule information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                cid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new schedule information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
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
