<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courses
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
        Me.pnlinput = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcoursename = New System.Windows.Forms.TextBox()
        Me.numcredits = New System.Windows.Forms.NumericUpDown()
        Me.cmbcoursetype = New System.Windows.Forms.ComboBox()
        Me.txtcourseid = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.courseview = New System.Windows.Forms.ListView()
        Me.courseid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.coursename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.credits = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.coursetype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.pnlinput.SuspendLayout()
        CType(Me.numcredits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlinput
        '
        Me.pnlinput.BackColor = System.Drawing.Color.White
        Me.pnlinput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.Label1)
        Me.pnlinput.Controls.Add(Me.txtcoursename)
        Me.pnlinput.Controls.Add(Me.numcredits)
        Me.pnlinput.Controls.Add(Me.cmbcoursetype)
        Me.pnlinput.Location = New System.Drawing.Point(433, 121)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(385, 205)
        Me.pnlinput.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(214, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Course Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Credits:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Course Name:"
        '
        'txtcoursename
        '
        Me.txtcoursename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcoursename.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtcoursename.Location = New System.Drawing.Point(24, 50)
        Me.txtcoursename.Name = "txtcoursename"
        Me.txtcoursename.Size = New System.Drawing.Size(336, 30)
        Me.txtcoursename.TabIndex = 7
        '
        'numcredits
        '
        Me.numcredits.Location = New System.Drawing.Point(24, 135)
        Me.numcredits.Name = "numcredits"
        Me.numcredits.Size = New System.Drawing.Size(81, 30)
        Me.numcredits.TabIndex = 8
        '
        'cmbcoursetype
        '
        Me.cmbcoursetype.FormattingEnabled = True
        Me.cmbcoursetype.Items.AddRange(New Object() {"Core", "Elective"})
        Me.cmbcoursetype.Location = New System.Drawing.Point(218, 135)
        Me.cmbcoursetype.Name = "cmbcoursetype"
        Me.cmbcoursetype.Size = New System.Drawing.Size(142, 31)
        Me.cmbcoursetype.TabIndex = 9
        '
        'txtcourseid
        '
        Me.txtcourseid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcourseid.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtcourseid.Enabled = False
        Me.txtcourseid.Location = New System.Drawing.Point(788, 34)
        Me.txtcourseid.Name = "txtcourseid"
        Me.txtcourseid.Size = New System.Drawing.Size(30, 30)
        Me.txtcourseid.TabIndex = 18
        Me.txtcourseid.Text = "ID"
        Me.txtcourseid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcourseid.Visible = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.Location = New System.Drawing.Point(706, 337)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(112, 39)
        Me.btnsave.TabIndex = 17
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
        Me.btncancel.Location = New System.Drawing.Point(706, 382)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(112, 39)
        Me.btncancel.TabIndex = 16
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
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
        Me.btndelete.Location = New System.Drawing.Point(433, 382)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(110, 39)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
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
        Me.btnupdate.Location = New System.Drawing.Point(549, 337)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 39)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
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
        Me.btnnew.Location = New System.Drawing.Point(433, 337)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(110, 39)
        Me.btnnew.TabIndex = 13
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'courseview
        '
        Me.courseview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.courseid, Me.coursename, Me.credits, Me.coursetype})
        Me.courseview.FullRowSelect = True
        Me.courseview.GridLines = True
        Me.courseview.Location = New System.Drawing.Point(25, 121)
        Me.courseview.Name = "courseview"
        Me.courseview.Size = New System.Drawing.Size(387, 300)
        Me.courseview.TabIndex = 6
        Me.courseview.UseCompatibleStateImageBehavior = False
        Me.courseview.View = System.Windows.Forms.View.Details
        '
        'courseid
        '
        Me.courseid.Text = "ID"
        Me.courseid.Width = 40
        '
        'coursename
        '
        Me.coursename.Text = "Course Name"
        Me.coursename.Width = 170
        '
        'credits
        '
        Me.credits.Text = "Credits"
        Me.credits.Width = 73
        '
        'coursetype
        '
        Me.coursetype.Text = "Type"
        Me.coursetype.Width = 100
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(258, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(331, 94)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "COURSES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtcourseid)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 92)
        Me.Panel2.TabIndex = 19
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(846, 92)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.DiagonalBrick
        Me.RectangleShape2.Location = New System.Drawing.Point(-15, -9)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(861, 106)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape3.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(-1, -1)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(256, 93)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(587, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(256, 93)
        '
        'Courses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(843, 452)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.courseview)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.pnlinput)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnupdate)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Courses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Courses"
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        CType(Me.numcredits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlinput As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcoursename As System.Windows.Forms.TextBox
    Friend WithEvents numcredits As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbcoursetype As System.Windows.Forms.ComboBox
    Friend WithEvents courseview As System.Windows.Forms.ListView
    Friend WithEvents courseid As System.Windows.Forms.ColumnHeader
    Friend WithEvents coursename As System.Windows.Forms.ColumnHeader
    Friend WithEvents credits As System.Windows.Forms.ColumnHeader
    Friend WithEvents coursetype As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents txtcourseid As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
