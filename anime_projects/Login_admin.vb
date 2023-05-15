Imports MySql.Data.MySqlClient

Public Class Login_admin
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim SQL As String = "SELECT * FROM tb_admin WHERE username=@username AND password=@password"
        CMD = New MySqlCommand(SQL, CONN)
        CMD.Parameters.AddWithValue("@username", username_TXT.Text)
        CMD.Parameters.AddWithValue("@password", password_TXT.Text)
        Dim da As New MySqlDataAdapter(CMD)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("selamat datang Admin", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            form_admin.username_TXT.Text = dt.Rows(0)("username").ToString()
            username_TXT.Text = ""
            password_TXT.Text = ""
            cbpass.Checked = False
            Me.Hide()
            form_admin.Show()
            'FormPemesanan.Nama_TXT.Text = username_TXT.Text
            'FormPemesanan.id_us.Text = dt.Rows(0)("id").ToString()
            'riwayat_pesan.TXT_nama.Text = username_TXT.Text
            'riwayat_pesan.TXT_ID.Text = dt.Rows(0)("id").ToString()
        Else
            getar()
            MessageBox.Show("PENYUSUP!!!! , silahkan input ulang, jika bukan PENYUSUP!!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            username_TXT.Text = ""
            password_TXT.Text = ""
            username_TXT.Focus()
        End If
    End Sub

    Private Sub Login_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        login_user.Show()
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