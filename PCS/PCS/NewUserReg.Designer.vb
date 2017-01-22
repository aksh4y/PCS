<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUserReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUserReg))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.position = New System.Windows.Forms.TextBox()
        Me.addr = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.psid = New System.Windows.Forms.TextBox()
        Me.policeid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dd = New System.Windows.Forms.ComboBox()
        Me.yy = New System.Windows.Forms.ComboBox()
        Me.mm = New System.Windows.Forms.ComboBox()
        Me.sex = New System.Windows.Forms.ComboBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Police Registration"
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(272, 106)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(100, 20)
        Me.pname.TabIndex = 1
        '
        'position
        '
        Me.position.Location = New System.Drawing.Point(272, 184)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(100, 20)
        Me.position.TabIndex = 4
        '
        'addr
        '
        Me.addr.AcceptsReturn = True
        Me.addr.Location = New System.Drawing.Point(272, 210)
        Me.addr.Multiline = True
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(316, 102)
        Me.addr.TabIndex = 5
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(272, 318)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(100, 20)
        Me.phone.TabIndex = 6
        '
        'psid
        '
        Me.psid.Location = New System.Drawing.Point(272, 344)
        Me.psid.Name = "psid"
        Me.psid.Size = New System.Drawing.Size(100, 20)
        Me.psid.TabIndex = 7
        '
        'policeid
        '
        Me.policeid.Enabled = False
        Me.policeid.Location = New System.Drawing.Point(272, 371)
        Me.policeid.Name = "policeid"
        Me.policeid.Size = New System.Drawing.Size(100, 20)
        Me.policeid.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Sex"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Police Station ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(165, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Police ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(165, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "D.O.B"
        '
        'dd
        '
        Me.dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dd.FormattingEnabled = True
        Me.dd.Location = New System.Drawing.Point(272, 131)
        Me.dd.Name = "dd"
        Me.dd.Size = New System.Drawing.Size(40, 21)
        Me.dd.TabIndex = 17
        '
        'yy
        '
        Me.yy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yy.FormattingEnabled = True
        Me.yy.Location = New System.Drawing.Point(364, 132)
        Me.yy.Name = "yy"
        Me.yy.Size = New System.Drawing.Size(56, 21)
        Me.yy.TabIndex = 18
        '
        'mm
        '
        Me.mm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mm.FormattingEnabled = True
        Me.mm.Location = New System.Drawing.Point(318, 132)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(40, 21)
        Me.mm.TabIndex = 19
        '
        'sex
        '
        Me.sex.FormattingEnabled = True
        Me.sex.Location = New System.Drawing.Point(272, 158)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(100, 21)
        Me.sex.TabIndex = 20
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(272, 416)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(75, 23)
        Me.Register.TabIndex = 21
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(386, 416)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 22
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'NewUserReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(624, 478)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.sex)
        Me.Controls.Add(Me.mm)
        Me.Controls.Add(Me.yy)
        Me.Controls.Add(Me.dd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.policeid)
        Me.Controls.Add(Me.psid)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.addr)
        Me.Controls.Add(Me.position)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NewUserReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCS::User Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pname As System.Windows.Forms.TextBox
    Friend WithEvents position As System.Windows.Forms.TextBox
    Friend WithEvents addr As System.Windows.Forms.TextBox
    Friend WithEvents phone As System.Windows.Forms.TextBox
    Friend WithEvents psid As System.Windows.Forms.TextBox
    Friend WithEvents policeid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dd As System.Windows.Forms.ComboBox
    Friend WithEvents yy As System.Windows.Forms.ComboBox
    Friend WithEvents mm As System.Windows.Forms.ComboBox
    Friend WithEvents sex As System.Windows.Forms.ComboBox
    Friend WithEvents Register As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
