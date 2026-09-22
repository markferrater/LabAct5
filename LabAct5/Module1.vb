Imports System.Net
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Module Module1
    Private db_server As String = "localhost"
    Private db_username As String = "root"
    Private db_password As String = ""
    Private db_port As String = "3306"
    Private db_name As String = "labact5"
    Public db_con As New MySqlConnection
'aswqwqwqw test
    Public Sub dbConnect()
        db_con = New MySqlConnection("server=" & db_server & "; port=" & db_port & "; user id=" & db_username & "; password=" & db_password & "; database=" & db_name & ";")
        db_con.Open()
    End Sub

    Public Sub dbDisconnect()
        db_con.Close()
    End Sub

    'check if user exist in the database for the login form
    Public Sub checkUser(email As String, password As String)
        Try
            dbConnect()

            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT usr_email, usr_password FROM users WHERE usr_email = @email AND usr_password = @password AND isActive = 1", db_con)
            da.SelectCommand.Parameters.AddWithValue("email", email)
            da.SelectCommand.Parameters.AddWithValue("password", password)


            da.Fill(ds, "users")

            'if user is found, show message box "user found", else show message box "user not found"
            If ds.Tables("users").Rows.Count > 0 Then
                MsgBox("user found", vbOKOnly)

                Dashboard.Show()
                Form1.Close()

            Else
                MsgBox("user not found", vbOKOnly + vbCritical)
                Return
            End If

            ds.Dispose()
            da.Dispose()

            dbDisconnect()
        Catch ex As Exception

        End Try

        Return

    End Sub


    'load page from the datagrid (users)
    Public Sub loadUsers(dgv As DataGridView)
        Try
            dbConnect()

            dgv.Rows.Clear()

            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM users WHERE isActive = 1", db_con)
            da.Fill(ds, "users")

            'dgv.DataSource = ds.Tables("users")

            For i As Integer = 0 To ds.Tables("users").Rows.Count - 1
                Dim usr_id As String = ds.Tables("users").Rows(i).Item("usr_id").ToString()
                Dim usr_firstName As String = ds.Tables("users").Rows(i).Item("usr_firstName").ToString()
                Dim usr_lastName As String = ds.Tables("users").Rows(i).Item("usr_lastName").ToString()
                Dim usr_email As String = ds.Tables("users").Rows(i).Item("usr_email").ToString()
                Dim usr_password As String = ds.Tables("users").Rows(i).Item("usr_password").ToString()


                dgv.Rows.Add(usr_firstName, usr_lastName, usr_email, usr_password, usr_id)
            Next

            ds.Dispose()
            da.Dispose()

            dbDisconnect()
        Catch ex As Exception
        End Try

        Return
    End Sub


    'adding new user
    Public Sub addUser(firstName As String, lastName As String, email As String, password As String)
        Try

            dbConnect()

            Dim query As String = "INSERT INTO users (usr_firstName, usr_lastName, usr_email, usr_password, isActive) VALUES (@firstName, @lastName, @email, @password, 1)"
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, db_con)

            da.SelectCommand.Parameters.AddWithValue("firstName", firstName)
            da.SelectCommand.Parameters.AddWithValue("lastName", lastName)
            da.SelectCommand.Parameters.AddWithValue("email", email)
            da.SelectCommand.Parameters.AddWithValue("password", password)

            da.Fill(ds, "users")

            MsgBox("User added successfully", vbOKOnly + vbInformation)

            'wieugwiueywghqqgwqgwyuqgwqyiwg
            Call loadUsers(ManageUsers.DataGridView1)

            AddUsers.Close()

            ds.Dispose()
            da.Dispose()

            dbDisconnect()

        Catch ex As Exception

        End Try

        Return

    End Sub

    'updating user
    Public Sub updateUser(firstName As String, lastName As String, email As String, password As String, userId As Integer)
        Try
            dbConnect()

            Dim query As String = "UPDATE users SET usr_firstName = @firstName, usr_lastName = @lastName, usr_email = @email, usr_password = @password WHERE usr_id = @userId"
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, db_con)

            da.SelectCommand.Parameters.AddWithValue("firstName", firstName)
            da.SelectCommand.Parameters.AddWithValue("lastName", lastName)
            da.SelectCommand.Parameters.AddWithValue("email", email)
            da.SelectCommand.Parameters.AddWithValue("password", password)
            da.SelectCommand.Parameters.AddWithValue("userId", userId)

            da.Fill(ds, "users")

            MsgBox("User updated successfully", vbOKOnly + vbInformation)

            Call loadUsers(ManageUsers.DataGridView1)

            ds.Dispose()
            da.Dispose()

            dbDisconnect()

        Catch ex As Exception

        End Try

        Return

    End Sub

    'soft delete user
    Public Sub softDeleteUser(id As Integer)

        Try

            dbConnect()

            Dim query As String = "Update users SET isActive = 0 Where usr_id = @usr_id"
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, db_con)
            da.SelectCommand.Parameters.AddWithValue("usr_id", id)

            da.Fill(ds, "users")

            MsgBox("User deleted successfully", vbOKOnly + vbInformation)

            Call loadUsers(ManageUsers.DataGridView1)

            ds.Dispose()
            da.Dispose()

            dbDisconnect()

        Catch ex As Exception

        End Try

        Return

    End Sub

    'soft delete product
    Public Sub softDeleteProduct(id As Integer)

        Try

            dbConnect()

            Dim query As String = "Update products SET isActive = 0 Where prd_id = @prd_id"
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, db_con)
            da.SelectCommand.Parameters.AddWithValue("prd_id", id)

            da.Fill(ds, "products")

            MsgBox("Product deleted successfully", vbOKOnly + vbInformation)

            Call loadProducts(MangeProducts.dgvProducts)

            ds.Dispose()
            da.Dispose()

            dbDisconnect()

        Catch ex As Exception

        End Try

        Return

    End Sub

    'load page from the datagrid (products)
    Public Sub loadProducts(dgv As DataGridView)
        Try
            dbConnect()

            dgv.Rows.Clear()

            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM products WHERE prd_isActive = 1", db_con)
            da.Fill(ds, "products")

            For i As Integer = 0 To ds.Tables("products").Rows.Count - 1

                Dim prd_id As String = ds.Tables("products").Rows(i).Item("prd_id").ToString()
                Dim prd_Name As String = ds.Tables("products").Rows(i).Item("prd_name").ToString()
                Dim prd_Price As String = ds.Tables("products").Rows(i).Item("prd_price").ToString()
                Dim prd_Qty As String = ds.Tables("products").Rows(i).Item("prd_qty").ToString()

                dgv.Rows.Add(prd_Name, prd_Price, prd_Qty, prd_id)
            Next

            ds.Dispose()
            da.Dispose()

            dbDisconnect()
        Catch ex As Exception
        End Try

        Return
    End Sub


    Public Sub addPrds(prd_name As String, prd_price As Integer, prd_qty As Integer)

        dbConnect()

        Dim query As String = "INSERT INTO products (prd_name, prd_price, prd_qty, prd_isActive) VALUES (@prd_name, @prd_price, @prd_qty, 1)"
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, db_con)

        da.SelectCommand.Parameters.AddWithValue("prd_name", prd_name)
        da.SelectCommand.Parameters.AddWithValue("prd_price", prd_price)
        da.SelectCommand.Parameters.AddWithValue("prd_qty", prd_qty)

        da.Fill(ds, "products")

        MsgBox("Product added successfully", vbOKOnly + vbInformation)

        'wieugwiueywghqqgwqgwyuqgwqyiwg
        Call loadProducts(MangeProducts.dgvProducts)

        AddProduct.Close()

        ds.Dispose()
        da.Dispose()

        dbDisconnect()

    End Sub

    Public Sub updatePrd(prd_name As String, prd_price As Integer, prd_qty As Integer, prd_Id As Integer)

        Try
            dbConnect()

            Dim query As String = "UPDATE products SET prd_name = @prd_name, prd_price = @prd_price, prd_qty = @prd_qty WHERE prd_id = @prd_id"
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query, db_con)

            da.SelectCommand.Parameters.AddWithValue("prd_name", prd_name)
            da.SelectCommand.Parameters.AddWithValue("prd_price", prd_price)
            da.SelectCommand.Parameters.AddWithValue("prd_qty", prd_qty)
            da.SelectCommand.Parameters.AddWithValue("prd_id", prd_Id)

            da.Fill(ds, "products")

            MsgBox("Product updated successfully", vbOKOnly + vbInformation)

            Call loadProducts(MangeProducts.dgvProducts)

            ds.Dispose()
            da.Dispose()

            dbDisconnect()

        Catch ex As Exception

        End Try

        Return

    End Sub

    Public Sub searchUser(text As String, dgv As DataGridView)
        Try
            dbConnect()

            dgv.Rows.Clear()
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM users WHERE isActive = 1 AND (usr_firstName LIKE @text OR usr_lastName LIKE @text OR usr_email LIKE @text)", db_con)
            da.SelectCommand.Parameters.AddWithValue("text", text & "%")
            da.Fill(ds, "users")

            For i As Integer = 0 To ds.Tables("users").Rows.Count - 1
                Dim usr_id As String = ds.Tables("users").Rows(i).Item("usr_id").ToString()
                Dim usr_firstName As String = ds.Tables("users").Rows(i).Item("usr_firstName").ToString()
                Dim usr_lastName As String = ds.Tables("users").Rows(i).Item("usr_lastName").ToString()
                Dim usr_email As String = ds.Tables("users").Rows(i).Item("usr_email").ToString()
                Dim usr_password As String = ds.Tables("users").Rows(i).Item("usr_password").ToString()

                dgv.Rows.Add(usr_firstName, usr_lastName, usr_email, usr_password, usr_id)

            Next

        Catch ex As Exception

        End Try

        Return

    End Sub


    Public Sub searchProduct(text As String, dgv As DataGridView)
        Try
            dbConnect()

            dgv.Rows.Clear()
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM products WHERE isActive = 1 AND (prd_name LIKE @text)", db_con)
            da.SelectCommand.Parameters.AddWithValue("text", text & "%")
            da.Fill(ds, "products")

            For i As Integer = 0 To ds.Tables("products").Rows.Count - 1
                Dim prd_id As String = ds.Tables("products").Rows(i).Item("prd_id").ToString()
                Dim prd_name As String = ds.Tables("products").Rows(i).Item("prd_name").ToString()
                Dim prd_price As String = ds.Tables("products").Rows(i).Item("prd_price").ToString()
                Dim prd_qty As String = ds.Tables("products").Rows(i).Item("prd_qty").ToString()

                dgv.Rows.Add(prd_name, prd_price, prd_qty, prd_id)
            Next



        Catch ex As Exception

        End Try

        Return

    End Sub

End Module
