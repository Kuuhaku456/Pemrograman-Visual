<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DATAANIMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ONGOINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPLETEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATASHOPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.username_TXT = New System.Windows.Forms.TextBox()
        Me.foto_profile = New System.Windows.Forms.PictureBox()
        Me.id_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_admin = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.foto_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Crimson
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAANIMEToolStripMenuItem, Me.DATASHOPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1288, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DATAANIMEToolStripMenuItem
        '
        Me.DATAANIMEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ONGOINGToolStripMenuItem, Me.COMPLETEDToolStripMenuItem})
        Me.DATAANIMEToolStripMenuItem.Name = "DATAANIMEToolStripMenuItem"
        Me.DATAANIMEToolStripMenuItem.Size = New System.Drawing.Size(162, 34)
        Me.DATAANIMEToolStripMenuItem.Text = "DATA ANIME"
        '
        'ONGOINGToolStripMenuItem
        '
        Me.ONGOINGToolStripMenuItem.Name = "ONGOINGToolStripMenuItem"
        Me.ONGOINGToolStripMenuItem.Size = New System.Drawing.Size(246, 38)
        Me.ONGOINGToolStripMenuItem.Text = "ONGOING"
        '
        'COMPLETEDToolStripMenuItem
        '
        Me.COMPLETEDToolStripMenuItem.Name = "COMPLETEDToolStripMenuItem"
        Me.COMPLETEDToolStripMenuItem.Size = New System.Drawing.Size(246, 38)
        Me.COMPLETEDToolStripMenuItem.Text = "COMPLETED"
        '
        'DATASHOPToolStripMenuItem
        '
        Me.DATASHOPToolStripMenuItem.Name = "DATASHOPToolStripMenuItem"
        Me.DATASHOPToolStripMenuItem.Size = New System.Drawing.Size(150, 34)
        Me.DATASHOPToolStripMenuItem.Text = "DATA SHOP"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.username_TXT)
        Me.Panel1.Controls.Add(Me.foto_profile)
        Me.Panel1.Controls.Add(Me.id_user)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1288, 83)
        Me.Panel1.TabIndex = 1
        '
        'username_TXT
        '
        Me.username_TXT.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_TXT.Location = New System.Drawing.Point(995, 24)
        Me.username_TXT.Name = "username_TXT"
        Me.username_TXT.ReadOnly = True
        Me.username_TXT.Size = New System.Drawing.Size(140, 34)
        Me.username_TXT.TabIndex = 12
        '
        'foto_profile
        '
        Me.foto_profile.BackColor = System.Drawing.Color.DarkRed
        Me.foto_profile.Image = Global.anime_projects.My.Resources.Resources.admin_logo
        Me.foto_profile.Location = New System.Drawing.Point(1152, 5)
        Me.foto_profile.Name = "foto_profile"
        Me.foto_profile.Size = New System.Drawing.Size(98, 78)
        Me.foto_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto_profile.TabIndex = 11
        Me.foto_profile.TabStop = False
        '
        'id_user
        '
        Me.id_user.Location = New System.Drawing.Point(0, 19)
        Me.id_user.Name = "id_user"
        Me.id_user.ReadOnly = True
        Me.id_user.Size = New System.Drawing.Size(100, 39)
        Me.id_user.TabIndex = 10
        Me.id_user.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(377, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "WELCOME TO SAMAHEDAKU APP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_admin
        '
        Me.pnl_admin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_admin.Location = New System.Drawing.Point(0, 121)
        Me.pnl_admin.Name = "pnl_admin"
        Me.pnl_admin.Size = New System.Drawing.Size(1288, 680)
        Me.pnl_admin.TabIndex = 2
        '
        'form_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1288, 801)
        Me.Controls.Add(Me.pnl_admin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "form_admin"
        Me.Text = "form_admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.foto_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DATAANIMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATASHOPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents username_TXT As TextBox
    Friend WithEvents foto_profile As PictureBox
    Friend WithEvents id_user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_admin As Panel
    Friend WithEvents ONGOINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPLETEDToolStripMenuItem As ToolStripMenuItem
End Class
