Imports MySql.Data.MySqlClient
Module DBfunctions
    'conn stores the state of connection(whether connected or not) with the database'
    Public conn As New MySqlConnection
    'command executes sql command state(insert,delete,update,create)'
    Public command As MySqlCommand
    'reader stores returns of the result by the command'
    Public reader As MySqlDataReader
    Public fullname As String
    Dim DBserver = "server=localhost;database=reborn;username=root;password=root"
    Public Sub getconnection()
        Try
            'opening connection to db'
            conn.ConnectionString = DBserver
            'creating a connection using the data given above'
            conn.Open()
        Catch ex As Exception
            'in case of error it is displayed using a msgbox'
            MsgBox(ex.Message)
        End Try
    End Sub
    'accept command stored inside sql to open connection'
    Public Sub logins(ByVal sql As String)
        Try
            conn.ConnectionString = DBserver
            conn.Open()
            command = New MySqlCommand(sql, conn)
            'results displayed will be stored in the command reader'
            reader = command.ExecuteReader
            Dim count As Integer = 0
            While reader.Read = True
                count += 1
                fullname = reader.GetString("Username")
            End While
            If count >= 1 Then
                MsgBox("Login successful")
                Main_reborn.Show()
                login.Hide()
            Else
                MsgBox("Invalid credentials")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub savedata(ByVal sql As String)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            command.ExecuteNonQuery()
            MsgBox("Data has been saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub GetAllUsers(ByVal sql As String, ByVal lstview As ListView)
        Try
            'getting values from the database to the form on vb.net'
            getconnection()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim item As ListViewItem
            lstview.Items.Clear()
            While reader.Read = True
                item = New ListViewItem(reader("FirstName").ToString)
                item.SubItems.Add(reader("LastName").ToString)
                item.SubItems.Add(reader("Telephone").ToString)
                item.SubItems.Add(reader("Email").ToString)
                item.SubItems.Add(reader("NationalID").ToString)
                lstview.Items.Add(item)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub DeleteUser(ByVal SQL As String)
        Try
            getconnection()
            command = New MySqlCommand(SQL, conn)
            'no output required just confirmation if command has been executed to delete a user'
            command.ExecuteNonQuery()
            MsgBox("User has been deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub FindUser(ByVal SQL As String)
        Try
            getconnection()
            command = New MySqlCommand(SQL, conn)
            'results displayed will be stored in the command reader'
            reader = command.ExecuteReader
            While reader.Read = True
                Add_user.txtnationalid.Text = reader("NationalID")
                Add_user.txtfirstname.Text = reader("FirstName")
                Add_user.txtlastname.Text = reader("LastName")
                Add_user.txttelephoneaddress.Text = reader("Telephone")
                Add_user.txtemailaddress.Text = reader("Email")
                Add_user.txtstaffno.Text = reader("Staffno")
                Add_user.staffpic.Image = Image.FromFile(reader("Staffpic"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub GetAllFlights(ByVal sql As String, ByVal lstview As ListView)
        Try
            'getting values from the database to the form on vb.net'
            getconnection()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim item As ListViewItem
            lstview.Items.Clear()
            While reader.Read = True
                item = New ListViewItem(reader("FlightNumber").ToString)
                item.SubItems.Add(reader("Airline").ToString)
                item.SubItems.Add(reader("DepartDate").ToString)
                item.SubItems.Add(reader("DepartTime").ToString)
                item.SubItems.Add(reader("JourneyFrom").ToString)
                item.SubItems.Add(reader("Destination").ToString)
                item.SubItems.Add(reader("Status").ToString)
                item.SubItems.Add(reader("Space").ToString)
                lstview.Items.Add(item)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadFlightsNumber(ByVal sql As String)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            'results displayed will be stored in the command reader'
            reader = command.ExecuteReader
            While reader.Read = True
                Book_Flights.cboflight.Items.Add(reader("FlightNumber"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadFlightInformation(ByVal sql As String)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            'results displayed will be stored in the command reader'
            reader = command.ExecuteReader
            While reader.Read = True
                Book_Flights.lblairline.Text = "Airline: " & reader("Airline")
                Book_Flights.lblfrom.Text = "Journey from: " & reader("JourneyFrom")
                Book_Flights.lblto.Text = "Destination: " & reader("Destination")
                Book_Flights.lbldate.Text = "Departure date: " & reader("DepartDate")
                Book_Flights.lblstatus.Text = "Current status: " & reader("Status")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAllBookings(ByVal sql As String, ByVal lstview As ListView)
        Try
            'getting values from the database to the form on vb.net'
            getconnection()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim item As ListViewItem
            lstview.Items.Clear()
            While reader.Read = True
                item = New ListViewItem(reader("TicketNo").ToString)
                item.SubItems.Add(reader("Name").ToString)
                item.SubItems.Add(reader("Telephone").ToString)
                item.SubItems.Add(reader("Email").ToString)
                item.SubItems.Add(reader("Flight").ToString)
                item.SubItems.Add(reader("DateBooked").ToString)
                lstview.Items.Add(item)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module
