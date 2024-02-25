Public Class purchmanger_log
    Private Sub purchman_back_btn_Click(sender As Object, e As EventArgs) Handles purchman_back_btn.Click
        Me.Close()
        log1.Show()
    End Sub

    Private Sub purchman_reset_Click(sender As Object, e As EventArgs) Handles purchman_reset.Click
        purchman_txbx.Clear()
    End Sub

    Private Sub purchman_Sumbit_Click(sender As Object, e As EventArgs) Handles purchman_Sumbit.Click
        If (purchman_txbx.Text.Equals("purchmang101")) Then
            'MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            purchman_txbx.Clear()
            MessageBox.Show("Wrong password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class