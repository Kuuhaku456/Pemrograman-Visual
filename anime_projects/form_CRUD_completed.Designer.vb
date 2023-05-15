<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_CRUD_completed
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
        Me.data_anime_completed = New System.Windows.Forms.DataGridView()
        Me.id_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studio_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.episode_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinopsis_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.path_txt = New System.Windows.Forms.TextBox()
        Me.id_txt = New System.Windows.Forms.TextBox()
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
        Me.studio_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.judul_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SINOPSIS_TXT = New System.Windows.Forms.RichTextBox()
        Me.rating_txt = New System.Windows.Forms.TextBox()
        CType(Me.data_anime_completed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_anime_completed
        '
        Me.data_anime_completed.AllowUserToAddRows = False
        Me.data_anime_completed.AllowUserToDeleteRows = False
        Me.data_anime_completed.AllowUserToResizeColumns = False
        Me.data_anime_completed.AllowUserToResizeRows = False
        Me.data_anime_completed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_anime_completed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_completed, Me.judul_completed, Me.studio_completed, Me.rating_completed, Me.tipe_completed, Me.status_completed, Me.episode_completed, Me.genre_completed, Me.tanggal_completed, Me.sinopsis_completed, Me.gambar_completed})
        Me.data_anime_completed.Location = New System.Drawing.Point(448, 400)
        Me.data_anime_completed.MultiSelect = False
        Me.data_anime_completed.Name = "data_anime_completed"
        Me.data_anime_completed.RowHeadersVisible = False
        Me.data_anime_completed.RowHeadersWidth = 62
        Me.data_anime_completed.RowTemplate.Height = 28
        Me.data_anime_completed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_anime_completed.Size = New System.Drawing.Size(563, 181)
        Me.data_anime_completed.TabIndex = 93
        '
        'id_completed
        '
        Me.id_completed.HeaderText = "ID"
        Me.id_completed.MinimumWidth = 8
        Me.id_completed.Name = "id_completed"
        Me.id_completed.ReadOnly = True
        Me.id_completed.Visible = False
        Me.id_completed.Width = 150
        '
        'judul_completed
        '
        Me.judul_completed.HeaderText = "JUDUL ANIME"
        Me.judul_completed.MinimumWidth = 8
        Me.judul_completed.Name = "judul_completed"
        Me.judul_completed.ReadOnly = True
        Me.judul_completed.Width = 150
        '
        'studio_completed
        '
        Me.studio_completed.HeaderText = "STUDIO ANIME"
        Me.studio_completed.MinimumWidth = 8
        Me.studio_completed.Name = "studio_completed"
        Me.studio_completed.ReadOnly = True
        Me.studio_completed.Width = 150
        '
        'rating_completed
        '
        Me.rating_completed.HeaderText = "RATING"
        Me.rating_completed.MinimumWidth = 8
        Me.rating_completed.Name = "rating_completed"
        Me.rating_completed.ReadOnly = True
        Me.rating_completed.Width = 115
        '
        'tipe_completed
        '
        Me.tipe_completed.HeaderText = "TIPE ANIME"
        Me.tipe_completed.MinimumWidth = 8
        Me.tipe_completed.Name = "tipe_completed"
        Me.tipe_completed.ReadOnly = True
        Me.tipe_completed.Visible = False
        Me.tipe_completed.Width = 150
        '
        'status_completed
        '
        Me.status_completed.HeaderText = "STATUS ANIME"
        Me.status_completed.MinimumWidth = 8
        Me.status_completed.Name = "status_completed"
        Me.status_completed.ReadOnly = True
        Me.status_completed.Width = 150
        '
        'episode_completed
        '
        Me.episode_completed.HeaderText = "EPISODE "
        Me.episode_completed.MinimumWidth = 8
        Me.episode_completed.Name = "episode_completed"
        Me.episode_completed.ReadOnly = True
        Me.episode_completed.Width = 120
        '
        'genre_completed
        '
        Me.genre_completed.HeaderText = "GENRE ANIME"
        Me.genre_completed.MinimumWidth = 8
        Me.genre_completed.Name = "genre_completed"
        Me.genre_completed.ReadOnly = True
        Me.genre_completed.Visible = False
        Me.genre_completed.Width = 150
        '
        'tanggal_completed
        '
        Me.tanggal_completed.HeaderText = "TANGGAL RILIS"
        Me.tanggal_completed.MinimumWidth = 8
        Me.tanggal_completed.Name = "tanggal_completed"
        Me.tanggal_completed.ReadOnly = True
        Me.tanggal_completed.Visible = False
        Me.tanggal_completed.Width = 150
        '
        'sinopsis_completed
        '
        Me.sinopsis_completed.HeaderText = "SINOPSIS"
        Me.sinopsis_completed.MinimumWidth = 8
        Me.sinopsis_completed.Name = "sinopsis_completed"
        Me.sinopsis_completed.ReadOnly = True
        Me.sinopsis_completed.Visible = False
        Me.sinopsis_completed.Width = 150
        '
        'gambar_completed
        '
        Me.gambar_completed.HeaderText = "gambar"
        Me.gambar_completed.MinimumWidth = 8
        Me.gambar_completed.Name = "gambar_completed"
        Me.gambar_completed.ReadOnly = True
        Me.gambar_completed.Visible = False
        Me.gambar_completed.Width = 150
        '
        'path_txt
        '
        Me.path_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_txt.Location = New System.Drawing.Point(798, 291)
        Me.path_txt.Name = "path_txt"
        Me.path_txt.ReadOnly = True
        Me.path_txt.Size = New System.Drawing.Size(213, 39)
        Me.path_txt.TabIndex = 92
        '
        'id_txt
        '
        Me.id_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_txt.Location = New System.Drawing.Point(12, 5)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(83, 39)
        Me.id_txt.TabIndex = 91
        Me.id_txt.Visible = False
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.Coral
        Me.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_browse.Location = New System.Drawing.Point(1028, 282)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(142, 57)
        Me.btn_browse.TabIndex = 83
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(57, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 30)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "SINOPSIS"
        '
        'btn_log_out
        '
        Me.btn_log_out.BackColor = System.Drawing.Color.Crimson
        Me.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log_out.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_log_out.Location = New System.Drawing.Point(980, 5)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Size = New System.Drawing.Size(142, 49)
        Me.btn_log_out.TabIndex = 88
        Me.btn_log_out.Text = "LOG OUT"
        Me.btn_log_out.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.Coral
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_hapus.Location = New System.Drawing.Point(1017, 533)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(143, 48)
        Me.btn_hapus.TabIndex = 87
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.Coral
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_ubah.Location = New System.Drawing.Point(1017, 466)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(143, 48)
        Me.btn_ubah.TabIndex = 86
        Me.btn_ubah.Text = "UPDATE"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.Coral
        Me.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_tambah.Location = New System.Drawing.Point(1017, 400)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(143, 50)
        Me.btn_tambah.TabIndex = 85
        Me.btn_tambah.Text = "TAMBAH"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label11.Location = New System.Drawing.Point(599, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 30)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "GAMBAR ANIME"
        '
        'dtptanggal_rilis
        '
        Me.dtptanggal_rilis.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptanggal_rilis.Location = New System.Drawing.Point(798, 220)
        Me.dtptanggal_rilis.Name = "dtptanggal_rilis"
        Me.dtptanggal_rilis.Size = New System.Drawing.Size(372, 34)
        Me.dtptanggal_rilis.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label10.Location = New System.Drawing.Point(599, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 30)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "TANGGAL RILIS"
        '
        'genre_TXT
        '
        Me.genre_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genre_TXT.Location = New System.Drawing.Point(604, 145)
        Me.genre_TXT.Name = "genre_TXT"
        Me.genre_TXT.ReadOnly = True
        Me.genre_TXT.Size = New System.Drawing.Size(566, 39)
        Me.genre_TXT.TabIndex = 79
        '
        'btn_addgenre
        '
        Me.btn_addgenre.BackColor = System.Drawing.Color.Coral
        Me.btn_addgenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addgenre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addgenre.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_addgenre.Location = New System.Drawing.Point(1101, 82)
        Me.btn_addgenre.Name = "btn_addgenre"
        Me.btn_addgenre.Size = New System.Drawing.Size(69, 57)
        Me.btn_addgenre.TabIndex = 78
        Me.btn_addgenre.Text = "+"
        Me.btn_addgenre.UseVisualStyleBackColor = False
        '
        'cb_genre
        '
        Me.cb_genre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_genre.FormattingEnabled = True
        Me.cb_genre.Items.AddRange(New Object() {"ACTION", "ADVENTURE", "AVANTS GARDE", "COMEDY", "DEMONS", "DRAMA", "ECCHI", "FANTASY", "GAME", "HAREM", "HISTORICAL", "JOSEI", "MAGIC", "MARTIAL ARTS", "MECHA", "MILITARY", "MUSIC", "PSYCHOLOGICAL", "PARODY", "POLICE", "ROMANCE", "SAMURAI", "SCHOOL", "SCI-FI", "SEINEN", "SHOUJO", "SHOUJO AI", "SHOUNEN", "SLICE OF LIFE", "SPORTS", "SPACE", "SUPER POWER", "SUPERNATURAL", "THRILLER", "VAMPIRE"})
        Me.cb_genre.Location = New System.Drawing.Point(798, 87)
        Me.cb_genre.Name = "cb_genre"
        Me.cb_genre.Size = New System.Drawing.Size(213, 40)
        Me.cb_genre.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label9.Location = New System.Drawing.Point(599, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 30)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "GENRE ANIME"
        '
        'episode_TXT
        '
        Me.episode_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.episode_TXT.Location = New System.Drawing.Point(256, 291)
        Me.episode_TXT.Name = "episode_TXT"
        Me.episode_TXT.Size = New System.Drawing.Size(291, 39)
        Me.episode_TXT.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label8.Location = New System.Drawing.Point(57, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 30)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "EPISODE ANIME"
        '
        'cb_tipe
        '
        Me.cb_tipe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tipe.FormattingEnabled = True
        Me.cb_tipe.Items.AddRange(New Object() {"SERIES", "MOVIE"})
        Me.cb_tipe.Location = New System.Drawing.Point(256, 240)
        Me.cb_tipe.Name = "cb_tipe"
        Me.cb_tipe.Size = New System.Drawing.Size(158, 40)
        Me.cb_tipe.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label6.Location = New System.Drawing.Point(57, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 30)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "TIPE ANIME"
        '
        'studio_TXT
        '
        Me.studio_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.studio_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studio_TXT.Location = New System.Drawing.Point(256, 136)
        Me.studio_TXT.Name = "studio_TXT"
        Me.studio_TXT.Size = New System.Drawing.Size(291, 39)
        Me.studio_TXT.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(57, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 30)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "STUDIO ANIME"
        '
        'judul_TXT
        '
        Me.judul_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.judul_TXT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul_TXT.Location = New System.Drawing.Point(256, 87)
        Me.judul_TXT.Name = "judul_TXT"
        Me.judul_TXT.Size = New System.Drawing.Size(291, 39)
        Me.judul_TXT.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(57, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 30)
        Me.Label2.TabIndex = 64
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
        Me.Label1.Size = New System.Drawing.Size(1217, 60)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "CRUD COMPLETED"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(57, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 30)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "RATING ANIME"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SINOPSIS_TXT
        '
        Me.SINOPSIS_TXT.Location = New System.Drawing.Point(62, 400)
        Me.SINOPSIS_TXT.Name = "SINOPSIS_TXT"
        Me.SINOPSIS_TXT.Size = New System.Drawing.Size(374, 181)
        Me.SINOPSIS_TXT.TabIndex = 94
        Me.SINOPSIS_TXT.Text = ""
        '
        'rating_txt
        '
        Me.rating_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rating_txt.Location = New System.Drawing.Point(256, 189)
        Me.rating_txt.Name = "rating_txt"
        Me.rating_txt.Size = New System.Drawing.Size(291, 39)
        Me.rating_txt.TabIndex = 95
        '
        'form_CRUD_completed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1217, 640)
        Me.Controls.Add(Me.rating_txt)
        Me.Controls.Add(Me.SINOPSIS_TXT)
        Me.Controls.Add(Me.data_anime_completed)
        Me.Controls.Add(Me.path_txt)
        Me.Controls.Add(Me.id_txt)
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
        Me.Controls.Add(Me.studio_TXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.judul_TXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "form_CRUD_completed"
        Me.Text = "form_CRUD_completed"
        CType(Me.data_anime_completed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data_anime_completed As DataGridView
    Friend WithEvents id_completed As DataGridViewTextBoxColumn
    Friend WithEvents judul_completed As DataGridViewTextBoxColumn
    Friend WithEvents studio_completed As DataGridViewTextBoxColumn
    Friend WithEvents rating_completed As DataGridViewTextBoxColumn
    Friend WithEvents tipe_completed As DataGridViewTextBoxColumn
    Friend WithEvents status_completed As DataGridViewTextBoxColumn
    Friend WithEvents episode_completed As DataGridViewTextBoxColumn
    Friend WithEvents genre_completed As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_completed As DataGridViewTextBoxColumn
    Friend WithEvents sinopsis_completed As DataGridViewTextBoxColumn
    Friend WithEvents gambar_completed As DataGridViewTextBoxColumn
    Friend WithEvents path_txt As TextBox
    Friend WithEvents id_txt As TextBox
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
    Friend WithEvents studio_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents judul_TXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SINOPSIS_TXT As RichTextBox
    Friend WithEvents rating_txt As TextBox
End Class
