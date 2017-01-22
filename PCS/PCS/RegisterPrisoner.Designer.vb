<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPrisoner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterPrisoner))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prisonerid = New System.Windows.Forms.TextBox()
        Me.prisonername = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.height = New System.Windows.Forms.TextBox()
        Me.weight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.criminalid = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.heat = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.prisons = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.imp = New System.Windows.Forms.Label()
        Me.rel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.policeid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER PRISONER"
        '
        'prisonerid
        '
        Me.prisonerid.Enabled = False
        Me.prisonerid.Location = New System.Drawing.Point(451, 64)
        Me.prisonerid.Name = "prisonerid"
        Me.prisonerid.Size = New System.Drawing.Size(100, 20)
        Me.prisonerid.TabIndex = 1
        '
        'prisonername
        '
        Me.prisonername.Location = New System.Drawing.Point(264, 144)
        Me.prisonername.Name = "prisonername"
        Me.prisonername.Size = New System.Drawing.Size(100, 20)
        Me.prisonername.TabIndex = 4
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(264, 170)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(100, 20)
        Me.age.TabIndex = 5
        '
        'height
        '
        Me.height.Location = New System.Drawing.Point(264, 222)
        Me.height.Name = "height"
        Me.height.Size = New System.Drawing.Size(52, 20)
        Me.height.TabIndex = 7
        '
        'weight
        '
        Me.weight.Location = New System.Drawing.Point(264, 248)
        Me.weight.Name = "weight"
        Me.weight.Size = New System.Drawing.Size(52, 20)
        Me.weight.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Prisoner ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Criminal ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(149, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(149, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Height"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(149, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Weight"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(149, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Heat Level"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Date of Imprisonment"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(149, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Date of Release"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(149, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Gender"
        '
        'criminalid
        '
        Me.criminalid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.criminalid.FormattingEnabled = True
        Me.criminalid.Location = New System.Drawing.Point(264, 117)
        Me.criminalid.Name = "criminalid"
        Me.criminalid.Size = New System.Drawing.Size(100, 21)
        Me.criminalid.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(322, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "cm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(322, 251)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "kg"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(149, 359)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Current Prison"
        '
        'gender
        '
        Me.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender.FormattingEnabled = True
        Me.gender.Location = New System.Drawing.Point(264, 196)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(100, 21)
        Me.gender.TabIndex = 32
        '
        'heat
        '
        Me.heat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.heat.FormattingEnabled = True
        Me.heat.Location = New System.Drawing.Point(264, 274)
        Me.heat.Name = "heat"
        Me.heat.Size = New System.Drawing.Size(52, 21)
        Me.heat.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(456, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'prisons
        '
        Me.prisons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prisons.FormattingEnabled = True
        Me.prisons.Location = New System.Drawing.Point(264, 356)
        Me.prisons.Name = "prisons"
        Me.prisons.Size = New System.Drawing.Size(100, 21)
        Me.prisons.TabIndex = 37
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Show Calendar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(264, 324)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Show Calendar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(376, 117)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 40
        Me.MonthCalendar1.Visible = False
        '
        'imp
        '
        Me.imp.AutoSize = True
        Me.imp.Location = New System.Drawing.Point(373, 303)
        Me.imp.Name = "imp"
        Me.imp.Size = New System.Drawing.Size(0, 13)
        Me.imp.TabIndex = 41
        '
        'rel
        '
        Me.rel.AutoSize = True
        Me.rel.Location = New System.Drawing.Point(373, 329)
        Me.rel.Name = "rel"
        Me.rel.Size = New System.Drawing.Size(0, 13)
        Me.rel.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Police ID"
        '
        'policeid
        '
        Me.policeid.Enabled = False
        Me.policeid.Location = New System.Drawing.Point(264, 383)
        Me.policeid.Name = "policeid"
        Me.policeid.Size = New System.Drawing.Size(100, 20)
        Me.policeid.TabIndex = 43
        '
        'RegisterPrisoner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(621, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.policeid)
        Me.Controls.Add(Me.rel)
        Me.Controls.Add(Me.imp)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.prisons)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.heat)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.criminalid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.weight)
        Me.Controls.Add(Me.height)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.prisonername)
        Me.Controls.Add(Me.prisonerid)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RegisterPrisoner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterPrisoner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prisonerid As System.Windows.Forms.TextBox
    Friend WithEvents prisonername As System.Windows.Forms.TextBox
    Friend WithEvents age As System.Windows.Forms.TextBox
    Friend WithEvents height As System.Windows.Forms.TextBox
    Friend WithEvents weight As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents criminalid As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.ComboBox
    Friend WithEvents heat As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents prisons As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents imp As System.Windows.Forms.Label
    Friend WithEvents rel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents policeid As System.Windows.Forms.TextBox
End Class
