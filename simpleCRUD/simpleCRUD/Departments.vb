Public Class Departments

    Public adding As Boolean = False
    Public updating As Boolean = False
    Public id As Integer = Nothing
    Private cid As Integer = Nothing

    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "dbstudent", "3306", "root", "")

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

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        If adding Then
            If txtdeptname.Text = Nothing Or txtdepthead.Text = Nothing Or txtphonenum.Text = Nothing Or cmbofficelocation.Text = Nothing Then
                MsgBox("All Fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Else
                If MsgBox("Are you sure you want to add a new department?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO departments (deptid, deptname, depthead, phonenum, officelocation) VALUES('" & txtdeptid.Text.Trim & "', '" & txtdeptname.Text.Trim & "', '" & txtdepthead.Text.Trim & "', '" & txtphonenum.Text.Trim & "', '" & cmbofficelocation.Text.Trim & "')")

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
            If MsgBox("Are you sure you want to update department information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("UPDATE departments SET deptname='" & txtdeptname.Text.Trim & "', depthead='" & txtdepthead.Text.Trim & "', phonenum='" & txtphonenum.Text.Trim & "', officelocation='" & cmbofficelocation.Text.Trim & "' WHERE deptid='" & cid & "'")

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

    Private Sub deptview_DoubleClick(sender As Object, e As EventArgs) Handles deptview.DoubleClick
        cid = deptview.FocusedItem.SubItems(0).Text
        GetQuery("SELECT * FROM departments WHERE deptid='" & cid & "'", "departments")

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
                SetQuery("DELETE FROM departments WHERE deptid='" & cid & "'")

                fill()
                clearfields()
                id = Nothing
                MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
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
                id = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new department information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
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
