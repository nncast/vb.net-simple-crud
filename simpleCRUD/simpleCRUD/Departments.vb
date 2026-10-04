Public Class Departments

    Public adding As Boolean = False
    Public updating As Boolean = False
    Private cid As Integer = Nothing

    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

        fill()
        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        GetQuery("SELECT * FROM departments", "departments")
        deptview.Items.Clear()
        For i = 0 To ds.Tables("departments").Rows.Count - 1
            deptview.Items.Add(ds.Tables("departments").Rows(i).Item("deptid").ToString)
            With deptview.Items(i).SubItems
                .Add(ds.Tables("departments").Rows(i).Item("deptname").ToString)
                .Add(ds.Tables("departments").Rows(i).Item("depthead").ToString)
                .Add(ds.Tables("departments").Rows(i).Item("phonenum").ToString)
                .Add(ds.Tables("departments").Rows(i).Item("officelocation").ToString)
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
        txtdeptid.Text = Nothing
        txtdeptname.Text = Nothing
        txtdepthead.Text = Nothing
        txtphonenum.Text = Nothing
        cmbofficelocation.Text = Nothing
    End Sub

    Private Function validfields() As Boolean
        ' An empty masked box still returns its "-" literal, so check MaskCompleted.
        If txtdeptname.Text.Trim = "" Or txtdepthead.Text.Trim = "" Or cmbofficelocation.Text.Trim = "" Or Not txtphonenum.MaskCompleted Then
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
            MsgBox("Select a department to update", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not validfields() Then Exit Sub

        If adding Then
            If MsgBox("Are you sure you want to add a new department?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("INSERT INTO departments (deptname, depthead, phonenum, officelocation) VALUES (@deptname, @depthead, @phonenum, @officelocation)",
                            P("@deptname", txtdeptname.Text.Trim), P("@depthead", txtdepthead.Text.Trim),
                            P("@phonenum", txtphonenum.Text.Trim), P("@officelocation", cmbofficelocation.Text.Trim)) Then
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
            If MsgBox("Are you sure you want to update department information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("UPDATE departments SET deptname = @deptname, depthead = @depthead, phonenum = @phonenum, officelocation = @officelocation WHERE deptid = @id",
                            P("@deptname", txtdeptname.Text.Trim), P("@depthead", txtdepthead.Text.Trim),
                            P("@phonenum", txtphonenum.Text.Trim), P("@officelocation", cmbofficelocation.Text.Trim), P("@id", cid)) Then
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

    Private Sub deptview_DoubleClick(sender As Object, e As EventArgs) Handles deptview.DoubleClick
        If adding Or updating Or deptview.SelectedItems.Count = 0 Then Exit Sub

        cid = CInt(deptview.SelectedItems(0).SubItems(0).Text)
        GetQuery("SELECT * FROM departments WHERE deptid = @id", "departments", P("@id", cid))
        If ds.Tables("departments").Rows.Count = 0 Then Exit Sub

        txtdeptid.Text = ds.Tables("departments").Rows(0).Item("deptid").ToString
        txtdeptname.Text = ds.Tables("departments").Rows(0).Item("deptname").ToString
        txtdepthead.Text = ds.Tables("departments").Rows(0).Item("depthead").ToString
        txtphonenum.Text = ds.Tables("departments").Rows(0).Item("phonenum").ToString
        cmbofficelocation.Text = ds.Tables("departments").Rows(0).Item("officelocation").ToString

        btnnew.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btndelete_Click_1(sender As Object, e As EventArgs) Handles btndelete.Click
        If cid = Nothing Then
            MsgBox("Select department to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                If SetQuery("DELETE FROM departments WHERE deptid = @id", P("@id", cid)) Then
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
            If MsgBox("Are you sure you want to cancel updating department information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                cid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new department information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
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
