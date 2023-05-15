<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading_page
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBloading = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_progress = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(100, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Loading. . ."
        '
        'PBloading
        '
        Me.PBloading.Location = New System.Drawing.Point(107, 222)
        Me.PBloading.Name = "PBloading"
        Me.PBloading.Size = New System.Drawing.Size(563, 39)
        Me.PBloading.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(161, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(465, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "WELCOME TO SAMAHEDAKU APP"
        '
        'lbl_progress
        '
        Me.lbl_progress.AutoSize = True
        Me.lbl_progress.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_progress.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_progress.Location = New System.Drawing.Point(608, 273)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(62, 28)
        Me.lbl_progress.TabIndex = 10
        Me.lbl_progress.Text = "000%"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_status.Location = New System.Drawing.Point(102, 273)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(209, 28)
        Me.lbl_status.TabIndex = 9
        Me.lbl_status.Text = "Launching the app. . ."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 100)
        Me.Panel1.TabIndex = 8
        '
        'Loading_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(792, 368)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBloading)
        Me.Controls.Add(Me.lbl_progress)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loading_page"
        Me.Text = "Loading_page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PBloading As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_progress As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents Panel1 As Panel
End Class
