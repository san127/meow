Public Class adminMenu1
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        dataoptionsform.Show()
    End Sub

    Private Sub adminMenu_back_Click(sender As Object, e As EventArgs) Handles adminMenu_back.Click
        Me.Close()
        adminLogin.Show()
    End Sub
End Class