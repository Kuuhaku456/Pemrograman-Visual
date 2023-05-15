Public Class Loading_page
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_progress.Text = PBloading.Value & "%"

        PBloading.Value += 1

        If PBloading.Value > 10 Then
            lbl_status.Text = "Please Wait. . ."
        End If

        If PBloading.Value > 35 Then
            lbl_status.Text = "Intialize Component. . ."
        End If

        If PBloading.Value > 65 Then
            lbl_status.Text = "Read Component. . ."
        End If

        If PBloading.Value > 90 Then
            lbl_status.Text = "Almost There. . ."
        End If

        If PBloading.Value = 100 Then
            lbl_status.Text = "Done, Launching the application!"
            Timer1.Dispose()
            Threading.Thread.Sleep(2000)
            login_user.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Loading_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class