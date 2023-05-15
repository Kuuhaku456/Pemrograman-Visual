Imports MySql.Data.MySqlClient
Imports System.IO

Public Class main_user
    Private lastsize As Size
    Private Sub ONGOINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ONGOINGToolStripMenuItem.Click
        pnl_main.Controls.Clear()
        Dim newForm As New Ongoing
        newForm.TopLevel = False
        newForm.AutoScroll = True
        pnl_main.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Private Sub main_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        lastsize = Me.Size
        Label_judul.Location = New Point((Me.Width / 2) - (Label_judul.Width / 2), 26)
        username_TXT.Location = New Point(Label_judul.Location.X + Label_judul.Width + 150, 30)
        foto_profile.Location = New Point(username_TXT.Location.X + username_TXT.Width + 40, (Panel1.Height / 2) - (foto_profile.Height / 2))
        pnl_main.Controls.Clear()
        Dim newForm As New All_animes
        newForm.TopLevel = False
        newForm.AutoScroll = True
        pnl_main.Controls.Add(newForm)
        newForm.Show()
    End Sub
    Private Sub sb_vertikal_Scroll(sender As Object, e As ScrollEventArgs)
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            pnl_main.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub sb_horizontal_Scroll(sender As Object, e As ScrollEventArgs) 
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
            pnl_main.HorizontalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub main_user_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Size.Width = lastsize.Width AndAlso Me.Size.Height = lastsize.Height Then
            Label_judul.Location = New Point((Me.Width / 2) - (Label_judul.Width / 2), 26)
            username_TXT.Location = New Point(Label_judul.Location.X + Label_judul.Width + 150, 30)
            foto_profile.Location = New Point(username_TXT.Location.X + username_TXT.Width + 40, (Panel1.Height / 2) - (foto_profile.Height / 2))
        ElseIf Me.Size.Width < lastsize.Width AndAlso Me.Size.Height < lastsize.Height Then
            Label_judul.Location = New Point((Me.Width / 2) - (Label_judul.Width / 2), 26)
            username_TXT.Location = New Point(Label_judul.Location.X + Label_judul.Width + 40, 30)
            foto_profile.Location = New Point(username_TXT.Location.X + username_TXT.Width + 20, (Panel1.Height / 2) - (foto_profile.Height / 2))
        End If
    End Sub

    Private Sub COMPLETEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPLETEDToolStripMenuItem.Click
        pnl_main.Controls.Clear()
        Dim newForm As New Completed
        newForm.TopLevel = False
        newForm.AutoScroll = True
        pnl_main.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Private Sub btn_log_out_Click(sender As Object, e As EventArgs) Handles btn_log_out.Click
        Me.Hide()
        login_user.Show()
    End Sub

    Private Sub foto_profile_Click(sender As Object, e As EventArgs) Handles foto_profile.Click
        pnl_main.Controls.Clear()
        Dim newForm As New form_profil
        newForm.TopLevel = False
        newForm.AutoScroll = True
        pnl_main.Controls.Add(newForm)
        newForm.Show()
    End Sub
End Class