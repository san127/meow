Public Class phamacistLog
    Private Sub phrm_back_btn_Click(sender As Object, e As EventArgs) Handles phrm_back_btn.Click
        Me.Close()
        log1.Show()
    End Sub

    Private Sub pharma_reset_Click(sender As Object, e As EventArgs) Handles pharma_reset.Click
        pharma_txbx.Clear()
    End Sub

    Private Sub pharma_Sumbit_Click(sender As Object, e As EventArgs) Handles pharma_Sumbit.Click
        If (pharma_txbx.Text.Equals("pharma101")) Then
            MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            pharma_txbx.Clear()
            MessageBox.Show("Wrong password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class