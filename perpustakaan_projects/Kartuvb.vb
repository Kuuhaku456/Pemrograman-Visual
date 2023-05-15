Imports System.Drawing.Printing
Imports ZXing
Imports QRCoder
Imports System.CodeDom.Compiler

Public Class Kartuvb
    Private bitmap As Bitmap
    Private WithEvents ppd As New PrintPreviewDialog
    Private Sub Kartuvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Writer As New BarcodeWriter
        Dim generator As New QRCodeGenerator
        Writer.Format = BarcodeFormat.CODE_128
        PictureBoxBarcode.Image = Writer.Write(nim_txt.Text)

        Dim data = generator.CreateQrCode(nim_txt.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        PictureBoxQRCODE.Image = code.GetGraphic(6)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 120, 120)
    End Sub

    Public Sub print()
        Dim panel As Panel = New Panel()
        Me.Controls.Add(panel)
        Dim grp As Graphics = panel.CreateGraphics
        Dim formsize As Size = Me.ClientSize
        bitmap = New Bitmap(formsize.Width, formsize.Height, grp)
        grp = Graphics.FromImage(bitmap)
        Dim panellocation As Point = PointToScreen(panel.Location)
        grp.CopyFromScreen(panellocation.X, panellocation.Y, 0, 0, formsize)
        ppd.Document = PrintDocument1
        ppd.PrintPreviewControl.Zoom = 1.0
        ppd.ShowDialog()
        Return
    End Sub

    Private Sub PictureBoxProfile_Click(sender As Object, e As EventArgs) Handles PictureBoxProfile.Click
        Dim pd As New Printing.PrintDocument()
        AddHandler pd.PrintPage, AddressOf PrintPageHandler

        pd.DefaultPageSettings.PaperSize = New Printing.PaperSize("A5", 2583, 1827)

        Dim ppd As New PrintPreviewDialog()
        ppd.Document = pd
        ppd.ShowDialog()
        Me.Hide()
        'pd.Print()
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As Printing.PrintPageEventArgs)
        'Menentukan tata letak kartu dan mengisi data anggota ke dalamnya'
        'Variabel untuk menentukan ukuran kartu'
        Dim cardWidth As Integer = 698
        Dim cardHeight As Integer = 500

        'Variabel untuk bitmap screenshot form kartu'
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))

        'Menggambar bitmap ke dalam print document'

        Dim x As Integer = e.MarginBounds.X 'kordinat X, margin bound
        Dim y As Integer = e.MarginBounds.Y 'kordinat Y, margin bound
        Dim width As Integer = e.MarginBounds.Width 'lebar area cetak, margin bound
        Dim height As Integer = e.MarginBounds.Height 'tinggi area cetak, margin bound

        'Menyesuaikan ukuran gambar agar sesuai dengan ukuran kertas A5
        Dim ratio As Single = cardHeight / cardWidth 'rasio ukuran kartu
        If height > width Then
            'Portrait mode, lebar area cetak lebih kecil dari tinggi area cetak
            width = height / ratio
        Else
            'Landscape mode, tinggi area cetak lebih kecil dari lebar area cetak
            height = width * ratio
        End If

        e.Graphics.DrawImage(bmp, x, y, width, height)

    End Sub
End Class