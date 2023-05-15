Public Class Form1
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Try
            With OpenFileDialog1
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "jpg"
                .DereferenceLinks = True
                .FileName = ""
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All Files|*.*"
                .Multiselect = False

                .RestoreDirectory = True
                .Title = "SELECT FILE TO OPEN"
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBoxProfile.ImageLocation = .FileName
                        PictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If
            End With
        Catch ex As Exception

        End Try
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

    Private Sub nomor_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomor_txt.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub nama_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nama_txt.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Kartuvb.nim_txt.Text = nim_txt.Text
        Kartuvb.nama_txt.Text = nama_txt.Text
        Kartuvb.fakultas_txt.Text = fakultas_txt.Text
        Kartuvb.alamat_txt.Text = alamat_txt.Text
        Kartuvb.nomor_txt.Text = nomor_txt.Text
        Kartuvb.email_txt.Text = surel_txt.Text
        Kartuvb.txt_tanggal.Text = dtp_tanggal.Value
        Kartuvb.PictureBoxProfile.Image = PictureBoxProfile.Image
        Kartuvb.Show()
        Me.Hide()
    End Sub

    Private Sub nim_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nim_txt.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub fakultas_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fakultas_txt.KeyPress
        HanyaHuruf(e)
    End Sub
End Class
