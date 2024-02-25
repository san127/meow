Public Class salesrepLog
    Private Sub salerep_reset_Click(sender As Object, e As EventArgs) Handles salerep_reset.Click
        salesrep_txbx.Clear()
    End Sub

    Private Sub salerep_back_btn_Click(sender As Object, e As EventArgs) Handles salerep_back_btn.Click
        Me.Close()
        log1.Show()
    End Sub

    Private Sub salerep_Sumbit_Click(sender As Object, e As EventArgs) Handles salerep_Sumbit.Click
        If (salesrep_txbx.Text.Equals("sales101")) Then
            'MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            salesrep_txbx.Clear()
            MessageBox.Show("Wrong password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class