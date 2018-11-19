Public Class Home
    Private Sub btnabout_Click_1(sender As Object, e As EventArgs) Handles btnabout.Click
        MessageBox.Show("Viral online shopping was created by Oscar for convenience and efficiency in online and shopping in general" & vbNewLine & "on" & Date.Now() & vbNewLine & "Contact E-mail: oscar@Vronline.co.ke" & vbNewLine & " Website : www.Viral online shopping.co.ke", "Viral", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btncancel_Click_1(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class