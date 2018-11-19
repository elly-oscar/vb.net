Public Class login

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        'capture values from textboxes'
        Dim username = txtusername.Text
        Dim password = txtpassword.Text
        'create the sql select statement'
        Dim sql = "select * from login where username='" & username & "' and password='" & password & "'"
        'calling the login proceedure and passing the sql'
        logins(sql)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
