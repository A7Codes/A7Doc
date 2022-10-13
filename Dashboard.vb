Public Class Dashboard


    Private Sub DashBtnApts_Click(sender As Object, e As EventArgs) Handles DashBtnApts.Click
        Form1.CurForm = Appointments
        Dim Panel1 = Form1.Panel1
        Panel1.Controls.Clear()
        Appointments.TopLevel = False
        Panel1.Controls.Add(Appointments)
        Appointments.Show()
        Panel1.Size = Me.Size
        Appointments.Size = Panel1.Size
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posDashItems()
    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        posDashItems()
    End Sub

    Function posDashItems()

        Dim cenX = Screen.PrimaryScreen.WorkingArea.Width / 2
        Dim cenY = Screen.PrimaryScreen.Bounds.Height / 2

        dashPicLogo.Location = New Point(cenX - dashPicLogo.Width / 2, cenY - dashPicLogo.Height)
        DashBtnApts.Location = New Point(cenX - DashBtnApts.Width - 10, cenY + 10)
        DashBtnPats.Location = New Point(cenX + 10, cenY + 10)

    End Function

    Private Sub DashBtnPats_Click(sender As Object, e As EventArgs) Handles DashBtnPats.Click

        Form1.CurForm = Patient
        Dim Panel1 = Form1.Panel1
        Panel1.Controls.Clear()
        Patient.TopLevel = False
        Panel1.Controls.Add(Patient)
        Patient.Show()
        Panel1.Size = Me.Size
        Patient.Size = Panel1.Size

    End Sub

End Class