<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FIR
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FIR))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirNo = New System.Windows.Forms.TextBox()
        Me.infname = New System.Windows.Forms.TextBox()
        Me.infadd = New System.Windows.Forms.TextBox()
        Me.actinfo = New System.Windows.Forms.TextBox()
        Me.loc = New System.Windows.Forms.TextBox()
        Me.policeid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.register = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.hh = New System.Windows.Forms.ComboBox()
        Me.min = New System.Windows.Forms.ComboBox()
        Me.fmin = New System.Windows.Forms.ComboBox()
        Me.fhh = New System.Windows.Forms.ComboBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fmm = New System.Windows.Forms.ComboBox()
        Me.fdd = New System.Windows.Forms.ComboBox()
        Me.fyy = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.infid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER FIR"
        '
        'FirNo
        '
        Me.FirNo.Enabled = False
        Me.FirNo.Location = New System.Drawing.Point(664, 80)
        Me.FirNo.Name = "FirNo"
        Me.FirNo.Size = New System.Drawing.Size(100, 20)
        Me.FirNo.TabIndex = 1
        '
        'infname
        '
        Me.infname.Location = New System.Drawing.Point(359, 150)
        Me.infname.Name = "infname"
        Me.infname.Size = New System.Drawing.Size(369, 20)
        Me.infname.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.infname, "Enter informant names seperated by a comma")
        '
        'infadd
        '
        Me.infadd.Location = New System.Drawing.Point(359, 176)
        Me.infadd.Multiline = True
        Me.infadd.Name = "infadd"
        Me.infadd.Size = New System.Drawing.Size(369, 95)
        Me.infadd.TabIndex = 3
        '
        'actinfo
        '
        Me.actinfo.Location = New System.Drawing.Point(360, 517)
        Me.actinfo.Multiline = True
        Me.actinfo.Name = "actinfo"
        Me.actinfo.Size = New System.Drawing.Size(320, 72)
        Me.actinfo.TabIndex = 6
        '
        'loc
        '
        Me.loc.Location = New System.Drawing.Point(359, 491)
        Me.loc.Name = "loc"
        Me.loc.Size = New System.Drawing.Size(100, 20)
        Me.loc.TabIndex = 8
        '
        'policeid
        '
        Me.policeid.Enabled = False
        Me.policeid.Location = New System.Drawing.Point(360, 595)
        Me.policeid.Name = "policeid"
        Me.policeid.Size = New System.Drawing.Size(100, 20)
        Me.policeid.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(612, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "FIR NO."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Informant(s) Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Informant Add"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Time of Incidence"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(265, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "FIR Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Date of Incidence"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(265, 468)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "FIR Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(265, 494)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Location"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 598)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Police ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(265, 520)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Information/Act"
        '
        'register
        '
        Me.register.Location = New System.Drawing.Point(360, 647)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(75, 23)
        Me.register.TabIndex = 23
        Me.register.Text = "Register"
        Me.register.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(460, 647)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 24
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'hh
        '
        Me.hh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hh.FormattingEnabled = True
        Me.hh.Location = New System.Drawing.Point(359, 415)
        Me.hh.Name = "hh"
        Me.hh.Size = New System.Drawing.Size(53, 21)
        Me.hh.TabIndex = 27
        '
        'min
        '
        Me.min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.min.FormattingEnabled = True
        Me.min.Location = New System.Drawing.Point(415, 415)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(53, 21)
        Me.min.TabIndex = 28
        '
        'fmin
        '
        Me.fmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.fmin.Enabled = False
        Me.fmin.FormattingEnabled = True
        Me.fmin.Location = New System.Drawing.Point(415, 464)
        Me.fmin.Name = "fmin"
        Me.fmin.Size = New System.Drawing.Size(53, 21)
        Me.fmin.TabIndex = 33
        '
        'fhh
        '
        Me.fhh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.fhh.Enabled = False
        Me.fhh.FormattingEnabled = True
        Me.fhh.Location = New System.Drawing.Point(359, 464)
        Me.fhh.Name = "fhh"
        Me.fhh.Size = New System.Drawing.Size(53, 21)
        Me.fhh.TabIndex = 32
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(537, 300)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 35
        Me.MonthCalendar1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Show Calendar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fmm
        '
        Me.fmm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.fmm.Enabled = False
        Me.fmm.FormattingEnabled = True
        Me.fmm.Location = New System.Drawing.Point(415, 441)
        Me.fmm.Name = "fmm"
        Me.fmm.Size = New System.Drawing.Size(53, 21)
        Me.fmm.TabIndex = 38
        '
        'fdd
        '
        Me.fdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.fdd.Enabled = False
        Me.fdd.FormattingEnabled = True
        Me.fdd.Location = New System.Drawing.Point(359, 441)
        Me.fdd.Name = "fdd"
        Me.fdd.Size = New System.Drawing.Size(53, 21)
        Me.fdd.TabIndex = 37
        '
        'fyy
        '
        Me.fyy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.fyy.Enabled = False
        Me.fyy.FormattingEnabled = True
        Me.fyy.Location = New System.Drawing.Point(471, 441)
        Me.fyy.Name = "fyy"
        Me.fyy.Size = New System.Drawing.Size(53, 21)
        Me.fyy.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(265, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Informant Identification Type"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(268, 307)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton1.TabIndex = 41
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Driving Licence"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(373, 307)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton2.TabIndex = 42
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pan Card"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(448, 307)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Voter ID"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(394, 330)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton4.TabIndex = 44
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Passport Number"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(267, 330)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(121, 17)
        Me.RadioButton5.TabIndex = 45
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Ration Card Number"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'infid
        '
        Me.infid.Location = New System.Drawing.Point(424, 359)
        Me.infid.Name = "infid"
        Me.infid.Size = New System.Drawing.Size(100, 20)
        Me.infid.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(264, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Informant Identification Number"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(490, 392)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Visible = False
        '
        'FIR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1101, 719)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.infid)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fyy)
        Me.Controls.Add(Me.fmm)
        Me.Controls.Add(Me.fdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.fmin)
        Me.Controls.Add(Me.fhh)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.hh)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.policeid)
        Me.Controls.Add(Me.loc)
        Me.Controls.Add(Me.actinfo)
        Me.Controls.Add(Me.infadd)
        Me.Controls.Add(Me.infname)
        Me.Controls.Add(Me.FirNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FIR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCS::Register FIR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirNo As System.Windows.Forms.TextBox
    Friend WithEvents infname As System.Windows.Forms.TextBox
    Friend WithEvents infadd As System.Windows.Forms.TextBox
    Friend WithEvents actinfo As System.Windows.Forms.TextBox
    Friend WithEvents loc As System.Windows.Forms.TextBox
    Friend WithEvents policeid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents register As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents hh As System.Windows.Forms.ComboBox
    Friend WithEvents min As System.Windows.Forms.ComboBox
    Friend WithEvents fmin As System.Windows.Forms.ComboBox
    Friend WithEvents fhh As System.Windows.Forms.ComboBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fmm As System.Windows.Forms.ComboBox
    Friend WithEvents fdd As System.Windows.Forms.ComboBox
    Friend WithEvents fyy As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents infid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
