Public Class adminLogin
    Private Sub adm_back_btn_Click(sender As Object, e As EventArgs) Handles adm_back_btn.Click
        Me.Close()
        log1.Show()
    End Sub

    Private Sub adm_reset_Click(sender As Object, e As EventArgs) Handles adm_reset.Click
        admin_txbx.Clear()
    End Sub

    Private Sub adm_Sumbit_Click(sender As Object, e As EventArgs) Handles adm_Sumbit.Click
        If (admin_txbx.Text.Equals("admin101")) Then
            'MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            adminMenu1.Show()
        Else
            admin_txbx.Clear()
            MessageBox.Show("Wrong password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class