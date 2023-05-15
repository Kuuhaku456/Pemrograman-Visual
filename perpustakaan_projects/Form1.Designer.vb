<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.surel_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.alamat_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nomor_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fakultas_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nim_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 103)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(154, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PENDAFTARAN MEMBER PERPUSTAKAAN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.Controls.Add(Me.dtp_tanggal)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btn_submit)
        Me.Panel2.Controls.Add(Me.btn_browse)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBoxProfile)
        Me.Panel2.Controls.Add(Me.surel_txt)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.alamat_txt)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.nomor_txt)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.fakultas_txt)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.nim_txt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.nama_txt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(865, 468)
        Me.Panel2.TabIndex = 1
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.Crimson
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_submit.Location = New System.Drawing.Point(640, 353)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(138, 63)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "SUBMIT"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.Crimson
        Me.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_browse.Location = New System.Drawing.Point(645, 271)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(129, 43)
        Me.btn_browse.TabIndex = 14
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label8.Location = New System.Drawing.Point(615, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 32)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "FOTO PROFILE"
        '
        'PictureBoxProfile
        '
        Me.PictureBoxProfile.Location = New System.Drawing.Point(594, 60)
        Me.PictureBoxProfile.Name = "PictureBoxProfile"
        Me.PictureBoxProfile.Size = New System.Drawing.Size(219, 205)
        Me.PictureBoxProfile.TabIndex = 12
        Me.PictureBoxProfile.TabStop = False
        '
        'surel_txt
        '
        Me.surel_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surel_txt.Location = New System.Drawing.Point(231, 353)
        Me.surel_txt.Name = "surel_txt"
        Me.surel_txt.Size = New System.Drawing.Size(308, 39)
        Me.surel_txt.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label7.Location = New System.Drawing.Point(6, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 32)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "E-MAIL"
        '
        'alamat_txt
        '
        Me.alamat_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.alamat_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat_txt.Location = New System.Drawing.Point(231, 292)
        Me.alamat_txt.Name = "alamat_txt"
        Me.alamat_txt.Size = New System.Drawing.Size(308, 39)
        Me.alamat_txt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label6.Location = New System.Drawing.Point(6, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 32)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ALAMAT"
        '
        'nomor_txt
        '
        Me.nomor_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nomor_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomor_txt.Location = New System.Drawing.Point(231, 226)
        Me.nomor_txt.Name = "nomor_txt"
        Me.nomor_txt.Size = New System.Drawing.Size(308, 39)
        Me.nomor_txt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(6, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NOMOR TELEPON"
        '
        'fakultas_txt
        '
        Me.fakultas_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fakultas_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fakultas_txt.Location = New System.Drawing.Point(231, 160)
        Me.fakultas_txt.Name = "fakultas_txt"
        Me.fakultas_txt.Size = New System.Drawing.Size(308, 39)
        Me.fakultas_txt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(6, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "FAKULTAS "
        '
        'nim_txt
        '
        Me.nim_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nim_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nim_txt.Location = New System.Drawing.Point(231, 94)
        Me.nim_txt.Name = "nim_txt"
        Me.nim_txt.Size = New System.Drawing.Size(308, 39)
        Me.nim_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(6, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIM "
        '
        'nama_txt
        '
        Me.nama_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nama_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_txt.Location = New System.Drawing.Point(231, 25)
        Me.nama_txt.Name = "nama_txt"
        Me.nama_txt.Size = New System.Drawing.Size(308, 39)
        Me.nama_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NAMA "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label9.Location = New System.Drawing.Point(6, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 32)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "TANGGAL LAHIR"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_tanggal.Location = New System.Drawing.Point(231, 415)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(308, 34)
        Me.dtp_tanggal.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 571)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "PENDAFTARAN MEMBER PERPUSTAKAAN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents surel_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents alamat_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nomor_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fakultas_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nim_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nama_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_submit As Button
    Friend WithEvents btn_browse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents Label9 As Label
End Class
