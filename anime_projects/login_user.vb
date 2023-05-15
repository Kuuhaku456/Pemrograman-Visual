Imports MySql.Data.MySqlClient

Public Class login_user
    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        Me.Hide()
        Daftar.Show()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim SQL As String = "SELECT * FROM tb_akun WHERE username=@username AND password=@password"
        CMD = New MySqlCommand(SQL, CONN)
        CMD.Parameters.AddWithValue("@username", username_TXT.Text)
        CMD.Parameters.AddWithValue("@password", password_TXT.Text)
        Dim da As New MySqlDataAdapter(CMD)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Login berhasil Tuan >_<!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            main_user.id_user.Text = dt.Rows(0)("id").ToString()
            'edit_profile.id_txt.Text = dt.Rows(0)("id").ToString()
            main_user.foto_profile.Image = Image.FromFile(dt.Rows(0)("foto_profil").ToString())
            main_user.username_TXT.Text = username_TXT.Text
            username_TXT.Text = ""
            password_TXT.Text = ""
            cbpass.Checked = False
            main_user.Show()
        Else
            getar()
            MessageBox.Show("Username atau password salah tuan >_<!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            username_TXT.Text = ""
            password_TXT.Text = ""
            username_TXT.Focus()
        End If
    End Sub

    Private Sub Landing_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        password_TXT.UseSystemPasswordChar = True
        username_TXT.Text = ""
        password_TXT.Text = ""
        cbpass.Checked = False
    End Sub

    Private Sub cbpass_CheckedChanged(sender As Object, e As EventArgs) Handles cbpass.CheckedChanged
        If cbpass.Checked = True Then
            password_TXT.UseSystemPasswordChar = False
        Else
            password_TXT.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Me.Hide()
        Login_admin.Show()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Dim pesan As String = "Apakah anda yakin ingin keluar dari program?"
        Dim judul As String = "Konfirmasi Keluar"
        Dim hasil As DialogResult = MessageBox.Show(pesan, judul, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub getar()
        For i As Integer = 1 To 10
            If i Mod 2 = 0 Then
                Me.Location = New Point(Me.Location.X + 10, Me.Location.Y - 10)
            Else
                Me.Location = New Point(Me.Location.X - 10, Me.Location.Y + 10)
            End If
            Threading.Thread.Sleep(25)
        Next

    End Sub
End Class