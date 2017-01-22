<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SignOut = New System.Windows.Forms.Button()
        Me.GR = New System.Windows.Forms.Button()
        Me.PMS = New System.Windows.Forms.Button()
        Me.CMS = New System.Windows.Forms.Button()
        Me.FMS = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NUR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(11, 257)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 3
        Me.Search.Text = "SEARCH"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(418, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "POLICE CONTROL SYSTEM"
        '
        'SignOut
        '
        Me.SignOut.Location = New System.Drawing.Point(11, 308)
        Me.SignOut.Name = "SignOut"
        Me.SignOut.Size = New System.Drawing.Size(65, 23)
        Me.SignOut.TabIndex = 9
        Me.SignOut.Text = "Sign Out"
        Me.SignOut.UseVisualStyleBackColor = True
        '
        'GR
        '
        Me.GR.Location = New System.Drawing.Point(11, 212)
        Me.GR.Name = "GR"
        Me.GR.Size = New System.Drawing.Size(137, 23)
        Me.GR.TabIndex = 6
        Me.GR.Text = "GENERATE REPORT"
        Me.GR.UseVisualStyleBackColor = True
        '
        'PMS
        '
        Me.PMS.Location = New System.Drawing.Point(11, 123)
        Me.PMS.Name = "PMS"
        Me.PMS.Size = New System.Drawing.Size(204, 23)
        Me.PMS.TabIndex = 2
        Me.PMS.Text = "PRISONER MANAGEMENT SYSTEM"
        Me.PMS.UseVisualStyleBackColor = True
        '
        'CMS
        '
        Me.CMS.Location = New System.Drawing.Point(11, 80)
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(204, 23)
        Me.CMS.TabIndex = 5
        Me.CMS.Text = "CRIMINAL MANAGEMENT SYSTEM"
        Me.CMS.UseVisualStyleBackColor = True
        '
        'FMS
        '
        Me.FMS.Location = New System.Drawing.Point(11, 38)
        Me.FMS.Name = "FMS"
        Me.FMS.Size = New System.Drawing.Size(204, 23)
        Me.FMS.TabIndex = 0
        Me.FMS.Text = "FIR MANAGEMENT SYSTEM"
        Me.FMS.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NUR)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PMS)
        Me.Panel1.Controls.Add(Me.FMS)
        Me.Panel1.Controls.Add(Me.SignOut)
        Me.Panel1.Controls.Add(Me.GR)
        Me.Panel1.Controls.Add(Me.CMS)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 719)
        Me.Panel1.TabIndex = 11
        '
        'NUR
        '
        Me.NUR.Enabled = False
        Me.NUR.Location = New System.Drawing.Point(11, 167)
        Me.NUR.Name = "NUR"
        Me.NUR.Size = New System.Drawing.Size(158, 23)
        Me.NUR.TabIndex = 11
        Me.NUR.Text = "NEW USER REQUESTS"
        Me.NUR.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NAVIGATE"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.PCS.My.Resources.Resources.Abstract_PalmHighRes
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(251, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1101, 719)
        Me.Panel2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(519, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DASHBOARD"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PCS.My.Resources.Resources.Abstract_PalmHighRes
        Me.ClientSize = New System.Drawing.Size(1350, 719)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCS::DASHBOARD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SignOut As System.Windows.Forms.Button
    Friend WithEvents GR As System.Windows.Forms.Button
    Friend WithEvents PMS As System.Windows.Forms.Button
    Friend WithEvents CMS As System.Windows.Forms.Button
    Friend WithEvents FMS As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NUR As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
