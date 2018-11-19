Public Class employees
    Dim filepath As String
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim FirstName = txtfirstname.Text
        Dim LastName = txtlastname.Text
        Dim DateOfBirth = DateTimePicker1.Value.Date
        Dim EmployeeID = txtemployeeid.Text
        Dim NationalId = txtnationalid.Text
        Dim DateOfEmployment = DateTimePicker2.Value.Date
        Dim Telephone = txttelephone.Text
        Dim Email = txtemail.Text
        Dim Availability = cboavailability.Text
        Dim sql = "insert into EmployeeDetails(EmployeeID,FirstName,LastName,NationalID,DateOfBirth,Telephone,Email,DateOfEmployment,Availability)values('" & EmployeeID & "','" & FirstName & "','" & LastName & "','" & NationalId & "','" & DateOfBirth & "','" & Telephone & "','" & Email & "','" & DateOfEmployment & "','" & Availability & "','" & filepath.Replace("\", "\\") & "')"
        Call savedata(sql)
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        filepath = OpenFileDialog1.FileName
        staffpic.Image = Image.FromFile(filepath)
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim ID = InputBox("What is the Employee ID of the employee whose details you would like to check")
        Dim SQL = "select*from EmployeeDetails where EmployeeID='" & ID & "'"
        Call CheckEmployee(SQL)
    End Sub
End Class