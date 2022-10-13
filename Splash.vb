Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cX = Screen.PrimaryScreen.Bounds.Width / 2
        Dim cY = Screen.PrimaryScreen.Bounds.Height / 2

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Panel1.Controls.Clear()
        Dashboard.TopLevel = False
        Form1.Panel1.Controls.Add(Dashboard)
        Dashboard.Show()
        Form1.Panel1.Size = Me.Size
        Dashboard.Size = Form1.Panel1.Size
    End Sub
End Class