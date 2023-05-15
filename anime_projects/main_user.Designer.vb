<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_user))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STREAMINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ONGOINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPLETEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STUDIOLISTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHOPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MARCHENDISEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOTHESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHOESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.username_TXT = New System.Windows.Forms.TextBox()
        Me.foto_profile = New System.Windows.Forms.PictureBox()
        Me.id_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_judul = New System.Windows.Forms.Label()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.sb_vertikal = New System.Windows.Forms.VScrollBar()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.foto_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Crimson
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STREAMINGToolStripMenuItem, Me.SHOPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1288, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STREAMINGToolStripMenuItem
        '
        Me.STREAMINGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ONGOINGToolStripMenuItem, Me.COMPLETEDToolStripMenuItem, Me.STUDIOLISTToolStripMenuItem})
        Me.STREAMINGToolStripMenuItem.Name = "STREAMINGToolStripMenuItem"
        Me.STREAMINGToolStripMenuItem.Size = New System.Drawing.Size(170, 36)
        Me.STREAMINGToolStripMenuItem.Text = "STREAMING"
        '
        'ONGOINGToolStripMenuItem
        '
        Me.ONGOINGToolStripMenuItem.Name = "ONGOINGToolStripMenuItem"
        Me.ONGOINGToolStripMenuItem.Size = New System.Drawing.Size(260, 40)
        Me.ONGOINGToolStripMenuItem.Text = "ON GOING"
        '
        'COMPLETEDToolStripMenuItem
        '
        Me.COMPLETEDToolStripMenuItem.Name = "COMPLETEDToolStripMenuItem"
        Me.COMPLETEDToolStripMenuItem.Size = New System.Drawing.Size(260, 40)
        Me.COMPLETEDToolStripMenuItem.Text = "COMPLETED"
        '
        'STUDIOLISTToolStripMenuItem
        '
        Me.STUDIOLISTToolStripMenuItem.Name = "STUDIOLISTToolStripMenuItem"
        Me.STUDIOLISTToolStripMenuItem.Size = New System.Drawing.Size(260, 40)
        Me.STUDIOLISTToolStripMenuItem.Text = "STUDIO LIST"
        '
        'SHOPToolStripMenuItem
        '
        Me.SHOPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MARCHENDISEToolStripMenuItem, Me.CLOTHESToolStripMenuItem, Me.SHOESToolStripMenuItem})
        Me.SHOPToolStripMenuItem.Name = "SHOPToolStripMenuItem"
        Me.SHOPToolStripMenuItem.Size = New System.Drawing.Size(94, 36)
        Me.SHOPToolStripMenuItem.Text = "SHOP"
        '
        'MARCHENDISEToolStripMenuItem
        '
        Me.MARCHENDISEToolStripMenuItem.Name = "MARCHENDISEToolStripMenuItem"
        Me.MARCHENDISEToolStripMenuItem.Size = New System.Drawing.Size(291, 40)
        Me.MARCHENDISEToolStripMenuItem.Text = "MARCHENDISE"
        '
        'CLOTHESToolStripMenuItem
        '
        Me.CLOTHESToolStripMenuItem.Name = "CLOTHESToolStripMenuItem"
        Me.CLOTHESToolStripMenuItem.Size = New System.Drawing.Size(291, 40)
        Me.CLOTHESToolStripMenuItem.Text = "CLOTHES"
        '
        'SHOESToolStripMenuItem
        '
        Me.SHOESToolStripMenuItem.Name = "SHOESToolStripMenuItem"
        Me.SHOESToolStripMenuItem.Size = New System.Drawing.Size(291, 40)
        Me.SHOESToolStripMenuItem.Text = "SHOES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label_judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1288, 129)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.Controls.Add(Me.btn_log_out)
        Me.Panel2.Controls.Add(Me.username_TXT)
        Me.Panel2.Controls.Add(Me.foto_profile)
        Me.Panel2.Controls.Add(Me.id_user)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1288, 129)
        Me.Panel2.TabIndex = 3
        '
        'btn_log_out
        '
        Me.btn_log_out.BackColor = System.Drawing.Color.DarkRed
        Me.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log_out.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_log_out.Location = New System.Drawing.Point(12, 20)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Size = New System.Drawing.Size(156, 68)
        Me.btn_log_out.TabIndex = 13
        Me.btn_log_out.Text = "LOG OUT"
        Me.btn_log_out.UseVisualStyleBackColor = False
        '
        'username_TXT
        '
        Me.username_TXT.BackColor = System.Drawing.Color.Coral
        Me.username_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username_TXT.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_TXT.Location = New System.Drawing.Point(997, 46)
        Me.username_TXT.Name = "username_TXT"
        Me.username_TXT.ReadOnly = True
        Me.username_TXT.Size = New System.Drawing.Size(140, 27)
        Me.username_TXT.TabIndex = 8
        '
        'foto_profile
        '
        Me.foto_profile.BackColor = System.Drawing.Color.DarkRed
        Me.foto_profile.Location = New System.Drawing.Point(1154, 12)
        Me.foto_profile.Name = "foto_profile"
        Me.foto_profile.Size = New System.Drawing.Size(109, 104)
        Me.foto_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto_profile.TabIndex = 7
        Me.foto_profile.TabStop = False
        '
        'id_user
        '
        Me.id_user.Location = New System.Drawing.Point(212, 50)
        Me.id_user.Name = "id_user"
        Me.id_user.ReadOnly = True
        Me.id_user.Size = New System.Drawing.Size(100, 26)
        Me.id_user.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(366, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME TO SAMAHEDAKU APP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_judul
        '
        Me.Label_judul.AutoSize = True
        Me.Label_judul.BackColor = System.Drawing.Color.Crimson
        Me.Label_judul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_judul.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label_judul.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label_judul.Location = New System.Drawing.Point(376, 28)
        Me.Label_judul.Name = "Label_judul"
        Me.Label_judul.Size = New System.Drawing.Size(536, 45)
        Me.Label_judul.TabIndex = 2
        Me.Label_judul.Text = "WELCOME TO SAMAHEDAKU APP"
        Me.Label_judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_main
        '
        Me.pnl_main.AutoScroll = True
        Me.pnl_main.Controls.Add(Me.sb_vertikal)
        Me.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_main.Location = New System.Drawing.Point(0, 169)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(1288, 632)
        Me.pnl_main.TabIndex = 2
        '
        'sb_vertikal
        '
        Me.sb_vertikal.Dock = System.Windows.Forms.DockStyle.Right
        Me.sb_vertikal.Location = New System.Drawing.Point(1262, 0)
        Me.sb_vertikal.Name = "sb_vertikal"
        Me.sb_vertikal.Size = New System.Drawing.Size(26, 632)
        Me.sb_vertikal.TabIndex = 1
        '
        'main_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1288, 801)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main_user"
        Me.Text = "main_user"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.foto_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_main.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STREAMINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ONGOINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPLETEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STUDIOLISTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHOPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MARCHENDISEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOTHESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHOESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents username_TXT As TextBox
    Friend WithEvents foto_profile As PictureBox
    Friend WithEvents id_user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_judul As Label
    Friend WithEvents pnl_main As Panel
    Friend WithEvents sb_vertikal As VScrollBar
    Friend WithEvents btn_log_out As Button
End Class
