<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Completed
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
        Me.data_anime = New System.Windows.Forms.DataGridView()
        Me.id_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studio_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.episode_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_rilis_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinopsis_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar_completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cb_genre = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_tipe = New System.Windows.Forms.ComboBox()
        Me.pb_completed = New System.Windows.Forms.PictureBox()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_completed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_anime
        '
        Me.data_anime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_anime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_completed, Me.judul_completed, Me.studio_completed, Me.rating_completed, Me.tipe_completed, Me.status_completed, Me.episode_completed, Me.genre_completed, Me.tanggal_rilis_completed, Me.sinopsis_completed, Me.gambar_completed, Me.btn_detail})
        Me.data_anime.Location = New System.Drawing.Point(33, 240)
        Me.data_anime.MultiSelect = False
        Me.data_anime.Name = "data_anime"
        Me.data_anime.RowHeadersVisible = False
        Me.data_anime.RowHeadersWidth = 62
        Me.data_anime.RowTemplate.Height = 28
        Me.data_anime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_anime.Size = New System.Drawing.Size(629, 365)
        Me.data_anime.TabIndex = 10
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
        Me.judul_completed.Width = 410
        '
        'studio_completed
        '
        Me.studio_completed.HeaderText = "studio"
        Me.studio_completed.MinimumWidth = 8
        Me.studio_completed.Name = "studio_completed"
        Me.studio_completed.ReadOnly = True
        Me.studio_completed.Visible = False
        Me.studio_completed.Width = 150
        '
        'rating_completed
        '
        Me.rating_completed.HeaderText = "RATING"
        Me.rating_completed.MinimumWidth = 8
        Me.rating_completed.Name = "rating_completed"
        Me.rating_completed.ReadOnly = True
        Me.rating_completed.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rating_completed.Width = 120
        '
        'tipe_completed
        '
        Me.tipe_completed.HeaderText = "tipe"
        Me.tipe_completed.MinimumWidth = 8
        Me.tipe_completed.Name = "tipe_completed"
        Me.tipe_completed.ReadOnly = True
        Me.tipe_completed.Visible = False
        Me.tipe_completed.Width = 150
        '
        'status_completed
        '
        Me.status_completed.HeaderText = "status"
        Me.status_completed.MinimumWidth = 8
        Me.status_completed.Name = "status_completed"
        Me.status_completed.ReadOnly = True
        Me.status_completed.Visible = False
        Me.status_completed.Width = 150
        '
        'episode_completed
        '
        Me.episode_completed.HeaderText = "episode"
        Me.episode_completed.MinimumWidth = 8
        Me.episode_completed.Name = "episode_completed"
        Me.episode_completed.ReadOnly = True
        Me.episode_completed.Visible = False
        Me.episode_completed.Width = 150
        '
        'genre_completed
        '
        Me.genre_completed.HeaderText = "genre"
        Me.genre_completed.MinimumWidth = 8
        Me.genre_completed.Name = "genre_completed"
        Me.genre_completed.ReadOnly = True
        Me.genre_completed.Visible = False
        Me.genre_completed.Width = 150
        '
        'tanggal_rilis_completed
        '
        Me.tanggal_rilis_completed.HeaderText = "tanggal_rilis"
        Me.tanggal_rilis_completed.MinimumWidth = 8
        Me.tanggal_rilis_completed.Name = "tanggal_rilis_completed"
        Me.tanggal_rilis_completed.ReadOnly = True
        Me.tanggal_rilis_completed.Visible = False
        Me.tanggal_rilis_completed.Width = 150
        '
        'sinopsis_completed
        '
        Me.sinopsis_completed.HeaderText = "sinopsis"
        Me.sinopsis_completed.MinimumWidth = 8
        Me.sinopsis_completed.Name = "sinopsis_completed"
        Me.sinopsis_completed.ReadOnly = True
        Me.sinopsis_completed.Visible = False
        Me.sinopsis_completed.Width = 1000
        '
        'gambar_completed
        '
        Me.gambar_completed.HeaderText = "gambar"
        Me.gambar_completed.MinimumWidth = 8
        Me.gambar_completed.Name = "gambar_completed"
        Me.gambar_completed.Visible = False
        Me.gambar_completed.Width = 150
        '
        'btn_detail
        '
        Me.btn_detail.HeaderText = "DETAIL"
        Me.btn_detail.MinimumWidth = 8
        Me.btn_detail.Name = "btn_detail"
        Me.btn_detail.ReadOnly = True
        Me.btn_detail.Text = "Detail"
        Me.btn_detail.Width = 120
        '
        'cb_genre
        '
        Me.cb_genre.BackColor = System.Drawing.Color.DarkRed
        Me.cb_genre.DropDownHeight = 80
        Me.cb_genre.DropDownWidth = 145
        Me.cb_genre.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_genre.ForeColor = System.Drawing.Color.Cornsilk
        Me.cb_genre.FormattingEnabled = True
        Me.cb_genre.IntegralHeight = False
        Me.cb_genre.ItemHeight = 45
        Me.cb_genre.Items.AddRange(New Object() {"ACTION", "ADVENTURE", "AVANTS GARDE", "COMEDY", "DEMONS", "DRAMA", "ECCHI", "FANTASY", "GAME", "HAREM", "HISTORICAL", "JOSEI", "MAGIC", "MARTIAL ARTS", "MECHA", "MILITARY", "MUSIC", "PSYCHOLOGICAL", "PARODY", "POLICE", "ROMANCE", "SAMURAI", "SCHOOL", "SCI-FI", "SEINEN", "SHOUJO", "SHOUJO AI", "SHOUNEN", "SLICE OF LIFE", "SPORTS", "SPACE", "SUPER POWER", "SUPERNATURAL", "THRILLER", "VAMPIRE"})
        Me.cb_genre.Location = New System.Drawing.Point(33, 120)
        Me.cb_genre.MaxDropDownItems = 5
        Me.cb_genre.Name = "cb_genre"
        Me.cb_genre.Size = New System.Drawing.Size(167, 53)
        Me.cb_genre.TabIndex = 13
        Me.cb_genre.Text = " GENRE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button1.Location = New System.Drawing.Point(486, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 53)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "LIHAT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 87)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(437, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "COMPLETED ANIME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_tipe
        '
        Me.cb_tipe.BackColor = System.Drawing.Color.DarkRed
        Me.cb_tipe.DropDownHeight = 80
        Me.cb_tipe.DropDownWidth = 145
        Me.cb_tipe.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_tipe.ForeColor = System.Drawing.Color.Cornsilk
        Me.cb_tipe.FormattingEnabled = True
        Me.cb_tipe.IntegralHeight = False
        Me.cb_tipe.ItemHeight = 45
        Me.cb_tipe.Items.AddRange(New Object() {"SERIES", "MOVIE"})
        Me.cb_tipe.Location = New System.Drawing.Point(257, 120)
        Me.cb_tipe.MaxDropDownItems = 5
        Me.cb_tipe.Name = "cb_tipe"
        Me.cb_tipe.Size = New System.Drawing.Size(167, 53)
        Me.cb_tipe.TabIndex = 15
        Me.cb_tipe.Text = "TIPE"
        '
        'pb_completed
        '
        Me.pb_completed.BackColor = System.Drawing.Color.DarkOrange
        Me.pb_completed.Location = New System.Drawing.Point(726, 120)
        Me.pb_completed.Name = "pb_completed"
        Me.pb_completed.Size = New System.Drawing.Size(391, 485)
        Me.pb_completed.TabIndex = 11
        Me.pb_completed.TabStop = False
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(33, 188)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(391, 39)
        Me.txt_cari.TabIndex = 62
        '
        'Completed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1278, 632)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.cb_tipe)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.data_anime)
        Me.Controls.Add(Me.cb_genre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pb_completed)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Completed"
        Me.Text = "Completed"
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_completed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data_anime As DataGridView
    Friend WithEvents cb_genre As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pb_completed As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_tipe As ComboBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents id_completed As DataGridViewTextBoxColumn
    Friend WithEvents judul_completed As DataGridViewTextBoxColumn
    Friend WithEvents studio_completed As DataGridViewTextBoxColumn
    Friend WithEvents rating_completed As DataGridViewTextBoxColumn
    Friend WithEvents tipe_completed As DataGridViewTextBoxColumn
    Friend WithEvents status_completed As DataGridViewTextBoxColumn
    Friend WithEvents episode_completed As DataGridViewTextBoxColumn
    Friend WithEvents genre_completed As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_rilis_completed As DataGridViewTextBoxColumn
    Friend WithEvents sinopsis_completed As DataGridViewTextBoxColumn
    Friend WithEvents gambar_completed As DataGridViewTextBoxColumn
    Friend WithEvents btn_detail As DataGridViewButtonColumn
End Class
