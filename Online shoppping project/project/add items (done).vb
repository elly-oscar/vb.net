Public Class add_items
    Dim filepath As String
    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        filepath = OpenFileDialog1.FileName
        itempic.Image = Image.FromFile(filepath)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

   
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim ItemCategory = cboitemcategory.Text
        Dim ItemName = txtitemname.Text
        Dim ItemID = txtitemid.Text
        Dim Price = txtcost.Text
        Dim Description = txtdescription.Text
        Dim sql = "insert into Items(ItemCategory,ItemID,ItemName,Description,Price)values('" & ItemCategory & "','" & ItemID & "','" & ItemName & "','" & Description & "','" & Price & "','" & filepath.Replace("\", "\\") & "')"
        savedata(sql)
    End Sub
End Class