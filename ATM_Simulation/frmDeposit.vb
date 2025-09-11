Imports System.Transactions
Imports MySql.Data.MySqlClient

Public Class frmDeposit

    Private Sub Deposit()
        Dim depositAmount As Double

        If Not Double.TryParse(txtDepositAmount.Text.Trim(), depositAmount) OrElse depositAmount <= 0 Then
            MessageBox.Show("Please enter a valid deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDepositAmount.Focus()
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

            sql = "UPDATE accountbalance SET BalanceAmount = BalanceAmount + @deposit WHERE AccountNumber = @acc"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@deposit", depositAmount)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 And rowsAffected <= 10000 Then
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

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Deposit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        txtDepositAmount.AppendText("1")
    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs) Handles lbl2.Click
        txtDepositAmount.AppendText("2")
    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs) Handles lbl3.Click
        txtDepositAmount.AppendText("3")
    End Sub

    Private Sub lbl4_Click(sender As Object, e As EventArgs) Handles lbl4.Click
        txtDepositAmount.AppendText("4")
    End Sub

    Private Sub lbl5_Click(sender As Object, e As EventArgs) Handles lbl5.Click
        txtDepositAmount.AppendText("5")
    End Sub

    Private Sub lbl6_Click(sender As Object, e As EventArgs) Handles lbl6.Click
        txtDepositAmount.AppendText("6")
    End Sub

    Private Sub lbl7_Click(sender As Object, e As EventArgs) Handles lbl7.Click
        txtDepositAmount.AppendText("7")
    End Sub

    Private Sub lbl8_Click(sender As Object, e As EventArgs) Handles lbl8.Click
        txtDepositAmount.AppendText("8")
    End Sub

    Private Sub lbl9_Click(sender As Object, e As EventArgs) Handles lbl9.Click
        txtDepositAmount.AppendText("9")
    End Sub

    Private Sub lbl0_Click(sender As Object, e As EventArgs) Handles lbl0.Click
        txtDepositAmount.AppendText("0")
    End Sub


    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        txtDepositAmount.Clear()
    End Sub

    Private Sub txtDepositAmount_TextChanged(sender As Object, e As EventArgs) Handles txtDepositAmount.TextChanged
        Dim raw As String = txtDepositAmount.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtDepositAmount.Text = String.Format("{0:N0}", value)
            txtDepositAmount.SelectionStart = txtDepositAmount.Text.Length
        End If

    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs)
        frmMain.Show
        Hide
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim pos As String = txtDepositAmount.Text.Length
        If pos > 0 Then
            txtDepositAmount.Text = txtDepositAmount.Text.Remove(pos - 1, 1)
            txtDepositAmount.SelectionStart = txtDepositAmount.Text.Length
        End If
    End Sub
End Class
