Public Class All_Employees

    Private Sub All_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = "select*from employees"
        LoadAllEmployees(sql, employeelist)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        employees.ShowDialog()
    End Sub
End Class