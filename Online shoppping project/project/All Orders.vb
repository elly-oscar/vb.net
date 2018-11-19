Public Class All_Orders

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Orders.ShowDialog()
    End Sub

    Private Sub All_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "select * from orders"
        LoadAllOrders(sql, orderlist)
    End Sub
End Class