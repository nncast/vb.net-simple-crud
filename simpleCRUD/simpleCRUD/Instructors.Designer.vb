<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructors
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtinstrid = New System.Windows.Forms.TextBox()
        Me.insview = New System.Windows.Forms.ListView()
        Me.instrid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.pnlinput.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlinput
        '
        Me.pnlinput.BackColor = System.Drawing.Color.White
        Me.pnlinput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlinput.Controls.Add(Me.Label4)
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.txtemail)
        Me.pnlinput.Controls.Add(Me.txtlname)
        Me.pnlinput.Controls.Add(Me.txtfname)
        Me.pnlinput.Location = New System.Drawing.Point(481, 120)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(390, 275)
        Me.pnlinput.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(20, 209)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(334, 30)
        Me.txtemail.TabIndex = 3
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(20, 125)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(334, 30)
        Me.txtlname.TabIndex = 2
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(20, 43)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(334, 30)
        Me.txtfname.TabIndex = 1
        '
        'txtinstrid
        '
        Me.txtinstrid.Enabled = False
        Me.txtinstrid.Location = New System.Drawing.Point(841, 34)
        Me.txtinstrid.Name = "txtinstrid"
        Me.txtinstrid.Size = New System.Drawing.Size(30, 30)
        Me.txtinstrid.TabIndex = 0
        Me.txtinstrid.Text = "ID"
        Me.txtinstrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtinstrid.Visible = False
        '
        'insview
        '
        Me.insview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.instrid, Me.fname, Me.lname, Me.email})
        Me.insview.FullRowSelect = True
        Me.insview.GridLines = True
        Me.insview.Location = New System.Drawing.Point(26, 120)
        Me.insview.Name = "insview"
        Me.insview.Size = New System.Drawing.Size(436, 370)
        Me.insview.TabIndex = 1
        Me.insview.UseCompatibleStateImageBehavior = False
        Me.insview.View = System.Windows.Forms.View.Details
        '
        'instrid
        '
        Me.instrid.Text = "ID"
        Me.instrid.Width = 40
        '
        'fname
        '
        Me.fname.Text = "First Name"
        Me.fname.Width = 120
        '
        'lname
        '
        Me.lname.Text = "Last Name"
        Me.lname.Width = 120
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.Width = 200
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(902, 92)
        Me.Panel2.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(215, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(479, 92)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "INSTRUCTORS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(902, 92)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Divot
        Me.RectangleShape2.Location = New System.Drawing.Point(-7, -4)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(923, 102)
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
        Me.RectangleShape3.Size = New System.Drawing.Size(215, 94)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(694, -1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(206, 94)
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.Location = New System.Drawing.Point(759, 406)
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
        Me.btncancel.Location = New System.Drawing.Point(759, 451)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(112, 39)
        Me.btncancel.TabIndex = 21
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
        Me.btndelete.Location = New System.Drawing.Point(481, 451)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(110, 39)
        Me.btndelete.TabIndex = 20
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
        Me.btnnew.Location = New System.Drawing.Point(481, 406)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(110, 39)
        Me.btnnew.TabIndex = 18
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
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
        Me.btnupdate.Location = New System.Drawing.Point(597, 406)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 39)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Instructors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(899, 525)
        Me.Controls.Add(Me.txtinstrid)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.insview)
        Me.Controls.Add(Me.pnlinput)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Instructors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructors"
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlinput As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtinstrid As System.Windows.Forms.TextBox
    Friend WithEvents insview As System.Windows.Forms.ListView
    Friend WithEvents instrid As System.Windows.Forms.ColumnHeader
    Friend WithEvents fname As System.Windows.Forms.ColumnHeader
    Friend WithEvents lname As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
