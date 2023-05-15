<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_user))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_daftar = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.cbpass = New System.Windows.Forms.CheckBox()
        Me.password_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.username_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btn_keluar)
        Me.Panel1.Controls.Add(Me.btn_admin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(952, 132)
        Me.Panel1.TabIndex = 8
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.Color.Crimson
        Me.btn_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_keluar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_keluar.Location = New System.Drawing.Point(806, 41)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(124, 54)
        Me.btn_keluar.TabIndex = 2
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'btn_admin
        '
        Me.btn_admin.BackColor = System.Drawing.Color.Crimson
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admin.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_admin.Location = New System.Drawing.Point(29, 38)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(109, 54)
        Me.btn_admin.TabIndex = 1
        Me.btn_admin.Text = "ADMIN"
        Me.btn_admin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(226, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO SAMAHEDAKU APP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_daftar
        '
        Me.btn_daftar.BackColor = System.Drawing.Color.Crimson
        Me.btn_daftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_daftar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daftar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_daftar.Location = New System.Drawing.Point(744, 475)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(141, 48)
        Me.btn_daftar.TabIndex = 16
        Me.btn_daftar.Text = "DAFTAR"
        Me.btn_daftar.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Crimson
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_login.Location = New System.Drawing.Point(520, 475)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(141, 48)
        Me.btn_login.TabIndex = 10
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'cbpass
        '
        Me.cbpass.AutoSize = True
        Me.cbpass.BackColor = System.Drawing.Color.Crimson
        Me.cbpass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpass.ForeColor = System.Drawing.Color.Cornsilk
        Me.cbpass.Location = New System.Drawing.Point(520, 425)
        Me.cbpass.Name = "cbpass"
        Me.cbpass.Size = New System.Drawing.Size(199, 29)
        Me.cbpass.TabIndex = 15
        Me.cbpass.Text = "SHOW PASSWORD"
        Me.cbpass.UseVisualStyleBackColor = False
        '
        'password_TXT
        '
        Me.password_TXT.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_TXT.Location = New System.Drawing.Point(520, 366)
        Me.password_TXT.Name = "password_TXT"
        Me.password_TXT.Size = New System.Drawing.Size(365, 45)
        Me.password_TXT.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label4.Location = New System.Drawing.Point(520, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 45)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PASSWORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'username_TXT
        '
        Me.username_TXT.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_TXT.Location = New System.Drawing.Point(520, 227)
        Me.username_TXT.Name = "username_TXT"
        Me.username_TXT.Size = New System.Drawing.Size(365, 45)
        Me.username_TXT.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(520, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 45)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "USERNAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(26, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(434, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APP ANIME YANG TERPERCAYA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 446)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.anime_projects.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(123, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'login_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(952, 576)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_daftar)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.cbpass)
        Me.Controls.Add(Me.password_TXT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.username_TXT)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login_user"
        Me.Text = "login_user"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_admin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_daftar As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents cbpass As CheckBox
    Friend WithEvents password_TXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents username_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_keluar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
