Imports System.Transactions
Imports MySql.Data.MySqlClient

Public Class frmDeposit

    'Function ng deposit logic
    Private Sub Deposit()
        Dim depositAmount As Double

        If Not Double.TryParse(txtDepositAmount.Text.Trim(), depositAmount) OrElse depositAmount <= 0 Then
            MessageBox.Show("Please enter a valid deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Focus()
            txtDepositAmount.Clear()
            Return
        End If

        If depositAmount > 10000 Then
            MessageBox.Show("Deposit amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Focus()
            txtDepositAmount.Clear()
            Return
        End If


        Try
            Call connection()

            Dim transaction = con.BeginTransaction()
            cmd = New MySqlCommand()
            cmd.Connection = con
            cmd.Transaction = transaction

            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount + @deposit WHERE AccountNumber = @acc"
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

                txtDepositAmount.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Error during deposit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepositAmount.Clear()
        Finally
            con.Close()
        End Try
    End Sub


    'Cancel Button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    'FORMAT 0,000
    Private Sub txtDeposit_Leave(sender As Object, e As EventArgs) Handles txtDepositAmount.Leave
        Dim raw As String = txtDepositAmount.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtDepositAmount.Text = value.ToString("N2")
        Else
            txtDepositAmount.Text = "0.00"
        End If
    End Sub

    ' Keypad Buttons
    Private Sub lblNo1_Click(sender As Object, e As EventArgs) Handles lblNo1.Click
        txtDepositAmount.AppendText("1")
    End Sub

    Private Sub lblNo2_Click(sender As Object, e As EventArgs) Handles lblNo2.Click
        txtDepositAmount.AppendText("2")
    End Sub
    Private Sub lblNo3_Click(sender As Object, e As EventArgs) Handles lblNo3.Click
        txtDepositAmount.AppendText("3")
    End Sub
    Private Sub lblNo4_Click(sender As Object, e As EventArgs) Handles lblNo4.Click
        txtDepositAmount.AppendText("4")
    End Sub
    Private Sub lblNo5_Click(sender As Object, e As EventArgs) Handles lblNo5.Click
        txtDepositAmount.AppendText("5")
    End Sub
    Private Sub lblNo6_Click(sender As Object, e As EventArgs) Handles lblNo6.Click
        txtDepositAmount.AppendText("6")
    End Sub
    Private Sub lblNo7_Click(sender As Object, e As EventArgs) Handles lblNo7.Click
        txtDepositAmount.AppendText("7")
    End Sub
    Private Sub lblNo8_Click(sender As Object, e As EventArgs) Handles lblNo8.Click
        txtDepositAmount.AppendText("8")
    End Sub
    Private Sub lblNo9_Click(sender As Object, e As EventArgs) Handles lblNo9.Click
        txtDepositAmount.AppendText("9")
    End Sub
    Private Sub lblNo0_Click(sender As Object, e As EventArgs) Handles lblNo0.Click
        txtDepositAmount.AppendText("0")
    End Sub


    'Deposit Button
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Deposit()
    End Sub


    ' Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDepositAmount.Clear()
    End Sub


    'Del Button
    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        Dim pos As Integer = txtDepositAmount.Text.Length
        If pos > 0 Then
            txtDepositAmount.Text = txtDepositAmount.Text.Remove(pos - 1, 1)
            txtDepositAmount.SelectionStart = txtDepositAmount.Text.Length
        End If
    End Sub

    Private Sub lblDecimal_Click(sender As Object, e As EventArgs) Handles lblDecimal.Click
        If txtDepositAmount.Focused AndAlso Not txtDepositAmount.Text.Contains(".") Then
            txtDepositAmount.AppendText(".")
        End If
    End Sub

End Class
