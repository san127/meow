Imports Devart.Data.MySql

Public Class supplierMgmtForm
    Private Sub supplierMgmtForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Meds_supplierTableAdapter.Fill(Me.PharmaDataSet.meds_supplier)

    End Sub

    Private Sub supp_delBTN_Click(sender As Object, e As EventArgs) Handles supp_delBTN.Click
        Dim Query As String
        Query = "DELETE FROM meds_supplier WHERE S_ID=@S_ID;"
        Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

        Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
        cmd.Parameters.AddWithValue("@S_ID", Val(supDelTxbx.Text))

        Try
            Connec.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Medicine removed successfully")
            Me.Meds_supplierTableAdapter.Fill(Me.PharmaDataSet.meds_supplier)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Connec.Close()
        End Try
    End Sub

    Private Sub sup_addbtn_Click(sender As Object, e As EventArgs) Handles sup_addbtn.Click
        Dim Query As String
        Query = "INSERT INTO meds_supplier VALUES (@S_ID,@S_name,@Contact,@supplier_company);"
        Dim Connec As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=pharma;UserId=root;Password=MER@sql69420;")

        Dim cmd As MySqlCommand = New MySqlCommand(Query, Connec)
        cmd.Parameters.AddWithValue("@S_ID", suppIDtxbx.Text)
        cmd.Parameters.AddWithValue("@S_name", supNametxbx.Text)
        cmd.Parameters.AddWithValue("@Contact", supPhonetxbx.Text)
        cmd.Parameters.AddWithValue("@supplier_company", supCompTxbx.Text)

        Try
            Connec.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Medicine added successfully")
            Me.Meds_supplierTableAdapter.Fill(Me.PharmaDataSet.meds_supplier)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        Finally
            Connec.Close()
        End Try
    End Sub
End Class