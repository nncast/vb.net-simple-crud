<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classrooms
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
        Me.classview = New System.Windows.Forms.ListView()
        Me.classid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bldgname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.roomnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.capacity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.equipment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlinput = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtequipment = New System.Windows.Forms.TextBox()
        Me.txtcapacity = New System.Windows.Forms.TextBox()
        Me.txtroomnum = New System.Windows.Forms.TextBox()
        Me.cmbbldgname = New System.Windows.Forms.ComboBox()
        Me.txtclassid = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.pnlinput.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'classview
        '
        Me.classview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.classid, Me.bldgname, Me.roomnum, Me.capacity, Me.equipment})
        Me.classview.FullRowSelect = True
        Me.classview.GridLines = True
        Me.classview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.classview.HoverSelection = True
        Me.classview.Location = New System.Drawing.Point(21, 123)
        Me.classview.Name = "classview"
        Me.classview.Size = New System.Drawing.Size(405, 331)
        Me.classview.TabIndex = 0
        Me.classview.UseCompatibleStateImageBehavior = False
        Me.classview.View = System.Windows.Forms.View.Details
        '
        'classid
        '
        Me.classid.Text = "ID"
        Me.classid.Width = 40
        '
        'bldgname
        '
        Me.bldgname.Text = "Building Name"
        Me.bldgname.Width = 136
        '
        'roomnum
        '
        Me.roomnum.Text = "Room number"
        Me.roomnum.Width = 135
        '
        'capacity
        '
        Me.capacity.Text = "Capacity"
        Me.capacity.Width = 90
        '
        'equipment
        '
        Me.equipment.Text = "Equipment"
        Me.equipment.Width = 200
        '
        'pnlinput
        '
        Me.pnlinput.BackColor = System.Drawing.Color.White
        Me.pnlinput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlinput.Controls.Add(Me.Label6)
        Me.pnlinput.Controls.Add(Me.Label4)
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.txtequipment)
        Me.pnlinput.Controls.Add(Me.txtcapacity)
        Me.pnlinput.Controls.Add(Me.txtroomnum)
        Me.pnlinput.Controls.Add(Me.cmbbldgname)
        Me.pnlinput.Location = New System.Drawing.Point(444, 123)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(476, 200)
        Me.pnlinput.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Equipment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Capacity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Room number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Building name:"
        '
        'txtequipment
        '
        Me.txtequipment.Location = New System.Drawing.Point(21, 133)
        Me.txtequipment.Name = "txtequipment"
        Me.txtequipment.Size = New System.Drawing.Size(429, 30)
        Me.txtequipment.TabIndex = 4
        '
        'txtcapacity
        '
        Me.txtcapacity.Location = New System.Drawing.Point(350, 50)
        Me.txtcapacity.Name = "txtcapacity"
        Me.txtcapacity.Size = New System.Drawing.Size(100, 30)
        Me.txtcapacity.TabIndex = 3
        '
        'txtroomnum
        '
        Me.txtroomnum.Location = New System.Drawing.Point(187, 50)
        Me.txtroomnum.Name = "txtroomnum"
        Me.txtroomnum.Size = New System.Drawing.Size(135, 30)
        Me.txtroomnum.TabIndex = 2
        '
        'cmbbldgname
        '
        Me.cmbbldgname.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbbldgname.FormattingEnabled = True
        Me.cmbbldgname.Items.AddRange(New Object() {"Building A", "Building B", "Building C", "Building D", "Building E"})
        Me.cmbbldgname.Location = New System.Drawing.Point(19, 49)
        Me.cmbbldgname.Name = "cmbbldgname"
        Me.cmbbldgname.Size = New System.Drawing.Size(141, 31)
        Me.cmbbldgname.TabIndex = 1
        '
        'txtclassid
        '
        Me.txtclassid.Enabled = False
        Me.txtclassid.Location = New System.Drawing.Point(890, 33)
        Me.txtclassid.Name = "txtclassid"
        Me.txtclassid.ShortcutsEnabled = False
        Me.txtclassid.Size = New System.Drawing.Size(30, 30)
        Me.txtclassid.TabIndex = 0
        Me.txtclassid.Text = "ID"
        Me.txtclassid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtclassid.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtclassid)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ShapeContainer3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 92)
        Me.Panel2.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(251, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(462, 92)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CLASSROOMS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(954, 92)
        Me.ShapeContainer3.TabIndex = 8
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.DottedGrid
        Me.RectangleShape2.Location = New System.Drawing.Point(1, 1)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(949, 102)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape3.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(231, 94)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(724, 1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(231, 94)
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.Location = New System.Drawing.Point(808, 333)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(112, 40)
        Me.btnsave.TabIndex = 27
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
        Me.btncancel.Location = New System.Drawing.Point(808, 378)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(112, 40)
        Me.btncancel.TabIndex = 26
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnupdate.FlatAppearance.BorderSize = 0
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnupdate.Location = New System.Drawing.Point(560, 333)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 40)
        Me.btnupdate.TabIndex = 24
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.Location = New System.Drawing.Point(444, 378)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(110, 40)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnnew.FlatAppearance.BorderSize = 0
        Me.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnew.Location = New System.Drawing.Point(444, 333)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(110, 40)
        Me.btnnew.TabIndex = 23
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'Classrooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(944, 483)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlinput)
        Me.Controls.Add(Me.classview)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Classrooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classrooms"
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents classview As System.Windows.Forms.ListView
    Friend WithEvents pnlinput As System.Windows.Forms.Panel
    Friend WithEvents txtcapacity As System.Windows.Forms.TextBox
    Friend WithEvents txtroomnum As System.Windows.Forms.TextBox
    Friend WithEvents txtclassid As System.Windows.Forms.TextBox
    Friend WithEvents txtequipment As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents classid As System.Windows.Forms.ColumnHeader
    Friend WithEvents bldgname As System.Windows.Forms.ColumnHeader
    Friend WithEvents roomnum As System.Windows.Forms.ColumnHeader
    Friend WithEvents capacity As System.Windows.Forms.ColumnHeader
    Friend WithEvents equipment As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents cmbbldgname As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
