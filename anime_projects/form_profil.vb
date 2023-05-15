Imports MySql.Data.MySqlClient

Public Class form_profil
    Private id As Integer
    Private Sub btn_kmbl_Click(sender As Object, e As EventArgs) Handles btn_kmbl.Click
        main_user.pnl_main.Controls.Clear()
        Dim newForm As New All_animes
        newForm.TopLevel = False
        newForm.AutoScroll = True
        main_user.pnl_main.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Private Sub form_profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id = CInt(main_user.id_user.Text)
        connect()
        display()
    End Sub
    Private Sub display()
        Dim SQL As String = "SELECT * FROM tb_akun WHERE id=@id"
        CMD = New MySqlCommand(SQL, CONN)
        CMD.Parameters.AddWithValue("@id", id)
        Dim da As New MySqlDataAdapter(CMD)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            nama_txt.Text = dt.Rows(0)("username").ToString()
            nomor_telepon_txt.Text = dt.Rows(0)("nomor_telepon").ToString()
            jenis_kelamin_txt.Text = dt.Rows(0)("jenis_kelamin").ToString()
            tanggal_txt.Text = dt.Rows(0)("tanggal_lahir").ToString()
            foto_profile.Image = Image.FromFile(dt.Rows(0)("foto_profil").ToString())
        End If
    End Sub

    Private Sub btn_anime_favorit_Click(sender As Object, e As EventArgs) Handles btn_anime_favorit.Click
        main_user.pnl_main.Controls.Clear()
        Dim newForm As New anime_favorit
        newForm.TopLevel = False
        newForm.AutoScroll = True
        main_user.pnl_main.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_edit_profile.Click
        main_user.username_TXT.Text = nama_txt.Text
        edit_profile.Show()
    End Sub
End Class