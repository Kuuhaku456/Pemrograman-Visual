Imports MySql.Data.MySqlClient

Public Class form_CRUD_completed
    Private Sub form_CRUD_completed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        display()
        cls()
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 65) And (tombol <= 90)) Or ((tombol >= 97) And (tombol <= 122)) Or (tombol = 8) Or (tombol = 32) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btn_log_out_Click(sender As Object, e As EventArgs) Handles btn_log_out.Click
        Me.Hide()
        form_admin.pnl_admin.Controls.Clear()
        form_admin.Hide()
        Login_admin.Show()
    End Sub



    Private Sub display()
        connect()
        data_anime_completed.Rows.Clear()
        Dim sql As String = "SELECT * FROM tb_completed"
        CMD = New MySqlCommand(sql, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim anime As New DataGridViewRow()
            anime.CreateCells(data_anime_completed)
            anime.Cells(0).Value = RD("id")
            anime.Cells(1).Value = RD("judul")
            anime.Cells(2).Value = RD("studio")
            anime.Cells(3).Value = RD("rating")
            anime.Cells(4).Value = RD("tipe")
            anime.Cells(5).Value = RD("status")
            anime.Cells(6).Value = RD("episode")
            anime.Cells(7).Value = RD("genre")
            anime.Cells(8).Value = RD("tanggal_rilis")
            anime.Cells(9).Value = RD("sinopsis")
            anime.Cells(10).Value = RD("gambar")
            data_anime_completed.Rows.Add(anime)
        End While
        CONN.Close()
    End Sub

    Private Sub cls()
        id_txt.Text = ""
        judul_TXT.Text = ""
        studio_TXT.Text = ""
        rating_txt.Text = ""
        cb_tipe.Text = ""
        episode_TXT.Text = "Unknown"
        genre_TXT.Text = ""
        dtptanggal_rilis.Value = DateTime.Now
        SINOPSIS_TXT.Text = ""
        path_txt.Text = ""
        data_anime_completed.ClearSelection()
    End Sub

    Private Sub judul_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles judul_TXT.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub episode_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles episode_TXT.KeyPress
        HanyaAngka(e)
    End Sub
    Private Sub btn_addgenre_Click(sender As Object, e As EventArgs) Handles btn_addgenre.Click
        If cb_genre.Text = "" Then
            MessageBox.Show("Silahkan pilih dulu genre nya tuan >_<", "EROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedGenre As String = cb_genre.SelectedItem.ToString()



        'menghapus nilai yang dipilih dari combobox
        cb_genre.Items.Remove(selectedGenre)

        'menambahkan nilai ke dalam textbox
        If genre_TXT.Text = "" Then
            genre_TXT.Text = selectedGenre
        Else
            genre_TXT.Text += " , " + selectedGenre
        End If
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files (*.jpg, *.png, *.gif, *.bmp, *.jfif)|*.jpg; *.png; *.gif; *.bmp; *.jfif"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedImage As String = openFileDialog1.FileName
            'menampilkan path file di textbox atau picturebox
            path_txt.Text = selectedImage
        End If
    End Sub

    Private Function cek_kosong()
        If judul_TXT.Text = "" Then
            MessageBox.Show("Judul anime harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            judul_TXT.Focus()
        ElseIf studio_TXT.Text = "" Then
            MessageBox.Show("Studio anime harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            studio_TXT.Focus()
        ElseIf rating_txt.Text = "" Then
            MessageBox.Show("Rating anime harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cb_tipe.Text = "" Then
            MessageBox.Show("Tipe anime harus dipilih Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf episode_TXT.Text = "" Then
            MessageBox.Show("Episode anime harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            episode_TXT.Focus()
        ElseIf genre_TXT.Text = "" Then
            MessageBox.Show("Genre anime harus dipilih Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dtptanggal_rilis.Value = DateTime.Now Then
            MessageBox.Show("tanggal tidak boleh sama tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf SINOPSIS_TXT.Text = "" Then
            MessageBox.Show("sinopsis tidak boleh kosong tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SINOPSIS_TXT.Focus()
        ElseIf path_txt.Text = "" Then
            MessageBox.Show("path gambar tidak boleh kosong tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim arrGenre() As String = {"ACTION", "ADVENTURE", "AVANTS GARDE", "COMEDY", "DEMONS", "DRAMA", "ECCHI", "FANTASY", "GAME", "HAREM", "HORROR", "HISTORICAL", "JOSEI", "MAGIC", "MARTIAL ARTS", "MECHA", "MILITARY", "MUSIC", "PSYCHOLOGICAL", "PARODY", "POLICE", "ROMANCE", "REINCARNATION", "SAMURAI", "SCHOOL", "SCI-FI", "SEINEN", "SHOUJO", "SHOUJO AI", "SHOUNEN", "SHOUNEN AI", "SLICE OF LIFE", "SPORTS", "SPACE", "SUPER POWER", "SUPERNATURAL", "THRILLER", "VAMPIRE", "ZOMBIE"}
        cb_genre.Items.Clear()
        For Each genres As String In arrGenre
            cb_genre.Items.Add(genres)
        Next
        If cek_kosong() = True Then
            Try
                connect()
                CMD = New MySqlCommand("SELECT COUNT(*) FROM tb_completed WHERE judul = @judul", CONN)
                CMD.Parameters.AddWithValue("@judul", judul_TXT.Text)
                Dim count As Integer = Convert.ToInt32(CMD.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Judul anime sudah ada Tuan >_< !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                    judul_TXT.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menyimpan data ke database: " & ex.Message)
            End Try

            Try
                connect()
                Dim id As String = ""
                Dim judul As String = judul_TXT.Text
                Dim studio As String = studio_TXT.Text
                Dim rating As Integer = rating_txt.Text
                Dim tipe As String = cb_tipe.SelectedItem.ToString()
                Dim status As String = "completed"
                Dim episode As Integer = Integer.Parse(episode_TXT.Text)
                Dim genre As String = genre_TXT.Text
                Dim tanggal As Date = dtptanggal_rilis.Value
                Dim sinopsis As String = SINOPSIS_TXT.Text
                Dim path As String = path_txt.Text
                Dim gambar As Image = Image.FromFile(path)
                Dim query As String = "INSERT INTO tb_completed (id , judul, studio, rating, tipe, status, episode, genre, tanggal_rilis, sinopsis, gambar) VALUES (@id , @judul, @studio, @rating, @tipe, @status, @episode, @genre, @tanggal_rilis, @sinopsis,  @gambar)"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@id", id)
                CMD.Parameters.AddWithValue("@judul", judul)
                CMD.Parameters.AddWithValue("@studio", studio)
                CMD.Parameters.AddWithValue("@rating", rating)
                CMD.Parameters.AddWithValue("@tipe", tipe)
                CMD.Parameters.AddWithValue("@status", status)
                CMD.Parameters.AddWithValue("@episode", episode)
                CMD.Parameters.AddWithValue("@genre", genre)
                CMD.Parameters.AddWithValue("@tanggal_rilis", tanggal)
                CMD.Parameters.AddWithValue("@sinopsis", sinopsis)
                CMD.Parameters.AddWithValue("@gambar", path)
                CMD.ExecuteNonQuery()
                MessageBox.Show("DATA BERHASIL DITAMBAH TUAN >_< !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'data_anime.Rows.Add(id, judul, studio, rating, tipe, status, episode, genre, tanggal, sinopsis, gambar)
                CONN.Close()
                display()
                cls()
            Catch ex As MySqlException
                MessageBox.Show("Terjadi kesalahan saat menyimpan data ke database: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        cb_genre.Items.Clear()
        Dim arrGenre() As String = {"ACTION", "ADVENTURE", "AVANTS GARDE", "COMEDY", "DEMONS", "DRAMA", "ECCHI", "FANTASY", "GAME", "HAREM", "HORROR", "HISTORICAL", "JOSEI", "MAGIC", "MARTIAL ARTS", "MECHA", "MILITARY", "MUSIC", "PSYCHOLOGICAL", "PARODY", "POLICE", "ROMANCE", "REINCARNATION", "SAMURAI", "SCHOOL", "SCI-FI", "SEINEN", "SHOUJO", "SHOUJO AI", "SHOUNEN", "SHOUNEN AI", "SLICE OF LIFE", "SPORTS", "SPACE", "SUPER POWER", "SUPERNATURAL", "THRILLER", "VAMPIRE", "ZOMBIE"}
        For Each genres As String In arrGenre
            cb_genre.Items.Add(genres)
        Next
        If data_anime_completed.SelectedRows.Count > 0 Then
            Dim pilih As DataGridViewRow = data_anime_completed.SelectedRows(0)
            Dim ids As Integer = pilih.Cells("id_completed").Value
            If cek_kosong() = True Then
                Try
                    connect()
                    Dim judul As String = judul_TXT.Text
                    Dim studio As String = studio_TXT.Text
                    Dim rating As Integer = rating_txt.Text
                    Dim tipe As String = cb_tipe.SelectedItem.ToString()
                    Dim status As String = "completed"
                    Dim episode As Integer = Integer.Parse(episode_TXT.Text)
                    Dim genre As String = genre_TXT.Text
                    Dim tanggal As Date = dtptanggal_rilis.Value
                    Dim sinopsis As String = SINOPSIS_TXT.Text
                    Dim paths As String = path_txt.Text
                    Dim sql As String = "UPDATE tb_completed SET judul=@judul, studio=@studio, rating=@rating, tipe=@tipe, status=@status, episode=@episode, genre=@genre, tanggal_rilis=@tanggal_rilis, sinopsis=@sinopsis, gambar=@gambar WHERE id=@id"
                    CMD = New MySqlCommand(sql, CONN)
                    CMD.Parameters.AddWithValue("@id", ids)
                    CMD.Parameters.AddWithValue("@judul", judul)
                    CMD.Parameters.AddWithValue("@studio", studio)
                    CMD.Parameters.AddWithValue("@rating", rating)
                    CMD.Parameters.AddWithValue("@tipe", tipe)
                    CMD.Parameters.AddWithValue("@status", status)
                    CMD.Parameters.AddWithValue("@episode", episode)
                    CMD.Parameters.AddWithValue("@genre", genre)
                    CMD.Parameters.AddWithValue("@tanggal_rilis", tanggal)
                    CMD.Parameters.AddWithValue("@sinopsis", sinopsis)
                    CMD.Parameters.AddWithValue("@gambar", paths)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("DATA BERHASIL DIRUBAH TUAN >_< !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CONN.Close()
                    display()
                    cls()
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data ke database: " & ex.Message, "EROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Anda tidak memilih data yang akan diupdate tuan >_<!!!", "EROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        cb_genre.Items.Clear()
        Dim arrGenre() As String = {"ACTION", "ADVENTURE", "AVANTS GARDE", "COMEDY", "DEMONS", "DRAMA", "ECCHI", "FANTASY", "GAME", "HAREM", "HORROR", "HISTORICAL", "JOSEI", "MAGIC", "MARTIAL ARTS", "MECHA", "MILITARY", "MUSIC", "PSYCHOLOGICAL", "PARODY", "POLICE", "ROMANCE", "REINCARNATION", "SAMURAI", "SCHOOL", "SCI-FI", "SEINEN", "SHOUJO", "SHOUJO AI", "SHOUNEN", "SHOUNEN AI", "SLICE OF LIFE", "SPORTS", "SPACE", "SUPER POWER", "SUPERNATURAL", "THRILLER", "VAMPIRE", "ZOMBIE"}
        For Each genres As String In arrGenre
            cb_genre.Items.Add(genres)
        Next
        If data_anime_completed.SelectedRows.Count > 0 Then
            Dim pilih As DataGridViewRow = data_anime_completed.SelectedRows(0)
            Dim idss As Integer = pilih.Cells("id_completed").Value
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus Data", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                connect()
                Dim sql As String = "delete from tb_completed where id=@id"
                CMD = New MySqlCommand(sql, CONN)
                CMD.Parameters.AddWithValue("@id", idss)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data telah dihapus Tuan >_<", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CONN.Close()
                display()
                cls()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Data tidak jadi dihapus Tuan >_<", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
    End Sub

    Private Sub data_anime_completedSelectionChanged(sender As Object, e As EventArgs) Handles data_anime_completed.SelectionChanged
        Dim anime As Integer = data_anime_completed.GetCellCount(DataGridViewElementStates.Selected)
        Dim arrGenre() As String = {"Action", "Adventure", "AVANTS GARDE", "COMEDY", "DEMONS", "DRAMA", "ECCHI", "FANTASY", "GAME", "HAREM", "HORROR", "HISTORICAL", "JOSEI", "MAGIC", "MARTIAL ARTS", "MECHA", "MILITARY", "MUSIC", "PSYCHOLOGICAL", "PARODY", "POLICE", "ROMANCE", "REINCARNATION", "SAMURAI", "SCHOOL", "SCI-FI", "SEINEN", "SHOUJO", "SHOUJO AI", "SHOUNEN", "SHOUNEN AI", "SLICE OF LIFE", "SPORTS", "SPACE", "SUPER POWER", "SUPERNATURAL", "THRILLER", "VAMPIRE", "ZOMBIE"}
        cb_genre.Items.Clear()
        For Each genre As String In arrGenre
            cb_genre.Items.Add(genre)
        Next
        If anime > 0 Then
            Dim i As Integer
            Dim index As Integer = data_anime_completed.SelectedCells(i).RowIndex
            path_txt.Text = data_anime_completed.CurrentRow.Cells("gambar_completed").Value
            id_txt.Text = data_anime_completed.CurrentRow.Cells("id_completed").Value.ToString()
            judul_TXT.Text = data_anime_completed.CurrentRow.Cells("judul_completed").Value.ToString()
            studio_TXT.Text = data_anime_completed.CurrentRow.Cells("studio_completed").Value.ToString()
            rating_txt.Text = data_anime_completed.CurrentRow.Cells("rating_completed").Value.ToString()
            dtptanggal_rilis.Value = CDate(data_anime_completed.CurrentRow.Cells("tanggal_completed").Value)
            cb_tipe.Text = data_anime_completed.CurrentRow.Cells("tipe_completed").Value.ToString()
            episode_TXT.Text = data_anime_completed.CurrentRow.Cells("episode_completed").Value.ToString()
            SINOPSIS_TXT.Text = data_anime_completed.CurrentRow.Cells("sinopsis_completed").Value.ToString()
        End If
    End Sub
End Class