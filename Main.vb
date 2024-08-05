Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchForm(New FormHome())
    End Sub

    Private Sub switchForm(form As Form)
        pnlMain.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        pnlMain.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        switchForm(New FormParkingSpace())
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        switchForm(New FormHome())
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        switchForm(New FormEmployee())
    End Sub
End Class
