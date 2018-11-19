Imports MySql.Data.MySqlClient
Module Functions
    Public conn As New MySqlConnection
    Public command As MySqlCommand
    Public reader As MySqlDataReader
    Public fullname As String
    Dim DBserver = "server=localhost;database=viral;username=root;password=root"
    Public Sub getconnection()
        Try
            conn.ConnectionString = DBserver
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub logins(ByVal sql As String)
        Try
            conn.ConnectionString = DBserver
            conn.Open()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim count As Integer = 0
            While reader.Read = True
                count += 1
                fullname = reader.GetString("Username")
            End While
            If count >= 1 Then
                MsgBox("Login successful")
                Main_Viral.Show()
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
    Public Sub CheckEmployee(ByVal SQL As String)
        Try
            getconnection()
            command = New MySqlCommand(SQL, conn)
            reader = command.ExecuteReader
            While reader.Read = True
                employees.txtemployeeid.Text = reader("EmployeeID")
                employees.txtnationalid.Text = reader("NationalID")
                employees.txtfirstname.Text = reader("FirstName")
                employees.txtlastname.Text = reader("LastName")
                employees.txttelephone.Text = reader("Telephone")
                employees.txtemail.Text = reader("Email")
                employees.cboavailability.Text = reader("Availability")
                employees.staffpic.Image = Image.FromFile(reader("Staffpic"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAllEmployees(ByVal sql As String, ByVal lstview As ListView)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim item As ListViewItem
            lstview.Items.Clear()
            While reader.Read = True
                item = New ListViewItem(reader("EmployeeID").ToString)
                item.SubItems.Add(reader("FirstName").ToString)
                item.SubItems.Add(reader("LastName").ToString)
                item.SubItems.Add(reader("Telephone").ToString)
                item.SubItems.Add(reader("Email").ToString)
                item.SubItems.Add(reader("Availability").ToString)
                lstview.Items.Add(item)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAllItems(ByVal sql As String, ByVal lstview As ListView)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim item As ListViewItem
            lstview.Items.Clear()
            While reader.Read = True
                item = New ListViewItem(reader("ItemCategory").ToString)
                item.SubItems.Add(reader("ItemName").ToString)
                item.SubItems.Add(reader("ItemID").ToString)
                item.SubItems.Add(reader("Description").ToString)
                item.SubItems.Add(reader("Price").ToString)
                item.SubItems.Add(reader("AmmountAvailable").ToString)
                lstview.Items.Add(item)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAllCustomers(ByVal sql As String, ByVal lstview As ListView)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim item As ListViewItem
            lstview.Items.Clear()
            While reader.Read = True
                item = New ListViewItem(reader("CustomerID").ToString)
                item.SubItems.Add(reader("FirstName").ToString)
                item.SubItems.Add(reader("LastName").ToString)
                item.SubItems.Add(reader("NationalID").ToString)
                item.SubItems.Add(reader("Telephone").ToString)
                item.SubItems.Add(reader("Email").ToString)
                item.SubItems.Add(reader("ResidentialArea").ToString)
                item.SubItems.Add(reader("PostalAddress").ToString)
                lstview.Items.Add(item)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadItemName(ByVal sql As String)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            'results displayed will be stored in the command reader'
            reader = command.ExecuteReader
            While reader.Read = True
                Orders.txtitemname.Text = reader("ItemName")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadItemInformation(ByVal sql As String)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            'results displayed will be stored in the command reader'
            reader = command.ExecuteReader
            While reader.Read = True
                Orders.lblcategory.Text = "Category: " & reader("Category")
                Orders.lblitemid.Text = "ItemID: " & reader("ItemID")
                Orders.lblprice.Text = "Price: " & reader("Price")
                Orders.lblammountavailable.Text = "AmmountAvailable: " & reader("AmmountAvailable")
                Orders.lbldescription.Text = "Description: " & reader("Description")
                Orders.Itempic.Image = Image.FromFile(reader("Staffpic"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadCustomerDetails(ByVal SQL As String)
        Try
            getconnection()
            command = New MySqlCommand(SQL, conn)
            reader = command.ExecuteReader
            While reader.Read = True
                Orders.txtcustomerid.Text = reader("CustomerID")
                Orders.Txtfirstname.Text = reader("FirstName")
                Orders.txttelephone.Text = reader("Telephone")
                Orders.txtemail.Text = reader("Email")
                Orders.txtresidence.Text = reader("Residence")
                Orders.txtpostaladdress.Text = reader("PoastalAddress")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAllOrders(ByVal sql As String, ByVal lstview As ListView)
        Try
            getconnection()
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader
            Dim item As ListViewItem
            lstview.Items.Clear()
            While reader.Read = True
                item = New ListViewItem(reader("CustomerID").ToString)
                item.SubItems.Add(reader("CustomerName").ToString)
                item.SubItems.Add(reader("Email").ToString)
                item.SubItems.Add(reader("NationalID").ToString)
                item.SubItems.Add(reader("PoastalAddress").ToString)
                item.SubItems.Add(reader("Telephone").ToString)
                item.SubItems.Add(reader("ItemID").ToString)
                item.SubItems.Add(reader("Price").ToString)
                item.SubItems.Add(reader("Delivery").ToString)
                lstview.Items.Add(item)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module
