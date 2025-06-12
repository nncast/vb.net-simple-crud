<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.deptview = New System.Windows.Forms.ListView()
        Me.deptid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deptname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.depthead = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.phonenum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.officelocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtdeptid = New System.Windows.Forms.TextBox()
        Me.txtdeptname = New System.Windows.Forms.TextBox()
        Me.txtdepthead = New System.Windows.Forms.TextBox()
        Me.txtphonenum = New System.Windows.Forms.MaskedTextBox()
        Me.pnlinput = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbofficelocation = New System.Windows.Forms.ComboBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.pnlinput.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'deptview
        '
        Me.deptview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.deptview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.deptid, Me.deptname, Me.depthead, Me.phonenum, Me.officelocation})
        Me.deptview.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deptview.FullRowSelect = True
        Me.deptview.GridLines = True
        Me.deptview.Location = New System.Drawing.Point(26, 387)
        Me.deptview.Name = "deptview"
        Me.deptview.Size = New System.Drawing.Size(677, 182)
        Me.deptview.TabIndex = 0
        Me.deptview.UseCompatibleStateImageBehavior = False
        Me.deptview.View = System.Windows.Forms.View.Details
        '
        'deptid
        '
        Me.deptid.Text = "ID"
        Me.deptid.Width = 40
        '
        'deptname
        '
        Me.deptname.Text = "Department Name"
        Me.deptname.Width = 173
        '
        'depthead
        '
        Me.depthead.Text = "Deparment Head"
        Me.depthead.Width = 164
        '
        'phonenum
        '
        Me.phonenum.Text = "Phone Number"
        Me.phonenum.Width = 147
        '
        'officelocation
        '
        Me.officelocation.Text = "Office Location"
        Me.officelocation.Width = 150
        '
        'txtdeptid
        '
        Me.txtdeptid.Enabled = False
        Me.txtdeptid.Location = New System.Drawing.Point(673, 32)
        Me.txtdeptid.Name = "txtdeptid"
        Me.txtdeptid.Size = New System.Drawing.Size(30, 30)
        Me.txtdeptid.TabIndex = 1
        Me.txtdeptid.Text = "ID"
        Me.txtdeptid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtdeptid.Visible = False
        '
        'txtdeptname
        '
        Me.txtdeptname.Location = New System.Drawing.Point(24, 47)
        Me.txtdeptname.Name = "txtdeptname"
        Me.txtdeptname.Size = New System.Drawing.Size(290, 30)
        Me.txtdeptname.TabIndex = 2
        '
        'txtdepthead
        '
        Me.txtdepthead.Location = New System.Drawing.Point(367, 47)
        Me.txtdepthead.Name = "txtdepthead"
        Me.txtdepthead.Size = New System.Drawing.Size(282, 30)
        Me.txtdepthead.TabIndex = 3
        '
        'txtphonenum
        '
        Me.txtphonenum.Location = New System.Drawing.Point(24, 118)
        Me.txtphonenum.Mask = "000-0000"
        Me.txtphonenum.Name = "txtphonenum"
        Me.txtphonenum.Size = New System.Drawing.Size(91, 30)
        Me.txtphonenum.TabIndex = 4
        '
        'pnlinput
        '
        Me.pnlinput.BackColor = System.Drawing.Color.White
        Me.pnlinput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlinput.Controls.Add(Me.Label5)
        Me.pnlinput.Controls.Add(Me.Label4)
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.cmbofficelocation)
        Me.pnlinput.Controls.Add(Me.txtdeptname)
        Me.pnlinput.Controls.Add(Me.txtphonenum)
        Me.pnlinput.Controls.Add(Me.txtdepthead)
        Me.pnlinput.Location = New System.Drawing.Point(26, 113)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(677, 190)
        Me.pnlinput.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Office Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Department Head:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Department Name:"
        '
        'cmbofficelocation
        '
        Me.cmbofficelocation.FormattingEnabled = True
        Me.cmbofficelocation.Items.AddRange(New Object() {"Building A", "Building B", "Building C", "Building D"})
        Me.cmbofficelocation.Location = New System.Drawing.Point(367, 117)
        Me.cmbofficelocation.Name = "cmbofficelocation"
        Me.cmbofficelocation.Size = New System.Drawing.Size(133, 31)
        Me.cmbofficelocation.TabIndex = 5
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(624, -4)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(108, 95)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Shingle
        Me.RectangleShape2.Location = New System.Drawing.Point(-7, -19)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(760, 127)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtdeptid)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 91)
        Me.Panel2.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(122, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(502, 91)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "DEPARTMENTS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(741, 91)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape3.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(0, -2)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(114, 95)
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.Location = New System.Drawing.Point(591, 327)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(112, 39)
        Me.btnsave.TabIndex = 22
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancel.Location = New System.Drawing.Point(473, 327)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(112, 39)
        Me.btncancel.TabIndex = 21
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(26, 327)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(112, 39)
        Me.btnnew.TabIndex = 23
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(144, 327)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(112, 39)
        Me.btnupdate.TabIndex = 24
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(262, 327)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(112, 39)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Departments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(732, 581)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlinput)
        Me.Controls.Add(Me.deptview)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Departments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departments"
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deptview As System.Windows.Forms.ListView
    Friend WithEvents txtdeptid As System.Windows.Forms.TextBox
    Friend WithEvents txtdeptname As System.Windows.Forms.TextBox
    Friend WithEvents txtdepthead As System.Windows.Forms.TextBox
    Friend WithEvents txtphonenum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents deptid As System.Windows.Forms.ColumnHeader
    Friend WithEvents deptname As System.Windows.Forms.ColumnHeader
    Friend WithEvents depthead As System.Windows.Forms.ColumnHeader
    Friend WithEvents phonenum As System.Windows.Forms.ColumnHeader
    Friend WithEvents officelocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlinput As System.Windows.Forms.Panel
    Friend WithEvents cmbofficelocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
