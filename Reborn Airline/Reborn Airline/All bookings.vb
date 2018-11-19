Public Class All_bookings

    Private Sub All_bookings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql = "Select * from bookings"
        LoadAllBookings(sql, ListView1)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Book_Flights.ShowDialog()
    End Sub
End Class