Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Public Class Appointments

    Dim apts As New List(Of Apt)
    Dim aptSorted As New List(Of Apt)
    Dim aptsToday As New List(Of Apt)
    Dim AddTapped As Integer = 0
    Dim EditTapped As Integer = 0
    Dim today
    Dim curEdtID
    Dim tmpApt

    Private Sub Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        positionItems()
        aptLblDatToday.Text = Date.Now.ToString("dd/MM/yyyy")
        today = Date.Now.ToString("dd/MM/yyyy").Split("/")

        colorize()

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
        '- Si is the selected index
        Dim si As Integer = ListBox1.SelectedIndex

        '- Put Selected index's Data in TextBox
        aptLblIDV.Text = aptSorted.Item(si).id
        aptLblNameV.Text = aptSorted.Item(si).name
        aptLblPhoneV.Text = aptSorted.Item(si).phone
        aptLblDateV.Text = aptSorted.Item(si).dat
        aptLblTimeV.Text = aptSorted.Item(si).tim

        '- Set Variables for Add, Edit and Delete
        tmpApt = aptSorted.Item(si)
        curEdtID = aptSorted.Item(si).id
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
        aptLblIDV.Location = New Point(picZX + pB2W / 3, picZY)
        aptLblNameT.Location = New Point(picZX + 20, picZY + pB2H / 7)
        aptLblNameV.Location = New Point(picZX + pB2W / 3, picZY + pB2H / 7)
        aptLblPhoneT.Location = New Point(picZX + 20, picZY + pB2H / 7 * 2)
        aptLblPhoneV.Location = New Point(picZX + pB2W / 3, picZY + pB2H / 7 * 2)
        aptLbldateT.Location = New Point(picZX + 20, picZY + pB2H / 7 * 3)
        aptLblDateV.Location = New Point(picZX + pB2W / 3, picZY + pB2H / 7 * 3)
        aptLblTimeT.Location = New Point(picZX + 20, picZY + pB2H / 7 * 4)
        aptLblTimeV.Location = New Point(picZX + pB2W / 3, picZY + pB2H / 7 * 4)
        '- Position The Search Box
        PictureBox1.Location = New Point(width / 2 - PictureBox1.Width / 2, height / 5 - PictureBox1.Height - 10)
        aptSearchBarTxt.Location = New Point(pBZX1 + 5, PictureBox1.Location.Y + PictureBox1.Height / 2 - aptSearchBarTxt.Height / 2)
        aptSearchBarBtn.Location = New Point(aptSearchBarTxt.Location.X + aptSearchBarTxt.Width, PictureBox1.Location.Y + PictureBox1.Height / 2 - aptSearchBarTxt.Height / 2)
        '- Position Add Btn
        AptBtnAdd.Location = New Point(PictureBox2.Location.X, picZY + pB2H / 7 * 6)
        '- Position Add TBs
        aptLblNameAdd.Location = New Point(aptLblNameV.Location.X + aptLblNameV.Width + 10, aptLblNameV.Location.Y)
        aptLblPhoneAdd.Location = New Point(aptLblPhoneV.Location.X + aptLblPhoneV.Width + 10, aptLblPhoneV.Location.Y)
        aptLblDateAdd.Location = New Point(aptLblDateV.Location.X + aptLblDateV.Width + 10, aptLblDateV.Location.Y)
        aptLblTimeAdd.Location = New Point(aptLblTimeV.Location.X + aptLblTimeV.Width + 10, aptLblTimeV.Location.Y)
        '- Today Label aptLblDatToday
        aptLblDatTodayBg.Location = New Point(10 + PictureBox3.Width / 2 - aptLblDatTodayBg.Width / 2, height / 5 - PictureBox1.Height - 10)
        aptLblDatToday.Location = New Point(aptLblDatTodayBg.Location.X + ((aptLblDatTodayBg.Width - aptLblDatToday.Width) / 2), aptLblDatTodayBg.Location.Y + ((aptLblDatTodayBg.Height - aptLblDatToday.Height) / 2))
        aptLblDatPrv.Location = New Point(aptLblDatTodayBg.Location.X - aptLblDatPrv.Width - 10, aptLblDatTodayBg.Location.Y)
        aptLblDatNxt.Location = New Point(aptLblDatTodayBg.Location.X + aptLblDatTodayBg.Width + 10, aptLblDatTodayBg.Location.Y)
        '- Edit Btn
        AptBtnEdit.Location = New Point(PictureBox2.Location.X + PictureBox2.Width / 2 - AptBtnEdit.Width / 2, picZY + pB2H / 7 * 6)
        '- Delete btn
        AptBtnDelete.Location = New Point(PictureBox2.Location.X + PictureBox2.Width - AptBtnDelete.Width, picZY + pB2H / 7 * 6)

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

        '- Download Data from DB
        Dim res As FirebaseResponse = client.Get("apts")
        Dim data As Dictionary(Of String, Apt) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Apt))(Res.Body.ToString())

        '- Add This Data To A List
        For Each tmpApt As KeyValuePair(Of String, Apt) In data
            apts.Add(tmpApt.Value)
        Next

        '- Sort The List
        sortByDate(today)

        '- Display the list inside listbox
        For i As Integer = 0 To aptSorted.Count - 1
            ListBox1.Items.Add(New String(aptSorted(i).tim + " - " + aptSorted(i).name))
        Next

    End Function

    Function sortByDate(ByVal dat)

        Dim todayD = Convert.ToInt32(today(0))
        Dim todayM = Convert.ToInt32(today(1))
        Dim todayY = Convert.ToInt32(today(2))

        For i = 0 To apts.Count - 1
            Dim idat = apts(i).dat.Split("/")
            Dim iday = Convert.ToInt32(idat(0))
            Dim iMon = Convert.ToInt32(idat(1))
            Dim iYea = Convert.ToInt32(idat(2))

            If (todayY = iYea And todayM = iMon And todayD = iday) Then
                aptsToday.Add(apts(i))
            End If

        Next

        SortByTime()

    End Function

    Function SortByTime()

        For i = 0 To aptsToday.Count - 1
            For j = 0 To aptsToday.Count - 2
                Dim tim1S = aptsToday(j).tim.Split(":")
                Dim tim2S = aptsToday(j + 1).tim.Split(":")
                Dim tim1 = Convert.ToInt32(tim1S(0))
                Dim tim2 = Convert.ToInt32(tim2S(0))
                Dim tim3 = Convert.ToInt32(tim1S(1))
                Dim tim4 = Convert.ToInt32(tim2S(1))

                If (tim1 > tim2) Then
                    Dim tmpApt = aptsToday(j)
                    aptsToday(j) = aptsToday(j + 1)
                    aptsToday(j + 1) = tmpApt
                End If
            Next
        Next

        For i = 0 To aptsToday.Count - 1 Step 2

            If aptsToday.Count Mod 2 = 0 Then

                Dim tim1S = aptsToday(i).tim.Split(":")
                Dim tim2S = aptsToday(i + 1).tim.Split(":")
                Dim tim1 = Convert.ToInt32(tim1S(0))
                Dim tim2 = Convert.ToInt32(tim2S(0))
                Dim tim3 = Convert.ToInt32(tim1S(1))
                Dim tim4 = Convert.ToInt32(tim2S(1))

                If tim1 = tim2 And tim3 > tim4 Then

                    Dim tmpApt = aptsToday(i)
                    aptsToday(i) = aptsToday(i + 1)
                    aptsToday(i + 1) = tmpApt

                    aptSorted.Add(aptsToday(i))
                    aptSorted.Add(aptsToday(i + 1))

                Else

                    aptSorted.Add(aptsToday(i))
                    aptSorted.Add(aptsToday(i + 1))

                End If

            Else

                If i < aptsToday.Count - 1 Then
                    Dim tim1S = aptsToday(i).tim.Split(":")
                    Dim tim2S = aptsToday(i + 1).tim.Split(":")
                    Dim tim1 = Convert.ToInt32(tim1S(0))
                    Dim tim2 = Convert.ToInt32(tim2S(0))
                    Dim tim3 = Convert.ToInt32(tim1S(1))
                    Dim tim4 = Convert.ToInt32(tim2S(1))

                    If tim1 = tim2 And tim3 > tim4 Then

                        Dim tmpApt = aptsToday(i)
                        aptsToday(i) = aptsToday(i + 1)
                        aptsToday(i + 1) = tmpApt

                        aptSorted.Add(aptsToday(i))
                        aptSorted.Add(aptsToday(i + 1))

                    Else

                        aptSorted.Add(aptsToday(i))
                        aptSorted.Add(aptsToday(i + 1))

                    End If

                Else
                    aptSorted.Add(aptsToday(i))
                End If

            End If

        Next

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

    '- Back Btn Tapped
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

    '- Add Btn Tapped
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
            aptsToday.Clear()
            aptSorted.Clear()
            ListBox1.Items.Clear()
            readDB()

            AptBtnAdd.Text = "ADD"

        End If



    End Sub

    '- Next Btn Tapped
    Private Sub aptLblDatNxt_Click(sender As Object, e As EventArgs) Handles aptLblDatNxt.Click

        Dim todayD = Convert.ToInt32(today(0))
        Dim todayM = Convert.ToInt32(today(1))
        Dim todayY = Convert.ToInt32(today(2))
        todayD = todayD + 1
        Dim tmpDat = todayD & "/" & todayM & "/" & todayY
        today = tmpDat.Split("/")

        apts.Clear()
        aptsToday.Clear()
        aptSorted.Clear()
        ListBox1.Items.Clear()

        aptLblDatToday.Text = tmpDat

        readDB()

    End Sub

    '- Previous Btn Tapped
    Private Sub aptLblDatPrv_Click(sender As Object, e As EventArgs) Handles aptLblDatPrv.Click

        Dim todayD = Convert.ToInt32(today(0))
        Dim todayM = Convert.ToInt32(today(1))
        Dim todayY = Convert.ToInt32(today(2))
        todayD = todayD - 1
        Dim tmpDat = todayD & "/" & todayM & "/" & todayY
        today = tmpDat.Split("/")

        apts.Clear()
        aptsToday.Clear()
        aptSorted.Clear()
        ListBox1.Items.Clear()

        aptLblDatToday.Text = tmpDat

        readDB()

    End Sub

    '- Edit Btn tapped
    Private Sub AptBtnEdit_Click(sender As Object, e As EventArgs) Handles AptBtnEdit.Click

        AptBtnEdit.Text = "DONE"

        aptLblIDV.Hide()
        aptLblNameV.Hide()
        aptLblPhoneV.Hide()
        aptLblDateV.Hide()
        aptLblTimeV.Hide()

        aptLblNameAdd.Show()
        aptLblPhoneAdd.Show()
        aptLblDateAdd.Show()
        aptLblTimeAdd.Show()

        EditTapped = EditTapped + 1

        If EditTapped = 1 Then

            aptLblNameAdd.Text = aptLblNameV.Text
            aptLblPhoneAdd.Text = aptLblPhoneV.Text
            aptLblDateAdd.Text = aptLblDateV.Text
            aptLblTimeAdd.Text = aptLblTimeV.Text

        End If

        If EditTapped = 2 Then

            Dim tmpApt As Apt = New Apt(curEdtID, aptLblNameAdd.Text, aptLblPhoneAdd.Text, aptLblDateAdd.Text, aptLblTimeAdd.Text)
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
            aptsToday.Clear()
            aptSorted.Clear()
            ListBox1.Items.Clear()
            readDB()

            AptBtnEdit.Text = "EDIT"

            EditTapped = 0
        End If

    End Sub

    '- Delete Btn Tapped
    Private Sub AptBtnDelete_Click(sender As Object, e As EventArgs) Handles AptBtnDelete.Click
        client.Delete("apts/" + tmpApt.id)

        apts.Clear()
        aptsToday.Clear()
        aptSorted.Clear()
        ListBox1.Items.Clear()
        readDB()

    End Sub
End Class