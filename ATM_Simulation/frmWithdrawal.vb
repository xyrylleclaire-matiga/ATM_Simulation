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
            MessageBox.Show("Withdrawal amount exceeds the maximum limit of 10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

            If rowsAffected > 0 Then
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

    ''FORMAT 0,000
    'Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
    '    Dim raw As String = txtAmount.Text.Replace(",", "")
    '    Dim value As Double
    '    If Double.TryParse(raw, value) Then
    '        txtAmount.Text = String.Format("{0:N2}", value)
    '        txtAmount.SelectionStart = txtAmount.Text.Length
    '    End If
    'End Sub

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

    'Withdraw Button
    Private Sub lblWithdraw_Click(sender As Object, e As EventArgs) Handles lblWithdraw.Click
        Withdraw()
    End Sub

    'Cancel Button
    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub txtWithdraw_Leave(sender As Object, e As EventArgs) Handles txtAmount.Leave
        Dim raw As String = txtAmount.Text.Replace(",", "")
        Dim value As Double
        If Double.TryParse(raw, value) Then
            txtAmount.Text = value.ToString("N2")
        End If
    End Sub


    'Decimal 'to
    Private Sub lblDecimal_Click(sender As Object, e As EventArgs) Handles lblDecimal.Click
        If txtAmount.Focused AndAlso Not txtAmount.Text.Contains(".") Then
            txtAmount.AppendText(".")
        End If
    End Sub

    'NUMPAD BUTTONS
    Private Sub lblNo1_Click(sender As Object, e As EventArgs) Handles lblNo1.Click
        txtAmount.AppendText("1")
    End Sub
    Private Sub lblNo2_Click(sender As Object, e As EventArgs) Handles lblNo2.Click
        txtAmount.AppendText("2")
    End Sub
    Private Sub lblNo3_Click(sender As Object, e As EventArgs) Handles lblNo3.Click
        txtAmount.AppendText("3")
    End Sub
    Private Sub lblNo4_Click(sender As Object, e As EventArgs) Handles lblNo4.Click
        txtAmount.AppendText("4")
    End Sub
    Private Sub lblNo5_Click(sender As Object, e As EventArgs) Handles lblNo5.Click
        txtAmount.AppendText("5")
    End Sub
    Private Sub lblNo6_Click(sender As Object, e As EventArgs) Handles lblNo6.Click
        txtAmount.AppendText("6")
    End Sub
    Private Sub lblNo7_Click(sender As Object, e As EventArgs) Handles lblNo7.Click
        txtAmount.AppendText("7")
    End Sub
    Private Sub lblNo8_Click(sender As Object, e As EventArgs) Handles lblNo8.Click
        txtAmount.AppendText("8")
    End Sub
    Private Sub lblNo9_Click(sender As Object, e As EventArgs) Handles lblNo9.Click
        txtAmount.AppendText("9")
    End Sub
    Private Sub lblNo0_Click(sender As Object, e As EventArgs) Handles lblNo0.Click
        txtAmount.AppendText("0")
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        txtAmount.Text = "500.00"
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        txtAmount.Text = "1000.00"
    End Sub

    Private Sub btn2000_Click(sender As Object, e As EventArgs) Handles btn2000.Click
        txtAmount.Text = "2000.00"
    End Sub

    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        txtAmount.Text = "5000.00"
    End Sub

    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click
        txtAmount.Text = "10000.00"
    End Sub

    Private Sub btnOtherAmount_Click(sender As Object, e As EventArgs) Handles btnOtherAmount.Click
        txtAmount.Focus()
    End Sub
End Class