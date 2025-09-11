Imports MySql.Data.MySqlClient

Public Class frmWithdrawal

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

            Dim cmdCheckBalance As New MySqlCommand("SELECT BalanceAmount FROM accountbalance WHERE AccountNumber = @acc", con)
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

            sql = "UPDATE accountbalance SET BalanceAmount = BalanceAmount - @withdraw WHERE AccountNumber = @acc"
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

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Withdraw()
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        txtAmount.AppendText("1")
    End Sub

    Private Sub lbl2_Click(sender As Object, e As EventArgs) Handles lbl2.Click
        txtAmount.AppendText("2")
    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs) Handles lbl3.Click
        txtAmount.AppendText("3")
    End Sub

    Private Sub lbl4_Click(sender As Object, e As EventArgs) Handles lbl4.Click
        txtAmount.AppendText("4")
    End Sub

    Private Sub lbl5_Click(sender As Object, e As EventArgs) Handles lbl5.Click
        txtAmount.AppendText("5")
    End Sub

    Private Sub lbl6_Click(sender As Object, e As EventArgs) Handles lbl6.Click
        txtAmount.AppendText("6")
    End Sub

    Private Sub lbl7_Click(sender As Object, e As EventArgs) Handles lbl7.Click
        txtAmount.AppendText("7")
    End Sub

    Private Sub lbl8_Click(sender As Object, e As EventArgs) Handles lbl8.Click
        txtAmount.AppendText("8")
    End Sub

    Private Sub lbl9_Click(sender As Object, e As EventArgs) Handles lbl9.Click
        txtAmount.AppendText("9")
    End Sub

    Private Sub lbl0_Click(sender As Object, e As EventArgs) Handles lbl0.Click
        txtAmount.AppendText("0")
    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        txtAmount.Clear()
    End Sub

End Class