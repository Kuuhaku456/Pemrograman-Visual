Imports MySql.Data.MySqlClient

Public Class anime_favorit
    Private id_users As Integer
    Private Sub anime_favorit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_users = CInt(main_user.id_user.Text)
        connect()
        display()
        data_anime.ClearSelection()
    End Sub
    Private Sub display()
        connect()
        data_anime.Rows.Clear()
        Dim sql As String = "SELECT * FROM tb_favorit where id_user=@id_user"
        CMD = New MySqlCommand(sql, CONN)
        CMD.Parameters.AddWithValue("@id_user", id_users)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim anime As New DataGridViewRow()
            anime.CreateCells(data_anime)
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
            data_anime.Rows.Add(anime)
        End While
        CONN.Close()
    End Sub

    Private Sub data_anime_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_anime.CellContentClick
        detail_favorit.TopLevel = False
        detail_favorit.AutoScroll = True
        If data_anime.Columns(e.ColumnIndex).Name = "btn_detail" Then
            detail_favorit.id_txt.Text = data_anime.Rows(e.RowIndex).Cells("id").Value
            detail_favorit.judul_txt.Text = data_anime.Rows(e.RowIndex).Cells("judul").Value
            detail_favorit.studio_txt.Text = data_anime.Rows(e.RowIndex).Cells("studio").Value
            detail_favorit.rating_txt.Text = data_anime.Rows(e.RowIndex).Cells("rating").Value
            detail_favorit.tipe_txt.Text = data_anime.Rows(e.RowIndex).Cells("tipe").Value
            detail_favorit.episode_txt.Text = data_anime.Rows(e.RowIndex).Cells("episode").Value
            detail_favorit.genre_txt.Text = data_anime.Rows(e.RowIndex).Cells("genre").Value
            detail_favorit.tanggal_rilis_txt.Text = data_anime.Rows(e.RowIndex).Cells("tanggal_rilis").Value
            detail_favorit.sinopsis_txt.Text = data_anime.Rows(e.RowIndex).Cells("sinopsis").Value
            detail_favorit.pb_anime.Image = Image.FromFile(data_anime.Rows(e.RowIndex).Cells("gambar").Value)
            detail_favorit.path_txt.Text = data_anime.Rows(e.RowIndex).Cells("gambar").Value
            main_user.pnl_main.Controls.Clear()
            main_user.pnl_main.Controls.Add(detail_favorit)
            detail_favorit.Show()
        End If
        If data_anime.Columns(e.ColumnIndex).Name = "btn_hapus" Then
            Dim idss As Integer = data_anime.Rows(e.RowIndex).Cells("id").Value
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus anime dari list favorit anda?", "Konfirmasi unfavorit anime", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                connect()
                Dim sql As String = "delete from tb_favorit where id=@id"
                CMD = New MySqlCommand(sql, CONN)
                CMD.Parameters.AddWithValue("@id", idss)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data telah dihapus Tuan >_<", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CONN.Close()
                display()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Data tidak jadi dihapus Tuan >_<", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
    End Sub

    Private Sub data_anime_SelectionChanged(sender As Object, e As EventArgs) Handles data_anime.SelectionChanged
        Dim anime As Integer = data_anime.GetCellCount(DataGridViewElementStates.Selected)
        If anime > 0 Then
            Dim i As Integer
            Dim index As Integer = data_anime.SelectedCells(i).RowIndex
            pb_favorit.Image = Image.FromFile(data_anime.CurrentRow.Cells("gambar").Value)
        End If
    End Sub

    Private Sub txt_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cari.KeyPress
        Dim cari As String
        cari = txt_cari.Text

        If e.KeyChar = Chr(13) Then
            connect()
            data_anime.Rows.Clear()
            CMD = New MySqlCommand("SELECT judul, studio, rating, tipe, episode, genre, tanggal_rilis, sinopsis, gambar from tb_favorit where judul like '%" & cari & "%'", CONN)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                While RD.Read()
                    Dim anime As New DataGridViewRow()
                    anime.CreateCells(data_anime)
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
                    data_anime.Rows.Add(anime)
                End While
                CONN.Close()
                RD.Close()
                data_anime.ClearSelection()
            Else
                RD.Close()
                MessageBox.Show("Data tidak ditemukan Tuan >_< !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_cari.Clear()
                display()
            End If

        End If
    End Sub
End Class
