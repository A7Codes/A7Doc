Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Public Class Form1

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "Jromu0smUgb7U17LfWempDHjG9HKgD0HnxWMRsaV",
        .BasePath = "https://a7doc-90432-default-rtdb.europe-west1.firebasedatabase.app/"
        }

    Private client As IFirebaseClient

    Public CurForm As Form = Dashboard

    Public y = Screen.PrimaryScreen.Bounds.Height / 3
    Public x = Screen.PrimaryScreen.Bounds.Width / 3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        '- Connecting to DB
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("Internet connection Error")
        End Try



        Panel1.Controls.Clear()
        Dashboard.TopLevel = False
        Panel1.Controls.Add(Dashboard)
        Dashboard.Show()
        Panel1.Size = Me.Size
        Dashboard.Size = Panel1.Size

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Panel1.Size = Me.Size
        CurForm.Size = Panel1.Size
    End Sub

End Class
