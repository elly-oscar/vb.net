Public Class Orders

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "select ItemName from Items"
        LoadItemName(sql)
    End Sub

    Private Sub txtitemname_TextChanged(sender As Object, e As EventArgs) Handles txtitemname.TextChanged
        Dim sql = "Select * from Items where ItemName='" & txtitemname.Text & "'"
        LoadItemInformation(sql)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtnationalid.TextChanged
        Dim sql = "select CustomerName from Customers"
        LoadCustomerDetails(sql)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        Dim CustomerID = txtcustomerid.Text
        Dim CustomerName = Txtfirstname.Text
        Dim NationalID = txtnationalid.Text
        Dim Email = txtemail.Text
        Dim Telephone = txttelephone.Text
        Dim PostalAddress = txtpostaladdress.Text
        Dim ItemID = lblitemid.Text
        Dim Price = lblprice.Text
        Dim delivery = cbodelivery.Text
        Dim sql = "Insert into Orders(CustomerID,CustomerName,NationalID,Telephone,Email,ItemID,Price,PostalAddress,Delivery)values('" & CustomerID & "','" & CustomerName & "','" & NationalID & "','" & Telephone & "','" & Email & "','" & ItemID & "','" & Price & "','" & PostalAddress & "','" & delivry & "')"
        savedata(sql)
    End Sub
End Class