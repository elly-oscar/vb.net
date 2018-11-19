Public Class add_flight

    
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim flight = txtflightnumber.Text
        Dim DepartDate = DateTimePicker1.Value.Date
        Dim airline = cboairline.Text
        Dim DepartTime = txttime.Text
        Dim From = cbojourneyfrom.Text
        Dim ToDest = cbojourneyto.Text
        Dim status = cbostatus.Text
        Dim space = txtspace.Text
        Dim sql = "insert into flights(FlightNumber,DepartDate,DepartTime,Airline,JourneyFrom,Destination,Space,Status)values('" & flight & "','" & DepartDate & "','" & DepartTime & "','" & airline & "','" & From & "','" & ToDest & "','" & space & "','" & status & "')"
        savedata(sql)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class