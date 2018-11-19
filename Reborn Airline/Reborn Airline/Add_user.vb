Public Class Add_user
    Dim filepath As String

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        filepath = OpenFileDialog1.FileName
        staffpic.Image = Image.FromFile(filepath)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim firstname = txtfirstname.Text
        Dim lastname = txtlastname.Text
        Dim nationalid = txtnationalid.Text
        Dim staffnumber = txtstaffno.Text
        Dim emailaddress = txtemailaddress.Text
        Dim telephoneaddress = txttelephoneaddress.Text
        Dim DOB = DateTimePicker1.Value.Date
        Dim sql = "insert into users(Firstname,Lastname,NationalID,StaffNo,Email,Telephone,DOB,Staffpic)values('" & firstname & "','" & lastname & "','" & nationalid & "','" & staffnumber & "','" & emailaddress & "','" & telephoneaddress & "','" & DOB & "','" & filepath.Replace("\", "\\") & "')"
        'call a subproceedure for saving data to database'
        Call saveData(sql)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim ID = InputBox("what is the National ID of the user you want to find")
        Dim SQL = "select*from users where NationalID='" & ID & "'"
        Call FindUser(SQL)
    End Sub

    Private Sub UpdateUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class