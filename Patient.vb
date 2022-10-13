Public Class Patient
    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        positionItems()
        hideTB()

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



End Class