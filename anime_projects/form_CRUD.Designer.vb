<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_CRUD
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
        Me.data_anime = New System.Windows.Forms.DataGridView()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtptanggal_rilis = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.genre_TXT = New System.Windows.Forms.TextBox()
        Me.btn_addgenre = New System.Windows.Forms.Button()
        Me.cb_genre = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.episode_TXT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_tipe = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.studio_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.judul_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.path_txt = New System.Windows.Forms.TextBox()
        Me.SINOPSIS_TXT = New System.Windows.Forms.RichTextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.episode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinopsis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating_txt = New System.Windows.Forms.TextBox()
        Me.cb_hari = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_anime
        '
        Me.data_anime.AllowUserToAddRows = False
        Me.data_anime.AllowUserToDeleteRows = False
        Me.data_anime.AllowUserToResizeColumns = False
        Me.data_anime.AllowUserToResizeRows = False
        Me.data_anime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_anime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.judul, Me.studio, Me.rating, Me.tipe, Me.status, Me.episode, Me.genre, Me.tanggal, Me.sinopsis, Me.gambar, Me.hari})
        Me.data_anime.Location = New System.Drawing.Point(456, 378)
        Me.data_anime.MultiSelect = False
        Me.data_anime.Name = "data_anime"
        Me.data_anime.RowHeadersVisible = False
        Me.data_anime.RowHeadersWidth = 62
        Me.data_anime.RowTemplate.Height = 28
        Me.data_anime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_anime.Size = New System.Drawing.Size(565, 201)
        Me.data_anime.TabIndex = 53
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.Coral
        Me.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_browse.Location = New System.Drawing.Point(1028, 259)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(142, 57)
        Me.btn_browse.TabIndex = 52
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(57, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 30)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "SINOPSIS"
        '
        'btn_log_out
        '
        Me.btn_log_out.BackColor = System.Drawing.Color.Crimson
        Me.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log_out.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_log_out.Location = New System.Drawing.Point(972, 0)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Size = New System.Drawing.Size(142, 49)
        Me.btn_log_out.TabIndex = 57
        Me.btn_log_out.Text = "LOG OUT"
        Me.btn_log_out.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.Coral
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_hapus.Location = New System.Drawing.Point(1027, 519)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(143, 48)
        Me.btn_hapus.TabIndex = 56
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.Coral
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_ubah.Location = New System.Drawing.Point(1027, 450)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(143, 48)
        Me.btn_ubah.TabIndex = 55
        Me.btn_ubah.Text = "UPDATE"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.Coral
        Me.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_tambah.Location = New System.Drawing.Point(1027, 378)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(143, 50)
        Me.btn_tambah.TabIndex = 54
        Me.btn_tambah.Text = "TAMBAH"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label11.Location = New System.Drawing.Point(599, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 30)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "GAMBAR ANIME"
        '
        'dtptanggal_rilis
        '
        Me.dtptanggal_rilis.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptanggal_rilis.Location = New System.Drawing.Point(798, 197)
        Me.dtptanggal_rilis.Name = "dtptanggal_rilis"
        Me.dtptanggal_rilis.Size = New System.Drawing.Size(372, 34)
        Me.dtptanggal_rilis.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label10.Location = New System.Drawing.Point(599, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 30)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "TANGGAL RILIS"
        '
        'genre_TXT
        '
        Me.genre_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genre_TXT.Location = New System.Drawing.Point(604, 126)
        Me.genre_TXT.Name = "genre_TXT"
        Me.genre_TXT.ReadOnly = True
        Me.genre_TXT.Size = New System.Drawing.Size(566, 39)
        Me.genre_TXT.TabIndex = 47
        '
        'btn_addgenre
        '
        Me.btn_addgenre.BackColor = System.Drawing.Color.Coral
        Me.btn_addgenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addgenre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addgenre.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_addgenre.Location = New System.Drawing.Point(1101, 63)
        Me.btn_addgenre.Name = "btn_addgenre"
        Me.btn_addgenre.Size = New System.Drawing.Size(69, 57)
        Me.btn_addgenre.TabIndex = 46
        Me.btn_addgenre.Text = "+"
        Me.btn_addgenre.UseVisualStyleBackColor = False
        '
        'cb_genre
        '
        Me.cb_genre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_genre.FormattingEnabled = True
        Me.cb_genre.Items.AddRange(New Object() {"ACTION", "ADVENTURE", "AVANTS GARDE", "COMEDY", "DEMONS", "DRAMA", "ECCHI", "FANTASY", "GAME", "HAREM", "HISTORICAL", "JOSEI", "MAGIC", "MARTIAL ARTS", "MECHA", "MILITARY", "MUSIC", "PSYCHOLOGICAL", "PARODY", "POLICE", "ROMANCE", "SAMURAI", "SCHOOL", "SCI-FI", "SEINEN", "SHOUJO", "SHOUJO AI", "SHOUNEN", "SLICE OF LIFE", "SPORTS", "SPACE", "SUPER POWER", "SUPERNATURAL", "THRILLER", "VAMPIRE"})
        Me.cb_genre.Location = New System.Drawing.Point(798, 68)
        Me.cb_genre.Name = "cb_genre"
        Me.cb_genre.Size = New System.Drawing.Size(213, 40)
        Me.cb_genre.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label9.Location = New System.Drawing.Point(599, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 30)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "GENRE ANIME"
        '
        'episode_TXT
        '
        Me.episode_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.episode_TXT.Location = New System.Drawing.Point(256, 277)
        Me.episode_TXT.Name = "episode_TXT"
        Me.episode_TXT.Size = New System.Drawing.Size(291, 39)
        Me.episode_TXT.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label8.Location = New System.Drawing.Point(57, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 30)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "EPISODE ANIME"
        '
        'cb_tipe
        '
        Me.cb_tipe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tipe.FormattingEnabled = True
        Me.cb_tipe.Items.AddRange(New Object() {"SERIES", "MOVIE"})
        Me.cb_tipe.Location = New System.Drawing.Point(256, 221)
        Me.cb_tipe.Name = "cb_tipe"
        Me.cb_tipe.Size = New System.Drawing.Size(158, 40)
        Me.cb_tipe.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label6.Location = New System.Drawing.Point(57, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 30)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "TIPE ANIME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(57, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 30)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "RATING ANIME"
        '
        'studio_TXT
        '
        Me.studio_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.studio_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studio_TXT.Location = New System.Drawing.Point(256, 117)
        Me.studio_TXT.Name = "studio_TXT"
        Me.studio_TXT.Size = New System.Drawing.Size(291, 39)
        Me.studio_TXT.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(57, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 30)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "STUDIO ANIME"
        '
        'judul_TXT
        '
        Me.judul_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.judul_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul_TXT.Location = New System.Drawing.Point(256, 68)
        Me.judul_TXT.Name = "judul_TXT"
        Me.judul_TXT.Size = New System.Drawing.Size(291, 39)
        Me.judul_TXT.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(57, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 30)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "JUDUL ANIME"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1204, 51)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CRUD ONGOING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'id_txt
        '
        Me.id_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_txt.Location = New System.Drawing.Point(8, 6)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(83, 39)
        Me.id_txt.TabIndex = 60
        Me.id_txt.Visible = False
        '
        'path_txt
        '
        Me.path_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_txt.Location = New System.Drawing.Point(798, 268)
        Me.path_txt.Name = "path_txt"
        Me.path_txt.ReadOnly = True
        Me.path_txt.Size = New System.Drawing.Size(213, 39)
        Me.path_txt.TabIndex = 61
        '
        'SINOPSIS_TXT
        '
        Me.SINOPSIS_TXT.Location = New System.Drawing.Point(62, 378)
        Me.SINOPSIS_TXT.Name = "SINOPSIS_TXT"
        Me.SINOPSIS_TXT.Size = New System.Drawing.Size(374, 201)
        Me.SINOPSIS_TXT.TabIndex = 62
        Me.SINOPSIS_TXT.Text = ""
        '
        'id
        '
        Me.id.HeaderText = "ID"
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
        Me.judul.Width = 150
        '
        'studio
        '
        Me.studio.HeaderText = "STUDIO ANIME"
        Me.studio.MinimumWidth = 8
        Me.studio.Name = "studio"
        Me.studio.ReadOnly = True
        Me.studio.Width = 150
        '
        'rating
        '
        Me.rating.HeaderText = "RATING"
        Me.rating.MinimumWidth = 8
        Me.rating.Name = "rating"
        Me.rating.ReadOnly = True
        Me.rating.Visible = False
        Me.rating.Width = 115
        '
        'tipe
        '
        Me.tipe.HeaderText = "TIPE ANIME"
        Me.tipe.MinimumWidth = 8
        Me.tipe.Name = "tipe"
        Me.tipe.ReadOnly = True
        Me.tipe.Visible = False
        Me.tipe.Width = 150
        '
        'status
        '
        Me.status.HeaderText = "STATUS ANIME"
        Me.status.MinimumWidth = 8
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Visible = False
        Me.status.Width = 150
        '
        'episode
        '
        Me.episode.HeaderText = "EPISODE "
        Me.episode.MinimumWidth = 8
        Me.episode.Name = "episode"
        Me.episode.ReadOnly = True
        Me.episode.Width = 120
        '
        'genre
        '
        Me.genre.HeaderText = "GENRE ANIME"
        Me.genre.MinimumWidth = 8
        Me.genre.Name = "genre"
        Me.genre.ReadOnly = True
        Me.genre.Visible = False
        Me.genre.Width = 150
        '
        'tanggal
        '
        Me.tanggal.HeaderText = "TANGGAL RILIS"
        Me.tanggal.MinimumWidth = 8
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        Me.tanggal.Visible = False
        Me.tanggal.Width = 150
        '
        'sinopsis
        '
        Me.sinopsis.HeaderText = "SINOPSIS"
        Me.sinopsis.MinimumWidth = 8
        Me.sinopsis.Name = "sinopsis"
        Me.sinopsis.ReadOnly = True
        Me.sinopsis.Visible = False
        Me.sinopsis.Width = 150
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
        'hari
        '
        Me.hari.HeaderText = "HARI"
        Me.hari.MinimumWidth = 8
        Me.hari.Name = "hari"
        Me.hari.ReadOnly = True
        Me.hari.Width = 150
        '
        'rating_txt
        '
        Me.rating_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rating_txt.Location = New System.Drawing.Point(256, 170)
        Me.rating_txt.Name = "rating_txt"
        Me.rating_txt.Size = New System.Drawing.Size(291, 39)
        Me.rating_txt.TabIndex = 63
        '
        'cb_hari
        '
        Me.cb_hari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_hari.FormattingEnabled = True
        Me.cb_hari.Items.AddRange(New Object() {"SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU", "MINGGU"})
        Me.cb_hari.Location = New System.Drawing.Point(798, 326)
        Me.cb_hari.Name = "cb_hari"
        Me.cb_hari.Size = New System.Drawing.Size(158, 40)
        Me.cb_hari.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label7.Location = New System.Drawing.Point(599, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 30)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "HARI TAYANG"
        '
        'form_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1204, 640)
        Me.Controls.Add(Me.cb_hari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rating_txt)
        Me.Controls.Add(Me.SINOPSIS_TXT)
        Me.Controls.Add(Me.path_txt)
        Me.Controls.Add(Me.id_txt)
        Me.Controls.Add(Me.data_anime)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_log_out)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtptanggal_rilis)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.genre_TXT)
        Me.Controls.Add(Me.btn_addgenre)
        Me.Controls.Add(Me.cb_genre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.episode_TXT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cb_tipe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.studio_TXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.judul_TXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "form_CRUD"
        Me.Text = "form_CRUD"
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_anime As DataGridView
    Friend WithEvents btn_browse As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_log_out As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents dtptanggal_rilis As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents genre_TXT As TextBox
    Friend WithEvents btn_addgenre As Button
    Friend WithEvents cb_genre As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents episode_TXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cb_tipe As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents studio_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents judul_TXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents id_txt As TextBox
    Friend WithEvents path_txt As TextBox
    Friend WithEvents SINOPSIS_TXT As RichTextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents studio As DataGridViewTextBoxColumn
    Friend WithEvents rating As DataGridViewTextBoxColumn
    Friend WithEvents tipe As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents episode As DataGridViewTextBoxColumn
    Friend WithEvents genre As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents sinopsis As DataGridViewTextBoxColumn
    Friend WithEvents gambar As DataGridViewTextBoxColumn
    Friend WithEvents hari As DataGridViewTextBoxColumn
    Friend WithEvents rating_txt As TextBox
    Friend WithEvents cb_hari As ComboBox
    Friend WithEvents Label7 As Label
End Class
