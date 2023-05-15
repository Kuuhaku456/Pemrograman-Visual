<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ongoing
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
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studio_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.episode_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_rilis_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinopsis_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar_ongoing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cb_hari = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.pb_ongoing = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_ongoing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_anime
        '
        Me.data_anime.AllowUserToAddRows = False
        Me.data_anime.AllowUserToDeleteRows = False
        Me.data_anime.AllowUserToResizeColumns = False
        Me.data_anime.AllowUserToResizeRows = False
        Me.data_anime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_anime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.judul_ongoing, Me.studio_ongoing, Me.rating_ongoing, Me.tipe_ongoing, Me.status_ongoing, Me.episode_ongoing, Me.genre_ongoing, Me.tanggal_rilis_ongoing, Me.sinopsis_ongoing, Me.gambar_ongoing, Me.btn_detail})
        Me.data_anime.Location = New System.Drawing.Point(36, 172)
        Me.data_anime.MultiSelect = False
        Me.data_anime.Name = "data_anime"
        Me.data_anime.RowHeadersVisible = False
        Me.data_anime.RowHeadersWidth = 62
        Me.data_anime.RowTemplate.Height = 28
        Me.data_anime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_anime.Size = New System.Drawing.Size(750, 389)
        Me.data_anime.TabIndex = 6
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
        'judul_ongoing
        '
        Me.judul_ongoing.HeaderText = "JUDUL ANIME"
        Me.judul_ongoing.MinimumWidth = 8
        Me.judul_ongoing.Name = "judul_ongoing"
        Me.judul_ongoing.ReadOnly = True
        Me.judul_ongoing.Width = 410
        '
        'studio_ongoing
        '
        Me.studio_ongoing.HeaderText = "studio"
        Me.studio_ongoing.MinimumWidth = 8
        Me.studio_ongoing.Name = "studio_ongoing"
        Me.studio_ongoing.ReadOnly = True
        Me.studio_ongoing.Visible = False
        Me.studio_ongoing.Width = 150
        '
        'rating_ongoing
        '
        Me.rating_ongoing.HeaderText = "RATING"
        Me.rating_ongoing.MinimumWidth = 8
        Me.rating_ongoing.Name = "rating_ongoing"
        Me.rating_ongoing.ReadOnly = True
        Me.rating_ongoing.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rating_ongoing.Width = 120
        '
        'tipe_ongoing
        '
        Me.tipe_ongoing.HeaderText = "tipe"
        Me.tipe_ongoing.MinimumWidth = 8
        Me.tipe_ongoing.Name = "tipe_ongoing"
        Me.tipe_ongoing.ReadOnly = True
        Me.tipe_ongoing.Visible = False
        Me.tipe_ongoing.Width = 150
        '
        'status_ongoing
        '
        Me.status_ongoing.HeaderText = "status"
        Me.status_ongoing.MinimumWidth = 8
        Me.status_ongoing.Name = "status_ongoing"
        Me.status_ongoing.ReadOnly = True
        Me.status_ongoing.Visible = False
        Me.status_ongoing.Width = 150
        '
        'episode_ongoing
        '
        Me.episode_ongoing.HeaderText = "EPISODE"
        Me.episode_ongoing.MinimumWidth = 8
        Me.episode_ongoing.Name = "episode_ongoing"
        Me.episode_ongoing.ReadOnly = True
        Me.episode_ongoing.Width = 120
        '
        'genre_ongoing
        '
        Me.genre_ongoing.HeaderText = "genre"
        Me.genre_ongoing.MinimumWidth = 8
        Me.genre_ongoing.Name = "genre_ongoing"
        Me.genre_ongoing.ReadOnly = True
        Me.genre_ongoing.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.genre_ongoing.Visible = False
        Me.genre_ongoing.Width = 150
        '
        'tanggal_rilis_ongoing
        '
        Me.tanggal_rilis_ongoing.HeaderText = "tanggal_rilis"
        Me.tanggal_rilis_ongoing.MinimumWidth = 8
        Me.tanggal_rilis_ongoing.Name = "tanggal_rilis_ongoing"
        Me.tanggal_rilis_ongoing.ReadOnly = True
        Me.tanggal_rilis_ongoing.Visible = False
        Me.tanggal_rilis_ongoing.Width = 150
        '
        'sinopsis_ongoing
        '
        Me.sinopsis_ongoing.HeaderText = "sinopsis"
        Me.sinopsis_ongoing.MinimumWidth = 8
        Me.sinopsis_ongoing.Name = "sinopsis_ongoing"
        Me.sinopsis_ongoing.ReadOnly = True
        Me.sinopsis_ongoing.Visible = False
        Me.sinopsis_ongoing.Width = 1000
        '
        'gambar_ongoing
        '
        Me.gambar_ongoing.HeaderText = "gambar"
        Me.gambar_ongoing.MinimumWidth = 8
        Me.gambar_ongoing.Name = "gambar_ongoing"
        Me.gambar_ongoing.ReadOnly = True
        Me.gambar_ongoing.Visible = False
        Me.gambar_ongoing.Width = 150
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
        'cb_hari
        '
        Me.cb_hari.BackColor = System.Drawing.Color.DarkRed
        Me.cb_hari.DropDownHeight = 80
        Me.cb_hari.DropDownWidth = 145
        Me.cb_hari.ForeColor = System.Drawing.Color.Cornsilk
        Me.cb_hari.FormattingEnabled = True
        Me.cb_hari.IntegralHeight = False
        Me.cb_hari.ItemHeight = 32
        Me.cb_hari.Items.AddRange(New Object() {"SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU", "MINGGU"})
        Me.cb_hari.Location = New System.Drawing.Point(456, 121)
        Me.cb_hari.MaxDropDownItems = 5
        Me.cb_hari.Name = "cb_hari"
        Me.cb_hari.Size = New System.Drawing.Size(139, 40)
        Me.cb_hari.TabIndex = 9
        Me.cb_hari.Text = "HARI"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button1.Location = New System.Drawing.Point(619, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 52)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "LIHAT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(36, 121)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(391, 39)
        Me.txt_cari.TabIndex = 61
        '
        'pb_ongoing
        '
        Me.pb_ongoing.BackColor = System.Drawing.Color.DarkOrange
        Me.pb_ongoing.Location = New System.Drawing.Point(851, 114)
        Me.pb_ongoing.Name = "pb_ongoing"
        Me.pb_ongoing.Size = New System.Drawing.Size(339, 447)
        Me.pb_ongoing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_ongoing.TabIndex = 7
        Me.pb_ongoing.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cornsilk
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1283, 74)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "ANIME ONGOING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ongoing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1283, 590)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.data_anime)
        Me.Controls.Add(Me.cb_hari)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pb_ongoing)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Ongoing"
        Me.Text = "Ongoing"
        CType(Me.data_anime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_ongoing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data_anime As DataGridView
    Friend WithEvents cb_hari As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pb_ongoing As PictureBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents judul_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents studio_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents rating_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents tipe_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents status_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents episode_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents genre_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_rilis_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents sinopsis_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents gambar_ongoing As DataGridViewTextBoxColumn
    Friend WithEvents btn_detail As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
End Class
