Public Class dataoptionsform
    Private Sub addstDBpic_Click(sender As Object, e As EventArgs) Handles addstDBpic.Click
        Me.Hide()
        pharmacistMenu1.Show()
    End Sub

    Private Sub delStDbpic_Click(sender As Object, e As EventArgs) Handles delStDbpic.Click
        Me.Hide()
        deleteMedForm.Show()
    End Sub
End Class