<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class anime_favorit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.data_anime = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pb_favorit = New System.Windows.Forms.PictureBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.episode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_rilis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinopsis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btn_hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_favorit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cornsilk
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1283, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ANIME FAVORIT ANDA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(131, 110)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(341, 39)
        Me.txt_cari.TabIndex = 66
        '
        'data_anime
        '
        Me.data_anime.AllowUserToAddRows = False
        Me.data_anime.AllowUserToDeleteRows = False
        Me.data_anime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_anime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.judul, Me.studio, Me.rating, Me.tipe, Me.episode, Me.genre, Me.tanggal_rilis, Me.sinopsis, Me.gambar, Me.btn_detail, Me.btn_hapus})
        Me.data_anime.Location = New System.Drawing.Point(67, 161)
        Me.data_anime.MultiSelect = False
        Me.data_anime.Name = "data_anime"
        Me.data_anime.RowHeadersVisible = False
        Me.data_anime.RowHeadersWidth = 62
        Me.data_anime.RowTemplate.Height = 28
        Me.data_anime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_anime.Size = New System.Drawing.Size(750, 389)
        Me.data_anime.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label9.Location = New System.Drawing.Point(62, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 30)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "CARI"
        '
        'pb_favorit
        '
        Me.pb_favorit.BackColor = System.Drawing.Color.DarkOrange
        Me.pb_favorit.Location = New System.Drawing.Point(873, 103)
        Me.pb_favorit.Name = "pb_favorit"
        Me.pb_favorit.Size = New System.Drawing.Size(339, 447)
        Me.pb_favorit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_favorit.TabIndex = 63
        Me.pb_favorit.TabStop = False
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 150
        '
        'judul
        '
        Me.judul.HeaderText = "JUDUL ANIME"
        Me.judul.MinimumWidth = 8
        Me.judul.Name = "judul"
        Me.judul.ReadOnly = True
        Me.judul.Width = 410
        '
        'studio
        '
        Me.studio.HeaderText = "studio"
        Me.studio.MinimumWidth = 8
        Me.studio.Name = "studio"
        Me.studio.ReadOnly = True
        Me.studio.Visible = False
        Me.studio.Width = 150
        '
        'rating
        '
        Me.rating.HeaderText = "RATING"
        Me.rating.MinimumWidth = 8
        Me.rating.Name = "rating"
        Me.rating.ReadOnly = True
        Me.rating.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rating.Width = 115
        '
        'tipe
        '
        Me.tipe.HeaderText = "tipe"
        Me.tipe.MinimumWidth = 8
        Me.tipe.Name = "tipe"
        Me.tipe.ReadOnly = True
        Me.tipe.Visible = False
        Me.tipe.Width = 150
        '
        'episode
        '
        Me.episode.HeaderText = "EPISODE"
        Me.episode.MinimumWidth = 8
        Me.episode.Name = "episode"
        Me.episode.ReadOnly = True
        Me.episode.Visible = False
        Me.episode.Width = 120
        '
        'genre
        '
        Me.genre.HeaderText = "genre"
        Me.genre.MinimumWidth = 8
        Me.genre.Name = "genre"
        Me.genre.ReadOnly = True
        Me.genre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.genre.Visible = False
        Me.genre.Width = 150
        '
        'tanggal_rilis
        '
        Me.tanggal_rilis.HeaderText = "tanggal_rilis"
        Me.tanggal_rilis.MinimumWidth = 8
        Me.tanggal_rilis.Name = "tanggal_rilis"
        Me.tanggal_rilis.ReadOnly = True
        Me.tanggal_rilis.Visible = False
        Me.tanggal_rilis.Width = 150
        '
        'sinopsis
        '
        Me.sinopsis.HeaderText = "sinopsis"
        Me.sinopsis.MinimumWidth = 8
        Me.sinopsis.Name = "sinopsis"
        Me.sinopsis.ReadOnly = True
        Me.sinopsis.Visible = False
        Me.sinopsis.Width = 1000
        '
        'gambar
        '
        Me.gambar.HeaderText = "gambar"
        Me.gambar.MinimumWidth = 8
        Me.gambar.Name = "gambar"
        Me.gambar.ReadOnly = True
        Me.gambar.Visible = False
        Me.gambar.Width = 150
        '
        'btn_detail
        '
        Me.btn_detail.HeaderText = "DETAIL"
        Me.btn_detail.MinimumWidth = 8
        Me.btn_detail.Name = "btn_detail"
        Me.btn_detail.ReadOnly = True
        Me.btn_detail.Text = "Detail"
        Me.btn_detail.Width = 112
        '
        'btn_hapus
        '
        Me.btn_hapus.HeaderText = "REMOVE"
        Me.btn_hapus.MinimumWidth = 8
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.ReadOnly = True
        Me.btn_hapus.Width = 150
        '
        'anime_favorit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1283, 590)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.data_anime)
        Me.Controls.Add(Me.pb_favorit)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "anime_favorit"
        Me.Text = "anime_favorit"
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_favorit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents data_anime As DataGridView
    Friend WithEvents pb_favorit As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents studio As DataGridViewTextBoxColumn
    Friend WithEvents rating As DataGridViewTextBoxColumn
    Friend WithEvents tipe As DataGridViewTextBoxColumn
    Friend WithEvents episode As DataGridViewTextBoxColumn
    Friend WithEvents genre As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_rilis As DataGridViewTextBoxColumn
    Friend WithEvents sinopsis As DataGridViewTextBoxColumn
    Friend WithEvents gambar As DataGridViewTextBoxColumn
    Friend WithEvents btn_detail As DataGridViewButtonColumn
    Friend WithEvents btn_hapus As DataGridViewButtonColumn
End Class
