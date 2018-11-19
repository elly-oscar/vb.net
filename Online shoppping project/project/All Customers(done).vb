Public Class Customers

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CustomerDetails.ShowDialog()
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "select*from CustomerDetails"
        LoadAllCustomers(sql, customerlist)
    End Sub
End Class