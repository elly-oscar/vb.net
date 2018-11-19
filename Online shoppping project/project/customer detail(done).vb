Public Class CustomerDetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim CustomerID = txtcustomerid.Text
        Dim FirstName = txtfirstname.Text
        Dim LastName = txtlastname.Text
        Dim NationalID = txtnationalid.Text
        Dim Telephone = txttelephone.Text
        Dim Email = txtemail.Text
        Dim ResidentialArea = txtresidence.Text
        Dim PoastalAdress = txtpostaladdress.Text
        Dim sql = "insert into CustomerDetails(CustomerID,NationalID,FirstName,LastName,Telephone,Email,Residence,PoastalAddress)values('" & CustomerID & "','" & NationalID & "','" & FirstName & "','" & LastName & "','" & Telephone & "','" & Email & "','" & ResidentialArea & "','" & PoastalAdress & "')"
        Call savedata(sql)
    End Sub
End Class