Imports MySql.Data.MySqlClient

Public Class frmWithdrawal

    'Function ng withdraw logic
    Private Sub Withdraw()
        Dim withdrawAmount As Double
        frmBalanceInquiry.LoadBalance()

        If Not Double.TryParse(txtAmount.Text.Trim(), withdrawAmount) OrElse withdrawAmount <= 0 Then
            MessageBox.Show("Please enter a valid withdrawal amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Return
        End If

        If withdrawAmount > 10000 Then
            MessageBox.Show("Deposit amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            txtAmount.Clear()
            Return
        End If


        Try
            Call connection()

            Dim cmdCheckBalance As New MySqlCommand("SELECT BalanceAmount FROM tblaccountbalance WHERE AccountNumber = @acc", con)
            cmdCheckBalance.Parameters.AddWithValue("@acc", LoggedInAccNum)
            Dim currentBalance As Double = Convert.ToDouble(cmdCheckBalance.ExecuteScalar())
            If withdrawAmount > currentBalance Then
                MessageBox.Show("Insufficient balance for this withdrawal.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmount.Focus()
                txtAmount.Clear()
                Return
            End If

            Dim transaction = con.BeginTransaction()
            cmd = New MySqlCommand()
            cmd.Connection = con
            cmd.Transaction = transaction

            sql = "UPDATE tblaccountbalance SET BalanceAmount = BalanceAmount - @withdraw WHERE AccountNumber = @acc"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@withdraw", withdrawAmount)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 And rowsAffected <= 10000 Then
                transaction.Commit()
                MessageBox.Show("Withdraw successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAmount.Clear()
            Else
                transaction.Rollback()
                MessageBox.Show("Withdraw failed. Account not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error during withdraw: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    'Withdraw button
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Withdraw()
    End Sub

    'Cancel Button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    'Numpad Buttons
    Private Sub lbl1_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("1")
    End Sub
    Private Sub lbl2_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("2")
    End Sub
    Private Sub lbl3_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("3")
    End Sub
    Private Sub lbl4_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("4")
    End Sub
    Private Sub lbl5_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("5")
    End Sub
    Private Sub lbl6_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("6")
    End Sub
    Private Sub lbl7_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("7")
    End Sub
    Private Sub lbl8_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("8")
    End Sub
    Private Sub lbl9_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("9")
    End Sub
    Private Sub lbl0_Click(sender As Object, e As EventArgs)
        txtAmount.AppendText("0")
    End Sub

    'FORMAT 0,000
    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        Dim raw As String = txtAmount.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtAmount.Text = String.Format("{0:N0}", value)
            txtAmount.SelectionStart = txtAmount.Text.Length
        End If
    End Sub

    'Clear Button
    Private Sub lblClear_Click_1(sender As Object, e As EventArgs) Handles lblClear.Click
        txtAmount.Clear()
    End Sub

    'Delete Button
    Private Sub lblDel_Click(sender As Object, e As EventArgs) Handles lblDel.Click
        Dim pos As String = txtAmount.Text.Length
        If pos > 0 Then
            txtAmount.Text = txtAmount.Text.Remove(pos - 1, 1)
            txtAmount.SelectionStart = txtAmount.Text.Length
        End If
    End Sub

End Class