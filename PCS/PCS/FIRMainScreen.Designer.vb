<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FIRMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FIRMainScreen))
        Me.FileReport = New System.Windows.Forms.Button()
        Me.RegFIR = New System.Windows.Forms.Button()
        Me.FIRStat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FileReport
        '
        Me.FileReport.Location = New System.Drawing.Point(504, 217)
        Me.FileReport.Name = "FileReport"
        Me.FileReport.Size = New System.Drawing.Size(149, 74)
        Me.FileReport.TabIndex = 2
        Me.FileReport.Text = "FILE REPORT"
        Me.FileReport.UseVisualStyleBackColor = True
        '
        'RegFIR
        '
        Me.RegFIR.Location = New System.Drawing.Point(292, 217)
        Me.RegFIR.Name = "RegFIR"
        Me.RegFIR.Size = New System.Drawing.Size(149, 74)
        Me.RegFIR.TabIndex = 3
        Me.RegFIR.Text = "REGISTER FIR"
        Me.RegFIR.UseVisualStyleBackColor = True
        '
        'FIRStat
        '
        Me.FIRStat.Location = New System.Drawing.Point(705, 217)
        Me.FIRStat.Name = "FIRStat"
        Me.FIRStat.Size = New System.Drawing.Size(149, 74)
        Me.FIRStat.TabIndex = 4
        Me.FIRStat.Text = "VIEW FIR STATUS"
        Me.FIRStat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "FIR MANAGEMENT SYSTEM"
        '
        'FIRMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PCS.My.Resources.Resources.Abstract_PalmHighRes
        Me.ClientSize = New System.Drawing.Size(1101, 719)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FIRStat)
        Me.Controls.Add(Me.FileReport)
        Me.Controls.Add(Me.RegFIR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FIRMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIRMainScreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileReport As System.Windows.Forms.Button
    Friend WithEvents RegFIR As System.Windows.Forms.Button
    Friend WithEvents FIRStat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
