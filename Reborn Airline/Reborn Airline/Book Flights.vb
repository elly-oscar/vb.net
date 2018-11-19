Public Class Book_Flights

    Private Sub Book_Flights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql = "Select FlightNumber from flights"
        LoadFlightsNumber(sql)
    End Sub

    Private Sub cboflight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboflight.SelectedIndexChanged
        Dim sql = "Select * from flights where FlightNumber='" & cboflight.Text & "'"
        LoadFlightInformation(sql)
    End Sub

    Private Sub btnbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbook.Click
        Dim Name = txtname.Text
        Dim Telephone = txttelephone.Text
        Dim email = txtemail.Text
        Dim Ticket = txtticketno.Text
        Dim Cost = txtprice.Text
        Dim DateBooked = DateTimePicker1.Value.Date
        Dim Flight = cboflight.Text
        Dim sql = "Insert into bookings(Name,Telephone,Email,TicketNo,Cost,DateBooked,Flight)values('" & Name & "','" & Telephone & "','" & email & "','" & Ticket & "','" & Cost & "','" & DateBooked & "','" & Flight & "')"
        savedata(sql)
    End Sub
End Class