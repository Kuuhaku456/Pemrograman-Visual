Imports MySql.Data.MySqlClient

Public Class detail_animevb
    Private id_user As Integer
    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Dim newform As New Ongoing
        main_user.pnl_main.Controls.Clear()
        newform.TopLevel = False
        newform.AutoScroll = True
        main_user.pnl_main.Controls.Add(newform)
        newform.Show()
    End Sub

    Private Sub btn_favorit_Click(sender As Object, e As EventArgs) Handles btn_favorit.Click
        Try
            connect()
            CMD = New MySqlCommand("SELECT COUNT(*) FROM tb_favorit WHERE judul = @judul", CONN)
            CMD.Parameters.AddWithValue("@judul", judul_txt.Text)
            Dim count As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("ANIME SUDAH MENJADI FAVORIT TUAN >_< !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                judul_txt.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menyimpan data ke database: " & ex.Message)
        End Try

        Try
            connect()
            Dim judul As String = judul_txt.Text
            Dim studio As String = studio_txt.Text
            Dim rating As Integer = rating_txt.Text
            Dim tipe As String = tipe_txt.Text
            Dim episode As String = episode_txt.Text
            Dim genre As String = genre_txt.Text
            Dim tanggal As Date = CDate(tanggal_rilis_txt.Text)
            Dim sinopsis As String = sinopsis_txt.Text
            Dim path As String = path_txt.Text
            Dim query As String = "INSERT INTO tb_favorit (judul, studio, rating, tipe, episode, genre, tanggal_rilis, sinopsis, gambar, id_user) VALUES (@judul, @studio, @rating, @tipe, @episode, @genre, @tanggal_rilis, @sinopsis,  @gambar, @id_user)"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@judul", judul)
            CMD.Parameters.AddWithValue("@studio", studio)
            CMD.Parameters.AddWithValue("@rating", rating)
            CMD.Parameters.AddWithValue("@tipe", tipe)
            CMD.Parameters.AddWithValue("@episode", episode)
            CMD.Parameters.AddWithValue("@genre", genre)
            CMD.Parameters.AddWithValue("@tanggal_rilis", tanggal)
            CMD.Parameters.AddWithValue("@sinopsis", sinopsis)
            CMD.Parameters.AddWithValue("@gambar", path)
            CMD.Parameters.AddWithValue("@id_user", id_user)
            CMD.ExecuteNonQuery()
            MessageBox.Show("MASUK FAVORIT TUAN >_< !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CONN.Close()
        Catch ex As MySqlException
            MessageBox.Show("Terjadi kesalahan saat menyimpan data ke database: " & ex.Message)
        End Try
    End Sub

    Private Sub detail_animevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_user = CInt(main_user.id_user.Text)
        connect()
    End Sub
End Class