Public Class flights

    Private Sub flights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql = "Select * from flights"
        GetAllFlights(sql, FlightList)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        add_flight.ShowDialog()
    End Sub
End Class