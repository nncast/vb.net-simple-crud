<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedules
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
        Me.dtptimeslot = New System.Windows.Forms.DateTimePicker()
        Me.cmbdayofweek = New System.Windows.Forms.ComboBox()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtschedid = New System.Windows.Forms.TextBox()
        Me.schedview = New System.Windows.Forms.ListView()
        Me.schedid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.pnlinput.SuspendLayout()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlinput
        '
        Me.pnlinput.BackColor = System.Drawing.Color.White
        Me.pnlinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.dtptimeslot)
        Me.pnlinput.Controls.Add(Me.cmbdayofweek)
        Me.pnlinput.Location = New System.Drawing.Point(415, 118)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(374, 128)
        Me.pnlinput.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time Slots:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Day of Week:"
        '
        'dtptimeslot
        '
        Me.dtptimeslot.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtptimeslot.Location = New System.Drawing.Point(198, 50)
        Me.dtptimeslot.Name = "dtptimeslot"
        Me.dtptimeslot.ShowUpDown = True
        Me.dtptimeslot.Size = New System.Drawing.Size(154, 30)
        Me.dtptimeslot.TabIndex = 2
        Me.dtptimeslot.Value = New Date(2024, 11, 7, 18, 6, 0, 0)
        '
        'cmbdayofweek
        '
        Me.cmbdayofweek.FormattingEnabled = True
        Me.cmbdayofweek.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cmbdayofweek.Location = New System.Drawing.Point(20, 49)
        Me.cmbdayofweek.Name = "cmbdayofweek"
        Me.cmbdayofweek.Size = New System.Drawing.Size(130, 31)
        Me.cmbdayofweek.TabIndex = 1
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.ZigZag
        Me.RectangleShape2.Location = New System.Drawing.Point(-5, -2)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(833, 97)
        '
        'txtschedid
        '
        Me.txtschedid.Enabled = False
        Me.txtschedid.Location = New System.Drawing.Point(757, 31)
        Me.txtschedid.Name = "txtschedid"
        Me.txtschedid.Size = New System.Drawing.Size(30, 30)
        Me.txtschedid.TabIndex = 0
        Me.txtschedid.Text = "ID"
        Me.txtschedid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtschedid.Visible = False
        '
        'schedview
        '
        Me.schedview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.schedid, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.schedview.FullRowSelect = True
        Me.schedview.GridLines = True
        Me.schedview.Location = New System.Drawing.Point(23, 118)
        Me.schedview.Name = "schedview"
        Me.schedview.Size = New System.Drawing.Size(364, 305)
        Me.schedview.TabIndex = 1
        Me.schedview.UseCompatibleStateImageBehavior = False
        Me.schedview.View = System.Windows.Forms.View.Details
        '
        'schedid
        '
        Me.schedid.Text = "ID"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Day of Week"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Time Slot"
        Me.ColumnHeader2.Width = 150
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.Location = New System.Drawing.Point(677, 257)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(112, 39)
        Me.btnsave.TabIndex = 32
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancel.Location = New System.Drawing.Point(677, 302)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(112, 39)
        Me.btncancel.TabIndex = 31
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
        Me.btnupdate.Location = New System.Drawing.Point(531, 257)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 39)
        Me.btnupdate.TabIndex = 29
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
        Me.btndelete.Location = New System.Drawing.Point(415, 302)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(110, 39)
        Me.btndelete.TabIndex = 30
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
        Me.btnnew.Location = New System.Drawing.Point(415, 257)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(110, 39)
        Me.btnnew.TabIndex = 28
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.header.Controls.Add(Me.txtschedid)
        Me.header.Controls.Add(Me.Label5)
        Me.header.Controls.Add(Me.ShapeContainer1)
        Me.header.Location = New System.Drawing.Point(2, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(817, 92)
        Me.header.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(213, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(406, 92)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SCHEDULES"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(817, 92)
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
        Me.RectangleShape3.Location = New System.Drawing.Point(-1, -2)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(216, 96)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(624, -2)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(188, 96)
        '
        'Schedules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(814, 455)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.schedview)
        Me.Controls.Add(Me.pnlinput)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Schedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedules"
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlinput As System.Windows.Forms.Panel
    Friend WithEvents cmbdayofweek As System.Windows.Forms.ComboBox
    Friend WithEvents txtschedid As System.Windows.Forms.TextBox
    Friend WithEvents schedview As System.Windows.Forms.ListView
    Friend WithEvents schedid As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents dtptimeslot As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
