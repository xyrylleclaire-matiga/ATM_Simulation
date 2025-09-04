Imports MySql.Data.MySqlClient

Public Class frmDeposit

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim depositAmount As Double

        ' Validate input
        If Not Double.TryParse(txtDepositAmount.Text.Trim(), depositAmount) OrElse depositAmount <= 0 Then
            MessageBox.Show("Please enter a valid deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Focus()
            Return
        End If

        Try
            ' Open DB connection
            Call connection()

            ' Start transaction for safety (optional)
            Dim transaction = con.BeginTransaction()
            cmd = New MySqlCommand()
            cmd.Connection = con
            cmd.Transaction = transaction

            ' Update balance (add the deposit amount)
            sql = "UPDATE accountbalance SET BalanceAmount = BalanceAmount + @deposit WHERE AccountNumber = @acc"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@deposit", depositAmount)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                transaction.Commit()
                MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDepositAmount.Clear()
            Else
                transaction.Rollback()
                MessageBox.Show("Deposit failed. Account not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during deposit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Navigate back to main form or previous form
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
