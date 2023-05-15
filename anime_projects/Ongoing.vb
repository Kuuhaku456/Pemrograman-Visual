Imports MySql.Data.MySqlClient

Public Class Ongoing

    Private Sub Ongoing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        display()
    End Sub

    Private Sub display()
        data_anime.Rows.Clear()
        Dim sql As String = "SELECT * FROM tb_ongoing"
        CMD = New MySqlCommand(sql, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim anime As New DataGridViewRow()
            anime.CreateCells(data_anime)
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
            data_anime.Rows.Add(anime)
        End While
        CONN.Close()
    End Sub

    Private Sub data_anime_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_anime.CellContentClick
        detail_animevb.TopLevel = False
        detail_animevb.AutoScroll = True
        If data_anime.Columns(e.ColumnIndex).Name = "btn_detail" Then
            detail_animevb.judul_txt.Text = data_anime.Rows(e.RowIndex).Cells("judul_ongoing").Value
            detail_animevb.studio_txt.Text = data_anime.Rows(e.RowIndex).Cells("studio_ongoing").Value
            detail_animevb.rating_txt.Text = data_anime.Rows(e.RowIndex).Cells("rating_ongoing").Value
            detail_animevb.tipe_txt.Text = data_anime.Rows(e.RowIndex).Cells("tipe_ongoing").Value
            detail_animevb.episode_txt.Text = data_anime.Rows(e.RowIndex).Cells("episode_ongoing").Value
            detail_animevb.genre_txt.Text = data_anime.Rows(e.RowIndex).Cells("genre_ongoing").Value
            detail_animevb.tanggal_rilis_txt.Text = data_anime.Rows(e.RowIndex).Cells("tanggal_rilis_ongoing").Value
            detail_animevb.sinopsis_txt.Text = data_anime.Rows(e.RowIndex).Cells("sinopsis_ongoing").Value
            detail_animevb.pb_anime.Image = Image.FromFile(data_anime.Rows(e.RowIndex).Cells("gambar_ongoing").Value)
            detail_animevb.path_txt.Text = data_anime.Rows(e.RowIndex).Cells("gambar_ongoing").Value
            main_user.pnl_main.Controls.Clear()
            main_user.pnl_main.Controls.Add(detail_animevb)
            detail_animevb.Show()
        End If
    End Sub

    Private Sub data_anime_SelectionChanged(sender As Object, e As EventArgs) Handles data_anime.SelectionChanged
        Dim anime As Integer = data_anime.GetCellCount(DataGridViewElementStates.Selected)
        If anime > 0 Then
            Dim i As Integer
            Dim index As Integer = data_anime.SelectedCells(i).RowIndex
            pb_ongoing.Image = Image.FromFile(data_anime.CurrentRow.Cells("gambar_ongoing").Value)
        End If
    End Sub
End Class