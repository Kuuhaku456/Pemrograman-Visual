<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kartuvb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.nim_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nama_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fakultas_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.alamat_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomor_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBoxQRCODE = New System.Windows.Forms.PictureBox()
        Me.PictureBoxBarcode = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(676, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KARTU MEMBER PERPUSTAKAAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBoxProfile
        '
        Me.PictureBoxProfile.Location = New System.Drawing.Point(6, 40)
        Me.PictureBoxProfile.Name = "PictureBoxProfile"
        Me.PictureBoxProfile.Size = New System.Drawing.Size(210, 232)
        Me.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProfile.TabIndex = 1
        Me.PictureBoxProfile.TabStop = False
        '
        'nim_txt
        '
        Me.nim_txt.BackColor = System.Drawing.SystemColors.Control
        Me.nim_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nim_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nim_txt.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nim_txt.Location = New System.Drawing.Point(376, 44)
        Me.nim_txt.Name = "nim_txt"
        Me.nim_txt.Size = New System.Drawing.Size(233, 22)
        Me.nim_txt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(224, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIM"
        '
        'nama_txt
        '
        Me.nama_txt.BackColor = System.Drawing.SystemColors.Control
        Me.nama_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nama_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nama_txt.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_txt.Location = New System.Drawing.Point(376, 81)
        Me.nama_txt.Name = "nama_txt"
        Me.nama_txt.Size = New System.Drawing.Size(233, 22)
        Me.nama_txt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(224, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NAMA"
        '
        'fakultas_txt
        '
        Me.fakultas_txt.BackColor = System.Drawing.SystemColors.Control
        Me.fakultas_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fakultas_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fakultas_txt.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fakultas_txt.Location = New System.Drawing.Point(376, 124)
        Me.fakultas_txt.Name = "fakultas_txt"
        Me.fakultas_txt.Size = New System.Drawing.Size(233, 22)
        Me.fakultas_txt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(224, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FAKULTAS"
        '
        'alamat_txt
        '
        Me.alamat_txt.BackColor = System.Drawing.SystemColors.Control
        Me.alamat_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.alamat_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.alamat_txt.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat_txt.Location = New System.Drawing.Point(376, 164)
        Me.alamat_txt.Name = "alamat_txt"
        Me.alamat_txt.Size = New System.Drawing.Size(233, 22)
        Me.alamat_txt.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(224, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ALAMAT"
        '
        'nomor_txt
        '
        Me.nomor_txt.BackColor = System.Drawing.SystemColors.Control
        Me.nomor_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nomor_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nomor_txt.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomor_txt.Location = New System.Drawing.Point(376, 201)
        Me.nomor_txt.Name = "nomor_txt"
        Me.nomor_txt.Size = New System.Drawing.Size(233, 22)
        Me.nomor_txt.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(224, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "NOMOR TELEPON"
        '
        'email_txt
        '
        Me.email_txt.BackColor = System.Drawing.SystemColors.Control
        Me.email_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.email_txt.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.Location = New System.Drawing.Point(376, 236)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(233, 22)
        Me.email_txt.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(224, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "E-MAIL"
        '
        'PictureBoxQRCODE
        '
        Me.PictureBoxQRCODE.Location = New System.Drawing.Point(6, 315)
        Me.PictureBoxQRCODE.Name = "PictureBoxQRCODE"
        Me.PictureBoxQRCODE.Size = New System.Drawing.Size(210, 128)
        Me.PictureBoxQRCODE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxQRCODE.TabIndex = 14
        Me.PictureBoxQRCODE.TabStop = False
        '
        'PictureBoxBarcode
        '
        Me.PictureBoxBarcode.Location = New System.Drawing.Point(228, 287)
        Me.PictureBoxBarcode.Name = "PictureBoxBarcode"
        Me.PictureBoxBarcode.Size = New System.Drawing.Size(440, 156)
        Me.PictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxBarcode.TabIndex = 15
        Me.PictureBoxBarcode.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 20)
        Me.Panel1.TabIndex = 16
        '
        'PrintDocument1
        '
        '
        'txt_tanggal
        '
        Me.txt_tanggal.BackColor = System.Drawing.SystemColors.Control
        Me.txt_tanggal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tanggal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tanggal.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tanggal.Location = New System.Drawing.Point(6, 287)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(210, 22)
        Me.txt_tanggal.TabIndex = 17
        '
        'Kartuvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 469)
        Me.Controls.Add(Me.txt_tanggal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBoxBarcode)
        Me.Controls.Add(Me.PictureBoxQRCODE)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nomor_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.alamat_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fakultas_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nama_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nim_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBoxProfile)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kartuvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARTU"
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents nim_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nama_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fakultas_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents alamat_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nomor_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents email_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBoxQRCODE As PictureBox
    Friend WithEvents PictureBoxBarcode As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txt_tanggal As TextBox
End Class
