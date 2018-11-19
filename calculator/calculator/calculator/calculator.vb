Public Class calculator
    Dim firstnumber As Long
    Dim operation As String

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "1"
        Else
            txtdisplay.Text = txtdisplay.Text & "1"
        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "2"
        Else
            txtdisplay.Text = txtdisplay.Text & "2"
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "3"
        Else
            txtdisplay.Text = txtdisplay.Text & "3"
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "4"
        Else
            txtdisplay.Text = txtdisplay.Text & "4"
        End If
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "5"
        Else
            txtdisplay.Text = txtdisplay.Text & "5"
        End If
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "6"
        Else
            txtdisplay.Text = txtdisplay.Text & "6"
        End If
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "7"
        Else
            txtdisplay.Text = txtdisplay.Text & "7"
        End If
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "8"
        Else
            txtdisplay.Text = txtdisplay.Text & "8"
        End If
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "9"
        Else
            txtdisplay.Text = txtdisplay.Text & "9"
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = "0"
        Else
            txtdisplay.Text = txtdisplay.Text & "0"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncleareverything.Click
        txtdisplay.Text = "0"
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = "0"
        operation = "+"
    End Sub

    Private Sub btnsubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubtract.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = "0"
        operation = "-"
    End Sub

    Private Sub btnmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmultiply.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = "0"
        operation = "*"
    End Sub

    Private Sub btndivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivide.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = "0"
        operation = "/"
    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        Dim secondnumber As Long
        Dim result As Int32
        secondnumber = txtdisplay.Text
        If operation = "+" Then
            result = firstnumber + secondnumber
        ElseIf operation = "-" Then
            result = firstnumber - secondnumber
        ElseIf operation = "*" Then
            result = firstnumber * secondnumber
        ElseIf operation = "/" Then
            result = firstnumber / secondnumber
        ElseIf operation = "Sine" Then
            result = Math.Sin(txtdisplay.Text)
            txtdisplay.Text = result
            result = txtdisplay.Text
        ElseIf operation = "Cosine" Then
            result = Math.Cos(txtdisplay.Text)
        ElseIf operation = "Tangent" Then
            result = Math.Tan(txtdisplay.Text)
        ElseIf operation = "Logarithm" Then
            result = Math.Log(txtdisplay.Text)
        End If
        firstnumber = result
        txtdisplay.Text = result
    End Sub

    Private Sub btnsine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsine.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = Math.Sin(txtdisplay.Text)
        operation = ""
    End Sub

    Private Sub btnCosine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCosine.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = Math.Cos(txtdisplay.Text)
        operation = ""
    End Sub

    Private Sub btntangent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntangent.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = Math.Tan(txtdisplay.Text)
        operation = ""
    End Sub

    Private Sub btnlogarithm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogarithm.Click
        firstnumber = txtdisplay.Text
        txtdisplay.Text = Math.Log(txtdisplay.Text)
        operation = ""
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        If Len(txtdisplay.Text) = 0 Then Exit Sub
        txtdisplay.Text = Mid(txtdisplay.Text, 1, Len(txtdisplay.Text) - 1)
    End Sub

    Private Sub btnpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpoint.Click
        If Not (txtdisplay.Text.Contains(".")) Then
            txtdisplay.Text += "."
        End If
    End Sub

    Private Sub calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class