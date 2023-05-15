Imports MySql.Data.MySqlClient
Public Class edit_profile
    Private id_edit_user As Integer
    Private Sub edit_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
        'display()
        edit_password_txt.UseSystemPasswordChar = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
    Private Sub cbpass_CheckedChanged(sender As Object, e As EventArgs)
        If edit_cb_password.Checked Then
            edit_password_txt.UseSystemPasswordChar = False
        Else
            edit_password_txt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub display()
        connect()
        id_edit_user = CInt(main_user.id_user.Text)
        Dim jk As String
        Dim SQL As String = "SELECT * FROM tb_akun WHERE id=@id"
        CMD = New MySqlCommand(SQL, CONN)
        CMD.Parameters.AddWithValue("@id", id_edit_user)
        Dim da As New MySqlDataAdapter(CMD)
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            edit_username_txt.Text = dt.Rows(0)("username").ToString()
            edit_password_txt.Text = dt.Rows(0)("password").ToString()
            edit_telepon_txt.Text = dt.Rows(0)("nomor_telepon").ToString()
            dtp_edit_tanggal_lahir.Value = CType(dt.Rows(0)("tanggal_lahir"), Date)
            jk = dt.Rows(0)("jenis_kelamin").ToString()
            If jk = "Laki-laki" Then
                edit_rb_laki_laki.Checked = True
            ElseIf jk = "Perempuan" Then
                edit_RB_perempuan.Checked = True
            End If
            edit_path_txt.Text = dt.Rows(0)("foto_profil").ToString()
            foto_edit.Image = Image.FromFile(edit_path_txt.Text)
        End If
        CONN.Close()
    End Sub
    Private Function cek_kosong()
        If edit_username_txt.Text = "" Then
            MessageBox.Show("Username harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            edit_username_txt.Focus()
        ElseIf edit_password_txt.Text = "" Then
            MessageBox.Show("Password harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            edit_password_txt.Focus()
        ElseIf edit_password_txt.TextLength <> 8 Then
            MessageBox.Show("Password harus terdiri dari 8 karakter Tuan!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            edit_password_txt.Focus()
        ElseIf edit_telepon_txt.Text = "" Then
            MessageBox.Show("Password harus diisi Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            edit_telepon_txt.Focus()
        ElseIf dtp_edit_tanggal_lahir.Value = DateTime.Now.Date Then
            MessageBox.Show("Masa Tuan baru lahir sekarang >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtp_edit_tanggal_lahir.Focus()
        ElseIf edit_path_txt.Text = "" Then
            MessageBox.Show("Masa Foto Tuan gak ada >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf foto_edit.Image Is Nothing Then
            MessageBox.Show("Masa Foto Tuan gak ada >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not edit_RB_Laki_laki.Checked And Not edit_RB_perempuan.Checked Then
            MessageBox.Show("Jenis kelamin harus dipilih Tuan >_< !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub btn_browse_Click(sender As Object, e As EventArgs)
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files (*.jpg, *.png, *.gif, *.bmp)|*.jpg; *.png; *.gif; *.bmp"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedImage As String = openFileDialog1.FileName
            edit_path_txt.Text = selectedImage
            foto_edit.Image = Image.FromFile(selectedImage)
        End If
    End Sub

    Private Sub cls()
        edit_username_txt.Text = ""
        edit_password_txt.Text = ""
        edit_telepon_txt.Text = ""
        dtp_edit_tanggal_lahir.Value = DateTime.Now.Date
        edit_path_txt.Text = ""
        foto_edit.Image = Nothing
        edit_rb_laki_laki.Checked = False
        edit_RB_perempuan.Checked = False
    End Sub
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Apakah Tuan yakin ingin membatalkan perubahan ini?", "Konfirmasi Hapus Data", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Return
            cls()
            'display()
        ElseIf result = DialogResult.No Then
            Return
        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs)
        cls()
        Me.Hide()
    End Sub

    Private Sub telepon_TXT_KeyPress(sender As Object, e As KeyPressEventArgs)
        HanyaAngka(e)
    End Sub

    Private Sub btn_edit_simpan_Click(sender As Object, e As EventArgs) Handles btn_edit_simpan.Click
        If cek_kosong() = True Then
            id_edit_user = CInt(main_user.id_user.Text)
            Dim result As DialogResult = MessageBox.Show("Apakah Tuan yakin ingin menyimpan perubahan ini?", "Konfirmasi Hapus Data", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    connect()
                    Dim username As String = edit_username_txt.Text
                    Dim password As String = edit_password_txt.Text
                    Dim nomor_telepon As String = edit_telepon_txt.Text
                    Dim tanggal_lahir As Date = Format(dtp_edit_tanggal_lahir.Value, "dd-MM-yyyy")
                    Dim path_gambar As String = edit_path_txt.Text
                    Dim sql As String = "UPDATE tb_akun SET username=@username, password=@password, jenis_kelamin=@jenis_kelamin, nomor_telepon=@nomor_telepon, tanggal_lahir=@tanggal_lahir, foto_profil=@foto_profil WHERE id=@id"
                    CMD = New MySqlCommand(sql, CONN)
                    CMD.Parameters.AddWithValue("@id", id_edit_user)
                    CMD.Parameters.AddWithValue("@username", username)
                    CMD.Parameters.AddWithValue("password", password)
                    If edit_rb_laki_laki.Checked Then
                        CMD.Parameters.AddWithValue("@jenis_kelamin", "Laki-laki")
                    Else
                        CMD.Parameters.AddWithValue("@jenis_kelamin", "Perempuan")
                    End If
                    CMD.Parameters.AddWithValue("nomor_telepon", nomor_telepon)
                    CMD.Parameters.AddWithValue("tanggal_lahir", tanggal_lahir)
                    CMD.Parameters.AddWithValue("foto_profil", path_gambar)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("DATA BERHASIL DIRUBAH TUAN >_< !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CONN.Close()
                    'display()
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan saat menyimpan data ke database: " & ex.Message, "EROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Profil tidak jadi dirubah Tuan >_<", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
    End Sub
End Class