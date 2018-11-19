Imports MySql.Data.MySqlClient
Public Class form_1
    Dim conn As New MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim server = "server=locolhost;username=root;password=root;database=pract;"
    Public Sub getdata()
        Try
            conn.ConnectionString = server
            conn.Open()
            command = New MySqlCommand("Select * from aa", conn)
            reader = command.ExecuteReader
            While reader.Read = True
                DataGridView1.Rows.Add(reader("flight"), reader("departdate"), reader("airline"))
                lblcustomer.Text = reader("customer")
                lblbookdate.Text = reader("bookdate")
                lblnumber.Text = reader("ticket")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        PrintDialog1.Document = Me.PrintDocument1
        Dim result As DialogResult = PrintDialog1.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            panel1.height = 20
            PrintDocument1.Print()
            Me.Close()
        Else
            MsgBox("Print cancelled")
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub form_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
    End Sub
End Class