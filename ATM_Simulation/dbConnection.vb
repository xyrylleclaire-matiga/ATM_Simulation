﻿Imports MySql.Data.MySqlClient

Module dbConnection

    Public con As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String
 Public LoggedInAccNum As String
    Public Sub connection()

        If con.State = ConnectionState.Open Then
            ' Connection already open, do nothing
        Else
            con.ConnectionString = "server=localhost;user=root;password=;database=ATM_Simulation"
            con.Open()
        End If
    End Sub




End Module
