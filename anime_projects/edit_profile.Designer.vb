<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edit_profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_profile))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.edit_path_txt = New System.Windows.Forms.TextBox()
        Me.btn_edit_simpan = New System.Windows.Forms.Button()
        Me.btn_edit_browse = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.foto_edit = New System.Windows.Forms.PictureBox()
        Me.edit_RB_perempuan = New System.Windows.Forms.RadioButton()
        Me.edit_rb_laki_laki = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_edit_tanggal_lahir = New System.Windows.Forms.DateTimePicker()
        Me.edit_telepon_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.edit_cb_password = New System.Windows.Forms.CheckBox()
        Me.edit_password_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.edit_username_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.foto_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.edit_path_txt)
        Me.Panel1.Controls.Add(Me.btn_edit_simpan)
        Me.Panel1.Controls.Add(Me.btn_edit_browse)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.foto_edit)
        Me.Panel1.Controls.Add(Me.edit_RB_perempuan)
        Me.Panel1.Controls.Add(Me.edit_rb_laki_laki)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtp_edit_tanggal_lahir)
        Me.Panel1.Controls.Add(Me.edit_telepon_txt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.edit_cb_password)
        Me.Panel1.Controls.Add(Me.edit_password_txt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.edit_username_txt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 605)
        Me.Panel1.TabIndex = 0
        '
        'edit_path_txt
        '
        Me.edit_path_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_path_txt.Location = New System.Drawing.Point(616, 254)
        Me.edit_path_txt.Name = "edit_path_txt"
        Me.edit_path_txt.Size = New System.Drawing.Size(122, 39)
        Me.edit_path_txt.TabIndex = 18
        Me.edit_path_txt.Visible = False
        '
        'btn_edit_simpan
        '
        Me.btn_edit_simpan.BackColor = System.Drawing.Color.Crimson
        Me.btn_edit_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_simpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_simpan.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_edit_simpan.Location = New System.Drawing.Point(620, 427)
        Me.btn_edit_simpan.Name = "btn_edit_simpan"
        Me.btn_edit_simpan.Size = New System.Drawing.Size(118, 53)
        Me.btn_edit_simpan.TabIndex = 17
        Me.btn_edit_simpan.Text = "SIMPAN"
        Me.btn_edit_simpan.UseVisualStyleBackColor = False
        '
        'btn_edit_browse
        '
        Me.btn_edit_browse.BackColor = System.Drawing.Color.Crimson
        Me.btn_edit_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_browse.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_browse.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_edit_browse.Location = New System.Drawing.Point(620, 304)
        Me.btn_edit_browse.Name = "btn_edit_browse"
        Me.btn_edit_browse.Size = New System.Drawing.Size(118, 53)
        Me.btn_edit_browse.TabIndex = 16
        Me.btn_edit_browse.Text = "BROWSE"
        Me.btn_edit_browse.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(388, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 32)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "FOTO PROFILE"
        '
        'foto_edit
        '
        Me.foto_edit.Location = New System.Drawing.Point(383, 304)
        Me.foto_edit.Name = "foto_edit"
        Me.foto_edit.Size = New System.Drawing.Size(188, 176)
        Me.foto_edit.TabIndex = 14
        Me.foto_edit.TabStop = False
        '
        'edit_RB_perempuan
        '
        Me.edit_RB_perempuan.AutoSize = True
        Me.edit_RB_perempuan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_RB_perempuan.ForeColor = System.Drawing.Color.Crimson
        Me.edit_RB_perempuan.Location = New System.Drawing.Point(159, 304)
        Me.edit_RB_perempuan.Name = "edit_RB_perempuan"
        Me.edit_RB_perempuan.Size = New System.Drawing.Size(159, 32)
        Me.edit_RB_perempuan.TabIndex = 13
        Me.edit_RB_perempuan.TabStop = True
        Me.edit_RB_perempuan.Text = "PEREMPUAN"
        Me.edit_RB_perempuan.UseVisualStyleBackColor = True
        '
        'edit_rb_laki_laki
        '
        Me.edit_rb_laki_laki.AutoSize = True
        Me.edit_rb_laki_laki.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_rb_laki_laki.ForeColor = System.Drawing.Color.Crimson
        Me.edit_rb_laki_laki.Location = New System.Drawing.Point(10, 304)
        Me.edit_rb_laki_laki.Name = "edit_rb_laki_laki"
        Me.edit_rb_laki_laki.Size = New System.Drawing.Size(143, 32)
        Me.edit_rb_laki_laki.TabIndex = 12
        Me.edit_rb_laki_laki.TabStop = True
        Me.edit_rb_laki_laki.Text = "LAKI - LAKI"
        Me.edit_rb_laki_laki.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(4, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "JENIS KELAMIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(423, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TANGGAL LAHIR"
        '
        'dtp_edit_tanggal_lahir
        '
        Me.dtp_edit_tanggal_lahir.CalendarFont = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_edit_tanggal_lahir.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_edit_tanggal_lahir.Location = New System.Drawing.Point(632, 181)
        Me.dtp_edit_tanggal_lahir.Name = "dtp_edit_tanggal_lahir"
        Me.dtp_edit_tanggal_lahir.Size = New System.Drawing.Size(203, 29)
        Me.dtp_edit_tanggal_lahir.TabIndex = 9
        '
        'edit_telepon_txt
        '
        Me.edit_telepon_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_telepon_txt.Location = New System.Drawing.Point(574, 114)
        Me.edit_telepon_txt.Name = "edit_telepon_txt"
        Me.edit_telepon_txt.Size = New System.Drawing.Size(261, 39)
        Me.edit_telepon_txt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(423, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TELEPON"
        '
        'edit_cb_password
        '
        Me.edit_cb_password.AutoSize = True
        Me.edit_cb_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_cb_password.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_cb_password.ForeColor = System.Drawing.Color.Crimson
        Me.edit_cb_password.Location = New System.Drawing.Point(10, 218)
        Me.edit_cb_password.Name = "edit_cb_password"
        Me.edit_cb_password.Size = New System.Drawing.Size(175, 25)
        Me.edit_cb_password.TabIndex = 6
        Me.edit_cb_password.Text = "SHOW_PASSWORD"
        Me.edit_cb_password.UseVisualStyleBackColor = True
        '
        'edit_password_txt
        '
        Me.edit_password_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_password_txt.Location = New System.Drawing.Point(154, 171)
        Me.edit_password_txt.Name = "edit_password_txt"
        Me.edit_password_txt.Size = New System.Drawing.Size(261, 39)
        Me.edit_password_txt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(3, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD"
        '
        'edit_username_txt
        '
        Me.edit_username_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_username_txt.Location = New System.Drawing.Point(154, 111)
        Me.edit_username_txt.Name = "edit_username_txt"
        Me.edit_username_txt.Size = New System.Drawing.Size(261, 39)
        Me.edit_username_txt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(3, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USERNAME"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button1.Location = New System.Drawing.Point(0, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Coral
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(847, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EDIT PROFILE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'edit_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(930, 667)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "edit_profile"
        Me.Text = "edit_profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.foto_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_edit_simpan As Button
    Friend WithEvents btn_edit_browse As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents foto_edit As PictureBox
    Friend WithEvents edit_RB_perempuan As RadioButton
    Friend WithEvents edit_rb_laki_laki As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_edit_tanggal_lahir As DateTimePicker
    Friend WithEvents edit_telepon_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents edit_cb_password As CheckBox
    Friend WithEvents edit_password_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents edit_username_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents edit_path_txt As TextBox
End Class
