Imports MySql.Data.MySqlClient
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO

Public Class Daftar
    Private Sub Daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = "C:\Praktikum_Pem_visual\PA_FIX\foto_akun\user.png"
        connect()
        password_TXT.UseSystemPasswordChar = True
        foto_daftar.Image = Image.FromFile(path)
        cls()
    End Sub

    Private Sub cls()
        username_TXT.Text = ""
        password_TXT.Text = ""
        telepon_TXT.Text = ""
        dtpTangalLahir.Value = DateTime.Now.Date
        path_txt.Text = ""
    End Sub


    Private Function cek_kosong()
        If username_TXT.Text = "" Then
            MessageBox.Show("Username harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            username_TXT.Focus()
        ElseIf password_TXT.Text = "" Then
            MessageBox.Show("Password harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            password_TXT.Focus()
        ElseIf password_TXT.TextLength <> 8 Then
            MessageBox.Show("Password harus terdiri dari 8 karakter Tuan!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            password_TXT.Focus()
        ElseIf telepon_TXT.Text = "" Then
            MessageBox.Show("Password harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            telepon_TXT.Focus()
        ElseIf dtpTangalLahir.Value = DateTime.Now.Date Then
            MessageBox.Show("Masa Tuan baru lahir sekarang >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTangalLahir.Focus()
        ElseIf path_txt.Text = "" Then
            MessageBox.Show("Masa Foto Tuan gak ada >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf foto_daftar.Image Is Nothing Then
            MessageBox.Show("Masa Foto Tuan gak ada >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not RB_Laki.Checked And Not RB_cewe.Checked Then
            MessageBox.Show("Jenis kelamin harus dipilih Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files (*.jpg, *.png, *.gif, *.bmp)|*.jpg; *.png; *.gif; *.bmp"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedImage As String = openFileDialog1.FileName
            path_txt.Text = selectedImage
            foto_daftar.Image = Image.FromFile(selectedImage)
        End If
    End Sub

    Private Sub cbpass_CheckedChanged(sender As Object, e As EventArgs) Handles cbpass.CheckedChanged
        If cbpass.Checked Then
            password_TXT.UseSystemPasswordChar = False
        Else
            password_TXT.UseSystemPasswordChar = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        If cek_kosong() = True Then
            Try
                'Untuk menegecek apakah username sudah terdaftar atau belum
                CMD = New MySqlCommand("SELECT COUNT(*) FROM tb_akun WHERE username = @username", CONN)
                CMD.Parameters.AddWithValue("@username", username_TXT.Text)
                CMD.Parameters.AddWithValue("@nomor_telepon", telepon_TXT.Text)
                Dim count As Integer = Convert.ToInt32(CMD.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Username'" & username_TXT.Text & "' sudah terdaftar, silahkan gunakan username lain.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                    username_TXT.Focus()
                End If

                CMD = New MySqlCommand("Select COUNT(*) FROM tb_akun WHERE nomor_telepon =@nomor_telepon", CONN)
                CMD.Parameters.AddWithValue("@nomor_telepon", telepon_TXT.Text)
                Dim Counts As Integer = Convert.ToInt32(CMD.ExecuteScalar())
                If Counts > 0 Then
                    MessageBox.Show("Nomor telepon'" & telepon_TXT.Text & "' sudah terdaftar, silahkan gunakan nomor telepon lain.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                    telepon_TXT.Focus()
                End If

                'Insert data ke dalam database
                Dim query As String = "INSERT INTO tb_akun (id , username, password, jenis_kelamin, nomor_telepon, tanggal_lahir, foto_profil) VALUES (@id , @username, @password, @jenis_kelamin, @nomor_telepon, @tanggal_lahir, @foto_profil)"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@id", "")
                CMD.Parameters.AddWithValue("@username", username_TXT.Text)
                CMD.Parameters.AddWithValue("@password", password_TXT.Text)

                If RB_Laki.Checked Then
                    CMD.Parameters.AddWithValue("@jenis_kelamin", "Laki-laki")
                Else
                    CMD.Parameters.AddWithValue("@jenis_kelamin", "Perempuan")
                End If

                CMD.Parameters.AddWithValue("@nomor_telepon", telepon_TXT.Text)
                CMD.Parameters.AddWithValue("@tanggal_lahir", dtpTangalLahir.Value.Date)
                CMD.Parameters.AddWithValue("@foto_profil", path_txt.Text)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cls()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Dim pesan As String = "Apakah anda ingin kembali?"
        Dim judul As String = "Konfirmasi Kembali"
        Dim hasil As DialogResult = MessageBox.Show(pesan, judul, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Me.Hide()
            login_user.Show()
        End If
    End Sub

    Private Sub telepon_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telepon_TXT.KeyPress
        HanyaAngka(e)
    End Sub

End Class