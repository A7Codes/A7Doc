Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json

Public Class Patient

    Dim addBtnTaps = 0
    Dim edtBtnTaps = 0
    Dim pats As New List(Of Pat)
    '- DB Connection
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "Jromu0smUgb7U17LfWempDHjG9HKgD0HnxWMRsaV",
        .BasePath = "https://a7doc-90432-default-rtdb.europe-west1.firebasedatabase.app/"
        }
    Private client As IFirebaseClient


    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        positionItems()
        hideTB()

        '- Connecting to DB
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("Internet connection Error")
        End Try

        readDB()

    End Sub

    Function positionItems()

        '- Variables
        Dim midScrnX = Screen.PrimaryScreen.Bounds.Width / 2
        Dim midScrnY = Screen.PrimaryScreen.Bounds.Height / 5
        '- The Picture
        patDetailsBG.Location = New Point(midScrnX, midScrnY)
        '- The Labels
        Dim picX = patDetailsBG.Location.X
        Dim picY = patDetailsBG.Location.Y
        Dim picW = patDetailsBG.Width
        Dim picH = patDetailsBG.Height
        patLblName.Location = New Point(picX + picW / 10, picY + picH / 4)
        patLblPhone.Location = New Point(picX + picW / 10, picY + picH / 4 * 2)
        patLblAddress.Location = New Point(picX + picW / 10, picY + picH / 4 * 3)
        '- The Values
        patLblNameV.Location = New Point(picX + picW / 3, picY + picH / 4)
        patLblPhoneV.Location = New Point(picX + picW / 3, picY + picH / 4 * 2)
        patLblAddressV.Location = New Point(picX + picW / 3, picY + picH / 4 * 3)
        '- The TB
        patLblNameTB.Location = New Point(picX + picW - 300, picY + picH / 4)
        patLblPhoneTB.Location = New Point(picX + picW - 300, picY + picH / 4 * 2)
        patLblAddressTB.Location = New Point(picX + picW - 300, picY + picH / 4 * 3)
        '- Search Bar
        Dim searchBarW = patSearchBG.Width
        Dim searchBarH = patSearchBG.Height
        patSearchBG.Location = New Point(picX + (picW / 2) - (searchBarW / 2), picY - patSearchBG.Height)
        Dim searchBarX = patSearchBG.Location.X
        Dim searchBarY = patSearchBG.Location.Y
        patSearchBarTxt.Location = New Point(searchBarX + searchBarW / 20, searchBarY + searchBarH / 2 - patSearchBarTxt.Height / 2)
        patSearchBarBtn.Location = New Point(patSearchBarTxt.Location.X + patSearchBarTxt.Width + 5, searchBarY + searchBarH / 2 - patSearchBarTxt.Height / 2)
        '- Buttons Add, Edit and Delete
        PatBtnAdd.Location = New Point(picX, picY + picH + 10)
        PatBtnEdit.Location = New Point(picX + picW / 2 - PatBtnEdit.Width / 2, picY + picH + 10)
        PatBtnDelete.Location = New Point(picX + picW - PatBtnDelete.Width, picY + picH + 10)

    End Function

    Function hideVs()
        patLblNameV.Hide()
        patLblPhoneV.Hide()
        patLblAddressV.Hide()
    End Function
    Function showVs()
        patLblNameV.Show()
        patLblPhoneV.Show()
        patLblAddressV.Show()
    End Function

    Function hideTB()
        patLblNameTB.Hide()
        patLblPhoneTB.Hide()
        patLblAddressTB.Hide()
    End Function

    Function showTB()
        patLblNameTB.Show()
        patLblPhoneTB.Show()
        patLblAddressTB.Show()
    End Function

    Private Sub PatBtnAdd_Click(sender As Object, e As EventArgs) Handles PatBtnAdd.Click

        addBtnTaps += 1
        hideVs()
        showTB()
        PatBtnAdd.Text = "DONE"

        If addBtnTaps = 2 Then

            showVs()
            hideTB()

            Dim tmpPat = New Pat(patLblNameTB.Text, patLblPhoneTB.Text, patLblAddressTB.Text)
            Dim setter = client.Set("pats/" + tmpPat.phone, tmpPat)
            PatBtnAdd.Text = "ADD"

            addBtnTaps = 0
            MessageBox.Show("Done")

        End If


    End Sub

    Private Sub PatBtnEdit_Click(sender As Object, e As EventArgs) Handles PatBtnEdit.Click

        Dim name = patLblNameV.Text
        Dim phone = patLblPhoneV.Text
        Dim address = patLblAddressV.Text
        edtBtnTaps += 1

        If edtBtnTaps = 1 Then

            hideVs()
            showTB()
            PatBtnEdit.Text = "DONE"

            patLblNameTB.Text = name
            patLblPhoneTB.Text = phone
            patLblAddressTB.Text = address

        End If

        If edtBtnTaps = 2 Then

            Dim tmpPat = New Pat(patLblNameTB.Text, patLblPhoneTB.Text, patLblAddressTB.Text)
            Dim setter = client.Set("pats/" + tmpPat.phone, tmpPat)
            PatBtnEdit.Text = "EDIT"
            edtBtnTaps = 0

            showVs()
            hideTB()

            MessageBox.Show("Done")
        End If

    End Sub

    Private Sub PatBtnDelete_Click(sender As Object, e As EventArgs) Handles PatBtnDelete.Click

        Dim tmpPat = New Pat(patLblNameV.Text, patLblPhoneV.Text, patLblAddressV.Text)
        client.Delete("pats/" + tmpPat.phone)

        MessageBox.Show("Done")

    End Sub

    Private Sub patSearchBarBtn_Click(sender As Object, e As EventArgs) Handles patSearchBarBtn.Click

        readDB()


        For i = 0 To pats.Count - 1

            If patSearchBarTxt.Text = pats(i).phone Then

                patLblNameV.Text = pats(i).name
                patLblPhoneV.Text = pats(i).phone
                patLblAddressV.Text = pats(i).address

            End If

        Next

    End Sub

    Function readDB()
        '- Connecting to DB
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("Internet connection Error")
        End Try

        '- Download Data from DB
        Dim res As FirebaseResponse = client.Get("pats")
        Dim data As Dictionary(Of String, Pat) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Pat))(res.Body.ToString())

        '- Add This Data To A List
        For Each tmpPat As KeyValuePair(Of String, Pat) In data
            pats.Add(tmpPat.Value)
        Next

    End Function

    Private Sub patBackBtn_Click(sender As Object, e As EventArgs) Handles patBackBtn.Click
        Form1.CurForm = Dashboard
        Dim Panel1 = Form1.Panel1
        Panel1.Controls.Clear()
        Dashboard.TopLevel = False
        Panel1.Controls.Add(Dashboard)
        Dashboard.Show()
        Panel1.Size = Me.Size
        Dashboard.Size = Panel1.Size
    End Sub
End Class