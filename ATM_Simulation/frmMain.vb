Imports MySql.Data.MySqlClient

Public Class frmMain

    Private Sub userDetails()
        Try
            dbConnection.connection()
            Dim query As String = "SELECT * FROM userinfo WHERE AccountNumber = @accNum"
            dbConnection.cmd = New MySqlCommand(query, dbConnection.con)
            dbConnection.cmd.Parameters.AddWithValue("@accNum", dbConnection.LoggedInAccNum)
            dbConnection.dr = dbConnection.cmd.ExecuteReader()
            If dbConnection.dr.Read() Then
                lblUser.Text = dbConnection.dr("FirstName").ToString()
                lblAccountNumberDisplay.Text = dbConnection.dr("AccountNumber").ToString()
            End If
            dbConnection.dr.Close()
            dbConnection.con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If dbConnection.con.State = ConnectionState.Open Then
                dbConnection.con.Close()
            End If
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnBalanceInquiry_Click(sender As Object, e As EventArgs) Handles btnBalanceInquiry.Click
        frmBalanceInquiry.Show()
        Me.Hide()

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        frmDeposit.Show()
        Me.Hide()
    End Sub

    Private Sub btnWithdrawal_Click(sender As Object, e As EventArgs) Handles btnWithdrawal.Click
        frmWithdrawal.Show()
        Me.Hide()
    End Sub

    Private Sub btnMiniStatement_Click(sender As Object, e As EventArgs) Handles btnMiniStatement.Click
        frmMiniStatement.Show()
        Me.Hide()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userDetails()
    End Sub
End Class