<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Daftar
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dtpTangalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.telepon_TXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_daftar = New System.Windows.Forms.Button()
        Me.foto_daftar = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RB_cewe = New System.Windows.Forms.RadioButton()
        Me.RB_Laki = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbpass = New System.Windows.Forms.CheckBox()
        Me.password_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.username_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.path_txt = New System.Windows.Forms.TextBox()
        Me.btn_kembali = New System.Windows.Forms.Button()
        CType(Me.foto_daftar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dtpTangalLahir
        '
        Me.dtpTangalLahir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTangalLahir.Location = New System.Drawing.Point(29, 387)
        Me.dtpTangalLahir.Name = "dtpTangalLahir"
        Me.dtpTangalLahir.Size = New System.Drawing.Size(286, 39)
        Me.dtpTangalLahir.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Crimson
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label7.Location = New System.Drawing.Point(29, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 38)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "TANGGAL LAHIR"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.Crimson
        Me.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_browse.Location = New System.Drawing.Point(640, 352)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(141, 48)
        Me.btn_browse.TabIndex = 21
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'telepon_TXT
        '
        Me.telepon_TXT.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telepon_TXT.Location = New System.Drawing.Point(26, 263)
        Me.telepon_TXT.Name = "telepon_TXT"
        Me.telepon_TXT.Size = New System.Drawing.Size(316, 45)
        Me.telepon_TXT.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Crimson
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label6.Location = New System.Drawing.Point(26, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 38)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "TELEPON"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_daftar
        '
        Me.btn_daftar.BackColor = System.Drawing.Color.Crimson
        Me.btn_daftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_daftar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daftar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_daftar.Location = New System.Drawing.Point(507, 506)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(226, 48)
        Me.btn_daftar.TabIndex = 18
        Me.btn_daftar.Text = "DAFTAR"
        Me.btn_daftar.UseVisualStyleBackColor = False
        '
        'foto_daftar
        '
        Me.foto_daftar.Location = New System.Drawing.Point(403, 302)
        Me.foto_daftar.Name = "foto_daftar"
        Me.foto_daftar.Size = New System.Drawing.Size(205, 170)
        Me.foto_daftar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto_daftar.TabIndex = 17
        Me.foto_daftar.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Crimson
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label5.Location = New System.Drawing.Point(404, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 38)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "FOTO PROFIL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Coral
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(875, 54)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DAFTAR AKUN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RB_cewe
        '
        Me.RB_cewe.AutoSize = True
        Me.RB_cewe.BackColor = System.Drawing.Color.Crimson
        Me.RB_cewe.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_cewe.ForeColor = System.Drawing.Color.Cornsilk
        Me.RB_cewe.Location = New System.Drawing.Point(177, 517)
        Me.RB_cewe.Name = "RB_cewe"
        Me.RB_cewe.Size = New System.Drawing.Size(143, 32)
        Me.RB_cewe.TabIndex = 14
        Me.RB_cewe.TabStop = True
        Me.RB_cewe.Text = "Perempuan"
        Me.RB_cewe.UseVisualStyleBackColor = False
        '
        'RB_Laki
        '
        Me.RB_Laki.AutoSize = True
        Me.RB_Laki.BackColor = System.Drawing.Color.Crimson
        Me.RB_Laki.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Laki.ForeColor = System.Drawing.Color.Cornsilk
        Me.RB_Laki.Location = New System.Drawing.Point(31, 517)
        Me.RB_Laki.Name = "RB_Laki"
        Me.RB_Laki.Size = New System.Drawing.Size(117, 32)
        Me.RB_Laki.TabIndex = 13
        Me.RB_Laki.TabStop = True
        Me.RB_Laki.Text = "Laki-laki"
        Me.RB_Laki.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(31, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "JENIS KELAMIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbpass
        '
        Me.cbpass.AutoSize = True
        Me.cbpass.BackColor = System.Drawing.Color.Crimson
        Me.cbpass.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpass.ForeColor = System.Drawing.Color.Cornsilk
        Me.cbpass.Location = New System.Drawing.Point(402, 199)
        Me.cbpass.Name = "cbpass"
        Me.cbpass.Size = New System.Drawing.Size(177, 25)
        Me.cbpass.TabIndex = 11
        Me.cbpass.Text = "SHOW PASSWORD"
        Me.cbpass.UseVisualStyleBackColor = False
        '
        'password_TXT
        '
        Me.password_TXT.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_TXT.Location = New System.Drawing.Point(402, 142)
        Me.password_TXT.Name = "password_TXT"
        Me.password_TXT.Size = New System.Drawing.Size(352, 45)
        Me.password_TXT.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label4.Location = New System.Drawing.Point(402, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PASSWORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'username_TXT
        '
        Me.username_TXT.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_TXT.Location = New System.Drawing.Point(26, 142)
        Me.username_TXT.Name = "username_TXT"
        Me.username_TXT.Size = New System.Drawing.Size(316, 45)
        Me.username_TXT.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(26, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "USERNAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.path_txt)
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Controls.Add(Me.dtpTangalLahir)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btn_browse)
        Me.Panel1.Controls.Add(Me.telepon_TXT)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_daftar)
        Me.Panel1.Controls.Add(Me.foto_daftar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RB_cewe)
        Me.Panel1.Controls.Add(Me.RB_Laki)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbpass)
        Me.Panel1.Controls.Add(Me.password_TXT)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.username_TXT)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(44, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 598)
        Me.Panel1.TabIndex = 1
        '
        'path_txt
        '
        Me.path_txt.Location = New System.Drawing.Point(600, 251)
        Me.path_txt.Name = "path_txt"
        Me.path_txt.Size = New System.Drawing.Size(181, 26)
        Me.path_txt.TabIndex = 25
        Me.path_txt.Visible = False
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Crimson
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_kembali.Location = New System.Drawing.Point(715, 71)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(157, 53)
        Me.btn_kembali.TabIndex = 24
        Me.btn_kembali.Text = "KEMBALI"
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(968, 719)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Daftar"
        Me.Text = "Form1"
        CType(Me.foto_daftar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dtpTangalLahir As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents telepon_TXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_daftar As Button
    Friend WithEvents foto_daftar As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RB_cewe As RadioButton
    Friend WithEvents RB_Laki As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbpass As CheckBox
    Friend WithEvents password_TXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents username_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_kembali As Button
    Friend WithEvents path_txt As TextBox
End Class
