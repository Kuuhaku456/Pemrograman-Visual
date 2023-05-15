Imports MySql.Data.MySqlClient

Public Class detail_favorit
    Private id As Integer
    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        anime_favorit.TopLevel = False
        anime_favorit.AutoScroll = True
        main_user.pnl_main.Controls.Clear()
        main_user.pnl_main.Controls.Add(anime_favorit)
        anime_favorit.Show()
    End Sub

    Sub display()
        anime_favorit.data_anime.Rows.Clear()
        Dim sql As String = "SELECT * FROM tb_favorit where id_user=@id_user"
        CMD = New MySqlCommand(sql, CONN)
        CMD.Parameters.AddWithValue("@id_user", id)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim anime As New DataGridViewRow()
            anime.CreateCells(anime_favorit.data_anime)
            anime.Cells(0).Value = RD("id")
            anime.Cells(1).Value = RD("judul")
            anime.Cells(2).Value = RD("studio")
            anime.Cells(3).Value = RD("rating")
            anime.Cells(4).Value = RD("tipe")
            anime.Cells(5).Value = RD("episode")
            anime.Cells(6).Value = RD("genre")
            anime.Cells(7).Value = RD("tanggal_rilis")
            anime.Cells(8).Value = RD("sinopsis")
            anime.Cells(9).Value = RD("gambar")
            anime_favorit.data_anime.Rows.Add(anime)
        End While
        CONN.Close()
    End Sub

    Private Sub detail_favorit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id = CInt(main_user.id_user.Text)
        connect()
    End Sub
End Class