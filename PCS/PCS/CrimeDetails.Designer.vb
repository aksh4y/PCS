<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrimeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrimeDetails))
        Me.caseid = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.infid = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.policeid = New System.Windows.Forms.TextBox()
        Me.actinfo = New System.Windows.Forms.TextBox()
        Me.loc = New System.Windows.Forms.TextBox()
        Me.infadd = New System.Windows.Forms.TextBox()
        Me.infname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dd = New System.Windows.Forms.TextBox()
        Me.mm = New System.Windows.Forms.TextBox()
        Me.yy = New System.Windows.Forms.TextBox()
        Me.fyy = New System.Windows.Forms.TextBox()
        Me.fmm = New System.Windows.Forms.TextBox()
        Me.fdd = New System.Windows.Forms.TextBox()
        Me.min = New System.Windows.Forms.TextBox()
        Me.hh = New System.Windows.Forms.TextBox()
        Me.fmin = New System.Windows.Forms.TextBox()
        Me.fhh = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'caseid
        '
        Me.caseid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.caseid.FormattingEnabled = True
        Me.caseid.Location = New System.Drawing.Point(505, 86)
        Me.caseid.Name = "caseid"
        Me.caseid.Size = New System.Drawing.Size(87, 21)
        Me.caseid.TabIndex = 175
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(126, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 13)
        Me.Label13.TabIndex = 169
        Me.Label13.Text = "Informant Identification Number"
        '
        'infid
        '
        Me.infid.Enabled = False
        Me.infid.Location = New System.Drawing.Point(293, 202)
        Me.infid.Name = "infid"
        Me.infid.Size = New System.Drawing.Size(100, 20)
        Me.infid.TabIndex = 168
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(286, 543)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 161
        Me.cancel.Text = "BACK"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(127, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "Information/Act"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(127, 465)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "Police ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(127, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "Location"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "FIR Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Date of Incidence"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "FIR Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Time of Incidence"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Informant Add"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Informant Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(453, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Case ID"
        '
        'policeid
        '
        Me.policeid.Enabled = False
        Me.policeid.Location = New System.Drawing.Point(292, 462)
        Me.policeid.Name = "policeid"
        Me.policeid.Size = New System.Drawing.Size(100, 20)
        Me.policeid.TabIndex = 150
        '
        'actinfo
        '
        Me.actinfo.Enabled = False
        Me.actinfo.Location = New System.Drawing.Point(292, 331)
        Me.actinfo.Multiline = True
        Me.actinfo.Name = "actinfo"
        Me.actinfo.Size = New System.Drawing.Size(313, 80)
        Me.actinfo.TabIndex = 149
        '
        'loc
        '
        Me.loc.Enabled = False
        Me.loc.Location = New System.Drawing.Point(292, 417)
        Me.loc.Multiline = True
        Me.loc.Name = "loc"
        Me.loc.Size = New System.Drawing.Size(313, 33)
        Me.loc.TabIndex = 148
        '
        'infadd
        '
        Me.infadd.Enabled = False
        Me.infadd.Location = New System.Drawing.Point(293, 173)
        Me.infadd.Name = "infadd"
        Me.infadd.Size = New System.Drawing.Size(100, 20)
        Me.infadd.TabIndex = 146
        '
        'infname
        '
        Me.infname.Enabled = False
        Me.infname.Location = New System.Drawing.Point(293, 147)
        Me.infname.Name = "infname"
        Me.infname.Size = New System.Drawing.Size(100, 20)
        Me.infname.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 32)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "CRIME DETAILS"
        '
        'dd
        '
        Me.dd.Enabled = False
        Me.dd.Location = New System.Drawing.Point(292, 230)
        Me.dd.Name = "dd"
        Me.dd.Size = New System.Drawing.Size(52, 20)
        Me.dd.TabIndex = 176
        '
        'mm
        '
        Me.mm.Enabled = False
        Me.mm.Location = New System.Drawing.Point(352, 230)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(52, 20)
        Me.mm.TabIndex = 177
        '
        'yy
        '
        Me.yy.Enabled = False
        Me.yy.Location = New System.Drawing.Point(407, 230)
        Me.yy.Name = "yy"
        Me.yy.Size = New System.Drawing.Size(52, 20)
        Me.yy.TabIndex = 178
        '
        'fyy
        '
        Me.fyy.Enabled = False
        Me.fyy.Location = New System.Drawing.Point(407, 281)
        Me.fyy.Name = "fyy"
        Me.fyy.Size = New System.Drawing.Size(52, 20)
        Me.fyy.TabIndex = 181
        '
        'fmm
        '
        Me.fmm.Enabled = False
        Me.fmm.Location = New System.Drawing.Point(352, 281)
        Me.fmm.Name = "fmm"
        Me.fmm.Size = New System.Drawing.Size(52, 20)
        Me.fmm.TabIndex = 180
        '
        'fdd
        '
        Me.fdd.Enabled = False
        Me.fdd.Location = New System.Drawing.Point(292, 281)
        Me.fdd.Name = "fdd"
        Me.fdd.Size = New System.Drawing.Size(52, 20)
        Me.fdd.TabIndex = 179
        '
        'min
        '
        Me.min.Enabled = False
        Me.min.Location = New System.Drawing.Point(352, 256)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(52, 20)
        Me.min.TabIndex = 183
        '
        'hh
        '
        Me.hh.Enabled = False
        Me.hh.Location = New System.Drawing.Point(292, 256)
        Me.hh.Name = "hh"
        Me.hh.Size = New System.Drawing.Size(52, 20)
        Me.hh.TabIndex = 182
        '
        'fmin
        '
        Me.fmin.Enabled = False
        Me.fmin.Location = New System.Drawing.Point(352, 304)
        Me.fmin.Name = "fmin"
        Me.fmin.Size = New System.Drawing.Size(52, 20)
        Me.fmin.TabIndex = 185
        '
        'fhh
        '
        Me.fhh.Enabled = False
        Me.fhh.Location = New System.Drawing.Point(292, 304)
        Me.fhh.Name = "fhh"
        Me.fhh.Size = New System.Drawing.Size(52, 20)
        Me.fhh.TabIndex = 184
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(127, 491)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "Status"
        '
        'status
        '
        Me.status.Enabled = False
        Me.status.Location = New System.Drawing.Point(292, 488)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(100, 20)
        Me.status.TabIndex = 186
        '
        'CrimeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(738, 578)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.fmin)
        Me.Controls.Add(Me.fhh)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.hh)
        Me.Controls.Add(Me.fyy)
        Me.Controls.Add(Me.fmm)
        Me.Controls.Add(Me.fdd)
        Me.Controls.Add(Me.yy)
        Me.Controls.Add(Me.mm)
        Me.Controls.Add(Me.dd)
        Me.Controls.Add(Me.caseid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.infid)
        Me.Controls.Add(Me.cancel)
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
        Me.Controls.Add(Me.actinfo)
        Me.Controls.Add(Me.loc)
        Me.Controls.Add(Me.infadd)
        Me.Controls.Add(Me.infname)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrimeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCS::Crime Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents caseid As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents infid As System.Windows.Forms.TextBox
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents policeid As System.Windows.Forms.TextBox
    Friend WithEvents actinfo As System.Windows.Forms.TextBox
    Friend WithEvents loc As System.Windows.Forms.TextBox
    Friend WithEvents infadd As System.Windows.Forms.TextBox
    Friend WithEvents infname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dd As System.Windows.Forms.TextBox
    Friend WithEvents mm As System.Windows.Forms.TextBox
    Friend WithEvents yy As System.Windows.Forms.TextBox
    Friend WithEvents fyy As System.Windows.Forms.TextBox
    Friend WithEvents fmm As System.Windows.Forms.TextBox
    Friend WithEvents fdd As System.Windows.Forms.TextBox
    Friend WithEvents min As System.Windows.Forms.TextBox
    Friend WithEvents hh As System.Windows.Forms.TextBox
    Friend WithEvents fmin As System.Windows.Forms.TextBox
    Friend WithEvents fhh As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.TextBox
End Class
