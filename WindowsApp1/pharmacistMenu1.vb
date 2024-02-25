Imports Devart.Data.MySql

Public Class pharmacistMenu1
    Private Sub pharmacistMenu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmaDataSet.meds_inventory' table. You can move, or remove it, as needed.
        Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)

    End Sub

    Private Sub add_inventBtn_Click(sender As Object, e As EventArgs) Handles add_inventBtn.Click

        'check for empty textbox values
        If (medId_txbx.Text.Length() = 0) Then
            MsgBox("Enter medicine ID")

        ElseIf (medName_txbx.Text.Length() = 0) Then
            MsgBox("Enter medicine name")

        ElseIf (medCategory_combx.Text.Length() = 0) Then
            MsgBox("Enter medicine category")

        ElseIf (expDate_txbx.Text.Length() = 0) Then
            MsgBox("Enter medicine Expiry date")

        ElseIf (medPrice_txbx.Text.Length() = 0) Then
            MsgBox("Enter medicine Price")

        ElseIf (medQty_txbx.Text.Length() = 0) Then
            MsgBox("Enter medicine quantity")
        End If

        'adding data to the table
        Dim Query As String
        Query = "INSERT INTO meds_inventory VALUES (@Med_ID,@Medicine,@category,@expiration_date,@Price,@Qty);"
        Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

        Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
        cmd.Parameters.AddWithValue("@Med_ID", medId_txbx.Text)
        cmd.Parameters.AddWithValue("@Medicine", medName_txbx.Text)
        cmd.Parameters.AddWithValue("@category", medCategory_combx.Text)
        cmd.Parameters.AddWithValue("@expiration_date", expDate_txbx.Text)
        cmd.Parameters.AddWithValue("@Price", medPrice_txbx.Text)
        cmd.Parameters.AddWithValue("@Qty", medQty_txbx.Text)

        Try
            Connec.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Medicine added successfully")
            Me.Meds_inventoryTableAdapter.Fill(Me.PharmaDataSet.meds_inventory)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Connec.Close()
        End Try
    End Sub
End Class