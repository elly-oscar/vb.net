Public Class Items

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        add_items.ShowDialog()
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "select*from items"
        LoadAllItems(sql, itemlist)
    End Sub
End Class