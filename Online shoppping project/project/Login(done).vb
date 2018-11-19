Public Class Login

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username = cbousername.Text
        Dim password = txtpassword.Text
        Dim sql = "select * from login where username='" & username & "' and password='" & password & "'"
        logins(sql)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
