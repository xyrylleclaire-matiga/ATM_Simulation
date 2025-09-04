Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            dbConnection.connection()

            Dim query As String = "SELECT * FROM userinfo WHERE AccountNumber = @accNum AND PIN = @pin"
            dbConnection.cmd = New MySqlCommand(query, dbConnection.con)
            dbConnection.cmd.Parameters.AddWithValue("@accNum", txtAccNum.Text.Trim())
            dbConnection.cmd.Parameters.AddWithValue("@pin", txtPIN.Text.Trim())

            dbConnection.dr = dbConnection.cmd.ExecuteReader()

            If dbConnection.dr.Read() Then
                dbConnection.LoggedInAccNum = txtAccNum.Text.Trim()
                dbConnection.dr.Close()
                dbConnection.con.Close()
                Dim mainForm As New frmMain()
                mainForm.Show()
                Me.Hide()
                txtAccNum.Clear()
                txtPIN.Clear()
            Else
                dbConnection.dr.Close()
                dbConnection.con.Close()
                MessageBox.Show("Invalid Account Number or PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAccNum.Clear()
                txtPIN.Clear()
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If dbConnection.con.State = ConnectionState.Open Then
                dbConnection.con.Close()
            End If
        End Try
    End Sub

End Class
