Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Public Class Appointments

    Dim apts As New List(Of Apt)
    Dim aptSorted As New List(Of Apt)
    Dim AddTapped As Integer = 0

    Private Sub Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        colorize()
        positionItems()
        readDB()

        aptLblNameAdd.Hide()
        aptLblPhoneAdd.Hide()
        aptLblDateAdd.Hide()
        aptLblTimeAdd.Hide()



    End Sub



    Function colorize()
        aptSearchBarTxt.BackColor = Color.FromArgb(0, 228, 46)
        aptSearchBarBtn.BackColor = Color.FromArgb(0, 228, 46)
        ListBox1.BackColor = Color.FromArgb(0, 60, 148)
        aptLblIDT.BackColor = Color.FromArgb(0, 60, 148)
        aptLblNameT.BackColor = Color.FromArgb(0, 60, 148)
        aptLblPhoneT.BackColor = Color.FromArgb(0, 60, 148)
        aptLbldateT.BackColor = Color.FromArgb(0, 60, 148)
        aptLblTimeT.BackColor = Color.FromArgb(0, 60, 148)
        aptLblIDV.BackColor = Color.FromArgb(0, 60, 148)
        aptLblNameV.BackColor = Color.FromArgb(0, 60, 148)
        aptLblPhoneV.BackColor = Color.FromArgb(0, 60, 148)
        aptLblDateV.BackColor = Color.FromArgb(0, 60, 148)
        aptLblTimeV.BackColor = Color.FromArgb(0, 60, 148)
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim si As Integer = ListBox1.SelectedIndex
        aptLblIDV.Text = apts.Item(si).id
        aptLblNameV.Text = apts.Item(si).name
        aptLblPhoneV.Text = apts.Item(si).phone
        aptLblDateV.Text = apts.Item(si).dat
        aptLblTimeV.Text = apts.Item(si).tim
    End Sub

    Function positionItems()
        '- Variables
        Dim width = Screen.PrimaryScreen.Bounds.Width
        Dim height = Screen.PrimaryScreen.Bounds.Height
        Dim picZX = PictureBox2.Location.X
        Dim picZY = PictureBox2.Location.Y
        Dim pB2H = PictureBox2.Bounds.Height
        Dim pB2W = PictureBox2.Bounds.Width
        Dim pBZX3 = PictureBox3.Location.X
        Dim pBZY3 = PictureBox3.Location.Y
        Dim pBZX1 = PictureBox1.Location.X
        Dim pBZY1 = PictureBox1.Location.Y
        '- Position the List Box
        PictureBox3.Location = New Point(10, height / 5)
        ListBox1.Location = New Point(pBZX3 + 5, pBZY3 + 30)
        '- Position The Details Box
        PictureBox2.Location = New Point(width / 2 - PictureBox2.Width / 2, height / 5)
        aptLblIDT.Location = New Point(picZX + 20, picZY)
        aptLblIDV.Location = New Point(picZX + pB2W / 2, picZY)
        aptLblNameT.Location = New Point(picZX + 20, picZY + pB2H / 7)
        aptLblNameV.Location = New Point(picZX + pB2W / 2, picZY + pB2H / 7)
        aptLblPhoneT.Location = New Point(picZX + 20, picZY + pB2H / 7 * 2)
        aptLblPhoneV.Location = New Point(picZX + pB2W / 2, picZY + pB2H / 7 * 2)
        aptLbldateT.Location = New Point(picZX + 20, picZY + pB2H / 7 * 3)
        aptLblDateV.Location = New Point(picZX + pB2W / 2, picZY + pB2H / 7 * 3)
        aptLblTimeT.Location = New Point(picZX + 20, picZY + pB2H / 7 * 4)
        aptLblTimeV.Location = New Point(picZX + pB2W / 2, picZY + pB2H / 7 * 4)
        '- Position The Search Box
        PictureBox1.Location = New Point(width / 2 - PictureBox1.Width / 2, height / 5 - PictureBox1.Height - 10)
        aptSearchBarTxt.Location = New Point(pBZX1 + 5, PictureBox1.Location.Y + PictureBox1.Height / 2 - aptSearchBarTxt.Height / 2)
        aptSearchBarBtn.Location = New Point(aptSearchBarTxt.Location.X + aptSearchBarTxt.Width, PictureBox1.Location.Y + PictureBox1.Height / 2 - aptSearchBarTxt.Height / 2)
        '- Position Add Btn
        AptBtnAdd.Location = New Point(width / 2 - PictureBox1.Width / 2, picZY + pB2H / 7 * 6)
        '- Position Add TBs
        aptLblNameAdd.Location = New Point(aptLblNameV.Location.X + aptLblNameV.Width + 10, aptLblNameV.Location.Y)
        aptLblPhoneAdd.Location = New Point(aptLblPhoneV.Location.X + aptLblPhoneV.Width + 10, aptLblPhoneV.Location.Y)
        aptLblDateAdd.Location = New Point(aptLblDateV.Location.X + aptLblDateV.Width + 10, aptLblDateV.Location.Y)
        aptLblTimeAdd.Location = New Point(aptLblTimeV.Location.X + aptLblTimeV.Width + 10, aptLblTimeV.Location.Y)

    End Function

    '- DB Connection
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "Jromu0smUgb7U17LfWempDHjG9HKgD0HnxWMRsaV",
        .BasePath = "https://a7doc-90432-default-rtdb.europe-west1.firebasedatabase.app/"
        }

    Private client As IFirebaseClient
    Function readDB()
        '- Connecting to DB
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("Internet connection Error")
        End Try

        Dim res As FirebaseResponse = client.Get("apts")
        Dim data As Dictionary(Of String, Apt) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Apt))(res.Body.ToString())

        For Each tmpApt As KeyValuePair(Of String, Apt) In data
            apts.Add(tmpApt.Value)
        Next


        For i As Integer = 0 To apts.Count - 1
            ListBox1.Items.Add(New String(apts(i).tim + " - " + apts(i).name))
        Next

    End Function

    Function SortByTime()

    End Function

    '- Search Btn Tapped
    Private Sub aptSearchBarBtn_Click(sender As Object, e As EventArgs) Handles aptSearchBarBtn.Click
        Dim tmpApt As Apt

        For Each ta As Apt In apts
            If ta.name.ToLower = aptSearchBarTxt.Text.ToLower Or ta.phone = aptSearchBarTxt.Text Then
                aptLblIDV.Text = ta.id
                aptLblNameV.Text = ta.name
                aptLblPhoneV.Text = ta.phone
                aptLblDateV.Text = ta.dat
                aptLblTimeV.Text = ta.tim
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.CurForm = Dashboard
        Dim Panel1 = Form1.Panel1
        Panel1.Controls.Clear()
        Dashboard.TopLevel = False
        Panel1.Controls.Add(Dashboard)
        Dashboard.Show()
        Panel1.Size = Me.Size
        Dashboard.Size = Panel1.Size

    End Sub

    Private Sub AptBtnAdd_Click(sender As Object, e As EventArgs) Handles AptBtnAdd.Click
        AptBtnAdd.Text = "DONE"

        aptLblIDV.Hide()
        aptLblNameV.Hide()
        aptLblPhoneV.Hide()
        aptLblDateV.Hide()
        aptLblTimeV.Hide()

        aptLblNameAdd.Show()
        aptLblPhoneAdd.Show()
        aptLblDateAdd.Show()
        aptLblTimeAdd.Show()

        AddTapped += 1

        If AddTapped = 2 Then

            Dim dateStr = aptLblDateAdd.Text.Split("/")
            Dim lastID = aptLblPhoneAdd.Text + dateStr(0) + dateStr(1) + dateStr(2)
            Dim tmpApt As Apt = New Apt(lastID, aptLblNameAdd.Text, aptLblPhoneAdd.Text, aptLblDateAdd.Text, aptLblTimeAdd.Text)
            Dim setter = client.Set("apts/" + tmpApt.id, tmpApt)

            aptLblNameAdd.Hide()
            aptLblPhoneAdd.Hide()
            aptLblDateAdd.Hide()
            aptLblTimeAdd.Hide()

            aptLblIDV.Show()
            aptLblNameV.Show()
            aptLblPhoneV.Show()
            aptLblDateV.Show()
            aptLblTimeV.Show()

            apts.Clear()
            ListBox1.Items.Clear()
            readDB()

        End If



    End Sub


End Class