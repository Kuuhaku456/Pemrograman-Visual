Public Class form_admin
    Private Sub ONGOINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ONGOINGToolStripMenuItem.Click
        pnl_admin.Controls.Clear()
        Dim newForm As New form_CRUD
        newForm.TopLevel = False
        newForm.AutoScroll = True
        pnl_admin.Controls.Add(newForm)
        newForm.Show()
    End Sub

    Private Sub COMPLETEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPLETEDToolStripMenuItem.Click
        pnl_admin.Controls.Clear()
        Dim newForm As New form_CRUD_completed
        newForm.TopLevel = False
        newForm.AutoScroll = True
        pnl_admin.Controls.Add(newForm)
        newForm.Show()
    End Sub
End Class